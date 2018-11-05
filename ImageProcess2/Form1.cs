using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 编写者：欧连红
/// 实现功能：对图片进行裁剪，制作圆形图片并让其进行旋转（旋转功能尚且有些bug、待完善）
/// </summary>
namespace ImageProcess2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //图形类
        Graphics g;
        int dashOffset = 0;//偏移量
        Point clickPoint;
        bool isCreateAvatar;//是否制作头像
        //Rectangle rect;
        int w, h,size;
        Image newImage;


        private void timer1_Tick(object sender, EventArgs e)
        {
            dashOffset++;
            picOrigin.Invalidate();
        }

        Bitmap bmpOriginal;
        //打开图像
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            bmpOriginal = new Bitmap(ofd.FileName);
            picOrigin.BackgroundImage = bmpOriginal;
        }
        
        //保存
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            picRectangle.BackgroundImage.Save(sfd.FileName);
            
        }
        private void picOrigin_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;//画板

            Pen blackPen = new Pen(Color.White, 5);//自己做笔
            //blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;//笔为虚线custom 自己定义与下面dashpattern有关
           // blackPen.DashPattern = new float[] { 4, 4 };//两线的间距
            //blackPen.DashOffset = dashOffset;//偏移量
            g.DrawRectangle(blackPen, clickPoint.X, clickPoint.Y, size, size);

        }
        private void picOrigin_MouseDown(object sender, MouseEventArgs e)
        {
            isCreateAvatar = true;
            clickPoint = new Point(e.X, e.Y);//起始点
            timerPic.Enabled = true;
        }

        private void picOrigin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCreateAvatar)
            {
                w =Math.Abs( e.X-clickPoint.X);
                h = Math.Abs(clickPoint.Y-e.Y);
                size = w < h ? w : h;
                w = size;
                h = size;
                picOrigin.Invalidate();
            }
        }

        Bitmap bmpRound;
        private void picOrigin_MouseUp(object sender, MouseEventArgs e)
        {
            if (isCreateAvatar == true)
            {
                isCreateAvatar = false;
                //正方形
                Bitmap bmpRect = new Bitmap(w, h);
                Console.WriteLine(w.ToString());
                Console.WriteLine(h.ToString());
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Color c = bmpOriginal.GetPixel(clickPoint.X + i, clickPoint.Y + j);
                        bmpRect.SetPixel(i, j, c);
                    }
                }
                picRectangle.BackgroundImage = bmpRect;
                //圆形
                bmpRound = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {

                        Color c = bmpOriginal.GetPixel(clickPoint.X + i, clickPoint.Y + j);
                        bmpRound.SetPixel(i, j, c);
                    }
                }
                Image image = bmpRound;
                 newImage = CutEllipse(image, new Rectangle(0, 0, w, h), new Size(w, h));
                picRound.BackgroundImage = newImage;
                picRotaRound.BackgroundImage = newImage;
                picLittle.BackgroundImage = bmpRect;
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(picLittle.ClientRectangle);
                Region region = new Region(gp);
                picLittle.Region = region;
                gp.Dispose();
                region.Dispose();
               
            }
        }
        //将图片裁切呈圆形
        private Image CutEllipse(Image img, Rectangle rec, Size size) {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }
        int angle = 5;
        //旋转按钮
        private void btnRotal_Click(object sender, EventArgs e)
        {
            timerRoat.Enabled = true;
          
        }
        //旋转图片的计时事件
        private void timerRoat_Tick(object sender, EventArgs e)
        {
           
            angle += 2;
            var btn = sender as Button;
            Graphics graphics = null;
            try
            {
                //假设待处理的矩形 长宽为
                var w = 120;
                var h = 60;
                //创建graphics
                graphics = picRotaRound.CreateGraphics(); ;//pictureBox1为界面中一个PictureBox控件
                graphics.Clear(Color.Gray);
                //原始位置
                //***第一步***
                //将graphics坐标原点移到矩形中心点
                graphics.TranslateTransform(w / 2, h / 2);
                //***第二步***
                //graphics旋转相应的角度(绕当前原点)
                graphics.RotateTransform(angle);        
                //***每三步***
                //恢复graphics在水平和垂直方向的平移(沿当前原点)
                graphics.TranslateTransform(-w / 2, -h / 2);
                //重至绘图的所有变换
                graphics.ResetTransform();
                graphics.Save();
                //***结束***
                picRotaRound.BackgroundImage = GetRotateImage(newImage, angle);
                picLittle.BackgroundImage = GetRotateImage(newImage, angle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (graphics != null)
                    graphics.Dispose();
            }
           

        }
       
        //获得旋转后的图形
        public Image GetRotateImage(Image srcImage, int angle)
        {
            angle = angle % 360;
            //原图的宽和高
            int srcWidth = srcImage.Width;
            int srcHeight = srcImage.Height;
            //图像旋转之后所占区域宽和高
            Rectangle rotateRec = new Rectangle(0,0,picRotaRound.Width-30,picRotaRound.Height-30);
                //GetRotateRectangle(srcWidth, srcHeight, angle);
            int rotateWidth = rotateRec.Width;
            int rotateHeight = rotateRec.Height;
            //目标位图
            Bitmap destImage = null;
            Graphics graphics = null;
            try
            {
                //定义画布，宽高为图像旋转后的宽高
                destImage = new Bitmap(rotateWidth, rotateHeight);
                //graphics根据destImage创建，因此其原点此时在destImage左上角
                graphics = Graphics.FromImage(destImage);
                //要让graphics围绕某矩形中心点旋转N度，分三步
                //第一步，将graphics坐标原点移到矩形中心点,假设其中点坐标（x,y）
                //第二步，graphics旋转相应的角度(沿当前原点)
                //第三步，移回（-x,-y）
                //获取画布中心点
                Point centerPoint = new Point(rotateWidth / 2, rotateHeight / 2);
                //将graphics坐标原点移到中心点
                graphics.TranslateTransform(centerPoint.X, centerPoint.Y);
                //graphics旋转相应的角度(绕当前原点)
                graphics.RotateTransform(angle);
                //恢复graphics在水平和垂直方向的平移(沿当前原点)
                graphics.TranslateTransform(-centerPoint.X, -centerPoint.Y);
                //此时已经完成了graphics的旋转

                //计算:如果要将源图像画到画布上且中心与画布中心重合，需要的偏移量
                Point Offset = new Point((rotateWidth - srcWidth) / 2, (rotateHeight - srcHeight) / 2);
                //将源图片画到rect里（rotateRec的中心）
                graphics.DrawImage(srcImage, new Rectangle(Offset.X, Offset.Y, srcWidth, srcHeight));
                //重至绘图的所有变换
                graphics.ResetTransform();
                graphics.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (graphics != null)
                    graphics.Dispose();
            }
            return destImage;
         
        }

    }
}

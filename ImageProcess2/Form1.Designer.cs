namespace ImageProcess2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerPic = new System.Windows.Forms.Timer(this.components);
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.picRectangle = new System.Windows.Forms.PictureBox();
            this.picRound = new System.Windows.Forms.PictureBox();
            this.picRotaRound = new System.Windows.Forms.PictureBox();
            this.picFilmRound = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnRotal = new System.Windows.Forms.Button();
            this.timerRoat = new System.Windows.Forms.Timer(this.components);
            this.picLittle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotaRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLittle)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPic
            // 
            this.timerPic.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picOrigin
            // 
            this.picOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrigin.Location = new System.Drawing.Point(65, 42);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(601, 470);
            this.picOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrigin.TabIndex = 0;
            this.picOrigin.TabStop = false;
            this.picOrigin.Paint += new System.Windows.Forms.PaintEventHandler(this.picOrigin_Paint);
            this.picOrigin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picOrigin_MouseDown);
            this.picOrigin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOrigin_MouseMove);
            this.picOrigin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picOrigin_MouseUp);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(54, 584);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(133, 35);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "打开";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // picRectangle
            // 
            this.picRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRectangle.ErrorImage = null;
            this.picRectangle.Location = new System.Drawing.Point(767, 42);
            this.picRectangle.Name = "picRectangle";
            this.picRectangle.Size = new System.Drawing.Size(270, 270);
            this.picRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangle.TabIndex = 0;
            this.picRectangle.TabStop = false;
            // 
            // picRound
            // 
            this.picRound.BackColor = System.Drawing.Color.Transparent;
            this.picRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRound.Location = new System.Drawing.Point(767, 390);
            this.picRound.Name = "picRound";
            this.picRound.Size = new System.Drawing.Size(270, 270);
            this.picRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRound.TabIndex = 0;
            this.picRound.TabStop = false;
            // 
            // picRotaRound
            // 
            this.picRotaRound.BackColor = System.Drawing.Color.Transparent;
            this.picRotaRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRotaRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRotaRound.Location = new System.Drawing.Point(1092, 42);
            this.picRotaRound.Name = "picRotaRound";
            this.picRotaRound.Size = new System.Drawing.Size(270, 270);
            this.picRotaRound.TabIndex = 0;
            this.picRotaRound.TabStop = false;
            // 
            // picFilmRound
            // 
            this.picFilmRound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFilmRound.BackgroundImage")));
            this.picFilmRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFilmRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilmRound.Location = new System.Drawing.Point(1092, 390);
            this.picFilmRound.Name = "picFilmRound";
            this.picFilmRound.Size = new System.Drawing.Size(270, 270);
            this.picFilmRound.TabIndex = 0;
            this.picFilmRound.TabStop = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(233, 584);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(133, 35);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "保存";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnRotal
            // 
            this.btnRotal.Location = new System.Drawing.Point(425, 584);
            this.btnRotal.Name = "btnRotal";
            this.btnRotal.Size = new System.Drawing.Size(133, 35);
            this.btnRotal.TabIndex = 1;
            this.btnRotal.Text = "旋转";
            this.btnRotal.UseVisualStyleBackColor = true;
            this.btnRotal.Click += new System.EventHandler(this.btnRotal_Click);
            // 
            // timerRoat
            // 
            this.timerRoat.Tick += new System.EventHandler(this.timerRoat_Tick);
            // 
            // picLittle
            // 
            this.picLittle.BackColor = System.Drawing.Color.Transparent;
            this.picLittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLittle.Location = new System.Drawing.Point(1172, 482);
            this.picLittle.Name = "picLittle";
            this.picLittle.Size = new System.Drawing.Size(111, 110);
            this.picLittle.TabIndex = 2;
            this.picLittle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 743);
            this.Controls.Add(this.picLittle);
            this.Controls.Add(this.btnRotal);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.picFilmRound);
            this.Controls.Add(this.picRotaRound);
            this.Controls.Add(this.picRound);
            this.Controls.Add(this.picRectangle);
            this.Controls.Add(this.picOrigin);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotaRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLittle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerPic;
        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox picRectangle;
        private System.Windows.Forms.PictureBox picRound;
        private System.Windows.Forms.PictureBox picRotaRound;
        private System.Windows.Forms.PictureBox picFilmRound;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnRotal;
        private System.Windows.Forms.Timer timerRoat;
        private System.Windows.Forms.PictureBox picLittle;
    }
}


namespace CU_event
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 50;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "로그인";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 5;
            this.bunifuThinButton21.IdleCornerRadius = 50;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(58, 125);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(366, 70);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineThickness = 1;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(59, 22);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(365, 44);
            this.bunifuMaterialTextbox1.TabIndex = 3;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineThickness = 1;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(59, 74);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(365, 44);
            this.bunifuMaterialTextbox2.TabIndex = 4;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox2.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 163);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "쿠폰받기";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 5;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(47)))), ((int)(((byte)(141)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(234, 81);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(184, 56);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(271, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "5,000원\r\n금액 상품권\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


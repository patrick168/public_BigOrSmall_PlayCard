namespace Guest_Big_Small
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsmall = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnbig = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.lbwinlose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmoney = new System.Windows.Forms.Label();
            this.tbmoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtoptext = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textL = new System.Windows.Forms.Label();
            this.textR = new System.Windows.Forms.Label();
            this.leftWin = new System.Windows.Forms.Label();
            this.rightWin = new System.Windows.Forms.Label();
            this.DealTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 121);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnsmall
            // 
            this.btnsmall.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsmall.Location = new System.Drawing.Point(254, 242);
            this.btnsmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(51, 50);
            this.btnsmall.TabIndex = 16;
            this.btnsmall.Text = "小";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(224, 427);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(113, 50);
            this.btnDeal.TabIndex = 19;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnbig
            // 
            this.btnbig.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbig.Location = new System.Drawing.Point(254, 171);
            this.btnbig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(51, 50);
            this.btnbig.TabIndex = 20;
            this.btnbig.Text = "大";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnend.Location = new System.Drawing.Point(595, 422);
            this.btnend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(113, 50);
            this.btnend.TabIndex = 21;
            this.btnend.Text = "結束遊戲";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infolabel.Location = new System.Drawing.Point(619, 314);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(58, 30);
            this.infolabel.TabIndex = 22;
            this.infolabel.Text = "info";
            // 
            // lbwinlose
            // 
            this.lbwinlose.AutoSize = true;
            this.lbwinlose.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbwinlose.Location = new System.Drawing.Point(228, 351);
            this.lbwinlose.Name = "lbwinlose";
            this.lbwinlose.Size = new System.Drawing.Size(133, 30);
            this.lbwinlose.TabIndex = 23;
            this.lbwinlose.Text = "輸贏訊息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(589, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "你的籌碼";
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbmoney.ForeColor = System.Drawing.Color.Blue;
            this.lbmoney.Location = new System.Drawing.Point(600, 167);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(55, 30);
            this.lbmoney.TabIndex = 25;
            this.lbmoney.Text = "100";
            // 
            // tbmoney
            // 
            this.tbmoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmoney.Location = new System.Drawing.Point(605, 259);
            this.tbmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(100, 43);
            this.tbmoney.TabIndex = 26;
            this.tbmoney.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(589, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "押注金額";
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbtoptext.Location = new System.Drawing.Point(67, 35);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(124, 28);
            this.lbtoptext.TabIndex = 27;
            this.lbtoptext.Text = "文字訊息";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(402, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 121);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // textL
            // 
            this.textL.AutoSize = true;
            this.textL.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textL.Location = new System.Drawing.Point(79, 109);
            this.textL.Name = "textL";
            this.textL.Size = new System.Drawing.Size(83, 33);
            this.textL.TabIndex = 28;
            this.textL.Text = "莊家";
            // 
            // textR
            // 
            this.textR.AutoSize = true;
            this.textR.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textR.Location = new System.Drawing.Point(407, 109);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(83, 33);
            this.textR.TabIndex = 29;
            this.textR.Text = "玩家";
            // 
            // leftWin
            // 
            this.leftWin.AutoSize = true;
            this.leftWin.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.leftWin.Location = new System.Drawing.Point(103, 332);
            this.leftWin.Name = "leftWin";
            this.leftWin.Size = new System.Drawing.Size(31, 33);
            this.leftWin.TabIndex = 30;
            this.leftWin.Text = "0";
            // 
            // rightWin
            // 
            this.rightWin.AutoSize = true;
            this.rightWin.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rightWin.Location = new System.Drawing.Point(435, 332);
            this.rightWin.Name = "rightWin";
            this.rightWin.Size = new System.Drawing.Size(31, 33);
            this.rightWin.TabIndex = 30;
            this.rightWin.Text = "0";
            // 
            // DealTest
            // 
            this.DealTest.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealTest.Location = new System.Drawing.Point(404, 427);
            this.DealTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DealTest.Name = "DealTest";
            this.DealTest.Size = new System.Drawing.Size(113, 50);
            this.DealTest.TabIndex = 19;
            this.DealTest.Text = "DealTest";
            this.DealTest.UseVisualStyleBackColor = true;
            this.DealTest.Visible = false;
            this.DealTest.Click += new System.EventHandler(this.DealTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 513);
            this.Controls.Add(this.rightWin);
            this.Controls.Add(this.leftWin);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.textL);
            this.Controls.Add(this.lbtoptext);
            this.Controls.Add(this.tbmoney);
            this.Controls.Add(this.lbmoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbwinlose);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnbig);
            this.Controls.Add(this.DealTest);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnsmall);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "押大小或是牌色";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsmall;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnbig;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label lbwinlose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmoney;
        private System.Windows.Forms.TextBox tbmoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtoptext;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textL;
        private System.Windows.Forms.Label textR;
        private System.Windows.Forms.Label leftWin;
        private System.Windows.Forms.Label rightWin;
        private System.Windows.Forms.Button DealTest;
    }
}


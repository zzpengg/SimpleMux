namespace SimpleMux
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.chineseTitleLabel = new System.Windows.Forms.Label();
            this.englishTitleLabel = new System.Windows.Forms.Label();
            this.InServiceTW = new System.Windows.Forms.Label();
            this.InServiceEN = new System.Windows.Forms.Label();
            this.ContextPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalFare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price25 = new System.Windows.Forms.Button();
            this.price30 = new System.Windows.Forms.Button();
            this.price35 = new System.Windows.Forms.Button();
            this.price40 = new System.Windows.Forms.Button();
            this.price45 = new System.Windows.Forms.Button();
            this.price50 = new System.Windows.Forms.Button();
            this.price55 = new System.Windows.Forms.Button();
            this.price60 = new System.Windows.Forms.Button();
            this.ticket2 = new System.Windows.Forms.Button();
            this.ticket3 = new System.Windows.Forms.Button();
            this.ticket4 = new System.Windows.Forms.Button();
            this.ticket5 = new System.Windows.Forms.Button();
            this.ticket6 = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chineseTitleLabel
            // 
            this.chineseTitleLabel.AutoSize = true;
            this.chineseTitleLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.chineseTitleLabel.Location = new System.Drawing.Point(30, 25);
            this.chineseTitleLabel.Name = "chineseTitleLabel";
            this.chineseTitleLabel.Size = new System.Drawing.Size(370, 25);
            this.chineseTitleLabel.TabIndex = 0;
            this.chineseTitleLabel.Text = "1. 選擇票價及張數 ( 限當日使用 )";
            this.chineseTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chineseTitleLabel.UseMnemonic = false;
            // 
            // englishTitleLabel
            // 
            this.englishTitleLabel.AutoSize = true;
            this.englishTitleLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.englishTitleLabel.Location = new System.Drawing.Point(30, 77);
            this.englishTitleLabel.Name = "englishTitleLabel";
            this.englishTitleLabel.Size = new System.Drawing.Size(273, 25);
            this.englishTitleLabel.TabIndex = 1;
            this.englishTitleLabel.Text = "Select Fare and N of tickets";
            this.englishTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.englishTitleLabel.UseMnemonic = false;
            // 
            // InServiceTW
            // 
            this.InServiceTW.AutoSize = true;
            this.InServiceTW.BackColor = System.Drawing.SystemColors.Control;
            this.InServiceTW.Font = new System.Drawing.Font("新細明體", 12F);
            this.InServiceTW.ForeColor = System.Drawing.Color.Green;
            this.InServiceTW.Location = new System.Drawing.Point(54, 140);
            this.InServiceTW.Name = "InServiceTW";
            this.InServiceTW.Size = new System.Drawing.Size(69, 20);
            this.InServiceTW.TabIndex = 2;
            this.InServiceTW.Text = "營運中";
            // 
            // InServiceEN
            // 
            this.InServiceEN.AutoSize = true;
            this.InServiceEN.Font = new System.Drawing.Font("新細明體", 12F);
            this.InServiceEN.ForeColor = System.Drawing.Color.Green;
            this.InServiceEN.Location = new System.Drawing.Point(54, 169);
            this.InServiceEN.Name = "InServiceEN";
            this.InServiceEN.Size = new System.Drawing.Size(83, 20);
            this.InServiceEN.TabIndex = 3;
            this.InServiceEN.Text = "In Service";
            // 
            // ContextPrice
            // 
            this.ContextPrice.AutoSize = true;
            this.ContextPrice.Font = new System.Drawing.Font("新細明體", 12F);
            this.ContextPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContextPrice.Location = new System.Drawing.Point(32, 249);
            this.ContextPrice.Name = "ContextPrice";
            this.ContextPrice.Size = new System.Drawing.Size(283, 20);
            this.ContextPrice.TabIndex = 4;
            this.ContextPrice.Text = "1. 單程票價 ( 元 ) ticket price (NT)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "2. 張數 (1張免選) N of tickets (if 2 or more)";
            // 
            // price20
            // 
            this.price20.BackColor = System.Drawing.Color.Orange;
            this.price20.Font = new System.Drawing.Font("新細明體", 11F);
            this.price20.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price20.Location = new System.Drawing.Point(35, 304);
            this.price20.Name = "price20";
            this.price20.Size = new System.Drawing.Size(65, 48);
            this.price20.TabIndex = 6;
            this.price20.Text = "20";
            this.price20.UseVisualStyleBackColor = false;
            this.price20.Click += new System.EventHandler(this.price20_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.totalFare);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(557, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 89);
            this.panel1.TabIndex = 7;
            // 
            // totalFare
            // 
            this.totalFare.Enabled = false;
            this.totalFare.Location = new System.Drawing.Point(139, 14);
            this.totalFare.Name = "totalFare";
            this.totalFare.Size = new System.Drawing.Size(97, 55);
            this.totalFare.TabIndex = 2;
            this.totalFare.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fare Payable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "應付金額";
            // 
            // price25
            // 
            this.price25.BackColor = System.Drawing.Color.Orange;
            this.price25.Font = new System.Drawing.Font("新細明體", 11F);
            this.price25.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price25.Location = new System.Drawing.Point(130, 304);
            this.price25.Name = "price25";
            this.price25.Size = new System.Drawing.Size(65, 48);
            this.price25.TabIndex = 8;
            this.price25.Text = "25";
            this.price25.UseVisualStyleBackColor = false;
            this.price25.Click += new System.EventHandler(this.price25_Click);
            // 
            // price30
            // 
            this.price30.BackColor = System.Drawing.Color.Orange;
            this.price30.Font = new System.Drawing.Font("新細明體", 11F);
            this.price30.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price30.Location = new System.Drawing.Point(223, 304);
            this.price30.Name = "price30";
            this.price30.Size = new System.Drawing.Size(65, 48);
            this.price30.TabIndex = 9;
            this.price30.Text = "30";
            this.price30.UseVisualStyleBackColor = false;
            this.price30.Click += new System.EventHandler(this.price30_Click);
            // 
            // price35
            // 
            this.price35.BackColor = System.Drawing.Color.Orange;
            this.price35.Font = new System.Drawing.Font("新細明體", 11F);
            this.price35.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price35.Location = new System.Drawing.Point(317, 304);
            this.price35.Name = "price35";
            this.price35.Size = new System.Drawing.Size(65, 48);
            this.price35.TabIndex = 10;
            this.price35.Text = "35";
            this.price35.UseVisualStyleBackColor = false;
            this.price35.Click += new System.EventHandler(this.price35_Click);
            // 
            // price40
            // 
            this.price40.BackColor = System.Drawing.Color.Orange;
            this.price40.Font = new System.Drawing.Font("新細明體", 11F);
            this.price40.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price40.Location = new System.Drawing.Point(403, 304);
            this.price40.Name = "price40";
            this.price40.Size = new System.Drawing.Size(65, 48);
            this.price40.TabIndex = 11;
            this.price40.Text = "40";
            this.price40.UseVisualStyleBackColor = false;
            this.price40.Click += new System.EventHandler(this.price40_Click);
            // 
            // price45
            // 
            this.price45.BackColor = System.Drawing.Color.Orange;
            this.price45.Font = new System.Drawing.Font("新細明體", 11F);
            this.price45.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price45.Location = new System.Drawing.Point(499, 304);
            this.price45.Name = "price45";
            this.price45.Size = new System.Drawing.Size(65, 48);
            this.price45.TabIndex = 12;
            this.price45.Text = "45";
            this.price45.UseVisualStyleBackColor = false;
            this.price45.Click += new System.EventHandler(this.price45_Click);
            // 
            // price50
            // 
            this.price50.BackColor = System.Drawing.Color.Orange;
            this.price50.Font = new System.Drawing.Font("新細明體", 11F);
            this.price50.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price50.Location = new System.Drawing.Point(591, 304);
            this.price50.Name = "price50";
            this.price50.Size = new System.Drawing.Size(65, 48);
            this.price50.TabIndex = 13;
            this.price50.Text = "50";
            this.price50.UseVisualStyleBackColor = false;
            this.price50.Click += new System.EventHandler(this.price50_Click);
            // 
            // price55
            // 
            this.price55.BackColor = System.Drawing.Color.Orange;
            this.price55.Font = new System.Drawing.Font("新細明體", 11F);
            this.price55.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price55.Location = new System.Drawing.Point(686, 304);
            this.price55.Name = "price55";
            this.price55.Size = new System.Drawing.Size(65, 48);
            this.price55.TabIndex = 14;
            this.price55.Text = "55";
            this.price55.UseVisualStyleBackColor = false;
            this.price55.Click += new System.EventHandler(this.price55_Click);
            // 
            // price60
            // 
            this.price60.BackColor = System.Drawing.Color.Orange;
            this.price60.Font = new System.Drawing.Font("新細明體", 11F);
            this.price60.ForeColor = System.Drawing.SystemColors.Desktop;
            this.price60.Location = new System.Drawing.Point(769, 304);
            this.price60.Name = "price60";
            this.price60.Size = new System.Drawing.Size(65, 48);
            this.price60.TabIndex = 15;
            this.price60.Text = "60";
            this.price60.UseVisualStyleBackColor = false;
            this.price60.Click += new System.EventHandler(this.price60_Click);
            // 
            // ticket2
            // 
            this.ticket2.BackColor = System.Drawing.Color.Orange;
            this.ticket2.Font = new System.Drawing.Font("新細明體", 11F);
            this.ticket2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ticket2.Location = new System.Drawing.Point(35, 431);
            this.ticket2.Name = "ticket2";
            this.ticket2.Size = new System.Drawing.Size(65, 48);
            this.ticket2.TabIndex = 16;
            this.ticket2.Text = "2";
            this.ticket2.UseVisualStyleBackColor = false;
            this.ticket2.Click += new System.EventHandler(this.ticket2_Click);
            // 
            // ticket3
            // 
            this.ticket3.BackColor = System.Drawing.Color.Orange;
            this.ticket3.Font = new System.Drawing.Font("新細明體", 11F);
            this.ticket3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ticket3.Location = new System.Drawing.Point(130, 431);
            this.ticket3.Name = "ticket3";
            this.ticket3.Size = new System.Drawing.Size(65, 48);
            this.ticket3.TabIndex = 17;
            this.ticket3.Text = "3";
            this.ticket3.UseVisualStyleBackColor = false;
            this.ticket3.Click += new System.EventHandler(this.ticket3_Click);
            // 
            // ticket4
            // 
            this.ticket4.BackColor = System.Drawing.Color.Orange;
            this.ticket4.Font = new System.Drawing.Font("新細明體", 11F);
            this.ticket4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ticket4.Location = new System.Drawing.Point(223, 431);
            this.ticket4.Name = "ticket4";
            this.ticket4.Size = new System.Drawing.Size(65, 48);
            this.ticket4.TabIndex = 18;
            this.ticket4.Text = "4";
            this.ticket4.UseVisualStyleBackColor = false;
            this.ticket4.Click += new System.EventHandler(this.ticket4_Click);
            // 
            // ticket5
            // 
            this.ticket5.BackColor = System.Drawing.Color.Orange;
            this.ticket5.Font = new System.Drawing.Font("新細明體", 11F);
            this.ticket5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ticket5.Location = new System.Drawing.Point(317, 431);
            this.ticket5.Name = "ticket5";
            this.ticket5.Size = new System.Drawing.Size(65, 48);
            this.ticket5.TabIndex = 19;
            this.ticket5.Text = "5";
            this.ticket5.UseVisualStyleBackColor = false;
            this.ticket5.Click += new System.EventHandler(this.ticket5_Click);
            // 
            // ticket6
            // 
            this.ticket6.BackColor = System.Drawing.Color.Orange;
            this.ticket6.Font = new System.Drawing.Font("新細明體", 11F);
            this.ticket6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ticket6.Location = new System.Drawing.Point(403, 431);
            this.ticket6.Name = "ticket6";
            this.ticket6.Size = new System.Drawing.Size(65, 48);
            this.ticket6.TabIndex = 20;
            this.ticket6.Text = "6";
            this.ticket6.UseVisualStyleBackColor = false;
            this.ticket6.Click += new System.EventHandler(this.ticket6_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("新細明體", 15F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(681, 410);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 69);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "重選Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.ticket6);
            this.Controls.Add(this.ticket5);
            this.Controls.Add(this.ticket4);
            this.Controls.Add(this.ticket3);
            this.Controls.Add(this.ticket2);
            this.Controls.Add(this.price60);
            this.Controls.Add(this.price55);
            this.Controls.Add(this.price50);
            this.Controls.Add(this.price45);
            this.Controls.Add(this.price40);
            this.Controls.Add(this.price35);
            this.Controls.Add(this.price30);
            this.Controls.Add(this.price25);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContextPrice);
            this.Controls.Add(this.InServiceEN);
            this.Controls.Add(this.InServiceTW);
            this.Controls.Add(this.englishTitleLabel);
            this.Controls.Add(this.chineseTitleLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form";
            this.Text = "20";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chineseTitleLabel;
        private System.Windows.Forms.Label englishTitleLabel;
        private System.Windows.Forms.Label InServiceTW;
        private System.Windows.Forms.Label InServiceEN;
        private System.Windows.Forms.Label ContextPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button price20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button totalFare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button price25;
        private System.Windows.Forms.Button price30;
        private System.Windows.Forms.Button price35;
        private System.Windows.Forms.Button price40;
        private System.Windows.Forms.Button price45;
        private System.Windows.Forms.Button price50;
        private System.Windows.Forms.Button price55;
        private System.Windows.Forms.Button price60;
        private System.Windows.Forms.Button ticket2;
        private System.Windows.Forms.Button ticket3;
        private System.Windows.Forms.Button ticket4;
        private System.Windows.Forms.Button ticket5;
        private System.Windows.Forms.Button ticket6;
        private System.Windows.Forms.Button cancelBtn;
    }
}


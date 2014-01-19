namespace makeDigest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.realmBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.respBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(274, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "MD5(A1)";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(274, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 19);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "nonce";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(260, 19);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "nc";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 71);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(260, 19);
			this.textBox3.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(6, 107);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(179, 19);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "cnonce";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(8, 149);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(260, 19);
			this.textBox5.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "qop";
			// 
			// textBox6
			// 
			this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox6.Location = new System.Drawing.Point(274, 30);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(260, 19);
			this.textBox6.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(274, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "MD5(A2)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(260, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "make";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(274, 71);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(260, 126);
			this.textBox7.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(274, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 12);
			this.label8.TabIndex = 15;
			this.label8.Text = "MD5(response)";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(274, 34);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(260, 19);
			this.textBox8.TabIndex = 16;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(260, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "bruteforce";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(274, 30);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(260, 19);
			this.textBox9.TabIndex = 18;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(191, 105);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "random";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// userNameBox
			// 
			this.userNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userNameBox.Location = new System.Drawing.Point(8, 30);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(260, 19);
			this.userNameBox.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 12);
			this.label9.TabIndex = 21;
			this.label9.Text = "username";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 52);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 12);
			this.label10.TabIndex = 22;
			this.label10.Text = "realm";
			// 
			// realmBox
			// 
			this.realmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.realmBox.Location = new System.Drawing.Point(8, 67);
			this.realmBox.Name = "realmBox";
			this.realmBox.Size = new System.Drawing.Size(260, 19);
			this.realmBox.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 89);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 12);
			this.label11.TabIndex = 24;
			this.label11.Text = "password";
			// 
			// passwordBox
			// 
			this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordBox.Location = new System.Drawing.Point(8, 104);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(260, 19);
			this.passwordBox.TabIndex = 25;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(8, 129);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(260, 23);
			this.button4.TabIndex = 26;
			this.button4.Text = "get MD5(A1)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "POST"});
			this.comboBox1.Location = new System.Drawing.Point(6, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(262, 20);
			this.comboBox1.TabIndex = 27;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 12);
			this.label12.TabIndex = 28;
			this.label12.Text = "method";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 53);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(27, 12);
			this.label13.TabIndex = 29;
			this.label13.Text = "URL";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.userNameBox);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.passwordBox);
			this.groupBox1.Controls.Add(this.realmBox);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(547, 201);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 1";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.urlBox);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 219);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(547, 138);
			this.groupBox2.TabIndex = 31;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Step 2";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 94);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(262, 23);
			this.button5.TabIndex = 31;
			this.button5.Text = "get MD5(A2)";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// urlBox
			// 
			this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.urlBox.Location = new System.Drawing.Point(6, 69);
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(262, 19);
			this.urlBox.TabIndex = 30;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Location = new System.Drawing.Point(12, 363);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(547, 206);
			this.groupBox3.TabIndex = 32;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Step 3";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(274, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 12);
			this.label14.TabIndex = 20;
			this.label14.Text = "HTTP header";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.respBox);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.button2);
			this.groupBox4.Controls.Add(this.textBox9);
			this.groupBox4.Location = new System.Drawing.Point(12, 575);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(547, 99);
			this.groupBox4.TabIndex = 33;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Test";
			// 
			// respBox
			// 
			this.respBox.Location = new System.Drawing.Point(6, 30);
			this.respBox.Name = "respBox";
			this.respBox.Size = new System.Drawing.Size(254, 19);
			this.respBox.TabIndex = 21;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(51, 12);
			this.label15.TabIndex = 20;
			this.label15.Text = "response";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(272, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 19;
			this.label7.Text = "password";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 686);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "makeDigest";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox userNameBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox realmBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox respBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label7;
    }
}


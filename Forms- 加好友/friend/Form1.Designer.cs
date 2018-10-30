namespace friend
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 19);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 34);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "性別:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "生日:";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(97, 166);
            this.birthday.Margin = new System.Windows.Forms.Padding(5);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(264, 34);
            this.birthday.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(365, 19);
            this.Add.Margin = new System.Windows.Forms.Padding(5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(125, 38);
            this.Add.TabIndex = 6;
            this.Add.Text = "新增";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(365, 214);
            this.exit.Margin = new System.Windows.Forms.Padding(5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(109, 74);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(73, 29);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "男性";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(109, 109);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 29);
            this.female.TabIndex = 9;
            this.female.TabStop = true;
            this.female.Text = "女性";
            this.female.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 280);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
    }
}


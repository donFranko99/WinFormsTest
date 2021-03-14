
namespace WinFormsTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelMsg1 = new System.Windows.Forms.Label();
            this.labelMsg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(38, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name\r\n";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(38, 106);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(109, 32);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname\r\n";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(38, 182);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 32);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age\r\n";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(236, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 39);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(236, 106);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 39);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(236, 182);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(200, 39);
            this.textBoxAge.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(111, 270);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 46);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Press me";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelMsg1
            // 
            this.labelMsg1.AutoSize = true;
            this.labelMsg1.Location = new System.Drawing.Point(38, 350);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(128, 32);
            this.labelMsg1.TabIndex = 7;
            this.labelMsg1.Text = "Message 1";
            this.labelMsg1.Click += new System.EventHandler(this.labelMsg1_Click);
            // 
            // labelMsg2
            // 
            this.labelMsg2.AutoSize = true;
            this.labelMsg2.Location = new System.Drawing.Point(38, 416);
            this.labelMsg2.Name = "labelMsg2";
            this.labelMsg2.Size = new System.Drawing.Size(128, 32);
            this.labelMsg2.TabIndex = 8;
            this.labelMsg2.Text = "Message 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 598);
            this.Controls.Add(this.labelMsg2);
            this.Controls.Add(this.labelMsg1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Hello App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelMsg1;
        private System.Windows.Forms.Label labelMsg2;
    }
}


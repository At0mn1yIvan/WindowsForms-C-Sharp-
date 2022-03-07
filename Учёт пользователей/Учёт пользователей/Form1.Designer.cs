
namespace Учёт_пользователей
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Create_B = new System.Windows.Forms.Button();
            this.Show_Hide_B = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBox_User
            // 
            this.textBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User.Location = new System.Drawing.Point(130, 39);
            this.textBox_User.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(229, 24);
            this.textBox_User.TabIndex = 2;
            this.textBox_User.TextChanged += new System.EventHandler(this.textBox_User_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(130, 93);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(229, 24);
            this.textBox_Password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(172, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Are you new here?";
            // 
            // OK_B
            // 
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_B.Location = new System.Drawing.Point(107, 168);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(95, 32);
            this.OK_B.TabIndex = 5;
            this.OK_B.Text = "OK";
            this.OK_B.UseVisualStyleBackColor = true;
            this.OK_B.Click += new System.EventHandler(this.OK_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_B.Location = new System.Drawing.Point(277, 168);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(95, 32);
            this.Exit_B.TabIndex = 6;
            this.Exit_B.Text = "Exit";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click_1);
            // 
            // Create_B
            // 
            this.Create_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_B.Location = new System.Drawing.Point(191, 247);
            this.Create_B.Name = "Create_B";
            this.Create_B.Size = new System.Drawing.Size(95, 34);
            this.Create_B.TabIndex = 7;
            this.Create_B.Text = "Create user";
            this.Create_B.UseVisualStyleBackColor = true;
            this.Create_B.Click += new System.EventHandler(this.Create_B_Click);
            // 
            // Show_Hide_B
            // 
            this.Show_Hide_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.Show_Hide_B.AutoSize = true;
            this.Show_Hide_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Hide_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_Hide_B.Location = new System.Drawing.Point(388, 91);
            this.Show_Hide_B.Name = "Show_Hide_B";
            this.Show_Hide_B.Size = new System.Drawing.Size(51, 26);
            this.Show_Hide_B.TabIndex = 8;
            this.Show_Hide_B.Text = "Show";
            this.Show_Hide_B.UseVisualStyleBackColor = true;
            this.Show_Hide_B.CheckedChanged += new System.EventHandler(this.Show_Hide_B_CheckedChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(468, 318);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Show_Hide_B);
            this.Controls.Add(this.Create_B);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Create_B;
        private System.Windows.Forms.CheckBox Show_Hide_B;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
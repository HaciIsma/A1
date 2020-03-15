namespace A1.View.UC
{
    partial class SignInControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.clearbt = new System.Windows.Forms.Button();
            this.singInbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 46);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(128, 20);
            this.password.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(81, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(128, 20);
            this.username.TabIndex = 22;
            // 
            // clearbt
            // 
            this.clearbt.Location = new System.Drawing.Point(134, 90);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(75, 23);
            this.clearbt.TabIndex = 27;
            this.clearbt.Text = "Clear";
            this.clearbt.UseVisualStyleBackColor = true;
            this.clearbt.Click += new System.EventHandler(this.clearbt_Click);
            // 
            // singInbtn
            // 
            this.singInbtn.Location = new System.Drawing.Point(21, 90);
            this.singInbtn.Name = "singInbtn";
            this.singInbtn.Size = new System.Drawing.Size(75, 23);
            this.singInbtn.TabIndex = 26;
            this.singInbtn.Text = "Sign In";
            this.singInbtn.UseVisualStyleBackColor = true;
            this.singInbtn.Click += new System.EventHandler(this.singInbtn_Click);
            // 
            // SignInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearbt);
            this.Controls.Add(this.singInbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Name = "SignInControl";
            this.Size = new System.Drawing.Size(221, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button clearbt;
        private System.Windows.Forms.Button singInbtn;
    }
}

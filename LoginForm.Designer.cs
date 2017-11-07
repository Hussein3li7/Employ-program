namespace PersonInformation
{
    partial class LoginForm
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
            this._logo = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btCancle = new System.Windows.Forms.Button();
            this.btLoign = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _logo
            // 
            this._logo.AutoSize = true;
            this._logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this._logo.Location = new System.Drawing.Point(139, 52);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(142, 55);
            this._logo.TabIndex = 11;
            this._logo.Text = "Login";
            // 
            // btCancle
            // 
            this.btCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btCancle.FlatAppearance.BorderSize = 2;
            this.btCancle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btCancle.Location = new System.Drawing.Point(163, 296);
            this.btCancle.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(100, 35);
            this.btCancle.TabIndex = 13;
            this.btCancle.Text = "Close";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // btLoign
            // 
            this.btLoign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btLoign.FlatAppearance.BorderSize = 2;
            this.btLoign.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btLoign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btLoign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btLoign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoign.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btLoign.Location = new System.Drawing.Point(163, 255);
            this.btLoign.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btLoign.Name = "btLoign";
            this.btLoign.Size = new System.Drawing.Size(100, 35);
            this.btLoign.TabIndex = 12;
            this.btLoign.Text = "Sign In";
            this.btLoign.UseVisualStyleBackColor = true;
            this.btLoign.Click += new System.EventHandler(this.btLoign_Click);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(91, 188);
            this.tbPass.Margin = new System.Windows.Forms.Padding(0);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(245, 33);
            this.tbPass.TabIndex = 17;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(91, 142);
            this.tbUser.Margin = new System.Windows.Forms.Padding(0);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(245, 33);
            this.tbUser.TabIndex = 16;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btLoign);
            this.Controls.Add(this._logo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(426, 381);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _logo;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btLoign;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
    }
}
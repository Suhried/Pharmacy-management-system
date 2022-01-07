
namespace pharmacy_management
{
    partial class pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacy));
            this.label2 = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.PassWordTb = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // UnameTb
            // 
            resources.ApplyResources(this.UnameTb, "UnameTb");
            this.UnameTb.Name = "UnameTb";
            // 
            // PassWordTb
            // 
            resources.ApplyResources(this.PassWordTb, "PassWordTb");
            this.PassWordTb.Name = "PassWordTb";
            this.PassWordTb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // userID
            // 
            resources.ApplyResources(this.userID, "userID");
            this.userID.Name = "userID";
            this.userID.Click += new System.EventHandler(this.userID_Click);
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pharmacy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.PassWordTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label2);
            this.Name = "pharmacy";
            this.Load += new System.EventHandler(this.pharmacy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.TextBox PassWordTb;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Login;
    }
}


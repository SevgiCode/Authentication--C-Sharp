namespace Registration
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
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            textBox2 = new TextBox();
            Login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(103, 49);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(103, 121);
            label2.Name = "label2";
            label2.Size = new Size(122, 27);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(248, 45);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Enter your username";
            usernameTxt.Size = new Size(333, 31);
            usernameTxt.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 123);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Password ";
            textBox2.Size = new Size(333, 31);
            textBox2.TabIndex = 3;
            // 
            // Login
            // 
            Login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login.Location = new Point(250, 223);
            Login.Name = "Login";
            Login.Size = new Size(176, 50);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(466, 223);
            button1.Name = "button1";
            button1.Size = new Size(218, 50);
            button1.TabIndex = 5;
            button1.Text = "Create an Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(796, 419);
            Controls.Add(button1);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox textBox2;
        private Button Login;
        private Button button1;
    }
}
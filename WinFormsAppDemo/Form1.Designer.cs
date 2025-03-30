namespace WinFormsAppDemo
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
            lblHello = new Label();
            btnSayHello = new Button();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(395, 162);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(125, 15);
            lblHello.TabIndex = 0;
            lblHello.Text = "Please press button...";
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(289, 158);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(75, 23);
            btnSayHello.TabIndex = 1;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSayHello);
            Controls.Add(lblHello);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHello;
        private Button btnSayHello;
    }
}

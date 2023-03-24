namespace EC_Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            button1 = new Button();
            Fan = new Button();
            panel3 = new Panel();
            button2 = new Button();
            userControl11 = new UserControl1();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 44, 65);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Fan);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 682);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 206);
            button1.Name = "button1";
            button1.Size = new Size(147, 149);
            button1.TabIndex = 3;
            button1.Text = "Memory Debug";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // Fan
            // 
            Fan.FlatAppearance.BorderSize = 0;
            Fan.FlatStyle = FlatStyle.Flat;
            Fan.Font = new Font("Montserrat", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Fan.ForeColor = SystemColors.ButtonHighlight;
            Fan.Image = (Image)resources.GetObject("Fan.Image");
            Fan.Location = new Point(0, 70);
            Fan.Name = "Fan";
            Fan.Size = new Size(147, 130);
            Fan.TabIndex = 2;
            Fan.Text = "Fan Control";
            Fan.TextAlign = ContentAlignment.BottomCenter;
            Fan.UseVisualStyleBackColor = true;
            Fan.Click += Fan_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 44, 65);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 50);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1107, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 4;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(-25, -156);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1013, 667);
            userControl11.TabIndex = 2;
            userControl11.Load += userControl11_Load;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(userControl11);
            panel1.Location = new Point(178, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 342);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 732);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        #endregion
        private Panel panel2;
        private Button Fan;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private UserControl1 userControl11;
        private Panel panel1;
    }
}
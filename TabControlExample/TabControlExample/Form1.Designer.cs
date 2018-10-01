namespace TabControlExample
{
    partial class Form1
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
            this.displaylabel = new System.Windows.Forms.TextBox();
            this.helloradiobutton = new System.Windows.Forms.RadioButton();
            this.goodbyebtn = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.size12radiobutton = new System.Windows.Forms.RadioButton();
            this.size16radiobutton = new System.Windows.Forms.RadioButton();
            this.size20radiobutton = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blackradiobutton = new System.Windows.Forms.RadioButton();
            this.redradiobutton = new System.Windows.Forms.RadioButton();
            this.greenradiobutton = new System.Windows.Forms.RadioButton();
            this.form = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hellobtn = new System.Windows.Forms.RadioButton();
            this.Byebtn = new System.Windows.Forms.RadioButton();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.form.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaylabel
            // 
            this.displaylabel.Location = new System.Drawing.Point(254, 395);
            this.displaylabel.Name = "displaylabel";
            this.displaylabel.Size = new System.Drawing.Size(179, 22);
            this.displaylabel.TabIndex = 2;
            // 
            // helloradiobutton
            // 
            this.helloradiobutton.Location = new System.Drawing.Point(0, 0);
            this.helloradiobutton.Name = "helloradiobutton";
            this.helloradiobutton.Size = new System.Drawing.Size(104, 24);
            this.helloradiobutton.TabIndex = 0;
            // 
            // goodbyebtn
            // 
            this.goodbyebtn.Location = new System.Drawing.Point(0, 0);
            this.goodbyebtn.Name = "goodbyebtn";
            this.goodbyebtn.Size = new System.Drawing.Size(104, 24);
            this.goodbyebtn.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.size20radiobutton);
            this.tabPage3.Controls.Add(this.size16radiobutton);
            this.tabPage3.Controls.Add(this.size12radiobutton);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(464, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // size12radiobutton
            // 
            this.size12radiobutton.AutoSize = true;
            this.size12radiobutton.Location = new System.Drawing.Point(46, 66);
            this.size12radiobutton.Name = "size12radiobutton";
            this.size12radiobutton.Size = new System.Drawing.Size(76, 21);
            this.size12radiobutton.TabIndex = 0;
            this.size12radiobutton.TabStop = true;
            this.size12radiobutton.Text = "Size 12";
            this.size12radiobutton.UseVisualStyleBackColor = true;
            this.size12radiobutton.CheckedChanged += new System.EventHandler(this.size12radiobutton_CheckedChanged);
            // 
            // size16radiobutton
            // 
            this.size16radiobutton.AutoSize = true;
            this.size16radiobutton.Location = new System.Drawing.Point(46, 125);
            this.size16radiobutton.Name = "size16radiobutton";
            this.size16radiobutton.Size = new System.Drawing.Size(74, 21);
            this.size16radiobutton.TabIndex = 1;
            this.size16radiobutton.TabStop = true;
            this.size16radiobutton.Text = "size 16";
            this.size16radiobutton.UseVisualStyleBackColor = true;
            this.size16radiobutton.CheckedChanged += new System.EventHandler(this.size16radiobutton_CheckedChanged_1);
            // 
            // size20radiobutton
            // 
            this.size20radiobutton.AutoSize = true;
            this.size20radiobutton.Location = new System.Drawing.Point(46, 198);
            this.size20radiobutton.Name = "size20radiobutton";
            this.size20radiobutton.Size = new System.Drawing.Size(74, 21);
            this.size20radiobutton.TabIndex = 2;
            this.size20radiobutton.TabStop = true;
            this.size20radiobutton.Text = "size 20";
            this.size20radiobutton.UseVisualStyleBackColor = true;
            this.size20radiobutton.CheckedChanged += new System.EventHandler(this.size20radiobutton_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.greenradiobutton);
            this.tabPage1.Controls.Add(this.redradiobutton);
            this.tabPage1.Controls.Add(this.blackradiobutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // blackradiobutton
            // 
            this.blackradiobutton.AutoSize = true;
            this.blackradiobutton.Location = new System.Drawing.Point(31, 70);
            this.blackradiobutton.Name = "blackradiobutton";
            this.blackradiobutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blackradiobutton.Size = new System.Drawing.Size(63, 21);
            this.blackradiobutton.TabIndex = 0;
            this.blackradiobutton.TabStop = true;
            this.blackradiobutton.Text = "Black";
            this.blackradiobutton.UseVisualStyleBackColor = true;
            this.blackradiobutton.CheckedChanged += new System.EventHandler(this.blackradiobutton_CheckedChanged);
            // 
            // redradiobutton
            // 
            this.redradiobutton.AutoSize = true;
            this.redradiobutton.Location = new System.Drawing.Point(31, 116);
            this.redradiobutton.Name = "redradiobutton";
            this.redradiobutton.Size = new System.Drawing.Size(55, 21);
            this.redradiobutton.TabIndex = 1;
            this.redradiobutton.TabStop = true;
            this.redradiobutton.Text = "Red";
            this.redradiobutton.UseVisualStyleBackColor = true;
            this.redradiobutton.CheckedChanged += new System.EventHandler(this.redradiobutton_CheckedChanged_1);
            // 
            // greenradiobutton
            // 
            this.greenradiobutton.AutoSize = true;
            this.greenradiobutton.Location = new System.Drawing.Point(31, 169);
            this.greenradiobutton.Name = "greenradiobutton";
            this.greenradiobutton.Size = new System.Drawing.Size(69, 21);
            this.greenradiobutton.TabIndex = 2;
            this.greenradiobutton.TabStop = true;
            this.greenradiobutton.Text = "Green";
            this.greenradiobutton.UseVisualStyleBackColor = true;
            this.greenradiobutton.CheckedChanged += new System.EventHandler(this.greenradiobutton_CheckedChanged_1);
            // 
            // form
            // 
            this.form.Controls.Add(this.tabPage1);
            this.form.Controls.Add(this.tabPage3);
            this.form.Controls.Add(this.tabPage2);
            this.form.Location = new System.Drawing.Point(142, 28);
            this.form.Name = "form";
            this.form.SelectedIndex = 0;
            this.form.Size = new System.Drawing.Size(472, 333);
            this.form.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Byebtn);
            this.tabPage2.Controls.Add(this.hellobtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 304);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hellobtn
            // 
            this.hellobtn.AutoSize = true;
            this.hellobtn.Location = new System.Drawing.Point(66, 86);
            this.hellobtn.Name = "hellobtn";
            this.hellobtn.Size = new System.Drawing.Size(64, 21);
            this.hellobtn.TabIndex = 0;
            this.hellobtn.TabStop = true;
            this.hellobtn.Text = "Hello!";
            this.hellobtn.UseVisualStyleBackColor = true;
            this.hellobtn.CheckedChanged += new System.EventHandler(this.hellobtn_CheckedChanged_1);
            // 
            // Byebtn
            // 
            this.Byebtn.AutoSize = true;
            this.Byebtn.Location = new System.Drawing.Point(66, 155);
            this.Byebtn.Name = "Byebtn";
            this.Byebtn.Size = new System.Drawing.Size(88, 21);
            this.Byebtn.TabIndex = 1;
            this.Byebtn.TabStop = true;
            this.Byebtn.Text = "GoodBye";
            this.Byebtn.UseVisualStyleBackColor = true;
            this.Byebtn.CheckedChanged += new System.EventHandler(this.Byebtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displaylabel);
            this.Controls.Add(this.form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.form.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.TextBox displaylabel;
        private System.Windows.Forms.RadioButton goodbyebtn;
        private System.Windows.Forms.RadioButton helloradiobutton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton size20radiobutton;
        private System.Windows.Forms.RadioButton size16radiobutton;
        private System.Windows.Forms.RadioButton size12radiobutton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton greenradiobutton;
        private System.Windows.Forms.RadioButton redradiobutton;
        private System.Windows.Forms.RadioButton blackradiobutton;
        private System.Windows.Forms.TabControl form;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton hellobtn;
        private System.Windows.Forms.RadioButton Byebtn;
    }
}


namespace ImageAnalysis
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_1st_pic = new System.Windows.Forms.Panel();
            this.panel_2nd_pic = new System.Windows.Forms.Panel();
            this.picGroup = new System.Windows.Forms.GroupBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.butPre = new System.Windows.Forms.Button();
            this.but_Next = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radButPic = new System.Windows.Forms.RadioButton();
            this.radButTail = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.RGB_Box = new System.Windows.Forms.TextBox();
            this.Lay_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butRenew = new System.Windows.Forms.Button();
            this.picGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_1st_pic
            // 
            this.panel_1st_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_1st_pic.Location = new System.Drawing.Point(6, 19);
            this.panel_1st_pic.Name = "panel_1st_pic";
            this.panel_1st_pic.Size = new System.Drawing.Size(470, 575);
            this.panel_1st_pic.TabIndex = 0;
            // 
            // panel_2nd_pic
            // 
            this.panel_2nd_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_2nd_pic.Location = new System.Drawing.Point(482, 19);
            this.panel_2nd_pic.Name = "panel_2nd_pic";
            this.panel_2nd_pic.Size = new System.Drawing.Size(470, 575);
            this.panel_2nd_pic.TabIndex = 1;
            // 
            // picGroup
            // 
            this.picGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGroup.Controls.Add(this.panel_2nd_pic);
            this.picGroup.Controls.Add(this.panel_1st_pic);
            this.picGroup.Location = new System.Drawing.Point(12, 12);
            this.picGroup.Name = "picGroup";
            this.picGroup.Size = new System.Drawing.Size(958, 600);
            this.picGroup.TabIndex = 2;
            this.picGroup.TabStop = false;
            this.picGroup.Text = "Pictures";
            // 
            // controlGroup
            // 
            this.controlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroup.Controls.Add(this.panel3);
            this.controlGroup.Controls.Add(this.but_Next);
            this.controlGroup.Controls.Add(this.butPre);
            this.controlGroup.Location = new System.Drawing.Point(12, 618);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(958, 96);
            this.controlGroup.TabIndex = 4;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Controls";
            // 
            // butPre
            // 
            this.butPre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butPre.Location = new System.Drawing.Point(6, 19);
            this.butPre.Name = "butPre";
            this.butPre.Size = new System.Drawing.Size(35, 71);
            this.butPre.TabIndex = 0;
            this.butPre.Text = "<<";
            this.butPre.UseVisualStyleBackColor = true;
            this.butPre.Click += new System.EventHandler(this.butPre_Click);
            // 
            // but_Next
            // 
            this.but_Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.but_Next.Location = new System.Drawing.Point(47, 19);
            this.but_Next.Name = "but_Next";
            this.but_Next.Size = new System.Drawing.Size(35, 71);
            this.but_Next.TabIndex = 1;
            this.but_Next.Text = ">>";
            this.but_Next.UseVisualStyleBackColor = true;
            this.but_Next.Click += new System.EventHandler(this.but_Next_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.radButTail);
            this.panel3.Controls.Add(this.radButPic);
            this.panel3.Location = new System.Drawing.Point(88, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 71);
            this.panel3.TabIndex = 2;
            // 
            // radButPic
            // 
            this.radButPic.AutoSize = true;
            this.radButPic.Checked = true;
            this.radButPic.Location = new System.Drawing.Point(3, 3);
            this.radButPic.Name = "radButPic";
            this.radButPic.Size = new System.Drawing.Size(63, 17);
            this.radButPic.TabIndex = 0;
            this.radButPic.TabStop = true;
            this.radButPic.Text = "Pictures";
            this.radButPic.UseVisualStyleBackColor = true;
            this.radButPic.CheckedChanged += new System.EventHandler(this.radButPic_CheckedChanged);
            // 
            // radButTail
            // 
            this.radButTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButTail.AutoSize = true;
            this.radButTail.Location = new System.Drawing.Point(90, 3);
            this.radButTail.Name = "radButTail";
            this.radButTail.Size = new System.Drawing.Size(42, 17);
            this.radButTail.TabIndex = 1;
            this.radButTail.Text = "Bits";
            this.radButTail.UseVisualStyleBackColor = true;
            this.radButTail.CheckedChanged += new System.EventHandler(this.radButTail_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.butRenew);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Lay_Box);
            this.groupBox2.Controls.Add(this.RGB_Box);
            this.groupBox2.Location = new System.Drawing.Point(84, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(3, 20);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(66, 17);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "dif pixels";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // RGB_Box
            // 
            this.RGB_Box.Location = new System.Drawing.Point(9, 23);
            this.RGB_Box.Name = "RGB_Box";
            this.RGB_Box.Size = new System.Drawing.Size(45, 20);
            this.RGB_Box.TabIndex = 0;
            this.RGB_Box.Text = "R";
            // 
            // Lay_Box
            // 
            this.Lay_Box.Location = new System.Drawing.Point(60, 23);
            this.Lay_Box.Name = "Lay_Box";
            this.Lay_Box.Size = new System.Drawing.Size(45, 20);
            this.Lay_Box.TabIndex = 1;
            this.Lay_Box.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "canal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "layer";
            // 
            // butRenew
            // 
            this.butRenew.Location = new System.Drawing.Point(111, 19);
            this.butRenew.Name = "butRenew";
            this.butRenew.Size = new System.Drawing.Size(161, 24);
            this.butRenew.TabIndex = 4;
            this.butRenew.Text = "Renew";
            this.butRenew.UseVisualStyleBackColor = true;
            this.butRenew.Click += new System.EventHandler(this.butRenew_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 726);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.picGroup);
            this.Name = "Form";
            this.Text = "Analysis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.picGroup.ResumeLayout(false);
            this.controlGroup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_1st_pic;
        private System.Windows.Forms.Panel panel_2nd_pic;
        private System.Windows.Forms.GroupBox picGroup;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radButPic;
        private System.Windows.Forms.Button but_Next;
        private System.Windows.Forms.Button butPre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lay_Box;
        private System.Windows.Forms.TextBox RGB_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radButTail;
        private System.Windows.Forms.Button butRenew;
        private System.Windows.Forms.Label label2;
    }
}


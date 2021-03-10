
namespace fractals_2D
{
    partial class Sierpinski_Triangle_Iter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sierpinski_Triangle_Iter));
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelDepth = new System.Windows.Forms.Label();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToMenu.AutoSize = true;
            this.buttonToMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonToMenu.Location = new System.Drawing.Point(516, 476);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(256, 23);
            this.buttonToMenu.TabIndex = 20;
            this.buttonToMenu.Text = "Меню";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLine.Location = new System.Drawing.Point(500, -25);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(10, 541);
            this.pictureBoxLine.TabIndex = 21;
            this.pictureBoxLine.TabStop = false;
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxScreen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxScreen.TabIndex = 22;
            this.pictureBoxScreen.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDraw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDraw.Location = new System.Drawing.Point(626, 12);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(146, 45);
            this.buttonDraw.TabIndex = 23;
            this.buttonDraw.Text = "НАРИСОВАТЬ";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelDepth
            // 
            this.labelDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepth.AutoSize = true;
            this.labelDepth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDepth.Location = new System.Drawing.Point(516, 44);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(51, 13);
            this.labelDepth.TabIndex = 25;
            this.labelDepth.Text = "Глубина:";
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDepth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBarDepth.Location = new System.Drawing.Point(516, 12);
            this.trackBarDepth.Minimum = 1;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(104, 45);
            this.trackBarDepth.TabIndex = 24;
            this.trackBarDepth.Value = 5;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBarDepth_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(626, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Цвет:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "Gray",
            "Yellow",
            "Navy",
            "Crimson",
            "Orange"});
            this.comboBoxColor.Location = new System.Drawing.Point(626, 81);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(139, 21);
            this.comboBoxColor.TabIndex = 26;
            // 
            // Sierpinski_Triangle_Iter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBoxScreen);
            this.Controls.Add(this.pictureBoxLine);
            this.Controls.Add(this.buttonToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "Sierpinski_Triangle_Iter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треугольник серпинского";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sierpinski_Triangle_Iter_FormClosing);
            this.Load += new System.EventHandler(this.Sierpinski_Triangle_Iter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToMenu;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}
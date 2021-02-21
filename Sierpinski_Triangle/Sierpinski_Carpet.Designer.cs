
namespace fractals_2D
{
    partial class Sierpinski_Carpet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sierpinski_Carpet));
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.labelDepth = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScreen
            // 
            resources.ApplyResources(this.pictureBoxScreen, "pictureBoxScreen");
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.TabStop = false;
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.pictureBoxLine, "pictureBoxLine");
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.TabStop = false;
            // 
            // buttonToMenu
            // 
            resources.ApplyResources(this.buttonToMenu, "buttonToMenu");
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // trackBarDepth
            // 
            resources.ApplyResources(this.trackBarDepth, "trackBarDepth");
            this.trackBarDepth.Minimum = 1;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Value = 5;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelDepth
            // 
            resources.ApplyResources(this.labelDepth, "labelDepth");
            this.labelDepth.Name = "labelDepth";
            // 
            // buttonDraw
            // 
            resources.ApplyResources(this.buttonDraw, "buttonDraw");
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // comboBoxColor
            // 
            resources.ApplyResources(this.comboBoxColor, "comboBoxColor");
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            resources.GetString("comboBoxColor.Items"),
            resources.GetString("comboBoxColor.Items1"),
            resources.GetString("comboBoxColor.Items2"),
            resources.GetString("comboBoxColor.Items3"),
            resources.GetString("comboBoxColor.Items4"),
            resources.GetString("comboBoxColor.Items5"),
            resources.GetString("comboBoxColor.Items6"),
            resources.GetString("comboBoxColor.Items7"),
            resources.GetString("comboBoxColor.Items8"),
            resources.GetString("comboBoxColor.Items9")});
            this.comboBoxColor.Name = "comboBoxColor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Sierpinski_Carpet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.pictureBoxLine);
            this.Controls.Add(this.pictureBoxScreen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sierpinski_Carpet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SierpinskiCarpet_FormClosing);
            this.Load += new System.EventHandler(this.SierpinskiCarpet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Draw_Tick;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Button buttonToMenu;
        private System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label1;
    }
}


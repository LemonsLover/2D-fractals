
namespace fractals_2D
{
    partial class Sierpinski_Triangle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sierpinski_Triangle));
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.numericUpDownDotWidth = new System.Windows.Forms.NumericUpDown();
            this.labelDotWidth = new System.Windows.Forms.Label();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownDotSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDotAmount = new System.Windows.Forms.Label();
            this.numericUpDownDotAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRndColors = new System.Windows.Forms.CheckBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.checkBoxOnePerTick = new System.Windows.Forms.CheckBox();
            this.checkBoxRndFirstDot = new System.Windows.Forms.CheckBox();
            this.buttonToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScreen
            // 
            resources.ApplyResources(this.pictureBoxScreen, "pictureBoxScreen");
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.TabStop = false;
            this.pictureBoxScreen.Resize += new System.EventHandler(this.pictureBoxScreen_Resize);
            // 
            // buttonDraw
            // 
            resources.ApplyResources(this.buttonDraw, "buttonDraw");
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // numericUpDownDotWidth
            // 
            resources.ApplyResources(this.numericUpDownDotWidth, "numericUpDownDotWidth");
            this.numericUpDownDotWidth.DecimalPlaces = 1;
            this.numericUpDownDotWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDotWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDotWidth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.numericUpDownDotWidth.Name = "numericUpDownDotWidth";
            this.numericUpDownDotWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotWidth.ValueChanged += new System.EventHandler(this.numericUpDownDotWidth_ValueChanged);
            // 
            // labelDotWidth
            // 
            resources.ApplyResources(this.labelDotWidth, "labelDotWidth");
            this.labelDotWidth.Name = "labelDotWidth";
            // 
            // timerDraw
            // 
            this.timerDraw.Interval = 1;
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClean
            // 
            resources.ApplyResources(this.buttonClean, "buttonClean");
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
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
            resources.GetString("comboBoxColor.Items4")});
            this.comboBoxColor.Name = "comboBoxColor";
            // 
            // labelColor
            // 
            resources.ApplyResources(this.labelColor, "labelColor");
            this.labelColor.Name = "labelColor";
            // 
            // pictureBoxLine
            // 
            resources.ApplyResources(this.pictureBoxLine, "pictureBoxLine");
            this.pictureBoxLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.TabStop = false;
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // numericUpDownDotSpeed
            // 
            resources.ApplyResources(this.numericUpDownDotSpeed, "numericUpDownDotSpeed");
            this.numericUpDownDotSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Maximum = new decimal(new int[] {
            -1675358184,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Name = "numericUpDownDotSpeed";
            this.numericUpDownDotSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.ValueChanged += new System.EventHandler(this.numericUpDownDotSpeed_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelDotAmount
            // 
            resources.ApplyResources(this.labelDotAmount, "labelDotAmount");
            this.labelDotAmount.Name = "labelDotAmount";
            // 
            // numericUpDownDotAmount
            // 
            resources.ApplyResources(this.numericUpDownDotAmount, "numericUpDownDotAmount");
            this.numericUpDownDotAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownDotAmount.Name = "numericUpDownDotAmount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkBoxRndColors
            // 
            resources.ApplyResources(this.checkBoxRndColors, "checkBoxRndColors");
            this.checkBoxRndColors.Name = "checkBoxRndColors";
            this.checkBoxRndColors.UseVisualStyleBackColor = true;
            // 
            // labelSpeed
            // 
            resources.ApplyResources(this.labelSpeed, "labelSpeed");
            this.labelSpeed.Name = "labelSpeed";
            // 
            // checkBoxOnePerTick
            // 
            resources.ApplyResources(this.checkBoxOnePerTick, "checkBoxOnePerTick");
            this.checkBoxOnePerTick.Name = "checkBoxOnePerTick";
            this.checkBoxOnePerTick.UseVisualStyleBackColor = true;
            // 
            // checkBoxRndFirstDot
            // 
            resources.ApplyResources(this.checkBoxRndFirstDot, "checkBoxRndFirstDot");
            this.checkBoxRndFirstDot.Name = "checkBoxRndFirstDot";
            this.checkBoxRndFirstDot.UseVisualStyleBackColor = true;
            // 
            // buttonToMenu
            // 
            resources.ApplyResources(this.buttonToMenu, "buttonToMenu");
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Sierpinski_Triangle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.checkBoxRndFirstDot);
            this.Controls.Add(this.checkBoxOnePerTick);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.checkBoxRndColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDotAmount);
            this.Controls.Add(this.numericUpDownDotAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDotSpeed);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLine);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelDotWidth);
            this.Controls.Add(this.numericUpDownDotWidth);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBoxScreen);
            this.Name = "Sierpinski_Triangle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sierpinski_Triangle_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownDotWidth;
        private System.Windows.Forms.Label labelDotWidth;
        private System.Windows.Forms.Timer Draw_Tick;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownDotSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDotAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownDotAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRndColors;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkBoxOnePerTick;
        private System.Windows.Forms.CheckBox checkBoxRndFirstDot;
        private System.Windows.Forms.Button buttonToMenu;
    }
}


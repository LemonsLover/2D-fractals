
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
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Location = new System.Drawing.Point(455, 152);
            this.buttonToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(291, 209);
            this.buttonToMenu.TabIndex = 0;
            this.buttonToMenu.Text = "Меню";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Sierpinski_Carpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 601);
            this.Controls.Add(this.buttonToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sierpinski_Carpet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ковер серпинского";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sierpinski_Carpet_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToMenu;
    }
}
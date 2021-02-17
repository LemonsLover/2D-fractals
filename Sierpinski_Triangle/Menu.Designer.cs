
namespace fractals_2D
{
    partial class Menu
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
            this.buttonToCarpet = new System.Windows.Forms.Button();
            this.buttonToTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToCarpet
            // 
            this.buttonToCarpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToCarpet.Location = new System.Drawing.Point(14, 93);
            this.buttonToCarpet.Name = "buttonToCarpet";
            this.buttonToCarpet.Size = new System.Drawing.Size(251, 56);
            this.buttonToCarpet.TabIndex = 0;
            this.buttonToCarpet.Text = "Ковер Серпинского";
            this.buttonToCarpet.UseVisualStyleBackColor = true;
            this.buttonToCarpet.Click += new System.EventHandler(this.buttonToCarpet_Click);
            // 
            // buttonToTriangle
            // 
            this.buttonToTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonToTriangle.Location = new System.Drawing.Point(14, 12);
            this.buttonToTriangle.Name = "buttonToTriangle";
            this.buttonToTriangle.Size = new System.Drawing.Size(250, 56);
            this.buttonToTriangle.TabIndex = 1;
            this.buttonToTriangle.Text = "Треугольник Серпинского";
            this.buttonToTriangle.UseVisualStyleBackColor = true;
            this.buttonToTriangle.Click += new System.EventHandler(this.buttonToTriangle_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonToTriangle);
            this.Controls.Add(this.buttonToCarpet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToCarpet;
        private System.Windows.Forms.Button buttonToTriangle;
    }
}
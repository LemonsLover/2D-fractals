
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonToCarpet = new System.Windows.Forms.Button();
            this.buttonToTriangle = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToCarpet
            // 
            this.buttonToCarpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToCarpet.Location = new System.Drawing.Point(21, 88);
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
            this.buttonToTriangle.Location = new System.Drawing.Point(21, 9);
            this.buttonToTriangle.Name = "buttonToTriangle";
            this.buttonToTriangle.Size = new System.Drawing.Size(250, 56);
            this.buttonToTriangle.TabIndex = 1;
            this.buttonToTriangle.Text = "Треугольник Серпинского";
            this.buttonToTriangle.UseVisualStyleBackColor = true;
            this.buttonToTriangle.Click += new System.EventHandler(this.buttonToTriangle_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.Location = new System.Drawing.Point(71, 176);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(155, 17);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "By: Ovseukov Yehor";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 202);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonToTriangle);
            this.Controls.Add(this.buttonToCarpet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 241);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToCarpet;
        private System.Windows.Forms.Button buttonToTriangle;
        private System.Windows.Forms.Label labelTitle;
    }
}
namespace poo_paint
{
    partial class AreaDeDesenho
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboxFerramenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboxFerramenta
            // 
            this.comboxFerramenta.FormattingEnabled = true;
            this.comboxFerramenta.Location = new System.Drawing.Point(10, 0);
            this.comboxFerramenta.Margin = new System.Windows.Forms.Padding(2);
            this.comboxFerramenta.Name = "comboxFerramenta";
            this.comboxFerramenta.Size = new System.Drawing.Size(92, 21);
            this.comboxFerramenta.TabIndex = 1;
            this.comboxFerramenta.SelectedIndexChanged += new System.EventHandler(this.comboxFerramenta_SelectedIndexChanged);
            // 
            // AreaDeDesenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.comboxFerramenta);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AreaDeDesenho";
            this.Text = "AreaDeDesenho";
            this.Load += new System.EventHandler(this.AreaDeDesenho_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Desenha);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DesenhaCliqueInicial);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DesenhaCliqueFinal);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox comboxFerramenta;
    }
}
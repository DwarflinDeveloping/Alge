namespace Alge
{
    partial class Alge
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.modus = new System.Windows.Forms.Label();
            this.modus_farbe = new System.Windows.Forms.RadioButton();
            this.modus_alge = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(63, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERGEBNIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modus
            // 
            this.modus.AutoSize = true;
            this.modus.BackColor = System.Drawing.Color.Transparent;
            this.modus.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modus.ForeColor = System.Drawing.SystemColors.Control;
            this.modus.Location = new System.Drawing.Point(12, 284);
            this.modus.Name = "modus";
            this.modus.Size = new System.Drawing.Size(79, 23);
            this.modus.TabIndex = 1;
            this.modus.Text = "Modus:";
            // 
            // modus_farbe
            // 
            this.modus_farbe.AutoSize = true;
            this.modus_farbe.BackColor = System.Drawing.Color.Transparent;
            this.modus_farbe.Checked = true;
            this.modus_farbe.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modus_farbe.ForeColor = System.Drawing.SystemColors.Control;
            this.modus_farbe.Location = new System.Drawing.Point(16, 310);
            this.modus_farbe.Name = "modus_farbe";
            this.modus_farbe.Size = new System.Drawing.Size(57, 17);
            this.modus_farbe.TabIndex = 2;
            this.modus_farbe.TabStop = true;
            this.modus_farbe.Text = "Farbe";
            this.modus_farbe.UseVisualStyleBackColor = false;
            // 
            // modus_alge
            // 
            this.modus_alge.AutoSize = true;
            this.modus_alge.BackColor = System.Drawing.Color.Transparent;
            this.modus_alge.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modus_alge.ForeColor = System.Drawing.SystemColors.Control;
            this.modus_alge.Location = new System.Drawing.Point(16, 333);
            this.modus_alge.Name = "modus_alge";
            this.modus_alge.Size = new System.Drawing.Size(50, 17);
            this.modus_alge.TabIndex = 3;
            this.modus_alge.Text = "Alge";
            this.modus_alge.UseVisualStyleBackColor = false;
            // 
            // Alge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alge.Properties.Resources.c9223d5_lg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 384);
            this.Controls.Add(this.modus_alge);
            this.Controls.Add(this.modus_farbe);
            this.Controls.Add(this.modus);
            this.Controls.Add(this.label1);
            this.Name = "Alge";
            this.Text = "Alge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modus;
        private System.Windows.Forms.RadioButton modus_farbe;
        private System.Windows.Forms.RadioButton modus_alge;
    }
}


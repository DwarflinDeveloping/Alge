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
            this.ergebnis = new System.Windows.Forms.Label();
            this.modus = new System.Windows.Forms.Label();
            this.modus_farbe = new System.Windows.Forms.RadioButton();
            this.modus_alge = new System.Windows.Forms.RadioButton();
            this.button_alge = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // ergebnis
            // 
            this.ergebnis.AutoSize = true;
            this.ergebnis.BackColor = System.Drawing.Color.Transparent;
            this.ergebnis.Font = new System.Drawing.Font("Rubik", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ergebnis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ergebnis.Location = new System.Drawing.Point(63, 90);
            this.ergebnis.Name = "ergebnis";
            this.ergebnis.Size = new System.Drawing.Size(541, 114);
            this.ergebnis.TabIndex = 0;
            this.ergebnis.Text = "ERGEBNIS";
            this.ergebnis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ergebnis.Visible = false;
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
            // button_alge
            // 
            this.button_alge.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alge.Location = new System.Drawing.Point(246, 284);
            this.button_alge.Name = "button_alge";
            this.button_alge.Size = new System.Drawing.Size(163, 71);
            this.button_alge.TabIndex = 4;
            this.button_alge.Text = "ALGE";
            this.button_alge.UseVisualStyleBackColor = true;
            this.button_alge.Click += new System.EventHandler(this.button_alge_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Image = global::Alge.Properties.Resources.settings_image;
            this.settings.Location = new System.Drawing.Point(588, 322);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(50, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.LinkColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(11, 362);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(83, 13);
            this.credits.TabIndex = 6;
            this.credits.TabStop = true;
            this.credits.Text = "Alge by Paxonic";
            this.credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credits_LinkClicked);
            // 
            // Alge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alge.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 384);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.button_alge);
            this.Controls.Add(this.modus_alge);
            this.Controls.Add(this.modus_farbe);
            this.Controls.Add(this.modus);
            this.Controls.Add(this.ergebnis);
            this.Name = "Alge";
            this.Text = "Alge";
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ergebnis;
        private System.Windows.Forms.Label modus;
        private System.Windows.Forms.RadioButton modus_farbe;
        private System.Windows.Forms.RadioButton modus_alge;
        private System.Windows.Forms.Button button_alge;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.LinkLabel credits;
    }
}


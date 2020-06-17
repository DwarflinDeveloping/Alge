namespace Alge
{
    partial class Settings
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
            this.sound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sound
            // 
            this.sound.AutoSize = true;
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.Checked = true;
            this.sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sound.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sound.ForeColor = System.Drawing.SystemColors.Control;
            this.sound.Location = new System.Drawing.Point(96, 75);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(265, 36);
            this.sound.TabIndex = 0;
            this.sound.Text = "Sound aktivieren";
            this.sound.UseVisualStyleBackColor = false;
            this.sound.CheckedChanged += new System.EventHandler(this.sound_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alge.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(468, 398);
            this.Controls.Add(this.sound);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox sound;
    }
}
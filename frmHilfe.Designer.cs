
namespace Blackjack_Spiel
{
    partial class frmHilfe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHilfe));
            this.btnZuruekZumMenue = new System.Windows.Forms.Button();
            this.lbl_hilfe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZuruekZumMenue
            // 
            this.btnZuruekZumMenue.Location = new System.Drawing.Point(1480, 10);
            this.btnZuruekZumMenue.Name = "btnZuruekZumMenue";
            this.btnZuruekZumMenue.Size = new System.Drawing.Size(210, 63);
            this.btnZuruekZumMenue.TabIndex = 0;
            this.btnZuruekZumMenue.Text = "Zurück zum Hauptmenü";
            this.btnZuruekZumMenue.UseVisualStyleBackColor = true;
            this.btnZuruekZumMenue.Click += new System.EventHandler(this.btnZuruekZumMenue_Click);
            // 
            // lbl_hilfe
            // 
            this.lbl_hilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hilfe.Location = new System.Drawing.Point(12, 15);
            this.lbl_hilfe.Name = "lbl_hilfe";
            this.lbl_hilfe.Size = new System.Drawing.Size(1462, 58);
            this.lbl_hilfe.TabIndex = 1;
            this.lbl_hilfe.Text = "Willkommen bei Blackjack. Hier findest du die Hilfe, die du brauchst, um Blackjac" +
    "k spielen zu können.";
            this.lbl_hilfe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1673, 990);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // frmHilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 1097);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_hilfe);
            this.Controls.Add(this.btnZuruekZumMenue);
            this.Name = "frmHilfe";
            this.Text = "Blackjack - Hilfe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZuruekZumMenue;
        private System.Windows.Forms.Label lbl_hilfe;
        private System.Windows.Forms.TextBox textBox1;
    }
}

namespace Blackjack_Spiel
{
    partial class frmHauptmenue
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpielStarten = new System.Windows.Forms.Button();
            this.btnHilfe = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1726, 1160);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSpielStarten);
            this.flowLayoutPanel1.Controls.Add(this.btnHilfe);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(434, 583);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(857, 574);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnSpielStarten
            // 
            this.btnSpielStarten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpielStarten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpielStarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpielStarten.ForeColor = System.Drawing.Color.Black;
            this.btnSpielStarten.Location = new System.Drawing.Point(3, 3);
            this.btnSpielStarten.Name = "btnSpielStarten";
            this.btnSpielStarten.Size = new System.Drawing.Size(600, 200);
            this.btnSpielStarten.TabIndex = 1;
            this.btnSpielStarten.Text = "Starten";
            this.btnSpielStarten.UseVisualStyleBackColor = false;
            this.btnSpielStarten.Click += new System.EventHandler(this.btnSpielStarten_Click_1);
            // 
            // btnHilfe
            // 
            this.btnHilfe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHilfe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHilfe.Location = new System.Drawing.Point(3, 209);
            this.btnHilfe.Name = "btnHilfe";
            this.btnHilfe.Size = new System.Drawing.Size(600, 200);
            this.btnHilfe.TabIndex = 3;
            this.btnHilfe.Text = "Hilfe";
            this.btnHilfe.UseVisualStyleBackColor = false;
            this.btnHilfe.Click += new System.EventHandler(this.btnHilfe_Click_1);
            // 
            // frmHauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Blackjack_Spiel.Properties.Resources.tournament_blackjack_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1726, 1160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHauptmenue";
            this.Text = "Blackjack - Hauptmenü";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSpielStarten;
        private System.Windows.Forms.Button btnHilfe;
    }
}


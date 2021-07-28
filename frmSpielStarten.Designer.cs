
namespace Blackjack_Spiel
{
    partial class frmSpielStarten
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbWetteinsatz = new System.Windows.Forms.ComboBox();
            this.btnWetteAbschliessen = new System.Windows.Forms.Button();
            this.txtWetteAbschliessen = new System.Windows.Forms.TextBox();
            this.btnSpielNeustarten = new System.Windows.Forms.Button();
            this.btnSpielBeenden = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pbBacksideKarte = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKarteZiehen = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnVerdoppeln = new System.Windows.Forms.Button();
            this.lblDealerKartenSumme = new System.Windows.Forms.Label();
            this.lblSpielerKartenSumme = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBacksideKarte)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1778, 379);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(358, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1417, 373);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 802);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1778, 379);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cbbWetteinsatz);
            this.flowLayoutPanel1.Controls.Add(this.btnWetteAbschliessen);
            this.flowLayoutPanel1.Controls.Add(this.txtWetteAbschliessen);
            this.flowLayoutPanel1.Controls.Add(this.btnSpielNeustarten);
            this.flowLayoutPanel1.Controls.Add(this.btnSpielBeenden);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 370);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbbWetteinsatz
            // 
            this.cbbWetteinsatz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWetteinsatz.FormattingEnabled = true;
            this.cbbWetteinsatz.Location = new System.Drawing.Point(33, 3);
            this.cbbWetteinsatz.Name = "cbbWetteinsatz";
            this.cbbWetteinsatz.Size = new System.Drawing.Size(286, 28);
            this.cbbWetteinsatz.TabIndex = 1;
            this.cbbWetteinsatz.SelectedIndexChanged += new System.EventHandler(this.cbbWetteinsatz_SelectedIndexChanged);
            // 
            // btnWetteAbschliessen
            // 
            this.btnWetteAbschliessen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWetteAbschliessen.Location = new System.Drawing.Point(33, 37);
            this.btnWetteAbschliessen.Name = "btnWetteAbschliessen";
            this.btnWetteAbschliessen.Size = new System.Drawing.Size(286, 69);
            this.btnWetteAbschliessen.TabIndex = 0;
            this.btnWetteAbschliessen.Text = "Wette abschließen";
            this.btnWetteAbschliessen.UseVisualStyleBackColor = true;
            this.btnWetteAbschliessen.Click += new System.EventHandler(this.btnWetteAbschliessen_Click);
            // 
            // txtWetteAbschliessen
            // 
            this.txtWetteAbschliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWetteAbschliessen.Location = new System.Drawing.Point(33, 112);
            this.txtWetteAbschliessen.Multiline = true;
            this.txtWetteAbschliessen.Name = "txtWetteAbschliessen";
            this.txtWetteAbschliessen.ReadOnly = true;
            this.txtWetteAbschliessen.Size = new System.Drawing.Size(286, 86);
            this.txtWetteAbschliessen.TabIndex = 2;
            this.txtWetteAbschliessen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWetteAbschliessen.TextChanged += new System.EventHandler(this.txtWetteAbschliessen_TextChanged);
            // 
            // btnSpielNeustarten
            // 
            this.btnSpielNeustarten.Location = new System.Drawing.Point(33, 204);
            this.btnSpielNeustarten.Name = "btnSpielNeustarten";
            this.btnSpielNeustarten.Size = new System.Drawing.Size(286, 80);
            this.btnSpielNeustarten.TabIndex = 5;
            this.btnSpielNeustarten.Text = " Spiel neustarten";
            this.btnSpielNeustarten.UseVisualStyleBackColor = true;
            this.btnSpielNeustarten.Click += new System.EventHandler(this.btnSpielNeustarten_Click);
            // 
            // btnSpielBeenden
            // 
            this.btnSpielBeenden.Location = new System.Drawing.Point(33, 290);
            this.btnSpielBeenden.Name = "btnSpielBeenden";
            this.btnSpielBeenden.Size = new System.Drawing.Size(286, 80);
            this.btnSpielBeenden.TabIndex = 4;
            this.btnSpielBeenden.Text = "Spiel beenden";
            this.btnSpielBeenden.UseVisualStyleBackColor = true;
            this.btnSpielBeenden.Click += new System.EventHandler(this.btnSpielBeenden_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(358, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1417, 373);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pbBacksideKarte, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 379);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.82742F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 423);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // pbBacksideKarte
            // 
            this.pbBacksideKarte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBacksideKarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBacksideKarte.Location = new System.Drawing.Point(106, 131);
            this.pbBacksideKarte.Name = "pbBacksideKarte";
            this.pbBacksideKarte.Size = new System.Drawing.Size(100, 160);
            this.pbBacksideKarte.TabIndex = 0;
            this.pbBacksideKarte.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 780F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDealerKartenSumme, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpielerKartenSumme, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(319, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1459, 423);
            this.tableLayoutPanel2.TabIndex = 6;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnKarteZiehen);
            this.flowLayoutPanel4.Controls.Add(this.btnStand);
            this.flowLayoutPanel4.Controls.Add(this.btnVerdoppeln);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 214);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(673, 206);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // btnKarteZiehen
            // 
            this.btnKarteZiehen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarteZiehen.Location = new System.Drawing.Point(3, 3);
            this.btnKarteZiehen.Name = "btnKarteZiehen";
            this.btnKarteZiehen.Size = new System.Drawing.Size(202, 94);
            this.btnKarteZiehen.TabIndex = 0;
            this.btnKarteZiehen.Text = "Karte ziehen";
            this.btnKarteZiehen.UseVisualStyleBackColor = true;
            this.btnKarteZiehen.Click += new System.EventHandler(this.btnKarteZiehen_Click);
            // 
            // btnStand
            // 
            this.btnStand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStand.Location = new System.Drawing.Point(211, 3);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(202, 94);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnVerdoppeln
            // 
            this.btnVerdoppeln.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerdoppeln.Location = new System.Drawing.Point(419, 3);
            this.btnVerdoppeln.Name = "btnVerdoppeln";
            this.btnVerdoppeln.Size = new System.Drawing.Size(202, 94);
            this.btnVerdoppeln.TabIndex = 2;
            this.btnVerdoppeln.Text = "Verdoppeln";
            this.btnVerdoppeln.UseVisualStyleBackColor = true;
            this.btnVerdoppeln.Click += new System.EventHandler(this.btnVerdoppeln_Click);
            // 
            // lblDealerKartenSumme
            // 
            this.lblDealerKartenSumme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDealerKartenSumme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDealerKartenSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerKartenSumme.Location = new System.Drawing.Point(881, 68);
            this.lblDealerKartenSumme.Name = "lblDealerKartenSumme";
            this.lblDealerKartenSumme.Size = new System.Drawing.Size(376, 74);
            this.lblDealerKartenSumme.TabIndex = 1;
            // 
            // lblSpielerKartenSumme
            // 
            this.lblSpielerKartenSumme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpielerKartenSumme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpielerKartenSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielerKartenSumme.Location = new System.Drawing.Point(881, 280);
            this.lblSpielerKartenSumme.Name = "lblSpielerKartenSumme";
            this.lblSpielerKartenSumme.Size = new System.Drawing.Size(376, 74);
            this.lblSpielerKartenSumme.TabIndex = 2;
            // 
            // frmSpielStarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Blackjack_Spiel.Properties.Resources.js_guides_blackjack_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1778, 1181);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSpielStarten";
            this.Text = "Blackjack - Spiel";
            this.Load += new System.EventHandler(this.frmSpielStarten_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBacksideKarte)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pbBacksideKarte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnWetteAbschliessen;
        private System.Windows.Forms.ComboBox cbbWetteinsatz;
        private System.Windows.Forms.TextBox txtWetteAbschliessen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnKarteZiehen;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnVerdoppeln;
        private System.Windows.Forms.Label lblDealerKartenSumme;
        private System.Windows.Forms.Button btnSpielBeenden;
        private System.Windows.Forms.Label lblSpielerKartenSumme;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnSpielNeustarten;
    }
}

namespace Osztalypenz
{
    partial class frmOsztalypenz
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTranzakcio = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBefizetes = new System.Windows.Forms.RadioButton();
            this.rbKifizetes = new System.Windows.Forms.RadioButton();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOsszeg = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEgyenleg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tranzakciók";
            // 
            // lbTranzakcio
            // 
            this.lbTranzakcio.FormattingEnabled = true;
            this.lbTranzakcio.ItemHeight = 20;
            this.lbTranzakcio.Location = new System.Drawing.Point(32, 52);
            this.lbTranzakcio.Name = "lbTranzakcio";
            this.lbTranzakcio.Size = new System.Drawing.Size(484, 304);
            this.lbTranzakcio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(32, 376);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(484, 39);
            this.btnMentes.TabIndex = 3;
            this.btnMentes.Text = "Állapot mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(32, 427);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(484, 39);
            this.btnBetoltes.TabIndex = 3;
            this.btnBetoltes.Text = "Állapot betöltése";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBefizetes);
            this.groupBox1.Controls.Add(this.rbKifizetes);
            this.groupBox1.Location = new System.Drawing.Point(534, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új tranzakció típusa";
            // 
            // rbBefizetes
            // 
            this.rbBefizetes.AutoSize = true;
            this.rbBefizetes.Location = new System.Drawing.Point(6, 37);
            this.rbBefizetes.Name = "rbBefizetes";
            this.rbBefizetes.Size = new System.Drawing.Size(94, 24);
            this.rbBefizetes.TabIndex = 0;
            this.rbBefizetes.TabStop = true;
            this.rbBefizetes.Text = "Befizetés";
            this.rbBefizetes.UseVisualStyleBackColor = true;
            // 
            // rbKifizetes
            // 
            this.rbKifizetes.AutoSize = true;
            this.rbKifizetes.Location = new System.Drawing.Point(6, 67);
            this.rbKifizetes.Name = "rbKifizetes";
            this.rbKifizetes.Size = new System.Drawing.Size(87, 24);
            this.rbKifizetes.TabIndex = 0;
            this.rbKifizetes.TabStop = true;
            this.rbKifizetes.Text = "Kifizetés";
            this.rbKifizetes.UseVisualStyleBackColor = true;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(534, 205);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(179, 26);
            this.tbNev.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Összeg:";
            // 
            // tbOsszeg
            // 
            this.tbOsszeg.Location = new System.Drawing.Point(534, 273);
            this.tbOsszeg.Name = "tbOsszeg";
            this.tbOsszeg.Size = new System.Drawing.Size(179, 26);
            this.tbOsszeg.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(534, 341);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(179, 26);
            this.dtpDatum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dátum:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Egyenleg:";
            // 
            // lblEgyenleg
            // 
            this.lblEgyenleg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEgyenleg.AutoSize = true;
            this.lblEgyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEgyenleg.Location = new System.Drawing.Point(66, 49);
            this.lblEgyenleg.Name = "lblEgyenleg";
            this.lblEgyenleg.Size = new System.Drawing.Size(46, 26);
            this.lblEgyenleg.TabIndex = 0;
            this.lblEgyenleg.Text = "0Ft";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEgyenleg, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(534, 376);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 90);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // frmOsztalypenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbOsszeg);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTranzakcio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOsztalypenz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osztálypénz nyilvántartása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTranzakcio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBefizetes;
        private System.Windows.Forms.RadioButton rbKifizetes;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOsszeg;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEgyenleg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


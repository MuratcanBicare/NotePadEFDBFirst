
namespace GunlukEFDBFirst
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılarım";
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotEkle.Location = new System.Drawing.Point(128, 49);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(50, 42);
            this.btnNotEkle.TabIndex = 1;
            this.btnNotEkle.Text = "+";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.DisplayMember = "Baslik";
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 20;
            this.lstNotlar.Location = new System.Drawing.Point(29, 109);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(287, 484);
            this.lstNotlar.TabIndex = 2;
            this.lstNotlar.ValueMember = "Id";
            this.lstNotlar.SelectedIndexChanged += new System.EventHandler(this.lstNotlar_SelectedIndexChanged);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(364, 65);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(877, 26);
            this.txtBaslik.TabIndex = 3;
            this.txtBaslik.TextChanged += new System.EventHandler(this.txtBaslik_TextChanged);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(364, 109);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(877, 484);
            this.txtIcerik.TabIndex = 4;
            this.txtIcerik.TextChanged += new System.EventHandler(this.txtIcerik_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(29, 641);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(183, 26);
            this.txtAra.TabIndex = 6;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(218, 630);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(131, 51);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(817, 610);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(424, 91);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(364, 610);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(424, 91);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 746);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Günlük EF DbFirst";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
    }
}



namespace VizeNTP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHavaDurumuBilgiAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ciili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMakSicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHavaDurumuBilgiAl
            // 
            this.btnHavaDurumuBilgiAl.Location = new System.Drawing.Point(8, 4);
            this.btnHavaDurumuBilgiAl.Name = "btnHavaDurumuBilgiAl";
            this.btnHavaDurumuBilgiAl.Size = new System.Drawing.Size(788, 44);
            this.btnHavaDurumuBilgiAl.TabIndex = 0;
            this.btnHavaDurumuBilgiAl.Text = "Hava Durumu Bilgileri Al";
            this.btnHavaDurumuBilgiAl.UseVisualStyleBackColor = true;
            this.btnHavaDurumuBilgiAl.Click += new System.EventHandler(this.btnHavaDurumuBilgiAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciili,
            this.cldurum,
            this.clMakSicaklik});
            this.dataGridView1.Location = new System.Drawing.Point(9, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // ciili
            // 
            this.ciili.HeaderText = "ili";
            this.ciili.Name = "ciili";
            // 
            // cldurum
            // 
            this.cldurum.HeaderText = "Durum";
            this.cldurum.Name = "cldurum";
            // 
            // clMakSicaklik
            // 
            this.clMakSicaklik.HeaderText = "MaksimumSıcaklık";
            this.clMakSicaklik.Name = "clMakSicaklik";
            // 
            // timer1
            // 
            this.timer1.Interval = 500000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHavaDurumuBilgiAl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHavaDurumuBilgiAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciili;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMakSicaklik;
        private System.Windows.Forms.Timer timer1;
    }
}


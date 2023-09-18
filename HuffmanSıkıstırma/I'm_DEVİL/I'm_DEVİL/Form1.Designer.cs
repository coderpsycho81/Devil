
namespace I_m_DEVİL
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
            this.selected_File = new System.Windows.Forms.TextBox();
            this.göster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.bytes_text = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEncode = new System.Windows.Forms.Label();
            this.btnEncodeDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCikti = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // selected_File
            // 
            this.selected_File.BackColor = System.Drawing.Color.DimGray;
            this.selected_File.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selected_File.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.selected_File.Location = new System.Drawing.Point(87, 14);
            this.selected_File.Multiline = true;
            this.selected_File.Name = "selected_File";
            this.selected_File.Size = new System.Drawing.Size(364, 20);
            this.selected_File.TabIndex = 0;
            this.selected_File.TabStop = false;
            this.selected_File.TextChanged += new System.EventHandler(this.selected_File_TextChanged);
            // 
            // göster
            // 
            this.göster.BackColor = System.Drawing.Color.Brown;
            this.göster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.göster.FlatAppearance.BorderSize = 0;
            this.göster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.göster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.göster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.göster.Location = new System.Drawing.Point(6, 13);
            this.göster.Name = "göster";
            this.göster.Size = new System.Drawing.Size(75, 23);
            this.göster.TabIndex = 1;
            this.göster.Text = "Göster";
            this.göster.UseVisualStyleBackColor = false;
            this.göster.Click += new System.EventHandler(this.göster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(104, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Seçiniz(PNG-JPG-JPEG)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.bytes_text);
            this.groupBox3.Controls.Add(this.btnHide);
            this.groupBox3.Controls.Add(this.göster);
            this.groupBox3.Controls.Add(this.selected_File);
            this.groupBox3.Location = new System.Drawing.Point(6, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 89);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gizleme: ";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Brown;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(376, 40);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Gizle";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // bytes_text
            // 
            this.bytes_text.AutoSize = true;
            this.bytes_text.Location = new System.Drawing.Point(84, 37);
            this.bytes_text.Name = "bytes_text";
            this.bytes_text.Size = new System.Drawing.Size(77, 14);
            this.bytes_text.TabIndex = 2;
            this.bytes_text.Text = "0/00 Bytes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEncode);
            this.groupBox2.Controls.Add(this.btnEncodeDecode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCikti);
            this.groupBox2.Location = new System.Drawing.Point(104, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manager";
            // 
            // lblEncode
            // 
            this.lblEncode.AutoSize = true;
            this.lblEncode.Location = new System.Drawing.Point(84, 45);
            this.lblEncode.Name = "lblEncode";
            this.lblEncode.Size = new System.Drawing.Size(63, 14);
            this.lblEncode.TabIndex = 3;
            this.lblEncode.Text = "Encode: ";
            // 
            // btnEncodeDecode
            // 
            this.btnEncodeDecode.BackColor = System.Drawing.Color.Brown;
            this.btnEncodeDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncodeDecode.FlatAppearance.BorderSize = 0;
            this.btnEncodeDecode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnEncodeDecode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEncodeDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncodeDecode.Location = new System.Drawing.Point(375, 45);
            this.btnEncodeDecode.Name = "btnEncodeDecode";
            this.btnEncodeDecode.Size = new System.Drawing.Size(107, 23);
            this.btnEncodeDecode.TabIndex = 3;
            this.btnEncodeDecode.Text = "Encode/Decode";
            this.btnEncodeDecode.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "TXT Çıktı";
            // 
            // txtCikti
            // 
            this.txtCikti.BackColor = System.Drawing.Color.DimGray;
            this.txtCikti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCikti.Enabled = false;
            this.txtCikti.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCikti.Location = new System.Drawing.Point(87, 19);
            this.txtCikti.Multiline = true;
            this.txtCikti.Name = "txtCikti";
            this.txtCikti.Size = new System.Drawing.Size(395, 20);
            this.txtCikti.TabIndex = 0;
            this.txtCikti.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(703, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 421);
            this.MinimumSize = new System.Drawing.Size(719, 421);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button göster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bytes_text;
        private System.Windows.Forms.TextBox selected_File;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCikti;
        private System.Windows.Forms.Button btnEncodeDecode;
        private System.Windows.Forms.Label lblEncode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


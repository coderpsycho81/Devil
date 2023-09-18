using System;
using System.IO;
using System.Windows.Forms;
using Huffman;

namespace I_m_DEVİL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long InputFileLengh = 0;
        private string FileExtension;

        #region Göster
        private void göster_Click(object sender, EventArgs e)
        {
            bytes_text.Text = "";

            OpenFileDialog InputFileDialog = new OpenFileDialog();
            InputFileDialog.Filter = "Tü Dosyalar (*.*)|*.*|PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|ASE (*.bztpe)|*.bztpe";
            InputFileDialog.ShowDialog();

            if (InputFileDialog.FileName != "") selected_File.Text = InputFileDialog.FileName;

            // Dosya Boyutunu Görmek
            FileStream fsStream = new FileStream(selected_File.Text, FileMode.Open);
            InputFileLengh = fsStream.Length;
            bytes_text.Text = "0/" + InputFileLengh + " Bytes";
            fsStream.Close();
        }
        #endregion

        #region Selected_File
        private void selected_File_TextChanged(object sender, EventArgs e)
        {
            lblEncode.Text = "";

            göster.Enabled = true;


            if (File.Exists(selected_File.Text))
            {
                bool CanBeOpenFlag = true;               

                if (CanBeOpenFlag)
                {
                    btnEncodeDecode.Enabled = true;
                    göster.Enabled = true;
                    txtCikti.Enabled = true;

                    if (selected_File.Text.Substring(selected_File.Text.Length - 6, 6) != ".bztpe")
                    {
                        btnHide.Text = "Gizle";
                        btnEncodeDecode.Text = "Encode";

                        FileInfo finfo = new FileInfo(selected_File.Text);

                        txtCikti.Text = selected_File.Text.Substring(0, selected_File.Text.Length - finfo.Extension.Length) + ".bztpe";

                        var path = Path.GetDirectoryName(selected_File.Text);
                        txtCikti.Text = path + "\\AKB.bztpe";
                    }
                    else
                    {
                        btnEncodeDecode.Text = "Decode";
                        btnHide.Text = "Çıkar";

                        StreamReader rdr = new StreamReader(File.OpenRead(selected_File.Text));
                        char[] charBuffer = new char[1];
                        FileExtension = "";
                        rdr.Read(charBuffer, 0, 1);
                        while (charBuffer[0] != '.')
                        {
                            FileExtension += charBuffer[0].ToString();
                            rdr.Read(charBuffer, 0, 1);
                        }

                        txtCikti.Text = selected_File.Text.Substring(0, selected_File.Text.Length - 6) + FileExtension;

                        var path = Path.GetDirectoryName(selected_File.Text);
                        txtCikti.Text = path + "\\AKB.txt";

                        rdr.Close();
                    }
                }
                else
                {
                    btnEncodeDecode.Enabled = false;
                    txtCikti.Enabled = false;
                }
            }
            else
            {
                btnEncodeDecode.Enabled = false;
                txtCikti.Enabled = false;
            }          
        }
        #endregion

        #region ImageEncode
        public void ImageEncode()
        {
            bool AppropritaDirectoryFlag = false;
            göster.Enabled = false;

            if(btnEncodeDecode.Text == "Encode")
            {
                if(txtCikti.Text.Length >= 6)
                {
                    if(txtCikti.Text.Substring(txtCikti.Text.Length - 6, 6) == ".bztpe")
                    {
                        if(HuffmanAlg.EncodeFile(selected_File.Text, txtCikti.Text  ))
                        {
                            AppropritaDirectoryFlag = true;
                            BinaryReader SourceFile = new BinaryReader(File.OpenRead(selected_File.Text));
                            BinaryReader OutputFile = new BinaryReader(File.OpenRead(txtCikti.Text));
                            lblEncode.Text = "Encode: Başarılı";
                            SourceFile.Close();
                            OutputFile.Close();
                        }                       
                    }
                }
                if (!AppropritaDirectoryFlag) lblEncode.Text = "Geçersiz Dizin";
            }
            if(btnEncodeDecode.Text == "Decode")
            {
                if (txtCikti.Text.Substring(txtCikti.Text.Length - FileExtension.Length, FileExtension.Length).Equals(FileExtension))
                {
                    if (!HuffmanAlg.DecodeFile(selected_File.Text, txtCikti.Text))
                        lblEncode.Text = "Geçersiz Dizin";
                    else
                        lblEncode.Text = "Decode Başarılı";
                }
                else lblEncode.Text = "Geçersiz Dizin";
            }
            göster.Enabled = true;
        }
        #endregion

        #region ImageDecode (Bakımda)
        public void ImageDecode()
        {
            var path = Path.GetDirectoryName(txtCikti.Text);
            selected_File.Text = path + "\\AKB.btzpe";            
            lblEncode.Text = "Decode: Başarılı";
        }
        #endregion

        #region btnHide_Click
        private void btnHide_Click(object sender, EventArgs e)
        {

            if (selected_File.Text.Length == 0)
            {
                errorProvider1.SetError(selected_File, "Lütfen Dosya Seçiniz..!");
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                ImageEncode();
                selected_File.Text = "";

                label3.Text = "Gizleme: Başarılı";
                btnHide.Text = "Gizle";

                this.Cursor = Cursors.Default;
            }                               
        }
        #endregion
    }
}

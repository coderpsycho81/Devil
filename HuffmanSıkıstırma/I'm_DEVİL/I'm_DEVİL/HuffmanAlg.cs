using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    public static class HuffmanAlg
    {
        //public static event Action ProgressEvent;

        ////İlkel veri türlerini belirli bir kodlamada ikili değer olarak okur.
        private static BinaryReader SourceFile; 

        private static void OnNotEnoughCodeEvent(ref string Code)
        {
            Code += HuffmanTree.ToBinaryString(SourceFile.ReadByte());
            //ProgressEvent();
        }

        public static bool DecodeFile(string InputPath, string OutputPath)
        {
            bool OpenSuccessfully = true;
            BinaryWriter OutputFile = null;
            try
            {
                SourceFile = new BinaryReader(File.OpenRead(InputPath));
                OutputFile = new BinaryWriter(File.Create(OutputPath));
            }
            catch
            {
                OpenSuccessfully = false;
            }

            if (OpenSuccessfully)
            {
                HuffmanTree DecodingModel = new HuffmanTree();
                DecodingModel.CreateModel();
                DecodingModel.NotEnoughCodeEvent += new HuffmanTree.NotEnoughCodeEventDelegate(OnNotEnoughCodeEvent);
                bool FinishFlag = false;
                Byte? Symbol = 0;
                string Code = "";

                do
                {
                    //ProgressEvent();
                }
                while (SourceFile.ReadChar() != '.');

                //ProgressEvent();
                Code = HuffmanTree.ToBinaryString(SourceFile.ReadByte());

                while (!FinishFlag)
                {
                    Symbol = DecodingModel.Decode(ref Code);
                    if (Symbol == null) FinishFlag = true;
                    if (!FinishFlag)
                    {
                        OutputFile.Write((Byte)Symbol);
                    }
                }
            }
            SourceFile.Close();
            OutputFile.Close();
            return OpenSuccessfully;
        }

        #region EnCodeFile
        public static bool EncodeFile(string InputPath, string OutputPath)
        {
            // InputPath: Giriş Yolu
            // OutputPath: Çıkış Yolu

            //Manager
            bool OpenSuccessfully = true; // Başarıyı Tamamen Aç

            //bir akışa ikili ilkel türler yazar ve belirli bir kodlamada dize yazmayı destekler.
            BinaryWriter OutputFile = null; // ÇıkışDosyası

            #region Dosya Yolu Atama
            try
            {
                //InputPeth deki ikilikleri okuyp Kaynak Dosyasına Atıyor
                SourceFile = new BinaryReader(File.OpenRead(InputPath));

                // OutPutPath dosya Oluşturup Çıkış Dosyamıza Atıyor
                OutputFile = new BinaryWriter(File.Create(OutputPath));
            }
            catch
            {
                OpenSuccessfully = false;
            }
            #endregion


            if (OpenSuccessfully)
            {
                HuffmanTree EncodingModel = new HuffmanTree(); //Huffman Tree i çağırdı
                EncodingModel.CreateModel(); //HuffmanTreeden CreatModel fonk çağırdı
                
                //Manage
                bool EndOfFile = false; // Dosyanın Sonu
                Byte Symbol = 0; //8 bit işaretsiz tamsayıyı temsil eder.

                string Code;
                string Buffer = "";  //Tampon
                char[] CharTypeBuffer; // Karakter Tipi Fonksiyon

                FileInfo Finfo = new FileInfo(InputPath); //InputPath'i Finfo ya Alıyorki Üzerinde Değişiklik Yapalım

                //Giriş Yolunun Uzantısından 1 den başlayarak sadece son dan bir çıkartarak . koyuyor ve geri kalan uzantıyıda
                // ToCharArray ile karakte başına sayı atıyacak
                CharTypeBuffer = (Finfo.Extension.Substring(1, Finfo.Extension.Length - 1) + ".").ToCharArray();
                OutputFile.Write(CharTypeBuffer); // Çıkış Dosyasına Karakter Tipi Fonksiyon'umuzu Binary olarak yazdırcak

                while (!EndOfFile)
                {
                    //ProgressEvent();

                    try
                    {
                        Symbol = SourceFile.ReadByte(); // Kaynak Dosyasındaki Bytleri okuyark Symbol'a Eşitleyecek
                    }
                    catch
                    {
                        EndOfFile = true;
                    }

                    if (!EndOfFile) Code = EncodingModel.Encode(Symbol);
                    else Code = EncodingModel.Encode(null);

                    Code = Buffer + Code;
                    Buffer = Code.Substring(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    Code = Code.Remove(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    while (Code != "")
                    {
                        OutputFile.Write(HuffmanTree.ToByte(Code.Substring(0, 8)));
                        Code = Code.Remove(0, 8);
                    }

                    if (EndOfFile)
                    {
                        while (Buffer.Length != 8) Buffer += "0";
                        OutputFile.Write(HuffmanTree.ToByte(Buffer));
                    }

                }
                SourceFile.Close();
                OutputFile.Close();
            }
            return OpenSuccessfully;
        }
        #endregion
    }
}
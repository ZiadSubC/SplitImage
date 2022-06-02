using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using SkiaSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace imageSplit.winForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //   Crops 100*100 in an image in the top right corner

            Bitmap originalImage = new Bitmap(Image.FromFile("kitten.jpg"));

            Rectangle rect = new Rectangle(0, 0, originalImage.Width, originalImage.Height);
            Bitmap mainImage = originalImage.Clone(rect, originalImage.PixelFormat);
            mainImage.Save("C:/Users/SubC/source/repos/SplitImage/ImageSplit/imageSplit.winForms/kitten1.jpg");
            rect = new Rectangle(originalImage.Width-100 , 0, 100,100);
            Bitmap crop = originalImage.Clone(rect, originalImage.PixelFormat);
            crop.Save("C:/Users/SubC/source/repos/SplitImage/ImageSplit/imageSplit.winForms/kitten2.jpg");

            pictureBox1.Image = originalImage;
            pictureBox2.Image = crop;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = @"JPEG files|&.jpg;*.jpg";
        //        saveFileDialog.ValidateNames = true;
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            QRCodeEncoder encoder = new QRCodeEncoder();
        //            encoder.QRCodeScale = 8;
        //            Bitmap bitmap = encoder.Encode(textBox1.Text);
        //            pictureBox1.Image = bitmap;
        //            bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
        //        }
        //    }
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = @"JPEG files|&.jpg;*.jpg";
        //        openFileDialog.ValidateNames = true;
        //        openFileDialog.Multiselect = false;
        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        //            QRCodeDecoder decoder = new QRCodeDecoder();
        //            textBox2.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        //        }
        //    }
        //}
    }
}
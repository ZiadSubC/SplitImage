namespace imageSplit.winForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap originalImage = new Bitmap(Image.FromFile("kitten.jpg"));
            Rectangle rect = new Rectangle(0, 0, originalImage.Width / 2, originalImage.Height);
            Bitmap firstHalf = originalImage.Clone(rect, originalImage.PixelFormat);
            firstHalf.Save("C:/Users/SubC/source/repos/SplitImage/ImageSplit/imageSplit.winForms/kitten1.jpg");
            rect = new Rectangle(originalImage.Width / 2, 0, originalImage.Width / 2, originalImage.Height);
            Bitmap secondHalf = originalImage.Clone(rect, originalImage.PixelFormat);
            secondHalf.Save("C:/Users/SubC/source/repos/SplitImage/ImageSplit/imageSplit.winForms/kitten2.jpg");

            pictureBox1.Image = originalImage;
        }
    }
}
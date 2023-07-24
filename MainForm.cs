using System.Diagnostics;
using System.Windows.Forms;
using System;
using OpenCvSharp;
using System.Windows.Forms;
namespace SegmentAnything
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Settings.Load();
            if (Settings.GetSettings("PreModel") == "")
            {
                Init init = new Init();
                if (init.ShowDialog() != DialogResult.OK)
                    return;
            }
            preModelPath = Settings.GetSettings("PreModel");
            samModelPath = Settings.GetSettings("Model");
            Settings.Save();
            samRunner = new SamRunner(preModelPath, samModelPath);
        }
        public static SamRunner samRunner;
        public static Image im;
        public static string temp = "";
        string preModelPath = "models\\sam_preprocess.onnx";
        string samModelPath = "models\\sam_vit_h_4b8939.onnx";
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (samRunner == null) return;
            Directory.CreateDirectory("Masks");
            temp = "Masks/" + e.X + e.Y + ".jpg";
            Mat m = samRunner.GetMask(e.Location);
            Console.WriteLine("Saving Mask.");
            m.SaveImage(temp);
            maskBox.Image = (Image)Image.FromFile(temp);
        }
        bool disp = false;
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string inputImagePath = openFileDialog.FileName;
            im = Image.FromFile(inputImagePath);
            pictureBox.Image = im;
            string resizeImagePath = "resize.jpg";
            Stopwatch st = new Stopwatch();
            st.Start();
            if (disp)
            {
                samRunner.Dispose();
                samRunner = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                samRunner = new SamRunner(preModelPath, samModelPath);
            }
            Console.WriteLine("Reading input image.");
            Mat src = Cv2.ImRead(inputImagePath);
            Mat dst = Mat.Zeros(samRunner.GetInputSize(), MatType.CV_8UC3);
            Cv2.Resize(src, src, samRunner.GetInputSize());
            Console.WriteLine("Saving resize image. " + st.ElapsedMilliseconds / 1000 + "s");
            src.SaveImage(resizeImagePath);
            Console.WriteLine("Loading resize Image. " + st.ElapsedMilliseconds / 1000 + "s");
            samRunner.LoadImage(src);
            src.Dispose();
            dst.Dispose();
            disp = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            maskBox.Image.Save(saveFileDialog.FileName);
        }
    }
}
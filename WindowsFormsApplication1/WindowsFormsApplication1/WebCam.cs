using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCam_Capture;
using KeepAutomation.BarcodeReader;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class WebCam
    {

        private WebCamCapture cam;
        private PictureBox _FrameImage;
        private int FrameNumber = 50;
        public void InitializeWebCam(ref System.Windows.Forms.PictureBox ImageControl)
        {
            try
            {
                cam = new WebCamCapture();
                cam.FrameNumber = ((ulong)(0ul));
                cam.TimeToCapture_milliseconds = FrameNumber;
                cam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
                _FrameImage = ImageControl;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _FrameImage.Image = e.WebCamImage;
        }

        public void Start()
        {
            cam.TimeToCapture_milliseconds = FrameNumber;
            cam.Start(0);
        }

        public void Stop()
        {
            cam.Stop();
            cam.Dispose();
            _FrameImage.Image = null;
        }

        public string readCode()
        {
            string qr = "";
            try
            {
                string[] temp = BarcodeReader.readBarcode((Bitmap)_FrameImage.Image, BarcodeType.QRCode);
                qr = temp[0].Substring(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return qr;
        }
    }
}

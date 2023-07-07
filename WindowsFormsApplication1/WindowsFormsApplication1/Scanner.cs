using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using KeepAutomation.BarcodeReader;

namespace WindowsFormsApplication1
{
    class Scanner
    {
        private bool scanning = false;
        private WebCam webCam;

        public Scanner(ref PictureBox pBox)
        {
            webCam = new WebCam();
            webCam.InitializeWebCam(ref pBox);
            pBox.InitialImage = pBox.Image = null;
            webCam.Start();
            webCam.Start();
        }

        public async Task<string> startScan()
        {
            //webCam.Start();
            //webCam.Start();
            return await scan();
        }

        public void stopScan()
        {
            scanning = false;
            webCam.Stop();
        }

        private async Task<string> scan()
        {
            scanning = true;
            string code = "";
            while (scanning)
            {
                code = webCam.readCode();
                if (!String.IsNullOrEmpty(code))
                {
                    scanning = false;
                    return code;
                }
                await Task.Delay(1000);
            }
            return code;
        }

    }
}

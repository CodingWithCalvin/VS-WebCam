using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingWithCalvin.VisualStudioCam
{
    [Guid("79FC33BF-8DA0-477A-B315-5A48A38FD54D")]
    public class ToolWindow : ToolWindowPane
    {
        public ToolWindow()
        {
            Caption = "Webcam";
            Content = new WebcamView();
        }
    }
}

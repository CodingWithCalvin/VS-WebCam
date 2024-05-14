using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace CodingWithCalvin.WebcamStudio
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

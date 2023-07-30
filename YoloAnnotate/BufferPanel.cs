using System.Windows.Forms;

namespace YoloAnnotate
{
    class BufferPanel : Panel
    {
        public BufferPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}

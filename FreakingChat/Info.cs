using System.Drawing;

namespace Chat
{
    public class Info
    {
        public UserInfo FromUser { get; set; }
        public UserInfo ToUser { get; set; } // If message type is whisper
        public string Text { get; set; }
        public Color TextColor { get; set; }

        public Info(string text)
        {
            Text = text;
        }
    }
}
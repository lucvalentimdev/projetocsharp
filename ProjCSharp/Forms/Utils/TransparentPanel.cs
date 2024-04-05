namespace SalSystem.Views.Utils
{
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
            BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

    }
}
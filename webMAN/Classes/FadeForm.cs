using System;
using System.Windows.Forms;

namespace Misc
{
    internal class FadeForm
    {
        Form SForm = null;
        Timer AnimController = new System.Windows.Forms.Timer();
        public FadeForm(Form form)
        {
            SForm = form;
        }
        public void FadeIn()
        {
            AnimController = new System.Windows.Forms.Timer();
            AnimController.Interval = 5;
            AnimController.Tick += (s, e) =>
            {
                if (SForm.Opacity == 1.0)
                {
                    AnimController.Stop();
                    return;
                }
                SForm.Opacity += 0.070;

            };
            AnimController.Start();
        }
        public void FadeOut(EventHandler finished, Form target, double targetValue = 0.0)
        {
            AnimController = new System.Windows.Forms.Timer();
            AnimController.Interval = 5;
            AnimController.Tick += (s, e) =>
            {
                if (SForm.Opacity == targetValue)
                {
                    AnimController.Stop();
                    finished?.Invoke(this, null);
                    return;
                }
                target.Opacity -= 0.070;

            };
            AnimController.Start();
        }
    }
}

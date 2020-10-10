using System;
using System.Windows.Forms;

namespace WinForms.Utils
{
    public class InvokeProgressBar
    {
        public static void SetValue(ProgressBar control, int value)
        {
            void Work(ProgressBar inControl, int inValue)
            {
                inControl.Value = inValue;
            }

            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action(() =>
                    {
                        Work(control, value);
                    }));
                }
                else
                {
                    Work(control, value);
                }
            }
        }

        public static void SetMinimum(ProgressBar control, int value)
        {
            void Work(ProgressBar inControl, int inValue)
            {
                inControl.Minimum = inValue;
            }

            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action(() =>
                    {
                        Work(control, value);
                    }));
                }
                else
                {
                    Work(control, value);
                }
            }
        }

        public static void SetMaximum(ProgressBar control, int value, int sleepTimeOutMs = 10)
        {
            void Work(ProgressBar inControl, int inValue)
            {
                inControl.Maximum = inValue;
            }

            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action(() =>
                    {
                        Work(control, value);
                    }));
                }
                else
                {
                    Work(control, value);
                }
            }
        }
    }
}

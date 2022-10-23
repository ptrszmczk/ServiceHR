using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceHR.UserInterface.Extentions
{
    public static class ExtentionsMethods
    {
        public static void DateTimePickerValueChanged(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Short;
        }
    }
}

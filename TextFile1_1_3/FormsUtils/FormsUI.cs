﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUtils
{
    public class FormsUI
    {
        public static void ErrorMessageBox(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Показать сообщение об ошибке (параметр - исключение)
        public static void ErrorMessageBox(Exception except)
        {
            ErrorMessageBox(String.Format("{0}\n\n{1}", except.Message, except.StackTrace));
        }
    }
}
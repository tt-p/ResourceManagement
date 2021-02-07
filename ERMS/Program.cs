using FP_Group_27.ERMS.ResOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27
{
    static class Program
    {

        private static Stack<Form> forms = new Stack<Form>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form mainForm = new LoginForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            forms.Push(mainForm);
            mainForm.Show();
            Application.Run();
        }

        public static void newForm(Form form)
        {
            if (forms.Count == 0)
            {
                forms.Push(form);
                form.Show();
            }
            else
            {
                Form oF = forms.Pop();
                forms.Push(form);
                form.Location = oF.Location;
                oF.Close();
                form.Show();
            }      
        }

        public static void exit()
        {
            foreach (Form form in forms)
            {
                form.Close();
            }
            Application.Exit();
        }

    }
}

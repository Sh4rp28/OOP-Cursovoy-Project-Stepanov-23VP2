using System;
using System.Windows.Forms;

namespace OOP_Cursovaya
{
    internal static class Program
    {
        /// <summary>
        /// ����� ����� � ���������
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ���������� �������������� �����
            using (var welcomeForm = new WelcomeForm())
            {
                if (welcomeForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new ClientForm());
                }
            
            }
        }
    }
}
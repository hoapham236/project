using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          try
          {
                Employee employee = new Employee();
                if (DateTime.Now.Hour >= 7)
                {
                    employee.updateSalary(DateTime.Today.AddDays(-1).ToString("MM/dd/yyyy"));
                }
            } catch { }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm flogin = new LoginForm();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                flogin.id = flogin.guna2TextBoxid.Text;
                if (!flogin.checkStatus(flogin.id))
                {
                    ResetPasswordF resetPassword = new ResetPasswordF();
                    Application.Run(resetPassword);
                    if (resetPassword.DialogResult == DialogResult.OK)
                    {
                        if (flogin.radioButtonCleaner.Checked)
                        {
                            MainFormCleaner mainFC = new MainFormCleaner();
                            mainFC.id = flogin.id;
                            Application.Run(mainFC);
                        }
                        else if (flogin.radioButtonReceptionist.Checked)
                        {
                            MainFormReceptionist mainFR = new MainFormReceptionist();
                            mainFR.id = flogin.id;
                            Application.Run(mainFR);
                        }
                        else
                        {
                            MainFormManager mainFR = new MainFormManager();
                            mainFR.id = flogin.id;
                            Application.Run(mainFR);
                        }
                    }
                }
                else
                {
                    if (flogin.radioButtonCleaner.Checked)
                    {
                        MainFormCleaner mainFC = new MainFormCleaner();
                        mainFC.id = flogin.id;
                        Application.Run(mainFC);
                    }
                    else if (flogin.radioButtonReceptionist.Checked)
                    {
                        MainFormReceptionist mainFR = new MainFormReceptionist();
                        mainFR.id = flogin.id;
                        Application.Run(mainFR);
                    }    
                    else
                    {
                        MainFormManager mainFR = new MainFormManager();
                        mainFR.id = flogin.id;
                        Application.Run(mainFR);
                    }   
                }
 
            }  
            else
            { 
                Application.Exit(); 
            }

        }
    }
}

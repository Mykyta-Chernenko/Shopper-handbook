using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopper_handbok;

namespace WindowsFormsApplication2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            TimeFromPicker.Format = DateTimePickerFormat.Time;
            TimeFromPicker.ShowUpDown = true;
            TimeToPicker.Format = DateTimePickerFormat.Time;
            TimeToPicker.ShowUpDown = true;
        }       
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        protected virtual void  AddButton_Click(object sender, EventArgs e)
        {
            // Проверка на наличия компании с таким именем 
            if (MainForm.Outlet.IndexOf(NameTxt.Text) == -1)
            {
                // Проверка введеного формата времени 
                string TimeFrom = TimeFromPicker.Text[4] == ':' ?TimeFromPicker.Text.Substring(0, 4) 
                    :TimeFromPicker.Text.Substring(0, 5);
                string TimeTo = TimeToPicker.Text[4] == ':' ? TimeToPicker.Text.Substring(0, 4)
                    : TimeToPicker.Text.Substring(0, 5);


                if (!IsTimeRight(TimeFrom, TimeTo))
                {
                    errorProvider1.SetError(TimeToPicker, "End time is bigger than start");
                    return;
                }
                if(LinesAreFilled(new string[]{NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                    SpecializationTxt.Text, PossetionTxt.Text, TimeFrom, TimeTo }))
                MainForm.Outlet.Add(new Company(NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                    SpecializationTxt.Text, PossetionTxt.Text, TimeFrom, TimeTo));
                this.Close();
            }
            else
            {
                MessageBox.Show("Company with such a name already exists, change that one");
            }
            
        }
        public bool IsTimeRight(string TimeFrom, string TimeTo)
        {
            return DateTime.Parse( TimeFrom)  < DateTime.Parse( TimeTo);
        }
        public bool LineChecker(string text)
        {
            return ((text.Length > 0 && text.Length < 20 && text[0] != '-') || (text.Length == 1 && text[0] == '-')) ;
        }

        private void LineValidating(object sender, CancelEventArgs e)
        {
            Control s = (Control)sender;
            e.Cancel = !LineChecker(s.Text);
            string textError = e.Cancel ? "Line is empty or too large(fill \"-\" instead of space)" : "";
            errorProvider1.SetError((Control)sender, textError);
        }

        private void PhoneTxt_Validating(object sender, CancelEventArgs e)
        {

            e.Cancel = !(PhoneTxt.MaskCompleted && PhoneTxt.Text.Length >= 8 && PhoneTxt.Text.Length <= 12);
            string textError = e.Cancel ? "Wrong number" : "";
            errorProvider1.SetError((Control)sender, textError);
        }

        // Проверка полей ввода на пустоту
        private bool LinesAreFilled(string[] fields)
        {
            foreach(var line in fields)
            {
                if (line.Length == 0)
                    return false;
            }
            return true;
        }
    }
}

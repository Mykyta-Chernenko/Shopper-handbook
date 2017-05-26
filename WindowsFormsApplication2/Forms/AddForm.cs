using System;
using System.ComponentModel;
using System.Windows.Forms;
using Shopper_handbok.Model;

namespace Shopper_handbok.Forms
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
                string timeFrom = TimeFromPicker.Text[4] == ':' ?TimeFromPicker.Text.Substring(0, 4) 
                    :TimeFromPicker.Text.Substring(0, 5);
                string timeTo = TimeToPicker.Text[4] == ':' ? TimeToPicker.Text.Substring(0, 4)
                    : TimeToPicker.Text.Substring(0, 5);


                if (!IsTimeRight(timeFrom, timeTo))
                {
                    errorProvider1.SetError(TimeToPicker, "End time is bigger than start");
                    return;
                }
                if (LinesAreFilled(new string[]
                    {
                        NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                        SpecializationTxt.Text, PossetionTxt.Text, timeFrom, timeTo
                    }))
                {

                    MainForm.Outlet.Add(new Company(NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                        SpecializationTxt.Text, PossetionTxt.Text, timeFrom, timeTo));
                    this.Close();
                }
                else 
                    errorProvider1.SetError(AddButton, "Not all lines are filled");
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
            return (((text.Length > 0 && text.Length < 20 && text[0] != '-') || (text.Length == 1 && text[0] == '-'))
                    && NotAllNumbers(text));
        }

        public bool NotAllNumbers(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 48 || (int)text[i] > 57)
                    return true;
            }
            return false;
        }
        private void LineValidating(object sender, CancelEventArgs e)
        {
            Control s = (Control)sender;
            e.Cancel = !LineChecker(s.Text);
            string textError = e.Cancel ? "Line is empty or too large(fill \"-\" instead of space)" +
                                          " \n Line can't contaion only numbers": "";
            errorProvider1.SetError((Control)sender, textError);
        }

        private void PhoneTxt_Validating(object sender, CancelEventArgs e)
        {

            e.Cancel = !(PhoneTxt.MaskCompleted);
            string textError = e.Cancel ? "Wrong number" : "";
            errorProvider1.SetError((Control)sender, textError);
        }

        // Проверка полей ввода на пустоту
        public bool LinesAreFilled(string[] fields)
        {
            foreach(var line in fields)
            {
                if (line.Length == 0)
                    return false;
            }
            return true;
        }

        private void KeyDownValidation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddButton_Click(sender, null);
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}

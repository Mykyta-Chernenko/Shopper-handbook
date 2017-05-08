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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Form1.outlet.IndexOf(NameTxt.Text) == -1)
            {
                string TimeFrom = TimeFromPicker.Text[4] == ':' ?TimeFromPicker.Text.Substring(0, 4) 
                    :TimeFromPicker.Text.Substring(0, 5);
                string TimeTo = TimeToPicker.Text[4] == ':' ? TimeToPicker.Text.Substring(0, 4)
                    : TimeToPicker.Text.Substring(0, 5);
                if (!IsTimeRight(TimeFrom, TimeTo))
                {
                    errorProvider1.SetError(TimeToPicker, "End time is bigger than start");
                    return;
                }         
                Form1.outlet.Add(new Company(NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
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
        public bool IsNeededLength(string text)
        {
            return !(text.Length > 0 && text.Length < 20);
        }

        private void LineValidating(object sender, CancelEventArgs e)
        {
            TextBox s = (TextBox)sender;
            e.Cancel = IsNeededLength(s.Text);
            string textError = e.Cancel ? "Line is empty or too large" : "";
            errorProvider1.SetError((Control)sender, textError);
        }

        private void PhoneTxt_Validating(object sender, CancelEventArgs e)
        {

            e.Cancel = !(PhoneTxt.MaskCompleted && PhoneTxt.Text.Length == 10);
            string textError = e.Cancel ? "Wrong number" : "";
            errorProvider1.SetError((Control)sender, textError);
        }
    }
}

using Shopper_handbok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ChangeForm : AddForm
    {
        public string ComName;
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }

        protected override void AddButton_Click(object sender, EventArgs e)
        {
            int indexOutlet = MainForm.Outlet.IndexOf(ComName);
            if (indexOutlet != -1)
            {
                // Проверка введеного формата времени 
                string TimeFrom = TimeFromPicker.Text[4] == ':' ? TimeFromPicker.Text.Substring(0, 4)
                        : TimeFromPicker.Text.Substring(0, 5); 
                string TimeTo = TimeToPicker.Text[4] == ':' ? TimeToPicker.Text.Substring(0, 4)
                    : TimeToPicker.Text.Substring(0, 5);

                if (!IsTimeRight(TimeFrom, TimeTo))
                {
                    errorProvider1.SetError(TimeToPicker, "End time is bigger than start");
                    return;
                }
                Company temp = new Company(NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                    SpecializationTxt.Text, PossetionTxt.Text, TimeFrom, TimeTo);
                MainForm.Outlet[indexOutlet] = temp;
            }
                this.Close();
        }
    }
}

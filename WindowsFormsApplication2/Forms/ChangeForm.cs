using System;
using System.Windows.Forms;
using Shopper_handbok.Model;

namespace Shopper_handbok.Forms
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
                string timeFrom = TimeFromPicker.Text[4] == ':'
                    ? TimeFromPicker.Text.Substring(0, 4)
                    : TimeFromPicker.Text.Substring(0, 5);
                string timeTo = TimeToPicker.Text[4] == ':'
                    ? TimeToPicker.Text.Substring(0, 4)
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
                    Company temp = new Company(NameTxt.Text, AdressTxt.Text, PhoneTxt.Text,
                        SpecializationTxt.Text, PossetionTxt.Text, timeFrom, timeTo);
                    MainForm.Outlet[indexOutlet] = temp;
                    this.Close();

                }
                else
                {
                    errorProvider1.SetError(AddButton, "Не все поля заполнени ");
                }

            }
        }
       
    }
}

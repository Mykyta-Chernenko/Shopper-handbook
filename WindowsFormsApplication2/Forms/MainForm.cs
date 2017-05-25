using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApplication2;
using Newtonsoft.Json;
using OfficeOpenXml;
using Shopper_handbok.Model;

namespace Shopper_handbok
{
    public partial class MainForm : Form
    {

        public static Base Outlet = new Base();// База компаний
        public static MainForm Instance; // Ссылка на форму
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
            
            //Привязка данных
            bindingSource1.DataSource = Outlet;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
             
            SearchTimeFromPicker.Format = DateTimePickerFormat.Time;
            SearchTimeFromPicker.ShowUpDown = true;
            SearchTimeToPicker.Format = DateTimePickerFormat.Time;
            SearchTimeToPicker.ShowUpDown = true;
            

        }
        // Открытие базы из текстового файла десериализируя JSON формат
        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                Outlet = JsonConvert.DeserializeObject<Base>(fileText);
            }
            catch
            {
                MessageBox.Show(@"File can't be opened");
            }
            bindingSource1.DataSource = Outlet;
            RefreshBase();
        }
        // Сохранение базы в текстовый файл сериализуя с помощью JSON
        private void Save_click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                string filename = saveFileDialog1.FileName;
                string outletString = JsonConvert.SerializeObject(Outlet);
                File.WriteAllText(filename + ".txt", outletString);
                MessageBox.Show(@"Base has been successfully saved");
            }
            catch {
                MessageBox.Show(@"Base hasn't been saved");
            }
        }
        // Сохранение базы в Excel формат
        private void SaveExcelBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            ExcelPackage excel = new ExcelPackage();

            ExcelWorksheet ws = excel.Workbook.Worksheets.Add("MyWorksheet");

            ws.Cells["A1"].Value = "ID Number";
            int count = 1;
            foreach (Company comp in ((Base)bindingSource1.DataSource))
            {
                Type baseType = comp.GetType();

                char k = 'A';
                foreach (PropertyInfo prop in baseType.GetProperties())
                {
                    ws.Cells[k + "" + count].Value = prop.GetValue(comp);
                    k++;
                }
                count++;
            }
            excel.SaveAs(new FileInfo(filename + ".xlsx"));
            MessageBox.Show(@"Base has been saved");
        }
        
        // Возвращение вида программы к основной базе
        private void ReturnToBase_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Outlet;
            RefreshBase();
        }


        private void AddCompany_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddForm();
            ifrm.ShowDialog();
            bindingSource1.DataSource = Outlet;
            RefreshBase();   
            
        }
        private void DeleteCompany(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                Base currentBase = (Base)bindingSource1.DataSource;
                DialogResult dialogResult = MessageBox.Show(@"Are you sure of deleting company with name: " +
                    currentBase[index].Name, @"Deleting company", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Outlet.RemoveAt(Outlet.IndexOf(currentBase[index].Name));
                    if( !currentBase.Equals(Outlet))currentBase.RemoveAt(index);
                    RefreshBase();
                }
            }

        }
        
        // Обновления привязки после изменения базы
        public void RefreshBase()
        {
            var temp = bindingSource1.DataSource;
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = temp;
        }
        private void Search(object sender, EventArgs e)
        {
            Base temp = new Base();
            foreach (Company x in Outlet)
            {
                temp.Add(x);
            }
            string[] searchLine = { textSearchName.Text, textSearchAddress.Text, textSearchPhone.Text,
                textSearchSpecialization.Text, textSearchPossetion.Text};
            if (LinesAreEmpty(searchLine))
            {
                bindingSource1.DataSource = Outlet;
                return;
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp.Count == 0) break;
                Type baseType = temp[i].GetType();
                int k = 0;
                foreach (PropertyInfo prop in baseType.GetProperties())
                {
                    if (k < 5 && searchLine[k].Trim() == "")
                    {
                        k++;
                        continue;
                    }
                    if (prop.Name == "TimeFrom")
                    {
                        if (DateTime.Parse(prop.GetValue(temp[i]).ToString()) < DateTime.Parse(SearchTimeFromPicker.Text))
                        {
                            temp.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    else if (prop.Name == "TimeTo")
                    {
                        if (DateTime.Parse(prop.GetValue(temp[i]).ToString()) > DateTime.Parse(SearchTimeToPicker.Text))
                        {
                            temp.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        if (prop.GetValue(temp[i]).ToString().ToLower().IndexOf(searchLine[k], StringComparison.Ordinal) == -1)
                        {
                            temp.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    k++;
                }
            }
            bindingSource1.DataSource = temp;

        }

        // Проверка полей ввода 
        public bool LinesAreEmpty(string[] lines)
        {
            foreach (string x in lines)
            {
                if (x.Trim() != "") return false;
            }
            if(SearchTimeFromPicker.Text == @"0:00:00" && SearchTimeToPicker.Text == @"23:59:00")
                return true;
            return false;
        }

        //Редактирование компании 
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Base currentBase = (Base)bindingSource1.DataSource;
                ChangeForm ifrm = new ChangeForm
                {
                    ComName = currentBase[dataGridView1.CurrentRow.Index].Name ,
                    NameTxt = { Text = currentBase[dataGridView1.CurrentRow.Index].Name },
                    PhoneTxt = { Text = currentBase[dataGridView1.CurrentRow.Index].Phone },
                    PossetionTxt = { Text = currentBase[dataGridView1.CurrentRow.Index].Possetion },
                    AdressTxt = { Text = currentBase[dataGridView1.CurrentRow.Index].Address },
                    SpecializationTxt = { Text = currentBase[dataGridView1.CurrentRow.Index].Specialization },
                    TimeFromPicker = { Text = currentBase[dataGridView1.CurrentRow.Index].TimeFrom },
                    TimeToPicker = { Text = currentBase[dataGridView1.CurrentRow.Index].TimeTo },
                    AddButton = { Text = @"Change" },
                    Height = 500,
                    Width = 300
                };
                ifrm.ShowDialog();
                bindingSource1.DataSource = Outlet;
                RefreshBase();
            }
        }


        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Cource on the theme \"Shopper handbook\" \n @Autor: Nikita chernneko \n PZPI-16-1 2017");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search(sender, e);
        }
    }
}


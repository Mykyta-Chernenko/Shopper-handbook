using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static Base outlet = new Base();

        public Form1()        
        {
            InitializeComponent();
            bindingSource1.DataSource = outlet;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
            SearchTimeFromPicker.Format = DateTimePickerFormat.Time;
            SearchTimeFromPicker.ShowUpDown = true;
            SearchTimeToPicker.Format = DateTimePickerFormat.Time;
            SearchTimeToPicker.ShowUpDown = true;
        }
        private void DeleteCompany(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                Base currentBase = (Base)bindingSource1.DataSource;
                DialogResult dialogResult = MessageBox.Show("Are you sure of deleting company with name: " + 
                    currentBase[index].Name, "Deleting company", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    outlet.RemoveAt(outlet.IndexOf(currentBase[index].Name));
                    currentBase.RemoveAt(index);
                    RefreshBase();
                }
            }    
           
        }
        private void Save_click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string outletString= JsonConvert.SerializeObject(outlet);
            System.IO.File.WriteAllText(filename+ ".txt", outletString);
            MessageBox.Show("Base has been successfully saved");
        }
        

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            try {
                string filename = openFileDialog1.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                outlet = JsonConvert.DeserializeObject<Base>(fileText);
            }
            catch
            {
                MessageBox.Show("File can't be opened");
            }
            bindingSource1.DataSource = outlet;
            RefreshBase();
        }
        private void ReturnToBase_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = outlet;
            RefreshBase();
        }

        private void AddCompany_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddForm();
            ifrm.ShowDialog();
            bindingSource1.DataSource = outlet;
            RefreshBase();   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static void Clear(params TextBoxBase[] par)
        {
            for(int i = 0; i < par.Length; i++)
            {
                par[i].Clear();
            }
        }      
        public void RefreshBase()
        {
            var temp = bindingSource1.DataSource;
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = temp;
        }
        private void Search(object sender, KeyEventArgs e)
        {
            Base temp = new Base();
            foreach (Company x in outlet)
            {
                temp.Add(x);
            }
            string[] searchLine = { textSearchName.Text, textSearchAddress.Text, textSearchPhone.Text,
                textSearchSpecialization.Text, textSearchPossetion.Text};
            if (LinesAreEmpty(searchLine))
            {
                bindingSource1.DataSource = outlet;
                return;
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp.Count == 0) break;
                Type BaseType = temp[i].GetType();
                int k = 0;
                foreach (PropertyInfo prop in BaseType.GetProperties())
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
                        if (((prop.GetValue(temp[i]).ToString()).ToLower().IndexOf(searchLine[k]) == -1))
                        {
                            string str1 = prop.GetValue(temp[i]).ToString();
                            string str2 = searchLine[k];
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
        public bool LinesAreEmpty(string[] lines)
        {
            foreach (string x in lines)
            {
                if (x.Trim() != "") return false;
            }
            return true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indexLast = outlet.Count;
                ChangeForm ifrm = new ChangeForm();
                ifrm.NameTxt.Text = outlet[dataGridView1.CurrentRow.Index].Name;
                ifrm.PhoneTxt.Text = outlet[dataGridView1.CurrentRow.Index].Phone;
                ifrm.PossetionTxt.Text = outlet[dataGridView1.CurrentRow.Index].Possetion;
                ifrm.AdressTxt.Text = outlet[dataGridView1.CurrentRow.Index].Address;
                ifrm.SpecializationTxt.Text = outlet[dataGridView1.CurrentRow.Index].Specialization;
                ifrm.TimeFromPicker.Text = outlet[dataGridView1.CurrentRow.Index].TimeFrom;
                ifrm.TimeToPicker.Text = outlet[dataGridView1.CurrentRow.Index].TimeTo;
                ifrm.AddButton.Text = "Change";
                ifrm.Height = 500;
                ifrm.Width = 300;
                ifrm.ShowDialog();
                if (indexLast + 1 == outlet.Count)
                {
                    outlet[dataGridView1.CurrentRow.Index] = outlet[outlet.Count - 1];
                    outlet.RemoveAt(outlet.Count - 1);
                }
                bindingSource1.DataSource = outlet;
                RefreshBase();
            }
        }

        private void SaveExcelBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            ExcelPackage excel = new ExcelPackage();
            
            ExcelWorksheet ws = excel.Workbook.Worksheets.Add("MyWorksheet");

            ws.Cells["A1"].Value = "ID Number";
            int count = 1;
            foreach(Company comp in ((Base)bindingSource1.DataSource))
            {
                Type BaseType = comp.GetType();
                
                char k = 'A';
                foreach (PropertyInfo prop in BaseType.GetProperties()) {
                    ws.Cells[k + "" + count].Value = prop.GetValue(comp);
                    k++;
                }
                count++;                  
            }
            excel.SaveAs(new FileInfo(filename+".xlsx"));          
            MessageBox.Show("Base has been saved");
        }

        
    }
}


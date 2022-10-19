﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGAD_StudentInfoSystem
{
    public partial class Form3 : Form
    {
        bool sideNavExpand;
        bool dgvPanelExpand;
        public Form3()
        {
            InitializeComponent();
            
            //declaring all column names for text fields
            dgv_Student.ColumnCount = 31;
            dgv_Student.Columns[0].Name = "Student Number";
            dgv_Student.Columns[1].Name = "Year Level";
            dgv_Student.Columns[2].Name = "Course";
            dgv_Student.Columns[3].Name = "First Name";
            dgv_Student.Columns[4].Name = "Last Name";
            dgv_Student.Columns[5].Name = "Middle Name";
            dgv_Student.Columns[6].Name = "Extension Name";
            dgv_Student.Columns[7].Name = "Sex";
            dgv_Student.Columns[8].Name = "Civil Status";
            dgv_Student.Columns[9].Name = "Citizenship";
            dgv_Student.Columns[10].Name = "Date of Birth";
            dgv_Student.Columns[11].Name = "Place of Birth";
            dgv_Student.Columns[12].Name = "Age";
            dgv_Student.Columns[13].Name = "Mobile Number";
            dgv_Student.Columns[14].Name = "Email Address";
            dgv_Student.Columns[15].Name = "Barangay/Street";
            dgv_Student.Columns[16].Name = "City";
            dgv_Student.Columns[17].Name = "Province";
            dgv_Student.Columns[18].Name = "District";
            dgv_Student.Columns[19].Name = "Zip Code";
            dgv_Student.Columns[20].Name = "DSWD Household Number";
            dgv_Student.Columns[21].Name = "Household Income per Capital";
            dgv_Student.Columns[22].Name = "Father's First Name";
            dgv_Student.Columns[23].Name = "Father's Last Name";
            dgv_Student.Columns[24].Name = "Father's Extension Name";
            dgv_Student.Columns[25].Name = "Father's Occupation";
            dgv_Student.Columns[26].Name = "Mother's First Name";
            dgv_Student.Columns[27].Name = "Mother's Last Name";
            dgv_Student.Columns[28].Name = "Mother's Extension Name";
            dgv_Student.Columns[29].Name = "Mother's Occupation";
            dgv_Student.Columns[30].Name = "Skills";
        }
        //side navigation timer utilized for transition
        private void sideNavTimer_Tick(object sender, EventArgs e)
        {

            if (!sideNavExpand)
            {
                sideNav.Width -= 30;
                if (sideNav.Width == sideNav.MinimumSize.Width)
                {
                        sideNavExpand = true;
                        sideNavTimer.Stop();
                }
            }
            else
            {
                sideNav.Width += 30;
                if (sideNav.Width == sideNav.MaximumSize.Width)
                {
                        sideNavExpand = false;
                        sideNavTimer.Stop();
                }
            }
        }

        //data grid view timer utilized for transition
        private void dgvPanelTimer_Tick(object sender, EventArgs e)
        {

            if (dgvPanelExpand)
            {
                dgvPanel.Width -= 30;
                dgv_Student.Width -= 30;
                if (dgvPanel.Width == dgvPanel.MinimumSize.Width && dgv_Student.Width == dgv_Student.MinimumSize.Width)
                {
                    dgvPanelExpand = false;
                    dgvPanelTimer.Stop();
                }
            }
            else
            {
                dgvPanel.Width += 30;
                dgv_Student.Width += 30;
                if (dgvPanel.Width == dgvPanel.MaximumSize.Width && dgv_Student.Width == dgv_Student.MaximumSize.Width)
                {
                    dgvPanelExpand = true;
                    dgvPanelTimer.Stop();
                }
            }
        }
        //burger icon
        private void btnSideNav_Click(object sender, EventArgs e)
        {
            sideNavTimer.Start();
            dgvPanelTimer.Start();
        }

        //validation and keypress events
        private void txtStudentNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                e.Cancel = true;
                txtStudentNumber.Focus();
                formErrorProvider.SetError(txtStudentNumber, "Student number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtStudentNumber, "");
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                formErrorProvider.SetError(txtFirstName, "First name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                formErrorProvider.SetError(txtLastName, "Last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtLastName, "");
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                e.Cancel = true;
                txtMiddleName.Focus();
                formErrorProvider.SetError(txtMiddleName, "Student number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtMiddleName, "");
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExtensionName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExtensionName.Text))
            {
                e.Cancel = true;
                txtExtensionName.Focus();
                formErrorProvider.SetError(txtExtensionName, "Extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtExtensionName, "");
            }
        }

        private void txtExtensionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCivilStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCivilStatus.Text))
            {
                e.Cancel = true;
                txtCivilStatus.Focus();
                formErrorProvider.SetError(txtCivilStatus, "Civil status should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtCivilStatus, "");
            }
        }

        private void txtCivilStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCitizenship_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCitizenship.Text))
            {
                e.Cancel = true;
                txtCitizenship.Focus();
                formErrorProvider.SetError(txtCitizenship, "Citizenship should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtCitizenship, "");
            }
        }

        private void txtCitizenship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBirthPlace_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthPlace.Text))
            {
                e.Cancel = true;
                txtBirthPlace.Focus();
                formErrorProvider.SetError(txtBirthPlace, "Birth place should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtBirthPlace, "");
            }
        }

        private void txtBirthPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
            {
                e.Cancel = true;
                txtMobileNumber.Focus();
                formErrorProvider.SetError(txtMobileNumber, "Mobile number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtMobileNumber, "");
            }
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtBarangaySt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarangaySt.Text))
            {
                e.Cancel = true;
                txtBarangaySt.Focus();
                formErrorProvider.SetError(txtBarangaySt, "Barangay or Street should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtBarangaySt, "");
            }
        }

        private void txtBarangaySt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                e.Cancel = true;
                txtCity.Focus();
                formErrorProvider.SetError(txtCity, "City should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtCity, "");
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProvince_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProvince.Text))
            {
                e.Cancel = true;
                txtProvince.Focus();
                formErrorProvider.SetError(txtProvince, "Province should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtProvince, "");
            }
        }

        private void txtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDistrict_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDistrict.Text))
            {
                e.Cancel = true;
                txtDistrict.Focus();
                formErrorProvider.SetError(txtDistrict, "Zip code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtDistrict, "");
            }
        }

        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZipCode.Text))
            {
                e.Cancel = true;
                txtZipCode.Focus();
                formErrorProvider.SetError(txtZipCode, "Zip code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtZipCode, "");
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHouseNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHouseNumber.Text))
            {
                e.Cancel = true;
                txtHouseNumber.Focus();
                formErrorProvider.SetError(txtHouseNumber, "House number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtHouseNumber, "");
            }
        }

        private void txtHouseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHouse_Capital_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHouse_Capital.Text))
            {
                e.Cancel = true;
                txtHouse_Capital.Focus();
                formErrorProvider.SetError(txtHouse_Capital, "Capital should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtHouse_Capital, "");
            }
        }

        private void txtHouse_Capital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtF_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtF_FirstName.Text))
            {
                e.Cancel = true;
                txtF_FirstName.Focus();
                formErrorProvider.SetError(txtF_FirstName, "Father's first name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtF_FirstName, "");
            }
        }

        private void txtF_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtF_LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtF_LastName.Text))
            {
                e.Cancel = true;
                txtF_LastName.Focus();
                formErrorProvider.SetError(txtF_LastName, "Father's last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtF_LastName, "");
            }
        }

        private void txtF_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtF_ExtensionName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtF_ExtensionName.Text))
            {
                e.Cancel = true;
                txtF_ExtensionName.Focus();
                formErrorProvider.SetError(txtF_ExtensionName, "Father's extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtF_ExtensionName, "");
            }
        }

        private void txtF_ExtensionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtF_Occupation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtF_Occupation.Text))
            {
                e.Cancel = true;
                txtF_Occupation.Focus();
                formErrorProvider.SetError(txtF_Occupation, "Father's occupation should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtF_Occupation, "");
            }
        }

        private void txtF_Occupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtM_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM_FirstName.Text))
            {
                e.Cancel = true;
                txtM_FirstName.Focus();
                formErrorProvider.SetError(txtM_FirstName, "Mother's first name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtM_FirstName, "");
            }
        }

        private void txtM_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtM_LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM_LastName.Text))
            {
                e.Cancel = true;
                txtM_LastName.Focus();
                formErrorProvider.SetError(txtM_LastName, "Mother's last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtM_LastName, "");
            }
        }

        private void txtM_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtM_ExtensionName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM_ExtensionName.Text))
            {
                e.Cancel = true;
                txtM_ExtensionName.Focus();
                formErrorProvider.SetError(txtM_ExtensionName, "Mother's extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtM_ExtensionName, "");
            }
        }

        private void txtM_ExtensionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtM_Occupation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM_Occupation.Text))
            {
                e.Cancel = true;
                txtM_Occupation.Focus();
                formErrorProvider.SetError(txtM_Occupation, "Mother's occupation should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                formErrorProvider.SetError(txtM_Occupation, "");
            }
        }

        private void txtM_Occupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //save event, saves all checked and inputs
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = " ", skills = " ";

            if (rbMale.Checked)
                sex = "Male";
            else if (rbFemale.Checked)
                sex = "Female";

            if (chckCpp.Checked)
                skills += "C++";
            if (chckCSharp.Checked)
                skills += "C#";
            if (chckPHP.Checked)
                skills += "Php";
            if (chckJava.Checked)
                skills += "Java";
            if (chckVbDotNet.Checked)
                skills += "VB.Net";
            if (chckPython.Checked)
                skills += "Python";

            MemoryStream ms = new MemoryStream();
            picImage.Image.Save(ms, picImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            dgv_Student.Rows.Add(txtStudentNumber.Text, cmbYearLevel.SelectedItem, cmbCourse.SelectedItem, txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, txtExtensionName.Text, sex,
                                    txtCivilStatus.Text, txtCitizenship.Text, dtpDateOfBirth.Value, txtBirthPlace.Text, numAge.Value, txtMobileNumber.Text, txtEmailAddress.Text, txtBarangaySt.Text,
                                    txtCity.Text, txtProvince.Text, txtDistrict.Text, txtZipCode.Text, txtHouseNumber.Text, txtHouse_Capital.Text, txtF_FirstName.Text, txtF_LastName.Text, txtF_ExtensionName.Text,
                                    txtF_Occupation.Text, txtM_FirstName.Text, txtM_LastName.Text, txtM_ExtensionName.Text, txtM_Occupation.Text, skills, img);
        }

        //uploading image to picture box
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Choose image (*.jpg; *.png; *.gif;) | *.jpg; *.png; *.gif;";

            if (openfile.ShowDialog() == DialogResult.OK)
                picImage.Image = Image.FromFile(openfile.FileName);
        }

        //adding data grid view column for image
        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv_Student.Columns.Add(dgvImage);
        }

        //log out button
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        //back to home
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

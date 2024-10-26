using BloodSeeker.Admin.Controllers;
using BloodSeeker.Components.Client_Information;
using BloodSeeker.Model;
using BloodSeeker.Model.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodSeeker.Admin
{
    public partial class StaffList : Form
    {
        ClientStaffInformationTab tab;
        StaffListController controller;
        StaffRepository staffRepository;
        public StaffList()
        {
            InitializeComponent();
            staffRepository = new StaffRepository(); 
            LoadStaff();
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {
            controller = new StaffListController();
            for (int i = 0; i < controller.getStaffLength(); i++)
            {
                tab = new ClientStaffInformationTab(
                    controller.getStaffList()[i].firstname,
                    controller.getStaffList()[i].lastname,
                    controller.getStaffList()[i].sex,
                    controller.getStaffList()[i].phone,
                    controller.getStaffList()[i].email,
                    controller.getStaffList()[i].address,
                    controller.getStaffList()[i].birthdate
                    );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }
        private void LoadStaff(List<Staff> staffToDisplay = null)
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing entries
            var staffList = staffToDisplay ?? staffRepository.getStaff();
            foreach (var staff in staffList)
            {
                tab = new ClientStaffInformationTab(
                    staff.firstname,
                    staff.lastname,
                    staff.sex,
                    staff.phone,
                    staff.email,
                    staff.address,
                    staff.birthdate
                );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            changePanel(new AddStaff());
        }
        public void changePanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = guna2TextBox1.Text.Trim();
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(searchTerm))
            {
                var allStaff = controller.getStaffList(); 
                foreach (var staff in allStaff)
                {
                    var tab = new ClientStaffInformationTab(
                        staff.firstname,
                        staff.lastname,
                        staff.sex,
                        staff.phone,
                        staff.email,
                        staff.address,
                        staff.birthdate
                    );
                    tab.BackColor = Color.FromArgb(36, 36, 36);
                    flowLayoutPanel1.Controls.Add(tab);
                }
                return;
            }

            List<Staff> searchResults = new List<Staff>();

            if (int.TryParse(searchTerm, out int staffId))
            {
                searchResults = staffRepository.searchStaffById(staffId);
            }
            else
            {
                var nameParts = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (nameParts.Length == 1)
                {
                    var firstNameResults = staffRepository.searchStaffByFirstName(nameParts[0]);
                    var lastNameResults = staffRepository.searchStaffByLastName(nameParts[0]);

                    searchResults = firstNameResults.Concat(lastNameResults).Distinct().ToList();
                }
                else if (nameParts.Length >= 2)
                {
                    var firstNameResults = staffRepository.searchStaffByFirstName(nameParts[0]);
                    var lastNameResults = staffRepository.searchStaffByLastName(nameParts[1]);

                    searchResults = firstNameResults
                        .Where(staff => lastNameResults.Any(lr => lr.staffId == staff.staffId))
                        .ToList();
                }
            }

            foreach (var staff in searchResults)
            {
                var tab = new ClientStaffInformationTab(
                    staff.firstname,
                    staff.lastname,
                    staff.sex,
                    staff.phone,
                    staff.email,
                    staff.address,
                    staff.birthdate
                );
                tab.BackColor = Color.FromArgb(36, 36, 36);
                flowLayoutPanel1.Controls.Add(tab);
             }
            }
    }
}

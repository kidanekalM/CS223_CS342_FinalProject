using Real_Estate_App.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientAppointmentPage : Form
    {
        private ClientContainer container;
        private int UserId;
        private int AppointmentId = 0;

        public ClientAppointmentPage(ClientContainer container, int userId)
        {
            InitializeComponent();

            this.container = container;
            UserId = userId;
            DisplayAppointments();
        }

        private void btn_CancleAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    if (AppointmentId != 0)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are you sure you want to cancle the appointment?", "Cancle appointment", buttons);
                        if (result == DialogResult.Yes)
                        {
                            rm.Delete_Appointment(AppointmentId);
                            MessageBox.Show("Appointment cancled!");
                            DisplayAppointments();
                        }
                    }
                    else
                        MessageBox.Show("You have to select an appointment first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to cancle appointment! \n" + ex.Message);
            }
        }

        private void dgv_AppointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_AppointmentTable.Rows[e.RowIndex];

                AppointmentId = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void DisplayAppointments()
        {
            try
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    var appointments = rm.Search_Appointment_By_ClientID(UserId).ToList();
                    if (appointments.Count > 0)
                        dgv_AppointmentTable.DataSource = appointments;
                    else if (appointments.Count == 0)
                    {
                        MessageBox.Show("There are no appointments yet!");
                        ClientHomePage homePage = new ClientHomePage();
                        homePage.MdiParent = container;
                        homePage.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load appointments! \n" + ex.Message);
            }
        }
    }
}


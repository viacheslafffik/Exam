using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Panels
{
    public partial class PanelAppointment : UserControl
    {
        private Form1 main;

        public PanelAppointment(Form1 form)
        {
            InitializeComponent();
            main = form;
            DateAppointment.Value = DateTime.Today;
            ListServices.DataSource = null;
            ListServices.DataSource = main.Services;
            ListServices.DisplayMember = "Name";
        }

        private void ButtonAddAppointment_Click(object sender, EventArgs e)
        {
            for (int i = main.Services.Count - 1; i >= 0; i--)
            {
                var nm = main.Services[i]?.Name;
                if (nm.Length == 0) main.Services.RemoveAt(i);
            }

            if (ListServices.CheckedItems.Count == 0) return;      

            var selected = new List<string>();

            foreach (var item in ListServices.CheckedItems)
            {
                if (item is Service s)
                {
                    var nm = s.Name;
                    if (nm.Length > 0) selected.Add(nm);
                }
            }

            selected = selected.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            if (selected.Count == 0)
            {
                MessageBox.Show("Оберіть хоча б одну послугу");
                return;
            }

            main.Appointments.Add(new Appointment
            {
                Date = DateAppointment.Value.Date,
                Services = selected
            });

            for (int i = 0; i < ListServices.Items.Count; i++) ListServices.SetItemChecked(i, false);
            MessageBox.Show("Запис успішно додано");
        }
    }
}

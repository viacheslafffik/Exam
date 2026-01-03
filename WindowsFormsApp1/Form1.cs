using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public BindingList<Service> Services { get; } = new BindingList<Service>();
        public BindingList<Appointment> Appointments { get; } = new BindingList<Appointment>();

        private readonly Dictionary<string, UserControl> cache = new Dictionary<string, UserControl>();

        public Form1()
        {
            InitializeComponent();
            Open("price");
        }

        private void ButtonPrice_Click(object sender, System.EventArgs e) => Open("price");
        private void ButtonAppointment_Click(object sender, System.EventArgs e) => Open("appointment");
        private void ButtonTop_Click(object sender, System.EventArgs e) => Open("top");

        private void Open(string key)
        {
            if (!cache.TryGetValue(key, out var page))
            {
                if (key == "price") page = new Panels.PanelPrice(this);
                else if (key == "appointment") page = new Panels.PanelAppointment(this);
                else page = new Panels.PanelTop(this);
                page.Dock = DockStyle.Fill;
                cache[key] = page;
            }

            PanelContainer.SuspendLayout();
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(page);
            PanelContainer.ResumeLayout();
        }
    }
}

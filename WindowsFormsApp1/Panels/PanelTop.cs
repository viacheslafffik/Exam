using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Panels
{
    public partial class PanelTop : UserControl
    {
        private readonly Form1 main;

        public PanelTop(Form1 form)
        {
            InitializeComponent();
            main = form;
            TopDate.Value = DateTime.Today;
            ButtonShow.Click += ButtonShow_Click;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            var date = TopDate.Value.Date;
            var stat = new Dictionary<string, int>();

            foreach (var a in main.Appointments)
            {
                if (a.Date != date) continue;
                foreach (var s in a.Services)
                {
                    if (string.IsNullOrWhiteSpace(s)) continue;
                    stat[s] = stat.TryGetValue(s, out var c) ? c + 1 : 1;
                }
            }
            TopList.Items.Clear();
            if (stat.Count == 0)
            {
                TopList.Items.Add("На цю дату записів немає");
                return;
            }
            int i = 1;
            foreach (var t in stat.OrderByDescending(x => x.Value).Take(3)) TopList.Items.Add($"{i++}. {t.Key} — {t.Value} раз(и)");
        }

    }
}

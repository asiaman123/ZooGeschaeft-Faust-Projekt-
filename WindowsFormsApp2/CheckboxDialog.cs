using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{// Diese Klasse habe ich aus Stackoverflow und habe diese entsprechend angepasst

    // https://stackoverflow.com/questions/17385895/how-to-show-a-messagebox-with-a-checkbox

    public static class CheckboxDialog
    {
        public static bool ShowDialog(string text,string text2, string caption)
        {   
            Boolean checks = false;
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 200;
            prompt.Text = caption;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            CheckBox chk = new CheckBox();
            CheckBox chk2 = new CheckBox();
            chk.Text = text;
            chk2.Text = text2;
            chk.AutoSize = false;
            chk2.AutoSize = false;
            Button ok = new Button() { Text = "Yes" };
            ok.Click += (sender, e) => { prompt.Close(); };
            panel.Controls.Add(chk);
            panel.Controls.Add(chk2);
            panel.SetFlowBreak(chk, true);
            panel.SetFlowBreak(chk2, true);
            panel.Controls.Add(ok); 
            prompt.Controls.Add(panel);
            prompt.ShowDialog();
            if(chk.Checked && chk2.Checked)
            {
                checks = true;

            }
            return checks;
        }
    }
}

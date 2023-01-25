using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xRegistryEditor
{
    public partial class SettingDialog : Form
    {
        public Main mainForm;

        public SettingDialog(IEnumerable<SettingEntry> entries, Main form)
        {
            InitializeComponent();
            mainForm = form;
            foreach(SettingEntry entry in entries)
            {
                cbSettings.Items.Add(entry);
            }
            txtLength.Maximum = UInt16.MaxValue;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (cbSettings.SelectedItem == null || cbSettings.SelectedItem.GetType() != typeof(SettingEntry))
                return;
            if (!rad0.Checked && !rad1.Checked && !rad2.Checked)
                return;
            if (rad1.Checked && (txtLength.Value == 0 || txtLength.Value % 2 == 1))
                return;
            SettingDataEntry entry = new SettingDataEntry
                                         {
                                             Flags = 0,
                                             FileNameEntry = ((SettingEntry) cbSettings.SelectedItem),
                                             FileNameOffset =
                                                 (ushort) (((SettingEntry) cbSettings.SelectedItem).Offset - 0x10),
                                             Checksum = 0,
                                             Length = (ushort) txtLength.Value,
                                             Terminator = 0

                                         };
            if (rad0.Checked)
            {
                entry.Type = 0;
                entry.Value = new byte[(int)txtLength.Value];
            }
            if (rad1.Checked)
            {
                entry.Type = 1;
                entry.Value = (byte) 0;
            }
            if (rad2.Checked)
            {
                entry.Type = 2;
                entry.Value = new byte[(int) txtLength.Value];
            }
            mainForm.DataEntries.Add(entry);
            mainForm.LoadEntries();
            DialogResult = DialogResult.OK;
        }
    }
}

using System.ComponentModel;
using System.Windows.Forms;

namespace PSS3
{
    public class ChangableMenuListView : ListView
    {
        protected override void OnItemSelectionChanged(ListViewItemSelectionChangedEventArgs e)
        {
            base.OnItemSelectionChanged(e);

            int selectedCount = SelectedIndices.Count;

            if (selectedCount > 1)
            {
                ContextMenuStrip = MultiSelectedContextMenuStrip;
            }
            else
            {
                ContextMenuStrip = SingleSelectedContextMenuStrip;
            }
        }

        [Browsable(true)]
        [Category("Behavior")]
        public ContextMenuStrip MultiSelectedContextMenuStrip
        {
            get;
            set;
        }

        [Browsable(true)]
        [Category("Behavior")]
        public ContextMenuStrip SingleSelectedContextMenuStrip
        {
            get;
            set;
        }
    }
}

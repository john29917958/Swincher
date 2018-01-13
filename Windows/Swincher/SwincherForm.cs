using System.ComponentModel;
using System.Windows.Forms;
using Swincher.Core;

namespace Swincher
{
    public partial class SwincherForm : Form
    {
        private readonly Config _config;

        public SwincherForm()
        {
            InitializeComponent();
            _config = Config.Load();

            foreach (Swincher.Core.Binding binding in _config.Bindings)
            {
                Bindings.Add(binding);
            }

            Bindings.AddNew();
        }

        private void BindingGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Swincher.Core.Binding lastRecord = (Swincher.Core.Binding) Bindings[Bindings.Count - 1];

            if (!lastRecord.IsEmpty)
            {
                BindingGridView.AddNewRow();
            }
            else
            {
                DeleteDuplicateEmptyRows();
            }
        }

        private void DeleteDuplicateEmptyRows()
        {
            while (Bindings.Count > 1 &&
                   ((Swincher.Core.Binding) Bindings[Bindings.Count - 1]).IsEmpty &&
                   ((Swincher.Core.Binding) Bindings[Bindings.Count - 2]).IsEmpty)
            {
                BindingGridView.DeleteRow(Bindings.Count - 1);
            }
        }
    }
}

using System.ComponentModel;
using System.Windows.Forms;
using Swincher.Core;

namespace Swincher
{
    public partial class SwincherForm : Form
    {
        private readonly Config _config;
        private readonly BindingList<Swincher.Core.Binding> _bindings;

        public SwincherForm()
        {
            InitializeComponent();
            _config = Config.Load();
            _bindings = new BindingList<Swincher.Core.Binding>(_config.Bindings);
            BindingGrid.DataSource = _bindings;
            BindingGridView.AddNewRow();
        }

        private void BindingGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Swincher.Core.Binding lastRecord =_bindings[_bindings.Count - 1];

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
            while (_bindings.Count > 1 &&
                _bindings[_bindings.Count - 1].IsEmpty &&
                _bindings[_bindings.Count - 2].IsEmpty)
            {
                BindingGridView.DeleteRow(_bindings.Count - 1);
            }
        }
    }
}

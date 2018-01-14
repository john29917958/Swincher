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

            foreach (AppBinding binding in _config.Bindings)
            {
                Bindings.Add(binding);
            }
        }

        private void BindingGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                BindingsGridView.DeleteSelectedRows();
            }
        }
    }
}

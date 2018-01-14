using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Swincher.Core;
using Swincher.Core.Configuration;
using Swincher.Core.Key;

namespace Swincher
{
    public partial class SwincherForm : Form
    {
        private readonly Config _config;
        private readonly List<KeyCode> _keyCombination;

        public SwincherForm()
        {
            InitializeComponent();

            _keyCombination = new List<KeyCode>();

            _config = Config.Load();
            BindingsGrid.DataSource = _config.Bindings;
            StartWithOsCheckBox.Checked = _config.StartWithOs;
            AutoActivateCheckBox.Checked = _config.AutoActivate;
            AutoOpenAppCheckBox.Checked = _config.AutoOpenApps;
        }

        private void BindingGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BindingsGridView.DeleteSelectedRows();
            }
        }

        private void StartWithOsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.StartWithOs = StartWithOsCheckBox.Checked;
        }

        private void AutoActivateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.AutoActivate = AutoActivateCheckBox.Checked;
        }

        private void AutoOpenAppCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _config.AutoOpenApps = AutoOpenAppCheckBox.Checked;
        }

        private void SwitchModeKeysInput_Enter(object sender, EventArgs e)
        {
            SwitchModeKeysInput.Text = string.Empty;
            _keyCombination.Clear();
        }

        private void SwitchModeKeysInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (!SwitchModeKeysInput.IsEditorActive) return;
            if (e.Modifiers == Keys.None) return;

            if (e.KeyCode == Keys.Escape)
            {
                _keyCombination.Clear();
                _keyCombination.AddRange(_config.EnterSwitchingModeKeys);
                GeneralPage.Focus();
                UpdateSwitchModeKeysInputText();
                return;
            }

            if (e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ShiftKey)
            {
                _keyCombination.Clear();
                if (e.Control)
                {
                    _keyCombination.Add(KeyCode.Control);
                }
                if (e.Shift)
                {
                    _keyCombination.Add(KeyCode.Shift);
                }
                if (e.Alt)
                {
                    _keyCombination.Add(KeyCode.Alt);
                }
                string keyName = e.KeyCode.ToString();
                _keyCombination.Add((KeyCode)Enum.Parse(typeof(KeyCode), keyName));

                UpdateSwitchModeKeysInputText();
            }
        }

        private void UpdateSwitchModeKeysInputText()
        {
            SwitchModeKeysInput.Text = string.Empty;

            foreach (KeyCode key in _keyCombination)
            {
                SwitchModeKeysInput.Text += key.ToString() + ", ";
            }

            SwitchModeKeysInput.Text = SwitchModeKeysInput.Text.Substring(0, SwitchModeKeysInput.Text.Length - 2);
        }
    }
}

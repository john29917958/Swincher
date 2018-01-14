using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Swincher.Core;
using Swincher.Core.Configuration;
using Swincher.Core.Key;
using Swincher.Support;

namespace Swincher
{
    public partial class SwincherForm : Form
    {
        private readonly Config _config;
        private readonly KeyCombination _keyCombination;
        private readonly List<KeyCode> _switchingModeKeyCombination;
        private readonly HashSet<Keys> _pressedKeys;

        public SwincherForm()
        {
            InitializeComponent();

            _keyCombination = new KeyCombination();
            _switchingModeKeyCombination = new List<KeyCode>();
            _pressedKeys = new HashSet<Keys>();

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
            _keyCombination.Reset();
        }

        private void SwitchModeKeysInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (_pressedKeys.Count == 0)
            {
                _keyCombination.Reset();
            }

            _pressedKeys.Add(e.KeyCode);
            if (e.KeyCode == Keys.Escape)
            {
                _keyCombination.Reset();
                _keyCombination.Keys.AddRange(_config.EnterSwitchingModeKeys);
                UpdateSwitchModeKeysInputText();
                return;
            }

            _keyCombination.Next(KeyCodeConverter.Convert(e.KeyCode));
            UpdateSwitchModeKeysInputText();
        }

        private void UpdateSwitchModeKeysInputText()
        {
            SwitchModeKeysInput.Text = _keyCombination.ToString();
        }

        private void SwitchModeKeysInput_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedKeys.Remove(e.KeyCode);
            if (e.Modifiers != Keys.None) return;

            if (_pressedKeys.Count == 0 && !_keyCombination.HasNonModifier())
            {
                _keyCombination.Reset();
            }

            UpdateSwitchModeKeysInputText();
        }
    }
}

namespace Swincher
{
    partial class SwincherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.Tabs = new DevExpress.XtraTab.XtraTabControl();
            this.HomePage = new DevExpress.XtraTab.XtraTabPage();
            this.ActivatePanel = new DevExpress.XtraEditors.PanelControl();
            this.ActivateButton = new DevExpress.XtraEditors.SimpleButton();
            this.HeadingPanel = new DevExpress.XtraEditors.PanelControl();
            this.HeadingLabel = new DevExpress.XtraEditors.LabelControl();
            this.SubtitleLabel = new DevExpress.XtraEditors.LabelControl();
            this.GeneralPage = new DevExpress.XtraTab.XtraTabPage();
            this.SwitchModePanel = new DevExpress.XtraEditors.PanelControl();
            this.SwitchModeKeysInput = new DevExpress.XtraEditors.TextEdit();
            this.SwitchModeLabel = new DevExpress.XtraEditors.LabelControl();
            this.AutoOpenAppCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.AutoActivateCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.StartWithOsCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.BindingsPage = new DevExpress.XtraTab.XtraTabPage();
            this.BindingsGrid = new DevExpress.XtraGrid.GridControl();
            this.BindingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApplicationPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeys = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).BeginInit();
            this.Tabs.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivatePanel)).BeginInit();
            this.ActivatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingPanel)).BeginInit();
            this.HeadingPanel.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchModePanel)).BeginInit();
            this.SwitchModePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchModeKeysInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoOpenAppCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoActivateCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWithOsCheckBox.Properties)).BeginInit();
            this.BindingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Theme
            // 
            this.Theme.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // Tabs
            // 
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedTabPage = this.HomePage;
            this.Tabs.Size = new System.Drawing.Size(384, 211);
            this.Tabs.TabIndex = 0;
            this.Tabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.HomePage,
            this.GeneralPage,
            this.BindingsPage});
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.ActivatePanel);
            this.HomePage.Controls.Add(this.HeadingPanel);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(382, 184);
            this.HomePage.Text = "Home";
            // 
            // ActivatePanel
            // 
            this.ActivatePanel.Appearance.Options.UseTextOptions = true;
            this.ActivatePanel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ActivatePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ActivatePanel.Controls.Add(this.ActivateButton);
            this.ActivatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivatePanel.Location = new System.Drawing.Point(0, 71);
            this.ActivatePanel.Name = "ActivatePanel";
            this.ActivatePanel.Size = new System.Drawing.Size(382, 113);
            this.ActivatePanel.TabIndex = 2;
            // 
            // ActivateButton
            // 
            this.ActivateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActivateButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ActivateButton.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ActivateButton.Appearance.Options.UseBackColor = true;
            this.ActivateButton.Location = new System.Drawing.Point(151, 41);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(80, 30);
            this.ActivateButton.TabIndex = 0;
            this.ActivateButton.Text = "Activate";
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.HeadingPanel.Controls.Add(this.HeadingLabel);
            this.HeadingPanel.Controls.Add(this.SubtitleLabel);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(382, 71);
            this.HeadingPanel.TabIndex = 1;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.HeadingLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.HeadingLabel.Appearance.Options.UseFont = true;
            this.HeadingLabel.Appearance.Options.UseForeColor = true;
            this.HeadingLabel.Appearance.Options.UseTextOptions = true;
            this.HeadingLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HeadingLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.HeadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadingLabel.Location = new System.Drawing.Point(0, 0);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(382, 58);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Swincher";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Appearance.Options.UseTextOptions = true;
            this.SubtitleLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubtitleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.SubtitleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubtitleLabel.Location = new System.Drawing.Point(0, 58);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(382, 13);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Easy window switching. Level ups your efficiency";
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.SwitchModePanel);
            this.GeneralPage.Controls.Add(this.AutoOpenAppCheckBox);
            this.GeneralPage.Controls.Add(this.AutoActivateCheckBox);
            this.GeneralPage.Controls.Add(this.StartWithOsCheckBox);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(382, 184);
            this.GeneralPage.Text = "General";
            // 
            // SwitchModePanel
            // 
            this.SwitchModePanel.Controls.Add(this.SwitchModeKeysInput);
            this.SwitchModePanel.Controls.Add(this.SwitchModeLabel);
            this.SwitchModePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchModePanel.Location = new System.Drawing.Point(0, 57);
            this.SwitchModePanel.Name = "SwitchModePanel";
            this.SwitchModePanel.Size = new System.Drawing.Size(382, 39);
            this.SwitchModePanel.TabIndex = 3;
            // 
            // SwitchModeKeysInput
            // 
            this.SwitchModeKeysInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchModeKeysInput.Location = new System.Drawing.Point(2, 15);
            this.SwitchModeKeysInput.Name = "SwitchModeKeysInput";
            this.SwitchModeKeysInput.Properties.NullText = "< Press keys... >";
            this.SwitchModeKeysInput.Size = new System.Drawing.Size(378, 20);
            this.SwitchModeKeysInput.TabIndex = 1;
            this.SwitchModeKeysInput.Enter += new System.EventHandler(this.SwitchModeKeysInput_Enter);
            this.SwitchModeKeysInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SwitchModeKeysInput_KeyDown);
            this.SwitchModeKeysInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SwitchModeKeysInput_KeyUp);
            // 
            // SwitchModeLabel
            // 
            this.SwitchModeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchModeLabel.Location = new System.Drawing.Point(2, 2);
            this.SwitchModeLabel.Name = "SwitchModeLabel";
            this.SwitchModeLabel.Size = new System.Drawing.Size(214, 13);
            this.SwitchModeLabel.TabIndex = 0;
            this.SwitchModeLabel.Text = "Key combination for entering switching mode";
            // 
            // AutoOpenAppCheckBox
            // 
            this.AutoOpenAppCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoOpenAppCheckBox.Location = new System.Drawing.Point(0, 38);
            this.AutoOpenAppCheckBox.Name = "AutoOpenAppCheckBox";
            this.AutoOpenAppCheckBox.Properties.Caption = "Auto. opens all applications in bindings list once activated";
            this.AutoOpenAppCheckBox.Size = new System.Drawing.Size(382, 19);
            this.AutoOpenAppCheckBox.TabIndex = 2;
            this.AutoOpenAppCheckBox.CheckedChanged += new System.EventHandler(this.AutoOpenAppCheckBox_CheckedChanged);
            // 
            // AutoActivateCheckBox
            // 
            this.AutoActivateCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoActivateCheckBox.Location = new System.Drawing.Point(0, 19);
            this.AutoActivateCheckBox.Name = "AutoActivateCheckBox";
            this.AutoActivateCheckBox.Properties.Caption = "Auto. activated once Swincher is opened";
            this.AutoActivateCheckBox.Size = new System.Drawing.Size(382, 19);
            this.AutoActivateCheckBox.TabIndex = 1;
            this.AutoActivateCheckBox.CheckedChanged += new System.EventHandler(this.AutoActivateCheckBox_CheckedChanged);
            // 
            // StartWithOsCheckBox
            // 
            this.StartWithOsCheckBox.AutoSizeInLayoutControl = true;
            this.StartWithOsCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartWithOsCheckBox.Location = new System.Drawing.Point(0, 0);
            this.StartWithOsCheckBox.Name = "StartWithOsCheckBox";
            this.StartWithOsCheckBox.Properties.Caption = "Start with Windows";
            this.StartWithOsCheckBox.Size = new System.Drawing.Size(382, 19);
            this.StartWithOsCheckBox.TabIndex = 0;
            this.StartWithOsCheckBox.CheckedChanged += new System.EventHandler(this.StartWithOsCheckBox_CheckedChanged);
            // 
            // BindingsPage
            // 
            this.BindingsPage.Controls.Add(this.BindingsGrid);
            this.BindingsPage.Name = "BindingsPage";
            this.BindingsPage.Size = new System.Drawing.Size(382, 184);
            this.BindingsPage.Text = "Bindings";
            // 
            // BindingsGrid
            // 
            this.BindingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingsGrid.Location = new System.Drawing.Point(0, 0);
            this.BindingsGrid.MainView = this.BindingsGridView;
            this.BindingsGrid.Name = "BindingsGrid";
            this.BindingsGrid.Size = new System.Drawing.Size(382, 184);
            this.BindingsGrid.TabIndex = 0;
            this.BindingsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BindingsGridView});
            // 
            // BindingsGridView
            // 
            this.BindingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApplicationPath,
            this.colKeys});
            this.BindingsGridView.GridControl = this.BindingsGrid;
            this.BindingsGridView.Name = "BindingsGridView";
            this.BindingsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.BindingsGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindingGridView_KeyDown);
            // 
            // colApplicationPath
            // 
            this.colApplicationPath.FieldName = "ApplicationPath";
            this.colApplicationPath.Name = "colApplicationPath";
            this.colApplicationPath.Visible = true;
            this.colApplicationPath.VisibleIndex = 0;
            // 
            // colKeys
            // 
            this.colKeys.FieldName = "Keys";
            this.colKeys.Name = "colKeys";
            this.colKeys.Visible = true;
            this.colKeys.VisibleIndex = 1;
            // 
            // SwincherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.Tabs);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "SwincherForm";
            this.Text = "Swincher";
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActivatePanel)).EndInit();
            this.ActivatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingPanel)).EndInit();
            this.HeadingPanel.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SwitchModePanel)).EndInit();
            this.SwitchModePanel.ResumeLayout(false);
            this.SwitchModePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchModeKeysInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoOpenAppCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoActivateCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWithOsCheckBox.Properties)).EndInit();
            this.BindingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel Theme;
        private DevExpress.XtraTab.XtraTabControl Tabs;
        private DevExpress.XtraTab.XtraTabPage BindingsPage;
        private DevExpress.XtraTab.XtraTabPage GeneralPage;
        private DevExpress.XtraGrid.GridControl BindingsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView BindingsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationPath;
        private DevExpress.XtraGrid.Columns.GridColumn colKeys;
        private DevExpress.XtraEditors.CheckEdit AutoOpenAppCheckBox;
        private DevExpress.XtraEditors.CheckEdit AutoActivateCheckBox;
        private DevExpress.XtraEditors.CheckEdit StartWithOsCheckBox;
        private DevExpress.XtraEditors.PanelControl SwitchModePanel;
        private DevExpress.XtraEditors.TextEdit SwitchModeKeysInput;
        private DevExpress.XtraEditors.LabelControl SwitchModeLabel;
        private DevExpress.XtraTab.XtraTabPage HomePage;
        private DevExpress.XtraEditors.PanelControl ActivatePanel;
        private DevExpress.XtraEditors.PanelControl HeadingPanel;
        private DevExpress.XtraEditors.LabelControl SubtitleLabel;
        private DevExpress.XtraEditors.LabelControl HeadingLabel;
        private DevExpress.XtraEditors.SimpleButton ActivateButton;
    }
}
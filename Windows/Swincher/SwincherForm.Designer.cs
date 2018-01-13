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
            this.BindingsPage = new DevExpress.XtraTab.XtraTabPage();
            this.BindingGrid = new DevExpress.XtraGrid.GridControl();
            this.Bindings = new System.Windows.Forms.BindingSource();
            this.BindingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeys = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GeneralPage = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).BeginInit();
            this.Tabs.SuspendLayout();
            this.BindingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingGridView)).BeginInit();
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
            this.Tabs.SelectedTabPage = this.BindingsPage;
            this.Tabs.Size = new System.Drawing.Size(459, 261);
            this.Tabs.TabIndex = 0;
            this.Tabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.BindingsPage,
            this.GeneralPage});
            // 
            // BindingsPage
            // 
            this.BindingsPage.Controls.Add(this.BindingGrid);
            this.BindingsPage.Name = "BindingsPage";
            this.BindingsPage.Size = new System.Drawing.Size(457, 234);
            this.BindingsPage.Text = "Bindings";
            // 
            // BindingGrid
            // 
            this.BindingGrid.DataSource = this.Bindings;
            this.BindingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingGrid.Location = new System.Drawing.Point(0, 0);
            this.BindingGrid.MainView = this.BindingGridView;
            this.BindingGrid.Name = "BindingGrid";
            this.BindingGrid.Size = new System.Drawing.Size(457, 234);
            this.BindingGrid.TabIndex = 0;
            this.BindingGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BindingGridView});
            // 
            // Bindings
            // 
            this.Bindings.DataSource = typeof(Swincher.Core.Binding);
            // 
            // BindingGridView
            // 
            this.BindingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExePath,
            this.colKeys});
            this.BindingGridView.GridControl = this.BindingGrid;
            this.BindingGridView.Name = "BindingGridView";
            this.BindingGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.BindingGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.BindingGridView.OptionsSelection.MultiSelect = true;
            this.BindingGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.BindingGridView_CellValueChanged);
            this.BindingGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindingGridView_KeyDown);
            // 
            // colExePath
            // 
            this.colExePath.FieldName = "ExePath";
            this.colExePath.Name = "colExePath";
            this.colExePath.Visible = true;
            this.colExePath.VisibleIndex = 0;
            // 
            // colKeys
            // 
            this.colKeys.FieldName = "Keys";
            this.colKeys.Name = "colKeys";
            this.colKeys.Visible = true;
            this.colKeys.VisibleIndex = 1;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(457, 234);
            this.GeneralPage.Text = "General";
            // 
            // SwincherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.Tabs);
            this.Name = "SwincherForm";
            this.Text = "Swincher";
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.BindingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel Theme;
        private DevExpress.XtraTab.XtraTabControl Tabs;
        private DevExpress.XtraTab.XtraTabPage BindingsPage;
        private DevExpress.XtraTab.XtraTabPage GeneralPage;
        private DevExpress.XtraGrid.GridControl BindingGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView BindingGridView;
        private System.Windows.Forms.BindingSource Bindings;
        private DevExpress.XtraGrid.Columns.GridColumn colExePath;
        private DevExpress.XtraGrid.Columns.GridColumn colKeys;
    }
}
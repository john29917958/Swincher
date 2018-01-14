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
            this.GeneralPage = new DevExpress.XtraTab.XtraTabPage();
            this.Bindings = new System.Windows.Forms.BindingSource();
            this.BindingsGrid = new DevExpress.XtraGrid.GridControl();
            this.BindingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApplicationPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeys = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).BeginInit();
            this.Tabs.SuspendLayout();
            this.BindingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).BeginInit();
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
            this.Tabs.SelectedTabPage = this.BindingsPage;
            this.Tabs.Size = new System.Drawing.Size(459, 261);
            this.Tabs.TabIndex = 0;
            this.Tabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.BindingsPage,
            this.GeneralPage});
            // 
            // BindingsPage
            // 
            this.BindingsPage.Controls.Add(this.BindingsGrid);
            this.BindingsPage.Name = "BindingsPage";
            this.BindingsPage.Size = new System.Drawing.Size(457, 234);
            this.BindingsPage.Text = "Bindings";
            // 
            // GeneralPage
            // 
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(457, 234);
            this.GeneralPage.Text = "General";
            // 
            // Bindings
            // 
            this.Bindings.DataSource = typeof(Swincher.Core.AppBinding);
            // 
            // BindingsGrid
            // 
            this.BindingsGrid.DataSource = this.Bindings;
            this.BindingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingsGrid.Location = new System.Drawing.Point(0, 0);
            this.BindingsGrid.MainView = this.BindingsGridView;
            this.BindingsGrid.Name = "BindingsGrid";
            this.BindingsGrid.Size = new System.Drawing.Size(457, 234);
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
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.Tabs);
            this.Name = "SwincherForm";
            this.Text = "Swincher";
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.BindingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel Theme;
        private DevExpress.XtraTab.XtraTabControl Tabs;
        private DevExpress.XtraTab.XtraTabPage BindingsPage;
        private DevExpress.XtraTab.XtraTabPage GeneralPage;
        private System.Windows.Forms.BindingSource Bindings;
        private DevExpress.XtraGrid.GridControl BindingsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView BindingsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationPath;
        private DevExpress.XtraGrid.Columns.GridColumn colKeys;
    }
}
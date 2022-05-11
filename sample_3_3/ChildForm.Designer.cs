namespace sample_3_3 {
  partial class ChildForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.bar2 = new DevExpress.XtraBars.Bar();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(254, 113);
      this.panel1.TabIndex = 0;
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2});
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 3;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(254, 41);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 154);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(254, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 113);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(254, 41);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 113);
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
      this.bar1.Text = "Tools";
      // 
      // bar2
      // 
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "&View";
      this.barSubItem1.Id = 0;
      this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
      this.barSubItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Child Form View Menu Item";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.MergeOrder = 50;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "Child Form Toolbar Button";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // ChildForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(254, 154);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "ChildForm";
      this.Text = "ChildForm";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.Bar bar2;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
  }
}
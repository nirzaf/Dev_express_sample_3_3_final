﻿namespace sample_3_3 {
  partial class Form1 {
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
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.bar2 = new DevExpress.XtraBars.Bar();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
      this.bar3 = new DevExpress.XtraBars.Bar();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
      this.bar4 = new DevExpress.XtraBars.Bar();
      this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
      this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem3,
            this.barMdiChildrenListItem1});
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 7;
      this.barManager1.StatusBar = this.bar3;
      this.barManager1.Merge += new DevExpress.XtraBars.BarManagerMergeEventHandler(this.barManager1_Merge);
      this.barManager1.UnMerge += new DevExpress.XtraBars.BarManagerMergeEventHandler(this.barManager1_UnMerge);
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 1;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
      this.bar1.Text = "Tools";
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Create MDI Child";
      this.barButtonItem1.Id = 0;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
      // 
      // bar2
      // 
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "&File";
      this.barSubItem1.Id = 1;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barSubItem2
      // 
      this.barSubItem2.Caption = "&View";
      this.barSubItem2.Id = 2;
      this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true)});
      this.barSubItem2.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
      this.barSubItem2.Name = "barSubItem2";
      // 
      // bar3
      // 
      this.bar3.BarName = "Status bar";
      this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
      this.bar3.DockCol = 0;
      this.bar3.DockRow = 0;
      this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
      this.bar3.OptionsBar.AllowQuickCustomization = false;
      this.bar3.OptionsBar.DrawDragBorder = false;
      this.bar3.OptionsBar.UseWholeRow = true;
      this.bar3.Text = "Status bar";
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(825, 46);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(825, 21);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(825, 46);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "First Main Menu Button";
      this.barButtonItem2.Id = 3;
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // barButtonItem3
      // 
      this.barButtonItem3.Caption = "Button At End";
      this.barButtonItem3.Id = 4;
      this.barButtonItem3.MergeOrder = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      // 
      // bar4
      // 
      this.bar4.BarName = "Child Bar";
      this.bar4.DockCol = 1;
      this.bar4.DockRow = 1;
      this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar4.Text = "Custom 5";
      this.bar4.Visible = false;
      // 
      // barSubItem3
      // 
      this.barSubItem3.Caption = "Window";
      this.barSubItem3.Id = 5;
      this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1)});
      this.barSubItem3.Name = "barSubItem3";
      // 
      // barMdiChildrenListItem1
      // 
      this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
      this.barMdiChildrenListItem1.Id = 6;
      this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 453);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.IsMdiContainer = true;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.Bar bar2;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem2;
    private DevExpress.XtraBars.Bar bar3;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.Bar bar4;
    private DevExpress.XtraBars.BarSubItem barSubItem3;
    private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
  }
}


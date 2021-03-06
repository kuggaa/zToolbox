﻿namespace zToolbox
{
    partial class zToolRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public zToolRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.addresstb = this.Factory.CreateRibbonEditBox();
            this.zLinkB = this.Factory.CreateRibbonButton();
            this.zEstimate = this.Factory.CreateRibbonButton();
            this.factsheet = this.Factory.CreateRibbonButton();
            this.getCompTable = this.Factory.CreateRibbonButton();
            this.gMap = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "zToolbox";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.zLinkB);
            this.group1.Items.Add(this.zEstimate);
            this.group1.Items.Add(this.factsheet);
            this.group1.Items.Add(this.getCompTable);
            this.group1.Items.Add(this.gMap);
            this.group1.Items.Add(this.button1);
            this.group1.Label = "common";
            this.group1.Name = "group1";
            // 
            // group3
            // 
            this.group3.Items.Add(this.button2);
            this.group3.Label = "Settings";
            this.group3.Name = "group3";
            // 
            // group2
            // 
            this.group2.Items.Add(this.addresstb);
            this.group2.Label = "Context Address";
            this.group2.Name = "group2";
            // 
            // addresstb
            // 
            this.addresstb.Enabled = false;
            this.addresstb.Label = "Address:";
            this.addresstb.Name = "addresstb";
            this.addresstb.ScreenTip = "The current Address in Context, use zLink feature to set this";
            this.addresstb.ShowLabel = false;
            this.addresstb.SizeString = "\"xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\"";
            this.addresstb.Text = null;
            // 
            // zLinkB
            // 
            this.zLinkB.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.zLinkB.Image = global::zToolbox.Properties.Resources._4feca402f9cb8bcf5bf2015cb2b7be9f_1_;
            this.zLinkB.Label = "zLink";
            this.zLinkB.Name = "zLinkB";
            this.zLinkB.ScreenTip = "Highlight Address or input address for the search";
            this.zLinkB.ShowImage = true;
            this.zLinkB.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.zLinkB_Click);
            // 
            // zEstimate
            // 
            this.zEstimate.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.zEstimate.Image = global::zToolbox.Properties.Resources._4feca402f9cb8bcf5bf2015cb2b7be9f_1_;
            this.zEstimate.Label = "zEstimate";
            this.zEstimate.Name = "zEstimate";
            this.zEstimate.ScreenTip = "Get Zillow Estimate";
            this.zEstimate.ShowImage = true;
            this.zEstimate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.zEstimate_Click);
            // 
            // factsheet
            // 
            this.factsheet.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.factsheet.Image = global::zToolbox.Properties.Resources._4feca402f9cb8bcf5bf2015cb2b7be9f_1_;
            this.factsheet.Label = "zFacts";
            this.factsheet.Name = "factsheet";
            this.factsheet.ScreenTip = "Get Property Facts from Zillow";
            this.factsheet.ShowImage = true;
            this.factsheet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.zFacts_click);
            // 
            // getCompTable
            // 
            this.getCompTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.getCompTable.Image = global::zToolbox.Properties.Resources._4feca402f9cb8bcf5bf2015cb2b7be9f_1_;
            this.getCompTable.Label = "zComps";
            this.getCompTable.Name = "getCompTable";
            this.getCompTable.ScreenTip = "Pull down the comp of a property";
            this.getCompTable.ShowImage = true;
            this.getCompTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getCompTable_Click);
            // 
            // gMap
            // 
            this.gMap.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.gMap.Image = global::zToolbox.Properties.Resources.GOOG;
            this.gMap.Label = "Property Map";
            this.gMap.Name = "gMap";
            this.gMap.ScreenTip = "The map shows the property";
            this.gMap.ShowImage = true;
            this.gMap.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gMap_Click);
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::zToolbox.Properties.Resources.GOOG;
            this.button1.Label = "Comp Map";
            this.button1.Name = "button1";
            this.button1.ScreenTip = "Map for the comparisons";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pullCompMap_click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = global::zToolbox.Properties.Resources.sett2;
            this.button2.Label = "Credential";
            this.button2.Name = "button2";
            this.button2.ScreenTip = "Set ZWID and other settings";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setting_click);
            // 
            // zToolRibbon
            // 
            this.Name = "zToolRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Post.Compose, Microsoft.Outlook" +
    ".Sharing.Compose";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.zToolRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton zLinkB;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton zEstimate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton factsheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gMap;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton getCompTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox addresstb;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
    }

    partial class ThisRibbonCollection
    {
        internal zToolRibbon zToolRibbon
        {
            get { return this.GetRibbon<zToolRibbon>(); }
        }
    }
}

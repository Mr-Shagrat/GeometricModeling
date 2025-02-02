﻿namespace GeometricModeling
{
    partial class GeometricModeling
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometricModeling));
            this.drawing = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.drawPanel = new System.Windows.Forms.RibbonPanel();
            this.lineBtn = new System.Windows.Forms.RibbonButton();
            this.straightLineBtn = new System.Windows.Forms.RibbonButton();
            this.dottedLineBtn = new System.Windows.Forms.RibbonButton();
            this.lineSettingsBtn = new System.Windows.Forms.RibbonButton();
            this.circleBtn = new System.Windows.Forms.RibbonButton();
            this.sqareBtn = new System.Windows.Forms.RibbonButton();
            this.lineTypeBtn = new System.Windows.Forms.RibbonButton();
            this.straightLine = new System.Windows.Forms.RibbonButton();
            this.dashLine = new System.Windows.Forms.RibbonButton();
            this.dashDotLine = new System.Windows.Forms.RibbonButton();
            this.lineWeightBtn = new System.Windows.Forms.RibbonButton();
            this.halfDefaultWeight = new System.Windows.Forms.RibbonButton();
            this.defaultWeight = new System.Windows.Forms.RibbonButton();
            this.boldWeight = new System.Windows.Forms.RibbonButton();
            this.zoomPanel = new System.Windows.Forms.RibbonPanel();
            this.zoomIn = new System.Windows.Forms.RibbonButton();
            this.zoomOut = new System.Windows.Forms.RibbonButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.coordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing
            // 
            this.drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawing.BackColor = System.Drawing.SystemColors.Window;
            this.drawing.Location = new System.Drawing.Point(0, 148);
            this.drawing.Margin = new System.Windows.Forms.Padding(0);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(2037, 929);
            this.drawing.TabIndex = 0;
            this.drawing.TabStop = false;
            this.drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_Paint);
            this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(147, 28);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbDropDown.TabStop = false;
            this.ribbon1.OrbDropDown.Visible = false;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton2);
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1924, 151);
            this.ribbon1.TabIndex = 5;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.drawPanel);
            this.ribbonTab1.Panels.Add(this.zoomPanel);
            this.ribbonTab1.Text = "";
            // 
            // drawPanel
            // 
            this.drawPanel.ButtonMoreEnabled = false;
            this.drawPanel.ButtonMoreVisible = false;
            this.drawPanel.Items.Add(this.lineBtn);
            this.drawPanel.Items.Add(this.circleBtn);
            this.drawPanel.Items.Add(this.sqareBtn);
            this.drawPanel.Items.Add(this.lineTypeBtn);
            this.drawPanel.Items.Add(this.lineWeightBtn);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Text = "";
            // 
            // lineBtn
            // 
            this.lineBtn.DropDownItems.Add(this.straightLineBtn);
            this.lineBtn.DropDownItems.Add(this.dottedLineBtn);
            this.lineBtn.DropDownItems.Add(this.lineSettingsBtn);
            this.lineBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineBtn.Image")));
            this.lineBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("lineBtn.LargeImage")));
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineBtn.SmallImage")));
            this.lineBtn.Text = "Линия";
            this.lineBtn.DoubleClick += new System.EventHandler(this.lineBtn_DoubleClick);
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // straightLineBtn
            // 
            this.straightLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("straightLineBtn.Image")));
            this.straightLineBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("straightLineBtn.LargeImage")));
            this.straightLineBtn.Name = "straightLineBtn";
            this.straightLineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("straightLineBtn.SmallImage")));
            // 
            // dottedLineBtn
            // 
            this.dottedLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("dottedLineBtn.Image")));
            this.dottedLineBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("dottedLineBtn.LargeImage")));
            this.dottedLineBtn.Name = "dottedLineBtn";
            this.dottedLineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("dottedLineBtn.SmallImage")));
            // 
            // lineSettingsBtn
            // 
            this.lineSettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineSettingsBtn.Image")));
            this.lineSettingsBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("lineSettingsBtn.LargeImage")));
            this.lineSettingsBtn.Name = "lineSettingsBtn";
            this.lineSettingsBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineSettingsBtn.SmallImage")));
            // 
            // circleBtn
            // 
            this.circleBtn.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn.Image")));
            this.circleBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("circleBtn.LargeImage")));
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn.SmallImage")));
            this.circleBtn.Text = "Круг";
            this.circleBtn.DoubleClick += new System.EventHandler(this.circleBtn_DoubleClick);
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // sqareBtn
            // 
            this.sqareBtn.Image = ((System.Drawing.Image)(resources.GetObject("sqareBtn.Image")));
            this.sqareBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("sqareBtn.LargeImage")));
            this.sqareBtn.Name = "sqareBtn";
            this.sqareBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("sqareBtn.SmallImage")));
            this.sqareBtn.Text = "Прямоугольник";
            this.sqareBtn.Click += new System.EventHandler(this.sqareBtn_Click);
            // 
            // lineTypeBtn
            // 
            this.lineTypeBtn.DropDownItems.Add(this.straightLine);
            this.lineTypeBtn.DropDownItems.Add(this.dashLine);
            this.lineTypeBtn.DropDownItems.Add(this.dashDotLine);
            this.lineTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineTypeBtn.Image")));
            this.lineTypeBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("lineTypeBtn.LargeImage")));
            this.lineTypeBtn.Name = "lineTypeBtn";
            this.lineTypeBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineTypeBtn.SmallImage")));
            this.lineTypeBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.lineTypeBtn.Text = "Тип линии";
            // 
            // straightLine
            // 
            this.straightLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.straightLine.Image = ((System.Drawing.Image)(resources.GetObject("straightLine.Image")));
            this.straightLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("straightLine.LargeImage")));
            this.straightLine.Name = "straightLine";
            this.straightLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("straightLine.SmallImage")));
            this.straightLine.Text = "Сплошная";
            this.straightLine.Click += new System.EventHandler(this.straightLine_Click);
            // 
            // dashLine
            // 
            this.dashLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.dashLine.Image = ((System.Drawing.Image)(resources.GetObject("dashLine.Image")));
            this.dashLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("dashLine.LargeImage")));
            this.dashLine.Name = "dashLine";
            this.dashLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("dashLine.SmallImage")));
            this.dashLine.Text = "Пунктирная";
            this.dashLine.Click += new System.EventHandler(this.dashLine_Click);
            // 
            // dashDotLine
            // 
            this.dashDotLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.dashDotLine.Image = ((System.Drawing.Image)(resources.GetObject("dashDotLine.Image")));
            this.dashDotLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("dashDotLine.LargeImage")));
            this.dashDotLine.Name = "dashDotLine";
            this.dashDotLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("dashDotLine.SmallImage")));
            this.dashDotLine.Text = "Пунктирная с точкой";
            this.dashDotLine.Click += new System.EventHandler(this.dashDotLine_Click);
            // 
            // lineWeightBtn
            // 
            this.lineWeightBtn.DropDownItems.Add(this.halfDefaultWeight);
            this.lineWeightBtn.DropDownItems.Add(this.defaultWeight);
            this.lineWeightBtn.DropDownItems.Add(this.boldWeight);
            this.lineWeightBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineWeightBtn.Image")));
            this.lineWeightBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("lineWeightBtn.LargeImage")));
            this.lineWeightBtn.Name = "lineWeightBtn";
            this.lineWeightBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineWeightBtn.SmallImage")));
            this.lineWeightBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.lineWeightBtn.Text = "Толщина линии";
            // 
            // halfDefaultWeight
            // 
            this.halfDefaultWeight.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.halfDefaultWeight.Image = ((System.Drawing.Image)(resources.GetObject("halfDefaultWeight.Image")));
            this.halfDefaultWeight.LargeImage = ((System.Drawing.Image)(resources.GetObject("halfDefaultWeight.LargeImage")));
            this.halfDefaultWeight.Name = "halfDefaultWeight";
            this.halfDefaultWeight.SmallImage = ((System.Drawing.Image)(resources.GetObject("halfDefaultWeight.SmallImage")));
            this.halfDefaultWeight.Text = "Тонкая линия";
            this.halfDefaultWeight.Click += new System.EventHandler(this.halfDefaultWeight_Click);
            // 
            // defaultWeight
            // 
            this.defaultWeight.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.defaultWeight.Image = ((System.Drawing.Image)(resources.GetObject("defaultWeight.Image")));
            this.defaultWeight.LargeImage = ((System.Drawing.Image)(resources.GetObject("defaultWeight.LargeImage")));
            this.defaultWeight.Name = "defaultWeight";
            this.defaultWeight.SmallImage = ((System.Drawing.Image)(resources.GetObject("defaultWeight.SmallImage")));
            this.defaultWeight.Text = "Стандартная линия";
            this.defaultWeight.Click += new System.EventHandler(this.defaultWeight_Click);
            // 
            // boldWeight
            // 
            this.boldWeight.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.boldWeight.Image = ((System.Drawing.Image)(resources.GetObject("boldWeight.Image")));
            this.boldWeight.LargeImage = ((System.Drawing.Image)(resources.GetObject("boldWeight.LargeImage")));
            this.boldWeight.Name = "boldWeight";
            this.boldWeight.SmallImage = ((System.Drawing.Image)(resources.GetObject("boldWeight.SmallImage")));
            this.boldWeight.Text = "Жирная линия";
            this.boldWeight.Click += new System.EventHandler(this.boldWeight_Click);
            // 
            // zoomPanel
            // 
            this.zoomPanel.ButtonMoreVisible = false;
            this.zoomPanel.Items.Add(this.zoomIn);
            this.zoomPanel.Items.Add(this.zoomOut);
            this.zoomPanel.Name = "zoomPanel";
            this.zoomPanel.Text = "";
            // 
            // zoomIn
            // 
            this.zoomIn.Image = ((System.Drawing.Image)(resources.GetObject("zoomIn.Image")));
            this.zoomIn.LargeImage = ((System.Drawing.Image)(resources.GetObject("zoomIn.LargeImage")));
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.SmallImage = ((System.Drawing.Image)(resources.GetObject("zoomIn.SmallImage")));
            this.zoomIn.Text = "Отдалить";
            this.zoomIn.Click += new System.EventHandler(this.ZoomBtn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Image = ((System.Drawing.Image)(resources.GetObject("zoomOut.Image")));
            this.zoomOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("zoomOut.LargeImage")));
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("zoomOut.SmallImage")));
            this.zoomOut.Text = "Приблизить";
            this.zoomOut.Click += new System.EventHandler(this.ZoomBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinate});
            this.statusStrip.Location = new System.Drawing.Point(0, 1015);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1924, 40);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // coordinate
            // 
            this.coordinate.AutoSize = false;
            this.coordinate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.coordinate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.coordinate.Name = "coordinate";
            this.coordinate.Size = new System.Drawing.Size(250, 34);
            this.coordinate.Text = "0.000, 0.000, 0.000";
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar.Location = new System.Drawing.Point(2037, 148);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(26, 929);
            this.vScrollBar.TabIndex = 7;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar.Location = new System.Drawing.Point(0, 1080);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(2037, 26);
            this.hScrollBar.TabIndex = 8;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // GeometricModeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ContextMenuStrip = this.menuStrip;
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.drawing);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeometricModeling";
            this.Text = "Geometric Modeling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawing;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel drawPanel;
        private System.Windows.Forms.RibbonButton lineBtn;
        private System.Windows.Forms.RibbonButton dottedLineBtn;
        private System.Windows.Forms.RibbonButton straightLineBtn;
        private System.Windows.Forms.RibbonButton lineSettingsBtn;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonButton lineTypeBtn;
        private System.Windows.Forms.RibbonButton straightLine;
        private System.Windows.Forms.RibbonButton dashLine;
        private System.Windows.Forms.RibbonButton dashDotLine;
        private System.Windows.Forms.RibbonButton lineWeightBtn;
        private System.Windows.Forms.RibbonButton halfDefaultWeight;
        private System.Windows.Forms.RibbonButton defaultWeight;
        private System.Windows.Forms.RibbonButton boldWeight;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel coordinate;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.RibbonPanel zoomPanel;
        private System.Windows.Forms.RibbonButton zoomIn;
        private System.Windows.Forms.RibbonButton zoomOut;
        private System.Windows.Forms.RibbonButton circleBtn;
        private System.Windows.Forms.RibbonButton sqareBtn;
        private System.Windows.Forms.RibbonPanel lineType;
    }
}


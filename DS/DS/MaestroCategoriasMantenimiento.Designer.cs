namespace DS
{
    partial class MaestroCategoriasMantenimiento
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("General");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("guardarRegistro");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cerrar");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("agregarRegistro");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("guardarRegistro");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cerrar");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1");
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this.menuContainerPanel = new Infragistics.Win.Misc.UltraPanel();
            this._ClientArea_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._ClientArea_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._ClientArea_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._ClientArea_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoCategoríaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.menuContainerPanel.ClientArea.SuspendLayout();
            this.menuContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            appearance2.BackColor = System.Drawing.Color.DimGray;
            this.ultraPanel1.Appearance = appearance2;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.label2);
            this.ultraPanel1.ClientArea.Controls.Add(this.label1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(664, 63);
            this.ultraPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Información de agrupación de artículos por familia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maestro de categorías de artículos";
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this.menuContainerPanel.ClientArea;
            this.ultraToolbarsManager1.LockToolbars = true;
            this.ultraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2010;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            buttonTool1.InstanceProps.IsFirstInGroup = true;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool3,
            buttonTool1});
            ultraToolbar1.Text = "General";
            this.ultraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = Infragistics.Win.DefaultableBoolean.True;
            this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = Infragistics.Win.DefaultableBoolean.False;
            this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = Infragistics.Win.DefaultableBoolean.True;
            appearance3.Image = global::DS.Properties.Resources.add_32;
            buttonTool2.SharedPropsInternal.AppearancesLarge.Appearance = appearance3;
            buttonTool2.SharedPropsInternal.Caption = "agregarRegistro";
            appearance4.Image = global::DS.Properties.Resources.save_blue_32;
            buttonTool4.SharedPropsInternal.AppearancesLarge.Appearance = appearance4;
            buttonTool4.SharedPropsInternal.Caption = "guardarRegistro";
            appearance5.Image = global::DS.Properties.Resources.exit_32;
            buttonTool6.SharedPropsInternal.AppearancesLarge.Appearance = appearance5;
            buttonTool6.SharedPropsInternal.Caption = "Cerrar";
            buttonTool7.SharedPropsInternal.Caption = "ButtonTool1";
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2,
            buttonTool4,
            buttonTool6,
            buttonTool7});
            this.ultraToolbarsManager1.UseLargeImagesOnToolbar = true;
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // menuContainerPanel
            // 
            // 
            // menuContainerPanel.ClientArea
            // 
            this.menuContainerPanel.ClientArea.Controls.Add(this._ClientArea_Toolbars_Dock_Area_Left);
            this.menuContainerPanel.ClientArea.Controls.Add(this._ClientArea_Toolbars_Dock_Area_Right);
            this.menuContainerPanel.ClientArea.Controls.Add(this._ClientArea_Toolbars_Dock_Area_Bottom);
            this.menuContainerPanel.ClientArea.Controls.Add(this._ClientArea_Toolbars_Dock_Area_Top);
            this.menuContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuContainerPanel.Location = new System.Drawing.Point(0, 63);
            this.menuContainerPanel.Name = "menuContainerPanel";
            this.menuContainerPanel.Size = new System.Drawing.Size(664, 40);
            this.menuContainerPanel.TabIndex = 8;
            // 
            // _ClientArea_Toolbars_Dock_Area_Left
            // 
            this._ClientArea_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._ClientArea_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._ClientArea_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._ClientArea_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClientArea_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 40);
            this._ClientArea_Toolbars_Dock_Area_Left.Name = "_ClientArea_Toolbars_Dock_Area_Left";
            this._ClientArea_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 0);
            this._ClientArea_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _ClientArea_Toolbars_Dock_Area_Right
            // 
            this._ClientArea_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._ClientArea_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._ClientArea_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._ClientArea_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClientArea_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(664, 40);
            this._ClientArea_Toolbars_Dock_Area_Right.Name = "_ClientArea_Toolbars_Dock_Area_Right";
            this._ClientArea_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 0);
            this._ClientArea_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _ClientArea_Toolbars_Dock_Area_Bottom
            // 
            this._ClientArea_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._ClientArea_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._ClientArea_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._ClientArea_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClientArea_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 40);
            this._ClientArea_Toolbars_Dock_Area_Bottom.Name = "_ClientArea_Toolbars_Dock_Area_Bottom";
            this._ClientArea_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(664, 0);
            this._ClientArea_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _ClientArea_Toolbars_Dock_Area_Top
            // 
            this._ClientArea_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._ClientArea_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._ClientArea_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._ClientArea_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClientArea_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._ClientArea_Toolbars_Dock_Area_Top.Name = "_ClientArea_Toolbars_Dock_Area_Top";
            this._ClientArea_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(664, 40);
            this._ClientArea_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripción:";
            // 
            // codigoCategoríaTextBox
            // 
            this.codigoCategoríaTextBox.Location = new System.Drawing.Point(161, 129);
            this.codigoCategoríaTextBox.Name = "codigoCategoríaTextBox";
            this.codigoCategoríaTextBox.Size = new System.Drawing.Size(306, 20);
            this.codigoCategoríaTextBox.TabIndex = 11;
            // 
            // descripcionCategoriaTextBox
            // 
            this.descripcionCategoriaTextBox.Location = new System.Drawing.Point(161, 166);
            this.descripcionCategoriaTextBox.Name = "descripcionCategoriaTextBox";
            this.descripcionCategoriaTextBox.Size = new System.Drawing.Size(306, 20);
            this.descripcionCategoriaTextBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MaestroCategoriasMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 550);
            this.Controls.Add(this.descripcionCategoriaTextBox);
            this.Controls.Add(this.codigoCategoríaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuContainerPanel);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "MaestroCategoriasMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Presentaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ClientArea.PerformLayout();
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.menuContainerPanel.ClientArea.ResumeLayout(false);
            this.menuContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.Misc.UltraPanel menuContainerPanel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _ClientArea_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _ClientArea_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _ClientArea_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _ClientArea_Toolbars_Dock_Area_Top;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoCategoríaTextBox;
        private System.Windows.Forms.TextBox descripcionCategoriaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
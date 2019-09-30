namespace CSAY_UTMLatLongConverter
{
    partial class FrmLatLongToUTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLatLongToUTM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageINPUT = new System.Windows.Forms.TabPage();
            this.LblProjectionMsg = new System.Windows.Forms.Label();
            this.LblDatumMsg = new System.Windows.Forms.Label();
            this.LblDataNo = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.tabPageORIGINS = new System.Windows.Forms.TabPage();
            this.ComboBoxCMZone = new System.Windows.Forms.ComboBox();
            this.TxtZone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLatOrigin = new System.Windows.Forms.TextBox();
            this.tabPageELLIPSOID = new System.Windows.Forms.TabPage();
            this.ComboBoxDatum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblFlatening = new System.Windows.Forms.Label();
            this.TxtFlatening = new System.Windows.Forms.TextBox();
            this.Lbla = new System.Windows.Forms.Label();
            this.TxtSemiMajorAxis = new System.Windows.Forms.TextBox();
            this.tabPageSCALE_FACTOR = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxProjection = new System.Windows.Forms.ComboBox();
            this.LblM0 = new System.Windows.Forms.Label();
            this.TxtM0 = new System.Windows.Forms.TextBox();
            this.LblK0 = new System.Windows.Forms.Label();
            this.TxtK0 = new System.Windows.Forms.TextBox();
            this.tabPageFALSE_E_N = new System.Windows.Forms.TabPage();
            this.LblFalseN = new System.Windows.Forms.Label();
            this.TxtFalseN = new System.Windows.Forms.TextBox();
            this.LblFalseE = new System.Windows.Forms.Label();
            this.TxtFalseE = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.IMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedGridOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyFromGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToGidCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutFromGridCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveOneSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearValueOfSelectedCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveAllGridsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageINPUT.SuspendLayout();
            this.tabPageORIGINS.SuspendLayout();
            this.tabPageELLIPSOID.SuspendLayout();
            this.tabPageSCALE_FACTOR.SuspendLayout();
            this.tabPageFALSE_E_N.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMusking)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageINPUT);
            this.tabControl1.Controls.Add(this.tabPageORIGINS);
            this.tabControl1.Controls.Add(this.tabPageELLIPSOID);
            this.tabControl1.Controls.Add(this.tabPageSCALE_FACTOR);
            this.tabControl1.Controls.Add(this.tabPageFALSE_E_N);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(75, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 183);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageINPUT
            // 
            this.tabPageINPUT.Controls.Add(this.LblProjectionMsg);
            this.tabPageINPUT.Controls.Add(this.LblDatumMsg);
            this.tabPageINPUT.Controls.Add(this.LblDataNo);
            this.tabPageINPUT.Controls.Add(this.TxtNumber);
            this.tabPageINPUT.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageINPUT.ForeColor = System.Drawing.Color.Black;
            this.tabPageINPUT.Location = new System.Drawing.Point(4, 27);
            this.tabPageINPUT.Name = "tabPageINPUT";
            this.tabPageINPUT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageINPUT.Size = new System.Drawing.Size(805, 152);
            this.tabPageINPUT.TabIndex = 0;
            this.tabPageINPUT.Text = "INPUT";
            this.tabPageINPUT.UseVisualStyleBackColor = true;
            // 
            // LblProjectionMsg
            // 
            this.LblProjectionMsg.AutoSize = true;
            this.LblProjectionMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectionMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblProjectionMsg.Location = new System.Drawing.Point(415, 67);
            this.LblProjectionMsg.Name = "LblProjectionMsg";
            this.LblProjectionMsg.Size = new System.Drawing.Size(352, 23);
            this.LblProjectionMsg.TabIndex = 14;
            this.LblProjectionMsg.Text = "Projection: (Select from SCALE FACTOR tab)";
            // 
            // LblDatumMsg
            // 
            this.LblDatumMsg.AutoSize = true;
            this.LblDatumMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatumMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblDatumMsg.Location = new System.Drawing.Point(415, 24);
            this.LblDatumMsg.Name = "LblDatumMsg";
            this.LblDatumMsg.Size = new System.Drawing.Size(290, 23);
            this.LblDatumMsg.TabIndex = 13;
            this.LblDatumMsg.Text = "Datum: (Select from ELLIPSOID tab)";
            // 
            // LblDataNo
            // 
            this.LblDataNo.AutoSize = true;
            this.LblDataNo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNo.ForeColor = System.Drawing.Color.Green;
            this.LblDataNo.Location = new System.Drawing.Point(28, 44);
            this.LblDataNo.Name = "LblDataNo";
            this.LblDataNo.Size = new System.Drawing.Size(137, 29);
            this.LblDataNo.TabIndex = 4;
            this.LblDataNo.Text = "Data number";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.Location = new System.Drawing.Point(171, 46);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(172, 30);
            this.TxtNumber.TabIndex = 5;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // tabPageORIGINS
            // 
            this.tabPageORIGINS.Controls.Add(this.ComboBoxCMZone);
            this.tabPageORIGINS.Controls.Add(this.TxtZone);
            this.tabPageORIGINS.Controls.Add(this.label5);
            this.tabPageORIGINS.Controls.Add(this.label1);
            this.tabPageORIGINS.Controls.Add(this.TxtCM);
            this.tabPageORIGINS.Controls.Add(this.label2);
            this.tabPageORIGINS.Controls.Add(this.TxtLatOrigin);
            this.tabPageORIGINS.Location = new System.Drawing.Point(4, 27);
            this.tabPageORIGINS.Name = "tabPageORIGINS";
            this.tabPageORIGINS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageORIGINS.Size = new System.Drawing.Size(805, 152);
            this.tabPageORIGINS.TabIndex = 1;
            this.tabPageORIGINS.Text = "ORIGINS";
            this.tabPageORIGINS.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCMZone
            // 
            this.ComboBoxCMZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCMZone.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCMZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxCMZone.FormattingEnabled = true;
            this.ComboBoxCMZone.Location = new System.Drawing.Point(486, 28);
            this.ComboBoxCMZone.Name = "ComboBoxCMZone";
            this.ComboBoxCMZone.Size = new System.Drawing.Size(243, 34);
            this.ComboBoxCMZone.TabIndex = 11;
            this.ComboBoxCMZone.Text = "Select CM or Zone";
            this.ComboBoxCMZone.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCMZone_SelectedIndexChanged);
            // 
            // TxtZone
            // 
            this.TxtZone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZone.Location = new System.Drawing.Point(607, 90);
            this.TxtZone.Name = "TxtZone";
            this.TxtZone.ReadOnly = true;
            this.TxtZone.Size = new System.Drawing.Size(122, 30);
            this.TxtZone.TabIndex = 9;
            this.TxtZone.TextChanged += new System.EventHandler(this.TxtZone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(481, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Central Meridian (DD)";
            // 
            // TxtCM
            // 
            this.TxtCM.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCM.Location = new System.Drawing.Point(291, 90);
            this.TxtCM.Name = "TxtCM";
            this.TxtCM.ReadOnly = true;
            this.TxtCM.Size = new System.Drawing.Size(138, 30);
            this.TxtCM.TabIndex = 7;
            this.TxtCM.TextChanged += new System.EventHandler(this.TxtCM_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Latitude Origin (DD)";
            // 
            // TxtLatOrigin
            // 
            this.TxtLatOrigin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLatOrigin.Location = new System.Drawing.Point(291, 28);
            this.TxtLatOrigin.Name = "TxtLatOrigin";
            this.TxtLatOrigin.Size = new System.Drawing.Size(138, 30);
            this.TxtLatOrigin.TabIndex = 5;
            // 
            // tabPageELLIPSOID
            // 
            this.tabPageELLIPSOID.Controls.Add(this.ComboBoxDatum);
            this.tabPageELLIPSOID.Controls.Add(this.label4);
            this.tabPageELLIPSOID.Controls.Add(this.LblFlatening);
            this.tabPageELLIPSOID.Controls.Add(this.TxtFlatening);
            this.tabPageELLIPSOID.Controls.Add(this.Lbla);
            this.tabPageELLIPSOID.Controls.Add(this.TxtSemiMajorAxis);
            this.tabPageELLIPSOID.Location = new System.Drawing.Point(4, 27);
            this.tabPageELLIPSOID.Name = "tabPageELLIPSOID";
            this.tabPageELLIPSOID.Size = new System.Drawing.Size(805, 152);
            this.tabPageELLIPSOID.TabIndex = 2;
            this.tabPageELLIPSOID.Text = "ELLIPSOID";
            this.tabPageELLIPSOID.UseVisualStyleBackColor = true;
            // 
            // ComboBoxDatum
            // 
            this.ComboBoxDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDatum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxDatum.FormattingEnabled = true;
            this.ComboBoxDatum.Location = new System.Drawing.Point(527, 84);
            this.ComboBoxDatum.Name = "ComboBoxDatum";
            this.ComboBoxDatum.Size = new System.Drawing.Size(243, 34);
            this.ComboBoxDatum.TabIndex = 10;
            this.ComboBoxDatum.Text = "Select Datum";
            this.ComboBoxDatum.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDatum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(522, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum";
            // 
            // LblFlatening
            // 
            this.LblFlatening.AutoSize = true;
            this.LblFlatening.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlatening.ForeColor = System.Drawing.Color.Green;
            this.LblFlatening.Location = new System.Drawing.Point(20, 81);
            this.LblFlatening.Name = "LblFlatening";
            this.LblFlatening.Size = new System.Drawing.Size(238, 29);
            this.LblFlatening.TabIndex = 6;
            this.LblFlatening.Text = "Flatening ratio, 1/f (m)";
            // 
            // TxtFlatening
            // 
            this.TxtFlatening.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFlatening.Location = new System.Drawing.Point(286, 80);
            this.TxtFlatening.Name = "TxtFlatening";
            this.TxtFlatening.Size = new System.Drawing.Size(204, 30);
            this.TxtFlatening.TabIndex = 7;
            this.TxtFlatening.TextChanged += new System.EventHandler(this.TxtFlatening_TextChanged);
            // 
            // Lbla
            // 
            this.Lbla.AutoSize = true;
            this.Lbla.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbla.ForeColor = System.Drawing.Color.Green;
            this.Lbla.Location = new System.Drawing.Point(20, 23);
            this.Lbla.Name = "Lbla";
            this.Lbla.Size = new System.Drawing.Size(235, 29);
            this.Lbla.TabIndex = 4;
            this.Lbla.Text = "Semi-Major axis, a (m)";
            // 
            // TxtSemiMajorAxis
            // 
            this.TxtSemiMajorAxis.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSemiMajorAxis.Location = new System.Drawing.Point(286, 25);
            this.TxtSemiMajorAxis.Name = "TxtSemiMajorAxis";
            this.TxtSemiMajorAxis.Size = new System.Drawing.Size(204, 30);
            this.TxtSemiMajorAxis.TabIndex = 5;
            // 
            // tabPageSCALE_FACTOR
            // 
            this.tabPageSCALE_FACTOR.Controls.Add(this.label3);
            this.tabPageSCALE_FACTOR.Controls.Add(this.ComboBoxProjection);
            this.tabPageSCALE_FACTOR.Controls.Add(this.LblM0);
            this.tabPageSCALE_FACTOR.Controls.Add(this.TxtM0);
            this.tabPageSCALE_FACTOR.Controls.Add(this.LblK0);
            this.tabPageSCALE_FACTOR.Controls.Add(this.TxtK0);
            this.tabPageSCALE_FACTOR.Location = new System.Drawing.Point(4, 27);
            this.tabPageSCALE_FACTOR.Name = "tabPageSCALE_FACTOR";
            this.tabPageSCALE_FACTOR.Size = new System.Drawing.Size(805, 152);
            this.tabPageSCALE_FACTOR.TabIndex = 3;
            this.tabPageSCALE_FACTOR.Text = "SCALE FACTOR";
            this.tabPageSCALE_FACTOR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(525, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Projection System";
            // 
            // ComboBoxProjection
            // 
            this.ComboBoxProjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxProjection.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProjection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxProjection.FormattingEnabled = true;
            this.ComboBoxProjection.Location = new System.Drawing.Point(530, 82);
            this.ComboBoxProjection.Name = "ComboBoxProjection";
            this.ComboBoxProjection.Size = new System.Drawing.Size(207, 34);
            this.ComboBoxProjection.TabIndex = 8;
            this.ComboBoxProjection.Text = "Select Projection";
            this.ComboBoxProjection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProjection_SelectedIndexChanged);
            // 
            // LblM0
            // 
            this.LblM0.AutoSize = true;
            this.LblM0.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblM0.ForeColor = System.Drawing.Color.Green;
            this.LblM0.Location = new System.Drawing.Point(30, 66);
            this.LblM0.Name = "LblM0";
            this.LblM0.Size = new System.Drawing.Size(263, 58);
            this.LblM0.TabIndex = 10;
            this.LblM0.Text = "True distance along CM \r\nfrom equator to lat origin";
            // 
            // TxtM0
            // 
            this.TxtM0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtM0.Location = new System.Drawing.Point(304, 82);
            this.TxtM0.Name = "TxtM0";
            this.TxtM0.Size = new System.Drawing.Size(188, 30);
            this.TxtM0.TabIndex = 11;
            // 
            // LblK0
            // 
            this.LblK0.AutoSize = true;
            this.LblK0.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblK0.ForeColor = System.Drawing.Color.Green;
            this.LblK0.Location = new System.Drawing.Point(30, 20);
            this.LblK0.Name = "LblK0";
            this.LblK0.Size = new System.Drawing.Size(242, 29);
            this.LblK0.TabIndex = 8;
            this.LblK0.Text = "Scale Factor at the CM";
            // 
            // TxtK0
            // 
            this.TxtK0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtK0.Location = new System.Drawing.Point(304, 22);
            this.TxtK0.Name = "TxtK0";
            this.TxtK0.Size = new System.Drawing.Size(188, 30);
            this.TxtK0.TabIndex = 9;
            // 
            // tabPageFALSE_E_N
            // 
            this.tabPageFALSE_E_N.Controls.Add(this.LblFalseN);
            this.tabPageFALSE_E_N.Controls.Add(this.TxtFalseN);
            this.tabPageFALSE_E_N.Controls.Add(this.LblFalseE);
            this.tabPageFALSE_E_N.Controls.Add(this.TxtFalseE);
            this.tabPageFALSE_E_N.Location = new System.Drawing.Point(4, 27);
            this.tabPageFALSE_E_N.Name = "tabPageFALSE_E_N";
            this.tabPageFALSE_E_N.Size = new System.Drawing.Size(805, 152);
            this.tabPageFALSE_E_N.TabIndex = 4;
            this.tabPageFALSE_E_N.Text = "FALSE EASTING NORTHING";
            this.tabPageFALSE_E_N.UseVisualStyleBackColor = true;
            // 
            // LblFalseN
            // 
            this.LblFalseN.AutoSize = true;
            this.LblFalseN.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalseN.ForeColor = System.Drawing.Color.Green;
            this.LblFalseN.Location = new System.Drawing.Point(39, 83);
            this.LblFalseN.Name = "LblFalseN";
            this.LblFalseN.Size = new System.Drawing.Size(195, 29);
            this.LblFalseN.TabIndex = 10;
            this.LblFalseN.Text = "False Northing (m)";
            // 
            // TxtFalseN
            // 
            this.TxtFalseN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFalseN.Location = new System.Drawing.Point(305, 82);
            this.TxtFalseN.Name = "TxtFalseN";
            this.TxtFalseN.Size = new System.Drawing.Size(266, 30);
            this.TxtFalseN.TabIndex = 11;
            // 
            // LblFalseE
            // 
            this.LblFalseE.AutoSize = true;
            this.LblFalseE.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalseE.ForeColor = System.Drawing.Color.Green;
            this.LblFalseE.Location = new System.Drawing.Point(39, 25);
            this.LblFalseE.Name = "LblFalseE";
            this.LblFalseE.Size = new System.Drawing.Size(180, 29);
            this.LblFalseE.TabIndex = 8;
            this.LblFalseE.Text = "False Easting (m)";
            // 
            // TxtFalseE
            // 
            this.TxtFalseE.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFalseE.Location = new System.Drawing.Point(305, 27);
            this.TxtFalseE.Name = "TxtFalseE";
            this.TxtFalseE.Size = new System.Drawing.Size(266, 30);
            this.TxtFalseE.TabIndex = 9;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Black;
            this.LblMessage.Location = new System.Drawing.Point(921, 102);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(282, 554);
            this.LblMessage.TabIndex = 6;
            this.LblMessage.Text = resources.GetString("LblMessage.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.IMPORTToolStripMenuItem,
            this.EXPORTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CopyFromGridToolStripMenuItem,
            this.PasteToGidCellsToolStripMenuItem,
            this.CutFromGridCellsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem5,
            this.EXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 204);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CalculateToolStripMenuItem.Text = "LatLongToXY";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // IMPORTToolStripMenuItem
            // 
            this.IMPORTToolStripMenuItem.Name = "IMPORTToolStripMenuItem";
            this.IMPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.IMPORTToolStripMenuItem.Text = "Import From Excel";
            this.IMPORTToolStripMenuItem.Click += new System.EventHandler(this.IMPORTToolStripMenuItem_Click);
            // 
            // EXPORTToolStripMenuItem
            // 
            this.EXPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllGridToolStripMenuItem,
            this.SelectedGridOnlyToolStripMenuItem});
            this.EXPORTToolStripMenuItem.Name = "EXPORTToolStripMenuItem";
            this.EXPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXPORTToolStripMenuItem.Text = "Export To Excel";
            // 
            // AllGridToolStripMenuItem
            // 
            this.AllGridToolStripMenuItem.Name = "AllGridToolStripMenuItem";
            this.AllGridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AllGridToolStripMenuItem.Text = "All Cells";
            this.AllGridToolStripMenuItem.Click += new System.EventHandler(this.AllGridToolStripMenuItem_Click);
            // 
            // SelectedGridOnlyToolStripMenuItem
            // 
            this.SelectedGridOnlyToolStripMenuItem.Name = "SelectedGridOnlyToolStripMenuItem";
            this.SelectedGridOnlyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SelectedGridOnlyToolStripMenuItem.Text = "Selected Cells Only";
            this.SelectedGridOnlyToolStripMenuItem.Click += new System.EventHandler(this.SelectedGridOnlyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // CopyFromGridToolStripMenuItem
            // 
            this.CopyFromGridToolStripMenuItem.Name = "CopyFromGridToolStripMenuItem";
            this.CopyFromGridToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CopyFromGridToolStripMenuItem.Text = "Copy From Grid Cells";
            this.CopyFromGridToolStripMenuItem.Click += new System.EventHandler(this.CopyFromGridToolStripMenuItem_Click);
            // 
            // PasteToGidCellsToolStripMenuItem
            // 
            this.PasteToGidCellsToolStripMenuItem.Name = "PasteToGidCellsToolStripMenuItem";
            this.PasteToGidCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PasteToGidCellsToolStripMenuItem.Text = "Paste To Gid Cells";
            this.PasteToGidCellsToolStripMenuItem.Click += new System.EventHandler(this.PasteToGidCellsToolStripMenuItem_Click);
            // 
            // CutFromGridCellsToolStripMenuItem
            // 
            this.CutFromGridCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveOneSelectedRowToolStripMenuItem,
            this.ClearValueOfSelectedCellsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.RemoveAllGridsToolStripMenuItem});
            this.CutFromGridCellsToolStripMenuItem.Name = "CutFromGridCellsToolStripMenuItem";
            this.CutFromGridCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CutFromGridCellsToolStripMenuItem.Text = "Clear";
            // 
            // RemoveOneSelectedRowToolStripMenuItem
            // 
            this.RemoveOneSelectedRowToolStripMenuItem.Name = "RemoveOneSelectedRowToolStripMenuItem";
            this.RemoveOneSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveOneSelectedRowToolStripMenuItem.Text = "Remove One Selected Row";
            this.RemoveOneSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.RemoveOneSelectedRowToolStripMenuItem_Click);
            // 
            // ClearValueOfSelectedCellsToolStripMenuItem
            // 
            this.ClearValueOfSelectedCellsToolStripMenuItem.Name = "ClearValueOfSelectedCellsToolStripMenuItem";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ClearValueOfSelectedCellsToolStripMenuItem.Text = "Clear Value Of Selected Cells";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Click += new System.EventHandler(this.ClearValueOfSelectedCellsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 6);
            // 
            // RemoveAllGridsToolStripMenuItem
            // 
            this.RemoveAllGridsToolStripMenuItem.Name = "RemoveAllGridsToolStripMenuItem";
            this.RemoveAllGridsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveAllGridsToolStripMenuItem.Text = "Remove All Grids";
            this.RemoveAllGridsToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllGridsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 6);
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // DataGridViewMusking
            // 
            this.DataGridViewMusking.AllowDrop = true;
            this.DataGridViewMusking.AllowUserToResizeColumns = false;
            this.DataGridViewMusking.AllowUserToResizeRows = false;
            this.DataGridViewMusking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSN,
            this.ColLatitude,
            this.ColLongitude,
            this.ColEasting,
            this.ColNorthing});
            this.DataGridViewMusking.Location = new System.Drawing.Point(75, 293);
            this.DataGridViewMusking.Name = "DataGridViewMusking";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMusking.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewMusking.RowHeadersVisible = false;
            this.DataGridViewMusking.Size = new System.Drawing.Size(840, 346);
            this.DataGridViewMusking.TabIndex = 7;
            this.DataGridViewMusking.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridViewMusking_DragDrop);
            this.DataGridViewMusking.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridViewMusking_DragEnter);
            // 
            // ColSN
            // 
            this.ColSN.HeaderText = "SN";
            this.ColSN.Name = "ColSN";
            this.ColSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColLatitude
            // 
            this.ColLatitude.HeaderText = "Latitude";
            this.ColLatitude.Name = "ColLatitude";
            this.ColLatitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLatitude.Width = 150;
            // 
            // ColLongitude
            // 
            this.ColLongitude.HeaderText = "Longitude";
            this.ColLongitude.Name = "ColLongitude";
            this.ColLongitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLongitude.Width = 150;
            // 
            // ColEasting
            // 
            this.ColEasting.HeaderText = "Easting (X)";
            this.ColEasting.Name = "ColEasting";
            this.ColEasting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEasting.Width = 205;
            // 
            // ColNorthing
            // 
            this.ColNorthing.HeaderText = "Northing (Y)";
            this.ColNorthing.Name = "ColNorthing";
            this.ColNorthing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNorthing.Width = 205;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblTitle.Location = new System.Drawing.Point(310, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(335, 29);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "LAT LONG COORD CONVERTER";
            // 
            // FrmLatLongToUTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 672);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.DataGridViewMusking);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmLatLongToUTM";
            this.Text = "CSAY LAT LONG COORD CONVETER";
            this.Load += new System.EventHandler(this.FrmLatLongToUTM_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageINPUT.ResumeLayout(false);
            this.tabPageINPUT.PerformLayout();
            this.tabPageORIGINS.ResumeLayout(false);
            this.tabPageORIGINS.PerformLayout();
            this.tabPageELLIPSOID.ResumeLayout(false);
            this.tabPageELLIPSOID.PerformLayout();
            this.tabPageSCALE_FACTOR.ResumeLayout(false);
            this.tabPageSCALE_FACTOR.PerformLayout();
            this.tabPageFALSE_E_N.ResumeLayout(false);
            this.tabPageFALSE_E_N.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMusking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageINPUT;
        private System.Windows.Forms.TabPage tabPageORIGINS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLatOrigin;
        private System.Windows.Forms.TabPage tabPageELLIPSOID;
        private System.Windows.Forms.TabPage tabPageSCALE_FACTOR;
        private System.Windows.Forms.TabPage tabPageFALSE_E_N;
        private System.Windows.Forms.Label LblFlatening;
        private System.Windows.Forms.TextBox TxtFlatening;
        private System.Windows.Forms.Label Lbla;
        private System.Windows.Forms.TextBox TxtSemiMajorAxis;
        private System.Windows.Forms.Label LblM0;
        private System.Windows.Forms.TextBox TxtM0;
        private System.Windows.Forms.Label LblK0;
        private System.Windows.Forms.TextBox TxtK0;
        private System.Windows.Forms.Label LblFalseN;
        private System.Windows.Forms.TextBox TxtFalseN;
        private System.Windows.Forms.Label LblFalseE;
        private System.Windows.Forms.TextBox TxtFalseE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem IMPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectedGridOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyFromGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToGidCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutFromGridCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveOneSelectedRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearValueOfSelectedCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllGridsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.Label LblDataNo;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.DataGridView DataGridViewMusking;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.ComboBox ComboBoxProjection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDatumMsg;
        private System.Windows.Forms.Label LblProjectionMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNorthing;
        private System.Windows.Forms.TextBox TxtZone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxCMZone;
    }
}


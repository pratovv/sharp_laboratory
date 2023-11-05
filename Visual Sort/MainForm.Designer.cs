namespace Visual_Sort
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.comboBoxSortingAlgorithm = new System.Windows.Forms.ComboBox();
            this.panelDraw = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.labelRuntimeValue = new System.Windows.Forms.Label();
            this.labelCsRelationValue = new System.Windows.Forms.Label();
            this.labelCsRelation = new System.Windows.Forms.Label();
            this.labelSwapValue = new System.Windows.Forms.Label();
            this.labelSwap = new System.Windows.Forms.Label();
            this.labelComparisonValue = new System.Windows.Forms.Label();
            this.labelComparison = new System.Windows.Forms.Label();
            this.comboBoxVisualizationScheme = new System.Windows.Forms.ComboBox();
            this.groupBoxVisualizationDepth = new System.Windows.Forms.GroupBox();
            this.radioBoxVisualizationDepthNone = new System.Windows.Forms.RadioButton();
            this.radioBoxVisualizationDepthDetailed = new System.Windows.Forms.RadioButton();
            this.radioBoxVisualizationDepthSimple = new System.Windows.Forms.RadioButton();
            this.checkBoxDataProcessingSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxFinalEvent = new System.Windows.Forms.CheckBox();
            this.labelSortingAlgorithm = new System.Windows.Forms.Label();
            this.labelVisualizationScheme = new System.Windows.Forms.Label();
            this.labelShuffleMode = new System.Windows.Forms.Label();
            this.comboBoxShuffleMode = new System.Windows.Forms.ComboBox();
            this.comboBoxDrawMode = new System.Windows.Forms.ComboBox();
            this.labelDrawMode = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAnalysis = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxVisualizationDepth.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.AccessibleDescription = "Start the sorting";
            this.buttonSort.AccessibleName = "Start";
            this.buttonSort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSort.Location = new System.Drawing.Point(191, 324);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(167, 28);
            this.buttonSort.TabIndex = 13;
            this.buttonSort.Text = "S&tart";
            this.toolTip.SetToolTip(this.buttonSort, "Start");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            this.buttonSort.Enter += new System.EventHandler(this.SetStatusbar);
            this.buttonSort.Leave += new System.EventHandler(this.ClearStatusbar);
            this.buttonSort.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.buttonSort.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.AccessibleDescription = "Shuffle the field";
            this.buttonShuffle.AccessibleName = "Shuffle";
            this.buttonShuffle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonShuffle.Location = new System.Drawing.Point(16, 324);
            this.buttonShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(167, 28);
            this.buttonShuffle.TabIndex = 12;
            this.buttonShuffle.Text = "S&huffle";
            this.toolTip.SetToolTip(this.buttonShuffle, "Shuffle");
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
            this.buttonShuffle.Enter += new System.EventHandler(this.SetStatusbar);
            this.buttonShuffle.Leave += new System.EventHandler(this.ClearStatusbar);
            this.buttonShuffle.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.buttonShuffle.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // comboBoxSortingAlgorithm
            // 
            this.comboBoxSortingAlgorithm.AccessibleDescription = "Click to show the sorting algorithms";
            this.comboBoxSortingAlgorithm.AccessibleName = "Sorting algorithm";
            this.comboBoxSortingAlgorithm.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBoxSortingAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortingAlgorithm.FormattingEnabled = true;
            this.comboBoxSortingAlgorithm.Location = new System.Drawing.Point(16, 38);
            this.comboBoxSortingAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSortingAlgorithm.Name = "comboBoxSortingAlgorithm";
            this.comboBoxSortingAlgorithm.Size = new System.Drawing.Size(340, 24);
            this.comboBoxSortingAlgorithm.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxSortingAlgorithm, "Sorting algorithm");
            this.comboBoxSortingAlgorithm.Enter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxSortingAlgorithm.Leave += new System.EventHandler(this.ClearStatusbar);
            this.comboBoxSortingAlgorithm.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxSortingAlgorithm.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // panelDraw
            // 
            this.panelDraw.AccessibleDescription = "Show the canvas of the field";
            this.panelDraw.AccessibleName = "Canvas";
            this.panelDraw.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Location = new System.Drawing.Point(365, 15);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(4);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(341, 315);
            this.panelDraw.TabIndex = 4;
            this.panelDraw.TabStop = false;
            this.toolTip.SetToolTip(this.panelDraw, "Canvas");
            this.panelDraw.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.panelDraw.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AccessibleDescription = "Group the statistics";
            this.tableLayoutPanel.AccessibleName = "Statistic group";
            this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.Controls.Add(this.labelRuntime, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelRuntimeValue, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelCsRelationValue, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCsRelation, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelSwapValue, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelSwap, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelComparisonValue, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelComparison, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(367, 338);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(340, 70);
            this.tableLayoutPanel.TabIndex = 15;
            // 
            // labelRuntime
            // 
            this.labelRuntime.AccessibleDescription = "Show the time";
            this.labelRuntime.AccessibleName = "Time";
            this.labelRuntime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.BackColor = System.Drawing.Color.Transparent;
            this.labelRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRuntime.Location = new System.Drawing.Point(4, 51);
            this.labelRuntime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(128, 19);
            this.labelRuntime.TabIndex = 6;
            this.labelRuntime.Text = "Time in hms:";
            this.labelRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRuntimeValue
            // 
            this.labelRuntimeValue.AccessibleDescription = "Show the value of the time";
            this.labelRuntimeValue.AccessibleName = "Time";
            this.labelRuntimeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelRuntimeValue.AutoSize = true;
            this.labelRuntimeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelRuntimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRuntimeValue.Location = new System.Drawing.Point(140, 51);
            this.labelRuntimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRuntimeValue.Name = "labelRuntimeValue";
            this.labelRuntimeValue.Size = new System.Drawing.Size(196, 19);
            this.labelRuntimeValue.TabIndex = 7;
            this.labelRuntimeValue.Text = "0";
            this.labelRuntimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelRuntimeValue, "Time");
            // 
            // labelCsRelationValue
            // 
            this.labelCsRelationValue.AccessibleDescription = "Show the value of the c/s relation";
            this.labelCsRelationValue.AccessibleName = "c/s relation";
            this.labelCsRelationValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelCsRelationValue.AutoSize = true;
            this.labelCsRelationValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCsRelationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCsRelationValue.Location = new System.Drawing.Point(140, 34);
            this.labelCsRelationValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCsRelationValue.Name = "labelCsRelationValue";
            this.labelCsRelationValue.Size = new System.Drawing.Size(196, 17);
            this.labelCsRelationValue.TabIndex = 5;
            this.labelCsRelationValue.Text = "0";
            this.labelCsRelationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelCsRelationValue, "c/s relation");
            this.labelCsRelationValue.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelCsRelationValue.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelCsRelationValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelCsRelationValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelCsRelation
            // 
            this.labelCsRelation.AccessibleDescription = "Show the c/s relation";
            this.labelCsRelation.AccessibleName = "c/s relation";
            this.labelCsRelation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelCsRelation.AutoSize = true;
            this.labelCsRelation.BackColor = System.Drawing.Color.Transparent;
            this.labelCsRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCsRelation.Location = new System.Drawing.Point(4, 34);
            this.labelCsRelation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCsRelation.Name = "labelCsRelation";
            this.labelCsRelation.Size = new System.Drawing.Size(128, 17);
            this.labelCsRelation.TabIndex = 4;
            this.labelCsRelation.Text = "c/s relation:";
            this.labelCsRelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCsRelation.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelCsRelation.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelCsRelation.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelCsRelation.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelSwapValue
            // 
            this.labelSwapValue.AccessibleDescription = "Show the value of the swaps";
            this.labelSwapValue.AccessibleName = "Swaps";
            this.labelSwapValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSwapValue.AutoSize = true;
            this.labelSwapValue.BackColor = System.Drawing.Color.Transparent;
            this.labelSwapValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSwapValue.Location = new System.Drawing.Point(140, 17);
            this.labelSwapValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSwapValue.Name = "labelSwapValue";
            this.labelSwapValue.Size = new System.Drawing.Size(196, 17);
            this.labelSwapValue.TabIndex = 3;
            this.labelSwapValue.Text = "0";
            this.labelSwapValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelSwapValue, "Swaps");
            this.labelSwapValue.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelSwapValue.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelSwapValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelSwapValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelSwap
            // 
            this.labelSwap.AccessibleDescription = "Show the swaps";
            this.labelSwap.AccessibleName = "Swaps";
            this.labelSwap.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSwap.AutoSize = true;
            this.labelSwap.BackColor = System.Drawing.Color.Transparent;
            this.labelSwap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSwap.Location = new System.Drawing.Point(4, 17);
            this.labelSwap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(128, 17);
            this.labelSwap.TabIndex = 2;
            this.labelSwap.Text = "Swaps (s):";
            this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSwap.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelSwap.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelSwap.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelSwap.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelComparisonValue
            // 
            this.labelComparisonValue.AccessibleDescription = "Show the value of the comparisons";
            this.labelComparisonValue.AccessibleName = "Comparisons";
            this.labelComparisonValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelComparisonValue.AutoSize = true;
            this.labelComparisonValue.BackColor = System.Drawing.Color.Transparent;
            this.labelComparisonValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComparisonValue.Location = new System.Drawing.Point(140, 0);
            this.labelComparisonValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComparisonValue.Name = "labelComparisonValue";
            this.labelComparisonValue.Size = new System.Drawing.Size(196, 17);
            this.labelComparisonValue.TabIndex = 1;
            this.labelComparisonValue.Text = "0";
            this.labelComparisonValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelComparisonValue, "Comparisons");
            this.labelComparisonValue.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelComparisonValue.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelComparisonValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelComparisonValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelComparison
            // 
            this.labelComparison.AccessibleDescription = "Show the comparisons";
            this.labelComparison.AccessibleName = "Comparisons";
            this.labelComparison.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelComparison.AutoSize = true;
            this.labelComparison.BackColor = System.Drawing.Color.Transparent;
            this.labelComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComparison.Location = new System.Drawing.Point(4, 0);
            this.labelComparison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.Size = new System.Drawing.Size(128, 17);
            this.labelComparison.TabIndex = 0;
            this.labelComparison.Text = "Comparisons (c):";
            this.labelComparison.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelComparison.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelComparison.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelComparison.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelComparison.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // comboBoxVisualizationScheme
            // 
            this.comboBoxVisualizationScheme.AccessibleDescription = "Click to show the visualization scheme";
            this.comboBoxVisualizationScheme.AccessibleName = "Visualization scheme";
            this.comboBoxVisualizationScheme.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBoxVisualizationScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisualizationScheme.FormattingEnabled = true;
            this.comboBoxVisualizationScheme.Location = new System.Drawing.Point(161, 71);
            this.comboBoxVisualizationScheme.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVisualizationScheme.Name = "comboBoxVisualizationScheme";
            this.comboBoxVisualizationScheme.Size = new System.Drawing.Size(195, 24);
            this.comboBoxVisualizationScheme.TabIndex = 3;
            this.toolTip.SetToolTip(this.comboBoxVisualizationScheme, "Visualization scheme");
            this.comboBoxVisualizationScheme.Enter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxVisualizationScheme.Leave += new System.EventHandler(this.ClearStatusbar);
            this.comboBoxVisualizationScheme.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxVisualizationScheme.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // groupBoxVisualizationDepth
            // 
            this.groupBoxVisualizationDepth.AccessibleDescription = "Group the visualization depth";
            this.groupBoxVisualizationDepth.AccessibleName = "Visualization depth";
            this.groupBoxVisualizationDepth.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBoxVisualizationDepth.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthNone);
            this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthDetailed);
            this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthSimple);
            this.groupBoxVisualizationDepth.Location = new System.Drawing.Point(16, 171);
            this.groupBoxVisualizationDepth.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVisualizationDepth.Name = "groupBoxVisualizationDepth";
            this.groupBoxVisualizationDepth.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVisualizationDepth.Size = new System.Drawing.Size(341, 59);
            this.groupBoxVisualizationDepth.TabIndex = 8;
            this.groupBoxVisualizationDepth.TabStop = false;
            this.groupBoxVisualizationDepth.Text = "Visualization depth";
            // 
            // radioBoxVisualizationDepthNone
            // 
            this.radioBoxVisualizationDepthNone.AccessibleDescription = "Click to apply no visualization depth";
            this.radioBoxVisualizationDepthNone.AccessibleName = "No visualization depth";
            this.radioBoxVisualizationDepthNone.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioBoxVisualizationDepthNone.AutoSize = true;
            this.radioBoxVisualizationDepthNone.Location = new System.Drawing.Point(9, 25);
            this.radioBoxVisualizationDepthNone.Margin = new System.Windows.Forms.Padding(4);
            this.radioBoxVisualizationDepthNone.Name = "radioBoxVisualizationDepthNone";
            this.radioBoxVisualizationDepthNone.Size = new System.Drawing.Size(76, 20);
            this.radioBoxVisualizationDepthNone.TabIndex = 0;
            this.radioBoxVisualizationDepthNone.Text = "(&1) none";
            this.toolTip.SetToolTip(this.radioBoxVisualizationDepthNone, "none visualization depth");
            this.radioBoxVisualizationDepthNone.UseVisualStyleBackColor = true;
            this.radioBoxVisualizationDepthNone.Enter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthNone.Leave += new System.EventHandler(this.ClearStatusbar);
            this.radioBoxVisualizationDepthNone.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthNone.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // radioBoxVisualizationDepthDetailed
            // 
            this.radioBoxVisualizationDepthDetailed.AccessibleDescription = "Click to apply detailed visualization depth";
            this.radioBoxVisualizationDepthDetailed.AccessibleName = "Detailed visualization depth";
            this.radioBoxVisualizationDepthDetailed.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioBoxVisualizationDepthDetailed.AutoSize = true;
            this.radioBoxVisualizationDepthDetailed.Location = new System.Drawing.Point(203, 25);
            this.radioBoxVisualizationDepthDetailed.Margin = new System.Windows.Forms.Padding(4);
            this.radioBoxVisualizationDepthDetailed.Name = "radioBoxVisualizationDepthDetailed";
            this.radioBoxVisualizationDepthDetailed.Size = new System.Drawing.Size(95, 20);
            this.radioBoxVisualizationDepthDetailed.TabIndex = 2;
            this.radioBoxVisualizationDepthDetailed.Text = "(&3) detailed";
            this.toolTip.SetToolTip(this.radioBoxVisualizationDepthDetailed, "detailed visualization depth");
            this.radioBoxVisualizationDepthDetailed.UseVisualStyleBackColor = true;
            this.radioBoxVisualizationDepthDetailed.Enter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthDetailed.Leave += new System.EventHandler(this.ClearStatusbar);
            this.radioBoxVisualizationDepthDetailed.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthDetailed.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // radioBoxVisualizationDepthSimple
            // 
            this.radioBoxVisualizationDepthSimple.AccessibleDescription = "Click to apply simple visualization depth";
            this.radioBoxVisualizationDepthSimple.AccessibleName = "Simple visualization depth";
            this.radioBoxVisualizationDepthSimple.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioBoxVisualizationDepthSimple.AutoSize = true;
            this.radioBoxVisualizationDepthSimple.Checked = true;
            this.radioBoxVisualizationDepthSimple.Location = new System.Drawing.Point(103, 25);
            this.radioBoxVisualizationDepthSimple.Margin = new System.Windows.Forms.Padding(4);
            this.radioBoxVisualizationDepthSimple.Name = "radioBoxVisualizationDepthSimple";
            this.radioBoxVisualizationDepthSimple.Size = new System.Drawing.Size(86, 20);
            this.radioBoxVisualizationDepthSimple.TabIndex = 1;
            this.radioBoxVisualizationDepthSimple.TabStop = true;
            this.radioBoxVisualizationDepthSimple.Text = "(&2) simple";
            this.toolTip.SetToolTip(this.radioBoxVisualizationDepthSimple, "simple visualization depth");
            this.radioBoxVisualizationDepthSimple.UseVisualStyleBackColor = true;
            this.radioBoxVisualizationDepthSimple.Enter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthSimple.Leave += new System.EventHandler(this.ClearStatusbar);
            this.radioBoxVisualizationDepthSimple.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.radioBoxVisualizationDepthSimple.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // checkBoxDataProcessingSpeed
            // 
            this.checkBoxDataProcessingSpeed.AccessibleDescription = "Click to show data processing speed";
            this.checkBoxDataProcessingSpeed.AccessibleName = "Show data processing speed";
            this.checkBoxDataProcessingSpeed.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.checkBoxDataProcessingSpeed.AutoSize = true;
            this.checkBoxDataProcessingSpeed.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDataProcessingSpeed.Checked = true;
            this.checkBoxDataProcessingSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDataProcessingSpeed.Location = new System.Drawing.Point(16, 239);
            this.checkBoxDataProcessingSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDataProcessingSpeed.Name = "checkBoxDataProcessingSpeed";
            this.checkBoxDataProcessingSpeed.Size = new System.Drawing.Size(204, 20);
            this.checkBoxDataProcessingSpeed.TabIndex = 9;
            this.checkBoxDataProcessingSpeed.Text = "Show data &processing speed";
            this.toolTip.SetToolTip(this.checkBoxDataProcessingSpeed, "Show data processing speed");
            this.checkBoxDataProcessingSpeed.UseVisualStyleBackColor = false;
            this.checkBoxDataProcessingSpeed.Enter += new System.EventHandler(this.SetStatusbar);
            this.checkBoxDataProcessingSpeed.Leave += new System.EventHandler(this.ClearStatusbar);
            this.checkBoxDataProcessingSpeed.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.checkBoxDataProcessingSpeed.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // checkBoxFinalEvent
            // 
            this.checkBoxFinalEvent.AccessibleDescription = "Click to apply final event";
            this.checkBoxFinalEvent.AccessibleName = "Apply final event";
            this.checkBoxFinalEvent.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.checkBoxFinalEvent.AutoSize = true;
            this.checkBoxFinalEvent.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFinalEvent.Checked = true;
            this.checkBoxFinalEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFinalEvent.Location = new System.Drawing.Point(16, 267);
            this.checkBoxFinalEvent.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFinalEvent.Name = "checkBoxFinalEvent";
            this.checkBoxFinalEvent.Size = new System.Drawing.Size(127, 20);
            this.checkBoxFinalEvent.TabIndex = 10;
            this.checkBoxFinalEvent.Text = "Appl&y final event";
            this.toolTip.SetToolTip(this.checkBoxFinalEvent, "Apply final event");
            this.checkBoxFinalEvent.UseVisualStyleBackColor = false;
            this.checkBoxFinalEvent.Enter += new System.EventHandler(this.SetStatusbar);
            this.checkBoxFinalEvent.Leave += new System.EventHandler(this.ClearStatusbar);
            this.checkBoxFinalEvent.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.checkBoxFinalEvent.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelSortingAlgorithm
            // 
            this.labelSortingAlgorithm.AccessibleDescription = "Show the sorting algorithms";
            this.labelSortingAlgorithm.AccessibleName = "Sorting algorithm";
            this.labelSortingAlgorithm.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSortingAlgorithm.AutoSize = true;
            this.labelSortingAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.labelSortingAlgorithm.Location = new System.Drawing.Point(12, 18);
            this.labelSortingAlgorithm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortingAlgorithm.Name = "labelSortingAlgorithm";
            this.labelSortingAlgorithm.Size = new System.Drawing.Size(110, 16);
            this.labelSortingAlgorithm.TabIndex = 0;
            this.labelSortingAlgorithm.Text = "Sorting &algorithm:";
            this.labelSortingAlgorithm.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelSortingAlgorithm.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelSortingAlgorithm.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelSortingAlgorithm.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelVisualizationScheme
            // 
            this.labelVisualizationScheme.AccessibleDescription = "Show the visualization scheme";
            this.labelVisualizationScheme.AccessibleName = "Visualization scheme";
            this.labelVisualizationScheme.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelVisualizationScheme.AutoSize = true;
            this.labelVisualizationScheme.BackColor = System.Drawing.Color.Transparent;
            this.labelVisualizationScheme.Location = new System.Drawing.Point(12, 75);
            this.labelVisualizationScheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisualizationScheme.Name = "labelVisualizationScheme";
            this.labelVisualizationScheme.Size = new System.Drawing.Size(136, 16);
            this.labelVisualizationScheme.TabIndex = 2;
            this.labelVisualizationScheme.Text = "&Visualization scheme:";
            this.labelVisualizationScheme.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelVisualizationScheme.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelVisualizationScheme.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelVisualizationScheme.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelShuffleMode
            // 
            this.labelShuffleMode.AccessibleDescription = "Show the shuffle mode";
            this.labelShuffleMode.AccessibleName = "Shuffle mode";
            this.labelShuffleMode.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelShuffleMode.AutoSize = true;
            this.labelShuffleMode.BackColor = System.Drawing.Color.Transparent;
            this.labelShuffleMode.Location = new System.Drawing.Point(12, 108);
            this.labelShuffleMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShuffleMode.Name = "labelShuffleMode";
            this.labelShuffleMode.Size = new System.Drawing.Size(88, 16);
            this.labelShuffleMode.TabIndex = 4;
            this.labelShuffleMode.Text = "Shuffle &mode:";
            this.labelShuffleMode.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelShuffleMode.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelShuffleMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelShuffleMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // comboBoxShuffleMode
            // 
            this.comboBoxShuffleMode.AccessibleDescription = "Click to show the shuffle scheme";
            this.comboBoxShuffleMode.AccessibleName = "Shuffle mode";
            this.comboBoxShuffleMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBoxShuffleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShuffleMode.FormattingEnabled = true;
            this.comboBoxShuffleMode.Location = new System.Drawing.Point(161, 105);
            this.comboBoxShuffleMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShuffleMode.Name = "comboBoxShuffleMode";
            this.comboBoxShuffleMode.Size = new System.Drawing.Size(195, 24);
            this.comboBoxShuffleMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.comboBoxShuffleMode, "Shuffle mode");
            this.comboBoxShuffleMode.Enter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxShuffleMode.Leave += new System.EventHandler(this.ClearStatusbar);
            this.comboBoxShuffleMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxShuffleMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // comboBoxDrawMode
            // 
            this.comboBoxDrawMode.AccessibleDescription = "Click to show the draw scheme";
            this.comboBoxDrawMode.AccessibleName = "Draw mode";
            this.comboBoxDrawMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBoxDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrawMode.FormattingEnabled = true;
            this.comboBoxDrawMode.Location = new System.Drawing.Point(161, 138);
            this.comboBoxDrawMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDrawMode.Name = "comboBoxDrawMode";
            this.comboBoxDrawMode.Size = new System.Drawing.Size(195, 24);
            this.comboBoxDrawMode.TabIndex = 7;
            this.toolTip.SetToolTip(this.comboBoxDrawMode, "Draw mode");
            this.comboBoxDrawMode.Enter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxDrawMode.Leave += new System.EventHandler(this.ClearStatusbar);
            this.comboBoxDrawMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.comboBoxDrawMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // labelDrawMode
            // 
            this.labelDrawMode.AccessibleDescription = "Show the draw mode";
            this.labelDrawMode.AccessibleName = "Draw mode";
            this.labelDrawMode.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelDrawMode.AutoSize = true;
            this.labelDrawMode.BackColor = System.Drawing.Color.Transparent;
            this.labelDrawMode.Location = new System.Drawing.Point(12, 142);
            this.labelDrawMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrawMode.Name = "labelDrawMode";
            this.labelDrawMode.Size = new System.Drawing.Size(79, 16);
            this.labelDrawMode.TabIndex = 6;
            this.labelDrawMode.Text = "&Draw mode:";
            this.labelDrawMode.Enter += new System.EventHandler(this.SetStatusbar);
            this.labelDrawMode.Leave += new System.EventHandler(this.ClearStatusbar);
            this.labelDrawMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.labelDrawMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.AccessibleDescription = "Save logging as csv file";
            this.buttonAnalysis.AccessibleName = "Save logging";
            this.buttonAnalysis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAnalysis.Location = new System.Drawing.Point(16, 359);
            this.buttonAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(340, 28);
            this.buttonAnalysis.TabIndex = 14;
            this.buttonAnalysis.Text = "Comparative Analysis";
            this.toolTip.SetToolTip(this.buttonAnalysis, "Save logging as csv file");
            this.buttonAnalysis.UseVisualStyleBackColor = true;
            this.buttonAnalysis.Click += new System.EventHandler(this.ButtonSaveLogging_Click);
            this.buttonAnalysis.Enter += new System.EventHandler(this.SetStatusbar);
            this.buttonAnalysis.Leave += new System.EventHandler(this.ClearStatusbar);
            this.buttonAnalysis.MouseEnter += new System.EventHandler(this.SetStatusbar);
            this.buttonAnalysis.MouseLeave += new System.EventHandler(this.ClearStatusbar);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Show the Statusbar";
            this.statusStrip.AccessibleName = "Statusbar";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 438);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(721, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AccessibleDescription = "Shw some information";
            this.toolStripStatusLabel.AccessibleName = "Information";
            this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.toolStripStatusLabel.AutoToolTip = true;
            this.toolStripStatusLabel.DoubleClickEnabled = true;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel.Text = "Information";
            this.toolStripStatusLabel.ToolTipText = "Information";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "csv files|*.csv";
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Application";
            this.AccessibleName = "Application";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 464);
            this.Controls.Add(this.buttonAnalysis);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelDrawMode);
            this.Controls.Add(this.comboBoxDrawMode);
            this.Controls.Add(this.labelShuffleMode);
            this.Controls.Add(this.comboBoxShuffleMode);
            this.Controls.Add(this.labelVisualizationScheme);
            this.Controls.Add(this.labelSortingAlgorithm);
            this.Controls.Add(this.checkBoxFinalEvent);
            this.Controls.Add(this.checkBoxDataProcessingSpeed);
            this.Controls.Add(this.groupBoxVisualizationDepth);
            this.Controls.Add(this.comboBoxVisualizationScheme);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.comboBoxSortingAlgorithm);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.buttonSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Sort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelDraw)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.groupBoxVisualizationDepth.ResumeLayout(false);
            this.groupBoxVisualizationDepth.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonShuffle;
		private System.Windows.Forms.ComboBox comboBoxSortingAlgorithm;
		private System.Windows.Forms.PictureBox panelDraw;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelCsRelationValue;
		private System.Windows.Forms.Label labelCsRelation;
		private System.Windows.Forms.Label labelSwapValue;
		private System.Windows.Forms.Label labelSwap;
		private System.Windows.Forms.Label labelComparisonValue;
		private System.Windows.Forms.Label labelComparison;
		private System.Windows.Forms.ComboBox comboBoxVisualizationScheme;
		private System.Windows.Forms.GroupBox groupBoxVisualizationDepth;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthDetailed;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthSimple;
		private System.Windows.Forms.CheckBox checkBoxDataProcessingSpeed;
		private System.Windows.Forms.CheckBox checkBoxFinalEvent;
		private System.Windows.Forms.Label labelSortingAlgorithm;
		private System.Windows.Forms.Label labelVisualizationScheme;
		private System.Windows.Forms.Label labelShuffleMode;
		private System.Windows.Forms.ComboBox comboBoxShuffleMode;
		private System.Windows.Forms.ComboBox comboBoxDrawMode;
		private System.Windows.Forms.Label labelDrawMode;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthNone;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label labelRuntime;
		private System.Windows.Forms.Label labelRuntimeValue;
        private System.Windows.Forms.Button buttonAnalysis;
    }
}


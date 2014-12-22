namespace GraphNodes
{
	partial class ExampleForm
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
            Graph.Compatibility.AlwaysCompatible alwaysCompatible1 = new Graph.Compatibility.AlwaysCompatible();
            this.showLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.nodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.graphControl = new Graph.GraphControl();
            this.nodeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showLabelsCheckBox
            // 
            this.showLabelsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showLabelsCheckBox.AutoSize = true;
            this.showLabelsCheckBox.Location = new System.Drawing.Point(16, 395);
            this.showLabelsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showLabelsCheckBox.Name = "showLabelsCheckBox";
            this.showLabelsCheckBox.Size = new System.Drawing.Size(110, 21);
            this.showLabelsCheckBox.TabIndex = 2;
            this.showLabelsCheckBox.Text = "Show Labels";
            this.showLabelsCheckBox.UseVisualStyleBackColor = true;
            this.showLabelsCheckBox.CheckedChanged += new System.EventHandler(this.OnShowLabelsChanged);
            // 
            // nodeMenu
            // 
            this.nodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testMenuItem});
            this.nodeMenu.Name = "NodeMenu";
            this.nodeMenu.Size = new System.Drawing.Size(106, 28);
            // 
            // testMenuItem
            // 
            this.testMenuItem.Name = "testMenuItem";
            this.testMenuItem.Size = new System.Drawing.Size(105, 24);
            this.testMenuItem.Text = "Test";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.graphControl);
            this.splitContainer1.Size = new System.Drawing.Size(867, 431);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(260, 431);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "color node";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorNode_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "texture node";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextureNode_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "drag&drop nodes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "some node";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SomeNode_MouseDown);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(260, 285);
            this.propertyGrid1.TabIndex = 1;
            // 
            // graphControl
            // 
            this.graphControl.AllowDrop = true;
            this.graphControl.BackColor = System.Drawing.Color.White;
            this.graphControl.CompatibilityStrategy = alwaysCompatible1;
            this.graphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphControl.FocusElement = null;
            this.graphControl.HighlightCompatible = true;
            this.graphControl.LargeGridStep = 128F;
            this.graphControl.LargeStepGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.graphControl.Location = new System.Drawing.Point(0, 0);
            this.graphControl.Margin = new System.Windows.Forms.Padding(4);
            this.graphControl.Name = "graphControl";
            this.graphControl.ShowLabels = false;
            this.graphControl.Size = new System.Drawing.Size(603, 431);
            this.graphControl.SmallGridStep = 16F;
            this.graphControl.SmallStepGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.graphControl.TabIndex = 1;
            this.graphControl.Text = "graphControl";
            this.graphControl.Zoom = 1F;
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.showLabelsCheckBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExampleForm";
            this.Text = "Form1";
            this.nodeMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.CheckBox showLabelsCheckBox;
		private System.Windows.Forms.ContextMenuStrip nodeMenu;
		private System.Windows.Forms.ToolStripMenuItem testMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Graph.GraphControl graphControl;
	}
}


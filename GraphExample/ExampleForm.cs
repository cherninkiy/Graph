using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsGraph.Items;
using System.Drawing.Drawing2D;
using WinFormsGraph.Compatibility;

namespace WinFormsGraph
{
	public partial class ExampleForm : Form
	{
		public ExampleForm()
		{
			InitializeComponent();

            propertyGrid1.CollapseAllGridItems();
            propertyGrid1.SelectedObject = graphControl;

            graphControl.HighlightCompatible = true;

			var someNode1 = new Node("My Title");
			someNode1.Location = new Point(200, 10);
            var check1Item = new NodeCheckboxItem("Check 11", true, false) { Tag = 31337 };
			someNode1.AddItem(check1Item);
            someNode1.AddItem(new NodeCheckboxItem("Check 12", true, false) { Tag = 42f });
			graphControl.AddNode(someNode1);

            var someNode2 = new Node("My Title");
            someNode2.Location = new Point(200, 110);
            var check2Item = new NodeCheckboxItem("Check 21", true, false) { Tag = 31337 };
            someNode2.AddItem(check2Item);
            someNode2.AddItem(new NodeCheckboxItem("Check 22", true, false) { Tag = 42f });
            graphControl.AddNode(someNode2);

			var colorNode = new Node("Color");
			colorNode.Location = new Point(20, 10);
			var redChannel		= new NodeSliderItem("R", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var greenChannel	= new NodeSliderItem("G", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var blueChannel		= new NodeSliderItem("B", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var colorItem		= new NodeColorItem("Color", Color.Black, false, true) { Tag = 1337 };

            EventHandler<NodeItemEventArgs> channelChangedDelegate = delegate(object sender, NodeItemEventArgs args)
			{
				var red = redChannel.Value;
				var green = blueChannel.Value;
				var blue = greenChannel.Value;
				colorItem.Color = Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
			};
            redChannel.ValueChanged += channelChangedDelegate;
            greenChannel.ValueChanged += channelChangedDelegate;
            blueChannel.ValueChanged += channelChangedDelegate;


			colorNode.AddItem(redChannel);
			colorNode.AddItem(greenChannel);
			colorNode.AddItem(blueChannel);

            colorItem.Clicked += OnColClicked;
			colorNode.AddItem(colorItem);
			graphControl.AddNode(colorNode);

			var textureNode = new Node("Texture");
			textureNode.Location = new Point(20, 150);
			var imageItem = new NodeImageItem(Properties.Resources.example, 64, 64, false, true) { Tag = 1000f };
            imageItem.Clicked += OnImgClicked;
			textureNode.AddItem(imageItem);
			graphControl.AddNode(textureNode);

            graphControl.ConnectionAdded += new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionAdded);
            graphControl.ConnectionAdding += new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionAdding);
            graphControl.ConnectionRemoving += new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionRemoved);
            graphControl.ShowElementMenu += new EventHandler<AcceptElementLocationEventArgs>(OnShowElementMenu);

            discreteFlowConnection = graphControl.Connect(colorItem, check1Item);

            CenterToScreen();
		}

        private NodeConnection discreteFlowConnection;

        void OnImgClicked(object sender, NodeItemEventArgs e)
		{
			MessageBox.Show("IMAGE");
		}

        void OnColClicked(object sender, NodeItemEventArgs e)
		{
			MessageBox.Show("Color");
		}

        void OnConnectionRemoved(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
		}

        void OnShowElementMenu(object sender, AcceptElementLocationEventArgs e)
		{
			if (e.Element == null)
			{
				// Show a test menu for when you click on nothing
				testMenuItem.Text = "(clicked on nothing)";
				nodeMenu.Show(e.Position);
				e.Cancel = false;
			} else
			if (e.Element is Node)
			{
				// Show a test menu for a node
				testMenuItem.Text = ((Node)e.Element).Title;
				nodeMenu.Show(e.Position);
				e.Cancel = false;
			} else
			if (e.Element is NodeItem)
			{
				// Show a test menu for a nodeItem
				testMenuItem.Text = e.Element.GetType().Name;
				nodeMenu.Show(e.Position);
				e.Cancel = false;
			} else
			{
				// if you don't want to show a menu for this item (but perhaps show a menu for something more higher up) 
				// then you can cancel the event
				e.Cancel = true;
			}
		}

        void OnConnectionAdding(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
		}

		static int counter = 1;
        void OnConnectionAdded(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
			e.Connection.Name = "Connection " + counter ++;
            e.Connection.DoubleClick += new EventHandler<NodeConnectionEventArgs>(OnConnectionDoubleClick);
		}

        void OnConnectionDoubleClick(object sender, NodeConnectionEventArgs e)
		{
			e.Connection.Name = "Connection " + counter++;
		}

		private void SomeNode_MouseDown(object sender, MouseEventArgs e)
		{
			var node = new Node("Some node");
			node.AddItem(new NodeLabelItem("Entry 1", true, false));
            node.AddItem(new NodeLabelItem("Entry 2", true, false));
            node.AddItem(new NodeLabelItem("Entry 3", false, true));
			node.AddItem(new NodeTextBoxItem("TEXTTEXT", false, true));
            node.AddItem(new NodeNumericSliderItem("R", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false));
            node.AddItem(new NodeDropDownItem(new string[] { "1", "2", "3", "4" }, 0, false, false));
			this.DoDragDrop(node, DragDropEffects.Copy);
		}

		private void TextureNode_MouseDown(object sender, MouseEventArgs e)
		{
			var textureNode = new Node("Texture");
			textureNode.Location = new Point(300, 150);
			var imageItem = new NodeImageItem(Properties.Resources.example, 64, 64, false, true);
			imageItem.Clicked += OnImgClicked;
			textureNode.AddItem(imageItem);
			this.DoDragDrop(textureNode, DragDropEffects.Copy);
		}

		private void ColorNode_MouseDown(object sender, MouseEventArgs e)
		{
			var colorNode = new Node("Color");
			colorNode.Location = new Point(200, 50);
			var redChannel = new NodeSliderItem("R", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var greenChannel = new NodeSliderItem("G", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var blueChannel = new NodeSliderItem("B", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var colorItem = new NodeColorItem("Color", Color.Black, false, true);

            EventHandler<NodeItemEventArgs> channelChangedDelegate = delegate(object s, NodeItemEventArgs args)
			{
				var red = redChannel.Value;
				var green = blueChannel.Value;
				var blue = greenChannel.Value;
				colorItem.Color = Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
			};
            redChannel.ValueChanged += channelChangedDelegate;
            greenChannel.ValueChanged += channelChangedDelegate;
            blueChannel.ValueChanged += channelChangedDelegate;


			colorNode.AddItem(redChannel);
			colorNode.AddItem(greenChannel);
			colorNode.AddItem(blueChannel);

			colorItem.Clicked += OnColClicked;
			colorNode.AddItem(colorItem);

			this.DoDragDrop(colorNode, DragDropEffects.Copy);
		}

        private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
        {
            textBox1.Text = propertyGrid1.SelectedObject.GetType().Name;
        }

        private void graphControl_FocusChanged(object sender, ElementEventArgs e)
        {
            if (graphControl.FocusElement == null)
            {
                propertyGrid1.SelectedObject = graphControl;
            }
            else if (graphControl.FocusElement is NodeSelection)
            {
                propertyGrid1.SelectedObject = (graphControl.FocusElement as NodeSelection).Nodes.First();
            }
            else
            {
                propertyGrid1.SelectedObject = graphControl.FocusElement;
            }

            //graphControl.Invalidate();
            //graphControl.Update();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            graphControl.Invalidate();
        }
	}
}

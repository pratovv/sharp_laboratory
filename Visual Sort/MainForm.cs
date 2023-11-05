using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using Visual_Sort.Properties;

namespace Visual_Sort
{
	public partial class MainForm : Form
	{
		private long
			comparisons = 0,
			swaps = 0;

		private readonly byte[] array = new byte[byte.MaxValue];

		private readonly Stopwatch watch = new Stopwatch();

		private Graphics graphics;

		private readonly Random rand = new Random();

		private readonly Pen
			penDraw = new Pen(SystemColors.ControlText, 1),
			penMarker = new Pen(Color.OrangeRed, 1),
			penFinal = new Pen(Color.LimeGreen, 1),
			penControl = new Pen(Color.White, 1);

		private readonly SolidBrush
			brushDraw = new SolidBrush(SystemColors.ControlText),
			brushMarker = new SolidBrush(Color.OrangeRed),
			brushFinal = new SolidBrush(Color.LimeGreen),
			brushControl = new SolidBrush(Color.White);

		private bool isShuffled = false;

		private Thread thread;

		private readonly Bitmap bmpSave;

		private readonly Dictionary<string, string> dicLogging = new Dictionary<string, string>();

		#region Assemblyattributaccessoren

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyTitle()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
			if (attributes.Length > 0)
			{
				AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
				if (titleAttribute.Title != "")
				{
					return titleAttribute.Title;
				}
			}
			return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyDescription()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)attributes[0]).Description;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyCompany()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)attributes[0]).Company;
		}
		#endregion

		public MainForm() => InitializeComponent();

		private void InitArray()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
		}

		private void InitArrayReverse()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				array[array.Length - i] = i;
			}
		}

		private void MeasureTime() => labelRuntimeValue.Text = watch.Elapsed.ToString();

		private void ShowProcessingInformation()
		{
			if (checkBoxDataProcessingSpeed.Checked)
			{
				labelComparisonValue.Text = comparisons.ToString() + (comparisons / watch.Elapsed.TotalSeconds).ToString("' ('0.00 'per sec)'");
				labelSwapValue.Text = swaps.ToString() + (swaps / watch.Elapsed.TotalSeconds).ToString("' ('0.00 'per sec)'");
			}
			else
			{
				labelComparisonValue.Text = comparisons.ToString();
				labelSwapValue.Text = swaps.ToString();
			}
			labelCsRelationValue.Text = ((swaps * 1.0) / comparisons).ToString("0.0000");
		}


		private void ApplyFinalEvent()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						{
							graphics.DrawLine(penFinal, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							//graphics.DrawLine(penControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
							break;
						}
					case 1: //dotes
						{
							graphics.FillRectangle(brushFinal, i + 1, panelDraw.Height - array[i], 1, 1);
							break;
						}
				}
			}
		}

		private delegate void SetControlValueCallback(Control pnlSort);

		private void RefreshPanel(Control pnlSort)
		{
			if (pnlSort.InvokeRequired)
			{
				SetControlValueCallback d = new SetControlValueCallback(RefreshPanel);
				pnlSort.Invoke(d, new object[] { pnlSort });
			}
			else
			{
				pnlSort.Refresh();
			}
		}

		private void DrawArray()
		{
			/*bmpSave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpSave);
			panelDraw.Image = bmpSave;*/
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != Resources.strLines)
			{
				graphics.Clear(color: panelDraw.BackColor);
			}

			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
						{
							graphics.DrawLine(pen: penDraw, x1: i + 1, y1: panelDraw.Height - array[i], x2: i + 1, y2: panelDraw.Height);
							graphics.DrawLine(pen: penControl, x1: i + 1, y1: 0, x2: i + 1, y2: panelDraw.Height - array[i]);
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
						{
							graphics.FillRectangle(brush: brushDraw, x: i + 1, y: panelDraw.Height - array[i], width: i + 1, height: panelDraw.Height);
							graphics.FillRectangle(brush: brushControl, x: i + 1, y: 0, width: i + 1, height: panelDraw.Height - array[i]);
						}
						break;
					case 1: //dotes
						graphics.FillRectangle(brush: brushDraw, x: i + 1, y: panelDraw.Height - array[i], width: 1, height: 1);
						break;
				}
			}
			//RefreshPanel(panelDraw);
		}

		private void DrawArray(byte marker)
		{
			/*bmpSave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpSave);
			panelDraw.Image = bmpSave;*/
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != Resources.strLines)
			{
				graphics.Clear(panelDraw.BackColor);
			}

			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
							{
								graphics.DrawLine(pen: penMarker, x1: i + 1, y1: panelDraw.Height - array[i], x2: i + 1, y2: panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
							{
								graphics.FillRectangle(brush: brushMarker, x: i + 1, y: panelDraw.Height - array[i], width: i + 1, height: panelDraw.Height);
							}
						}
						else
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
							{
								graphics.DrawLine(pen: penDraw, x1: i + 1, y1: panelDraw.Height - array[i], x2: i + 1, y2: panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
							{
								graphics.FillRectangle(brush: brushDraw, x: i + 1, y: panelDraw.Height - array[i], width: i + 1, height: panelDraw.Height);
							}
						}
						if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
						{
							graphics.DrawLine(pen: penControl, x1: i + 1, y1: 0, x2: i + 1, y2: panelDraw.Height - array[i]);
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
						{
							graphics.FillRectangle(brush: brushControl, x: i + 1, y: 0, width: i + 1, height: panelDraw.Height - array[i]);
						}
						break;
					case 1: //dotes
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							graphics.FillRectangle(brush: brushMarker, x: i + 1, y: panelDraw.Height - array[i], width: 1, height: 1);
						}
						else
						{
							graphics.FillRectangle(brush: brushDraw, x: i + 1, y: panelDraw.Height - array[i], width: 1, height: 1);
						}
						break;
				}
			}
			//RefreshPanel(panelDraw);
		}

		private void Shuffle<T>(T[] array) where T : IComparable
		{
			int n = array.Length;
			while (n > 1)
			{
				int k = rand.Next(n--);
				T temp = array[n];
				array[n] = array[k];
				array[k] = temp;
			}
		}

		private bool IsSorted<T>(T[] array) where T : IComparable
		{
			if (array.Length <= 1)
			{
				return true;
			}

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].CompareTo(obj: array[i - 1]) < 0)
				{
					return false;
				}
			}
			return true;
		}

		private void Swap(ref byte x, ref byte y)
		{
			swaps++;
			byte temp = x;
			x = y;
			y = temp;
		}


		#region BozoSort

		private void BozoSort()
		{
			byte i, j;
			while (!IsSorted(array: array))
			{
				i = (byte)rand.Next(maxValue: array.Length);
				j = (byte)rand.Next(maxValue: array.Length);
				Swap(ref array[i], ref array[j]);
				if (radioBoxVisualizationDepthDetailed.Checked)
				{
					DrawArray(marker: j);
					MeasureTime();
					ShowProcessingInformation();
				}
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTime();
					ShowProcessingInformation();
				}
				if (radioBoxVisualizationDepthNone.Checked)
				{
					graphics.Clear(color: panelDraw.BackColor);
					//RefreshPanel(panelDraw);
					MeasureTime();
					ShowProcessingInformation();
				}
			}
		}

        #endregion


        private void InsertionSort()
        {
            int n = array.Length;
            for (byte i = 1; i < n; i++)
            {
                byte currentElement = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > currentElement)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = currentElement;

                if (radioBoxVisualizationDepthDetailed.Checked)
                {
                    DrawArray(marker: i);
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthSimple.Checked)
                {
                    DrawArray();
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthNone.Checked)
                {
                    graphics.Clear(color: panelDraw.BackColor);
                    MeasureTime();
                    ShowProcessingInformation();
                }
            }
        }


        public void MergeSortAlg()
        {
            byte[] temp = new byte[array.Length];
            Sort(array, temp, 0, array.Length - 1);
        }

        private void Sort(byte[] arr, byte[] temp, byte left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(arr, temp, left, middle);
                Sort(arr, temp, (byte)(middle + 1), right);
                Merge(arr, temp, left, middle, right);
            }
        }

        private void Merge(byte[] arr, byte[] temp, byte left, int middle, int right)
        {
            for (int i = left; i <= right; i++)
            {
                temp[i] = arr[i];
            }

            int index1 = left;
            int index2 = middle + 1;

            for (byte i = left; i <= right; i++)
            {
                if (index1 > middle)
                {
                    arr[i] = temp[index2];
                    index2++;
                }
                else if (index2 > right)
                {
                    arr[i] = temp[index1];
                    index1++;
                }
                else if (temp[index1] <= temp[index2])
                {
                    arr[i] = temp[index1];
                    index1++;
                }
                else
                {
                    arr[i] = temp[index2];
                    index2++;
                }
                if (radioBoxVisualizationDepthDetailed.Checked)
                {
                    DrawArray(marker: i);
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthSimple.Checked)
                {
                    DrawArray();
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthNone.Checked)
                {
                    graphics.Clear(color: panelDraw.BackColor);
                    MeasureTime();
                    ShowProcessingInformation();
                }
            }
        }


        public void CountingSortAlg()
        {
            if (array == null || array.Length <= 1)
                return;

            byte max = array[0];
            byte min = array[0];

            // Find the maximum and minimum values in the byte array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }

            // Create an array for counting elements
            int range = max - min + 1;
            int[] count = new int[range];
            byte[] output = new byte[array.Length];

            // Count the occurrences of each element
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }

            // Calculate cumulative sums
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            // Place elements in their correct positions in the output array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
                if (radioBoxVisualizationDepthDetailed.Checked)
                {
                    DrawArray(marker: (byte)i);
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthSimple.Checked)
                {
                    DrawArray();
                    MeasureTime();
                    ShowProcessingInformation();
                }

                if (radioBoxVisualizationDepthNone.Checked)
                {
                    graphics.Clear(color: panelDraw.BackColor);
                    MeasureTime();
                    ShowProcessingInformation();
                }
            }

            // Copy the sorted byte array back to the original array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }



        #region Statusbar

        private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				toolStripStatusLabel.Text = button.AccessibleDescription;
			}
			else if (sender is Label label)
			{
				toolStripStatusLabel.Text = label.AccessibleDescription;
			}
			else if (sender is ComboBox comboBox)
			{
				toolStripStatusLabel.Text = comboBox.AccessibleDescription;
			}
			else if (sender is RadioButton radioButton)
			{
				toolStripStatusLabel.Text = radioButton.AccessibleDescription;
			}
			else if (sender is CheckBox checkBox)
			{
				toolStripStatusLabel.Text = checkBox.AccessibleDescription;
			}
			else if (sender is PictureBox pictureBox)
			{
				toolStripStatusLabel.Text = pictureBox.AccessibleDescription;
			}
			else if (sender is StatusStrip statusStrip)
			{
				toolStripStatusLabel.Text = statusStrip.AccessibleDescription;
			}
			else if (sender is GroupBox groupBox)
			{
				toolStripStatusLabel.Text = groupBox.AccessibleDescription;
			}
			else if (sender is TableLayoutPanel tableLayoutPanel)
			{
				toolStripStatusLabel.Text = tableLayoutPanel.AccessibleDescription;
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				toolStripStatusLabel.Text = toolStripStatusLabel.AccessibleDescription;
			}
		}

		private void ClearStatusbar(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = "";
		}

		#endregion

		#region Mainform-Events

		private void MainForm_Load(object sender, EventArgs e)
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.UserPaint |
				ControlStyles.AllPaintingInWmPaint, true);
			UpdateStyles();
			typeof(Panel).InvokeMember(name: "DoubleBuffered", invokeAttr: BindingFlags.SetProperty |
				BindingFlags.Instance |
				BindingFlags.NonPublic, binder: null, target: panelDraw, args: new object[] { true });
			ClearStatusbar(sender: null, e: null);
			graphics = panelDraw.CreateGraphics();
			comboBoxSortingAlgorithm.Items.AddRange(items: new object[] {
				Resources.strInsertionSort,
				Resources.strMergeSort,
				Resources.strCountingSort
			}); ;
			comboBoxSortingAlgorithm.SelectedIndex = 2;
			comboBoxVisualizationScheme.Items.AddRange(items: new object[] {
				Resources.strLines,
				Resources.strDotes});
			comboBoxVisualizationScheme.SelectedIndex = 0;
			comboBoxShuffleMode.Items.AddRange(items: new object[] {
				Resources.strRandom,
				Resources.strSortedForward,
				Resources.strSortedReverse});
			comboBoxShuffleMode.SelectedIndex = 0;
			comboBoxDrawMode.Items.AddRange(items: new object[] {
				Resources.strDrawLines,
				Resources.strFillRectangles});
			comboBoxDrawMode.SelectedIndex = 0;
			InitArray();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (thread != null)
			{
				thread.Abort();
				thread.Join();
			}
		}

		#endregion

		#region Button-Events

		private void ButtonShuffle_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
				isShuffled = true;
			}
			labelComparisonValue.Text =
				labelSwapValue.Text =
				labelRuntimeValue.Text =
				labelCsRelationValue.Text = Resources.strNumberZero;
			switch (comboBoxShuffleMode.SelectedIndex)
			{
				case 0: //random
					Shuffle(array: array);
					break;
				case 1: //sorted forward
					InitArray();
					break;
				case 2: //sorted reverse
					InitArrayReverse();
					break;
				default:
					Shuffle(array: array);
					break;
			}
			graphics.Clear(color: panelDraw.BackColor);
			DrawArray();
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
				labelComparisonValue.Text =
					labelSwapValue.Text =
					labelRuntimeValue.Text =
					labelCsRelationValue.Text = Resources.strNumberZero;
				isShuffled = true;
				Shuffle(array: array);
				DrawArray();
			}
			MeasureTime();
			if (thread != null)
			{
				thread.Abort();
				thread.Join();
			}
			void threadStart()
			{
				watch.Reset();
				watch.Start();
				comboBoxSortingAlgorithm.Enabled = false;
				buttonShuffle.Enabled = false;
				buttonSort.Enabled = false;
				dicLogging.Clear();
				comparisons = 0;
				swaps = 0;
				switch (comboBoxSortingAlgorithm.SelectedIndex)
				{
					case 0: 
						InsertionSort();
						break;
					case 1: //Bozo Sort
                        MergeSortAlg();
						break;
					case 2: //Random Sort
						InsertionSort();
                        break;
				}
				if (checkBoxFinalEvent.Checked)
				{
					ApplyFinalEvent();
				}

				comboBoxSortingAlgorithm.Enabled = true;
				buttonShuffle.Enabled = true;
                buttonAnalysis.Enabled = true;
				buttonSort.Enabled = true;
				watch.Stop();
			}
			threadStart();
			MeasureTime();
		}



		private void ButtonSaveLogging_Click(object sender, EventArgs e)
		{
			ComparativeAnalysis com= new ComparativeAnalysis();
			com.ShowDialog();
		}

		#endregion
	}
}
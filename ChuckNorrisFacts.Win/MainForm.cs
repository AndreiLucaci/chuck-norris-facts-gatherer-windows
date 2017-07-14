using System;
using System.Windows.Forms;
using ChuckNorrisFacts.Win.Controllers;

namespace ChuckNorrisFacts.Win
{
	public partial class MainForm : Form
	{
		private readonly FactsGathererController _controller;

		public MainForm(FactsGathererController controller)
		{
			InitializeComponent();

			_controller = controller;
		}

		private async void gather_btn_Click(object sender, System.EventArgs e)
		{
			for (var i = 0; i < numericUpDown1.Value; i++)
			{
				var fact = await _controller.GatherOne();

				richTextBox1.Invoke((Action) (() => richTextBox1.AppendText(PrepareLine(fact.Value))));
			}
		}

		private string PrepareLine(string value)
		{
			return $"{value}{Environment.NewLine}";
		}

		private void clear_btn_Click(object sender, EventArgs e)
		{
			richTextBox1.Invoke((Action) (() => richTextBox1.Clear()));
		}
	}
}

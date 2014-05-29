using System;
using System.Windows.Forms;
using SoulverDotNet.Parser;

namespace SoulverDotNet.Forms
{
    public partial class MainForm : Form
    {
        private const int LINE_NUMBERS_PANEL_WIDTH = 25;
        private const int ANSWERS_PANEL_WIDTH = 200;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ResizeFixedPanels()
        {
            splitContainer.SplitterDistance = splitContainer.Width - ANSWERS_PANEL_WIDTH;
            splitContainerInner.SplitterDistance = LINE_NUMBERS_PANEL_WIDTH;
        }

        private void SetLineNumbers()
        {
            // always show a number for line 1, even with no content
            txtLineNumbers.Text = string.Format("1{0}", Environment.NewLine);

            for (int i = 2; i <= txtQuestions.Lines.Length; i++)
            {
                txtLineNumbers.Text += string.Format("{0}{1}", i, Environment.NewLine);
            }
        }

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetLineNumbers();
            ResizeFixedPanels();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeFixedPanels();
        }

        private void txtQuestions_TextChanged(object sender, EventArgs e)
        {
            SetLineNumbers();

            txtAnswers.Lines = QuestionParser.Parse(txtQuestions.Lines);
        }

		#region Menu Items

		private void newMenuItem_Click(object sender, EventArgs e)
		{
			txtQuestions.Text = string.Empty;
			SetLineNumbers();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			new AboutDialog().ShowDialog();
		}

		#endregion // Menu Items

		#endregion // Event Handlers
	}
}

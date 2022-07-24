using System;
using System.Windows.Forms;

namespace Cant_catch_me
{
    public partial class MainMenu : Form
    {
        GameForm gameForm;
        public MainMenu()
        {
            InitializeComponent();
            InitializeDifficultyComboBox();
        }

        private void InitializeDifficultyComboBox()
        {
            DifficultyComboBox.Items.AddRange(Enum.GetNames(typeof(Difficulty)));
            DifficultyComboBox.SelectedIndex = 0;
        }
        private void GameForm_FormClosed(object sender, EventArgs e)
        {
            Close();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            gameForm = new GameForm((Difficulty)DifficultyComboBox.SelectedIndex);
            InitializeGameForm();
            gameForm.Show();

            this.Visible = false;
        }

        private void InitializeGameForm()
        {
            gameForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(GameForm_FormClosed);
        }
    }
}

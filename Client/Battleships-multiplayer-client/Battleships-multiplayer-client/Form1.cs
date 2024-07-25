namespace Battleships_multiplayer_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create button
            loadGame(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //join button
            loadGame(this);
        }

        private void loadGame(Form thisForm)
        {
            Game game = new Game();
            thisForm.Hide();
            game.Show();
        }
    }
}
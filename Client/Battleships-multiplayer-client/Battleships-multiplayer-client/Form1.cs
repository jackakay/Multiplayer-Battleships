
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http;
using RestSharp;
using static System.Net.Mime.MediaTypeNames;

namespace Battleships_multiplayer_client
{
    public partial class Form1 : Form
    {
        public const string URL = "http://localhost:8080";
        RestClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client  = new RestClient(URL);
        }

        
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            //create button
            string json = JsonConvert.SerializeObject(new { textBox1.Text });

            var request = new RestRequest("/creategame");
            request.AddJsonBody(json);
           
            try
            {
                var response = await client.PostAsync(request);
                MessageBox.Show("Game created with name " + textBox1.Text);
                loadGame(this);
            }catch(HttpRequestException ex)
            {
                MessageBox.Show("Game name already exists, try again.");
            }
           
            
            
            
            //API request needed
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //join button
            //need to setup this function in node.js
            loadGame(this);
            MessageBox.Show("Game name does not exist");
        }

        private bool joinGame(string text)
        {
            throw new NotImplementedException();
        }

        private void loadGame(Form thisForm)
        {
            Game game = new Game();
            thisForm.Hide();
            game.Show();
        }
    }
}
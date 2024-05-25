using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        private List<Movie> movies = new List<Movie>();
        private HttpClient httpClient = new HttpClient();
        public Bai4()
        {
            InitializeComponent();
            LoadMovieData();
        }

        private async Task LoadMovieData()
        {
            string url = "https://betacinemas.vn/phim.htm";
            var response = await httpClient.GetStringAsync(url);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(response);

            var movieNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'movie-block')]");

            foreach (var movieNode in movieNodes)
            {
                string title = movieNode.SelectSingleNode(".//h3").InnerText;
                string detailsUrl = movieNode.SelectSingleNode(".//a").Attributes["href"].Value;

                var movie = new Movie { Title = title, DetailsUrl = detailsUrl };
                movies.Add(movie);

                progressBar1.Value += (100 / movieNodes.Count);
            }

            System.IO.File.WriteAllText("movies.json", JsonConvert.SerializeObject(movies));

            lstMovies.Items.Clear();
            foreach (var movie in movies)
            {
                lstMovies.Items.Add(movie.Title);
            }
        }

        public class Movie
        {
            public string Title { get; set; }
            public string DetailsUrl { get; set; }
        }
    }
}

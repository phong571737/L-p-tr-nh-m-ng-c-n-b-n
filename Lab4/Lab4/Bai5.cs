using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            await ConnectToAPIRequest();
        }

        private async Task ConnectToAPIRequest()
        {
            string url = btURL.Text;
            string username = tbUserName.Text;
            string password = tbPass.Text;



            using (var client = new HttpClient())
            {
                // Get the access token
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };
                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                var responseObject = JObject.Parse(responseString);

                // Kiểm tra xem đăng nhập thành công không
                if (!response.IsSuccessStatusCode)
                {
                    // đăng nhập thất bại
                    var detail = responseObject["detail"].ToString();
                    rtbContent.Text = $"Login failed. Detail: {detail}";
                    return;
                }

                // If login successful, print token information
                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();
                rtbContent.Text = $"Bearer" + "\n" + $"{accessToken}";

                // Now you can use the access token to make authenticated requests
                // For example, let's get user information using the access token
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                //var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                //var getUserResponse = await client.GetAsync(getUserUrl);
                //var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                //rtbContent.AppendText($"\nUser Information: {getUserResponseString}");
                rtbContent.Text += "\n" + "Đăng nhập thành công";
            }
        }
    }
}

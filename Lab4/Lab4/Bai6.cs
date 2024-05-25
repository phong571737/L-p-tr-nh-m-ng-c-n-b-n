using Newtonsoft.Json.Linq;
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

namespace Lab4
{
    public partial class Bai6 : Form
    {
        private string accessToken;
        private string tokenType;
        public Bai6()
        {
            InitializeComponent();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            await ConnectToAPIRequest();
        }

        private async Task ConnectToAPIRequest()
        {
            string url = tbURL.Text;
            string username = tbUsername.Text;
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

                // đăng nhập thành công
                tokenType = responseObject["token_type"].ToString();
                accessToken = responseObject["access_token"].ToString();
                rtbContent.Text = $"Bearer" + "\n" + $"{accessToken}";
                rtbContent.Text += "\n" + "Đăng nhập thành công";
            }
        }

        private async void btUserInfor_Click(object sender, EventArgs e)
        {
            await GetUserInfor();
        }

        private async Task GetUserInfor()
        {
            if (string.IsNullOrEmpty(accessToken)) 
            {
                MessageBox.Show("Bạn cần đăng nhập trước", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string url = "https://nt106.uitiot.vn/api/v1/user/me";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                    HttpResponseMessage response = await client.GetAsync(url);
                    string responseString = await response.Content.ReadAsStringAsync();


                    if (!response.IsSuccessStatusCode)
                    {
                        var responseObject = JObject.Parse(responseString);
                        // đăng nhập thất bại
                        var detail = responseObject["detail"].ToString();
                        rtbContent.Text = $"Đăng nhập thất bại. Detail: {detail}";
                        return;
                    }
                    else
                    {
                        var responseObject = JObject.Parse(responseString);
                        string userInfor = $"Thông tin user:\n" +
                            $"Id: {responseObject["id"]}\n" +
                            $"Username: {responseObject["username"]}\n" +
                            $"Email: {responseObject["email"]}\n" +
                            $"First Name: {responseObject["first_name"]}\n" +
                            $"Last name: {responseObject["last_name"]}\n"
                            ;
                        rtbContent.Text = userInfor;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

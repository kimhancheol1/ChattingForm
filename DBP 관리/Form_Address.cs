using System.Diagnostics;
using System.Net;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace DBP_관리
{
    public delegate void DataGetEventHandler(string data);
    public partial class Form_Address : Form
    {
        public DataGetEventHandler sendEvent;
        int prevLBSelectedIndex = -1;
        public Form_Address()
        {
            InitializeComponent();
        }

        public void SearchKeyword(string query, ListBox list)
        {
            if (query.Equals(""))
            {
                MessageBox.Show("주소를 입력해주세요");
                return;
            }
            string key = "jftyUNdWKF%2FaY5lruiTOEzHizTDZ5%2BimMQZbmXCidMFtBAc%2Fr8IFtN%2BzPwglot681F7GKDfRyctTdzJL8X8rAQ%3D%3D";
            string url = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll";

            url += "?ServiceKey=" + key; // Service Key
            url += $"&srchwrd={query}";
            url += "&countPerPage=50";
            url += "&currentPage=1";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                results = reader.ReadToEnd();
            }

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(results);
            XmlNodeList xnList = xml.GetElementsByTagName("newAddressListAreaCdSearchAll");

            list.Items.Clear();
            foreach (XmlNode xn in xnList)
            {
                string zipNo = xn["zipNo"].InnerText;
                string lnmAddress = xn["lnmAdres"].InnerText;
                string rnAddress = xn["rnAdres"].InnerText;
                list.Items.Add(zipNo + " \n" + lnmAddress + " \n" + rnAddress);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            Brush brush;
            if (this.list_Address.SelectedIndex == e.Index)
                brush = Brushes.White;
            else
                brush = Brushes.Black;

            //Font의 Height를 더한 만큼 좌표를 변경합니다.
            int x = e.Bounds.X + e.Font.Height;
            int y = e.Bounds.Y + e.Font.Height;

            e.Graphics.DrawString(this.list_Address.Items[e.Index].ToString(),
                e.Font, brush, x, y, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prevLBSelectedIndex != -1)
                list_Address.Invalidate(list_Address.GetItemRectangle(prevLBSelectedIndex));

            prevLBSelectedIndex = list_Address.SelectedIndex;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchKeyword(txt_Keyword.Text, list_Address);
        }


        private void TextEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchKeyword(txt_Keyword.Text, list_Address);
            }
        }

        private void Form_Address_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sendEvent(list_Address.Text);
            this.Close();
        }
    }
}
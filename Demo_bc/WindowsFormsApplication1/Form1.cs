//using System;
//using System.Net;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;
//using System.Web;
//using System.IO;
//using System.Text;
using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Tukhoa
        {
            private string diachi;

            private int vitri;

            public Tukhoa()
            {

            }
            public Tukhoa(string diachi, int vitri)
            {
                this.Diachi = diachi;
                this.Vitri = vitri;
            }

            public string Diachi
            {
                get
                {
                    return diachi;
                }

                set
                {
                    diachi = value;
                }
            }

            public int Vitri
            {
                get
                {
                    return vitri;
                }

                set
                {
                    vitri = value;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string strUrl = txt_WebTK.Text;
            //Uri newUri = new Uri("https://google.com.vn");
            //int I = GetPosition(newUri, txt_TuKhoa.Text);
            //txt_KQViTri.Text = I.ToString();
             Tukhoa ketqua = new Tukhoa();
              ketqua = LayViTri(txt_WebTK.Text, txt_TuKhoa.Text);

              if (ketqua != null)
              {
                  txt_KQViTri.Text = string.Format("{0}", ketqua.Vitri);

                string link = ketqua.Diachi;
                var linkParser = new Regex(@"(?:https?://|www.)S+?&sa", RegexOptions.Compiled | RegexOptions.IgnoreCase);
               // var linkParser = new Regex(@"(https?://|www.)S+?&sa", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                foreach (Match m in linkParser.Matches(link))
                    link = m.Value;
                string pattern = "&sa";
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string ketqua_DC = rgx.Replace(link, replacement);
                ////textBox2.Text = ketqua_DC;
                txt_KQDiaChi.Text = link;
              }
              else
              {
                  txt_KQViTri.Text = "Từ khóa của bạn không nằm trong Top 100";
                  txt_KQDiaChi.Text = "NaN";
              }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbl_webnguon.SelectedIndex = 0;
        }
         private Tukhoa LayViTri(string Url, string tukhoa_tk)
         {
             Tukhoa ketqua= new Tukhoa();
             string raw = cbl_webnguon.Text + "/search?num=100&q={0}&btnG=Search";//tìm kiếm trên trang mình lựa chọn ở combobox
             string search = string.Format(raw, System.Uri.EscapeDataString(tukhoa_tk));
             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(search);// khới tạo HttpWebRequest theo từ khóa 
             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
             {
                 using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                 {

                     string html = reader.ReadToEnd();
                     ketqua = TimViTri(html, Url);// lấy vị trí một trang web tìm đuoẹc với rrang web cần tìm theo thuật toán viết ở dưới
                     return ketqua;
                 }
             }

         }
         private Tukhoa TimViTri(string html, string url)
         {
            int dem = 1;
             Tukhoa ketqua = new Tukhoa();
             var Webget = new HtmlWeb();// khởi tạo một đối tượng HtmlWeb của thư viện HtmlAgilityPack
             var page = Webget.Load("https://google.com.vn");// load trên địa chỉ google
            page.LoadHtml(html);

             var list = page.DocumentNode.SelectNodes("//a/@href");//("//h3[@class='r']//a");lấy thành phần href của thẻ a trên tất các link mà google tìm đc


            int count = list.Count();// dếm tổng số link tìm đc
            //tao lao int i = 0;
         
            ArrayList ListUrls1 = new ArrayList();
            ArrayList ListUrls2 = new ArrayList();
            foreach (var obj in list)
             {
                 i++;
                 if (i > count)
                 {
                     break;
                 }
                 else
                 // i = 4;
                 {
                    //        var urls = obj.SelectSingleNode(".").Attributes["href"].Value;
                    //        if (urls.Contains(url))
                    //        {
                    //            // lấy link bài viết
                    //            ketqua.Diachi = urls;
                    //            // lấy được vị trí
                    //            ketqua.Vitri = i;
                    //            return ketqua;
                    //        }

                    //    }
                    //}
                    //return null;
                    var http = "https://";
                    var urls = obj.SelectSingleNode(".").Attributes["href"].Value;// coi lại sai lay thong tin ơ đay
                   // ListUrls2.Add(urls);// them urls vao mang 

                    if (urls.Contains(http))//kiểm tra kink tìm được có chưa địa chỉ cần tìm k
                    {
                        ListUrls1.Add(urls);// them urls vao mang 
                       // j++;
                        for (int j = 0; j < ListUrls1.Count; j++)
                        {
                            //ListUrls2.Add(ListUrls1[j]);
                            for (int y = 1; y < ListUrls1.Count; y++)
                            {
                                //ListUrls2.Add(ListUrls1[j]);
                                if (!ListUrls1[j].ToString().Contains(url) && ListUrls1[y].ToString().Contains(url))
                                {
                                    ListUrls2.Add(ListUrls1[j]);
                                }
                                if (ListUrls1[j].ToString().Contains(url) && ListUrls1[y].ToString().Contains(url))
                                {
                                    //ListUrls2.Remove(ListUrls1[j]);
                                    ListUrls2.Add(ListUrls1[j]);
                                    //lấy link bài viết
                                    //ketqua.Diachi = ListUrls1[j].ToString();
                                    //lấy được vị trí
                                    ListUrls1.Remove(ListUrls1[y]);
                                    //ListUrls2.Add(ListUrls1[j]);
                                    //ketqua.Vitri = j;


                                    //ketqua.Vitri = j;
                                    //ketqua.Vitri = ListUrls2.Count;
                                    //return ketqua;

                                }
                               



                            }


                        }

                    }
                    int j1;
                    for (j1 = 0; j1 < ListUrls2.Count; j1++)
                    {
                        if (ListUrls2[j1].ToString().Contains(url))
                        {
                            ketqua.Diachi = ListUrls2[j1].ToString();
                            ketqua.Vitri = j1+1;
                            return ketqua;
                        }
                    }

                }
            }
            return null;

        }
        //public int GetPosition(Uri url, string searchTerm)
        //{
        //    string raw = "http://www.google.com/search?num=39&q={0}&btnG=Search";
        //    string search = string.Format(raw, HttpUtility.UrlEncode(searchTerm));

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(search);
        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
        //        {
        //            string html = reader.ReadToEnd();
        //            return SearchGoogle(html, url);
        //        };
        //    }
        //}
        //public int SearchGoogle(string html, Uri url)
        //{
        //    int i;
        //    string lookup = "(<a class=l href=\")(\\w+[a-zA-Z0-9.-?=/]*)";
        //    MatchCollection matches = Regex.Matches(html, lookup);
        //    for (i = 0; i < matches.Count; i++)
        //    { 
        //        string match = matches[i].Groups[2].Value;
        //        if (match.Contains(url.Host))
        //            return i + 1;
              
        //    }
        //    return i;

        //}
    }
}


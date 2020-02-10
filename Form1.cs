using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_6_C_sharp
{
    public partial class Form1 : Form

    {
        List<string> l=new List<string>();
        ConcurrentDictionary<int, int> dic = new ConcurrentDictionary<int, int>();
        Series ser1 = new Series("My Series");
        DateTime time1;
        CancellationTokenSource cts;
        CancellationToken token;
        int progress = 0;


        public Form1()
        {
            InitializeComponent();
            l=Directory.GetFiles(Application.StartupPath + @"\books").ToList();

            chart1.Legends.Clear();
            chart1.DataSource = dic;
            chart1.Series.Add(ser1);
           




        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Prepare();
           


            await Task.Run(() => {

                if (token.IsCancellationRequested) { return; }  // return if cancel has been pressed
                time1 = DateTime.Now; // record start time
                foreach (string s in l) {
                    if (token.IsCancellationRequested) { break; } // check cancellation at each iteration
                    
                   Parse_book(s);
                    Invoke((Action)(() => progressBar1.Value = 100 * progress / l.Count)); // refresh progress bar
                    float time2 = (float)(DateTime.Now - time1).TotalMilliseconds; 
                    Invoke((Action)(() => serial_sec.Text = time2.ToString() + " ms"));  // refreshing label

                    Invoke((Action)(() => chart1.Series["My Series"].Points.DataBindXY(dic.Keys, dic.Values)));
                }

            }
           
            );

            // var max = dic.Max(s => s.Key); // max word length
            
            if (token.IsCancellationRequested) {
                MessageBox.Show("Operation cancelled");  // if cancellation has been requested               
            }
            else { MessageBox.Show("Operation finished"); }
            Serial.Enabled = true; 
            Parallel.Enabled = true;
        }


        private void Parse_book(string s)
        {

           Interlocked.Increment(ref progress);
            StreamReader sr = new StreamReader(s, Encoding.Default);
            string str = sr.ReadToEnd();
            Regex regex = new Regex(@"[А-Яа-яA-Za-z-]+");
            MatchCollection matches = regex.Matches(str);
            foreach (Match mat in matches)
            {


				dic.AddOrUpdate(mat.Value.Length, 1, (key, oldValue) => oldValue + 1);
            }


        }


        

        //}

        private void Prepare() {
            progress = 0;
            dic.Clear();  // clear the dictionary before next start
            //lw.Clear();
            cts = new CancellationTokenSource();
            token = cts.Token;
            Serial.Enabled = false;
            Parallel.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Prepare();
       
            time1 = DateTime.Now;

            await Task.Run(() =>
            {

                Invoke((Action)(() => progressBar1.Value = 0)); 

                try
                {
                    System.Threading.Tasks.Parallel.For(0, l.Count, new ParallelOptions { CancellationToken = token }, i =>
                    {
                        Parse_book(l[i]);
                        Invoke((Action)(() => progressBar1.Value = 100 * progress / l.Count));
                        float time2 = (float)(DateTime.Now - time1).TotalMilliseconds;
                        Invoke((Action)(() => par_sec.Text = time2.ToString() + " ms"));
                        Invoke((Action)(() => chart1.Series["My Series"].Points.DataBindXY(dic.Keys, dic.Values)));


                    });
                    MessageBox.Show("Operation finished");

                }
                catch (OperationCanceledException ex)
                {
                    MessageBox.Show("Operation cancelled");
                   

                }

              

            }
  

            );

            Serial.Enabled = true;
            Parallel.Enabled = true;

        }
    }
}

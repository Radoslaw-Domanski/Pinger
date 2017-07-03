using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections;

namespace Pinger
{
    public partial class Form1 : Form
    {
        public static ArrayList listaDomen = new ArrayList();
        public static ArrayList listaIP = new ArrayList();
        public static ArrayList historiaDomen = new ArrayList();
        public static ArrayList historiaIP = new ArrayList();
        public static ArrayList listaDat = new ArrayList();
        public static ArrayList listaDatDodanych = new ArrayList();
        public static ArrayList listaAdresowIP = new ArrayList();
        public static int rozmiar = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                domainName.Text = String.Empty;
                pingedIP.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Escape)
            {
                pingedIP.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                IPPingedHistory.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string domena = domainName.Text;
            domena = domena.Trim();
            if (domena.StartsWith("http://"))
            {
                domena = domena.Substring("http://".Length);
            }
            if (domena.EndsWith("/"))
            {
                domena = domena.Substring(0,domena.Length-1);
            }
            string ip = pingIp(domena);
            listPingedDomains.Items.Add(domena);
            pingedIP.Text = ip;
            historiaDomen.Add(domena);
            historiaIP.Add(ip);
        }
        public static String pingIp(string domena)
        {
            String spingowane = String.Empty;
            domena = domena.Trim();
            if (domena.StartsWith("http://"))
            {
                domena = domena.Substring("http://".Length);
            }
            if (domena.EndsWith("/"))
            {
                domena = domena.Substring(0, domena.Length - 1);
            }
            try
            {
                IPAddress[] ip = Dns.GetHostAddresses(domena);
                spingowane = ip[0].ToString();
            }
            catch (Exception ex)
            {
                spingowane = "Domena nieosiągalna !";
            }
            
            return spingowane;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaDomen.Clear();
            listaIP.Clear();
            rozmiar = 0;
            pingProgress.Value = 0;
            openDomainList.Filter = "Notepad|*.txt|All|*.*";
            if (openDomainList.ShowDialog() == DialogResult.OK)
            {                
                    StreamReader strumien = new StreamReader(openDomainList.FileName);
                    while (!strumien.EndOfStream)
                        listaDomen.Add(strumien.ReadLine());
                    strumien.Close();
                    pingProgress.Maximum = listaDomen.Count;                
            }            
            statusPingInfo.Text = "Plik załadowano !";
        }
        public static void pingList(ArrayList lista){
            foreach(String domena in lista){
                listaIP.Add(pingIp(domena));
                rozmiar++;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            saveDomainListDialog.Filter = "Notepad|*.txt|All|*.*";
            if (saveDomainListDialog.ShowDialog() == DialogResult.OK)
            {
                if (listaAdresowIP.Count.Equals(0))
                {
                    using (StreamWriter sw = new StreamWriter(saveDomainListDialog.FileName))
                    {
                        sw.WriteLine("Domena" + "\t" + "Adres IP");
                        for (int i = 0; i < rozmiar; i++)
                            sw.WriteLine(listaDomen[i] + "\t" + listaIP[i]);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(saveDomainListDialog.FileName))
                    {
                        sw.WriteLine("Domena\tSerwer");
                        for (int i = 0; i < rozmiar; i++)
                        {
                            bool tmp = false;
                            for (int j = 0; j < listaAdresowIP.Count; j++)
                            {
                                if (listaIP[i].Equals(listaAdresowIP[j]))
                                {
                                    tmp = true;
                                }
                            }
                            if (listaIP[i].Equals("Domena nieosiągalna !"))
                            {
                                sw.WriteLine(listaDomen[i] + "\tDomena nieosiągalna !");
                            }                     
                            else if(tmp)
                            {
                                sw.WriteLine(listaDomen[i] + "\tnasz");
                            }
                            else
                            {
                                sw.WriteLine(listaDomen[i] + "\tklienta");
                            }                           
                        }                           
                        sw.Close();
                    }
                }                                                                                
            }
            wczytanoInfo.Text = String.Empty;
            statusPingInfo.Text = "Zapisano do pliku: " + Path.GetFileName(saveDomainListDialog.FileName);
            pingProgress.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (String domena in listaDomen)
            {
                listaIP.Add(pingIp(domena));
                rozmiar++;
                pingProgress.Value++;
            }
            wczytanoInfo.Text = String.Empty;
            statusPingInfo.Text = "Spingowano domeny !";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listPingedDomains.SelectedIndex;
            IPPingedHistory.Text = historiaIP[x].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listPingedDomains.Items.Clear();
            historiaIP.Clear();
            historiaDomen.Clear();
            IPPingedHistory.Text = String.Empty;
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listDateDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader strumien = new StreamReader(listDateDialog.FileName);
                while (!strumien.EndOfStream)
                {                  
                    DateTime data = DateTime.Parse(strumien.ReadLine());
                    listaDat.Add(data);
                }                   
                strumien.Close();
                statusDni.Text = "Wczytano dat : " + listaDat.Count.ToString();
            }
        }

        private void addDays_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            foreach(DateTime data in listaDat)
            {
                int oIle = rand.Next(0, 2);
                DateTime x;
                if (data.DayOfWeek == DayOfWeek.Wednesday)
                {
                    x = data.AddDays(2);
                }
                else if (data.DayOfWeek == DayOfWeek.Thursday)
                {
                    x = data.AddDays(4);
                }
                else if (data.DayOfWeek == DayOfWeek.Friday)
                {
                    x = data.AddDays(3);
                }
                else
                {
                    x = (oIle == 0) ? data.AddDays(2) : data.AddDays(3);
                }
                listaDatDodanych.Add(x);
            }
            statusDni.Text = "Dodano daty !";
        }

        private void saveDates_Click(object sender, EventArgs e)
        {
            saveAddedDates.Filter = "Notepad|*.txt|All|*.*";
            if (saveAddedDates.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveAddedDates.FileName))
                {
                    sw.WriteLine("Nowa Data");
                    string months = "0", days = "0";
                    foreach (DateTime data in listaDatDodanych)
                    {
                        months = (data.Month < 10) ? ("0" + data.Month.ToString()) : data.Month.ToString();                       
                        days = (data.Day < 10) ? ("0" + data.Day.ToString()) : data.Day.ToString();
                        sw.WriteLine(data.Year + "-" + months + "-" + days);
                    }
                    sw.Close();
                }
            }
            statusDni.Text = "Zapisano do pliku: " + Path.GetFileName(saveAddedDates.FileName);        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openIPList.Filter = "Notepad|*.txt|All|*.*";
            if (openIPList.ShowDialog() == DialogResult.OK)
            {
                StreamReader strumien = new StreamReader(openIPList.FileName);
                while (!strumien.EndOfStream)
                {
                    listaAdresowIP.Add(strumien.ReadLine());
                }
                strumien.Close();
            }
            labelIPList.Text = "Załadowano plik z adresami do porównania";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listaAdresowIP.Clear();
            labelIPList.Text = "Lista adresów do porównania pusta";
        }
    }
}

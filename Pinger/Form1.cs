using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Pinger
{
    public partial class Form1 : Form
    {
        public static ArrayList listaDomen = new ArrayList();
        public static ArrayList listaIP = new ArrayList();
        public static ArrayList historiaDomen = new ArrayList();
        public static ArrayList historiaIP = new ArrayList();
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
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Escape)
            {
                textBox2.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                textBox3.Text = String.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string domena = textBox1.Text;
            domena = domena.Trim();
            if (domena.StartsWith("http://"))
            {
                domena = domena.Substring("http://".Length);
            }
            string ip = pingIp(domena);
            listBox1.Items.Add(domena);
            textBox2.Text = ip;
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
            try
            {
                IPAddress[] ip = Dns.GetHostAddresses(domena);
                spingowane = ip[0].ToString();
            }
            catch (Exception e)
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
            progressBar1.Value = 0;
            openFileDialog1.Filter = "Notepad|*.txt|All|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                    System.IO.StreamReader strumien = new System.IO.StreamReader(openFileDialog1.FileName);
                    plikInfo.Text = Path.GetFileName(openFileDialog1.FileName);
                    while (!strumien.EndOfStream)
                        listaDomen.Add(strumien.ReadLine());
                    strumien.Close();
                    label5.Text = listaDomen.Count.ToString();
                    progressBar1.Maximum = listaDomen.Count;                
            }            
            wczytanoInfo.Text = "Plik załadowano !";
            spingowanoInfo.Text = String.Empty;
            zapisaneInfo.Text = String.Empty;
        }
        public static void pingList(ArrayList lista){
            foreach(String domena in lista){
                listaIP.Add(pingIp(domena));
                rozmiar++;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            String plik = String.Empty; 
            saveFileDialog1.Filter = "All|*.*|Notepad|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                plik = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("Domena" + "\t" + "Adres IP");
                    for (int i = 0; i < rozmiar; i++)
                        sw.WriteLine(listaDomen[i] + "\t" + listaIP[i]);
                    sw.Close();
                }                                                                                
            }
            plikInfo.Text = "Brak";
            wczytanoInfo.Text = String.Empty;
            spingowanoInfo.Text = String.Empty;
            zapisaneInfo.Text = "Zapisano do pliku: " + Path.GetFileName(plik);
            progressBar1.Value = 0;
            label5.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (String domena in listaDomen)
            {
                listaIP.Add(pingIp(domena));
                rozmiar++;
                progressBar1.Value++;
            }
            wczytanoInfo.Text = String.Empty;
            spingowanoInfo.Text = "Spingowano domeny !";
            zapisaneInfo.Text = String.Empty;
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
            int x = listBox1.SelectedIndex;
            textBox3.Text = historiaIP[x].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            historiaIP.Clear();
            historiaDomen.Clear();
            textBox3.Text = String.Empty;
        }        
    }
}

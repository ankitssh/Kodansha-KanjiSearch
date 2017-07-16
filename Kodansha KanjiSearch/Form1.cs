using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSON_SerDe;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Web;
namespace Kodansha_KanjiSearch
{
    public partial class KanjiSearchUI : MaterialForm
    {


        public KanjiSearchUI()
        {
            
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey900, Primary.BlueGrey700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

          //this.outputBox = new RichTextBoxLinks.RichTextBoxEx();
        }


        

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            
            if (kanjiSearchBox.Text == "")
                return;


            string input = kanjiSearchBox.Text;
            
         JSON_SerDe.Program.Main();
         var kanjiList= JSON_SerDe.Program.kanjiList;
         int n;
         if (kanjiList.Count == 0)
         {
             MessageBox.Show("Couldn't load the database. Application will now exit.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             Application.Exit();

         }
         if (int.TryParse(input, out n))
         {
             if (n < 1 || n > 2300)
             {
                 MessageBox.Show("Kanji with this ID is not in the database! Please enter an ID between 1-2300.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 return;
             }
             outputBox.Text = kanjiList[int.Parse(input) - 1].ToString() + "" + " Jisho Link: ";
             string url=  "jisho.org/search" + "/"+kanjiList[int.Parse(input) - 1].kanji;

             outputBox.Text += "http://www."+HttpUtility.UrlEncode(url)+"\n";
             
             historyView.Items.Insert(0, kanjiList[int.Parse(input) - 1].kanji + " " + DateTime.Now.ToString("hh:mm:ss tt") ); 
            
         }

         else
         {
            
             int id = 0;
             int inputLength = input.Length;
             int k = 0;
             while (k < inputLength)
             {
                 bool isFound = false;
                 for (int i = 0; i < kanjiList.Count; i++)
                 {
                     if (input[k].ToString() == kanjiList[i].kanji)
                     {
                         id = i;
                         outputBox.Text = outputBox.Text + "\n" + kanjiList[id].ToString();
                         k++;
                         historyView.Items.Insert(0, kanjiList[id].kanji + " " + DateTime.Now.ToString("hh:mm:ss tt"));
                         string url = "jisho.org/search" + "/" + kanjiList[i].kanji;

                         outputBox.Text += "http://www." + HttpUtility.UrlEncode(url)+"\n";
                         isFound = true;
                         break;

                     }

                 }

                 if (isFound == false)
                 {
                     MessageBox.Show(input[k]+" is not in the database.\nPlease enter only those kanji that are present in the Kodansha Kanji Learners Course.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     k++;
                 }
             }

         }
      
            
        }

      

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is useful to get information on Kanjis that are listed in Kodansha Kanji Learners course.\n\nDesigned and developed by Soul_Hacker\nIdea by RetraZil\n\nProtected by MIT License", "Kodansha Kanji Search 2017",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }



        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            { 
                materialFlatButton1_Click( sender,  e);
            }
         
        }

        private void outputBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(HttpUtility.UrlDecode(e.LinkText));

        }

        private void historyView_SelectedIndexChanged(object sender, EventArgs e)
        {
            kanjiSearchBox.Text = historyView.SelectedItem.ToString()[0].ToString();
            materialFlatButton1_Click(sender, e);
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            historyView.Items.Clear();
        }

       

      

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
namespace JSON_SerDe
{
    
  public  class KanjiDetails
    {

      public int id;
      public  string kanji;
      public string meaning;
      public string onyomi;
      public string kunyomi;
      public int pageno;

      /*  public KanjiDetails(int newId,string newKanji, string newMeaning, string newOnyomi, string newKunyomi, int newPageno)
        {
            id = newId;
            kanji = newKanji;
            meaning = newMeaning;
            onyomi = newOnyomi;
            kunyomi = newKunyomi;
            pageno = newPageno;
        }*/

        public override string ToString()
        {
            string result=" ID : "+id+"\n Kanji: "+kanji+"\n Meaning: "+meaning+"\n Onyomi: "+onyomi+"\n Kunyomi: "+kunyomi+"\n Page Number: "+pageno+"\n";
            return result;
        }
    
    }
  public class Program
    {
      public static List<KanjiDetails> kanjiList = new List<KanjiDetails>();

     

      public static void Main()
        {
        

     
       /*     int getId = 0;
            string getKanji = null;
            string getMeaning = null;
            string getOnymi = null;
            string getKunyomi = null;
            int getPageNumber = 0;

          */
           /* try
            {
                using (StreamReader sr = new StreamReader("../../../The Kodansha Kanji Learners Course.txt", Encoding.UTF8))
                {
                    sr.ReadLine();

                    while (sr.EndOfStream == false)
                    {

                        string input = sr.ReadLine();
                        string[] inputArray = input.Split('\t');
                        getId = Convert.ToInt32(inputArray[0]);
                        getKanji = inputArray[1];
                        getMeaning = inputArray[2];

                        getOnymi = inputArray[3];
                        getKunyomi = inputArray[4];
                        getPageNumber = Convert.ToInt32(inputArray[5]);

                        KanjiDetails kanji = new KanjiDetails(getId, getKanji, getMeaning, getOnymi, getKunyomi, getPageNumber);
                        kanjiList.Add(kanji);

                    }

                    sr.Close();

                }

            }
            catch (Exception ex)
            {

               // Console.WriteLine("Database not found! Please verify that the database is in correct location and try again. "+ex.Message);
            }*/

            JavaScriptSerializer jsDeserializer = new JavaScriptSerializer();
            try
            {
                using (StreamReader sr = new StreamReader("KodanshaDatabase", Encoding.UTF8))
                {
                    string readData = sr.ReadToEnd();
                    kanjiList = (List<KanjiDetails>)jsDeserializer.Deserialize(readData, typeof(List<KanjiDetails>));

                }
            }
            catch (Exception)
            {
                
                
            }
         


           
            
        }
    }
}

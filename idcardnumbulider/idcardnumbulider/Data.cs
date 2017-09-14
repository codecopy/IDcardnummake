using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace idcardnumbulider
{
    class Data
    {
        public string birthday { set; get; }
        public int sex { set; get; }//1man,2women
        public string areacode { set; get; }
        
        public Data(){
        }
        private string Randombullid() {
            Random r = new Random();
            int a;
            do{
                a=r.Next(1000,1999);
            
            }
            while((a+sex)%2==0);
            return a.ToString().Substring(1,3);
        
        }
        public string idnum()
        { 
            string tmp=areacode+birthday+Randombullid();
            string[] a = new string[] { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
           
            int sum = 0;
            for (int i = 1; i <= 17; i++) {
                sum += (int)(Math.Pow(2, i)) * (int.Parse(""+tmp[18 - i-1]));
            
            }
            int spc = sum % 11;
            
            string result = areacode + birthday.ToString() + Randombullid()+a[spc]; 

            return result;
        }







    }
}

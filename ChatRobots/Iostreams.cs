using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;//文件操作

namespace ChatRobots
{
    class Iostreams///读取文本类
    {
        public static void Import(string File_Name)
        {
            using (StreamReader sr = new StreamReader(File_Name, Encoding.Default))
            {
                string line1,line2;
                while((line1=sr.ReadLine())!= null)//按行读取
                {
                    
                 //   while ((line2 = sr.ReadLine())=="")
                    line2 = sr.ReadLine();
                    DataBase.Insert(line1, line2);
                  //  if(sr.ReadLine().Equals(""))
                    sr.ReadLine();
                }
                
            }
        }
    }
}

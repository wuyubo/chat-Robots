using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;//正则表达式

namespace ChatRobots
{
    class Regular//正则表达式类
    {
        public static bool match(string a, string ask)//正则表达式品配
        {
            Regex re = new Regex(@"[\s\S]*" + a + @"[\s\S]*");//简单的正则表达式
            return re.IsMatch(ask);//品配成功则返回true，否则返回false
        }
    }
}

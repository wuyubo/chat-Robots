using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatRobots
{
    class Robot //机器人类
    {
        public string name;//名字
        public string sex;//性别
        public int age;//年龄
        public Robot(string name, string sex, int age)//构造函数，初始化
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        public string answer(string ask)//问答函数
        {
            List<conversation> answers = new List<conversation>();
            string answer=null,a=null;
            a = "SELECT ask,answer FROM [chatwords] WHERE (ask LIKE'%[" + ask + "]%') ORDER BY ask DESC";///sql语句品所有字符的模糊搜索
            answers = DataBase.search(a);
            if (answers.Count != 0)
            {
                for (int i = 0; i < answers.Count; i++)
                {
                    if (Regular.match(answers[i].ask,ask ))
                        return answers[i].answer;
                }
            }
            answer = "听不懂";
            return answer;//返回包括有输入的任一字的ask和answer
        }
        public void learn(string ask, string answer)//调教输入函数
        {
            DataBase.Insert(ask, answer);
        }
    }
}

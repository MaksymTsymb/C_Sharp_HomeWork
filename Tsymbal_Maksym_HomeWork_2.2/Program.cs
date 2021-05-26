using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
//2. Створити Інтерфейс IMessage для нашого проекту "Чат" з наступними полями
//
//   -- From
//   -- ToWhom
//   -- Text
//   -- TimeStamp
// optional
//   -- Color, textFormat
/// </summary>


namespace Tsymbal_Maksym_HomeWork_2._2
{
    interface IMessage
    {
        string From();
        string ToWhom();
        string Text();
        TimeSpan TimeStamp();
        string Color();
        string TextFormat();

    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

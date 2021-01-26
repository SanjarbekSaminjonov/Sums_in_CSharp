using System;
using System.Collections;
namespace NongenericCollections
{
    public class Program
    {
        // Демонстрация ArrayList , Stack , Queu e и Hashtabl e
        public static void Main(string[] args ) 
{
            // ArrayLis t
            // 
            // Инстанцировани е ArrayLis t(вы может е указат ь
            // начальны й размер, но может е этог о и не делать)
            ArrayListaListWithSpecifiedSize = new ArrayList(1000);
            ArrayListaList = new ArrayList(); // разме р n o
                                                 // умолчани ю(16)
            aList.Add("one"); // Добавлени е в коне ц списк а
            aList.Add("two"); // В списк е -"one","two "
            aList.Add("three"); // В списк е -"one","two","three "
            Console.WriteLine("{0 } item s i n th e ArrayList:",
            aList.Count);
            // Цикл с использование м foreac h
            foreach (strin g s i n aList ) 
{
                // Выводим строк у и е е индек с в ArrayLis t
                Console.WriteLine(s + " в ({о})", aList.IndexOf(s));
            }
            // 
            // Stac k
            // 
            // Инстанцируе м сте к
            Stac k stac k = new Stack();
            // Вносим элемент ы в сте к и снимае м с нег о один
            // элемен т
            stack.Push("one");
            stack.Push("two"); // "two","one "
            stack.Push("three"); // "three","two","one "
            Console.WriteLine("{0 } элементо в в стеке : ",
            stack.Count);
            foreac h(strin g s i n stack)
            {
                Console.WriteLine(s);
            }
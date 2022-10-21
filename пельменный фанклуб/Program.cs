using static пельменный_фанклуб.Note;

namespace пельменный_фанклуб
{

    internal class Program
    {
        static void Main()
        {
            Note note = new Note();
            note.title = "  1.Жоска поплакать";
            note.text = "Мороженное с винкс больше не продают:(";
            note.dateofcreating = new DateTime(2022, 10, 20);
            note.position = 1;

            Note note1 = new Note();
            note1.title = "   2.Жоска рассказать анекдот";
            note1.text = "Что сказали сиамские близнецы, когда собрались на вечеринку? Оторвёмся. Как Следует";
            note1.dateofcreating = new DateTime(2022, 10, 20);
            note1.position = 2;

            Note note2 = new Note();
            note2.title = "   3.Жоска люблю своих кошек";
            note2.text = "лююююю";
            note2.dateofcreating = new DateTime(2022, 10, 20);
            note2.position = 3;

            Note note5 = new Note();
            note5.title = "   4. Жоска хочу сырники";
            note5.text = "хочу сырники";
            note5.dateofcreating = new DateTime(2022, 10, 20);
            note5.position = 4;

            Note note3 = new Note();
            note3.title = "  1.Жоска поехать в мпт";
            note3.text = "Памагите";
            note3.dateofcreating = new DateTime(2022, 10, 19);
            note3.position = 5 ;

            Note note4 = new Note();
            note4.title = "   2.Жоска засишарпиться";
            note4.text = "Боль и страдания";
            note4.dateofcreating = new DateTime(2022, 10, 19);
            note4.position = 6;

            Note note6 = new Note();
            note6.title = "   1.Жоска гитбашить";
            note6.text = "алохв гитхаб";
            note6.dateofcreating = new DateTime(2022, 10, 18);
            note6.position = 7;

            Note note7 = new Note();
            note7.title = "   2.Жоска покушать";
            note7.text = "Хорошего дня!!!!";
            note7.dateofcreating = new DateTime(2022, 10, 18);
            note7.position = 8;

            Note note8 = new Note();
            note8.title = "   1.Жоска совершить октябрьскую революцию";
            note8.text = "Ленин батя";
            note8.dateofcreating = new DateTime(1917, 10, 25);
            note8.position = 9;

            List<Note> notes = new List<Note>();
            notes.Add(note);
            notes.Add(note1);
            notes.Add(note2);
            notes.Add(note3);
            notes.Add(note4);
            notes.Add(note5);
            notes.Add(note6);
            notes.Add(note7);
            notes.Add(note8);

            DateTime today = DateTime.Now.Date;
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Дата: " + today.ToShortDateString());
                for (int i = 0; i < notes.Count; i++)
                {

                    if (notes[i].dateofcreating.Date == today.Date)
                    {
                        Console.WriteLine(notes[i].title);
                    }
                }
                position = RaaapMonstaaaa(key, position);
                Console.SetCursorPosition(0, position);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    today = today.AddDays(1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    today = today.AddDays(-1);
                }
            }
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                foreach (Note pos in notes)
                {
                   if (pos.position == position)
                    {
                    Console.WriteLine("Информация о заметке: ");
                    Console.WriteLine("Название: ");
                    Console.WriteLine( pos.title);
                    Console.WriteLine("Содержание: ");
                    Console.WriteLine(pos.text);
                    Console.WriteLine("Дата создания: ");
                    Console.WriteLine( pos.dateofcreating);
                    }
                    
                }

            }

        }
        static int RaaapMonstaaaa(ConsoleKeyInfo key1, int position)
        {
            if (key1.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
            else if (key1.Key == ConsoleKey.DownArrow)
            {

                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            return position;
        }
    }
}
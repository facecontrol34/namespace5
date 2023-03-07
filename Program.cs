using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Namespace1.Student[] students = new Namespace1.Student[3]
            {
                new Namespace1.Student("Охлобыстин Г.Д.", "Группа 1", 20),
                new Namespace1.Student("Путята М. Д.", "Группа 2", 19),
                new Namespace1.Student("Очканов Г. Н.", "Группа 3", 21)
            };
            ReaderNamespace.Reader[] readers = new ReaderNamespace.Reader[3]
                {
                new ReaderNamespace.Reader("Охлобыстин Г.Д.", "123456", "Факультет 1", new DateTime(2000, 1, 1), "+71234567890"),
                new ReaderNamespace.Reader("Путята М. Д.", "234567", "Факультет 2", new DateTime(2001, 2, 2), "+71234567891"),
                new ReaderNamespace.Reader("Очканов Г. Н.", "345678", "Факультет 3", new DateTime(1999, 3, 3), "+71234567892")
                };

            foreach (var student in students)
            {
                student.PrintStudent();
            }

            foreach (var reader in readers)
            {
                reader.PrintInfo();
            }

            readers[0].TakeBook(3);
            readers[1].TakeBook("Приключение", "Словарь", "Энциклопедия");
            readers[0].ReturnBook(3);
            readers[1].ReturnBook("Приключение", "Словарь", "Энциклопедия");
        }
    }
}
namespace Namespace1
{
    class Student
    {
        public string Name;
        public string Group;
        private int Age;

        public Student(string name, string group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }
        public void PrintStudent()
        {
            Console.WriteLine($"ФИО: {Name}, Группа: {Group}, Возраст: {Age}");
        }
    }
}
namespace ReaderNamespace
{
    public class Reader
    {
        private string FullName;
        public string CardNumber;
        public string Faculty;
        private DateTime DateOfBirth;
        public string PhoneNumber;

        public Reader(string fullName, string cardNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Faculty = faculty;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {FullName}, Номер читательского билета: {CardNumber}, Факультет: {Faculty}, Дата рождения: {DateOfBirth.ToShortDateString()}, Телефон: {PhoneNumber}");
        }

        public void TakeBook(int count)
        {
            Console.WriteLine($"{FullName} взял {count} книг(и)");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.WriteLine($"{FullName} взял книги: {string.Join(", ", bookNames)}");
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{FullName} вернул {count} книг(и)");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{FullName} вернул книги: {string.Join(", ", bookNames)}");
        }
    }
}

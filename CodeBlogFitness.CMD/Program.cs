using CodeBlogFitness.BL.Controller;
using System;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFittness");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthday = DateTime.Parse(Console.ReadLine()); // TODO: Здесь должен быть tryParse

            Console.WriteLine("Введите свой вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой рост");
            var height = double.Parse(Console.ReadLine());
            var userController = new UserController(name, gender, birthday, weight, height);
            userController.Save();
        }
    }
}

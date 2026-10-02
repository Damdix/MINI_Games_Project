using System.ComponentModel.Design;

Console.WriteLine(" \n\t ==FanITasy==  \n Введи имя своего персонажа:");
string user_name = Convert.ToString(Console.ReadLine());


int hp = 100;
int coin = 0;

// ==Вступление== \\

Console.WriteLine($" \n\t Приветствую тебя, {user_name}, в чудесном мире 'FanITasy'! \n\t Здесь каждый выбор меняет твою судьбу. \n\t Зарабатывай монеты, проходи уровни, \n\t торгуй и становись сильнее с каждым шагом! \n\t А теперь напиши своё имя, если готов отправиться в путь! \n Ввод: ");
string user_name_accept = Convert.ToString(Console.ReadLine());


if (user_name == user_name_accept)
{
    // == Локация 1 "Деревня" == \\

    Console.WriteLine(" \t Ты просыпаешься посреди тихой деревни. \n\t Перед тобой два пути: \n 1: Купить зелье (10 монет) \n 2: Войти в лес \n\t Твой выбор: ");

    int first_choice = Convert.ToInt32(Console.ReadLine());
    if (first_choice == 1)
    {
        if (coin == 10)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("Недостаточно средств :( . Попробуй заново!");
        }
    }
    else
    {
        // == Локация 2 "Лес" == \\
        coin = 10;

        Console.WriteLine("+ 10 монет\n\tТы идёшь по лесу уже около десяти минут.\n\t Внезапно из чащи выпрыгивает стая волков!\n\t Рядом ты замечаешь всадника — он готов помочь, но за 10 монет. \n\t Напиши 1: попробовать убежать\n\t Напиши 2: заплатить ему за помощь");

        int second_choice = Convert.ToInt32(Console.ReadLine());
        if (second_choice == 1)
        {
            hp = 50;
            coin = 20;

            Console.WriteLine("-50hp + 10 монет.\nТы не смог убежать — волки искусали тебя.\nДолго ты брёл по лесу, пока не наткнулся на тёмную пещеру.\n В этой пещере жил дракон, и он медленно повернул голову в твою сторону у тебя есть выбор \n1: Откупиться за 20 монет\n2: Попробовать убить дракона");
            int third_choice = Convert.ToInt32(Console.ReadLine());
            if (third_choice == 1)
            {
                if (coin == 20)
                {
                    coin = 0;
                    Console.WriteLine("-20 монет.\nТы откупился от дракона и выбежал из пещеры живым!");
                }
                else
                {
                    Console.WriteLine("Недостаточно монет! Дракон дышит огнём — ты теряешь 30hp.");
                    hp = hp - 30;
                }
            }
            else if (third_choice == 2)
            {
                Console.WriteLine("Ты бросаешься на дракона!\nДракон оказался сильнее — ты теряешь 50hp.");
                hp = hp - 50;
            }
        }
        else if (second_choice == 2)
        {
            if (coin == 10)
            {
                coin = 0;
                Console.WriteLine("-10 монет.\nВсадник отогнал волков, но забрал у тебя 10 монет.\nДолго ты брёл по лесу, пока не наткнулся на тёмную пещеру.\n В этой пещере жил дракон, и он медленно повернул голову в твою сторону у тебя есть выбор \n1:Откупится за 20 монет\n2:попробовать убить дракона так");
                int third_choice = Convert.ToInt32(Console.ReadLine());
                if (third_choice == 1)
                {
                    if (coin == 20)
                    {
                        coin = 0;
                        Console.WriteLine("-20 монет.\nТы откупился от дракона и выбежал из пещеры живым!");
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно монет! Дракон дышит огнём — ты теряешь 30hp.");
                        hp = hp - 30;
                    }
                }
                else if (third_choice == 2)
                {
                    Console.WriteLine("Ты бросаешься на дракона!\nДракон оказался сильнее — ты теряешь 50hp.");
                    hp = hp - 50;
                }
            }
        }
    }
}
else
{
    Console.WriteLine("Error");
}
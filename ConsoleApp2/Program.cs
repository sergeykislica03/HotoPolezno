int balans = 100;  
Console.WriteLine("Добро пожаловать в банкомат!\n");
Console.WriteLine("Ваш баланс:");
Console.WriteLine(balans);
Console.WriteLine("Введите сумму снятия:");
int D = Convert.ToInt32(Console.ReadLine());
int s = balans - D;
Console.WriteLine("Ваш баланс:");
Console.WriteLine(s);
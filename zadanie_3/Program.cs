// По заданному номеру дня недели вывести его название
Console.Clear ();

string [] array = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.Write("Какой день недели?");
int N = int.Parse(Console.ReadLine());
Console.Write(array [N-1]);
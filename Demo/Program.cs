// See https://aka.ms/new-console-template for more information
DateTime dateTime= DateTime.Now;
int year = dateTime.Year - 1911;
string now = year.ToString("000")+dateTime.ToString("MMdd HH:mm:ss.fff");
Console.WriteLine(now);

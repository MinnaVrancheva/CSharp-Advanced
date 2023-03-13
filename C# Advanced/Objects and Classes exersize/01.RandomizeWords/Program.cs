
string[] sentence = Console.ReadLine()
    .Split();

Random rnd = new Random();

for (int i = 0; i < sentence.Length; i++)
{
    int num = rnd.Next(0, sentence.Length - 1);
    var a = sentence[num];
    var b = sentence[i];
    sentence[num] = b;
    sentence[i] = a;
}

Console.WriteLine(String.Join(Environment.NewLine, sentence));
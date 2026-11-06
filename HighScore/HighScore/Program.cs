int[] scores = { 75, 90, 60, 100, 80, 56, 92, 39 };

float Total = 0, avarage;

int highscores = scores[0]; // Inisialisasi dengan elemen pertama

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"player {i + 1} : {scores[i]}");

    Total += scores[i];

    if (scores[i] > highscores)
    {
        highscores = scores[i];
    }
}

avarage = Total / scores.Length;

Console.WriteLine($"avarage is : {avarage}");
Console.WriteLine($"HighScore : {highscores}");
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

//First convert task into pseudo-code...

RandomizeAnimals();
string[,] group = AssignGroup();
Console.WriteLine("School A");
PrintGroup(group);

void RandomizeAnimals()
{
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        Random random = new Random();
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

foreach(string animal in pettingZoo) 
{
    Console.WriteLine(animal);
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[start++];
        }
    }
    return result;
}
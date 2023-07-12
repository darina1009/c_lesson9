int Promt (string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int n, int m){
    if (m == 0) 
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Promt("Введите m:");
int n = Promt("Введите n:");

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
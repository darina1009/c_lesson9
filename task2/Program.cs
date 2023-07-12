int Promt (string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int Summ(int n, int m){
    if (n==m) return n;
    else return Summ(n+1, m) + n;
}


int n = Promt("Введите n:");
int m = Promt("Введите m:");

Console.WriteLine(Summ(n,m));
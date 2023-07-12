int Promt (string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int Summ(int n, int m){
    if (n==m) return n;
    else 
    Console.Write($"{Summ(n, m+1)}, ");
    return m;
}


int n = Promt("Введите n:");

if (n<1){
    Console.WriteLine("Введите число:");
    return;
}
Console.WriteLine(Summ(n,1));

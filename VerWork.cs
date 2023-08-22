Console.WriteLine ("Введите колличество элементов(строк) в массиве: ");
int m = int.Parse(Console.ReadLine());
string[] arr = new string[m];

for(int i = 1; i < m + 1; i++){
    Console.WriteLine ("Введите {0} элемент массива (любые символы кроме последовательности (/ /) ): ", i);
    string n = Console.ReadLine();
    arr[i-1] = n;
}

string[] arrElLengThree(string[] arr){
    string strTemp = string.Empty;
    foreach (string a in arr){
        if (a.Length < 4){
            strTemp = strTemp+a+"(/ /)";
        }
    }
    string[] arrTemp = strTemp.Split("(/ /)");
    if (arrTemp.Length > 1){
        int arrEndLenght = arrTemp.Length-1;
        string[] arrEnd = new string[arrEndLenght];
        for(int i = 0; i < arrEndLenght; i++){
            arrEnd[i] = arrTemp[i];
        }
        return arrEnd;
    }    
    return arrTemp;
}

Console.WriteLine();
Console.WriteLine("Ваш массив: ");
Console.WriteLine("[{0}]", string.Join(", ", arrElLengThree(arr)));
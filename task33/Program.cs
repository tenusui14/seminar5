// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomArray(){
    int [] array = new int[10];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(-100, 111);
    }
    return array;
}
int NumberInput(){
    Console.WriteLine("Введите число, которое хотите найти: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string FindInArray(int[] array, int digit){
    string message = " ";
for(int i = 0; i < array.Length; i++){
    
    if(digit == array[i]){
        message = "Данное число присутствует";
        break;
    }
    else {
        message = "Данное число отсутствует";
    }
}
return message;
}

int [] myArray = GetRandomArray();
Console.WriteLine($"[ {string.Join(", ",myArray)} ]");
int number = NumberInput();
string finder = FindInArray(myArray, number);
Console.WriteLine(finder);



// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] GetRandomArray(){
    int [] array = new int[5];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}
int Calculations(int[] array){
int count = 0;
for(int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0){
        count++;
    }
}
return count;
}

int[] myArray = GetRandomArray();
int getEven = Calculations(myArray);
Console.WriteLine($"[ {string.Join(", ",myArray)} ] -> {getEven}");

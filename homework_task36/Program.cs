// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(){
    int [] array = new int[8];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(-24,25);
    }
    return array;
}
int Calculations(int[] array){
int count = 0;
for(int i = 0; i < array.Length; i++){
    if (i % 2 != 0){
        count += array[i];
    }
}
return count;
}
int[] myArray = GetRandomArray();
int getEven = Calculations(myArray);
Console.WriteLine($"[ {string.Join(", ",myArray)} ] -> {getEven}");

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
int[] GetRandomArray(){
    int [] array = new int[12];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}
int SumPositiveEl(int [] array){
    int sumOfPositive = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i]> 0){
            sumOfPositive +=  array[i];
        }
    }
    return sumOfPositive;
}
int SumNegativeEl(int [] array){
    int sumOfNegative = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i]< 0){
            sumOfNegative +=  array[i];
        }
    }
    return sumOfNegative;
}
int [] myArray = GetRandomArray();
int sumPositive = SumPositiveEl(myArray);
int sumNegative = SumNegativeEl(myArray);

Console.WriteLine($"[ {string.Join(", ",myArray)} ]");
Console.WriteLine($"Сумма положительных элементов равна = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна = {sumNegative}");

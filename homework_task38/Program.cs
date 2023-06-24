// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

int[] GetRandomArray(){
    int [] array = new int[5];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(1,101);
    }
    return array;
}
int Calculations(int[] array){
int diff = 0;
int max = array[0];
int min = array[0];
for(int i = 1; i < array.Length; i++){
    if(array[i]> max){
        max = array[i];
    }
    else if (array[i] < min){
        min = array[i];
    }
}
diff = max - min;
return diff;
}

int[] myArray = GetRandomArray();
int getDiff = Calculations(myArray);
Console.WriteLine($"[ {string.Join(", ",myArray)} ] Разница между max и min = {getDiff}");

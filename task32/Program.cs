// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray(){
    int [] array = new int[20];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(-10, 11);
    }
    return array;
}
int[] SwapDigit(int [] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = array[i] * -1;
    }
    return array;
}

int[] myArray = GetRandomArray();
Console.WriteLine($"[ {string.Join(", ",myArray)} ]");
int[] swap = SwapDigit(myArray);
Console.WriteLine($"[ {string.Join(", ",swap)} ]");
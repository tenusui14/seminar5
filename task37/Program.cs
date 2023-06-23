// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] array = {1,2,6,8,5,7,2,4};

Console.WriteLine($"[ {string.Join(", ",array)} ]");

int [] number1 = new int[(array.Length+1)/2];

for(int i = 0; i < number1.Length; i++){
    number1[i] = array[i] * array[array.Length - 1 - i];
}
if(array.Length % 2 != 0){
number1[number1.Length-1] = array[array.Length/2];
}

Console.WriteLine($"[ {string.Join(", ",number1)} ]");

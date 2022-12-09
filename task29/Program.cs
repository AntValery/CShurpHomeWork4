// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] createArray(int n){
    int[] array = new int[n];
    for(int i = 0; i < n; i++){
        array[i] = new Random().Next(-100, 100);
    }

    return array;
}

void printArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int[] arr = createArray(8);
printArray(arr);
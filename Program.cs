string[] original_array = new string[] {};

void fill_array(ref string[]? array) {
    string answer = "yes";

    int index = 0;

    while(answer == "yes" || answer == "y") {
        Console.Clear();

        Console.Write("Введите строку: ");
        string element = Console.ReadLine();

        Array.Resize(ref array, index + 1);
        array[index] = element;

        Console.Write("Продолжить ввод? [y]es/[n]o: ");
        answer = Console.ReadLine();

        index++;
    }
}

fill_array(ref original_array);

string[] filter_array(string[] original_array) {
    int original_array_size = original_array.Length;

    string[] result_array = new string[] {};

    for(int index = 0; index < original_array_size; index++) {
        string element = original_array[index];

        if(element.Length <= 3) {
            int result_array_size = result_array.Length;

            Array.Resize(ref result_array, result_array_size + 1);
            result_array[result_array_size] = element;
        }
    }

    return result_array;
}

string[] result_array = filter_array(original_array);

Console.Clear();

Console.WriteLine($"[{String.Join(", ", original_array)}] -> [{String.Join(", ", result_array)}]");

// [Hello, 2, world, :-)] → [2, :-)]
// [1234, 1567, -2, computer science] → [-2]
// [Russia, Denmark, Kazan] → []

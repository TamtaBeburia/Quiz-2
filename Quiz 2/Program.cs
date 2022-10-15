// 1)

int sum = 0, mult = 1;
Console.WriteLine("input 10 number");
int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 10; i+=2)
{
    sum = sum + i;
}
Console.WriteLine(sum);

for (int i = 1; i < 10; i += 2)
{
    mult = mult * i;
}
Console.WriteLine(mult);
Console.WriteLine(array.Length);



// 2)

string a = string.Empty;
Console.WriteLine("Enter Word");
a = Console.ReadLine();
char[] palindrome = a.ToCharArray();
Array.Reverse(palindrome);
string b = new string(palindrome);
if (a.ToLower().Equals(b.ToLower()))
{
   Console.WriteLine("Is Palindrome");
}
else
{
   Console.WriteLine("Is not Palindrome");
}

Console.ReadLine();




//4)
int[] arr = { 1, 1, 3, 4, 5, 5, 5, 6, 9, 30, 25, 25, 31 };

int[] arr2 = { arr[0] };

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr[i] == arr2[j])
        {
            
            Array.Resize(ref arr2, arr2.Length + 1);
            arr2[arr2.Length - 1] = arr[i];
        }
        
    }
}
Console.WriteLine(arr2[j]);


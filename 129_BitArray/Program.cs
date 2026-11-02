
using System.Collections;

var bitArray = new BitArray(8);

/*
 * BitArray is a collection of bits that can be set to true or false.
 * It is similar to an array of booleans, but it is more efficient in terms of memory usage.
 * Each bit in a BitArray can be set to true or false using the Set method.
 * The length of a BitArray can be specified when it is created, and it can be resized later if needed.
 * The BitArray class also provides methods for performing bitwise operations on the bits, such as AND, OR, and XOR.
 */
/*
 * In this example, we create a BitArray of length 8 and set the bits at indices 0, 2, 4, and 6 to true,
 * while the bits at indices 1, 3, 5, and 7 are set to false.
 * This results in a BitArray that represents the binary number 10101010.
 */

//bitArray.Set(0, true);
//bitArray.Set(1, false);
//bitArray.Set(2, true);
//bitArray.Set(3, false);
//bitArray.Set(4, true);
//bitArray.Set(5, false);
//bitArray.Set(6, true);
//bitArray.Set(7, false);

bitArray[0] = true;
bitArray[1] = false;
bitArray[2] = true;
bitArray[3] = false;
bitArray[4] = true;
bitArray[5] = false;
bitArray[6] = true;
bitArray[7] = false;

//bitArray[8] = true; // This will throw an exception because the index is out of range.

for (int i = 0; i < bitArray.Length; i++ )
    Console.WriteLine($"Bit at index {i}: {bitArray[i]}");

//perform logical NOT operation 

Console.WriteLine("\n After NOT Operation We Can Called It Reverse.\n");
var notBittArray = bitArray.Not();
for (int i = 0; i < bitArray.Length; i++)
{
    Console.WriteLine($"Bit at index {i}: {notBittArray[i]}");
}


var newBitArray = new BitArray(new[] { true, false, true, false, true, false, true, false });

bitArray.Or(newBitArray);
Console.WriteLine("\n After OR Operation:\n");
for (int i = 0; i < bitArray.Length; i++)
{
    Console.WriteLine($"Bit at index {i}: {bitArray[i]}");
}
Console.ReadLine();

//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
//of the string with the first of the key, the second – with the second, etc. When the last key 
//character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main(string[] args)
    {
        string myStr = Console.ReadLine();
        string myCipher = Console.ReadLine();

        string encripted = EncriptDecript(myStr, myCipher);
        string decripted = EncriptDecript(encripted, myCipher);

        Console.WriteLine(encripted);
        Console.WriteLine(decripted);
    }

    public static string EncriptDecript(string str, string cipher)
    {
        StringBuilder encrStr = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            encrStr.Append((char)((int)str[i] ^ (int)cipher[i % cipher.Length]));
        }

        return encrStr.ToString();
    }
}
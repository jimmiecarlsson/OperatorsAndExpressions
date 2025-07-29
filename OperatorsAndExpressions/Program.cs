// See https://aka.ms/new-console-template for more information


//Exercise 1

Console.WriteLine("--------- Exercise 1 --------"); // 

Console.WriteLine("Hello" + " " + "World!"); // Hello World!

Console.WriteLine(2 + 4); // 6

Console.WriteLine("2" + "4"); // 24

Console.WriteLine(2 + "4"); // 24

Console.WriteLine("2" + 4 + 7); // 247

Console.WriteLine(3 + 5 + "=" + 3 + 5); // 8=35

Console.WriteLine(6 + 2 + "3"); // 83

Console.WriteLine("Two" + "Three"); // TwoThree

Console.WriteLine(1 + 2 + "Three"); // 3Three

Console.WriteLine(4>2); // true

Console.WriteLine(34 < 32 + 4); // true (+ går före <)

Console.WriteLine(33 != 33); // false

Console.WriteLine(34 - 2 == 36); // false

Console.WriteLine(34 + 2 != 36); // false (+ går före !=, 36 != 36)

Console.WriteLine(34 + 2 >= 36); // true

Console.WriteLine(34-2 > 36); // false

Console.WriteLine(4 == 4 ? "One": "Two"); // true



//Exercise 2

Console.WriteLine("--------- Exercise 2 --------"); // 

Console.WriteLine(1 + "" + "="); // 1= 

Console.WriteLine(3+6*2); // 15 

Console.WriteLine("2" + 3 * 2); // 26 

Console.WriteLine(2 + 3 + "4" + 4 / 2); // 542 

Console.WriteLine("2" + (7 - 4)); // error! för att + är i string mode och inte i en beräkning. Parantes runt beräkningen ger 23. 

Console.WriteLine(7 / 3); // 2 eftersom det är int

Console.WriteLine(2 * (4 + 2)); // 12 eftersom parantesern räknas först 

Console.WriteLine(3 + (5 + "G")); // 35G 

Console.WriteLine(1 + 4 / 3); // 2 

Console.WriteLine(3 == 3 && 4 != 6); // true 

Console.WriteLine(3 == 4 || 4 != 4); // false 

Console.WriteLine(4 > 9 ? "Lucene" : 4 + 89); // 93


// Exercise 3

Console.WriteLine("--------- Exercise 3 --------"); // 

Console.WriteLine("No" + "" + "way"); // Noway

Console.WriteLine(4 + 6); // 10 

Console.WriteLine("3" + "9"); // 39

Console.WriteLine(1123 + "23"); // 112323

Console.WriteLine("43" + 2 + 5); // 4325 string value mode

Console.WriteLine(100 + "" + "+"); // 100+

Console.WriteLine(56 + 5 * 6); // 86 

Console.WriteLine("1" + 1 * 1); // 11 

Console.WriteLine(1 + 11 + "1" + 11 / 11); // 1211 

Console.WriteLine("34" + (2 - 1)); // error! paranteser för beräkningen ger 341 

Console.WriteLine(13 / 2); // 6

Console.WriteLine(4 * (5-3)); // 8

Console.WriteLine(9 + (2 + "OH")); // 92OH 

Console.WriteLine(12 + 12 / 4); // 15

Console.WriteLine(9 == 9 && 893 != 891 + 2); // false + går före !=

Console.WriteLine(8 == 4 / 2 || 4 != 4 / 2); // true

Console.WriteLine(2 + 8 + "=" + 2 + 8); // 10=28

Console.WriteLine(45 - 40 == 50 ? 3 + 6 : 6 + "3"); // 63
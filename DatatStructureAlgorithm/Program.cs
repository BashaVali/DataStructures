﻿using DatatStructureAlgorithm;
using System;
namespace DataStructureAlgorithm;
class Program
{
    public static string binaryTextPath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\DataStructureAlgorithm\DatatStructureAlgorithm\Files\BinarySearch.txt";
    public static string numberTextPath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\DataStructureAlgorithm\DatatStructureAlgorithm\Files\Numbers.txt";
    public static void Main(string[] args)
    {

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n\nWelcome to the Algorithm Programs " + "\n\n");

            Console.WriteLine(" Select the option ");

            Console.WriteLine("1.BinarySearch\n" +
                              "2.InsertionSort\n"+
                              "3.BubbleSort\n" +
                              "4.Anagram\n"+
                              "5.UserInput\n"+
                              "6.PrimeNumberRange\n"+
                              "7.LinkedListGeneric\n"+
                              "8.OrderedList\n"+
                              "9.OrderedList\n" +
                              "10.Exit" + "\n");
        int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFile(binaryTextPath);
                    search.BinarySearchOperation("BinarySearch");
                    break;
                case 2:
                    int[] arr = { 2, 1, 3 };
                    InsertionSort insertion = new InsertionSort();
                    insertion.Sort(arr);
                    break;
                case 3:
                    int[] arr2 = { 5, 2, 1, 4, 3 };
                    BubbleSort bubble = new BubbleSort();
                    bubble.Sort(arr2);
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram("Heart", "Earth");
                    break;
                case 5:
                    UserInput userInput= new UserInput();
                    userInput.ReplaceString();
                    break;
                case 6:
                    Console.WriteLine("The prime numbers are : ");
                    PrimeNumberRange primeNumberRange = new PrimeNumberRange();
                    primeNumberRange.FindPrime();
                    break;
                case 7:
                    LinkedListGeneric<string> linkedListGeneric = new LinkedListGeneric<string>();
                    linkedListGeneric.Add("Add");
                    linkedListGeneric.Delete("Delete");
                    linkedListGeneric.Display();
                    break;
                case 8:
                    OrderedList orderedList = new OrderedList();
                    orderedList.ReadTextFile(numberTextPath);
                    break;
                case 9:
                    UnOrderedList unOrderedList = new UnOrderedList();
                    unOrderedList.ReadAllTextFile(numberTextPath);
                    break;
                case 10:
                    flag = false;
                    break;
            }
        }
    }
}

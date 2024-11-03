// See https://aka.ms/new-console-template for more information
using System.Collections;






/* Console.WriteLine("Hello, World!");
//Create a list object with generic type Player
List<Player> playerList = new List<Player>();
//Create player1 object from Player class 
Player player1 = new Player("Peter");
//Create player2 object from Player class
Player player2 = new Player("Paul");
//Create player3 object from Player class
Player player3 = new Player("Sly");

//add player objects to the players list
playerList.Add(player1);
playerList.Add(player2);
playerList.Add(player3);

//iterate through the players list and write each player object's username on the console
foreach (Player player in playerList)
{
    
    Console.WriteLine(player.Username);
} */

 //USE THE NEW GENERIC INTERFACE AND NEW CLASS
//Create a EvaluateGreater object
EvaluateGreater<int> eval = new EvaluateGreater<int>();
//Call GreaterThan Method with 2 values
eval.GreaterThan(3, 4); 

// CLASSWORK
//Implement a Class that uses interface IGeneric to check if 2 strings are equal

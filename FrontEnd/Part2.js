// SECTION 1

// 1. Given the data array, process the array returning another array containing only the name of each destination. 

// JS: 

function GetDestinationArray(data) {
  var destinations = [];

  for (var item in data) 
  {
      destinations.push(data[item].name);
  }

  return destinations; 	
}

// JQuery: 

function GetDestinationArray(data) {
   var destinations = [];

   $.each(data, function(index, item) {
      destinations.push(item.name);
   });
}

// 2. Given the same data array, process the array again this time returning only the destination objects where the holidayRanking > 4.

function IsHighRankingDestination(destination)
{
   return destination.holidayRanking > 4;
}

function GetHighRankingDestinations()
{
   return data.filter(IsHighRankingDestination);
}

// 3.Extend your solution to problem 2 to return an array of holiday rankings where holidayRanking > 4 then sum all the holiday rankings

function add(sum, item) 
{
    return sum + item['holidayRanking'];
}

function GetSumOfHighRankingDestinationRankings()
{
    var highRankingDestinations = GetHighRankingDestinations();
    return highRankingDestinations.reduce(add, 0); 
}

// SECTION 2

// 1. Why will the function call return true?
//
// The function will return true as javascript is a weakly typed language and thus does not enforces correct typing.

// 2. How could one change this function so that data types are checked as well as values?

// Using the typeof operator to determine the type of each variable 

// e.g: 

function compareIt(num1, num2)
{
    return (typeof (num1) == typeof (num2)) && (num1 == num2);
}

// You could also consider using a tool such as TypeScript to write javascript in a similar manner to a strongly typed language.

// SECTION 3

// 1. Why will the function be parsed correctly?

// Javascript does not enforce unique variable names. Thus when a new variable is declared with the same name as an existing variable, the new variable will overwrite the existing variable.

// 2. How could you introduce a stricter syntax to variable/function declaration and avoid this behaviour?

// You could add a "use strict" statement to the start of the file or function to instruct the browser to use Strict mode. Once enabled, strict mode will enforce that variable names need
// to be unique within the scope defined by where the "use strict" statement. e.g. Entire files if declared at the top of the file. 

function legal(x) {
    "use strict";
    console.log(x);
    var x;
}
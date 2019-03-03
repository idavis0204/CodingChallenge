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
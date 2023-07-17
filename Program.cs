// Multiples Of 10

// 1. Show me numbers which are multiples of 10. going up to 1000.
// 2. Store all these numbers into an array
// 3. Display this array.
// 4. Now, from this array, create 10 more arrays.
// 5. 1st array will have numbers from 10 to 100
// 6. 2nd array will have numbers from 110 to 200
// 7. From here you will carry out steps 5 & 6, for the remaining numbers up to 1000. 

// The array size is 100 because 1000/10, is 100.

// Spacing Between Arrays - Array 1

int[] bigArray = new int[100];

var startOfTheBigArray = 0;
var endOfTheBigArray = 100;

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
    var indexAmendment = i + 1;

    // At the present I am getting 1,2,3,4.
    // I need to make these values 10,20,30,40. 
    // I am not going to write a line which will multiply each number by 10. 

    var indexHolder = indexAmendment * 10; 
    // Console.WriteLine("This is the output to show multiples of 10, the output is " + indexHolder);

    bigArray[i] = indexHolder;
}

    var explanation = "This is the main big array that contains all the numbers, from 10 to 1000";
    Console.WriteLine(explanation);

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
    Console.WriteLine(bigArray[i]);

}

// Spacing Between Arrays - Array 2

int[] smallsmallArray810to900to100 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i < 10){
      smallsmallArray810to900to100[i] = bigArray[i];
  }
  else{
    // ** Empty Else Statement On Purpose **
  } 

}

var explanation2 = "This array shows the numbers between 10 to 100";
Console.WriteLine(explanation2);

for (int i = 0; i < 10; i++){
    Console.WriteLine(smallsmallArray810to900to100[i]);
}

// Spacing Between Arrays - Array 3

Console.WriteLine("Now working on getting the array from 110 to 200");
int[] smallsmallArray910to10000to200 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 9 && i < 20){
    Console.WriteLine(bigArray[i]); 
    smallsmallArray910to10000to200[i - 10] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation3 = "This array shows the numbers between 110 to 200";
Console.WriteLine(explanation3);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallsmallArray910to10000to200[i]);
}

// Spacing Between Arrays - Array 4

Console.WriteLine("Now working on getting the array from 210 to 300");
int[] smallArray210to300 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 19 && i < 30){
    Console.WriteLine(bigArray[i]); 
    smallArray210to300[i - 20] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation4 = "This array shows the numbers between 210 to 300";
Console.WriteLine(explanation4);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray210to300[i]);
}

// Spacing Between Arrays - Array 5

Console.WriteLine("Now working on getting the array from 310 to 400");
int[] smallArray310to400 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 29 && i < 40){
    Console.WriteLine(bigArray[i]); 
    smallArray310to400[i - 30] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation5 = "This array shows the numbers between 310 to 400";
Console.WriteLine(explanation5);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray310to400[i]);
}

// Spacing Between Arrays - Array 6

Console.WriteLine("Now working on getting the array from 410 to 500");
int[] smallArray410to500 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 39 && i < 50){
    Console.WriteLine(bigArray[i]); 
    smallArray410to500[i - 40] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation6 = "This array shows the numbers between 410 to 500";
Console.WriteLine(explanation6);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray410to500[i]);
}

// Spacing Between Arrays - Array 7

Console.WriteLine("Now working on getting the array from 510 to 600");
int[] smallArray510to600 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 49 && i < 60){
    Console.WriteLine(bigArray[i]); 
    smallArray510to600[i - 50] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation7 = "This array shows the numbers between 510 to 600";
Console.WriteLine(explanation7);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray510to600[i]);
}

// Spacing Between Arrays - Array 8

Console.WriteLine("Now working on getting the array from 610 to 700");
int[] smallArray610to700 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 59 && i < 70){
    Console.WriteLine(bigArray[i]); 
    smallArray610to700[i - 60] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation8 = "This array shows the numbers between 610 to 700";
Console.WriteLine(explanation8);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray610to700[i]);
}

// Spacing Between Arrays - Array 9

Console.WriteLine("Now working on getting the array from 710 to 800");
int[] smallArray710to800 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 69 && i < 80){
    Console.WriteLine(bigArray[i]); 
    smallArray710to800[i - 70] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation9 = "This array shows the numbers between 710 to 800";
Console.WriteLine(explanation9);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray710to800[i]);
}

// Spacing Between Arrays - Array 10

Console.WriteLine("Now working on getting the array from 810 to 900");
int[] smallArray810to900 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 79 && i < 90){
    Console.WriteLine(bigArray[i]); 
    smallArray810to900[i - 80] = bigArray[i];
  }
  else{
        // ** Empty Else Statement On Purpose **
  }

}

var explanation10 = "This array shows the numbers between 810 to 900";
Console.WriteLine(explanation10);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray810to900[i]);
}

// Spacing Between Arrays - Array 11

Console.WriteLine("Now working on getting the array from 910 to 1000");
int[] smallArray910to1000 = new int[10];

for (int i = startOfTheBigArray; i < endOfTheBigArray; i++){
  if (i > 89 && i < 100){
    Console.WriteLine(bigArray[i]); 
    smallArray910to1000[i - 90] = bigArray[i];
  }
  else{
    // ** Empty Else Statement On Purpose **
  }

}

var explanation11 = "This array shows the numbers between 910 to 1000";
Console.WriteLine(explanation11);
for (int i = 0; i < 10; i++){
    Console.WriteLine(smallArray910to1000[i]);
}
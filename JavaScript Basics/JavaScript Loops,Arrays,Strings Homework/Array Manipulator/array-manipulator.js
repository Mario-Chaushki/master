var inputArray = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10 }, [10, 20, 30, 40]];

//filter nums
var numbersArray = [];

for (var i = 0; i < inputArray.length; i++) {
    if (!isNaN(inputArray[i])) {
        numbersArray.push(inputArray[i]);
    }
};

//Find min number
var minNumber = numbersArray[0];

for (var i = 1; i < numbersArray.length; i++) {
    if (minNumber > numbersArray[i]) {
        minNumber = numbersArray[i];
    }  
};

//Find max number
var maxNumber = numbersArray[0];

for (var i = 1; i < numbersArray.length; i++) {
    if (maxNumber < numbersArray[i]) {
        maxNumber = numbersArray[i];
    }
};

//Find most common number
//Unknown function/method
var mostCommonNumber = undefined;

//Sort numbers
numbersArray.sort(function (a, b) { return b - a });


console.log('Min number: ' + minNumber);
console.log('Max number: ' + maxNumber);
console.log('Most frequent number: ' + mostCommonNumber);
console.log(numbersArray);
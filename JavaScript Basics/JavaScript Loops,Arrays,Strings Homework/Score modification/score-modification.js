//Tasks:
//filter out all valid exam scores (between 0 and 400)
//scale them downwards by removing 20% out of each score
//print out the changed scores sorted in ascending order

var input = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];

//filter valid numbers
var validScores = input.filter(
    function (value) {
        return (value <= 400 && value >= 0);
    }
);

//foreach number in validScore divide by 20%
var dividedScores = new Array();
for (var i = 0; i < validScores.length; i++) {
    dividedScores[i] = (validScores[i] * 80) / 100;
};

//sort in ascending
dividedScores.sort(function (a, b) { return a - b });
console.log(dividedScores);
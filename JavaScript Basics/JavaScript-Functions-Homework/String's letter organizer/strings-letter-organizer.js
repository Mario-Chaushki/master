function sortLetters(string, boolean) {
    var letters = string.split('');

    if (boolean) {
        letters.sort(function (a, b) {
            
            //compare two values
            if (a.toLowerCase() < b.toLowerCase()) return -1;
            if (a.toLowerCase() > b.toLowerCase()) return 1;
            return 0;

        })

    } 
    else { 
        letters.sort(function (a, b) {
            
            //compare two values
            if (a.toLowerCase() > b.toLowerCase()) return -1;
            if (a.toLowerCase() < b.toLowerCase()) return 1;
            return 0;

        })
    }

    return letters.join('');
}

console.log(sortLetters('HelloWorld', true));
console.log('--------------------------------');
console.log(sortLetters('HelloWorld', false));

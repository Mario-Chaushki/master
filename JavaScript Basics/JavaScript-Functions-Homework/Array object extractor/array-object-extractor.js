
function extractObjects(array) {
    var objects = [];
    
    array.forEach(function (arg) {
        if (typeof arg === 'object') {
            objects.push(arg);
        }
        
    })

    return objects;
}

var input = [
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1, 2, 3],
    "Gosho",
    { name : 'Penka', height: 1.65 }
];

var extracted = extractObjects(input);

console.log(extracted);
function calc(array) {
    var silver = 0;
    var gold = 0;
    var diamonds = 0;
    
    var regex = /\s*mine\s*.*?\s*-\s*(\w+)\s*:\s*(\d+)/;
    array.forEach(function (line) {
        var isValid = regex.test(line);
        if (isValid) {
            if (regex.exec(line)[1] === 'silver') {
                silver += Number(regex.exec(line)[2]);
            } else if (regex.exec(line)[1] === 'gold') {
                gold += Number(regex.exec(line)[2]);
            } else if (regex.exec(line)[1] === 'diamonds') {
                diamonds += Number(regex.exec(line)[2]);
            }
        }
    });
    console.log('*Silver: ' + silver);
    console.log('*Gold: ' + gold);
    console.log('*Diamonds: ' + diamonds);
}
function countCoinsInBag (array) {
    var regex = /coin/i;
    var coins = 0;

    array.forEach(function (str) {
        var type = str.split(/\s/)[0];
        var num = str.split(/\s/)[1];

        if ((regex.test(type) && !isNaN(num)) && ((num % 1 === 0) && num > 0)) {
            coins += Number(num);
        }
    });
    //get values for gold, silver and bronze
    var gold = Math.round(Math.floor(coins / 100));
    var silver = Math.floor((coins % 100) / 10);
    var bronze = Math.floor(coins % 10);

    console.log('gold : ' + gold);
    console.log('silver : ' + silver);
    console.log('bronze : ' + bronze);
}

//var test = ['coin 1', 'coin 2', 'coin 5', 'coin 10', 'coin 20', 'coin 50', 'coin 100', 'coin 200', 'coin 500', 'cigars 1'];
//countCoinsInBag(test);
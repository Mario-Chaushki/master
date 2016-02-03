function printArgsInfo() {
    for (var i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + ' ' + '(' + typeof arguments[i] + ')');
    };
    
    
}

//test
printArgsInfo.call();
console.log();
printArgsInfo.call(this, 2, 3, 2.5, -110.5564, false);
console.log();
printArgsInfo.apply();
console.log();
printArgsInfo.apply(this, [2, 3, 2.5, -110.5564, false]);


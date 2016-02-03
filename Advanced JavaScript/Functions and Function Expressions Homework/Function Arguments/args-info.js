function printArgsInfo() {
    for (var i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + ' ' + '(' + typeof arguments[i] + ')');
    };
    
    
}

//test
printArgsInfo(2, 3, 2.5, -110.5564, false);
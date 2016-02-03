function solve(array) {
    var bannedUsernames = array[array.length - 1].split(' ');
    
    array.forEach(function (string) {
        
        var regex = /#[a-zA-Z][\w-]+/g;
        
        
        var match = regex.exec(string);
        if (match !== null) {
            string.replace(match[0], ('<a href="="/users/profile/show/RoYaL">' + match[0] + '</a>'));
            console.log(string);
        }
    })

    
}

String.prototype.repeat = function (n) {
    n = n || 1;
    return Array(n + 1).join(this);
}

function inArray(needle, haystack) {
    var length = haystack.length;
    for (var i = 0; i < length; i++) {
        if (haystack[i] == needle)
            return true;
    }
    return false;
}

//test
var test = ['#RoYaL: I\'m not sure what you mean,',
    'but I am confident that I \'ve written',
    'everything correctly.Ask # iordan_93',
    'and # pesho if you don\'t believe me', 
    '< code >',
    '# trying to print stuff',
    'print("yoo")',
    '</code>',
    'pesho gosho'
];

solve(test);
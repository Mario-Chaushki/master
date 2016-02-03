function fleeRacing(array) {
    var numberOfJumps = Number(array[0]);
    var trackLength = Number(array[1]);
    var fleeCount = 0;
    var flees = [];
    var tribunes = new Array(trackLength + 1).join('#');
    
    for (var i = 2; i < array.length; i++) {
        var flee = array[i];
        var fleeName = flee.split(', ')[0];
        var fleeJumpingDistance = Number(flee.split(', ')[1]);
        
        flees.push({
            initial: fleeName.substr(0, 1).toUpperCase(),
            name: fleeName,
            jumpingDistance: Number(fleeJumpingDistance),
            index: 0,
            trackIndex: fleeCount
        });
    };
    
    var fleeTrack = Array.apply(null, new Array(trackLength)).map(function () { return '.'; });
    fleeTrack[0] = fleeName.substr(0, 1).toUpperCase();
    track.push(fleeTrack);
    ++fleeCount;
    
    for (var i = 0; i < fleeJumpingDistance; i++) {
        var hasFinished = false;
        flees.every(function (flee) {
            if (flee.index + flee.jumpingDistance >= trackLength - 1) {
                hasFinished = flee;
                fleeTrack[flee.jumpingDistance][flee.index] = '.';
                track[flee.trackIndex][track[flee.trackIndex].length - 1] = flee.initial;
                return false;
            } else {
                track[flee.trackIndex][flee.index] = '.';
                track[flee.trackIndex][flee.index + flee.jumpDistance] = flee.initial;
                flee.index += flee.jumpDistance;
                return true;
            }
        });

        if (hasFinished) {
            winner
        }
        
    };
    

    //output
    //crowd
    console.log(tribunes);
    console.log(tribunes);
    //race track
    
    //crowd
    console.log(tribunes);
    console.log(tribunes);
}

var test = [10, 19, 'angel, 9', 'Boris, 10', 'Georgi, 3', 'Dimitar, 7'];
fleeRacing(test);
function studentListToJSON(array) {
//input = name (name)/s{1}- exam : result(0 to 400)
//if exam >= 2 every exam after the first is a makeup exam / take only the highest result
//print a JSON string sorted in exam appearance
//sort students by result in descending then by number of makeup exams in ascending
//if there are several students with the same result sort them by number of makeup exams in descending
//then by name (string.localeCompare(string))
//trim at output
    function studentObject(name , result, makeUpExams) {
        this.name = name;
        this.result = result;
        this.makeUpExams = makeUpExams;
    };

    var examsArray = [];

    array.forEach(function (line) {
        var lineArgs = line.split(/[-:]/i);
        
        var student = lineArgs[0].trim();
        
        var result = lineArgs[1].trim();
        
        

        if (result >= 0 && result <= 400) {
            //data validated
            examsArray.push(new studentObject(student, exam, result));

            //every object should contain student name, highest result of any exam and 
            //number of makeup exams (all exams went to - 1 if more than 1 exam visited)

        }
    });
    console.log(JSON.stringify(examsArray));
}

var sampleInput = ['Peter Jackson - Java : 350', 
                   'Jane - JavaScript : 200', 'Jane     -    JavaScript :     400', 
                   'Simon Cowell - PHP : 100', 'Simon Cowell-PHP: 500', 
                   'Simon Cowell - PHP : 200'];

studentListToJSON(sampleInput);
//Broken
//TODO:
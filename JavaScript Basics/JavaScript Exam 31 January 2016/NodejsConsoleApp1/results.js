function solve(array) {
    var students = [];

    for (var i = 0; i < array.length - 1; i++) {
        var currentLine = array[i].trim();
        var lineArgs = currentLine.split(/\s+/);
        
        var studentName = lineArgs[0];
        var courseName = lineArgs[1];
        var examPoints = parseFloat(lineArgs[2]);
        var courseBonuses = parseFloat(lineArgs[3]);
        
        var found = false;
        for (var j = 0; j < students.length; j++) {
            if (students[j].name === studentName) {
                found = true;
                students[j].points += examPoints;
                break;
            }
        }
        if (!found) {
            students.push({ name: studentName, course: courseName, points: examPoints, bonuses: courseBonuses });
        }
    };
    var courseForAverage = array[array.length - 1];
    
    var combinedCoursePoints = 0;
    students.forEach(function (student) {
        
        var failed = false;
        //get course points
        
        var studentPoints = (student.points * 20) / 100;
        
        if (student.course === courseForAverage) {
            combinedCoursePoints += studentPoints;
        }

        if (student.points < 100) {
            failed = true;
        } else {
            failed = false;
            var studentCoursePoints = studentPoints + student.bonuses;
        }
        
        //calc student grade
        var studentGrade;
        studentGrade = ((studentCoursePoints / 80) * 4) + 2;
        if (studentGrade >= 6) {
            studentGrade = 6.00;
        }
        
        //print
        if (failed) {
            console.log(student.name + ' failed at ' + '\"' + student.course + '\"');
        } else {
            console.log(student.name + ': Exam - "' + student.course + '"; Points - ' + parseFloat(studentCoursePoints.toFixed(2)) + '; Grade - ' + studentGrade.toFixed(2));
        }
    });
    //remove trailing zeros after the first
    //get and print average for course
    console.log('\"' + courseForAverage + '\"' + ' average points -> ' + combinedCoursePoints.toFixed(2).toString().replace(/0+$/g, ""));
}

var test = ['Student1 C#-Advanced 390 2', 'C#-Advanced'];

solve(test);
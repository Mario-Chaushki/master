function findYoungestPerson(array) {
    var sortedArray = array.sort(function (a, b) {
        return b.age - a.age;
    });
    var youngestPerson;
    sortedArray.forEach(function (person) {
        if (person.hasSmartphone) {
            youngestPerson = person;
        }
    })
    console.log('The youngest person is ' + youngestPerson.firstname + ' ' + youngestPerson.lastname);
}


var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false }, 
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }];

findYoungestPerson(people);
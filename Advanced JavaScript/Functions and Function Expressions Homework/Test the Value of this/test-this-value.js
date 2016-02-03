function testContext() {
    console.log(this);
}


//global
testContext();
//prints window props

//nested
function testFunc() {
    testContext();
}
testFunc();
//prints window props


//as object
var testObject = new testContext();
console.log(testObject);
var a1 = b + c; // This is a trailing comment that can be very very long

function doSomething(param1, param2, param3, param4, param5) {
 //...
}



function f() {
    iiiiiii = 1;         // Noncompliant; i is global

    for (jjjj = 0; j < array.length; jjjj++) {  // Noncompliant; j is global now too
        // ...
    }
}


function say(a, b) {
    print(a + " " + b);
}

say("hello", "world", "!"); // Noncompliant; last argument is not used


for (; ;) {  // Noncompliant; end condition omitted
    // ...
}
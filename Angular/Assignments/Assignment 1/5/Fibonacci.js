function Fibonacci(No) {
    var i = 1, a = 1, b;
    while (i <= No) {
        console.log(i);
        b = i + a;
        i = a;
        a = b;
    }
}
Fibonacci(21);

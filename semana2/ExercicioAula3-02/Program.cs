int fib1 = 1, fib2 = 1, fib=0;
do{
    fib = fib1+fib2;
    fib1 = fib2;
    fib2 = fib;
    Console.WriteLine(fib1);
}while(fib<100);
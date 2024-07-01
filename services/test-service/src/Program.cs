// Run in an infinite loop
while (true)
{
    Console.WriteLine(Environment.GetEnvironmentVariable("MESSAGE") ?? "Hello, World!");

    Thread.Sleep(1000);
}
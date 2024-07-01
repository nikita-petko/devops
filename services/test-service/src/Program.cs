// Run in an infinite loop
while (true)
{
    Console.WriteLine(Environment.GetEnvironmentVariable("MESSAGE") ?? "Hello, World 1!");

    Thread.Sleep(1000);
}

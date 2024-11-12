﻿using System.Runtime.CompilerServices;

public static class WasiMainWrapper
{
    public static async Task<int> MainAsync(string[] args)
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Add("User-Agent", "dotnet WASI");
        var query="https://www.random.org/integers/?num=1&min=40&max=45&col=1&base=10&format=plain&rnd=new";
        var json = await client.GetStringAsync(query);
        Console.WriteLine(json);

        ExampleWorld.exports.ExampleWorld.Add(1, int.Parse(json));
        return 0;
    }

    public static int Main(string[] args)
    {
        return PollWasiEventLoopUntilResolved((Thread)null!, MainAsync(args));

        [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = "PollWasiEventLoopUntilResolved")]
        static extern T PollWasiEventLoopUntilResolved<T>(Thread t, Task<T> mainTask);
    }
}

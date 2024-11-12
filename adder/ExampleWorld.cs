using System.Runtime.InteropServices;

namespace ExampleWorld;

public partial class ExampleWorldImpl {
    
    [UnmanagedCallersOnly(EntryPoint = "add")]
    public static unsafe int wasmExportAdd(int p0, int p1) {
        return p0 +p1;
    }
}

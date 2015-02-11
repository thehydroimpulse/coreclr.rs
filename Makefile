build: csharp/HelloWorld.cs target/
	cargo build
	dmcs -nostdlib -r:/Users/daniel/cloned/coreclr/binaries/Product/amd64/debug/mscorlib.dll csharp/HelloWorld.cs
	~/cloned/coreclr/binaries/Product/amd64/debug/corerun -c /Users/daniel/cloned/coreclr/binaries/Product/amd64/debug csharp/HelloWorld.exe

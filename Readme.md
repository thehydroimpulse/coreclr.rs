# Coreclr.rs

Since Microsoft open-sourced the runtime that powers C#, and some folks have contributed to get it working (somewhat) on OS X, I wanted to try and integrate Rust with it. Why? I think Rust is extremely powerful at FFI. Without a garbage collector or any heavy runtime, you can effectively use Rust in other systems like Ruby and now C# (on all platforms). But that's not it. We can leverage Rust's abilities in safety to have some guarantees. The examples I've used, while small, don't use unsafe code and uses regular references to access objects like classes defined in C#.

# License

MIT

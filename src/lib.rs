#![feature(libc, no_std, lang_items, core, asm)]
#![no_std]

extern crate core;
extern crate libc;

#[lang = "stack_exhausted"] extern fn stack_exhausted() {}
#[lang = "eh_personality"] extern fn eh_personality() {}
#[lang = "panic_fmt"] fn panic_fmt() -> ! { loop {} }

#[cfg(not(test))]
#[lang="begin_unwind"]
extern fn begin_unwind() {}

use libc::c_int;

#[derive(Debug)]
pub struct Person {
    pub age: i32
}

#[no_mangle]
pub extern "C" fn from_rust(a: c_int) -> c_int {
    return a + 5;
}

#[no_mangle]
pub extern "C" fn set_age(person: &mut Person, age: i32) {
    person.age = age;
}

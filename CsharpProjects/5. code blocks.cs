// Control variable scope and logic using code blocks in C#

bool flag = true;

// Loại bỏ các dấu ngoặc nhọn
if (flag)
    Console.WriteLine(flag);

// trên cùng 1 dòng
if (flag) Console.WriteLine(flag);


// sử dụng bỏ ngoặc nhọn dễ đọc hơn
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
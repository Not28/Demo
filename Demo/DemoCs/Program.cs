// format code ctrl + k + d
double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "true" : "false");

decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c + d == 0.3M);

//?: => ternary operator

string fullName = null;
//int i = null;
//c# cũ
//Nullable<int> i = null;
//c# mới
bool? check = null;

//int length = fullName != null ? fullName.length : 0;
//int? length = fullName is not null ? fullName.Length : null;

//null-conditional operator
// ? tương tự != , fullName mà khác null thì trả về vế sau.
int? length = fullName?.Length;

// null-coalescing operator ??
// tương tự dấu ==, fullName bằng null thì trả về vế sau
int? chieudai = fullName?.Length ?? 0;
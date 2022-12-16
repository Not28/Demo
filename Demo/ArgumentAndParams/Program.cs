﻿using ArgumentAndParams;
//pure oop
//ArgumentClass argu = new ArgumentClass;

//dùng var
//var argu = new ArgumentClass();

//target-type
ArgumentClass argu = new();

//named argument
argu.Display(4,5,6);
argu.Display(a: 4, b: 5, c: 6);
argu.Display(a: 4, b: 5,  6);
argu.Display(a: 4,  5,  6);
argu.Display(b: 4, a: 5, c: 6);
argu.Display(c: 4, a: 5, b: 6);
//argu.Display(c: 4,  5,  6); => error nếu không phải là a(hay Argument đầu thì phải viết ra hết )

//============================

argu.Show();
argu.Show(10);
argu.Show(10,5);
argu.Show(10, 5,4);
argu.Show(b: 10, c: 5); //=> giải quyết dc vấn đề ở trên

//============================

argu.sumParam(10);
argu.sumParam(1,2,3,4,6);

int[] mang = {1,2,3,4,6};
argu.sumParam(mang);


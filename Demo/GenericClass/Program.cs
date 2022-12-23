using GenericClass;

ClassOne<int> one = new ClassOne<int>();
one.Field = 10;
one.Show();

ClassTwo<string , int> two= new ClassTwo<string , int>();
two.Field1 = "not";
two.Field2 = 10;
two.Show();

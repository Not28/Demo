namespace ListAndLinQ;
internal class Student
{
    public int RollNumber { get; set; }
    public string FullName { get; set; }
    public string Section { get; set; }
    public int    HosterNumber{ get; set; }

    public override string ToString()
    {
        return $"{{{nameof(RollNumber)}={RollNumber}, {nameof(FullName)}={FullName}, {nameof(Section)}={Section}, {nameof(HosterNumber)}={HosterNumber.ToString()}}}";
    }
}

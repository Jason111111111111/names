using System;

public class People
{
    public string fName;
    public string lName;
    public string gradYear;
    public string gender;
    public People(string fn, string ln, string gy, string g)
    {
        fName = fn;
        lName = ln;
        gradYear = gy;
        gender = g;
    }
}

public class Freshman : People
{

    public Freshman(string fn, string ln, string gy, string g) :base(fn, ln, gy, g)
    {
        fName = fn;
        lName = ln;
        gradYear = gy;
        gender = g;
    }
}

public class Sophmore : People
{

    public Sophmore(string fn, string ln, string gy, string g) : base(fn, ln, gy, g)
    {
        fName = fn;
        lName = ln;
        gradYear = gy;
        gender = g;
    }
}

public class Junior : People
{

    public Junior(string fn, string ln, string gy, string g) : base(fn, ln, gy, g)
    {
        fName = fn;
        lName = ln;
        gradYear = gy;
        gender = g;
    }
}

public class Senior : People
{

    public Senior(string fn, string ln, string gy, string g) : base(fn, ln, gy, g)
    {
        fName = fn;
        lName = ln;
        gradYear = gy;
        gender= g;
    }
}

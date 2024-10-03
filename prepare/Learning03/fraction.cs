using System.Diagnostics;

public class fraction{
    private int _top;
    private int _bottom;

public fraction()
{
    _top = 1;
    _bottom = 1;
}
public fraction(int wholenumber)
{
    _top = wholenumber;
    _bottom = 1;
}
public fraction(int top, int bottom)
{
    _top = top;
    _bottom = bottom;
}
public string getfractionstring()
{
    string text = $"{_top}/{_bottom}";
    return text;
}
public double getdecimalstring()
{
    return (double)_top/(double)_bottom; 
}
}
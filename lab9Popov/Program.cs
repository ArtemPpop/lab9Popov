try
{
    Console.Write("Введите веществ. часть:");
    double realPart = double.Parse(Console.ReadLine()!);
    Console.Write("Введите мнимую часть:");
    double imaginaryPart = double.Parse(Console.ReadLine()!);

    ComplexNumber complexNumber = new ComplexNumber(realPart, imaginaryPart);
    Console.WriteLine($"в градусах: {complexNumber.Degrees()}");

    Console.Write("Введите число для умножения:");
    double scalar = double.Parse(Console.ReadLine()!);
    complexNumber.MultiByScal(scalar);

    Console.WriteLine($"Результат умножения числа на число: {complexNumber}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    
class ComplexNumber
{
    private double realPart;
    private double imaginaryPart;

    public ComplexNumber(double realPart, double imaginaryPart)
    {
        this.realPart = realPart;
        this.imaginaryPart = imaginaryPart;
    }

    public double Radians()
    {
        return Math.Atan2(imaginaryPart, realPart);
    }

    public double Degrees()
    {
        return Radians() * (180.0 / Math.PI);
    }

    public void MultiByScal(double scalar)
    {
        this.realPart *= scalar;
        this.imaginaryPart *= scalar;
    }
    public override string ToString()
    {
        return $"{this.realPart} + {this.imaginaryPart}i";
    }

}




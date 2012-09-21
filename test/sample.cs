using System;
using System.Text;

public partial class Car : IVehicle
{
    public string Name { get; set; }

    public string OtherName
    {
        get;
        set;
    }
    
    private Engine _engine;
    public Engine Engine
    {
        get { return _engine; }
        set { _engine = value; }
    }

    public Car() : base()
    {
    }

    public void Run()
    {
        var status = Engine.Start(x => x.Bob == true);
    }
}
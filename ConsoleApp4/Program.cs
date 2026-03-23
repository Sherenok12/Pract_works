namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            var sensor = new TempSensor();

            var scr = new Screen();
            var ac = new AC();
            var safe = new SafeSys();

            scr.Sub(sensor);
            ac.Sub(sensor);
            safe.Sub(sensor);

            sensor.SetTemp(10);
            sensor.SetTemp(20);
            sensor.SetTemp(30);
            sensor.SetTemp(45);
        }
    }
}

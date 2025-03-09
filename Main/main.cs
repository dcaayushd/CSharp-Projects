namespace CodePlusCircle
{
    class AlertDevice{
        //    public  void AlertPhone(string msg, int n)
           public static void AlertPhone(string msg, int n)
        {
            Console.WriteLine($"Alerting {n} for {msg} on Phone...");
        }
    }

    class MainProgram
    {
        // static void AlertPhone(string msg, int n)
        // {
        //     Console.WriteLine($"Alerting {n} for {msg} on Phone...");
        // }
        static void AlertDesktop(string msg, int n)
        {
            Console.WriteLine($"Alerting {n} for {msg} on Desktop...");
        }
        static void AlertTablet(string msg, int n)
        {
            Console.WriteLine($"Alerting {n} for {msg} on Tablet...");
        }

        delegate void Alert(string msg, int num);

        static void Main(string[] ___)
        {
            // //? If it is in the same class then use below 
            // //? AlertPhone("emergency", 911);
            // //? else use this method
            // AlertDevice.AlertPhone("emergency", 911);
            // AlertDesktop("emergency", 911);
            // AlertTablet("emergency", 911);

            // //! Else we can call like this
            //If it is in the same class then use below 
            // Alert alert= AlertPhone;
            
            //else use this method
            Alert alert = AlertDevice.AlertPhone;
            // if static keyword is removed form AlertDevice than use 
            // Alert alert= new AlertDevice().AlertPhone;
            alert += AlertDesktop;
            alert += AlertTablet;

            #pragma warning disable
            // Removes alert from tablet remove this to add alert on tablet
            alert -= AlertTablet;

            //? //Use any one from below to make a call to alert
            // alert.Invoke("emergency", 911);
            alert("emergency", 911);
        }
    }
}
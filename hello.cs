namespace Name
{
    class helloWorld
    {
        
        static void Main(string[] args)
        {
            helloWorld program = new helloWorld();
            program.helloWorldPrint();
            helloWorld greet = new GreetBlack();
            greet.GreetBlack();
        }

        public void helloWorldPrint()
        { 
            Console.WriteLine("hello everyone"); 
        }

        public void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        public void GreetBlack()
        {
            Console.WriteLine("hello black");
        }       
    }    
}

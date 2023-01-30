using System;
using System.Timers;
using System.Threading;

class Program {
	//current world population
	public static long WorldPopulation = 8000000000;
	//how many babies are born every tick
	public static int BornPerTick;
	//world type (0 = random 1=default 2=custom)
	public static int WorldType;
	//carbon dioxide level in atmosphere (0-1 1 is death and it is customizable when it starts becoming lethal)
	public static int CarbonDioxideLevel;
	public static int CarbonDioxideLethal;
	public static int CarbonDioxideIncreasing;
	//political leaders (0 = dont care about climate change 1 = they do)
	public static int PoliticalLeaderCare;
	//asteroid stuff
	public static int AsteroidImpacting;
	public static int AsteroidChance;
	public static int AsteroidSpeed;
	public static int AsteroidSize;
	public static int AsteroidMissChance;
	// omg super scary super volcano
	public static int SuperVolcanoErupting;
	public static int SuperVolcanoChain;
	public static int SuperVolcanoSize;
	public static int SuperVolcanoChance;
	// hungry black hole
	public static int BlackHoleNear;
	public static int BlackHoleChance;
	public static int BlackHoleSucking; //woah there black hole
	private static System.Timers.Timer aTimer;
   
   public static void Main()
   {
      SetTimer();

      Console.WriteLine("Press ENTER to start game.");
      Console.ReadLine();
      Game();
   }

   private static void SetTimer()
   {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
		WorldPopulation = WorldPopulation + 10000000;
        Console.WriteLine(WorldPopulation);
    }
	public static void Game() {
		Console.Clear();
		Thread.Sleep(1500);
		Console.WriteLine("Press ENTER to begin world setup");
		Console.ReadLine();
	}
}
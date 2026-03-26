namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            var player = new Player(100);

            var ui = new UIHealthBar();
            var sound = new SoundSystem();
            var achievements = new AchievementSystem();
            var logger = new GameLogger();

            ui.Subscribe(player);
            sound.Subscribe(player);
            achievements.Subscribe(player);
            logger.Subscribe(player);

            player.TakeDamage(20);
            player.TakeDamage(40);
            player.TakeDamage(50);
        }
    }
}


namespace ConsoleGame.logic
{
    class Health
    {
        public int Status { get; private set; }

        public Health (int healthStatus)
        {
            Status = healthStatus;
        }

        public void AddHealth(int value)
        {
            if (value > 0)
            {
                Status += value;
            }
        }

    }
}


namespace School
{
    internal class Time
    {
        public DateTime? StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }

        public void Start()
        {
            StartAt = DateTime.Now;
        }

        public void Stop()
        {
            EndAt = DateTime.Now;
        }

        public void Reset()
        {
            StartAt = null;
            EndAt = null;
        }

        public void Restart()
        {
            StartAt = DateTime.Now;
            EndAt = null;
        }
    }
}



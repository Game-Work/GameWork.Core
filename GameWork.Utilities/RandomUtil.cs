using System;

namespace GameWork.Utilities
{
    public static class RandomUtil
    {
        private static readonly Random Random = new Random();

        public static int Next()
        {
            return Random.Next();
        }
    }
}
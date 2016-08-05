using System;

namespace GameWork.Utilities
{
    public static class RandUtil
    {
        private static Random _random = new Random();

        public static int Next()
        {
            return _random.Next();
        }
    }
}
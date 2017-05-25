using System;

namespace GameWork.Core.Utilities
{
    /// <summary>
    /// Static convenience class that wraps up <xref href="System.Random">System.Random</xref>'s functionality.
    /// Set the <seealso cref="Seed"/> for deterministic Random behaviour.
    /// </summary>
    public static class RandomUtil
    {
        private static int _seed;

        /// <summary>
        /// Seed value used to insure deterministic random values
        /// </summary>
        public static int Seed
        {
            get => _seed;
            set
            {
                _seed = value;
                Random = new Random(_seed);
            }
            
        }

        private static Random Random = new Random();

        /// <summary>
        /// <xref href="System.Random.Next">System.Random.Next</xref>
        /// </summary>
        /// <returns>Random integer between 0 (inclusive) and <xref href="int.MaxInt">MaxInt</xref> (exclusive)</returns>
        public static int Next()
        {
            return Random.Next();
        }

        /// <summary>
        /// Random from zero to exclusiveMax.
        /// </summary>
        /// <param name="exclusiveMax"></param>
        /// <returns>Random integer between 0 (inclusive) and exclusiveMax (exclusive)</returns>
        public static int Next(int exclusiveMax)
		{
			return Random.Next(0, exclusiveMax);
		}

        /// <summary>
        /// Random integer from inclusiveMin to exclusiveMax
        /// </summary>
        /// <param name="inclusiveMin"></param>
        /// <param name="exclusiveMax"></param>
        /// <returns>Random integer berween inclusiveMin (inclusive) and exclusiveMax (exclusive)</returns>
        public static int Next(int inclusiveMin, int exclusiveMax)
        {
			return Random.Next(inclusiveMin, exclusiveMax);
        }

        /// <summary>
        /// Random floating point number between 0.0 1.0
        /// </summary>
        /// <returns>Random floating point number between 0.0f (inclusive) 1.0f (exclusive)</returns>
		public static float NextFloat()
		{
			return (float)Random.NextDouble();
		}
    }
}
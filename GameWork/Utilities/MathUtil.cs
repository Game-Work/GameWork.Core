using System;

namespace GameWork.Utilities
{
	public static class MathUtil
	{
		public static float Lerp(float start, float end, float weight)
		{
			weight = weight.Clamp(0f, 1f);

			var difference = (end - start);
			var progress = difference * weight; 

			if(progress < 0)
			{
				progress = Abs(difference) + progress;
			}

			return progress;
		}

		public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
		{
			if (val.CompareTo(min) < 0) return min;
			else if(val.CompareTo(max) > 0) return max;
			else return val;
		}

		public static float Abs(float val)
		{
			if(val < 0)
			{
				val *= -1f;
			}

			return val;
		}
	}
}
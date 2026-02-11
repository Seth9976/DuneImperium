using System;
using Il2CppSystem;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x02000375 RID: 885
	public class FloatComparer
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x00013559 File Offset: 0x00011759
		public bool Equals(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000B5EF8 File Offset: 0x000B40F8
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000B5F10 File Offset: 0x000B4110
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x000B5F30 File Offset: 0x000B4130
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool flag = expected == actual;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num > num2) ? num : num2));
				flag2 = num3 <= error;
			}
			return flag2;
		}

		// Token: 0x04002AAC RID: 10924
		public const float kEpsilon = 1E-05f;
	}
}

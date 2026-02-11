using System;

namespace UnityEngine.Animations
{
	// Token: 0x02000049 RID: 73
	public static class DiscreteEvaluationAttributeUtilities
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public unsafe static int ConvertFloatToDiscreteInt(float f)
		{
			float* ptr = &f;
			int* ptr2 = (int*)ptr;
			return *ptr2;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00012D10 File Offset: 0x00010F10
		public unsafe static float ConvertDiscreteIntToFloat(int f)
		{
			int* ptr = &f;
			float* ptr2 = (float*)ptr;
			return *ptr2;
		}
	}
}

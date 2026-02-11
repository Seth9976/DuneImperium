using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Accessibility
{
	// Token: 0x02000002 RID: 2
	public static class VisionUtility
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002078 File Offset: 0x00000278
		public static float ComputePerceivedLuminance(Color color)
		{
			color = color.linear;
			return Mathf.LinearToGammaSpace(0.2126f * color.r + 0.7152f * color.g + 0.0722f * color.b);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020C0 File Offset: 0x000002C0
		public static void GetLuminanceValuesForPalette(Il2CppStructArray<Color> palette, ref Il2CppStructArray<float> outLuminanceValues)
		{
			Debug.Assert(palette != null && outLuminanceValues != null, "Passed in arrays can't be null.");
			Debug.Assert(palette.Length == outLuminanceValues.Length, "Passed in arrays need to be of the same length.");
			for (int i = 0; i < palette.Length; i++)
			{
				outLuminanceValues[i] = VisionUtility.ComputePerceivedLuminance(palette[i]);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public static int GetColorBlindSafePalette(Il2CppStructArray<Color> palette, float minimumLuminance, float maximumLuminance)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205D File Offset: 0x0000025D
		public static int GetColorBlindSafePalette(Il2CppStructArray<Color32> palette, float minimumLuminance, float maximumLuminance)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206A File Offset: 0x0000026A
		public unsafe static int GetColorBlindSafePaletteInternal(void* palette, int paletteLength, float minimumLuminance, float maximumLuminance, bool useColor32)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000003 RID: 3
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x02000004 RID: 4
		public sealed class <>c__DisplayClass6_0
		{
		}
	}
}

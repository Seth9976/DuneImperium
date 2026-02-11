using System;

namespace UnityEngine.Yoga
{
	// Token: 0x020002B9 RID: 697
	public static class YogaValueExtensions
	{
		// Token: 0x060033BA RID: 13242 RVA: 0x000D9BBC File Offset: 0x000D7DBC
		public static YogaValue Percent(float value)
		{
			return YogaValue.Percent(value);
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x000D9BD4 File Offset: 0x000D7DD4
		public static YogaValue Pt(float value)
		{
			return YogaValue.Point(value);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000D9BEC File Offset: 0x000D7DEC
		public static YogaValue Percent(int value)
		{
			return YogaValue.Percent((float)value);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000D9C08 File Offset: 0x000D7E08
		public static YogaValue Pt(int value)
		{
			return YogaValue.Point((float)value);
		}
	}
}

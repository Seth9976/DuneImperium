using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200030D RID: 781
	public class SystemClock
	{
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000B43C0 File Offset: 0x000B25C0
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00012407 File Offset: 0x00010607
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00012414 File Offset: 0x00010614
		public static long ToUnixTimeSeconds(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

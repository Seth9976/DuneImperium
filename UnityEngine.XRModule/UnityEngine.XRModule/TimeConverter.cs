using System;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200001D RID: 29
	public static class TimeConverter
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000066D0 File Offset: 0x000048D0
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002C76 File Offset: 0x00000E76
		public static long LocalDateTimeToUnixTimeMilliseconds(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002C83 File Offset: 0x00000E83
		public static DateTime UnixTimeMillisecondsToLocalDateTime(long unixTimeInMilliseconds)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

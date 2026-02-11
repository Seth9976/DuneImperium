using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000003 RID: 3
	public interface UGSAnalyticsInternalTools
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002093 File Offset: 0x00000293
		public static void SetPrivacyStatus(bool status)
		{
			AnalyticsCommon.ugsAnalyticsEnabled = status;
		}
	}
}

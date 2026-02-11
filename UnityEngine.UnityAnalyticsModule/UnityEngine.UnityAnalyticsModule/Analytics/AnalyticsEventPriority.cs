using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000C RID: 12
	public enum AnalyticsEventPriority
	{
		// Token: 0x04000087 RID: 135
		FlushQueueFlag = 1,
		// Token: 0x04000088 RID: 136
		CacheImmediatelyFlag,
		// Token: 0x04000089 RID: 137
		AllowInStopModeFlag = 4,
		// Token: 0x0400008A RID: 138
		SendImmediateFlag = 8,
		// Token: 0x0400008B RID: 139
		NoCachingFlag = 16,
		// Token: 0x0400008C RID: 140
		NoRetryFlag = 32,
		// Token: 0x0400008D RID: 141
		NormalPriorityEvent = 0,
		// Token: 0x0400008E RID: 142
		NormalPriorityEvent_WithCaching = 2,
		// Token: 0x0400008F RID: 143
		NormalPriorityEvent_NoRetryNoCaching = 48,
		// Token: 0x04000090 RID: 144
		HighPriorityEvent = 1,
		// Token: 0x04000091 RID: 145
		HighPriorityEvent_InStopMode = 5,
		// Token: 0x04000092 RID: 146
		HighestPriorityEvent = 9,
		// Token: 0x04000093 RID: 147
		HighestPriorityEvent_NoRetryNoCaching = 49
	}
}

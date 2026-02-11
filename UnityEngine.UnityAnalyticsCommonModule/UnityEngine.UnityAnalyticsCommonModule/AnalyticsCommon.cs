using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Analytics
{
	// Token: 0x02000002 RID: 2
	public static class AnalyticsCommon
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000207C File Offset: 0x0000027C
		public static bool ugsAnalyticsEnabledInternal
		{
			get
			{
				return AnalyticsCommon.get_ugsAnalyticsEnabledInternalDelegateField();
			}
			set
			{
				AnalyticsCommon.set_ugsAnalyticsEnabledInternalDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002089 File Offset: 0x00000289
		public static bool ugsAnalyticsEnabled
		{
			get
			{
				return AnalyticsCommon.ugsAnalyticsEnabledInternal;
			}
			set
			{
				AnalyticsCommon.ugsAnalyticsEnabledInternal = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly AnalyticsCommon.get_ugsAnalyticsEnabledInternalDelegate get_ugsAnalyticsEnabledInternalDelegateField = IL2CPP.ResolveICall<AnalyticsCommon.get_ugsAnalyticsEnabledInternalDelegate>("UnityEngine.Analytics.AnalyticsCommon::get_ugsAnalyticsEnabledInternal");

		// Token: 0x04000002 RID: 2
		private static readonly AnalyticsCommon.set_ugsAnalyticsEnabledInternalDelegate set_ugsAnalyticsEnabledInternalDelegateField = IL2CPP.ResolveICall<AnalyticsCommon.set_ugsAnalyticsEnabledInternalDelegate>("UnityEngine.Analytics.AnalyticsCommon::set_ugsAnalyticsEnabledInternal");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000008 RID: 8
		private delegate bool get_ugsAnalyticsEnabledInternalDelegate();

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000A RID: 10
		private delegate void set_ugsAnalyticsEnabledInternalDelegate(bool value);
	}
}

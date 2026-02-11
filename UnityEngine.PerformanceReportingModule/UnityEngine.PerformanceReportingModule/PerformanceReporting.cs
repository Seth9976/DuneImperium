using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Analytics
{
	// Token: 0x02000002 RID: 2
	public static class PerformanceReporting
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000208B File Offset: 0x0000028B
		public static bool enabled
		{
			get
			{
				return PerformanceReporting.get_enabledDelegateField();
			}
			set
			{
				PerformanceReporting.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		public static long graphicsInitializationFinishTime
		{
			get
			{
				return PerformanceReporting.get_graphicsInitializationFinishTimeDelegateField();
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly PerformanceReporting.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<PerformanceReporting.get_enabledDelegate>("UnityEngine.Analytics.PerformanceReporting::get_enabled");

		// Token: 0x04000002 RID: 2
		private static readonly PerformanceReporting.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<PerformanceReporting.set_enabledDelegate>("UnityEngine.Analytics.PerformanceReporting::set_enabled");

		// Token: 0x04000003 RID: 3
		private static readonly PerformanceReporting.get_graphicsInitializationFinishTimeDelegate get_graphicsInitializationFinishTimeDelegateField = IL2CPP.ResolveICall<PerformanceReporting.get_graphicsInitializationFinishTimeDelegate>("UnityEngine.Analytics.PerformanceReporting::get_graphicsInitializationFinishTime");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000006 RID: 6
		private delegate bool get_enabledDelegate();

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000008 RID: 8
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000A RID: 10
		private delegate long get_graphicsInitializationFinishTimeDelegate();
	}
}

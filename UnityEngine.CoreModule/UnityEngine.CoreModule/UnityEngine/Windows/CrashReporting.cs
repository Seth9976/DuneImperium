using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Windows
{
	// Token: 0x02000315 RID: 789
	public static class CrashReporting
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000B47D4 File Offset: 0x000B29D4
		public static string crashReportFolder
		{
			get
			{
				IntPtr intPtr = CrashReporting.get_crashReportFolderDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x04002978 RID: 10616
		private static readonly CrashReporting.get_crashReportFolderDelegate get_crashReportFolderDelegateField = IL2CPP.ResolveICall<CrashReporting.get_crashReportFolderDelegate>("UnityEngine.Windows.CrashReporting::get_crashReportFolder");

		// Token: 0x02000B75 RID: 2933
		// (Invoke) Token: 0x06003FDF RID: 16351
		private delegate IntPtr get_crashReportFolderDelegate();
	}
}

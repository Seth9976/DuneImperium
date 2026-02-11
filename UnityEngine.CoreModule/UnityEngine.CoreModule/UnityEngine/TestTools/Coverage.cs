using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TestTools
{
	// Token: 0x02000363 RID: 867
	public static class Coverage
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00012DB7 File Offset: 0x00010FB7
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x00012DC3 File Offset: 0x00010FC3
		public static bool enabled
		{
			get
			{
				return Coverage.get_enabledDelegateField();
			}
			set
			{
				Coverage.set_enabledDelegateField(value);
			}
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00012DD0 File Offset: 0x00010FD0
		public static void ResetFor_Internal(MethodBase method)
		{
			Coverage.ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000B5A9C File Offset: 0x000B3C9C
		public static void ResetFor(MethodBase method)
		{
			bool flag = method == null;
			if (flag)
			{
				throw new ArgumentNullException("method");
			}
			Coverage.ResetFor_Internal(method);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00012DE2 File Offset: 0x00010FE2
		public static void ResetAll()
		{
			Coverage.ResetAllDelegateField();
		}

		// Token: 0x04002A5D RID: 10845
		private static readonly Coverage.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Coverage.get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");

		// Token: 0x04002A5E RID: 10846
		private static readonly Coverage.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Coverage.set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");

		// Token: 0x04002A5F RID: 10847
		private static readonly Coverage.ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<Coverage.ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");

		// Token: 0x04002A60 RID: 10848
		private static readonly Coverage.ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<Coverage.ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

		// Token: 0x02000BA4 RID: 2980
		// (Invoke) Token: 0x06004039 RID: 16441
		private delegate bool get_enabledDelegate();

		// Token: 0x02000BA5 RID: 2981
		// (Invoke) Token: 0x0600403B RID: 16443
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000BA6 RID: 2982
		// (Invoke) Token: 0x0600403D RID: 16445
		private delegate void ResetFor_InternalDelegate(IntPtr method);

		// Token: 0x02000BA7 RID: 2983
		// (Invoke) Token: 0x0600403F RID: 16447
		private delegate void ResetAllDelegate();
	}
}

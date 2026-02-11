using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Diagnostics
{
	// Token: 0x0200035E RID: 862
	public static class Utils
	{
		// Token: 0x06002EA3 RID: 11939 RVA: 0x000129C7 File Offset: 0x00010BC7
		public static void ForceCrash(ForcedCrashCategory crashCategory)
		{
			Utils.ForceCrashDelegateField(crashCategory);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000129D4 File Offset: 0x00010BD4
		public static void NativeAssert(string message)
		{
			Utils.NativeAssertDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000129E6 File Offset: 0x00010BE6
		public static void NativeError(string message)
		{
			Utils.NativeErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000129F8 File Offset: 0x00010BF8
		public static void NativeWarning(string message)
		{
			Utils.NativeWarningDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00012A0A File Offset: 0x00010C0A
		public static void ValidateHeap()
		{
			Utils.ValidateHeapDelegateField();
		}

		// Token: 0x04002A57 RID: 10839
		private static readonly Utils.ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<Utils.ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");

		// Token: 0x04002A58 RID: 10840
		private static readonly Utils.NativeAssertDelegate NativeAssertDelegateField = IL2CPP.ResolveICall<Utils.NativeAssertDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert");

		// Token: 0x04002A59 RID: 10841
		private static readonly Utils.NativeErrorDelegate NativeErrorDelegateField = IL2CPP.ResolveICall<Utils.NativeErrorDelegate>("UnityEngine.Diagnostics.Utils::NativeError");

		// Token: 0x04002A5A RID: 10842
		private static readonly Utils.NativeWarningDelegate NativeWarningDelegateField = IL2CPP.ResolveICall<Utils.NativeWarningDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning");

		// Token: 0x04002A5B RID: 10843
		private static readonly Utils.ValidateHeapDelegate ValidateHeapDelegateField = IL2CPP.ResolveICall<Utils.ValidateHeapDelegate>("UnityEngine.Diagnostics.Utils::ValidateHeap");

		// Token: 0x02000B9F RID: 2975
		// (Invoke) Token: 0x0600402F RID: 16431
		private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

		// Token: 0x02000BA0 RID: 2976
		// (Invoke) Token: 0x06004031 RID: 16433
		private delegate void NativeAssertDelegate(IntPtr message);

		// Token: 0x02000BA1 RID: 2977
		// (Invoke) Token: 0x06004033 RID: 16435
		private delegate void NativeErrorDelegate(IntPtr message);

		// Token: 0x02000BA2 RID: 2978
		// (Invoke) Token: 0x06004035 RID: 16437
		private delegate void NativeWarningDelegate(IntPtr message);

		// Token: 0x02000BA3 RID: 2979
		// (Invoke) Token: 0x06004037 RID: 16439
		private delegate void ValidateHeapDelegate();
	}
}

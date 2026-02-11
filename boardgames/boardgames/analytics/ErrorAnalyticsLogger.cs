using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.analytics
{
	// Token: 0x0200017B RID: 379
	public static class ErrorAnalyticsLogger : global::Il2CppSystem.Object
	{
		// Token: 0x060012EB RID: 4843 RVA: 0x0004B5A8 File Offset: 0x000497A8
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorAnalyticsLogger()
		{
			Il2CppClassPointerStore<ErrorAnalyticsLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.analytics", "ErrorAnalyticsLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorAnalyticsLogger>.NativeClassPtr);
			ErrorAnalyticsLogger.NativeMethodInfoPtr_ReleaseType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorAnalyticsLogger>.NativeClassPtr, 100666081);
			ErrorAnalyticsLogger.NativeMethodInfoPtr_SendErrorToAnalytics_Public_Static_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorAnalyticsLogger>.NativeClassPtr, 100666082);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0004B600 File Offset: 0x00049800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001417, XrefRangeEnd = 1001419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReleaseType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorAnalyticsLogger.NativeMethodInfoPtr_ReleaseType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0004B62C File Offset: 0x0004982C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001419, XrefRangeEnd = 1001481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendErrorToAnalytics(string logString, string stackTrace, LogType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorAnalyticsLogger.NativeMethodInfoPtr_SendErrorToAnalytics_Public_Static_Void_String_String_LogType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0000AD2A File Offset: 0x00008F2A
		public ErrorAnalyticsLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseType_Private_Static_String_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_SendErrorToAnalytics_Public_Static_Void_String_String_LogType_0;
	}
}

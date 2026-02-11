using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace analytics
{
	// Token: 0x02000006 RID: 6
	public static class Analytics : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000025B0 File Offset: 0x000007B0
		// Note: this type is marked as 'beforefieldinit'.
		static Analytics()
		{
			Il2CppClassPointerStore<Analytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "Analytics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Analytics>.NativeClassPtr);
			Analytics.NativeMethodInfoPtr_Log_Public_Static_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663303);
			Analytics.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663304);
			Analytics.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Dictionary_2_String_Object_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663305);
			Analytics.NativeMethodInfoPtr_MakeExceptionData_Private_Static_Dictionary_2_String_Object_String_Exception_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663306);
			Analytics.NativeMethodInfoPtr_MakeStackTrace_Private_Static_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663307);
			Analytics.NativeMethodInfoPtr_AppendInnerException_Private_Static_Void_StringBuilder_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002658 File Offset: 0x00000858
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1273276, RefRangeEnd = 1273282, XrefRangeStart = 1273258, XrefRangeEnd = 1273276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(string eventName, Dictionary<string, Object> dict)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_Log_Public_Static_Void_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026A0 File Offset: 0x000008A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1273286, RefRangeEnd = 1273289, XrefRangeStart = 1273282, XrefRangeEnd = 1273286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception e, Dictionary<string, Object> extraParams = null, string error = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraParams);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Dictionary_2_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026FC File Offset: 0x000008FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1273293, RefRangeEnd = 1273296, XrefRangeStart = 1273289, XrefRangeEnd = 1273293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string error, Dictionary<string, Object> extraParams = null, Exception e = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraParams);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Dictionary_2_String_Object_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002758 File Offset: 0x00000958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273329, RefRangeEnd = 1273331, XrefRangeStart = 1273296, XrefRangeEnd = 1273329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> MakeExceptionData(string error = null, Exception e = null, Dictionary<string, Object> extraParams = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_MakeExceptionData_Private_Static_Dictionary_2_String_Object_String_Exception_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027C0 File Offset: 0x000009C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273356, RefRangeEnd = 1273357, XrefRangeStart = 1273331, XrefRangeEnd = 1273356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeStackTrace(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_MakeStackTrace_Private_Static_String_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000027FC File Offset: 0x000009FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273370, RefRangeEnd = 1273372, XrefRangeStart = 1273357, XrefRangeEnd = 1273370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendInnerException(StringBuilder stackTrace, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackTrace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_AppendInnerException_Private_Static_Void_StringBuilder_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E7 File Offset: 0x000002E7
		public Analytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Dictionary_2_String_Object_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_Dictionary_2_String_Object_Exception_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_MakeExceptionData_Private_Static_Dictionary_2_String_Object_String_Exception_Dictionary_2_String_Object_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_MakeStackTrace_Private_Static_String_Exception_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_AppendInnerException_Private_Static_Void_StringBuilder_Exception_0;
	}
}

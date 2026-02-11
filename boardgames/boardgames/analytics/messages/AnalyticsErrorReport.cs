using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.analytics.messages
{
	// Token: 0x0200017D RID: 381
	public class AnalyticsErrorReport : ClientAnalyticsMessage
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0004B790 File Offset: 0x00049990
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsErrorReport()
		{
			Il2CppClassPointerStore<AnalyticsErrorReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.analytics.messages", "AnalyticsErrorReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsErrorReport>.NativeClassPtr);
			AnalyticsErrorReport.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsErrorReport>.NativeClassPtr, 100666085);
			AnalyticsErrorReport.NativeMethodInfoPtr_AddMetadata_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsErrorReport>.NativeClassPtr, 100666086);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0004B7E8 File Offset: 0x000499E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001557, RefRangeEnd = 1001558, XrefRangeStart = 1001508, XrefRangeEnd = 1001557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsErrorReport(string platform, string releaseType, string accountID, string gameID, string device, string os, string clientVersion, string serverVersion, string logLevel, string logMessage, string stackTrace, Dictionary<string, Object> extraMetadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsErrorReport>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(releaseType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accountID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(device);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(os);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientVersion);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(serverVersion);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(logLevel);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(logMessage);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraMetadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsErrorReport.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0004B908 File Offset: 0x00049B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001558, XrefRangeEnd = 1001562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMetadata(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsErrorReport.NativeMethodInfoPtr_AddMetadata_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0000AD3C File Offset: 0x00008F3C
		public AnalyticsErrorReport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_Dictionary_2_String_Object_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Void_String_Object_0;
	}
}

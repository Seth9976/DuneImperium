using System;
using analytics;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.analytics.messages
{
	// Token: 0x02000094 RID: 148
	public class AnalyticsOfflineGameStarted : IAnalyticsMessage
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00027B90 File Offset: 0x00025D90
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsOfflineGameStarted()
		{
			Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsOfflineGameStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr);
			AnalyticsOfflineGameStarted.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr, "data");
			AnalyticsOfflineGameStarted.NativeFieldInfoPtr_numPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr, "numPlayers");
			AnalyticsOfflineGameStarted.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr, 100664468);
			AnalyticsOfflineGameStarted.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr, 100664469);
			AnalyticsOfflineGameStarted.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr, 100664470);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00027C24 File Offset: 0x00025E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990495, RefRangeEnd = 990496, XrefRangeStart = 990473, XrefRangeEnd = 990495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsOfflineGameStarted(MatchInitData matchData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOfflineGameStarted>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOfflineGameStarted.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00027C70 File Offset: 0x00025E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990496, XrefRangeEnd = 990500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsOfflineGameStarted.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00027CC4 File Offset: 0x00025EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990500, XrefRangeEnd = 990538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsOfflineGameStarted.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00005373 File Offset: 0x00003573
		public AnalyticsOfflineGameStarted(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00027D18 File Offset: 0x00025F18
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0000537C File Offset: 0x0000357C
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameStarted.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameStarted.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00027D48 File Offset: 0x00025F48
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0000539B File Offset: 0x0000359B
		public unsafe int numPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameStarted.NativeFieldInfoPtr_numPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameStarted.NativeFieldInfoPtr_numPlayers)) = value;
			}
		}

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_numPlayers;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

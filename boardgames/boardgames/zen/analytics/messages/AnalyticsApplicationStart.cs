using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.analytics.messages
{
	// Token: 0x0200008F RID: 143
	public class AnalyticsApplicationStart : IAnalyticsMessage
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x000274D8 File Offset: 0x000256D8
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsApplicationStart()
		{
			Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsApplicationStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr);
			AnalyticsApplicationStart.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr, "data");
			AnalyticsApplicationStart.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr, 100664454);
			AnalyticsApplicationStart.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr, 100664455);
			AnalyticsApplicationStart.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr, 100664456);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00027558 File Offset: 0x00025758
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsApplicationStart(Dictionary<string, Object> d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsApplicationStart>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsApplicationStart.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000275A4 File Offset: 0x000257A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989960, XrefRangeEnd = 989964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsApplicationStart.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000275F8 File Offset: 0x000257F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989964, XrefRangeEnd = 990121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsApplicationStart.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00005291 File Offset: 0x00003491
		public AnalyticsApplicationStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0002764C File Offset: 0x0002584C
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x0000529A File Offset: 0x0000349A
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsApplicationStart.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsApplicationStart.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.analytics.messages
{
	// Token: 0x0200008E RID: 142
	public class AnalyticsApplicationEnd : IAnalyticsMessage
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x000272E4 File Offset: 0x000254E4
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsApplicationEnd()
		{
			Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsApplicationEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr);
			AnalyticsApplicationEnd.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr, "data");
			AnalyticsApplicationEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr, 100664450);
			AnalyticsApplicationEnd.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr, 100664451);
			AnalyticsApplicationEnd.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr, 100664452);
			AnalyticsApplicationEnd.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr, 100664453);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00027378 File Offset: 0x00025578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989845, XrefRangeEnd = 989853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsApplicationEnd()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsApplicationEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000273B4 File Offset: 0x000255B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989853, XrefRangeEnd = 989862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsApplicationEnd(Dictionary<string, Object> d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsApplicationEnd>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsApplicationEnd.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00027400 File Offset: 0x00025600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989862, XrefRangeEnd = 989866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsApplicationEnd.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00027454 File Offset: 0x00025654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989866, XrefRangeEnd = 989960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsApplicationEnd.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00005269 File Offset: 0x00003469
		public AnalyticsApplicationEnd(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000274A8 File Offset: 0x000256A8
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005272 File Offset: 0x00003472
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsApplicationEnd.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsApplicationEnd.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

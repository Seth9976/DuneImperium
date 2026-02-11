using System;
using analytics;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x02000091 RID: 145
	public class AnalyticsFriendUpdate : ClientAnalyticsMessage
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x00027778 File Offset: 0x00025978
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsFriendUpdate()
		{
			Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsFriendUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr);
			AnalyticsFriendUpdate.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr, "source");
			AnalyticsFriendUpdate.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr, "target");
			AnalyticsFriendUpdate.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr, 100664459);
			AnalyticsFriendUpdate.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr, 100664460);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000277F8 File Offset: 0x000259F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990159, XrefRangeEnd = 990168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsFriendUpdate(string eventType, string sourceID, string targetID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsFriendUpdate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsFriendUpdate.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00027868 File Offset: 0x00025A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990168, XrefRangeEnd = 990215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsFriendUpdate.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000052C2 File Offset: 0x000034C2
		public AnalyticsFriendUpdate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000278BC File Offset: 0x00025ABC
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000052CB File Offset: 0x000034CB
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsFriendUpdate.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsFriendUpdate.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000278E4 File Offset: 0x00025AE4
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000052EA File Offset: 0x000034EA
		public unsafe string target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsFriendUpdate.NativeFieldInfoPtr_target);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsFriendUpdate.NativeFieldInfoPtr_target), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

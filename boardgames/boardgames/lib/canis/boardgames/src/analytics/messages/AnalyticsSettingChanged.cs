using System;
using analytics;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lib.canis.boardgames.src.analytics.messages
{
	// Token: 0x0200003F RID: 63
	public class AnalyticsSettingChanged : ClientAnalyticsMessage
	{
		// Token: 0x06000284 RID: 644 RVA: 0x000192D8 File Offset: 0x000174D8
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSettingChanged()
		{
			Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.analytics.messages", "AnalyticsSettingChanged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr);
			AnalyticsSettingChanged.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, "accountID");
			AnalyticsSettingChanged.NativeFieldInfoPtr_changedSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, "changedSetting");
			AnalyticsSettingChanged.NativeFieldInfoPtr_changedSettingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, "changedSettingValue");
			AnalyticsSettingChanged.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, 100663765);
			AnalyticsSettingChanged.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, 100663766);
			AnalyticsSettingChanged.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr, 100663767);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00019380 File Offset: 0x00017580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 985088, RefRangeEnd = 985090, XrefRangeStart = 985076, XrefRangeEnd = 985088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsSettingChanged(string accountID, string changedSetting, string changedSettingValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSettingChanged>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(changedSetting);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(changedSettingValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSettingChanged.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000193F0 File Offset: 0x000175F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985090, XrefRangeEnd = 985094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsSettingChanged.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00019444 File Offset: 0x00017644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985094, XrefRangeEnd = 985191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsSettingChanged.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000310D File Offset: 0x0000130D
		public AnalyticsSettingChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00019498 File Offset: 0x00017698
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003116 File Offset: 0x00001316
		public unsafe string accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_accountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_accountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000194C0 File Offset: 0x000176C0
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003135 File Offset: 0x00001335
		public unsafe string changedSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_changedSetting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_changedSetting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000194E8 File Offset: 0x000176E8
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003154 File Offset: 0x00001354
		public unsafe string changedSettingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_changedSettingValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSettingChanged.NativeFieldInfoPtr_changedSettingValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_changedSetting;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_changedSettingValue;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

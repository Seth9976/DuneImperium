using System;
using analytics;
using boardgames.analytics;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lib.boardgames.src.analytics.messages
{
	// Token: 0x02000042 RID: 66
	public class AnalyticsIAPClaimed : ClientAnalyticsMessage
	{
		// Token: 0x0600029F RID: 671 RVA: 0x000197B4 File Offset: 0x000179B4
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsIAPClaimed()
		{
			Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.boardgames.src.analytics.messages", "AnalyticsIAPClaimed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr);
			AnalyticsIAPClaimed.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, "accountID");
			AnalyticsIAPClaimed.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, "productID");
			AnalyticsIAPClaimed.NativeFieldInfoPtr_transactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, "transactionID");
			AnalyticsIAPClaimed.NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, "reason");
			AnalyticsIAPClaimed.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, 100663772);
			AnalyticsIAPClaimed.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr, 100663773);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001985C File Offset: 0x00017A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985249, RefRangeEnd = 985250, XrefRangeStart = 985236, XrefRangeEnd = 985249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsIAPClaimed(AccountID accountID, string productID, string transactionID, string reason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsIAPClaimed>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsIAPClaimed.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000198E0 File Offset: 0x00017AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985250, XrefRangeEnd = 985269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsIAPClaimed.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003201 File Offset: 0x00001401
		public AnalyticsIAPClaimed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00019934 File Offset: 0x00017B34
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000320A File Offset: 0x0000140A
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00019964 File Offset: 0x00017B64
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003229 File Offset: 0x00001429
		public unsafe string productID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_productID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001998C File Offset: 0x00017B8C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003248 File Offset: 0x00001448
		public unsafe string transactionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_transactionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_transactionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000199B4 File Offset: 0x00017BB4
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00003267 File Offset: 0x00001467
		public unsafe string reason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_reason);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsIAPClaimed.NativeFieldInfoPtr_reason), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_productID;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_transactionID;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_reason;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_String_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000CD RID: 205
	public class FriendGameInviteData : DataComponent
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x00038E04 File Offset: 0x00037004
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInviteData()
		{
			Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "FriendGameInviteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr);
			FriendGameInviteData.NativeFieldInfoPtr__AccountID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, "<AccountID>k__BackingField");
			FriendGameInviteData.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, "<Name>k__BackingField");
			FriendGameInviteData.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, 100664560);
			FriendGameInviteData.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, 100664561);
			FriendGameInviteData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, 100664562);
			FriendGameInviteData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr, 100664563);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00038EAC File Offset: 0x000370AC
		public unsafe AccountID AccountID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteData.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00038EEC File Offset: 0x000370EC
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteData.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00038F24 File Offset: 0x00037124
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 504845, RefRangeEnd = 504850, XrefRangeStart = 504842, XrefRangeEnd = 504845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameInviteData(AccountID accountID, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInviteData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00038F84 File Offset: 0x00037184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504850, XrefRangeEnd = 504855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameInviteData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00006164 File Offset: 0x00004364
		public FriendGameInviteData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00038FC8 File Offset: 0x000371C8
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x0000616D File Offset: 0x0000436D
		public unsafe AccountID _AccountID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInviteData.NativeFieldInfoPtr__AccountID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInviteData.NativeFieldInfoPtr__AccountID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00038FF8 File Offset: 0x000371F8
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0000618C File Offset: 0x0000438C
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInviteData.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInviteData.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr__AccountID_k__BackingField;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

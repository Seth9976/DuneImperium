using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x02000028 RID: 40
	public class PlayerMatchInitData : Object
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00024814 File Offset: 0x00022A14
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMatchInitData()
		{
			Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "PlayerMatchInitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr);
			PlayerMatchInitData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, "name");
			PlayerMatchInitData.NativeFieldInfoPtr_isHuman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, "isHuman");
			PlayerMatchInitData.NativeFieldInfoPtr_aiLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, "aiLevel");
			PlayerMatchInitData.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, "metadata");
			PlayerMatchInitData.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, "accountID");
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_Int32_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663922);
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663923);
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663924);
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663925);
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663926);
			PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663927);
			PlayerMatchInitData.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663928);
			PlayerMatchInitData.NativeMethodInfoPtr_AddMetadata_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663929);
			PlayerMatchInitData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr, 100663930);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0002495C File Offset: 0x00022B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 548966, RefRangeEnd = 548968, XrefRangeStart = 548945, XrefRangeEnd = 548966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData(int ail, AccountID aiAccountId = null, string aiName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ail;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aiAccountId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aiName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_Int32_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000249C8 File Offset: 0x00022BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548984, RefRangeEnd = 548985, XrefRangeStart = 548968, XrefRangeEnd = 548984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00024A04 File Offset: 0x00022C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549002, RefRangeEnd = 549003, XrefRangeStart = 548985, XrefRangeEnd = 549002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData(string n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00024A50 File Offset: 0x00022C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549021, RefRangeEnd = 549022, XrefRangeStart = 549003, XrefRangeEnd = 549021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData(string n, AccountID aid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00024AB0 File Offset: 0x00022CB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 549041, RefRangeEnd = 549044, XrefRangeStart = 549022, XrefRangeEnd = 549041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData(PlayerMatchInitData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00024AFC File Offset: 0x00022CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549058, RefRangeEnd = 549059, XrefRangeStart = 549044, XrefRangeEnd = 549058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMatchInitData(PlayerInfoSaveData saveData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr__ctor_Protected_Void_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00024B48 File Offset: 0x00022D48
		[CallerCount(0)]
		public unsafe virtual PlayerMatchInitData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMatchInitData.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr3) : null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00024B94 File Offset: 0x00022D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549059, XrefRangeEnd = 549070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMetadata(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMatchInitData.NativeMethodInfoPtr_AddMetadata_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00024BE8 File Offset: 0x00022DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549070, XrefRangeEnd = 549098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMatchInitData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003258 File Offset: 0x00001458
		public PlayerMatchInitData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00024C2C File Offset: 0x00022E2C
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00003261 File Offset: 0x00001461
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00024C54 File Offset: 0x00022E54
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00003280 File Offset: 0x00001480
		public unsafe bool isHuman
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_isHuman);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_isHuman)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00024C7C File Offset: 0x00022E7C
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000329B File Offset: 0x0000149B
		public unsafe int aiLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_aiLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_aiLevel)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00024CA4 File Offset: 0x00022EA4
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000032B6 File Offset: 0x000014B6
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00024CD4 File Offset: 0x00022ED4
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x000032D5 File Offset: 0x000014D5
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMatchInitData.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_isHuman;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_aiLevel;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_AccountID_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_AccountID_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_PlayerMatchInitData_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_PlayerInfoSaveData_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_PlayerMatchInitData_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Void_String_String_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

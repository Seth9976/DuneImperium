using System;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.platform.providers
{
	// Token: 0x02000046 RID: 70
	public class PlatformBlockedAccounts : PlatformData
	{
		// Token: 0x06000267 RID: 615 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformBlockedAccounts()
		{
			Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.providers", "PlatformBlockedAccounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr);
			PlatformBlockedAccounts.NativeFieldInfoPtr_blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, "blocked");
			PlatformBlockedAccounts.NativeFieldInfoPtr__All_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, "<All>k__BackingField");
			PlatformBlockedAccounts.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_BlockedAccountEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663648);
			PlatformBlockedAccounts.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_BlockedAccountEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663649);
			PlatformBlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663650);
			PlatformBlockedAccounts.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663651);
			PlatformBlockedAccounts.NativeMethodInfoPtr_GetBlockedByID_Public_BlockedAccountEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663652);
			PlatformBlockedAccounts.NativeMethodInfoPtr_UpdateBlocked_Public_Void_BlockedAccounts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663653);
			PlatformBlockedAccounts.NativeMethodInfoPtr_UpdateBlocked_Public_Void_Il2CppReferenceArray_1_BlockedAccountEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663654);
			PlatformBlockedAccounts.NativeMethodInfoPtr_AddBlocked_Public_Void_BlockedAccountEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663655);
			PlatformBlockedAccounts.NativeMethodInfoPtr_RemoveBlocked_Public_Void_BlockedRemoval_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr, 100663656);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000CD78 File Offset: 0x0000AF78
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		public unsafe ReadOnlyCollection<BlockedAccountEntry> All
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_BlockedAccountEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BlockedAccountEntry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_BlockedAccountEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168222, XrefRangeEnd = 1168235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformBlockedAccounts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformBlockedAccounts>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000CE38 File Offset: 0x0000B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168235, XrefRangeEnd = 1168237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000CE6C File Offset: 0x0000B06C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168248, RefRangeEnd = 1168250, XrefRangeStart = 1168237, XrefRangeEnd = 1168248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockedAccountEntry GetBlockedByID(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_GetBlockedByID_Public_BlockedAccountEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockedAccountEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168250, XrefRangeEnd = 1168252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlocked(BlockedAccounts msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_UpdateBlocked_Public_Void_BlockedAccounts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000CF00 File Offset: 0x0000B100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168257, RefRangeEnd = 1168259, XrefRangeStart = 1168252, XrefRangeEnd = 1168257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlocked(Il2CppReferenceArray<BlockedAccountEntry> blockedList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blockedList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_UpdateBlocked_Public_Void_Il2CppReferenceArray_1_BlockedAccountEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000CF44 File Offset: 0x0000B144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168259, XrefRangeEnd = 1168268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBlocked(BlockedAccountEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_AddBlocked_Public_Void_BlockedAccountEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000CF88 File Offset: 0x0000B188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168268, XrefRangeEnd = 1168277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBlocked(BlockedRemoval removal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(removal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformBlockedAccounts.NativeMethodInfoPtr_RemoveBlocked_Public_Void_BlockedRemoval_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000338E File Offset: 0x0000158E
		public PlatformBlockedAccounts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00003397 File Offset: 0x00001597
		public unsafe List<BlockedAccountEntry> blocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformBlockedAccounts.NativeFieldInfoPtr_blocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BlockedAccountEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformBlockedAccounts.NativeFieldInfoPtr_blocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000033B6 File Offset: 0x000015B6
		public unsafe ReadOnlyCollection<BlockedAccountEntry> _All_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformBlockedAccounts.NativeFieldInfoPtr__All_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BlockedAccountEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformBlockedAccounts.NativeFieldInfoPtr__All_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_blocked;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr__All_k__BackingField;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_BlockedAccountEntry_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_BlockedAccountEntry_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockedByID_Public_BlockedAccountEntry_String_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlocked_Public_Void_BlockedAccounts_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlocked_Public_Void_Il2CppReferenceArray_1_BlockedAccountEntry_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_AddBlocked_Public_Void_BlockedAccountEntry_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBlocked_Public_Void_BlockedRemoval_0;
	}
}

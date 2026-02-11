using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200018D RID: 397
	public class PlayerSlotLockData : VersionedDataComponent
	{
		// Token: 0x0600118B RID: 4491 RVA: 0x00055444 File Offset: 0x00053644
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlotLockData()
		{
			Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PlayerSlotLockData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr);
			PlayerSlotLockData.NativeFieldInfoPtr_playerTypeLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, "playerTypeLocked");
			PlayerSlotLockData.NativeFieldInfoPtr_slotFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, "slotFilled");
			PlayerSlotLockData.NativeMethodInfoPtr_get_PlayerTypeLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665757);
			PlayerSlotLockData.NativeMethodInfoPtr_set_PlayerTypeLocked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665758);
			PlayerSlotLockData.NativeMethodInfoPtr_get_SlotFilled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665759);
			PlayerSlotLockData.NativeMethodInfoPtr_set_SlotFilled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665760);
			PlayerSlotLockData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665761);
			PlayerSlotLockData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr, 100665762);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00055514 File Offset: 0x00053714
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00055550 File Offset: 0x00053750
		public unsafe bool PlayerTypeLocked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockData.NativeMethodInfoPtr_get_PlayerTypeLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 499927, RefRangeEnd = 499930, XrefRangeStart = 499927, XrefRangeEnd = 499930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockData.NativeMethodInfoPtr_set_PlayerTypeLocked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00055590 File Offset: 0x00053790
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x000555CC File Offset: 0x000537CC
		public unsafe bool SlotFilled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockData.NativeMethodInfoPtr_get_SlotFilled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 515109, RefRangeEnd = 515116, XrefRangeStart = 515108, XrefRangeEnd = 515109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockData.NativeMethodInfoPtr_set_SlotFilled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0005560C File Offset: 0x0005380C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 515118, RefRangeEnd = 515122, XrefRangeStart = 515116, XrefRangeEnd = 515118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSlotLockData(bool playerTypeLocked)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSlotLockData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerTypeLocked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00055654 File Offset: 0x00053854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515122, XrefRangeEnd = 515132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSlotLockData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0000A68C File Offset: 0x0000888C
		public PlayerSlotLockData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00055698 File Offset: 0x00053898
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000A695 File Offset: 0x00008895
		public unsafe bool playerTypeLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockData.NativeFieldInfoPtr_playerTypeLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockData.NativeFieldInfoPtr_playerTypeLocked)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000556C0 File Offset: 0x000538C0
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0000A6B0 File Offset: 0x000088B0
		public unsafe bool slotFilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockData.NativeFieldInfoPtr_slotFilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockData.NativeFieldInfoPtr_slotFilled)) = value;
			}
		}

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_playerTypeLocked;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr_slotFilled;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerTypeLocked_Public_get_Boolean_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerTypeLocked_Public_set_Void_Boolean_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotFilled_Public_get_Boolean_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotFilled_Public_set_Void_Boolean_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

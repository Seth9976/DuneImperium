using System;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x0200018E RID: 398
	public class PlayerTypeData : VersionedDataComponent
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x000556E8 File Offset: 0x000538E8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTypeData()
		{
			Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PlayerTypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr);
			PlayerTypeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, "type");
			PlayerTypeData.NativeFieldInfoPtr_friend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, "friend");
			PlayerTypeData.NativeFieldInfoPtr_isActiveLocalPlayerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, "isActiveLocalPlayerSlot");
			PlayerTypeData.NativeMethodInfoPtr_get_Type_Public_get_PlayerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665763);
			PlayerTypeData.NativeMethodInfoPtr_set_Type_Public_set_Void_PlayerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665764);
			PlayerTypeData.NativeMethodInfoPtr_get_Friend_Public_get_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665765);
			PlayerTypeData.NativeMethodInfoPtr_set_Friend_Public_set_Void_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665766);
			PlayerTypeData.NativeMethodInfoPtr_get_IsActiveLocalPlayerSlot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665767);
			PlayerTypeData.NativeMethodInfoPtr_set_IsActiveLocalPlayerSlot_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665768);
			PlayerTypeData.NativeMethodInfoPtr__ctor_Public_Void_PlayerType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665769);
			PlayerTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr, 100665770);
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000557F4 File Offset: 0x000539F4
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00055830 File Offset: 0x00053A30
		public unsafe PlayerTypeData.PlayerType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_get_Type_Public_get_PlayerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 515133, RefRangeEnd = 515146, XrefRangeStart = 515132, XrefRangeEnd = 515133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_set_Type_Public_set_Void_PlayerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00055870 File Offset: 0x00053A70
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x000558B0 File Offset: 0x00053AB0
		public unsafe RosterEntry Friend
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_get_Friend_Public_get_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 514355, RefRangeEnd = 514362, XrefRangeStart = 514355, XrefRangeEnd = 514362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_set_Friend_Public_set_Void_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000558F4 File Offset: 0x00053AF4
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00055930 File Offset: 0x00053B30
		public unsafe bool IsActiveLocalPlayerSlot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_get_IsActiveLocalPlayerSlot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 515147, RefRangeEnd = 515148, XrefRangeStart = 515146, XrefRangeEnd = 515147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr_set_IsActiveLocalPlayerSlot_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00055970 File Offset: 0x00053B70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 515149, RefRangeEnd = 515154, XrefRangeStart = 515148, XrefRangeEnd = 515149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTypeData(PlayerTypeData.PlayerType type, bool isActiveLocalPlayerSlot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTypeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActiveLocalPlayerSlot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeData.NativeMethodInfoPtr__ctor_Public_Void_PlayerType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000559C8 File Offset: 0x00053BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515154, XrefRangeEnd = 515167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0000A6CB File Offset: 0x000088CB
		public PlayerTypeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00055A0C File Offset: 0x00053C0C
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0000A6D4 File Offset: 0x000088D4
		public unsafe PlayerTypeData.PlayerType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00055A34 File Offset: 0x00053C34
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000A6EF File Offset: 0x000088EF
		public unsafe RosterEntry friend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_friend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_friend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00055A64 File Offset: 0x00053C64
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000A70E File Offset: 0x0000890E
		public unsafe bool isActiveLocalPlayerSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_isActiveLocalPlayerSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeData.NativeFieldInfoPtr_isActiveLocalPlayerSlot)) = value;
			}
		}

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_friend;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_isActiveLocalPlayerSlot;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_PlayerType_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_PlayerType_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_get_Friend_Public_get_RosterEntry_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_set_Friend_Public_set_Void_RosterEntry_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActiveLocalPlayerSlot_Public_get_Boolean_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActiveLocalPlayerSlot_Public_set_Void_Boolean_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerType_Boolean_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200037A RID: 890
		[Serializable]
		public enum PlayerType
		{
			// Token: 0x04001A15 RID: 6677
			Human,
			// Token: 0x04001A16 RID: 6678
			CPU,
			// Token: 0x04001A17 RID: 6679
			Friend,
			// Token: 0x04001A18 RID: 6680
			Off
		}
	}
}

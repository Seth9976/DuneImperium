using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x02000468 RID: 1128
	public class ThroneRoomPoliticsRevealAbility : RevealAbility
	{
		// Token: 0x060031CC RID: 12748 RVA: 0x0012B2A0 File Offset: 0x001294A0
		// Note: this type is marked as 'beforefieldinit'.
		static ThroneRoomPoliticsRevealAbility()
		{
			Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "ThroneRoomPoliticsRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr);
			ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, "AbilityName");
			ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, "AbilityID");
			ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, 100678678);
			ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, 100678679);
			ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, 100678680);
			ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr, 100678681);
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0012B348 File Offset: 0x00129548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228759, XrefRangeEnd = 228763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0012B394 File Offset: 0x00129594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228763, XrefRangeEnd = 228779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThroneRoomPoliticsRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x0012B3E0 File Offset: 0x001295E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228779, XrefRangeEnd = 228783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThroneRoomPoliticsRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThroneRoomPoliticsRevealAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0012B450 File Offset: 0x00129650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228783, XrefRangeEnd = 228799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, int> GetRevealPreviewValue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThroneRoomPoliticsRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0001168A File Offset: 0x0000F88A
		public ThroneRoomPoliticsRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0012B4C0 File Offset: 0x001296C0
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00011693 File Offset: 0x0000F893
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0012B4E0 File Offset: 0x001296E0
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x000116A5 File Offset: 0x0000F8A5
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThroneRoomPoliticsRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;
	}
}

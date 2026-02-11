using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.abilities.TriggeredAbilities.Challenge
{
	// Token: 0x0200037F RID: 895
	public class AddTrashAcquireEffectForBeneGesserit : AddTrashAcquireEffectForFaction
	{
		// Token: 0x06002550 RID: 9552 RVA: 0x000EF474 File Offset: 0x000ED674
		// Note: this type is marked as 'beforefieldinit'.
		static AddTrashAcquireEffectForBeneGesserit()
		{
			Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "AddTrashAcquireEffectForBeneGesserit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr);
			AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, "AbilityName");
			AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, "AbilityID");
			AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, 100673532);
			AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, 100673533);
			AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, 100673534);
			AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr, 100673535);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000EF51C File Offset: 0x000ED71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189181, XrefRangeEnd = 189185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000EF568 File Offset: 0x000ED768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189185, XrefRangeEnd = 189188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTrashAcquireEffectForBeneGesserit(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000EF5B4 File Offset: 0x000ED7B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTrashAcquireEffectForBeneGesserit(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTrashAcquireEffectForBeneGesserit>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000EF624 File Offset: 0x000ED824
		public unsafe override Factions SpecifiedFaction
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTrashAcquireEffectForBeneGesserit.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x0000E77F File Offset: 0x0000C97F
		public AddTrashAcquireEffectForBeneGesserit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000EF66C File Offset: 0x000ED86C
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x0000E788 File Offset: 0x0000C988
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000EF68C File Offset: 0x000ED88C
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x0000E79A File Offset: 0x0000C99A
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddTrashAcquireEffectForBeneGesserit.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0;
	}
}

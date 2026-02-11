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
	// Token: 0x02000380 RID: 896
	public class AddTrashAcquireEffectForFremen : AddTrashAcquireEffectForFaction
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x000EF6B4 File Offset: 0x000ED8B4
		// Note: this type is marked as 'beforefieldinit'.
		static AddTrashAcquireEffectForFremen()
		{
			Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "AddTrashAcquireEffectForFremen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr);
			AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, "AbilityName");
			AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, "AbilityID");
			AddTrashAcquireEffectForFremen.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, 100673537);
			AddTrashAcquireEffectForFremen.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, 100673538);
			AddTrashAcquireEffectForFremen.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, 100673539);
			AddTrashAcquireEffectForFremen.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr, 100673540);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000EF75C File Offset: 0x000ED95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189188, XrefRangeEnd = 189192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTrashAcquireEffectForFremen.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000EF7A8 File Offset: 0x000ED9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189192, XrefRangeEnd = 189195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTrashAcquireEffectForFremen(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTrashAcquireEffectForFremen.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000EF7F4 File Offset: 0x000ED9F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTrashAcquireEffectForFremen(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTrashAcquireEffectForFremen>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTrashAcquireEffectForFremen.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000EF864 File Offset: 0x000EDA64
		public unsafe override Factions SpecifiedFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTrashAcquireEffectForFremen.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		public AddTrashAcquireEffectForFremen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000EF8AC File Offset: 0x000EDAAC
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x0000E7B5 File Offset: 0x0000C9B5
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000EF8CC File Offset: 0x000EDACC
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x0000E7C7 File Offset: 0x0000C9C7
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddTrashAcquireEffectForFremen.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0;
	}
}

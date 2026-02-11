using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004CA RID: 1226
	public class CarefulObservationSpacingGuildAbility : CarefulObservationFactionAbility
	{
		// Token: 0x06003757 RID: 14167 RVA: 0x0014716C File Offset: 0x0014536C
		// Note: this type is marked as 'beforefieldinit'.
		static CarefulObservationSpacingGuildAbility()
		{
			Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "CarefulObservationSpacingGuildAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr);
			CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, "AbilityName");
			CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, "AbilityID");
			CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, 100680834);
			CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, 100680835);
			CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, 100680836);
			CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr, 100680837);
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00147214 File Offset: 0x00145414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246970, XrefRangeEnd = 246974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00147260 File Offset: 0x00145460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246974, XrefRangeEnd = 246977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationSpacingGuildAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x001472AC File Offset: 0x001454AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationSpacingGuildAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationSpacingGuildAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x0014731C File Offset: 0x0014551C
		public unsafe override Factions SnooperFaction
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationSpacingGuildAbility.NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00012892 File Offset: 0x00010A92
		public CarefulObservationSpacingGuildAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x00147364 File Offset: 0x00145564
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x0001289B File Offset: 0x00010A9B
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x00147384 File Offset: 0x00145584
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x000128AD File Offset: 0x00010AAD
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationSpacingGuildAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0;
	}
}

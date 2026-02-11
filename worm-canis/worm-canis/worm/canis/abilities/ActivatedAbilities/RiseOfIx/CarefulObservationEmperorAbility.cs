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
	// Token: 0x020004C9 RID: 1225
	public class CarefulObservationEmperorAbility : CarefulObservationFactionAbility
	{
		// Token: 0x0600374D RID: 14157 RVA: 0x00146F2C File Offset: 0x0014512C
		// Note: this type is marked as 'beforefieldinit'.
		static CarefulObservationEmperorAbility()
		{
			Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "CarefulObservationEmperorAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr);
			CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, "AbilityName");
			CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, "AbilityID");
			CarefulObservationEmperorAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, 100680829);
			CarefulObservationEmperorAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, 100680830);
			CarefulObservationEmperorAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, 100680831);
			CarefulObservationEmperorAbility.NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr, 100680832);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00146FD4 File Offset: 0x001451D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246963, XrefRangeEnd = 246967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationEmperorAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00147020 File Offset: 0x00145220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246967, XrefRangeEnd = 246970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationEmperorAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationEmperorAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0014706C File Offset: 0x0014526C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationEmperorAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationEmperorAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationEmperorAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x001470DC File Offset: 0x001452DC
		public unsafe override Factions SnooperFaction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationEmperorAbility.NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00012865 File Offset: 0x00010A65
		public CarefulObservationEmperorAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x00147124 File Offset: 0x00145324
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x0001286E File Offset: 0x00010A6E
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x00147144 File Offset: 0x00145344
		// (set) Token: 0x06003756 RID: 14166 RVA: 0x00012880 File Offset: 0x00010A80
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationEmperorAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_get_SnooperFaction_Protected_Virtual_get_Factions_0;
	}
}

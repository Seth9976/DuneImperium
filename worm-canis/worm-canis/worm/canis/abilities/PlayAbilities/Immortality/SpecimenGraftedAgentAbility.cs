using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x02000465 RID: 1125
	public class SpecimenGraftedAgentAbility : SpecimenAgentAbility
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x0012A694 File Offset: 0x00128894
		// Note: this type is marked as 'beforefieldinit'.
		static SpecimenGraftedAgentAbility()
		{
			Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "SpecimenGraftedAgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr);
			SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, "AbilityName");
			SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, "AbilityID");
			SpecimenGraftedAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, 100678635);
			SpecimenGraftedAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, 100678636);
			SpecimenGraftedAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, 100678637);
			SpecimenGraftedAgentAbility.NativeMethodInfoPtr_SpecimensToGain_Protected_Virtual_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr, 100678638);
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x0012A73C File Offset: 0x0012893C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228537, XrefRangeEnd = 228541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecimenGraftedAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0012A788 File Offset: 0x00128988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228541, XrefRangeEnd = 228548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecimenGraftedAgentAbility(WormMatch m, string abilityName = "SpecimenGraftedAgentAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecimenGraftedAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x0012A7E8 File Offset: 0x001289E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228548, XrefRangeEnd = 228555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecimenGraftedAgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecimenGraftedAgentAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecimenGraftedAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x0012A858 File Offset: 0x00128A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228555, XrefRangeEnd = 228559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SpecimensToGain(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecimenGraftedAgentAbility.NativeMethodInfoPtr_SpecimensToGain_Protected_Virtual_Int32_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x00011603 File Offset: 0x0000F803
		public SpecimenGraftedAgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0012A8B0 File Offset: 0x00128AB0
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x0001160C File Offset: 0x0000F80C
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0012A8D0 File Offset: 0x00128AD0
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0001161E File Offset: 0x0000F81E
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecimenGraftedAgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_SpecimensToGain_Protected_Virtual_Int32_WormPlayer_0;
	}
}

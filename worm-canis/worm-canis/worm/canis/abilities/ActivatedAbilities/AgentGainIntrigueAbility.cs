using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities
{
	// Token: 0x020004AE RID: 1198
	public class AgentGainIntrigueAbility : GainIntrigueAbility
	{
		// Token: 0x060035CD RID: 13773 RVA: 0x0013F72C File Offset: 0x0013D92C
		// Note: this type is marked as 'beforefieldinit'.
		static AgentGainIntrigueAbility()
		{
			Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities", "AgentGainIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr);
			AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr, "AbilityName");
			AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr, "AbilityID");
			AgentGainIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr, 100680309);
			AgentGainIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr, 100680310);
			AgentGainIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr, 100680311);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0013F7C0 File Offset: 0x0013D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243023, XrefRangeEnd = 243027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentGainIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x0013F80C File Offset: 0x0013DA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243027, XrefRangeEnd = 243040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentGainIntrigueAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentGainIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0013F858 File Offset: 0x0013DA58
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentGainIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentGainIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentGainIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000123A1 File Offset: 0x000105A1
		public AgentGainIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x0013F8C8 File Offset: 0x0013DAC8
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x000123AA File Offset: 0x000105AA
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x0013F8E8 File Offset: 0x0013DAE8
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x000123BC File Offset: 0x000105BC
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentGainIntrigueAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;
	}
}

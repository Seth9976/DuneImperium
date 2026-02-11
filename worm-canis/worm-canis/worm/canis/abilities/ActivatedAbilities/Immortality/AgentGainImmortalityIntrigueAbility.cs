using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities.Immortality
{
	// Token: 0x02000509 RID: 1289
	public class AgentGainImmortalityIntrigueAbility : GainImmortalityIntrigueAbility
	{
		// Token: 0x06003BB6 RID: 15286 RVA: 0x0015E7C8 File Offset: 0x0015C9C8
		// Note: this type is marked as 'beforefieldinit'.
		static AgentGainImmortalityIntrigueAbility()
		{
			Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Immortality", "AgentGainImmortalityIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr);
			AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr, "AbilityName");
			AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr, "AbilityID");
			AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr, 100682770);
			AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr, 100682771);
			AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr, 100682772);
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x0015E85C File Offset: 0x0015CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264991, XrefRangeEnd = 264995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x0015E8A8 File Offset: 0x0015CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264995, XrefRangeEnd = 265008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentGainImmortalityIntrigueAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x0015E8F4 File Offset: 0x0015CAF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentGainImmortalityIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentGainImmortalityIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00013597 File Offset: 0x00011797
		public AgentGainImmortalityIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003BBB RID: 15291 RVA: 0x0015E964 File Offset: 0x0015CB64
		// (set) Token: 0x06003BBC RID: 15292 RVA: 0x000135A0 File Offset: 0x000117A0
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003BBD RID: 15293 RVA: 0x0015E984 File Offset: 0x0015CB84
		// (set) Token: 0x06003BBE RID: 15294 RVA: 0x000135B2 File Offset: 0x000117B2
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;
	}
}

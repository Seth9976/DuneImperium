using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx
{
	// Token: 0x0200039A RID: 922
	public class OffWorldConflictSpaces : RuleModAbility
	{
		// Token: 0x06002671 RID: 9841 RVA: 0x000F42C0 File Offset: 0x000F24C0
		// Note: this type is marked as 'beforefieldinit'.
		static OffWorldConflictSpaces()
		{
			Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx", "OffWorldConflictSpaces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr);
			OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "AbilityName");
			OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "AbilityID");
			OffWorldConflictSpaces.NativeFieldInfoPtr_GainInfluenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "GainInfluenceState");
			OffWorldConflictSpaces.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674082);
			OffWorldConflictSpaces.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674083);
			OffWorldConflictSpaces.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674084);
			OffWorldConflictSpaces.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674085);
			OffWorldConflictSpaces.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674086);
			OffWorldConflictSpaces.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674087);
			OffWorldConflictSpaces.NativeMethodInfoPtr_GainInfluence_Protected_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, 100674088);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000F43B8 File Offset: 0x000F25B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192375, XrefRangeEnd = 192379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffWorldConflictSpaces.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000F4404 File Offset: 0x000F2604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192379, XrefRangeEnd = 192391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffWorldConflictSpaces(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000F4450 File Offset: 0x000F2650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192391, XrefRangeEnd = 192401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffWorldConflictSpaces(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000F44C0 File Offset: 0x000F26C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192401, XrefRangeEnd = 192408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffWorldConflictSpaces.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000F451C File Offset: 0x000F271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192408, XrefRangeEnd = 192423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffWorldConflictSpaces.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000F4598 File Offset: 0x000F2798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192423, XrefRangeEnd = 192430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffWorldConflictSpaces.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000F4618 File Offset: 0x000F2818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192430, XrefRangeEnd = 192437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> GainInfluence(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.NativeMethodInfoPtr_GainInfluence_Protected_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		public OffWorldConflictSpaces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000F468C File Offset: 0x000F288C
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0000EBDB File Offset: 0x0000CDDB
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x000F46AC File Offset: 0x000F28AC
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0000EBED File Offset: 0x0000CDED
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000F46D4 File Offset: 0x000F28D4
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0000EBFF File Offset: 0x0000CDFF
		public unsafe static int GainInfluenceState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.NativeFieldInfoPtr_GainInfluenceState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.NativeFieldInfoPtr_GainInfluenceState, (void*)(&value));
			}
		}

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_GainInfluenceState;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_GainInfluence_Protected_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000903 RID: 2307
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OffWorldConflictSpaces+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060088E0 RID: 35040 RVA: 0x00254924 File Offset: 0x00252B24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr);
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9");
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9__8_0");
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9__8_1");
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9__8_4");
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9__8_2");
				OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, "<>9__8_3");
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674091);
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674092);
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674093);
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_4_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674094);
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674095);
				OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_3_Internal_EntityID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr, 100674096);
			}

			// Token: 0x060088E1 RID: 35041 RVA: 0x00254A40 File Offset: 0x00252C40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060088E2 RID: 35042 RVA: 0x00254A7C File Offset: 0x00252C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192016, XrefRangeEnd = 192032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060088E3 RID: 35043 RVA: 0x00254ACC File Offset: 0x00252CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192032, XrefRangeEnd = 192043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060088E4 RID: 35044 RVA: 0x00254B1C File Offset: 0x00252D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192043, XrefRangeEnd = 192044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_4(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_4_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060088E5 RID: 35045 RVA: 0x00254B6C File Offset: 0x00252D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060088E6 RID: 35046 RVA: 0x00254BBC File Offset: 0x00252DBC
			[CallerCount(0)]
			public unsafe EntityID _BeginExecution_b__8_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces.__c.NativeMethodInfoPtr__BeginExecution_b__8_3_Internal_EntityID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060088E7 RID: 35047 RVA: 0x0003A238 File Offset: 0x00038438
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027A0 RID: 10144
			// (get) Token: 0x060088E8 RID: 35048 RVA: 0x00254C0C File Offset: 0x00252E0C
			// (set) Token: 0x060088E9 RID: 35049 RVA: 0x0003A241 File Offset: 0x00038441
			public unsafe static OffWorldConflictSpaces.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OffWorldConflictSpaces.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A1 RID: 10145
			// (get) Token: 0x060088EA RID: 35050 RVA: 0x00254C34 File Offset: 0x00252E34
			// (set) Token: 0x060088EB RID: 35051 RVA: 0x0003A253 File Offset: 0x00038453
			public unsafe static Func<WormSpace, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A2 RID: 10146
			// (get) Token: 0x060088EC RID: 35052 RVA: 0x00254C5C File Offset: 0x00252E5C
			// (set) Token: 0x060088ED RID: 35053 RVA: 0x0003A265 File Offset: 0x00038465
			public unsafe static Func<WormSpace, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A3 RID: 10147
			// (get) Token: 0x060088EE RID: 35054 RVA: 0x00254C84 File Offset: 0x00252E84
			// (set) Token: 0x060088EF RID: 35055 RVA: 0x0003A277 File Offset: 0x00038477
			public unsafe static Func<WormAbilityDefinition, bool> __9__8_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A4 RID: 10148
			// (get) Token: 0x060088F0 RID: 35056 RVA: 0x00254CAC File Offset: 0x00252EAC
			// (set) Token: 0x060088F1 RID: 35057 RVA: 0x0003A289 File Offset: 0x00038489
			public unsafe static Func<WormPlayer, bool> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A5 RID: 10149
			// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00254CD4 File Offset: 0x00252ED4
			// (set) Token: 0x060088F3 RID: 35059 RVA: 0x0003A29B File Offset: 0x0003849B
			public unsafe static Func<WormPlayer, EntityID> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OffWorldConflictSpaces.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005787 RID: 22407
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005788 RID: 22408
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04005789 RID: 22409
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400578A RID: 22410
			private static readonly IntPtr NativeFieldInfoPtr___9__8_4;

			// Token: 0x0400578B RID: 22411
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x0400578C RID: 22412
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x0400578D RID: 22413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400578E RID: 22414
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_WormSpace_0;

			// Token: 0x0400578F RID: 22415
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_WormSpace_0;

			// Token: 0x04005790 RID: 22416
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_4_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04005791 RID: 22417
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x04005792 RID: 22418
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_3_Internal_EntityID_WormPlayer_0;
		}

		// Token: 0x02000904 RID: 2308
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OffWorldConflictSpaces+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x060088F4 RID: 35060 RVA: 0x00254CFC File Offset: 0x00252EFC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "match");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>7__wrap1");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr__space_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<space>5__3");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, "<>7__wrap3");
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674097);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674098);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674099);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674100);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674101);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674102);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674103);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674104);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674105);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674106);
				OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr, 100674107);
			}

			// Token: 0x060088F5 RID: 35061 RVA: 0x00254ECC File Offset: 0x002530CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060088F6 RID: 35062 RVA: 0x00254F14 File Offset: 0x00253114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192044, XrefRangeEnd = 192064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060088F7 RID: 35063 RVA: 0x00254F48 File Offset: 0x00253148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192064, XrefRangeEnd = 192287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060088F8 RID: 35064 RVA: 0x00254F84 File Offset: 0x00253184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192287, XrefRangeEnd = 192290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060088F9 RID: 35065 RVA: 0x00254FB8 File Offset: 0x002531B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192290, XrefRangeEnd = 192293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060088FA RID: 35066 RVA: 0x00254FEC File Offset: 0x002531EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192293, XrefRangeEnd = 192296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170027B0 RID: 10160
			// (get) Token: 0x060088FB RID: 35067 RVA: 0x00255020 File Offset: 0x00253220
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060088FC RID: 35068 RVA: 0x00255060 File Offset: 0x00253260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192296, XrefRangeEnd = 192301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170027B1 RID: 10161
			// (get) Token: 0x060088FD RID: 35069 RVA: 0x00255094 File Offset: 0x00253294
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060088FE RID: 35070 RVA: 0x002550D4 File Offset: 0x002532D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192301, XrefRangeEnd = 192310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060088FF RID: 35071 RVA: 0x00255114 File Offset: 0x00253314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008900 RID: 35072 RVA: 0x0003A2AD File Offset: 0x000384AD
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027A6 RID: 10150
			// (get) Token: 0x06008901 RID: 35073 RVA: 0x00255154 File Offset: 0x00253354
			// (set) Token: 0x06008902 RID: 35074 RVA: 0x0003A2B6 File Offset: 0x000384B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170027A7 RID: 10151
			// (get) Token: 0x06008903 RID: 35075 RVA: 0x0025517C File Offset: 0x0025337C
			// (set) Token: 0x06008904 RID: 35076 RVA: 0x0003A2D1 File Offset: 0x000384D1
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027A8 RID: 10152
			// (get) Token: 0x06008905 RID: 35077 RVA: 0x002551AC File Offset: 0x002533AC
			// (set) Token: 0x06008906 RID: 35078 RVA: 0x0003A2F0 File Offset: 0x000384F0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170027A9 RID: 10153
			// (get) Token: 0x06008907 RID: 35079 RVA: 0x002551D4 File Offset: 0x002533D4
			// (set) Token: 0x06008908 RID: 35080 RVA: 0x0003A30B File Offset: 0x0003850B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AA RID: 10154
			// (get) Token: 0x06008909 RID: 35081 RVA: 0x00255204 File Offset: 0x00253404
			// (set) Token: 0x0600890A RID: 35082 RVA: 0x0003A32A File Offset: 0x0003852A
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AB RID: 10155
			// (get) Token: 0x0600890B RID: 35083 RVA: 0x00255234 File Offset: 0x00253434
			// (set) Token: 0x0600890C RID: 35084 RVA: 0x0003A349 File Offset: 0x00038549
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AC RID: 10156
			// (get) Token: 0x0600890D RID: 35085 RVA: 0x00255264 File Offset: 0x00253464
			// (set) Token: 0x0600890E RID: 35086 RVA: 0x0003A368 File Offset: 0x00038568
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AD RID: 10157
			// (get) Token: 0x0600890F RID: 35087 RVA: 0x00255294 File Offset: 0x00253494
			// (set) Token: 0x06008910 RID: 35088 RVA: 0x0003A387 File Offset: 0x00038587
			public unsafe IEnumerator<WormSpace> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormSpace>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AE RID: 10158
			// (get) Token: 0x06008911 RID: 35089 RVA: 0x002552C4 File Offset: 0x002534C4
			// (set) Token: 0x06008912 RID: 35090 RVA: 0x0003A3A6 File Offset: 0x000385A6
			public unsafe WormSpace _space_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr__space_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr__space_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027AF RID: 10159
			// (get) Token: 0x06008913 RID: 35091 RVA: 0x002552F4 File Offset: 0x002534F4
			// (set) Token: 0x06008914 RID: 35092 RVA: 0x0003A3C5 File Offset: 0x000385C5
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005793 RID: 22419
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005794 RID: 22420
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005795 RID: 22421
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005796 RID: 22422
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005797 RID: 22423
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005798 RID: 22424
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005799 RID: 22425
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400579A RID: 22426
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400579B RID: 22427
			private static readonly IntPtr NativeFieldInfoPtr__space_5__3;

			// Token: 0x0400579C RID: 22428
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400579D RID: 22429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400579E RID: 22430
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400579F RID: 22431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040057A0 RID: 22432
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040057A1 RID: 22433
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040057A2 RID: 22434
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040057A3 RID: 22435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040057A4 RID: 22436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057A5 RID: 22437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040057A6 RID: 22438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040057A7 RID: 22439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000905 RID: 2309
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OffWorldConflictSpaces+<GainInfluence>d__9")]
		public sealed class _GainInfluence_d__9 : Object
		{
			// Token: 0x06008915 RID: 35093 RVA: 0x00255324 File Offset: 0x00253524
			// Note: this type is marked as 'beforefieldinit'.
			static _GainInfluence_d__9()
			{
				Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "<GainInfluence>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<>1__state");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<>2__current");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<>l__initialThreadId");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "activeAbility");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<>3__activeAbility");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "match");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<>3__match");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, "<player>5__2");
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674108);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674109);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674110);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674111);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674112);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674113);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674114);
				OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr, 100674115);
			}

			// Token: 0x06008916 RID: 35094 RVA: 0x00255490 File Offset: 0x00253690
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GainInfluence_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces._GainInfluence_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008917 RID: 35095 RVA: 0x002554D8 File Offset: 0x002536D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008918 RID: 35096 RVA: 0x0025550C File Offset: 0x0025370C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192310, XrefRangeEnd = 192340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170027BA RID: 10170
			// (get) Token: 0x06008919 RID: 35097 RVA: 0x00255548 File Offset: 0x00253748
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600891A RID: 35098 RVA: 0x00255588 File Offset: 0x00253788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192340, XrefRangeEnd = 192345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170027BB RID: 10171
			// (get) Token: 0x0600891B RID: 35099 RVA: 0x002555BC File Offset: 0x002537BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600891C RID: 35100 RVA: 0x002555FC File Offset: 0x002537FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192345, XrefRangeEnd = 192354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600891D RID: 35101 RVA: 0x0025563C File Offset: 0x0025383C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._GainInfluence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600891E RID: 35102 RVA: 0x0003A3E4 File Offset: 0x000385E4
			public _GainInfluence_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027B2 RID: 10162
			// (get) Token: 0x0600891F RID: 35103 RVA: 0x0025567C File Offset: 0x0025387C
			// (set) Token: 0x06008920 RID: 35104 RVA: 0x0003A3ED File Offset: 0x000385ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170027B3 RID: 10163
			// (get) Token: 0x06008921 RID: 35105 RVA: 0x002556A4 File Offset: 0x002538A4
			// (set) Token: 0x06008922 RID: 35106 RVA: 0x0003A408 File Offset: 0x00038608
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027B4 RID: 10164
			// (get) Token: 0x06008923 RID: 35107 RVA: 0x002556D4 File Offset: 0x002538D4
			// (set) Token: 0x06008924 RID: 35108 RVA: 0x0003A427 File Offset: 0x00038627
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170027B5 RID: 10165
			// (get) Token: 0x06008925 RID: 35109 RVA: 0x002556FC File Offset: 0x002538FC
			// (set) Token: 0x06008926 RID: 35110 RVA: 0x0003A442 File Offset: 0x00038642
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027B6 RID: 10166
			// (get) Token: 0x06008927 RID: 35111 RVA: 0x0025572C File Offset: 0x0025392C
			// (set) Token: 0x06008928 RID: 35112 RVA: 0x0003A461 File Offset: 0x00038661
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027B7 RID: 10167
			// (get) Token: 0x06008929 RID: 35113 RVA: 0x0025575C File Offset: 0x0025395C
			// (set) Token: 0x0600892A RID: 35114 RVA: 0x0003A480 File Offset: 0x00038680
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027B8 RID: 10168
			// (get) Token: 0x0600892B RID: 35115 RVA: 0x0025578C File Offset: 0x0025398C
			// (set) Token: 0x0600892C RID: 35116 RVA: 0x0003A49F File Offset: 0x0003869F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027B9 RID: 10169
			// (get) Token: 0x0600892D RID: 35117 RVA: 0x002557BC File Offset: 0x002539BC
			// (set) Token: 0x0600892E RID: 35118 RVA: 0x0003A4BE File Offset: 0x000386BE
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._GainInfluence_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057A8 RID: 22440
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040057A9 RID: 22441
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040057AA RID: 22442
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040057AB RID: 22443
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040057AC RID: 22444
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040057AD RID: 22445
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040057AE RID: 22446
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040057AF RID: 22447
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040057B0 RID: 22448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040057B1 RID: 22449
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057B2 RID: 22450
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040057B3 RID: 22451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040057B4 RID: 22452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057B5 RID: 22453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040057B6 RID: 22454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040057B7 RID: 22455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000906 RID: 2310
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OffWorldConflictSpaces+<IsValidFor>d__6")]
		public sealed class _IsValidFor_d__6 : Object
		{
			// Token: 0x0600892F RID: 35119 RVA: 0x002557EC File Offset: 0x002539EC
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__6()
			{
				Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OffWorldConflictSpaces>.NativeClassPtr, "<IsValidFor>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "<>1__state");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "<>2__current");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "<>l__initialThreadId");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "evt");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "<>3__evt");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, "<>4__this");
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674116);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674117);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674118);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674119);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674120);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674121);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674122);
				OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr, 100674123);
			}

			// Token: 0x06008930 RID: 35120 RVA: 0x00255930 File Offset: 0x00253B30
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffWorldConflictSpaces._IsValidFor_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008931 RID: 35121 RVA: 0x00255978 File Offset: 0x00253B78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008932 RID: 35122 RVA: 0x002559AC File Offset: 0x00253BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192354, XrefRangeEnd = 192361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170027C2 RID: 10178
			// (get) Token: 0x06008933 RID: 35123 RVA: 0x002559E8 File Offset: 0x00253BE8
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06008934 RID: 35124 RVA: 0x00255A28 File Offset: 0x00253C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192361, XrefRangeEnd = 192366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170027C3 RID: 10179
			// (get) Token: 0x06008935 RID: 35125 RVA: 0x00255A5C File Offset: 0x00253C5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008936 RID: 35126 RVA: 0x00255A9C File Offset: 0x00253C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192366, XrefRangeEnd = 192375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008937 RID: 35127 RVA: 0x00255ADC File Offset: 0x00253CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffWorldConflictSpaces._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008938 RID: 35128 RVA: 0x0003A4DD File Offset: 0x000386DD
			public _IsValidFor_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027BC RID: 10172
			// (get) Token: 0x06008939 RID: 35129 RVA: 0x00255B1C File Offset: 0x00253D1C
			// (set) Token: 0x0600893A RID: 35130 RVA: 0x0003A4E6 File Offset: 0x000386E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170027BD RID: 10173
			// (get) Token: 0x0600893B RID: 35131 RVA: 0x00255B44 File Offset: 0x00253D44
			// (set) Token: 0x0600893C RID: 35132 RVA: 0x0003A501 File Offset: 0x00038701
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027BE RID: 10174
			// (get) Token: 0x0600893D RID: 35133 RVA: 0x00255B74 File Offset: 0x00253D74
			// (set) Token: 0x0600893E RID: 35134 RVA: 0x0003A520 File Offset: 0x00038720
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170027BF RID: 10175
			// (get) Token: 0x0600893F RID: 35135 RVA: 0x00255B9C File Offset: 0x00253D9C
			// (set) Token: 0x06008940 RID: 35136 RVA: 0x0003A53B File Offset: 0x0003873B
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027C0 RID: 10176
			// (get) Token: 0x06008941 RID: 35137 RVA: 0x00255BCC File Offset: 0x00253DCC
			// (set) Token: 0x06008942 RID: 35138 RVA: 0x0003A55A File Offset: 0x0003875A
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027C1 RID: 10177
			// (get) Token: 0x06008943 RID: 35139 RVA: 0x00255BFC File Offset: 0x00253DFC
			// (set) Token: 0x06008944 RID: 35140 RVA: 0x0003A579 File Offset: 0x00038779
			public unsafe OffWorldConflictSpaces __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OffWorldConflictSpaces>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffWorldConflictSpaces._IsValidFor_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057B8 RID: 22456
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040057B9 RID: 22457
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040057BA RID: 22458
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040057BB RID: 22459
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040057BC RID: 22460
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x040057BD RID: 22461
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040057BE RID: 22462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040057BF RID: 22463
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057C0 RID: 22464
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040057C1 RID: 22465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x040057C2 RID: 22466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057C3 RID: 22467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040057C4 RID: 22468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x040057C5 RID: 22469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

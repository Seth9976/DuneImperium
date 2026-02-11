using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.Immortality
{
	// Token: 0x02000505 RID: 1285
	public class FamilyAtomicsAbility : DeferredAbility
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x0015D0E8 File Offset: 0x0015B2E8
		// Note: this type is marked as 'beforefieldinit'.
		static FamilyAtomicsAbility()
		{
			Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Immortality", "FamilyAtomicsAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr);
			FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "AbilityName");
			FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "AbilityID");
			FamilyAtomicsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682635);
			FamilyAtomicsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682636);
			FamilyAtomicsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682637);
			FamilyAtomicsAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682638);
			FamilyAtomicsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682639);
			FamilyAtomicsAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682640);
			FamilyAtomicsAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682641);
			FamilyAtomicsAbility.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682642);
			FamilyAtomicsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682643);
			FamilyAtomicsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682644);
			FamilyAtomicsAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, 100682645);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0015D21C File Offset: 0x0015B41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263996, XrefRangeEnd = 264000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x0015D268 File Offset: 0x0015B468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264000, XrefRangeEnd = 264020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FamilyAtomicsAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x0015D2B4 File Offset: 0x0015B4B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FamilyAtomicsAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x0015D324 File Offset: 0x0015B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264020, XrefRangeEnd = 264025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x0015D394 File Offset: 0x0015B594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264025, XrefRangeEnd = 264041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x0015D404 File Offset: 0x0015B604
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x0015D45C File Offset: 0x0015B65C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsUnexhausted(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x0015D4B4 File Offset: 0x0015B6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264041, XrefRangeEnd = 264048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0015D518 File Offset: 0x0015B718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264048, XrefRangeEnd = 264057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x0015D598 File Offset: 0x0015B798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x0015D614 File Offset: 0x0015B814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264057, XrefRangeEnd = 264136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FamilyAtomicsAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x000134C8 File Offset: 0x000116C8
		public FamilyAtomicsAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x0015D670 File Offset: 0x0015B870
		// (set) Token: 0x06003B80 RID: 15232 RVA: 0x000134D1 File Offset: 0x000116D1
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x0015D690 File Offset: 0x0015B890
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x000134E3 File Offset: 0x000116E3
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FamilyAtomicsAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000C4F RID: 3151
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.FamilyAtomicsAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600CB5C RID: 52060 RVA: 0x00316688 File Offset: 0x00314888
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr);
				FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, "<>9");
				FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, "<>9__9_0");
				FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, "<>9__12_1");
				FamilyAtomicsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, 100682648);
				FamilyAtomicsAbility.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__9_0_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, 100682649);
				FamilyAtomicsAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_1_Internal_Int32_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr, 100682650);
			}

			// Token: 0x0600CB5D RID: 52061 RVA: 0x0031672C File Offset: 0x0031492C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB5E RID: 52062 RVA: 0x00316768 File Offset: 0x00314968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _MakeAnalyticsData_b__9_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__9_0_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB5F RID: 52063 RVA: 0x003167B8 File Offset: 0x003149B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263586, XrefRangeEnd = 263594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__12_1(WormImperiumPlayable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_1_Internal_Int32_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CB60 RID: 52064 RVA: 0x000607A1 File Offset: 0x0005E9A1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003FA2 RID: 16290
			// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00316808 File Offset: 0x00314A08
			// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x000607AA File Offset: 0x0005E9AA
			public unsafe static FamilyAtomicsAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FamilyAtomicsAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA3 RID: 16291
			// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00316830 File Offset: 0x00314A30
			// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x000607BC File Offset: 0x0005E9BC
			public unsafe static Func<Entity, ArchetypeID> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA4 RID: 16292
			// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00316858 File Offset: 0x00314A58
			// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x000607CE File Offset: 0x0005E9CE
			public unsafe static Func<WormImperiumPlayable, int> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FamilyAtomicsAbility.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F47 RID: 32583
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007F48 RID: 32584
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04007F49 RID: 32585
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04007F4A RID: 32586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F4B RID: 32587
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__9_0_Internal_ArchetypeID_Entity_0;

			// Token: 0x04007F4C RID: 32588
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_1_Internal_Int32_WormImperiumPlayable_0;
		}

		// Token: 0x02000C50 RID: 3152
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.FamilyAtomicsAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600CB67 RID: 52071 RVA: 0x00316880 File Offset: 0x00314A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr);
				FamilyAtomicsAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr, "context");
				FamilyAtomicsAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr, 100682651);
				FamilyAtomicsAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr, 100682652);
			}

			// Token: 0x0600CB68 RID: 52072 RVA: 0x003168E8 File Offset: 0x00314AE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB69 RID: 52073 RVA: 0x00316924 File Offset: 0x00314B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263594, XrefRangeEnd = 263599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__0(WormImperiumPlayable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CB6A RID: 52074 RVA: 0x000607E0 File Offset: 0x0005E9E0
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003FA5 RID: 16293
			// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x00316974 File Offset: 0x00314B74
			// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x000607E9 File Offset: 0x0005E9E9
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F4D RID: 32589
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007F4E RID: 32590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F4F RID: 32591
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0;
		}

		// Token: 0x02000C51 RID: 3153
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.FamilyAtomicsAbility+<BeginExecution>d__10")]
		public sealed class _BeginExecution_d__10 : Object
		{
			// Token: 0x0600CB6D RID: 52077 RVA: 0x003169A4 File Offset: 0x00314BA4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__10()
			{
				Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "<BeginExecution>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>1__state");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>2__current");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>l__initialThreadId");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "activeAbility");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>3__activeAbility");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "context");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>3__context");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "match");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>3__match");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>4__this");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<player>5__2");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__oldImperiumCards_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<oldImperiumCards>5__3");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__logBuilder_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<logBuilder>5__4");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<sequenceHelper>5__5");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<>7__wrap5");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__card_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<card>5__7");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__x_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, "<x>5__8");
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682653);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682654);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682655);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682656);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682657);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682658);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682659);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682660);
				FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr, 100682661);
			}

			// Token: 0x0600CB6E RID: 52078 RVA: 0x00316BD8 File Offset: 0x00314DD8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility._BeginExecution_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CB6F RID: 52079 RVA: 0x00316C20 File Offset: 0x00314E20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263604, RefRangeEnd = 263605, XrefRangeStart = 263599, XrefRangeEnd = 263604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB70 RID: 52080 RVA: 0x00316C54 File Offset: 0x00314E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263605, XrefRangeEnd = 263852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB71 RID: 52081 RVA: 0x00316C90 File Offset: 0x00314E90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263855, RefRangeEnd = 263856, XrefRangeStart = 263852, XrefRangeEnd = 263855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FB7 RID: 16311
			// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x00316CC4 File Offset: 0x00314EC4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB73 RID: 52083 RVA: 0x00316D04 File Offset: 0x00314F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263856, XrefRangeEnd = 263861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FB8 RID: 16312
			// (get) Token: 0x0600CB74 RID: 52084 RVA: 0x00316D38 File Offset: 0x00314F38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB75 RID: 52085 RVA: 0x00316D78 File Offset: 0x00314F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263861, XrefRangeEnd = 263872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600CB76 RID: 52086 RVA: 0x00316DB8 File Offset: 0x00314FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CB77 RID: 52087 RVA: 0x00060808 File Offset: 0x0005EA08
			public _BeginExecution_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003FA6 RID: 16294
			// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x00316DF8 File Offset: 0x00314FF8
			// (set) Token: 0x0600CB79 RID: 52089 RVA: 0x00060811 File Offset: 0x0005EA11
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FA7 RID: 16295
			// (get) Token: 0x0600CB7A RID: 52090 RVA: 0x00316E20 File Offset: 0x00315020
			// (set) Token: 0x0600CB7B RID: 52091 RVA: 0x0006082C File Offset: 0x0005EA2C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA8 RID: 16296
			// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x00316E50 File Offset: 0x00315050
			// (set) Token: 0x0600CB7D RID: 52093 RVA: 0x0006084B File Offset: 0x0005EA4B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003FA9 RID: 16297
			// (get) Token: 0x0600CB7E RID: 52094 RVA: 0x00316E78 File Offset: 0x00315078
			// (set) Token: 0x0600CB7F RID: 52095 RVA: 0x00060866 File Offset: 0x0005EA66
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAA RID: 16298
			// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x00316EA8 File Offset: 0x003150A8
			// (set) Token: 0x0600CB81 RID: 52097 RVA: 0x00060885 File Offset: 0x0005EA85
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAB RID: 16299
			// (get) Token: 0x0600CB82 RID: 52098 RVA: 0x00316ED8 File Offset: 0x003150D8
			// (set) Token: 0x0600CB83 RID: 52099 RVA: 0x000608A4 File Offset: 0x0005EAA4
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAC RID: 16300
			// (get) Token: 0x0600CB84 RID: 52100 RVA: 0x00316F08 File Offset: 0x00315108
			// (set) Token: 0x0600CB85 RID: 52101 RVA: 0x000608C3 File Offset: 0x0005EAC3
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAD RID: 16301
			// (get) Token: 0x0600CB86 RID: 52102 RVA: 0x00316F38 File Offset: 0x00315138
			// (set) Token: 0x0600CB87 RID: 52103 RVA: 0x000608E2 File Offset: 0x0005EAE2
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAE RID: 16302
			// (get) Token: 0x0600CB88 RID: 52104 RVA: 0x00316F68 File Offset: 0x00315168
			// (set) Token: 0x0600CB89 RID: 52105 RVA: 0x00060901 File Offset: 0x0005EB01
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAF RID: 16303
			// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x00316F98 File Offset: 0x00315198
			// (set) Token: 0x0600CB8B RID: 52107 RVA: 0x00060920 File Offset: 0x0005EB20
			public unsafe FamilyAtomicsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FamilyAtomicsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB0 RID: 16304
			// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x00316FC8 File Offset: 0x003151C8
			// (set) Token: 0x0600CB8D RID: 52109 RVA: 0x0006093F File Offset: 0x0005EB3F
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB1 RID: 16305
			// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x00316FF8 File Offset: 0x003151F8
			// (set) Token: 0x0600CB8F RID: 52111 RVA: 0x0006095E File Offset: 0x0005EB5E
			public unsafe List<Entity> _oldImperiumCards_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__oldImperiumCards_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__oldImperiumCards_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB2 RID: 16306
			// (get) Token: 0x0600CB90 RID: 52112 RVA: 0x00317028 File Offset: 0x00315228
			// (set) Token: 0x0600CB91 RID: 52113 RVA: 0x0006097D File Offset: 0x0005EB7D
			public unsafe GameLogBuilder _logBuilder_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__logBuilder_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__logBuilder_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB3 RID: 16307
			// (get) Token: 0x0600CB92 RID: 52114 RVA: 0x00317058 File Offset: 0x00315258
			// (set) Token: 0x0600CB93 RID: 52115 RVA: 0x0006099C File Offset: 0x0005EB9C
			public unsafe SequenceHelper _sequenceHelper_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB4 RID: 16308
			// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x00317088 File Offset: 0x00315288
			// (set) Token: 0x0600CB95 RID: 52117 RVA: 0x000609BB File Offset: 0x0005EBBB
			public List<Entity>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5);
					return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003FB5 RID: 16309
			// (get) Token: 0x0600CB96 RID: 52118 RVA: 0x003170B8 File Offset: 0x003152B8
			// (set) Token: 0x0600CB97 RID: 52119 RVA: 0x000609E9 File Offset: 0x0005EBE9
			public unsafe Entity _card_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__card_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__card_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB6 RID: 16310
			// (get) Token: 0x0600CB98 RID: 52120 RVA: 0x003170E8 File Offset: 0x003152E8
			// (set) Token: 0x0600CB99 RID: 52121 RVA: 0x00060A08 File Offset: 0x0005EC08
			public unsafe int _x_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__x_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._BeginExecution_d__10.NativeFieldInfoPtr__x_5__8)) = value;
				}
			}

			// Token: 0x04007F50 RID: 32592
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F51 RID: 32593
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F52 RID: 32594
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F53 RID: 32595
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007F54 RID: 32596
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007F55 RID: 32597
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007F56 RID: 32598
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007F57 RID: 32599
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007F58 RID: 32600
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007F59 RID: 32601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007F5A RID: 32602
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04007F5B RID: 32603
			private static readonly IntPtr NativeFieldInfoPtr__oldImperiumCards_5__3;

			// Token: 0x04007F5C RID: 32604
			private static readonly IntPtr NativeFieldInfoPtr__logBuilder_5__4;

			// Token: 0x04007F5D RID: 32605
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__5;

			// Token: 0x04007F5E RID: 32606
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04007F5F RID: 32607
			private static readonly IntPtr NativeFieldInfoPtr__card_5__7;

			// Token: 0x04007F60 RID: 32608
			private static readonly IntPtr NativeFieldInfoPtr__x_5__8;

			// Token: 0x04007F61 RID: 32609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F62 RID: 32610
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F63 RID: 32611
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F64 RID: 32612
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007F65 RID: 32613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007F66 RID: 32614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F67 RID: 32615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F68 RID: 32616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007F69 RID: 32617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000C52 RID: 3154
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.FamilyAtomicsAbility+<MakeAnalyticsData>d__9")]
		public sealed class _MakeAnalyticsData_d__9 : Object
		{
			// Token: 0x0600CB9A RID: 52122 RVA: 0x00317110 File Offset: 0x00315310
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__9()
			{
				Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "<MakeAnalyticsData>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "<>1__state");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "<>2__current");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "<>l__initialThreadId");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "player");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__player");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "wormMatch");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__wormMatch");
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682662);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682663);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682664);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682665);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682666);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682667);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682668);
				FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr, 100682669);
			}

			// Token: 0x0600CB9B RID: 52123 RVA: 0x00317268 File Offset: 0x00315468
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility._MakeAnalyticsData_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CB9C RID: 52124 RVA: 0x003172B0 File Offset: 0x003154B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB9D RID: 52125 RVA: 0x003172E4 File Offset: 0x003154E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263872, XrefRangeEnd = 263890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FC0 RID: 16320
			// (get) Token: 0x0600CB9E RID: 52126 RVA: 0x00317320 File Offset: 0x00315520
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x0600CB9F RID: 52127 RVA: 0x00317358 File Offset: 0x00315558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263890, XrefRangeEnd = 263895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0600CBA0 RID: 52128 RVA: 0x0031738C File Offset: 0x0031558C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263895, XrefRangeEnd = 263898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBA1 RID: 52129 RVA: 0x003173CC File Offset: 0x003155CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263898, XrefRangeEnd = 263907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x0600CBA2 RID: 52130 RVA: 0x0031740C File Offset: 0x0031560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CBA3 RID: 52131 RVA: 0x00060A23 File Offset: 0x0005EC23
			public _MakeAnalyticsData_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003FB9 RID: 16313
			// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x0031744C File Offset: 0x0031564C
			// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x00060A2C File Offset: 0x0005EC2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FBA RID: 16314
			// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x00317474 File Offset: 0x00315674
			// (set) Token: 0x0600CBA7 RID: 52135 RVA: 0x00060A47 File Offset: 0x0005EC47
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003FBB RID: 16315
			// (get) Token: 0x0600CBA8 RID: 52136 RVA: 0x003174A4 File Offset: 0x003156A4
			// (set) Token: 0x0600CBA9 RID: 52137 RVA: 0x00060A75 File Offset: 0x0005EC75
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003FBC RID: 16316
			// (get) Token: 0x0600CBAA RID: 52138 RVA: 0x003174CC File Offset: 0x003156CC
			// (set) Token: 0x0600CBAB RID: 52139 RVA: 0x00060A90 File Offset: 0x0005EC90
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBD RID: 16317
			// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x003174FC File Offset: 0x003156FC
			// (set) Token: 0x0600CBAD RID: 52141 RVA: 0x00060AAF File Offset: 0x0005ECAF
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBE RID: 16318
			// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x0031752C File Offset: 0x0031572C
			// (set) Token: 0x0600CBAF RID: 52143 RVA: 0x00060ACE File Offset: 0x0005ECCE
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBF RID: 16319
			// (get) Token: 0x0600CBB0 RID: 52144 RVA: 0x0031755C File Offset: 0x0031575C
			// (set) Token: 0x0600CBB1 RID: 52145 RVA: 0x00060AED File Offset: 0x0005ECED
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F6A RID: 32618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F6B RID: 32619
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F6C RID: 32620
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F6D RID: 32621
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007F6E RID: 32622
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04007F6F RID: 32623
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04007F70 RID: 32624
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04007F71 RID: 32625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F72 RID: 32626
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F73 RID: 32627
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F74 RID: 32628
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04007F75 RID: 32629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F76 RID: 32630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F77 RID: 32631
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04007F78 RID: 32632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000C53 RID: 3155
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.FamilyAtomicsAbility+<Targets>d__5")]
		public sealed class _Targets_d__5 : Object
		{
			// Token: 0x0600CBB2 RID: 52146 RVA: 0x0031758C File Offset: 0x0031578C
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__5()
			{
				Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FamilyAtomicsAbility>.NativeClassPtr, "<Targets>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr);
				FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, "<>1__state");
				FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, "<>2__current");
				FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, "<>l__initialThreadId");
				FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, "context");
				FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, "<>3__context");
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682670);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682671);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682672);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682673);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682674);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682675);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682676);
				FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr, 100682677);
			}

			// Token: 0x0600CBB3 RID: 52147 RVA: 0x003176BC File Offset: 0x003158BC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FamilyAtomicsAbility._Targets_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CBB4 RID: 52148 RVA: 0x00317704 File Offset: 0x00315904
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBB5 RID: 52149 RVA: 0x00317738 File Offset: 0x00315938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263907, XrefRangeEnd = 263983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FC7 RID: 16327
			// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x00317774 File Offset: 0x00315974
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBB7 RID: 52151 RVA: 0x003177B4 File Offset: 0x003159B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263983, XrefRangeEnd = 263988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FC8 RID: 16328
			// (get) Token: 0x0600CBB8 RID: 52152 RVA: 0x003177E8 File Offset: 0x003159E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBB9 RID: 52153 RVA: 0x00317828 File Offset: 0x00315A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263988, XrefRangeEnd = 263996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600CBBA RID: 52154 RVA: 0x00317868 File Offset: 0x00315A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FamilyAtomicsAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CBBB RID: 52155 RVA: 0x00060B0C File Offset: 0x0005ED0C
			public _Targets_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0600CBBC RID: 52156 RVA: 0x003178A8 File Offset: 0x00315AA8
			// (set) Token: 0x0600CBBD RID: 52157 RVA: 0x00060B15 File Offset: 0x0005ED15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FC3 RID: 16323
			// (get) Token: 0x0600CBBE RID: 52158 RVA: 0x003178D0 File Offset: 0x00315AD0
			// (set) Token: 0x0600CBBF RID: 52159 RVA: 0x00060B30 File Offset: 0x0005ED30
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC4 RID: 16324
			// (get) Token: 0x0600CBC0 RID: 52160 RVA: 0x00317900 File Offset: 0x00315B00
			// (set) Token: 0x0600CBC1 RID: 52161 RVA: 0x00060B4F File Offset: 0x0005ED4F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x00317928 File Offset: 0x00315B28
			// (set) Token: 0x0600CBC3 RID: 52163 RVA: 0x00060B6A File Offset: 0x0005ED6A
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC6 RID: 16326
			// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x00317958 File Offset: 0x00315B58
			// (set) Token: 0x0600CBC5 RID: 52165 RVA: 0x00060B89 File Offset: 0x0005ED89
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FamilyAtomicsAbility._Targets_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F79 RID: 32633
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F7A RID: 32634
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F7B RID: 32635
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F7C RID: 32636
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007F7D RID: 32637
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007F7E RID: 32638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F7F RID: 32639
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F80 RID: 32640
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F81 RID: 32641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04007F82 RID: 32642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F83 RID: 32643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F84 RID: 32644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04007F85 RID: 32645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004C7 RID: 1223
	public class AppropriateAbility : DeferredAbility
	{
		// Token: 0x06003726 RID: 14118 RVA: 0x00146220 File Offset: 0x00144420
		// Note: this type is marked as 'beforefieldinit'.
		static AppropriateAbility()
		{
			Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "AppropriateAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr);
			AppropriateAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "AbilityName");
			AppropriateAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "AbilityID");
			AppropriateAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680764);
			AppropriateAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680765);
			AppropriateAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680766);
			AppropriateAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680767);
			AppropriateAbility.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680768);
			AppropriateAbility.NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680769);
			AppropriateAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680770);
			AppropriateAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680771);
			AppropriateAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680772);
			AppropriateAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680773);
			AppropriateAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680774);
			AppropriateAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680775);
			AppropriateAbility.NativeMethodInfoPtr_GetCustomChoiceFilter_Private_Static_Dictionary_2_EntityID_Il2CppStructArray_1_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680776);
			AppropriateAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680777);
			AppropriateAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, 100680778);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x001463A4 File Offset: 0x001445A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246617, XrefRangeEnd = 246621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x001463F0 File Offset: 0x001445F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246621, XrefRangeEnd = 246631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0014644C File Offset: 0x0014464C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246631, XrefRangeEnd = 246642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppropriateAbility(WormMatch m, string abilityName = "AppropriateAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x001464AC File Offset: 0x001446AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppropriateAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0014651C File Offset: 0x0014471C
		public unsafe virtual int TechDiscount
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x00146564 File Offset: 0x00144764
		public unsafe virtual bool IsCustomAbility
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x001465AC File Offset: 0x001447AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246642, XrefRangeEnd = 246650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0014661C File Offset: 0x0014481C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246650, XrefRangeEnd = 246656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0014668C File Offset: 0x0014488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246656, XrefRangeEnd = 246660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x001466E4 File Offset: 0x001448E4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x0014673C File Offset: 0x0014493C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246660, XrefRangeEnd = 246669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x001467BC File Offset: 0x001449BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246669, XrefRangeEnd = 246671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00146838 File Offset: 0x00144A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246742, RefRangeEnd = 246743, XrefRangeStart = 246671, XrefRangeEnd = 246742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<EntityID, Il2CppStructArray<int>> GetCustomChoiceFilter(WormMatch wormMatch, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.NativeMethodInfoPtr_GetCustomChoiceFilter_Private_Static_Dictionary_2_EntityID_Il2CppStructArray_1_Int32_WormMatch_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppStructArray<int>>>(intPtr3) : null;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00146890 File Offset: 0x00144A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246743, XrefRangeEnd = 246754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0014690C File Offset: 0x00144B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246754, XrefRangeEnd = 246809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppropriateAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x000127ED File Offset: 0x000109ED
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x000127FC File Offset: 0x000109FC
		public AppropriateAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x00146968 File Offset: 0x00144B68
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x00012805 File Offset: 0x00010A05
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x00146988 File Offset: 0x00144B88
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x00012817 File Offset: 0x00010A17
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_New_get_Int32_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomChoiceFilter_Private_Static_Dictionary_2_EntityID_Il2CppStructArray_1_Int32_WormMatch_WormPlayer_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000B8D RID: 2957
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.AppropriateAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600BC74 RID: 48244 RVA: 0x002EB56C File Offset: 0x002E976C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr);
				AppropriateAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, "<>9");
				AppropriateAbility.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, "<>9__10_0");
				AppropriateAbility.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, "<>9__10_1");
				AppropriateAbility.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, "<>9__16_0");
				AppropriateAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, 100680781);
				AppropriateAbility.__c.NativeMethodInfoPtr__Targets_b__10_0_Internal_EntityID_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, 100680782);
				AppropriateAbility.__c.NativeMethodInfoPtr__Targets_b__10_1_Internal_ReadOnlyAttributes_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, 100680783);
				AppropriateAbility.__c.NativeMethodInfoPtr__GetCustomChoiceFilter_b__16_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr, 100680784);
			}

			// Token: 0x0600BC75 RID: 48245 RVA: 0x002EB638 File Offset: 0x002E9838
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC76 RID: 48246 RVA: 0x002EB674 File Offset: 0x002E9874
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__10_0(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c.NativeMethodInfoPtr__Targets_b__10_0_Internal_EntityID_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC77 RID: 48247 RVA: 0x002EB6C4 File Offset: 0x002E98C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246370, XrefRangeEnd = 246390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__10_1(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c.NativeMethodInfoPtr__Targets_b__10_1_Internal_ReadOnlyAttributes_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC78 RID: 48248 RVA: 0x002EB714 File Offset: 0x002E9914
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _GetCustomChoiceFilter_b__16_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c.NativeMethodInfoPtr__GetCustomChoiceFilter_b__16_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC79 RID: 48249 RVA: 0x00057C38 File Offset: 0x00055E38
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A3F RID: 14911
			// (get) Token: 0x0600BC7A RID: 48250 RVA: 0x002EB764 File Offset: 0x002E9964
			// (set) Token: 0x0600BC7B RID: 48251 RVA: 0x00057C41 File Offset: 0x00055E41
			public unsafe static AppropriateAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A40 RID: 14912
			// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x002EB78C File Offset: 0x002E998C
			// (set) Token: 0x0600BC7D RID: 48253 RVA: 0x00057C53 File Offset: 0x00055E53
			public unsafe static Func<WormTechTilePlayable, EntityID> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A41 RID: 14913
			// (get) Token: 0x0600BC7E RID: 48254 RVA: 0x002EB7B4 File Offset: 0x002E99B4
			// (set) Token: 0x0600BC7F RID: 48255 RVA: 0x00057C65 File Offset: 0x00055E65
			public unsafe static Func<WormTechTilePlayable, ReadOnlyAttributes> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A42 RID: 14914
			// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x002EB7DC File Offset: 0x002E99DC
			// (set) Token: 0x0600BC81 RID: 48257 RVA: 0x00057C77 File Offset: 0x00055E77
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppropriateAbility.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007676 RID: 30326
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007677 RID: 30327
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04007678 RID: 30328
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04007679 RID: 30329
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x0400767A RID: 30330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400767B RID: 30331
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__10_0_Internal_EntityID_WormTechTilePlayable_0;

			// Token: 0x0400767C RID: 30332
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__10_1_Internal_ReadOnlyAttributes_WormTechTilePlayable_0;

			// Token: 0x0400767D RID: 30333
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomChoiceFilter_b__16_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;
		}

		// Token: 0x02000B8E RID: 2958
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.AppropriateAbility+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600BC82 RID: 48258 RVA: 0x002EB804 File Offset: 0x002E9A04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr);
				AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr, "player");
				AppropriateAbility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr, 100680785);
				AppropriateAbility.__c__DisplayClass14_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr, 100680786);
			}

			// Token: 0x0600BC83 RID: 48259 RVA: 0x002EB880 File Offset: 0x002E9A80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC84 RID: 48260 RVA: 0x002EB8BC File Offset: 0x002E9ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246390, XrefRangeEnd = 246399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c__DisplayClass14_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC85 RID: 48261 RVA: 0x00057C89 File Offset: 0x00055E89
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A43 RID: 14915
			// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x002EB90C File Offset: 0x002E9B0C
			// (set) Token: 0x0600BC87 RID: 48263 RVA: 0x00057C92 File Offset: 0x00055E92
			public unsafe AppropriateAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A44 RID: 14916
			// (get) Token: 0x0600BC88 RID: 48264 RVA: 0x002EB93C File Offset: 0x002E9B3C
			// (set) Token: 0x0600BC89 RID: 48265 RVA: 0x00057CB1 File Offset: 0x00055EB1
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400767E RID: 30334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400767F RID: 30335
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007680 RID: 30336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007681 RID: 30337
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B8F RID: 2959
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.AppropriateAbility+<>c__DisplayClass14_1")]
		public sealed class __c__DisplayClass14_1 : Object
		{
			// Token: 0x0600BC8A RID: 48266 RVA: 0x002EB96C File Offset: 0x002E9B6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_1()
			{
				Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "<>c__DisplayClass14_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr);
				AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_techTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr, "techTile");
				AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_tileCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr, "tileCost");
				AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_resourceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr, "resourceAttribute");
				AppropriateAbility.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr, 100680787);
				AppropriateAbility.__c__DisplayClass14_1.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr, 100680788);
			}

			// Token: 0x0600BC8B RID: 48267 RVA: 0x002EB9FC File Offset: 0x002E9BFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility.__c__DisplayClass14_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC8C RID: 48268 RVA: 0x002EBA38 File Offset: 0x002E9C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246399, XrefRangeEnd = 246404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__1(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility.__c__DisplayClass14_1.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC8D RID: 48269 RVA: 0x00057CD0 File Offset: 0x00055ED0
			public __c__DisplayClass14_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A45 RID: 14917
			// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x002EBA88 File Offset: 0x002E9C88
			// (set) Token: 0x0600BC8F RID: 48271 RVA: 0x00057CD9 File Offset: 0x00055ED9
			public unsafe WormTechTilePlayable techTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_techTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_techTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A46 RID: 14918
			// (get) Token: 0x0600BC90 RID: 48272 RVA: 0x002EBAB8 File Offset: 0x002E9CB8
			// (set) Token: 0x0600BC91 RID: 48273 RVA: 0x00057CF8 File Offset: 0x00055EF8
			public unsafe int tileCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_tileCost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_tileCost)) = value;
				}
			}

			// Token: 0x17003A47 RID: 14919
			// (get) Token: 0x0600BC92 RID: 48274 RVA: 0x002EBAE0 File Offset: 0x002E9CE0
			// (set) Token: 0x0600BC93 RID: 48275 RVA: 0x00057D13 File Offset: 0x00055F13
			public unsafe AttributeDefinition<Nullable<int>> resourceAttribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_resourceAttribute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility.__c__DisplayClass14_1.NativeFieldInfoPtr_resourceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007682 RID: 30338
			private static readonly IntPtr NativeFieldInfoPtr_techTile;

			// Token: 0x04007683 RID: 30339
			private static readonly IntPtr NativeFieldInfoPtr_tileCost;

			// Token: 0x04007684 RID: 30340
			private static readonly IntPtr NativeFieldInfoPtr_resourceAttribute;

			// Token: 0x04007685 RID: 30341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007686 RID: 30342
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B90 RID: 2960
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.AppropriateAbility+<BeginExecution>d__14")]
		public sealed class _BeginExecution_d__14 : Object
		{
			// Token: 0x0600BC94 RID: 48276 RVA: 0x002EBB10 File Offset: 0x002E9D10
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__14()
			{
				Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "<BeginExecution>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr);
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>1__state");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>2__current");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>l__initialThreadId");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>4__this");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "activeAbility");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>3__activeAbility");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "context");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>3__context");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "match");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>3__match");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>8__1");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<>8__2");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__payWithSolari_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<payWithSolari>5__2");
				AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__negotiatorCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, "<negotiatorCount>5__3");
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680789);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680790);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680791);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680792);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680793);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680794);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680795);
				AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr, 100680796);
			}

			// Token: 0x0600BC95 RID: 48277 RVA: 0x002EBCF4 File Offset: 0x002E9EF4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility._BeginExecution_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BC96 RID: 48278 RVA: 0x002EBD3C File Offset: 0x002E9F3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC97 RID: 48279 RVA: 0x002EBD70 File Offset: 0x002E9F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246404, XrefRangeEnd = 246445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003A56 RID: 14934
			// (get) Token: 0x0600BC98 RID: 48280 RVA: 0x002EBDAC File Offset: 0x002E9FAC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC99 RID: 48281 RVA: 0x002EBDEC File Offset: 0x002E9FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246445, XrefRangeEnd = 246450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003A57 RID: 14935
			// (get) Token: 0x0600BC9A RID: 48282 RVA: 0x002EBE20 File Offset: 0x002EA020
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC9B RID: 48283 RVA: 0x002EBE60 File Offset: 0x002EA060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246450, XrefRangeEnd = 246461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600BC9C RID: 48284 RVA: 0x002EBEA0 File Offset: 0x002EA0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._BeginExecution_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BC9D RID: 48285 RVA: 0x00057D32 File Offset: 0x00055F32
			public _BeginExecution_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A48 RID: 14920
			// (get) Token: 0x0600BC9E RID: 48286 RVA: 0x002EBEE0 File Offset: 0x002EA0E0
			// (set) Token: 0x0600BC9F RID: 48287 RVA: 0x00057D3B File Offset: 0x00055F3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003A49 RID: 14921
			// (get) Token: 0x0600BCA0 RID: 48288 RVA: 0x002EBF08 File Offset: 0x002EA108
			// (set) Token: 0x0600BCA1 RID: 48289 RVA: 0x00057D56 File Offset: 0x00055F56
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A4A RID: 14922
			// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x002EBF38 File Offset: 0x002EA138
			// (set) Token: 0x0600BCA3 RID: 48291 RVA: 0x00057D75 File Offset: 0x00055F75
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003A4B RID: 14923
			// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x002EBF60 File Offset: 0x002EA160
			// (set) Token: 0x0600BCA5 RID: 48293 RVA: 0x00057D90 File Offset: 0x00055F90
			public unsafe AppropriateAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A4C RID: 14924
			// (get) Token: 0x0600BCA6 RID: 48294 RVA: 0x002EBF90 File Offset: 0x002EA190
			// (set) Token: 0x0600BCA7 RID: 48295 RVA: 0x00057DAF File Offset: 0x00055FAF
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A4D RID: 14925
			// (get) Token: 0x0600BCA8 RID: 48296 RVA: 0x002EBFC0 File Offset: 0x002EA1C0
			// (set) Token: 0x0600BCA9 RID: 48297 RVA: 0x00057DCE File Offset: 0x00055FCE
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A4E RID: 14926
			// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x002EBFF0 File Offset: 0x002EA1F0
			// (set) Token: 0x0600BCAB RID: 48299 RVA: 0x00057DED File Offset: 0x00055FED
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A4F RID: 14927
			// (get) Token: 0x0600BCAC RID: 48300 RVA: 0x002EC020 File Offset: 0x002EA220
			// (set) Token: 0x0600BCAD RID: 48301 RVA: 0x00057E0C File Offset: 0x0005600C
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A50 RID: 14928
			// (get) Token: 0x0600BCAE RID: 48302 RVA: 0x002EC050 File Offset: 0x002EA250
			// (set) Token: 0x0600BCAF RID: 48303 RVA: 0x00057E2B File Offset: 0x0005602B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A51 RID: 14929
			// (get) Token: 0x0600BCB0 RID: 48304 RVA: 0x002EC080 File Offset: 0x002EA280
			// (set) Token: 0x0600BCB1 RID: 48305 RVA: 0x00057E4A File Offset: 0x0005604A
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A52 RID: 14930
			// (get) Token: 0x0600BCB2 RID: 48306 RVA: 0x002EC0B0 File Offset: 0x002EA2B0
			// (set) Token: 0x0600BCB3 RID: 48307 RVA: 0x00057E69 File Offset: 0x00056069
			public unsafe AppropriateAbility.__c__DisplayClass14_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility.__c__DisplayClass14_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A53 RID: 14931
			// (get) Token: 0x0600BCB4 RID: 48308 RVA: 0x002EC0E0 File Offset: 0x002EA2E0
			// (set) Token: 0x0600BCB5 RID: 48309 RVA: 0x00057E88 File Offset: 0x00056088
			public unsafe AppropriateAbility.__c__DisplayClass14_0 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A54 RID: 14932
			// (get) Token: 0x0600BCB6 RID: 48310 RVA: 0x002EC110 File Offset: 0x002EA310
			// (set) Token: 0x0600BCB7 RID: 48311 RVA: 0x00057EA7 File Offset: 0x000560A7
			public unsafe bool _payWithSolari_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__payWithSolari_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__payWithSolari_5__2)) = value;
				}
			}

			// Token: 0x17003A55 RID: 14933
			// (get) Token: 0x0600BCB8 RID: 48312 RVA: 0x002EC138 File Offset: 0x002EA338
			// (set) Token: 0x0600BCB9 RID: 48313 RVA: 0x00057EC2 File Offset: 0x000560C2
			public unsafe int _negotiatorCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__negotiatorCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._BeginExecution_d__14.NativeFieldInfoPtr__negotiatorCount_5__3)) = value;
				}
			}

			// Token: 0x04007687 RID: 30343
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007688 RID: 30344
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007689 RID: 30345
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400768A RID: 30346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400768B RID: 30347
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400768C RID: 30348
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400768D RID: 30349
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400768E RID: 30350
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400768F RID: 30351
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007690 RID: 30352
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007691 RID: 30353
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007692 RID: 30354
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04007693 RID: 30355
			private static readonly IntPtr NativeFieldInfoPtr__payWithSolari_5__2;

			// Token: 0x04007694 RID: 30356
			private static readonly IntPtr NativeFieldInfoPtr__negotiatorCount_5__3;

			// Token: 0x04007695 RID: 30357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007696 RID: 30358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007697 RID: 30359
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007698 RID: 30360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007699 RID: 30361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400769A RID: 30362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400769B RID: 30363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400769C RID: 30364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B91 RID: 2961
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.AppropriateAbility+<Targets>d__10")]
		public sealed class _Targets_d__10 : Object
		{
			// Token: 0x0600BCBA RID: 48314 RVA: 0x002EC160 File Offset: 0x002EA360
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__10()
			{
				Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppropriateAbility>.NativeClassPtr, "<Targets>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr);
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>1__state");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>2__current");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>l__initialThreadId");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "context");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>3__context");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "match");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>3__match");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<>4__this");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<player>5__2");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__wormMatch_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<wormMatch>5__3");
				AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__customChoiceFilter_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, "<customChoiceFilter>5__4");
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680797);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680798);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680799);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680800);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680801);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680802);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680803);
				AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr, 100680804);
			}

			// Token: 0x0600BCBB RID: 48315 RVA: 0x002EC308 File Offset: 0x002EA508
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppropriateAbility._Targets_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BCBC RID: 48316 RVA: 0x002EC350 File Offset: 0x002EA550
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCBD RID: 48317 RVA: 0x002EC384 File Offset: 0x002EA584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246461, XrefRangeEnd = 246602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003A63 RID: 14947
			// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x002EC3C0 File Offset: 0x002EA5C0
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600BCBF RID: 48319 RVA: 0x002EC400 File Offset: 0x002EA600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246602, XrefRangeEnd = 246607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003A64 RID: 14948
			// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x002EC434 File Offset: 0x002EA634
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BCC1 RID: 48321 RVA: 0x002EC474 File Offset: 0x002EA674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246607, XrefRangeEnd = 246617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600BCC2 RID: 48322 RVA: 0x002EC4B4 File Offset: 0x002EA6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppropriateAbility._Targets_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BCC3 RID: 48323 RVA: 0x00057EDD File Offset: 0x000560DD
			public _Targets_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A58 RID: 14936
			// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x002EC4F4 File Offset: 0x002EA6F4
			// (set) Token: 0x0600BCC5 RID: 48325 RVA: 0x00057EE6 File Offset: 0x000560E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003A59 RID: 14937
			// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x002EC51C File Offset: 0x002EA71C
			// (set) Token: 0x0600BCC7 RID: 48327 RVA: 0x00057F01 File Offset: 0x00056101
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5A RID: 14938
			// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x002EC54C File Offset: 0x002EA74C
			// (set) Token: 0x0600BCC9 RID: 48329 RVA: 0x00057F20 File Offset: 0x00056120
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003A5B RID: 14939
			// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x002EC574 File Offset: 0x002EA774
			// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x00057F3B File Offset: 0x0005613B
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5C RID: 14940
			// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x002EC5A4 File Offset: 0x002EA7A4
			// (set) Token: 0x0600BCCD RID: 48333 RVA: 0x00057F5A File Offset: 0x0005615A
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5D RID: 14941
			// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x002EC5D4 File Offset: 0x002EA7D4
			// (set) Token: 0x0600BCCF RID: 48335 RVA: 0x00057F79 File Offset: 0x00056179
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5E RID: 14942
			// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x002EC604 File Offset: 0x002EA804
			// (set) Token: 0x0600BCD1 RID: 48337 RVA: 0x00057F98 File Offset: 0x00056198
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5F RID: 14943
			// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x002EC634 File Offset: 0x002EA834
			// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x00057FB7 File Offset: 0x000561B7
			public unsafe AppropriateAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppropriateAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A60 RID: 14944
			// (get) Token: 0x0600BCD4 RID: 48340 RVA: 0x002EC664 File Offset: 0x002EA864
			// (set) Token: 0x0600BCD5 RID: 48341 RVA: 0x00057FD6 File Offset: 0x000561D6
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A61 RID: 14945
			// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x002EC694 File Offset: 0x002EA894
			// (set) Token: 0x0600BCD7 RID: 48343 RVA: 0x00057FF5 File Offset: 0x000561F5
			public unsafe WormMatch _wormMatch_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__wormMatch_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__wormMatch_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A62 RID: 14946
			// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x002EC6C4 File Offset: 0x002EA8C4
			// (set) Token: 0x0600BCD9 RID: 48345 RVA: 0x00058014 File Offset: 0x00056214
			public unsafe Dictionary<EntityID, Il2CppStructArray<int>> _customChoiceFilter_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__customChoiceFilter_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppropriateAbility._Targets_d__10.NativeFieldInfoPtr__customChoiceFilter_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400769D RID: 30365
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400769E RID: 30366
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400769F RID: 30367
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040076A0 RID: 30368
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040076A1 RID: 30369
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040076A2 RID: 30370
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040076A3 RID: 30371
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040076A4 RID: 30372
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076A5 RID: 30373
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040076A6 RID: 30374
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__3;

			// Token: 0x040076A7 RID: 30375
			private static readonly IntPtr NativeFieldInfoPtr__customChoiceFilter_5__4;

			// Token: 0x040076A8 RID: 30376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040076A9 RID: 30377
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076AA RID: 30378
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040076AB RID: 30379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040076AC RID: 30380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076AD RID: 30381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040076AE RID: 30382
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040076AF RID: 30383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

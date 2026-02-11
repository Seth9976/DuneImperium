using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
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

namespace worm.canis.abilities.ActivatedAbilities.BaseSet
{
	// Token: 0x02000538 RID: 1336
	public class GurneyHalleckAbility : DeferredAbility
	{
		// Token: 0x06003EC9 RID: 16073 RVA: 0x0016E574 File Offset: 0x0016C774
		// Note: this type is marked as 'beforefieldinit'.
		static GurneyHalleckAbility()
		{
			Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.BaseSet", "GurneyHalleckAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr);
			GurneyHalleckAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "AbilityName");
			GurneyHalleckAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "AbilityID");
			GurneyHalleckAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683918);
			GurneyHalleckAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683919);
			GurneyHalleckAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683920);
			GurneyHalleckAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683921);
			GurneyHalleckAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683922);
			GurneyHalleckAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683923);
			GurneyHalleckAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683924);
			GurneyHalleckAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683925);
			GurneyHalleckAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683926);
			GurneyHalleckAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683927);
			GurneyHalleckAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683928);
			GurneyHalleckAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683929);
			GurneyHalleckAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683930);
			GurneyHalleckAbility.NativeMethodInfoPtr__BeginExecution_b__10_1_Private_Boolean_WormTroop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683932);
			GurneyHalleckAbility.NativeMethodInfoPtr__Evaluate_b__14_3_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683933);
			GurneyHalleckAbility.NativeMethodInfoPtr__Evaluate_b__14_4_Private_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, 100683934);
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0016E70C File Offset: 0x0016C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276115, XrefRangeEnd = 276119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x0016E758 File Offset: 0x0016C958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276119, XrefRangeEnd = 276125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0016E7B4 File Offset: 0x0016C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276125, XrefRangeEnd = 276138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GurneyHalleckAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0016E800 File Offset: 0x0016CA00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GurneyHalleckAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0016E870 File Offset: 0x0016CA70
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0016E8C8 File Offset: 0x0016CAC8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0016E920 File Offset: 0x0016CB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276138, XrefRangeEnd = 276149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0016E990 File Offset: 0x0016CB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276149, XrefRangeEnd = 276156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0016EA00 File Offset: 0x0016CC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276156, XrefRangeEnd = 276164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0016EA80 File Offset: 0x0016CC80
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0016EAFC File Offset: 0x0016CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276164, XrefRangeEnd = 276193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<ValueTuple<LocalizableTextVariables, List<EntityID>>> GetUnusualSelections(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0016EB6C File Offset: 0x0016CD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276193, XrefRangeEnd = 276204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0016EBE8 File Offset: 0x0016CDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276204, XrefRangeEnd = 276374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GurneyHalleckAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0016EC44 File Offset: 0x0016CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BeginExecution_b__10_1(WormTroop _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.NativeMethodInfoPtr__BeginExecution_b__10_1_Private_Boolean_WormTroop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0016EC94 File Offset: 0x0016CE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276374, XrefRangeEnd = 276375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Evaluate_b__14_3(EntityID _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.NativeMethodInfoPtr__Evaluate_b__14_3_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0016ECE4 File Offset: 0x0016CEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276375, XrefRangeEnd = 276379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Evaluate_b__14_4(EntityID _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.NativeMethodInfoPtr__Evaluate_b__14_4_Private_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00013FAE File Offset: 0x000121AE
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00013FBD File Offset: 0x000121BD
		public GurneyHalleckAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0016ED34 File Offset: 0x0016CF34
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x00013FC6 File Offset: 0x000121C6
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0016ED54 File Offset: 0x0016CF54
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x00013FD8 File Offset: 0x000121D8
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__10_1_Private_Boolean_WormTroop_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_3_Private_Boolean_EntityID_0;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_4_Private_Entity_EntityID_0;

		// Token: 0x02000CBF RID: 3263
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.GurneyHalleckAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D4DA RID: 54490 RVA: 0x00331DC8 File Offset: 0x0032FFC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr);
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9");
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9__12_0");
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9__14_0");
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9__14_1");
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9__14_2");
				GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, "<>9__14_5");
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683936);
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__GetUnusualSelections_b__12_0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683937);
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683938);
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_1_Internal_Int32_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683939);
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_2_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683940);
				GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_5_Internal_EntityID_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr, 100683941);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x00331EE4 File Offset: 0x003300E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4DC RID: 54492 RVA: 0x00331F20 File Offset: 0x00330120
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnusualSelections_b__12_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__GetUnusualSelections_b__12_0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D4DD RID: 54493 RVA: 0x00331F70 File Offset: 0x00330170
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<int> _Evaluate_b__14_0(AIValueSummer<int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4DE RID: 54494 RVA: 0x00331FC0 File Offset: 0x003301C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275818, XrefRangeEnd = 275822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__14_1(AIValueSummer<int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_1_Internal_Int32_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D4DF RID: 54495 RVA: 0x00332010 File Offset: 0x00330210
			[CallerCount(0)]
			public unsafe int _Evaluate_b__14_2(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_2_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D4E0 RID: 54496 RVA: 0x0033205C File Offset: 0x0033025C
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__14_5(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c.NativeMethodInfoPtr__Evaluate_b__14_5_Internal_EntityID_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x000660CC File Offset: 0x000642CC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700431D RID: 17181
			// (get) Token: 0x0600D4E2 RID: 54498 RVA: 0x003320AC File Offset: 0x003302AC
			// (set) Token: 0x0600D4E3 RID: 54499 RVA: 0x000660D5 File Offset: 0x000642D5
			public unsafe static GurneyHalleckAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GurneyHalleckAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431E RID: 17182
			// (get) Token: 0x0600D4E4 RID: 54500 RVA: 0x003320D4 File Offset: 0x003302D4
			// (set) Token: 0x0600D4E5 RID: 54501 RVA: 0x000660E7 File Offset: 0x000642E7
			public unsafe static Func<Entity, int> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431F RID: 17183
			// (get) Token: 0x0600D4E6 RID: 54502 RVA: 0x003320FC File Offset: 0x003302FC
			// (set) Token: 0x0600D4E7 RID: 54503 RVA: 0x000660F9 File Offset: 0x000642F9
			public unsafe static Func<AIValueSummer<int>, AIValueSummer<int>> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<int>, AIValueSummer<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004320 RID: 17184
			// (get) Token: 0x0600D4E8 RID: 54504 RVA: 0x00332124 File Offset: 0x00330324
			// (set) Token: 0x0600D4E9 RID: 54505 RVA: 0x0006610B File Offset: 0x0006430B
			public unsafe static Func<AIValueSummer<int>, int> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004321 RID: 17185
			// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x0033214C File Offset: 0x0033034C
			// (set) Token: 0x0600D4EB RID: 54507 RVA: 0x0006611D File Offset: 0x0006431D
			public unsafe static Func<int, int> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004322 RID: 17186
			// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x00332174 File Offset: 0x00330374
			// (set) Token: 0x0600D4ED RID: 54509 RVA: 0x0006612F File Offset: 0x0006432F
			public unsafe static Func<WormUnit, EntityID> __9__14_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GurneyHalleckAbility.__c.NativeFieldInfoPtr___9__14_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084F2 RID: 34034
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084F3 RID: 34035
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040084F4 RID: 34036
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040084F5 RID: 34037
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x040084F6 RID: 34038
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x040084F7 RID: 34039
			private static readonly IntPtr NativeFieldInfoPtr___9__14_5;

			// Token: 0x040084F8 RID: 34040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084F9 RID: 34041
			private static readonly IntPtr NativeMethodInfoPtr__GetUnusualSelections_b__12_0_Internal_Int32_Entity_0;

			// Token: 0x040084FA RID: 34042
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0;

			// Token: 0x040084FB RID: 34043
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_1_Internal_Int32_AIValueSummer_1_Int32_0;

			// Token: 0x040084FC RID: 34044
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_2_Internal_Int32_Int32_0;

			// Token: 0x040084FD RID: 34045
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__14_5_Internal_EntityID_WormUnit_0;
		}

		// Token: 0x02000CC0 RID: 3264
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.GurneyHalleckAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600D4EE RID: 54510 RVA: 0x0033219C File Offset: 0x0033039C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr);
				GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_troopsToGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr, "troopsToGain");
				GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				GurneyHalleckAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr, 100683942);
				GurneyHalleckAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr, 100683943);
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x00332218 File Offset: 0x00330418
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x00332254 File Offset: 0x00330454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275822, XrefRangeEnd = 275832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x00066141 File Offset: 0x00064341
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004323 RID: 17187
			// (get) Token: 0x0600D4F2 RID: 54514 RVA: 0x003322A4 File Offset: 0x003304A4
			// (set) Token: 0x0600D4F3 RID: 54515 RVA: 0x0006614A File Offset: 0x0006434A
			public unsafe int troopsToGain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_troopsToGain);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_troopsToGain)) = value;
				}
			}

			// Token: 0x17004324 RID: 17188
			// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x003322CC File Offset: 0x003304CC
			// (set) Token: 0x0600D4F5 RID: 54517 RVA: 0x00066165 File Offset: 0x00064365
			public unsafe GurneyHalleckAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GurneyHalleckAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084FE RID: 34046
			private static readonly IntPtr NativeFieldInfoPtr_troopsToGain;

			// Token: 0x040084FF RID: 34047
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008500 RID: 34048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008501 RID: 34049
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000CC1 RID: 3265
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.GurneyHalleckAbility+<BeginExecution>d__10")]
		public sealed class _BeginExecution_d__10 : Object
		{
			// Token: 0x0600D4F6 RID: 54518 RVA: 0x003322FC File Offset: 0x003304FC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__10()
			{
				Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "<BeginExecution>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr);
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>1__state");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>2__current");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>l__initialThreadId");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "activeAbility");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>3__activeAbility");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>4__this");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "match");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>3__match");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<player>5__2");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<sequenceHelper>5__3");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__troopCount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<troopCount>5__4");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__chosenTroops_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<chosenTroops>5__5");
				GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, "<>7__wrap5");
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683944);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683945);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683946);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683947);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683948);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683949);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683950);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683951);
				GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr, 100683952);
			}

			// Token: 0x0600D4F7 RID: 54519 RVA: 0x003324E0 File Offset: 0x003306E0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility._BeginExecution_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D4F8 RID: 54520 RVA: 0x00332528 File Offset: 0x00330728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275832, XrefRangeEnd = 275837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x0033255C File Offset: 0x0033075C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275837, XrefRangeEnd = 276005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4FA RID: 54522 RVA: 0x00332598 File Offset: 0x00330798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276005, XrefRangeEnd = 276008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004332 RID: 17202
			// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x003325CC File Offset: 0x003307CC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4FC RID: 54524 RVA: 0x0033260C File Offset: 0x0033080C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276008, XrefRangeEnd = 276013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004333 RID: 17203
			// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x00332640 File Offset: 0x00330840
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4FE RID: 54526 RVA: 0x00332680 File Offset: 0x00330880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276013, XrefRangeEnd = 276023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x003326C0 File Offset: 0x003308C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x00066184 File Offset: 0x00064384
			public _BeginExecution_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004325 RID: 17189
			// (get) Token: 0x0600D501 RID: 54529 RVA: 0x00332700 File Offset: 0x00330900
			// (set) Token: 0x0600D502 RID: 54530 RVA: 0x0006618D File Offset: 0x0006438D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004326 RID: 17190
			// (get) Token: 0x0600D503 RID: 54531 RVA: 0x00332728 File Offset: 0x00330928
			// (set) Token: 0x0600D504 RID: 54532 RVA: 0x000661A8 File Offset: 0x000643A8
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004327 RID: 17191
			// (get) Token: 0x0600D505 RID: 54533 RVA: 0x00332758 File Offset: 0x00330958
			// (set) Token: 0x0600D506 RID: 54534 RVA: 0x000661C7 File Offset: 0x000643C7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004328 RID: 17192
			// (get) Token: 0x0600D507 RID: 54535 RVA: 0x00332780 File Offset: 0x00330980
			// (set) Token: 0x0600D508 RID: 54536 RVA: 0x000661E2 File Offset: 0x000643E2
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004329 RID: 17193
			// (get) Token: 0x0600D509 RID: 54537 RVA: 0x003327B0 File Offset: 0x003309B0
			// (set) Token: 0x0600D50A RID: 54538 RVA: 0x00066201 File Offset: 0x00064401
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432A RID: 17194
			// (get) Token: 0x0600D50B RID: 54539 RVA: 0x003327E0 File Offset: 0x003309E0
			// (set) Token: 0x0600D50C RID: 54540 RVA: 0x00066220 File Offset: 0x00064420
			public unsafe GurneyHalleckAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GurneyHalleckAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432B RID: 17195
			// (get) Token: 0x0600D50D RID: 54541 RVA: 0x00332810 File Offset: 0x00330A10
			// (set) Token: 0x0600D50E RID: 54542 RVA: 0x0006623F File Offset: 0x0006443F
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432C RID: 17196
			// (get) Token: 0x0600D50F RID: 54543 RVA: 0x00332840 File Offset: 0x00330A40
			// (set) Token: 0x0600D510 RID: 54544 RVA: 0x0006625E File Offset: 0x0006445E
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432D RID: 17197
			// (get) Token: 0x0600D511 RID: 54545 RVA: 0x00332870 File Offset: 0x00330A70
			// (set) Token: 0x0600D512 RID: 54546 RVA: 0x0006627D File Offset: 0x0006447D
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432E RID: 17198
			// (get) Token: 0x0600D513 RID: 54547 RVA: 0x003328A0 File Offset: 0x00330AA0
			// (set) Token: 0x0600D514 RID: 54548 RVA: 0x0006629C File Offset: 0x0006449C
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432F RID: 17199
			// (get) Token: 0x0600D515 RID: 54549 RVA: 0x003328D0 File Offset: 0x00330AD0
			// (set) Token: 0x0600D516 RID: 54550 RVA: 0x000662BB File Offset: 0x000644BB
			public unsafe int _troopCount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__troopCount_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__troopCount_5__4)) = value;
				}
			}

			// Token: 0x17004330 RID: 17200
			// (get) Token: 0x0600D517 RID: 54551 RVA: 0x003328F8 File Offset: 0x00330AF8
			// (set) Token: 0x0600D518 RID: 54552 RVA: 0x000662D6 File Offset: 0x000644D6
			public unsafe List<WormTroop> _chosenTroops_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__chosenTroops_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormTroop>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr__chosenTroops_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004331 RID: 17201
			// (get) Token: 0x0600D519 RID: 54553 RVA: 0x00332928 File Offset: 0x00330B28
			// (set) Token: 0x0600D51A RID: 54554 RVA: 0x000662F5 File Offset: 0x000644F5
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008502 RID: 34050
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008503 RID: 34051
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008504 RID: 34052
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04008505 RID: 34053
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04008506 RID: 34054
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04008507 RID: 34055
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008508 RID: 34056
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04008509 RID: 34057
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400850A RID: 34058
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400850B RID: 34059
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x0400850C RID: 34060
			private static readonly IntPtr NativeFieldInfoPtr__troopCount_5__4;

			// Token: 0x0400850D RID: 34061
			private static readonly IntPtr NativeFieldInfoPtr__chosenTroops_5__5;

			// Token: 0x0400850E RID: 34062
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x0400850F RID: 34063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008510 RID: 34064
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008511 RID: 34065
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008512 RID: 34066
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04008513 RID: 34067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04008514 RID: 34068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008515 RID: 34069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008516 RID: 34070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04008517 RID: 34071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000CC2 RID: 3266
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.GurneyHalleckAbility+<Targets>d__9")]
		public sealed class _Targets_d__9 : Object
		{
			// Token: 0x0600D51B RID: 54555 RVA: 0x00332958 File Offset: 0x00330B58
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__9()
			{
				Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GurneyHalleckAbility>.NativeClassPtr, "<Targets>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr);
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "<>1__state");
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "<>2__current");
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "context");
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "<>3__context");
				GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, "<>4__this");
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683953);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683954);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683955);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683956);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683957);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683958);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683959);
				GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr, 100683960);
			}

			// Token: 0x0600D51C RID: 54556 RVA: 0x00332A9C File Offset: 0x00330C9C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleckAbility._Targets_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D51D RID: 54557 RVA: 0x00332AE4 File Offset: 0x00330CE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D51E RID: 54558 RVA: 0x00332B18 File Offset: 0x00330D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276023, XrefRangeEnd = 276101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700433A RID: 17210
			// (get) Token: 0x0600D51F RID: 54559 RVA: 0x00332B54 File Offset: 0x00330D54
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600D520 RID: 54560 RVA: 0x00332B94 File Offset: 0x00330D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276101, XrefRangeEnd = 276106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700433B RID: 17211
			// (get) Token: 0x0600D521 RID: 54561 RVA: 0x00332BC8 File Offset: 0x00330DC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D522 RID: 54562 RVA: 0x00332C08 File Offset: 0x00330E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276106, XrefRangeEnd = 276115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x00332C48 File Offset: 0x00330E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleckAbility._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x00066314 File Offset: 0x00064514
			public _Targets_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004334 RID: 17204
			// (get) Token: 0x0600D525 RID: 54565 RVA: 0x00332C88 File Offset: 0x00330E88
			// (set) Token: 0x0600D526 RID: 54566 RVA: 0x0006631D File Offset: 0x0006451D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004335 RID: 17205
			// (get) Token: 0x0600D527 RID: 54567 RVA: 0x00332CB0 File Offset: 0x00330EB0
			// (set) Token: 0x0600D528 RID: 54568 RVA: 0x00066338 File Offset: 0x00064538
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004336 RID: 17206
			// (get) Token: 0x0600D529 RID: 54569 RVA: 0x00332CE0 File Offset: 0x00330EE0
			// (set) Token: 0x0600D52A RID: 54570 RVA: 0x00066357 File Offset: 0x00064557
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004337 RID: 17207
			// (get) Token: 0x0600D52B RID: 54571 RVA: 0x00332D08 File Offset: 0x00330F08
			// (set) Token: 0x0600D52C RID: 54572 RVA: 0x00066372 File Offset: 0x00064572
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004338 RID: 17208
			// (get) Token: 0x0600D52D RID: 54573 RVA: 0x00332D38 File Offset: 0x00330F38
			// (set) Token: 0x0600D52E RID: 54574 RVA: 0x00066391 File Offset: 0x00064591
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004339 RID: 17209
			// (get) Token: 0x0600D52F RID: 54575 RVA: 0x00332D68 File Offset: 0x00330F68
			// (set) Token: 0x0600D530 RID: 54576 RVA: 0x000663B0 File Offset: 0x000645B0
			public unsafe GurneyHalleckAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GurneyHalleckAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GurneyHalleckAbility._Targets_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008518 RID: 34072
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008519 RID: 34073
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400851A RID: 34074
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400851B RID: 34075
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400851C RID: 34076
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400851D RID: 34077
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400851E RID: 34078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400851F RID: 34079
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008520 RID: 34080
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008521 RID: 34081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04008522 RID: 34082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008523 RID: 34083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008524 RID: 34084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04008525 RID: 34085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

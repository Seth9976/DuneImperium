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
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004C2 RID: 1218
	public class GainAnyFactionInfluenceCustomAbility : DeferredAbility
	{
		// Token: 0x060036DB RID: 14043 RVA: 0x00144B90 File Offset: 0x00142D90
		// Note: this type is marked as 'beforefieldinit'.
		static GainAnyFactionInfluenceCustomAbility()
		{
			Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "GainAnyFactionInfluenceCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr);
			GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "AbilityName");
			GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "AbilityID");
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680668);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680669);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680670);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680671);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680672);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680673);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680674);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680675);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680676);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680677);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680678);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680679);
			GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, 100680680);
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00144CEC File Offset: 0x00142EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245772, XrefRangeEnd = 245776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00144D38 File Offset: 0x00142F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245776, XrefRangeEnd = 245782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00144D94 File Offset: 0x00142F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245782, XrefRangeEnd = 245795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainAnyFactionInfluenceCustomAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00144DE0 File Offset: 0x00142FE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainAnyFactionInfluenceCustomAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00144E50 File Offset: 0x00143050
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00144EA8 File Offset: 0x001430A8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00144F00 File Offset: 0x00143100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245795, XrefRangeEnd = 245802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00144F70 File Offset: 0x00143170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245802, XrefRangeEnd = 245811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00144FE0 File Offset: 0x001431E0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00145038 File Offset: 0x00143238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245811, XrefRangeEnd = 245819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x001450B8 File Offset: 0x001432B8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00145134 File Offset: 0x00143334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245819, XrefRangeEnd = 245832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x001451B0 File Offset: 0x001433B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245832, XrefRangeEnd = 245883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAnyFactionInfluenceCustomAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x000126EE File Offset: 0x000108EE
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000126FD File Offset: 0x000108FD
		public GainAnyFactionInfluenceCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x0014520C File Offset: 0x0014340C
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x00012706 File Offset: 0x00010906
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x0014522C File Offset: 0x0014342C
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x00012718 File Offset: 0x00010918
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000B84 RID: 2948
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.GainAnyFactionInfluenceCustomAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600BBCE RID: 48078 RVA: 0x002E97C0 File Offset: 0x002E79C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr);
				GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, "<>9");
				GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, "<>9__8_0");
				GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, "<>9__8_1");
				GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, "<>9__8_2");
				GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, 100680683);
				GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, 100680684);
				GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_1_Internal_EntityID_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, 100680685);
				GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_2_Internal_ReadOnlyAttributes_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr, 100680686);
			}

			// Token: 0x0600BBCF RID: 48079 RVA: 0x002E988C File Offset: 0x002E7A8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBD0 RID: 48080 RVA: 0x002E98C8 File Offset: 0x002E7AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__8_0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BBD1 RID: 48081 RVA: 0x002E9918 File Offset: 0x002E7B18
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__8_1(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_1_Internal_EntityID_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600BBD2 RID: 48082 RVA: 0x002E9968 File Offset: 0x002E7B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245571, XrefRangeEnd = 245591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__8_2(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c.NativeMethodInfoPtr__Targets_b__8_2_Internal_ReadOnlyAttributes_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600BBD3 RID: 48083 RVA: 0x0005765A File Offset: 0x0005585A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A04 RID: 14852
			// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x002E99B8 File Offset: 0x002E7BB8
			// (set) Token: 0x0600BBD5 RID: 48085 RVA: 0x00057663 File Offset: 0x00055863
			public unsafe static GainAnyFactionInfluenceCustomAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAnyFactionInfluenceCustomAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A05 RID: 14853
			// (get) Token: 0x0600BBD6 RID: 48086 RVA: 0x002E99E0 File Offset: 0x002E7BE0
			// (set) Token: 0x0600BBD7 RID: 48087 RVA: 0x00057675 File Offset: 0x00055875
			public unsafe static Func<WormFactionTrack, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A06 RID: 14854
			// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x002E9A08 File Offset: 0x002E7C08
			// (set) Token: 0x0600BBD9 RID: 48089 RVA: 0x00057687 File Offset: 0x00055887
			public unsafe static Func<WormFactionTrack, EntityID> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A07 RID: 14855
			// (get) Token: 0x0600BBDA RID: 48090 RVA: 0x002E9A30 File Offset: 0x002E7C30
			// (set) Token: 0x0600BBDB RID: 48091 RVA: 0x00057699 File Offset: 0x00055899
			public unsafe static Func<WormFactionTrack, ReadOnlyAttributes> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAnyFactionInfluenceCustomAbility.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007615 RID: 30229
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007616 RID: 30230
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04007617 RID: 30231
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04007618 RID: 30232
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x04007619 RID: 30233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400761A RID: 30234
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__8_0_Internal_Boolean_WormFactionTrack_0;

			// Token: 0x0400761B RID: 30235
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__8_1_Internal_EntityID_WormFactionTrack_0;

			// Token: 0x0400761C RID: 30236
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__8_2_Internal_ReadOnlyAttributes_WormFactionTrack_0;
		}

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.GainAnyFactionInfluenceCustomAbility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600BBDC RID: 48092 RVA: 0x002E9A58 File Offset: 0x002E7C58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr);
				GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr, "player");
				GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_chosenFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr, "chosenFaction");
				GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr, 100680687);
				GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr, 100680688);
			}

			// Token: 0x0600BBDD RID: 48093 RVA: 0x002E9AD4 File Offset: 0x002E7CD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBDE RID: 48094 RVA: 0x002E9B10 File Offset: 0x002E7D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245591, XrefRangeEnd = 245599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder glb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(glb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BBDF RID: 48095 RVA: 0x000576AB File Offset: 0x000558AB
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A08 RID: 14856
			// (get) Token: 0x0600BBE0 RID: 48096 RVA: 0x002E9B60 File Offset: 0x002E7D60
			// (set) Token: 0x0600BBE1 RID: 48097 RVA: 0x000576B4 File Offset: 0x000558B4
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A09 RID: 14857
			// (get) Token: 0x0600BBE2 RID: 48098 RVA: 0x002E9B90 File Offset: 0x002E7D90
			// (set) Token: 0x0600BBE3 RID: 48099 RVA: 0x000576D3 File Offset: 0x000558D3
			public unsafe Factions chosenFaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_chosenFaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_chosenFaction)) = value;
				}
			}

			// Token: 0x0400761D RID: 30237
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400761E RID: 30238
			private static readonly IntPtr NativeFieldInfoPtr_chosenFaction;

			// Token: 0x0400761F RID: 30239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007620 RID: 30240
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B86 RID: 2950
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.GainAnyFactionInfluenceCustomAbility+<BeginExecution>d__11")]
		public sealed class _BeginExecution_d__11 : Object
		{
			// Token: 0x0600BBE4 RID: 48100 RVA: 0x002E9BB8 File Offset: 0x002E7DB8
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__11()
			{
				Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "<BeginExecution>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>1__state");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>2__current");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>l__initialThreadId");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "activeAbility");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__activeAbility");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>4__this");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "match");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__match");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, "<>8__1");
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680689);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680690);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680691);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680692);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680693);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680694);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680695);
				GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr, 100680696);
			}

			// Token: 0x0600BBE5 RID: 48101 RVA: 0x002E9D38 File Offset: 0x002E7F38
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BBE6 RID: 48102 RVA: 0x002E9D80 File Offset: 0x002E7F80
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE7 RID: 48103 RVA: 0x002E9DB4 File Offset: 0x002E7FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245599, XrefRangeEnd = 245633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003A13 RID: 14867
			// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x002E9DF0 File Offset: 0x002E7FF0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600BBE9 RID: 48105 RVA: 0x002E9E30 File Offset: 0x002E8030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245633, XrefRangeEnd = 245638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003A14 RID: 14868
			// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x002E9E64 File Offset: 0x002E8064
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BBEB RID: 48107 RVA: 0x002E9EA4 File Offset: 0x002E80A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245638, XrefRangeEnd = 245648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600BBEC RID: 48108 RVA: 0x002E9EE4 File Offset: 0x002E80E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BBED RID: 48109 RVA: 0x000576EE File Offset: 0x000558EE
			public _BeginExecution_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A0A RID: 14858
			// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x002E9F24 File Offset: 0x002E8124
			// (set) Token: 0x0600BBEF RID: 48111 RVA: 0x000576F7 File Offset: 0x000558F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003A0B RID: 14859
			// (get) Token: 0x0600BBF0 RID: 48112 RVA: 0x002E9F4C File Offset: 0x002E814C
			// (set) Token: 0x0600BBF1 RID: 48113 RVA: 0x00057712 File Offset: 0x00055912
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A0C RID: 14860
			// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x002E9F7C File Offset: 0x002E817C
			// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x00057731 File Offset: 0x00055931
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003A0D RID: 14861
			// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x002E9FA4 File Offset: 0x002E81A4
			// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x0005774C File Offset: 0x0005594C
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A0E RID: 14862
			// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x002E9FD4 File Offset: 0x002E81D4
			// (set) Token: 0x0600BBF7 RID: 48119 RVA: 0x0005776B File Offset: 0x0005596B
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A0F RID: 14863
			// (get) Token: 0x0600BBF8 RID: 48120 RVA: 0x002EA004 File Offset: 0x002E8204
			// (set) Token: 0x0600BBF9 RID: 48121 RVA: 0x0005778A File Offset: 0x0005598A
			public unsafe GainAnyFactionInfluenceCustomAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAnyFactionInfluenceCustomAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A10 RID: 14864
			// (get) Token: 0x0600BBFA RID: 48122 RVA: 0x002EA034 File Offset: 0x002E8234
			// (set) Token: 0x0600BBFB RID: 48123 RVA: 0x000577A9 File Offset: 0x000559A9
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A11 RID: 14865
			// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x002EA064 File Offset: 0x002E8264
			// (set) Token: 0x0600BBFD RID: 48125 RVA: 0x000577C8 File Offset: 0x000559C8
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A12 RID: 14866
			// (get) Token: 0x0600BBFE RID: 48126 RVA: 0x002EA094 File Offset: 0x002E8294
			// (set) Token: 0x0600BBFF RID: 48127 RVA: 0x000577E7 File Offset: 0x000559E7
			public unsafe GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAnyFactionInfluenceCustomAbility.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007621 RID: 30241
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007622 RID: 30242
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007623 RID: 30243
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007624 RID: 30244
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007625 RID: 30245
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007626 RID: 30246
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007627 RID: 30247
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007628 RID: 30248
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007629 RID: 30249
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400762A RID: 30250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400762B RID: 30251
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400762C RID: 30252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400762D RID: 30253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400762E RID: 30254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400762F RID: 30255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007630 RID: 30256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007631 RID: 30257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.GainAnyFactionInfluenceCustomAbility+<Targets>d__8")]
		public sealed class _Targets_d__8 : Object
		{
			// Token: 0x0600BC00 RID: 48128 RVA: 0x002EA0C4 File Offset: 0x002E82C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__8()
			{
				Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility>.NativeClassPtr, "<Targets>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "<>1__state");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "<>2__current");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "context");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "<>3__context");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, "<>4__this");
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680697);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680698);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680699);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680700);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680701);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680702);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680703);
				GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr, 100680704);
			}

			// Token: 0x0600BC01 RID: 48129 RVA: 0x002EA208 File Offset: 0x002E8408
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAnyFactionInfluenceCustomAbility._Targets_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BC02 RID: 48130 RVA: 0x002EA250 File Offset: 0x002E8450
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC03 RID: 48131 RVA: 0x002EA284 File Offset: 0x002E8484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245648, XrefRangeEnd = 245758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003A1B RID: 14875
			// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x002EA2C0 File Offset: 0x002E84C0
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC05 RID: 48133 RVA: 0x002EA300 File Offset: 0x002E8500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245758, XrefRangeEnd = 245763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003A1C RID: 14876
			// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x002EA334 File Offset: 0x002E8534
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BC07 RID: 48135 RVA: 0x002EA374 File Offset: 0x002E8574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245763, XrefRangeEnd = 245772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600BC08 RID: 48136 RVA: 0x002EA3B4 File Offset: 0x002E85B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BC09 RID: 48137 RVA: 0x00057806 File Offset: 0x00055A06
			public _Targets_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A15 RID: 14869
			// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x002EA3F4 File Offset: 0x002E85F4
			// (set) Token: 0x0600BC0B RID: 48139 RVA: 0x0005780F File Offset: 0x00055A0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003A16 RID: 14870
			// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x002EA41C File Offset: 0x002E861C
			// (set) Token: 0x0600BC0D RID: 48141 RVA: 0x0005782A File Offset: 0x00055A2A
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A17 RID: 14871
			// (get) Token: 0x0600BC0E RID: 48142 RVA: 0x002EA44C File Offset: 0x002E864C
			// (set) Token: 0x0600BC0F RID: 48143 RVA: 0x00057849 File Offset: 0x00055A49
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003A18 RID: 14872
			// (get) Token: 0x0600BC10 RID: 48144 RVA: 0x002EA474 File Offset: 0x002E8674
			// (set) Token: 0x0600BC11 RID: 48145 RVA: 0x00057864 File Offset: 0x00055A64
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A19 RID: 14873
			// (get) Token: 0x0600BC12 RID: 48146 RVA: 0x002EA4A4 File Offset: 0x002E86A4
			// (set) Token: 0x0600BC13 RID: 48147 RVA: 0x00057883 File Offset: 0x00055A83
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A1A RID: 14874
			// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x002EA4D4 File Offset: 0x002E86D4
			// (set) Token: 0x0600BC15 RID: 48149 RVA: 0x000578A2 File Offset: 0x00055AA2
			public unsafe GainAnyFactionInfluenceCustomAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAnyFactionInfluenceCustomAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAnyFactionInfluenceCustomAbility._Targets_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007632 RID: 30258
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007633 RID: 30259
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007634 RID: 30260
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007635 RID: 30261
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007636 RID: 30262
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007637 RID: 30263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007638 RID: 30264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007639 RID: 30265
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400763A RID: 30266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400763B RID: 30267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x0400763C RID: 30268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400763D RID: 30269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400763E RID: 30270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x0400763F RID: 30271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

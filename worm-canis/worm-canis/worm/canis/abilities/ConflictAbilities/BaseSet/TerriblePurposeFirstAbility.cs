using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ConflictAbilities.BaseSet
{
	// Token: 0x02000418 RID: 1048
	public class TerriblePurposeFirstAbility : ConflictAbility
	{
		// Token: 0x06002D0E RID: 11534 RVA: 0x0011348C File Offset: 0x0011168C
		// Note: this type is marked as 'beforefieldinit'.
		static TerriblePurposeFirstAbility()
		{
			Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.BaseSet", "TerriblePurposeFirstAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr);
			TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, "AbilityName");
			TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, "AbilityID");
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676665);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676666);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676667);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676668);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676669);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676670);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676671);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676672);
			TerriblePurposeFirstAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, 100676673);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00113598 File Offset: 0x00111798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209937, XrefRangeEnd = 209941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x001135E4 File Offset: 0x001117E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209941, XrefRangeEnd = 209954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerriblePurposeFirstAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00113630 File Offset: 0x00111830
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerriblePurposeFirstAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x001136A0 File Offset: 0x001118A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209954, XrefRangeEnd = 209961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00113710 File Offset: 0x00111910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209961, XrefRangeEnd = 209965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00113780 File Offset: 0x00111980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209965, XrefRangeEnd = 209973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00113800 File Offset: 0x00111A00
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x0011387C File Offset: 0x00111A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209973, XrefRangeEnd = 209993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x001138F8 File Offset: 0x00111AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209993, XrefRangeEnd = 210008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TerriblePurposeFirstAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000105FF File Offset: 0x0000E7FF
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0001060E File Offset: 0x0000E80E
		public TerriblePurposeFirstAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00113954 File Offset: 0x00111B54
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00010617 File Offset: 0x0000E817
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x00113974 File Offset: 0x00111B74
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x00010629 File Offset: 0x0000E829
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerriblePurposeFirstAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x020009E1 RID: 2529
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.TerriblePurposeFirstAbility+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x06009CA5 RID: 40101 RVA: 0x0028EE0C File Offset: 0x0028D00C
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>4__this");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "match");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676675);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676676);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676677);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676678);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676679);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676680);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676681);
				TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr, 100676682);
			}

			// Token: 0x06009CA6 RID: 40102 RVA: 0x0028EF78 File Offset: 0x0028D178
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerriblePurposeFirstAbility._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009CA7 RID: 40103 RVA: 0x0028EFC0 File Offset: 0x0028D1C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CA8 RID: 40104 RVA: 0x0028EFF4 File Offset: 0x0028D1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209821, XrefRangeEnd = 209849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EF7 RID: 12023
			// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x0028F030 File Offset: 0x0028D230
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009CAA RID: 40106 RVA: 0x0028F070 File Offset: 0x0028D270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209849, XrefRangeEnd = 209854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EF8 RID: 12024
			// (get) Token: 0x06009CAB RID: 40107 RVA: 0x0028F0A4 File Offset: 0x0028D2A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009CAC RID: 40108 RVA: 0x0028F0E4 File Offset: 0x0028D2E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209854, XrefRangeEnd = 209864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009CAD RID: 40109 RVA: 0x0028F124 File Offset: 0x0028D324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009CAE RID: 40110 RVA: 0x0004583E File Offset: 0x00043A3E
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002EEF RID: 12015
			// (get) Token: 0x06009CAF RID: 40111 RVA: 0x0028F164 File Offset: 0x0028D364
			// (set) Token: 0x06009CB0 RID: 40112 RVA: 0x00045847 File Offset: 0x00043A47
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EF0 RID: 12016
			// (get) Token: 0x06009CB1 RID: 40113 RVA: 0x0028F18C File Offset: 0x0028D38C
			// (set) Token: 0x06009CB2 RID: 40114 RVA: 0x00045862 File Offset: 0x00043A62
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF1 RID: 12017
			// (get) Token: 0x06009CB3 RID: 40115 RVA: 0x0028F1BC File Offset: 0x0028D3BC
			// (set) Token: 0x06009CB4 RID: 40116 RVA: 0x00045881 File Offset: 0x00043A81
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002EF2 RID: 12018
			// (get) Token: 0x06009CB5 RID: 40117 RVA: 0x0028F1E4 File Offset: 0x0028D3E4
			// (set) Token: 0x06009CB6 RID: 40118 RVA: 0x0004589C File Offset: 0x00043A9C
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF3 RID: 12019
			// (get) Token: 0x06009CB7 RID: 40119 RVA: 0x0028F214 File Offset: 0x0028D414
			// (set) Token: 0x06009CB8 RID: 40120 RVA: 0x000458BB File Offset: 0x00043ABB
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF4 RID: 12020
			// (get) Token: 0x06009CB9 RID: 40121 RVA: 0x0028F244 File Offset: 0x0028D444
			// (set) Token: 0x06009CBA RID: 40122 RVA: 0x000458DA File Offset: 0x00043ADA
			public unsafe TerriblePurposeFirstAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerriblePurposeFirstAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF5 RID: 12021
			// (get) Token: 0x06009CBB RID: 40123 RVA: 0x0028F274 File Offset: 0x0028D474
			// (set) Token: 0x06009CBC RID: 40124 RVA: 0x000458F9 File Offset: 0x00043AF9
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF6 RID: 12022
			// (get) Token: 0x06009CBD RID: 40125 RVA: 0x0028F2A4 File Offset: 0x0028D4A4
			// (set) Token: 0x06009CBE RID: 40126 RVA: 0x00045918 File Offset: 0x00043B18
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006399 RID: 25497
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400639A RID: 25498
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400639B RID: 25499
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400639C RID: 25500
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400639D RID: 25501
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400639E RID: 25502
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400639F RID: 25503
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040063A0 RID: 25504
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040063A1 RID: 25505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040063A2 RID: 25506
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040063A3 RID: 25507
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040063A4 RID: 25508
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040063A5 RID: 25509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040063A6 RID: 25510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040063A7 RID: 25511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040063A8 RID: 25512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020009E2 RID: 2530
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.TerriblePurposeFirstAbility+<Targets>d__5")]
		public sealed class _Targets_d__5 : Object
		{
			// Token: 0x06009CBF RID: 40127 RVA: 0x0028F2D4 File Offset: 0x0028D4D4
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__5()
			{
				Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerriblePurposeFirstAbility>.NativeClassPtr, "<Targets>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr);
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "<>1__state");
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "<>2__current");
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "<>l__initialThreadId");
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "context");
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "<>3__context");
				TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, "<>4__this");
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676683);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676684);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676685);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676686);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676687);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676688);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676689);
				TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr, 100676690);
			}

			// Token: 0x06009CC0 RID: 40128 RVA: 0x0028F418 File Offset: 0x0028D618
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerriblePurposeFirstAbility._Targets_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009CC1 RID: 40129 RVA: 0x0028F460 File Offset: 0x0028D660
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CC2 RID: 40130 RVA: 0x0028F494 File Offset: 0x0028D694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209864, XrefRangeEnd = 209923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EFF RID: 12031
			// (get) Token: 0x06009CC3 RID: 40131 RVA: 0x0028F4D0 File Offset: 0x0028D6D0
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06009CC4 RID: 40132 RVA: 0x0028F510 File Offset: 0x0028D710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209923, XrefRangeEnd = 209928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002F00 RID: 12032
			// (get) Token: 0x06009CC5 RID: 40133 RVA: 0x0028F544 File Offset: 0x0028D744
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009CC6 RID: 40134 RVA: 0x0028F584 File Offset: 0x0028D784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209928, XrefRangeEnd = 209937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x06009CC7 RID: 40135 RVA: 0x0028F5C4 File Offset: 0x0028D7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurposeFirstAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009CC8 RID: 40136 RVA: 0x00045937 File Offset: 0x00043B37
			public _Targets_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002EF9 RID: 12025
			// (get) Token: 0x06009CC9 RID: 40137 RVA: 0x0028F604 File Offset: 0x0028D804
			// (set) Token: 0x06009CCA RID: 40138 RVA: 0x00045940 File Offset: 0x00043B40
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EFA RID: 12026
			// (get) Token: 0x06009CCB RID: 40139 RVA: 0x0028F62C File Offset: 0x0028D82C
			// (set) Token: 0x06009CCC RID: 40140 RVA: 0x0004595B File Offset: 0x00043B5B
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EFB RID: 12027
			// (get) Token: 0x06009CCD RID: 40141 RVA: 0x0028F65C File Offset: 0x0028D85C
			// (set) Token: 0x06009CCE RID: 40142 RVA: 0x0004597A File Offset: 0x00043B7A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002EFC RID: 12028
			// (get) Token: 0x06009CCF RID: 40143 RVA: 0x0028F684 File Offset: 0x0028D884
			// (set) Token: 0x06009CD0 RID: 40144 RVA: 0x00045995 File Offset: 0x00043B95
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EFD RID: 12029
			// (get) Token: 0x06009CD1 RID: 40145 RVA: 0x0028F6B4 File Offset: 0x0028D8B4
			// (set) Token: 0x06009CD2 RID: 40146 RVA: 0x000459B4 File Offset: 0x00043BB4
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EFE RID: 12030
			// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x0028F6E4 File Offset: 0x0028D8E4
			// (set) Token: 0x06009CD4 RID: 40148 RVA: 0x000459D3 File Offset: 0x00043BD3
			public unsafe TerriblePurposeFirstAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerriblePurposeFirstAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerriblePurposeFirstAbility._Targets_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040063A9 RID: 25513
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040063AA RID: 25514
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040063AB RID: 25515
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040063AC RID: 25516
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040063AD RID: 25517
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040063AE RID: 25518
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040063AF RID: 25519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040063B0 RID: 25520
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040063B1 RID: 25521
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040063B2 RID: 25522
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040063B3 RID: 25523
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040063B4 RID: 25524
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040063B5 RID: 25525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040063B6 RID: 25526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

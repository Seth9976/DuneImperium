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
using worm.canis.entities;

namespace worm.canis.abilities.ConflictAbilities.BaseSet
{
	// Token: 0x020003E8 RID: 1000
	public class BattleForCarthagFirstAbility : ConflictAbility
	{
		// Token: 0x06002A64 RID: 10852 RVA: 0x00106AB4 File Offset: 0x00104CB4
		// Note: this type is marked as 'beforefieldinit'.
		static BattleForCarthagFirstAbility()
		{
			Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.BaseSet", "BattleForCarthagFirstAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr);
			BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, "AbilityName");
			BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, "AbilityID");
			BattleForCarthagFirstAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675840);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675841);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675842);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675843);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675844);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675845);
			BattleForCarthagFirstAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, 100675846);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00106B98 File Offset: 0x00104D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204775, XrefRangeEnd = 204779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagFirstAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00106BE4 File Offset: 0x00104DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204779, XrefRangeEnd = 204792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleForCarthagFirstAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00106C30 File Offset: 0x00104E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleForCarthagFirstAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00106CA0 File Offset: 0x00104EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204792, XrefRangeEnd = 204796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagFirstAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00106D10 File Offset: 0x00104F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204796, XrefRangeEnd = 204805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagFirstAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00106D90 File Offset: 0x00104F90
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagFirstAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00106E0C File Offset: 0x0010500C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204805, XrefRangeEnd = 204820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagFirstAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0000FABF File Offset: 0x0000DCBF
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public BattleForCarthagFirstAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x00106E88 File Offset: 0x00105088
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x0000FAD7 File Offset: 0x0000DCD7
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x00106EA8 File Offset: 0x001050A8
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleForCarthagFirstAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x020009AA RID: 2474
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.BattleForCarthagFirstAbility+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x0600972C RID: 38700 RVA: 0x0027ECCC File Offset: 0x0027CECC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleForCarthagFirstAbility>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>4__this");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "match");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "context");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__context");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<player>5__2");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>7__wrap2");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, "<>7__wrap3");
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675848);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675849);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675850);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675851);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675852);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675853);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675854);
				BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr, 100675855);
			}

			// Token: 0x0600972D RID: 38701 RVA: 0x0027EE9C File Offset: 0x0027D09C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagFirstAbility._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600972E RID: 38702 RVA: 0x0027EEE4 File Offset: 0x0027D0E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600972F RID: 38703 RVA: 0x0027EF18 File Offset: 0x0027D118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204721, XrefRangeEnd = 204759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002CE5 RID: 11493
			// (get) Token: 0x06009730 RID: 38704 RVA: 0x0027EF54 File Offset: 0x0027D154
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009731 RID: 38705 RVA: 0x0027EF94 File Offset: 0x0027D194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204759, XrefRangeEnd = 204764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002CE6 RID: 11494
			// (get) Token: 0x06009732 RID: 38706 RVA: 0x0027EFC8 File Offset: 0x0027D1C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009733 RID: 38707 RVA: 0x0027F008 File Offset: 0x0027D208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204764, XrefRangeEnd = 204775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009734 RID: 38708 RVA: 0x0027F048 File Offset: 0x0027D248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009735 RID: 38709 RVA: 0x0004243C File Offset: 0x0004063C
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002CD8 RID: 11480
			// (get) Token: 0x06009736 RID: 38710 RVA: 0x0027F088 File Offset: 0x0027D288
			// (set) Token: 0x06009737 RID: 38711 RVA: 0x00042445 File Offset: 0x00040645
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002CD9 RID: 11481
			// (get) Token: 0x06009738 RID: 38712 RVA: 0x0027F0B0 File Offset: 0x0027D2B0
			// (set) Token: 0x06009739 RID: 38713 RVA: 0x00042460 File Offset: 0x00040660
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDA RID: 11482
			// (get) Token: 0x0600973A RID: 38714 RVA: 0x0027F0E0 File Offset: 0x0027D2E0
			// (set) Token: 0x0600973B RID: 38715 RVA: 0x0004247F File Offset: 0x0004067F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002CDB RID: 11483
			// (get) Token: 0x0600973C RID: 38716 RVA: 0x0027F108 File Offset: 0x0027D308
			// (set) Token: 0x0600973D RID: 38717 RVA: 0x0004249A File Offset: 0x0004069A
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDC RID: 11484
			// (get) Token: 0x0600973E RID: 38718 RVA: 0x0027F138 File Offset: 0x0027D338
			// (set) Token: 0x0600973F RID: 38719 RVA: 0x000424B9 File Offset: 0x000406B9
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDD RID: 11485
			// (get) Token: 0x06009740 RID: 38720 RVA: 0x0027F168 File Offset: 0x0027D368
			// (set) Token: 0x06009741 RID: 38721 RVA: 0x000424D8 File Offset: 0x000406D8
			public unsafe BattleForCarthagFirstAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleForCarthagFirstAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDE RID: 11486
			// (get) Token: 0x06009742 RID: 38722 RVA: 0x0027F198 File Offset: 0x0027D398
			// (set) Token: 0x06009743 RID: 38723 RVA: 0x000424F7 File Offset: 0x000406F7
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDF RID: 11487
			// (get) Token: 0x06009744 RID: 38724 RVA: 0x0027F1C8 File Offset: 0x0027D3C8
			// (set) Token: 0x06009745 RID: 38725 RVA: 0x00042516 File Offset: 0x00040716
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE0 RID: 11488
			// (get) Token: 0x06009746 RID: 38726 RVA: 0x0027F1F8 File Offset: 0x0027D3F8
			// (set) Token: 0x06009747 RID: 38727 RVA: 0x00042535 File Offset: 0x00040735
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE1 RID: 11489
			// (get) Token: 0x06009748 RID: 38728 RVA: 0x0027F228 File Offset: 0x0027D428
			// (set) Token: 0x06009749 RID: 38729 RVA: 0x00042554 File Offset: 0x00040754
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE2 RID: 11490
			// (get) Token: 0x0600974A RID: 38730 RVA: 0x0027F258 File Offset: 0x0027D458
			// (set) Token: 0x0600974B RID: 38731 RVA: 0x00042573 File Offset: 0x00040773
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE3 RID: 11491
			// (get) Token: 0x0600974C RID: 38732 RVA: 0x0027F288 File Offset: 0x0027D488
			// (set) Token: 0x0600974D RID: 38733 RVA: 0x00042592 File Offset: 0x00040792
			public unsafe Il2CppReferenceArray<ArchetypeID> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE4 RID: 11492
			// (get) Token: 0x0600974E RID: 38734 RVA: 0x0027F2B8 File Offset: 0x0027D4B8
			// (set) Token: 0x0600974F RID: 38735 RVA: 0x000425B1 File Offset: 0x000407B1
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagFirstAbility._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x0400603D RID: 24637
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400603E RID: 24638
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400603F RID: 24639
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006040 RID: 24640
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006041 RID: 24641
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006042 RID: 24642
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006043 RID: 24643
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006044 RID: 24644
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006045 RID: 24645
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006046 RID: 24646
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006047 RID: 24647
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04006048 RID: 24648
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006049 RID: 24649
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400604A RID: 24650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400604B RID: 24651
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400604C RID: 24652
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400604D RID: 24653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400604E RID: 24654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400604F RID: 24655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006050 RID: 24656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006051 RID: 24657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

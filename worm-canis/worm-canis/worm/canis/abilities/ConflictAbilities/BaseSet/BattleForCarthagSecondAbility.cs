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
	// Token: 0x020003E9 RID: 1001
	public class BattleForCarthagSecondAbility : ConflictAbility
	{
		// Token: 0x06002A72 RID: 10866 RVA: 0x00106ED0 File Offset: 0x001050D0
		// Note: this type is marked as 'beforefieldinit'.
		static BattleForCarthagSecondAbility()
		{
			Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.BaseSet", "BattleForCarthagSecondAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr);
			BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, "AbilityName");
			BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, "AbilityID");
			BattleForCarthagSecondAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675856);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675857);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675858);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675859);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675860);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675861);
			BattleForCarthagSecondAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, 100675862);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00106FB4 File Offset: 0x001051B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204854, XrefRangeEnd = 204858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagSecondAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00107000 File Offset: 0x00105200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204858, XrefRangeEnd = 204871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleForCarthagSecondAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0010704C File Offset: 0x0010524C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleForCarthagSecondAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x001070BC File Offset: 0x001052BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204871, XrefRangeEnd = 204875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagSecondAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0010712C File Offset: 0x0010532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204875, XrefRangeEnd = 204882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagSecondAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x001071AC File Offset: 0x001053AC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagSecondAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00107228 File Offset: 0x00105428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204882, XrefRangeEnd = 204901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BattleForCarthagSecondAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0000FAFB File Offset: 0x0000DCFB
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0000FB0A File Offset: 0x0000DD0A
		public BattleForCarthagSecondAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x001072A4 File Offset: 0x001054A4
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0000FB13 File Offset: 0x0000DD13
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x001072C4 File Offset: 0x001054C4
		// (set) Token: 0x06002A7F RID: 10879 RVA: 0x0000FB25 File Offset: 0x0000DD25
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleForCarthagSecondAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x020009AB RID: 2475
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.BattleForCarthagSecondAbility+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x06009750 RID: 38736 RVA: 0x0027F2E0 File Offset: 0x0027D4E0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleForCarthagSecondAbility>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "match");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, "<player>5__2");
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675864);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675865);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675866);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675867);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675868);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675869);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675870);
				BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr, 100675871);
			}

			// Token: 0x06009751 RID: 38737 RVA: 0x0027F44C File Offset: 0x0027D64C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleForCarthagSecondAbility._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009752 RID: 38738 RVA: 0x0027F494 File Offset: 0x0027D694
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009753 RID: 38739 RVA: 0x0027F4C8 File Offset: 0x0027D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204820, XrefRangeEnd = 204840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002CEF RID: 11503
			// (get) Token: 0x06009754 RID: 38740 RVA: 0x0027F504 File Offset: 0x0027D704
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009755 RID: 38741 RVA: 0x0027F544 File Offset: 0x0027D744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204840, XrefRangeEnd = 204845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002CF0 RID: 11504
			// (get) Token: 0x06009756 RID: 38742 RVA: 0x0027F578 File Offset: 0x0027D778
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009757 RID: 38743 RVA: 0x0027F5B8 File Offset: 0x0027D7B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204845, XrefRangeEnd = 204854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009758 RID: 38744 RVA: 0x0027F5F8 File Offset: 0x0027D7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009759 RID: 38745 RVA: 0x000425CC File Offset: 0x000407CC
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002CE7 RID: 11495
			// (get) Token: 0x0600975A RID: 38746 RVA: 0x0027F638 File Offset: 0x0027D838
			// (set) Token: 0x0600975B RID: 38747 RVA: 0x000425D5 File Offset: 0x000407D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002CE8 RID: 11496
			// (get) Token: 0x0600975C RID: 38748 RVA: 0x0027F660 File Offset: 0x0027D860
			// (set) Token: 0x0600975D RID: 38749 RVA: 0x000425F0 File Offset: 0x000407F0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE9 RID: 11497
			// (get) Token: 0x0600975E RID: 38750 RVA: 0x0027F690 File Offset: 0x0027D890
			// (set) Token: 0x0600975F RID: 38751 RVA: 0x0004260F File Offset: 0x0004080F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002CEA RID: 11498
			// (get) Token: 0x06009760 RID: 38752 RVA: 0x0027F6B8 File Offset: 0x0027D8B8
			// (set) Token: 0x06009761 RID: 38753 RVA: 0x0004262A File Offset: 0x0004082A
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEB RID: 11499
			// (get) Token: 0x06009762 RID: 38754 RVA: 0x0027F6E8 File Offset: 0x0027D8E8
			// (set) Token: 0x06009763 RID: 38755 RVA: 0x00042649 File Offset: 0x00040849
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEC RID: 11500
			// (get) Token: 0x06009764 RID: 38756 RVA: 0x0027F718 File Offset: 0x0027D918
			// (set) Token: 0x06009765 RID: 38757 RVA: 0x00042668 File Offset: 0x00040868
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CED RID: 11501
			// (get) Token: 0x06009766 RID: 38758 RVA: 0x0027F748 File Offset: 0x0027D948
			// (set) Token: 0x06009767 RID: 38759 RVA: 0x00042687 File Offset: 0x00040887
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CEE RID: 11502
			// (get) Token: 0x06009768 RID: 38760 RVA: 0x0027F778 File Offset: 0x0027D978
			// (set) Token: 0x06009769 RID: 38761 RVA: 0x000426A6 File Offset: 0x000408A6
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleForCarthagSecondAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006052 RID: 24658
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006053 RID: 24659
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006054 RID: 24660
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006055 RID: 24661
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006056 RID: 24662
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006057 RID: 24663
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006058 RID: 24664
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006059 RID: 24665
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400605A RID: 24666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400605B RID: 24667
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400605C RID: 24668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400605D RID: 24669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400605E RID: 24670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400605F RID: 24671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006060 RID: 24672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006061 RID: 24673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

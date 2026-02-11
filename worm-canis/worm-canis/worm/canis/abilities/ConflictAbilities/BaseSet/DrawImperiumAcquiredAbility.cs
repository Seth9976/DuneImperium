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
using worm.canis.abilities.ActivatedAbilities.RiseOfIx.TechTileAcquiredAbilities;
using worm.canis.entities;

namespace worm.canis.abilities.ConflictAbilities.BaseSet
{
	// Token: 0x020003E1 RID: 993
	public class DrawImperiumAcquiredAbility : TechTileAcquiredAbility
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x00104DD8 File Offset: 0x00102FD8
		// Note: this type is marked as 'beforefieldinit'.
		static DrawImperiumAcquiredAbility()
		{
			Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.BaseSet", "DrawImperiumAcquiredAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr);
			DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, "AbilityName");
			DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, "AbilityID");
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675680);
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675681);
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675682);
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675683);
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675684);
			DrawImperiumAcquiredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, 100675685);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00104EA8 File Offset: 0x001030A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203227, XrefRangeEnd = 203231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawImperiumAcquiredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00104EF4 File Offset: 0x001030F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203231, XrefRangeEnd = 203247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawImperiumAcquiredAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00104F40 File Offset: 0x00103140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203247, XrefRangeEnd = 203251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawImperiumAcquiredAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00104FB0 File Offset: 0x001031B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203251, XrefRangeEnd = 203260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawImperiumAcquiredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00105020 File Offset: 0x00103220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203260, XrefRangeEnd = 203268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> CustomExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawImperiumAcquiredAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x001050A0 File Offset: 0x001032A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203268, XrefRangeEnd = 203284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawImperiumAcquiredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0000F91B File Offset: 0x0000DB1B
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x0000F92A File Offset: 0x0000DB2A
		public DrawImperiumAcquiredAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0010511C File Offset: 0x0010331C
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x0000F933 File Offset: 0x0000DB33
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0010513C File Offset: 0x0010333C
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x0000F945 File Offset: 0x0000DB45
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawImperiumAcquiredAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x0200099C RID: 2460
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.DrawImperiumAcquiredAbility+<CustomExecution>d__6")]
		public sealed class _CustomExecution_d__6 : Object
		{
			// Token: 0x060095D6 RID: 38358 RVA: 0x0027AE38 File Offset: 0x00279038
			// Note: this type is marked as 'beforefieldinit'.
			static _CustomExecution_d__6()
			{
				Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawImperiumAcquiredAbility>.NativeClassPtr, "<CustomExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>1__state");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>2__current");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "activeAbility");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>4__this");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "match");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<>3__match");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<player>5__2");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, "<sequenceHelper>5__3");
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675687);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675688);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675689);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675690);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675691);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675692);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675693);
				DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr, 100675694);
			}

			// Token: 0x060095D7 RID: 38359 RVA: 0x0027AFCC File Offset: 0x002791CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CustomExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImperiumAcquiredAbility._CustomExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060095D8 RID: 38360 RVA: 0x0027B014 File Offset: 0x00279214
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095D9 RID: 38361 RVA: 0x0027B048 File Offset: 0x00279248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203190, XrefRangeEnd = 203212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002C63 RID: 11363
			// (get) Token: 0x060095DA RID: 38362 RVA: 0x0027B084 File Offset: 0x00279284
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060095DB RID: 38363 RVA: 0x0027B0C4 File Offset: 0x002792C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203212, XrefRangeEnd = 203217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C64 RID: 11364
			// (get) Token: 0x060095DC RID: 38364 RVA: 0x0027B0F8 File Offset: 0x002792F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060095DD RID: 38365 RVA: 0x0027B138 File Offset: 0x00279338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203217, XrefRangeEnd = 203227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060095DE RID: 38366 RVA: 0x0027B178 File Offset: 0x00279378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060095DF RID: 38367 RVA: 0x000417EF File Offset: 0x0003F9EF
			public _CustomExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002C59 RID: 11353
			// (get) Token: 0x060095E0 RID: 38368 RVA: 0x0027B1B8 File Offset: 0x002793B8
			// (set) Token: 0x060095E1 RID: 38369 RVA: 0x000417F8 File Offset: 0x0003F9F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C5A RID: 11354
			// (get) Token: 0x060095E2 RID: 38370 RVA: 0x0027B1E0 File Offset: 0x002793E0
			// (set) Token: 0x060095E3 RID: 38371 RVA: 0x00041813 File Offset: 0x0003FA13
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5B RID: 11355
			// (get) Token: 0x060095E4 RID: 38372 RVA: 0x0027B210 File Offset: 0x00279410
			// (set) Token: 0x060095E5 RID: 38373 RVA: 0x00041832 File Offset: 0x0003FA32
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002C5C RID: 11356
			// (get) Token: 0x060095E6 RID: 38374 RVA: 0x0027B238 File Offset: 0x00279438
			// (set) Token: 0x060095E7 RID: 38375 RVA: 0x0004184D File Offset: 0x0003FA4D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5D RID: 11357
			// (get) Token: 0x060095E8 RID: 38376 RVA: 0x0027B268 File Offset: 0x00279468
			// (set) Token: 0x060095E9 RID: 38377 RVA: 0x0004186C File Offset: 0x0003FA6C
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5E RID: 11358
			// (get) Token: 0x060095EA RID: 38378 RVA: 0x0027B298 File Offset: 0x00279498
			// (set) Token: 0x060095EB RID: 38379 RVA: 0x0004188B File Offset: 0x0003FA8B
			public unsafe DrawImperiumAcquiredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawImperiumAcquiredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5F RID: 11359
			// (get) Token: 0x060095EC RID: 38380 RVA: 0x0027B2C8 File Offset: 0x002794C8
			// (set) Token: 0x060095ED RID: 38381 RVA: 0x000418AA File Offset: 0x0003FAAA
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C60 RID: 11360
			// (get) Token: 0x060095EE RID: 38382 RVA: 0x0027B2F8 File Offset: 0x002794F8
			// (set) Token: 0x060095EF RID: 38383 RVA: 0x000418C9 File Offset: 0x0003FAC9
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C61 RID: 11361
			// (get) Token: 0x060095F0 RID: 38384 RVA: 0x0027B328 File Offset: 0x00279528
			// (set) Token: 0x060095F1 RID: 38385 RVA: 0x000418E8 File Offset: 0x0003FAE8
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C62 RID: 11362
			// (get) Token: 0x060095F2 RID: 38386 RVA: 0x0027B358 File Offset: 0x00279558
			// (set) Token: 0x060095F3 RID: 38387 RVA: 0x00041907 File Offset: 0x0003FB07
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImperiumAcquiredAbility._CustomExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F6E RID: 24430
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005F6F RID: 24431
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005F70 RID: 24432
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005F71 RID: 24433
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005F72 RID: 24434
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005F73 RID: 24435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F74 RID: 24436
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005F75 RID: 24437
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005F76 RID: 24438
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005F77 RID: 24439
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x04005F78 RID: 24440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005F79 RID: 24441
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005F7A RID: 24442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005F7B RID: 24443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005F7C RID: 24444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005F7D RID: 24445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005F7E RID: 24446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005F7F RID: 24447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

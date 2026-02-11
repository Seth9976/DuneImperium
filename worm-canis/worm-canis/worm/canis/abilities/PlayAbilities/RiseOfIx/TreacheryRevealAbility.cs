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

namespace worm.canis.abilities.PlayAbilities.RiseOfIx
{
	// Token: 0x02000449 RID: 1097
	public class TreacheryRevealAbility : RevealAbility
	{
		// Token: 0x06002FE7 RID: 12263 RVA: 0x00121AFC File Offset: 0x0011FCFC
		// Note: this type is marked as 'beforefieldinit'.
		static TreacheryRevealAbility()
		{
			Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.RiseOfIx", "TreacheryRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr);
			TreacheryRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, "AbilityName");
			TreacheryRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, "AbilityID");
			TreacheryRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677919);
			TreacheryRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677920);
			TreacheryRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677921);
			TreacheryRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677922);
			TreacheryRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677923);
			TreacheryRevealAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677924);
			TreacheryRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, 100677926);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00121BE0 File Offset: 0x0011FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222262, XrefRangeEnd = 222266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreacheryRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00121C2C File Offset: 0x0011FE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222266, XrefRangeEnd = 222272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreacheryRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00121C78 File Offset: 0x0011FE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222272, XrefRangeEnd = 222276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreacheryRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222276, XrefRangeEnd = 222285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreacheryRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00121D68 File Offset: 0x0011FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222285, XrefRangeEnd = 222305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreacheryRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00121DE4 File Offset: 0x0011FFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222305, XrefRangeEnd = 222313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00121E6C File Offset: 0x0012006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00010FDD File Offset: 0x0000F1DD
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00010FEC File Offset: 0x0000F1EC
		public TreacheryRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x00121EE0 File Offset: 0x001200E0
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x00010FF5 File Offset: 0x0000F1F5
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TreacheryRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TreacheryRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x00121F00 File Offset: 0x00120100
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x00011007 File Offset: 0x0000F207
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TreacheryRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TreacheryRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000A6E RID: 2670
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.TreacheryRevealAbility+<BeginExecution>d__5")]
		public sealed class _BeginExecution_d__5 : Object
		{
			// Token: 0x0600A6ED RID: 42733 RVA: 0x002ACD08 File Offset: 0x002AAF08
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__5()
			{
				Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, "<BeginExecution>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr);
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>1__state");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>2__current");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>l__initialThreadId");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "activeAbility");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__activeAbility");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>4__this");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "match");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__match");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "context");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__context");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<player>5__2");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__troopCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<troopCount>5__3");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<sequenceHelper>5__4");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__undeployedTroops_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<undeployedTroops>5__5");
				TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>7__wrap5");
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677927);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677928);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677929);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677930);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677931);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677932);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677933);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677934);
				TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677935);
			}

			// Token: 0x0600A6EE RID: 42734 RVA: 0x002ACF14 File Offset: 0x002AB114
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreacheryRevealAbility._BeginExecution_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A6EF RID: 42735 RVA: 0x002ACF5C File Offset: 0x002AB15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222096, XrefRangeEnd = 222099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6F0 RID: 42736 RVA: 0x002ACF90 File Offset: 0x002AB190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222099, XrefRangeEnd = 222203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F1 RID: 42737 RVA: 0x002ACFCC File Offset: 0x002AB1CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222206, RefRangeEnd = 222207, XrefRangeStart = 222203, XrefRangeEnd = 222206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700329E RID: 12958
			// (get) Token: 0x0600A6F2 RID: 42738 RVA: 0x002AD000 File Offset: 0x002AB200
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A6F3 RID: 42739 RVA: 0x002AD040 File Offset: 0x002AB240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222207, XrefRangeEnd = 222212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700329F RID: 12959
			// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x002AD074 File Offset: 0x002AB274
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A6F5 RID: 42741 RVA: 0x002AD0B4 File Offset: 0x002AB2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222212, XrefRangeEnd = 222223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A6F6 RID: 42742 RVA: 0x002AD0F4 File Offset: 0x002AB2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A6F7 RID: 42743 RVA: 0x0004B63A File Offset: 0x0004983A
			public _BeginExecution_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700328F RID: 12943
			// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x002AD134 File Offset: 0x002AB334
			// (set) Token: 0x0600A6F9 RID: 42745 RVA: 0x0004B643 File Offset: 0x00049843
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003290 RID: 12944
			// (get) Token: 0x0600A6FA RID: 42746 RVA: 0x002AD15C File Offset: 0x002AB35C
			// (set) Token: 0x0600A6FB RID: 42747 RVA: 0x0004B65E File Offset: 0x0004985E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003291 RID: 12945
			// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x002AD18C File Offset: 0x002AB38C
			// (set) Token: 0x0600A6FD RID: 42749 RVA: 0x0004B67D File Offset: 0x0004987D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003292 RID: 12946
			// (get) Token: 0x0600A6FE RID: 42750 RVA: 0x002AD1B4 File Offset: 0x002AB3B4
			// (set) Token: 0x0600A6FF RID: 42751 RVA: 0x0004B698 File Offset: 0x00049898
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003293 RID: 12947
			// (get) Token: 0x0600A700 RID: 42752 RVA: 0x002AD1E4 File Offset: 0x002AB3E4
			// (set) Token: 0x0600A701 RID: 42753 RVA: 0x0004B6B7 File Offset: 0x000498B7
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003294 RID: 12948
			// (get) Token: 0x0600A702 RID: 42754 RVA: 0x002AD214 File Offset: 0x002AB414
			// (set) Token: 0x0600A703 RID: 42755 RVA: 0x0004B6D6 File Offset: 0x000498D6
			public unsafe TreacheryRevealAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreacheryRevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003295 RID: 12949
			// (get) Token: 0x0600A704 RID: 42756 RVA: 0x002AD244 File Offset: 0x002AB444
			// (set) Token: 0x0600A705 RID: 42757 RVA: 0x0004B6F5 File Offset: 0x000498F5
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003296 RID: 12950
			// (get) Token: 0x0600A706 RID: 42758 RVA: 0x002AD274 File Offset: 0x002AB474
			// (set) Token: 0x0600A707 RID: 42759 RVA: 0x0004B714 File Offset: 0x00049914
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003297 RID: 12951
			// (get) Token: 0x0600A708 RID: 42760 RVA: 0x002AD2A4 File Offset: 0x002AB4A4
			// (set) Token: 0x0600A709 RID: 42761 RVA: 0x0004B733 File Offset: 0x00049933
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003298 RID: 12952
			// (get) Token: 0x0600A70A RID: 42762 RVA: 0x002AD2D4 File Offset: 0x002AB4D4
			// (set) Token: 0x0600A70B RID: 42763 RVA: 0x0004B752 File Offset: 0x00049952
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003299 RID: 12953
			// (get) Token: 0x0600A70C RID: 42764 RVA: 0x002AD304 File Offset: 0x002AB504
			// (set) Token: 0x0600A70D RID: 42765 RVA: 0x0004B771 File Offset: 0x00049971
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700329A RID: 12954
			// (get) Token: 0x0600A70E RID: 42766 RVA: 0x002AD334 File Offset: 0x002AB534
			// (set) Token: 0x0600A70F RID: 42767 RVA: 0x0004B790 File Offset: 0x00049990
			public unsafe int _troopCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__troopCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__troopCount_5__3)) = value;
				}
			}

			// Token: 0x1700329B RID: 12955
			// (get) Token: 0x0600A710 RID: 42768 RVA: 0x002AD35C File Offset: 0x002AB55C
			// (set) Token: 0x0600A711 RID: 42769 RVA: 0x0004B7AB File Offset: 0x000499AB
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700329C RID: 12956
			// (get) Token: 0x0600A712 RID: 42770 RVA: 0x002AD38C File Offset: 0x002AB58C
			// (set) Token: 0x0600A713 RID: 42771 RVA: 0x0004B7CA File Offset: 0x000499CA
			public unsafe int _undeployedTroops_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__undeployedTroops_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__undeployedTroops_5__5)) = value;
				}
			}

			// Token: 0x1700329D RID: 12957
			// (get) Token: 0x0600A714 RID: 42772 RVA: 0x002AD3B4 File Offset: 0x002AB5B4
			// (set) Token: 0x0600A715 RID: 42773 RVA: 0x0004B7E5 File Offset: 0x000499E5
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069B1 RID: 27057
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040069B2 RID: 27058
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040069B3 RID: 27059
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040069B4 RID: 27060
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040069B5 RID: 27061
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040069B6 RID: 27062
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040069B7 RID: 27063
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040069B8 RID: 27064
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040069B9 RID: 27065
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040069BA RID: 27066
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040069BB RID: 27067
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040069BC RID: 27068
			private static readonly IntPtr NativeFieldInfoPtr__troopCount_5__3;

			// Token: 0x040069BD RID: 27069
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x040069BE RID: 27070
			private static readonly IntPtr NativeFieldInfoPtr__undeployedTroops_5__5;

			// Token: 0x040069BF RID: 27071
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040069C0 RID: 27072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040069C1 RID: 27073
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069C2 RID: 27074
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040069C3 RID: 27075
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040069C4 RID: 27076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040069C5 RID: 27077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069C6 RID: 27078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040069C7 RID: 27079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040069C8 RID: 27080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A6F RID: 2671
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.TreacheryRevealAbility+<Undo>d__7")]
		public sealed class _Undo_d__7 : Object
		{
			// Token: 0x0600A716 RID: 42774 RVA: 0x002AD3E4 File Offset: 0x002AB5E4
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__7()
			{
				Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreacheryRevealAbility>.NativeClassPtr, "<Undo>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr);
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>1__state");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>2__current");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "node");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>3__node");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "match");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>3__match");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "player");
				TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, "<>3__player");
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677936);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677937);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677938);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677939);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677940);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677941);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677942);
				TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr, 100677943);
			}

			// Token: 0x0600A717 RID: 42775 RVA: 0x002AD564 File Offset: 0x002AB764
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreacheryRevealAbility._Undo_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A718 RID: 42776 RVA: 0x002AD5AC File Offset: 0x002AB7AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A719 RID: 42777 RVA: 0x002AD5E0 File Offset: 0x002AB7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222223, XrefRangeEnd = 222247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170032A9 RID: 12969
			// (get) Token: 0x0600A71A RID: 42778 RVA: 0x002AD61C File Offset: 0x002AB81C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A71B RID: 42779 RVA: 0x002AD65C File Offset: 0x002AB85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222247, XrefRangeEnd = 222252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170032AA RID: 12970
			// (get) Token: 0x0600A71C RID: 42780 RVA: 0x002AD690 File Offset: 0x002AB890
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A71D RID: 42781 RVA: 0x002AD6D0 File Offset: 0x002AB8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222252, XrefRangeEnd = 222262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A71E RID: 42782 RVA: 0x002AD710 File Offset: 0x002AB910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreacheryRevealAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A71F RID: 42783 RVA: 0x0004B804 File Offset: 0x00049A04
			public _Undo_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170032A0 RID: 12960
			// (get) Token: 0x0600A720 RID: 42784 RVA: 0x002AD750 File Offset: 0x002AB950
			// (set) Token: 0x0600A721 RID: 42785 RVA: 0x0004B80D File Offset: 0x00049A0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170032A1 RID: 12961
			// (get) Token: 0x0600A722 RID: 42786 RVA: 0x002AD778 File Offset: 0x002AB978
			// (set) Token: 0x0600A723 RID: 42787 RVA: 0x0004B828 File Offset: 0x00049A28
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A2 RID: 12962
			// (get) Token: 0x0600A724 RID: 42788 RVA: 0x002AD7A8 File Offset: 0x002AB9A8
			// (set) Token: 0x0600A725 RID: 42789 RVA: 0x0004B847 File Offset: 0x00049A47
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170032A3 RID: 12963
			// (get) Token: 0x0600A726 RID: 42790 RVA: 0x002AD7D0 File Offset: 0x002AB9D0
			// (set) Token: 0x0600A727 RID: 42791 RVA: 0x0004B862 File Offset: 0x00049A62
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A4 RID: 12964
			// (get) Token: 0x0600A728 RID: 42792 RVA: 0x002AD800 File Offset: 0x002ABA00
			// (set) Token: 0x0600A729 RID: 42793 RVA: 0x0004B881 File Offset: 0x00049A81
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A5 RID: 12965
			// (get) Token: 0x0600A72A RID: 42794 RVA: 0x002AD830 File Offset: 0x002ABA30
			// (set) Token: 0x0600A72B RID: 42795 RVA: 0x0004B8A0 File Offset: 0x00049AA0
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A6 RID: 12966
			// (get) Token: 0x0600A72C RID: 42796 RVA: 0x002AD860 File Offset: 0x002ABA60
			// (set) Token: 0x0600A72D RID: 42797 RVA: 0x0004B8BF File Offset: 0x00049ABF
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A7 RID: 12967
			// (get) Token: 0x0600A72E RID: 42798 RVA: 0x002AD890 File Offset: 0x002ABA90
			// (set) Token: 0x0600A72F RID: 42799 RVA: 0x0004B8DE File Offset: 0x00049ADE
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A8 RID: 12968
			// (get) Token: 0x0600A730 RID: 42800 RVA: 0x002AD8C0 File Offset: 0x002ABAC0
			// (set) Token: 0x0600A731 RID: 42801 RVA: 0x0004B8FD File Offset: 0x00049AFD
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreacheryRevealAbility._Undo_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069C9 RID: 27081
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040069CA RID: 27082
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040069CB RID: 27083
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040069CC RID: 27084
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x040069CD RID: 27085
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x040069CE RID: 27086
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040069CF RID: 27087
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040069D0 RID: 27088
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040069D1 RID: 27089
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040069D2 RID: 27090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040069D3 RID: 27091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069D4 RID: 27092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040069D5 RID: 27093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040069D6 RID: 27094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069D7 RID: 27095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040069D8 RID: 27096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040069D9 RID: 27097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

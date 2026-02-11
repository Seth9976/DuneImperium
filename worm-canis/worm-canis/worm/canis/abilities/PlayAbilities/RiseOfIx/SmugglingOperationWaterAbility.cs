using System;
using Canis;
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
using worm.canis.abilities.TriggeredAbilities;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.RiseOfIx
{
	// Token: 0x0200044F RID: 1103
	public class SmugglingOperationWaterAbility : TriggeredAbility
	{
		// Token: 0x06003046 RID: 12358 RVA: 0x001239F8 File Offset: 0x00121BF8
		// Note: this type is marked as 'beforefieldinit'.
		static SmugglingOperationWaterAbility()
		{
			Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.RiseOfIx", "SmugglingOperationWaterAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr);
			SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, "AbilityName");
			SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, "AbilityID");
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678099);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678100);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678101);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678102);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678103);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678104);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678105);
			SmugglingOperationWaterAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, 100678106);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00123AF0 File Offset: 0x00121CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223538, XrefRangeEnd = 223542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x00123B3C File Offset: 0x00121D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223542, XrefRangeEnd = 223555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmugglingOperationWaterAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x00123B88 File Offset: 0x00121D88
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmugglingOperationWaterAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00123BF8 File Offset: 0x00121DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223555, XrefRangeEnd = 223562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x00123C54 File Offset: 0x00121E54
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00123C9C File Offset: 0x00121E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223562, XrefRangeEnd = 223566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00123D0C File Offset: 0x00121F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223566, XrefRangeEnd = 223573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00123D8C File Offset: 0x00121F8C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmugglingOperationWaterAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000110FA File Offset: 0x0000F2FA
		public SmugglingOperationWaterAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x00123E08 File Offset: 0x00122008
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x00011103 File Offset: 0x0000F303
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x00123E28 File Offset: 0x00122028
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x00011115 File Offset: 0x0000F315
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SmugglingOperationWaterAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x02000A80 RID: 2688
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.SmugglingOperationWaterAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600A887 RID: 43143 RVA: 0x002B1660 File Offset: 0x002AF860
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678108);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678109);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678110);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678111);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678112);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678113);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678114);
				SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr, 100678115);
			}

			// Token: 0x0600A888 RID: 43144 RVA: 0x002B17B8 File Offset: 0x002AF9B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmugglingOperationWaterAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A889 RID: 43145 RVA: 0x002B1800 File Offset: 0x002AFA00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A88A RID: 43146 RVA: 0x002B1834 File Offset: 0x002AFA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223480, XrefRangeEnd = 223500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003330 RID: 13104
			// (get) Token: 0x0600A88B RID: 43147 RVA: 0x002B1870 File Offset: 0x002AFA70
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A88C RID: 43148 RVA: 0x002B18B0 File Offset: 0x002AFAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223500, XrefRangeEnd = 223505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003331 RID: 13105
			// (get) Token: 0x0600A88D RID: 43149 RVA: 0x002B18E4 File Offset: 0x002AFAE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A88E RID: 43150 RVA: 0x002B1924 File Offset: 0x002AFB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223505, XrefRangeEnd = 223514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A88F RID: 43151 RVA: 0x002B1964 File Offset: 0x002AFB64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A890 RID: 43152 RVA: 0x0004C5BA File Offset: 0x0004A7BA
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003329 RID: 13097
			// (get) Token: 0x0600A891 RID: 43153 RVA: 0x002B19A4 File Offset: 0x002AFBA4
			// (set) Token: 0x0600A892 RID: 43154 RVA: 0x0004C5C3 File Offset: 0x0004A7C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700332A RID: 13098
			// (get) Token: 0x0600A893 RID: 43155 RVA: 0x002B19CC File Offset: 0x002AFBCC
			// (set) Token: 0x0600A894 RID: 43156 RVA: 0x0004C5DE File Offset: 0x0004A7DE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332B RID: 13099
			// (get) Token: 0x0600A895 RID: 43157 RVA: 0x002B19FC File Offset: 0x002AFBFC
			// (set) Token: 0x0600A896 RID: 43158 RVA: 0x0004C5FD File Offset: 0x0004A7FD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700332C RID: 13100
			// (get) Token: 0x0600A897 RID: 43159 RVA: 0x002B1A24 File Offset: 0x002AFC24
			// (set) Token: 0x0600A898 RID: 43160 RVA: 0x0004C618 File Offset: 0x0004A818
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332D RID: 13101
			// (get) Token: 0x0600A899 RID: 43161 RVA: 0x002B1A54 File Offset: 0x002AFC54
			// (set) Token: 0x0600A89A RID: 43162 RVA: 0x0004C637 File Offset: 0x0004A837
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332E RID: 13102
			// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002B1A84 File Offset: 0x002AFC84
			// (set) Token: 0x0600A89C RID: 43164 RVA: 0x0004C656 File Offset: 0x0004A856
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332F RID: 13103
			// (get) Token: 0x0600A89D RID: 43165 RVA: 0x002B1AB4 File Offset: 0x002AFCB4
			// (set) Token: 0x0600A89E RID: 43166 RVA: 0x0004C675 File Offset: 0x0004A875
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AA5 RID: 27301
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006AA6 RID: 27302
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006AA7 RID: 27303
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006AA8 RID: 27304
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006AA9 RID: 27305
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006AAA RID: 27306
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006AAB RID: 27307
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006AAC RID: 27308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006AAD RID: 27309
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006AAE RID: 27310
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006AAF RID: 27311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006AB0 RID: 27312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006AB1 RID: 27313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006AB2 RID: 27314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006AB3 RID: 27315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A81 RID: 2689
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.SmugglingOperationWaterAbility+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x0600A89F RID: 43167 RVA: 0x002B1AE4 File Offset: 0x002AFCE4
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmugglingOperationWaterAbility>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "evt");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678116);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678117);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678118);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678119);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678120);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678121);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678122);
				SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr, 100678123);
			}

			// Token: 0x0600A8A0 RID: 43168 RVA: 0x002B1C28 File Offset: 0x002AFE28
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmugglingOperationWaterAbility._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A8A1 RID: 43169 RVA: 0x002B1C70 File Offset: 0x002AFE70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8A2 RID: 43170 RVA: 0x002B1CA4 File Offset: 0x002AFEA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223514, XrefRangeEnd = 223524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003338 RID: 13112
			// (get) Token: 0x0600A8A3 RID: 43171 RVA: 0x002B1CE0 File Offset: 0x002AFEE0
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600A8A4 RID: 43172 RVA: 0x002B1D20 File Offset: 0x002AFF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223524, XrefRangeEnd = 223529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003339 RID: 13113
			// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x002B1D54 File Offset: 0x002AFF54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A8A6 RID: 43174 RVA: 0x002B1D94 File Offset: 0x002AFF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223529, XrefRangeEnd = 223538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x0600A8A7 RID: 43175 RVA: 0x002B1DD4 File Offset: 0x002AFFD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A8A8 RID: 43176 RVA: 0x0004C694 File Offset: 0x0004A894
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003332 RID: 13106
			// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002B1E14 File Offset: 0x002B0014
			// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x0004C69D File Offset: 0x0004A89D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003333 RID: 13107
			// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002B1E3C File Offset: 0x002B003C
			// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x0004C6B8 File Offset: 0x0004A8B8
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003334 RID: 13108
			// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002B1E6C File Offset: 0x002B006C
			// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x0004C6D7 File Offset: 0x0004A8D7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003335 RID: 13109
			// (get) Token: 0x0600A8AF RID: 43183 RVA: 0x002B1E94 File Offset: 0x002B0094
			// (set) Token: 0x0600A8B0 RID: 43184 RVA: 0x0004C6F2 File Offset: 0x0004A8F2
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003336 RID: 13110
			// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002B1EC4 File Offset: 0x002B00C4
			// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x0004C711 File Offset: 0x0004A911
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003337 RID: 13111
			// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002B1EF4 File Offset: 0x002B00F4
			// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x0004C730 File Offset: 0x0004A930
			public unsafe SmugglingOperationWaterAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmugglingOperationWaterAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmugglingOperationWaterAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AB4 RID: 27316
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006AB5 RID: 27317
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006AB6 RID: 27318
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006AB7 RID: 27319
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04006AB8 RID: 27320
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04006AB9 RID: 27321
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006ABA RID: 27322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006ABB RID: 27323
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006ABC RID: 27324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006ABD RID: 27325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04006ABE RID: 27326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006ABF RID: 27327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006AC0 RID: 27328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04006AC1 RID: 27329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

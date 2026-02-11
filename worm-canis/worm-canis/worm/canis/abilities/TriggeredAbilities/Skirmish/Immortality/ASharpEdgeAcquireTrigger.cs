using System;
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
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality
{
	// Token: 0x02000351 RID: 849
	public class ASharpEdgeAcquireTrigger : RuleModAbility
	{
		// Token: 0x060022B9 RID: 8889 RVA: 0x000E269C File Offset: 0x000E089C
		// Note: this type is marked as 'beforefieldinit'.
		static ASharpEdgeAcquireTrigger()
		{
			Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality", "ASharpEdgeAcquireTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr);
			ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "AbilityName");
			ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "AbilityID");
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672263);
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672264);
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672265);
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672266);
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672267);
			ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, 100672268);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000E276C File Offset: 0x000E096C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182193, XrefRangeEnd = 182197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000E27B8 File Offset: 0x000E09B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182197, XrefRangeEnd = 182198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASharpEdgeAcquireTrigger(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000E2828 File Offset: 0x000E0A28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASharpEdgeAcquireTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000E2898 File Offset: 0x000E0A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182198, XrefRangeEnd = 182204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000E28F4 File Offset: 0x000E0AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182204, XrefRangeEnd = 182212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player, WormIntriguePlayable cardToDraw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardToDraw);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000E2968 File Offset: 0x000E0B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182212, XrefRangeEnd = 182220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASharpEdgeAcquireTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0000DECC File Offset: 0x0000C0CC
		public ASharpEdgeAcquireTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000E29E8 File Offset: 0x000E0BE8
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x0000DED5 File Offset: 0x0000C0D5
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000E2A08 File Offset: 0x000E0C08
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0000DEE7 File Offset: 0x0000C0E7
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0200084A RID: 2122
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality.ASharpEdgeAcquireTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060079D0 RID: 31184 RVA: 0x0022826C File Offset: 0x0022646C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr);
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9");
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9__5_0");
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9__5_1");
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9__7_0");
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9__7_1");
				ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, "<>9__7_2");
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672271);
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__5_0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672272);
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__5_1_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672273);
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672274);
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672275);
				ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr, 100672276);
			}

			// Token: 0x060079D1 RID: 31185 RVA: 0x00228388 File Offset: 0x00226588
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060079D2 RID: 31186 RVA: 0x002283C4 File Offset: 0x002265C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181754, XrefRangeEnd = 181761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__5_0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__5_0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060079D3 RID: 31187 RVA: 0x00228414 File Offset: 0x00226614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181761, XrefRangeEnd = 181778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__5_1(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__5_1_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060079D4 RID: 31188 RVA: 0x00228464 File Offset: 0x00226664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181778, XrefRangeEnd = 181795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060079D5 RID: 31189 RVA: 0x002284B4 File Offset: 0x002266B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181795, XrefRangeEnd = 181812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060079D6 RID: 31190 RVA: 0x00228504 File Offset: 0x00226704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181812, XrefRangeEnd = 181829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060079D7 RID: 31191 RVA: 0x000319CB File Offset: 0x0002FBCB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002223 RID: 8739
			// (get) Token: 0x060079D8 RID: 31192 RVA: 0x00228554 File Offset: 0x00226754
			// (set) Token: 0x060079D9 RID: 31193 RVA: 0x000319D4 File Offset: 0x0002FBD4
			public unsafe static ASharpEdgeAcquireTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASharpEdgeAcquireTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002224 RID: 8740
			// (get) Token: 0x060079DA RID: 31194 RVA: 0x0022857C File Offset: 0x0022677C
			// (set) Token: 0x060079DB RID: 31195 RVA: 0x000319E6 File Offset: 0x0002FBE6
			public unsafe static Func<WormPlayable, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002225 RID: 8741
			// (get) Token: 0x060079DC RID: 31196 RVA: 0x002285A4 File Offset: 0x002267A4
			// (set) Token: 0x060079DD RID: 31197 RVA: 0x000319F8 File Offset: 0x0002FBF8
			public unsafe static Func<WormPlayable, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002226 RID: 8742
			// (get) Token: 0x060079DE RID: 31198 RVA: 0x002285CC File Offset: 0x002267CC
			// (set) Token: 0x060079DF RID: 31199 RVA: 0x00031A0A File Offset: 0x0002FC0A
			public unsafe static Func<Entity, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002227 RID: 8743
			// (get) Token: 0x060079E0 RID: 31200 RVA: 0x002285F4 File Offset: 0x002267F4
			// (set) Token: 0x060079E1 RID: 31201 RVA: 0x00031A1C File Offset: 0x0002FC1C
			public unsafe static Func<Entity, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002228 RID: 8744
			// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0022861C File Offset: 0x0022681C
			// (set) Token: 0x060079E3 RID: 31203 RVA: 0x00031A2E File Offset: 0x0002FC2E
			public unsafe static Func<Entity, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ASharpEdgeAcquireTrigger.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E60 RID: 20064
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004E61 RID: 20065
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04004E62 RID: 20066
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04004E63 RID: 20067
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04004E64 RID: 20068
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04004E65 RID: 20069
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04004E66 RID: 20070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E67 RID: 20071
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__5_0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04004E68 RID: 20072
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__5_1_Internal_Boolean_WormPlayable_0;

			// Token: 0x04004E69 RID: 20073
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0;

			// Token: 0x04004E6A RID: 20074
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_Entity_0;

			// Token: 0x04004E6B RID: 20075
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200084B RID: 2123
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality.ASharpEdgeAcquireTrigger+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x060079E4 RID: 31204 RVA: 0x00228644 File Offset: 0x00226844
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "match");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>4__this");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<player>5__2");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__wormPlaymat_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<wormPlaymat>5__3");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCardsInDeck_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<combatIntrigueCardsInDeck>5__4");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCards_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<combatIntrigueCards>5__5");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__cardToDraw_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<cardToDraw>5__6");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__sequence_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<sequence>5__7");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap7");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap8");
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672277);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672278);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672279);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672280);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672281);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672282);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672283);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672284);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672285);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672286);
				ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr, 100672287);
			}

			// Token: 0x060079E5 RID: 31205 RVA: 0x0022888C File Offset: 0x00226A8C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060079E6 RID: 31206 RVA: 0x002288D4 File Offset: 0x00226AD4
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060079E7 RID: 31207 RVA: 0x00228908 File Offset: 0x00226B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181829, XrefRangeEnd = 182069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060079E8 RID: 31208 RVA: 0x00228944 File Offset: 0x00226B44
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 182072, RefRangeEnd = 182073, XrefRangeStart = 182069, XrefRangeEnd = 182072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060079E9 RID: 31209 RVA: 0x00228978 File Offset: 0x00226B78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 182076, RefRangeEnd = 182077, XrefRangeStart = 182073, XrefRangeEnd = 182076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060079EA RID: 31210 RVA: 0x002289AC File Offset: 0x00226BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182077, XrefRangeEnd = 182080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002239 RID: 8761
			// (get) Token: 0x060079EB RID: 31211 RVA: 0x002289E0 File Offset: 0x00226BE0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060079EC RID: 31212 RVA: 0x00228A20 File Offset: 0x00226C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182080, XrefRangeEnd = 182085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700223A RID: 8762
			// (get) Token: 0x060079ED RID: 31213 RVA: 0x00228A54 File Offset: 0x00226C54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060079EE RID: 31214 RVA: 0x00228A94 File Offset: 0x00226C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182085, XrefRangeEnd = 182095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060079EF RID: 31215 RVA: 0x00228AD4 File Offset: 0x00226CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060079F0 RID: 31216 RVA: 0x00031A40 File Offset: 0x0002FC40
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002229 RID: 8745
			// (get) Token: 0x060079F1 RID: 31217 RVA: 0x00228B14 File Offset: 0x00226D14
			// (set) Token: 0x060079F2 RID: 31218 RVA: 0x00031A49 File Offset: 0x0002FC49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700222A RID: 8746
			// (get) Token: 0x060079F3 RID: 31219 RVA: 0x00228B3C File Offset: 0x00226D3C
			// (set) Token: 0x060079F4 RID: 31220 RVA: 0x00031A64 File Offset: 0x0002FC64
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700222B RID: 8747
			// (get) Token: 0x060079F5 RID: 31221 RVA: 0x00228B6C File Offset: 0x00226D6C
			// (set) Token: 0x060079F6 RID: 31222 RVA: 0x00031A83 File Offset: 0x0002FC83
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700222C RID: 8748
			// (get) Token: 0x060079F7 RID: 31223 RVA: 0x00228B94 File Offset: 0x00226D94
			// (set) Token: 0x060079F8 RID: 31224 RVA: 0x00031A9E File Offset: 0x0002FC9E
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700222D RID: 8749
			// (get) Token: 0x060079F9 RID: 31225 RVA: 0x00228BC4 File Offset: 0x00226DC4
			// (set) Token: 0x060079FA RID: 31226 RVA: 0x00031ABD File Offset: 0x0002FCBD
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700222E RID: 8750
			// (get) Token: 0x060079FB RID: 31227 RVA: 0x00228BF4 File Offset: 0x00226DF4
			// (set) Token: 0x060079FC RID: 31228 RVA: 0x00031ADC File Offset: 0x0002FCDC
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700222F RID: 8751
			// (get) Token: 0x060079FD RID: 31229 RVA: 0x00228C24 File Offset: 0x00226E24
			// (set) Token: 0x060079FE RID: 31230 RVA: 0x00031AFB File Offset: 0x0002FCFB
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002230 RID: 8752
			// (get) Token: 0x060079FF RID: 31231 RVA: 0x00228C54 File Offset: 0x00226E54
			// (set) Token: 0x06007A00 RID: 31232 RVA: 0x00031B1A File Offset: 0x0002FD1A
			public unsafe ASharpEdgeAcquireTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASharpEdgeAcquireTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002231 RID: 8753
			// (get) Token: 0x06007A01 RID: 31233 RVA: 0x00228C84 File Offset: 0x00226E84
			// (set) Token: 0x06007A02 RID: 31234 RVA: 0x00031B39 File Offset: 0x0002FD39
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002232 RID: 8754
			// (get) Token: 0x06007A03 RID: 31235 RVA: 0x00228CB4 File Offset: 0x00226EB4
			// (set) Token: 0x06007A04 RID: 31236 RVA: 0x00031B58 File Offset: 0x0002FD58
			public unsafe WormPlaymat _wormPlaymat_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__wormPlaymat_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__wormPlaymat_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002233 RID: 8755
			// (get) Token: 0x06007A05 RID: 31237 RVA: 0x00228CE4 File Offset: 0x00226EE4
			// (set) Token: 0x06007A06 RID: 31238 RVA: 0x00031B77 File Offset: 0x0002FD77
			public unsafe List<Entity> _combatIntrigueCardsInDeck_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCardsInDeck_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCardsInDeck_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002234 RID: 8756
			// (get) Token: 0x06007A07 RID: 31239 RVA: 0x00228D14 File Offset: 0x00226F14
			// (set) Token: 0x06007A08 RID: 31240 RVA: 0x00031B96 File Offset: 0x0002FD96
			public unsafe List<Entity> _combatIntrigueCards_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCards_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__combatIntrigueCards_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002235 RID: 8757
			// (get) Token: 0x06007A09 RID: 31241 RVA: 0x00228D44 File Offset: 0x00226F44
			// (set) Token: 0x06007A0A RID: 31242 RVA: 0x00031BB5 File Offset: 0x0002FDB5
			public unsafe WormIntriguePlayable _cardToDraw_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__cardToDraw_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__cardToDraw_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002236 RID: 8758
			// (get) Token: 0x06007A0B RID: 31243 RVA: 0x00228D74 File Offset: 0x00226F74
			// (set) Token: 0x06007A0C RID: 31244 RVA: 0x00031BD4 File Offset: 0x0002FDD4
			public unsafe SequenceHelper _sequence_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__sequence_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr__sequence_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002237 RID: 8759
			// (get) Token: 0x06007A0D RID: 31245 RVA: 0x00228DA4 File Offset: 0x00226FA4
			// (set) Token: 0x06007A0E RID: 31246 RVA: 0x00031BF3 File Offset: 0x0002FDF3
			public List<Entity>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap7);
					return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002238 RID: 8760
			// (get) Token: 0x06007A0F RID: 31247 RVA: 0x00228DD4 File Offset: 0x00226FD4
			// (set) Token: 0x06007A10 RID: 31248 RVA: 0x00031C21 File Offset: 0x0002FE21
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E6C RID: 20076
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E6D RID: 20077
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004E6E RID: 20078
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004E6F RID: 20079
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004E70 RID: 20080
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004E71 RID: 20081
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004E72 RID: 20082
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004E73 RID: 20083
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004E74 RID: 20084
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04004E75 RID: 20085
			private static readonly IntPtr NativeFieldInfoPtr__wormPlaymat_5__3;

			// Token: 0x04004E76 RID: 20086
			private static readonly IntPtr NativeFieldInfoPtr__combatIntrigueCardsInDeck_5__4;

			// Token: 0x04004E77 RID: 20087
			private static readonly IntPtr NativeFieldInfoPtr__combatIntrigueCards_5__5;

			// Token: 0x04004E78 RID: 20088
			private static readonly IntPtr NativeFieldInfoPtr__cardToDraw_5__6;

			// Token: 0x04004E79 RID: 20089
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__7;

			// Token: 0x04004E7A RID: 20090
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04004E7B RID: 20091
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04004E7C RID: 20092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004E7D RID: 20093
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E7E RID: 20094
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004E7F RID: 20095
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004E80 RID: 20096
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004E81 RID: 20097
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04004E82 RID: 20098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004E83 RID: 20099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E84 RID: 20100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004E85 RID: 20101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004E86 RID: 20102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200084C RID: 2124
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality.ASharpEdgeAcquireTrigger+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06007A11 RID: 31249 RVA: 0x00228E04 File Offset: 0x00227004
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, "evt");
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672288);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672289);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672290);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672291);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672292);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672293);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672294);
				ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr, 100672295);
			}

			// Token: 0x06007A12 RID: 31250 RVA: 0x00228F34 File Offset: 0x00227134
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007A13 RID: 31251 RVA: 0x00228F7C File Offset: 0x0022717C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007A14 RID: 31252 RVA: 0x00228FB0 File Offset: 0x002271B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182095, XrefRangeEnd = 182146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002240 RID: 8768
			// (get) Token: 0x06007A15 RID: 31253 RVA: 0x00228FEC File Offset: 0x002271EC
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06007A16 RID: 31254 RVA: 0x0022902C File Offset: 0x0022722C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182146, XrefRangeEnd = 182151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002241 RID: 8769
			// (get) Token: 0x06007A17 RID: 31255 RVA: 0x00229060 File Offset: 0x00227260
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007A18 RID: 31256 RVA: 0x002290A0 File Offset: 0x002272A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182151, XrefRangeEnd = 182159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007A19 RID: 31257 RVA: 0x002290E0 File Offset: 0x002272E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007A1A RID: 31258 RVA: 0x00031C40 File Offset: 0x0002FE40
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700223B RID: 8763
			// (get) Token: 0x06007A1B RID: 31259 RVA: 0x00229120 File Offset: 0x00227320
			// (set) Token: 0x06007A1C RID: 31260 RVA: 0x00031C49 File Offset: 0x0002FE49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700223C RID: 8764
			// (get) Token: 0x06007A1D RID: 31261 RVA: 0x00229148 File Offset: 0x00227348
			// (set) Token: 0x06007A1E RID: 31262 RVA: 0x00031C64 File Offset: 0x0002FE64
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700223D RID: 8765
			// (get) Token: 0x06007A1F RID: 31263 RVA: 0x00229178 File Offset: 0x00227378
			// (set) Token: 0x06007A20 RID: 31264 RVA: 0x00031C83 File Offset: 0x0002FE83
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700223E RID: 8766
			// (get) Token: 0x06007A21 RID: 31265 RVA: 0x002291A0 File Offset: 0x002273A0
			// (set) Token: 0x06007A22 RID: 31266 RVA: 0x00031C9E File Offset: 0x0002FE9E
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700223F RID: 8767
			// (get) Token: 0x06007A23 RID: 31267 RVA: 0x002291D0 File Offset: 0x002273D0
			// (set) Token: 0x06007A24 RID: 31268 RVA: 0x00031CBD File Offset: 0x0002FEBD
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E87 RID: 20103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E88 RID: 20104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004E89 RID: 20105
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004E8A RID: 20106
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04004E8B RID: 20107
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04004E8C RID: 20108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004E8D RID: 20109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E8E RID: 20110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004E8F RID: 20111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004E90 RID: 20112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E91 RID: 20113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004E92 RID: 20114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004E93 RID: 20115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200084D RID: 2125
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.Immortality.ASharpEdgeAcquireTrigger+<MakeAnalyticsData>d__6")]
		public sealed class _MakeAnalyticsData_d__6 : Object
		{
			// Token: 0x06007A25 RID: 31269 RVA: 0x00229200 File Offset: 0x00227400
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__6()
			{
				Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger>.NativeClassPtr, "<MakeAnalyticsData>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>1__state");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>2__current");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "cardToDraw");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__cardToDraw");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "wormMatch");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__wormMatch");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "player");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__player");
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672296);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672297);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672298);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672299);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672300);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672301);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672302);
				ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr, 100672303);
			}

			// Token: 0x06007A26 RID: 31270 RVA: 0x00229380 File Offset: 0x00227580
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007A27 RID: 31271 RVA: 0x002293C8 File Offset: 0x002275C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007A28 RID: 31272 RVA: 0x002293FC File Offset: 0x002275FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182159, XrefRangeEnd = 182175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700224B RID: 8779
			// (get) Token: 0x06007A29 RID: 31273 RVA: 0x00229438 File Offset: 0x00227638
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06007A2A RID: 31274 RVA: 0x00229470 File Offset: 0x00227670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182175, XrefRangeEnd = 182180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700224C RID: 8780
			// (get) Token: 0x06007A2B RID: 31275 RVA: 0x002294A4 File Offset: 0x002276A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182180, XrefRangeEnd = 182183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007A2C RID: 31276 RVA: 0x002294E4 File Offset: 0x002276E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182183, XrefRangeEnd = 182193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06007A2D RID: 31277 RVA: 0x00229524 File Offset: 0x00227724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007A2E RID: 31278 RVA: 0x00031CDC File Offset: 0x0002FEDC
			public _MakeAnalyticsData_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002242 RID: 8770
			// (get) Token: 0x06007A2F RID: 31279 RVA: 0x00229564 File Offset: 0x00227764
			// (set) Token: 0x06007A30 RID: 31280 RVA: 0x00031CE5 File Offset: 0x0002FEE5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002243 RID: 8771
			// (get) Token: 0x06007A31 RID: 31281 RVA: 0x0022958C File Offset: 0x0022778C
			// (set) Token: 0x06007A32 RID: 31282 RVA: 0x00031D00 File Offset: 0x0002FF00
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002244 RID: 8772
			// (get) Token: 0x06007A33 RID: 31283 RVA: 0x002295BC File Offset: 0x002277BC
			// (set) Token: 0x06007A34 RID: 31284 RVA: 0x00031D2E File Offset: 0x0002FF2E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002245 RID: 8773
			// (get) Token: 0x06007A35 RID: 31285 RVA: 0x002295E4 File Offset: 0x002277E4
			// (set) Token: 0x06007A36 RID: 31286 RVA: 0x00031D49 File Offset: 0x0002FF49
			public unsafe WormIntriguePlayable cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002246 RID: 8774
			// (get) Token: 0x06007A37 RID: 31287 RVA: 0x00229614 File Offset: 0x00227814
			// (set) Token: 0x06007A38 RID: 31288 RVA: 0x00031D68 File Offset: 0x0002FF68
			public unsafe WormIntriguePlayable __3__cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002247 RID: 8775
			// (get) Token: 0x06007A39 RID: 31289 RVA: 0x00229644 File Offset: 0x00227844
			// (set) Token: 0x06007A3A RID: 31290 RVA: 0x00031D87 File Offset: 0x0002FF87
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002248 RID: 8776
			// (get) Token: 0x06007A3B RID: 31291 RVA: 0x00229674 File Offset: 0x00227874
			// (set) Token: 0x06007A3C RID: 31292 RVA: 0x00031DA6 File Offset: 0x0002FFA6
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002249 RID: 8777
			// (get) Token: 0x06007A3D RID: 31293 RVA: 0x002296A4 File Offset: 0x002278A4
			// (set) Token: 0x06007A3E RID: 31294 RVA: 0x00031DC5 File Offset: 0x0002FFC5
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700224A RID: 8778
			// (get) Token: 0x06007A3F RID: 31295 RVA: 0x002296D4 File Offset: 0x002278D4
			// (set) Token: 0x06007A40 RID: 31296 RVA: 0x00031DE4 File Offset: 0x0002FFE4
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASharpEdgeAcquireTrigger._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E94 RID: 20116
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E95 RID: 20117
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004E96 RID: 20118
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004E97 RID: 20119
			private static readonly IntPtr NativeFieldInfoPtr_cardToDraw;

			// Token: 0x04004E98 RID: 20120
			private static readonly IntPtr NativeFieldInfoPtr___3__cardToDraw;

			// Token: 0x04004E99 RID: 20121
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04004E9A RID: 20122
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04004E9B RID: 20123
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04004E9C RID: 20124
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04004E9D RID: 20125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004E9E RID: 20126
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E9F RID: 20127
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004EA0 RID: 20128
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04004EA1 RID: 20129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004EA2 RID: 20130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004EA3 RID: 20131
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04004EA4 RID: 20132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

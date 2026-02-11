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
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.BaseSet
{
	// Token: 0x020003B4 RID: 948
	public class ConnectionsAbility : TriggeredAbility
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x000F9DF4 File Offset: 0x000F7FF4
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionsAbility()
		{
			Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.BaseSet", "ConnectionsAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr);
			ConnectionsAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, "AbilityName");
			ConnectionsAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, "AbilityID");
			ConnectionsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674764);
			ConnectionsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674765);
			ConnectionsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674766);
			ConnectionsAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674767);
			ConnectionsAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674768);
			ConnectionsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674769);
			ConnectionsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674770);
			ConnectionsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, 100674771);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000F9EEC File Offset: 0x000F80EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196991, XrefRangeEnd = 196995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000F9F38 File Offset: 0x000F8138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196995, XrefRangeEnd = 196998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionsAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000F9F84 File Offset: 0x000F8184
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionsAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000F9FF4 File Offset: 0x000F81F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196998, XrefRangeEnd = 197005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000FA050 File Offset: 0x000F8250
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000FA098 File Offset: 0x000F8298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197005, XrefRangeEnd = 197009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000FA108 File Offset: 0x000F8308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197009, XrefRangeEnd = 197017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000FA188 File Offset: 0x000F8388
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		public ConnectionsAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000FA204 File Offset: 0x000F8404
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x0000F0B1 File Offset: 0x0000D2B1
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConnectionsAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConnectionsAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000FA224 File Offset: 0x000F8424
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x0000F0C3 File Offset: 0x0000D2C3
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConnectionsAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConnectionsAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x0200094D RID: 2381
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.BaseSet.ConnectionsAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008ED9 RID: 36569 RVA: 0x002663E0 File Offset: 0x002645E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr);
				ConnectionsAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr, "<>9");
				ConnectionsAbility.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr, "<>9__9_0");
				ConnectionsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr, 100674774);
				ConnectionsAbility.__c.NativeMethodInfoPtr__BeginExecution_b__9_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr, 100674775);
			}

			// Token: 0x06008EDA RID: 36570 RVA: 0x0026645C File Offset: 0x0026465C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionsAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EDB RID: 36571 RVA: 0x00266498 File Offset: 0x00264698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196903, XrefRangeEnd = 196904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__9_0(WormAbilityDefinition a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility.__c.NativeMethodInfoPtr__BeginExecution_b__9_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008EDC RID: 36572 RVA: 0x0003D7B0 File Offset: 0x0003B9B0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170029C5 RID: 10693
			// (get) Token: 0x06008EDD RID: 36573 RVA: 0x002664E8 File Offset: 0x002646E8
			// (set) Token: 0x06008EDE RID: 36574 RVA: 0x0003D7B9 File Offset: 0x0003B9B9
			public unsafe static ConnectionsAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConnectionsAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectionsAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConnectionsAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029C6 RID: 10694
			// (get) Token: 0x06008EDF RID: 36575 RVA: 0x00266510 File Offset: 0x00264710
			// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x0003D7CB File Offset: 0x0003B9CB
			public unsafe static Func<WormAbilityDefinition, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConnectionsAbility.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConnectionsAbility.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B29 RID: 23337
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005B2A RID: 23338
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04005B2B RID: 23339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B2C RID: 23340
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__9_0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x0200094E RID: 2382
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.BaseSet.ConnectionsAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x06008EE1 RID: 36577 RVA: 0x00266538 File Offset: 0x00264738
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr);
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, "<player>5__2");
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674776);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674777);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674778);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674779);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674780);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674781);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674782);
				ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr, 100674783);
			}

			// Token: 0x06008EE2 RID: 36578 RVA: 0x002666B8 File Offset: 0x002648B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionsAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008EE3 RID: 36579 RVA: 0x00266700 File Offset: 0x00264900
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EE4 RID: 36580 RVA: 0x00266734 File Offset: 0x00264934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196904, XrefRangeEnd = 196952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170029D0 RID: 10704
			// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x00266770 File Offset: 0x00264970
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008EE6 RID: 36582 RVA: 0x002667B0 File Offset: 0x002649B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196952, XrefRangeEnd = 196957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170029D1 RID: 10705
			// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x002667E4 File Offset: 0x002649E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008EE8 RID: 36584 RVA: 0x00266824 File Offset: 0x00264A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196957, XrefRangeEnd = 196967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008EE9 RID: 36585 RVA: 0x00266864 File Offset: 0x00264A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008EEA RID: 36586 RVA: 0x0003D7DD File Offset: 0x0003B9DD
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170029C7 RID: 10695
			// (get) Token: 0x06008EEB RID: 36587 RVA: 0x002668A4 File Offset: 0x00264AA4
			// (set) Token: 0x06008EEC RID: 36588 RVA: 0x0003D7E6 File Offset: 0x0003B9E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170029C8 RID: 10696
			// (get) Token: 0x06008EED RID: 36589 RVA: 0x002668CC File Offset: 0x00264ACC
			// (set) Token: 0x06008EEE RID: 36590 RVA: 0x0003D801 File Offset: 0x0003BA01
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029C9 RID: 10697
			// (get) Token: 0x06008EEF RID: 36591 RVA: 0x002668FC File Offset: 0x00264AFC
			// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x0003D820 File Offset: 0x0003BA20
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170029CA RID: 10698
			// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x00266924 File Offset: 0x00264B24
			// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x0003D83B File Offset: 0x0003BA3B
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029CB RID: 10699
			// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x00266954 File Offset: 0x00264B54
			// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x0003D85A File Offset: 0x0003BA5A
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029CC RID: 10700
			// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x00266984 File Offset: 0x00264B84
			// (set) Token: 0x06008EF6 RID: 36598 RVA: 0x0003D879 File Offset: 0x0003BA79
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029CD RID: 10701
			// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x002669B4 File Offset: 0x00264BB4
			// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x0003D898 File Offset: 0x0003BA98
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029CE RID: 10702
			// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x002669E4 File Offset: 0x00264BE4
			// (set) Token: 0x06008EFA RID: 36602 RVA: 0x0003D8B7 File Offset: 0x0003BAB7
			public unsafe ConnectionsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectionsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029CF RID: 10703
			// (get) Token: 0x06008EFB RID: 36603 RVA: 0x00266A14 File Offset: 0x00264C14
			// (set) Token: 0x06008EFC RID: 36604 RVA: 0x0003D8D6 File Offset: 0x0003BAD6
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B2D RID: 23341
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B2E RID: 23342
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B2F RID: 23343
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005B30 RID: 23344
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005B31 RID: 23345
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005B32 RID: 23346
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005B33 RID: 23347
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005B34 RID: 23348
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B35 RID: 23349
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005B36 RID: 23350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B37 RID: 23351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B38 RID: 23352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B39 RID: 23353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005B3A RID: 23354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B3B RID: 23355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B3C RID: 23356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005B3D RID: 23357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200094F RID: 2383
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.BaseSet.ConnectionsAbility+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06008EFD RID: 36605 RVA: 0x00266A44 File Offset: 0x00264C44
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConnectionsAbility>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr);
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "evt");
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674784);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674785);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674786);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674787);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674788);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674789);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674790);
				ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr, 100674791);
			}

			// Token: 0x06008EFE RID: 36606 RVA: 0x00266B88 File Offset: 0x00264D88
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionsAbility._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008EFF RID: 36607 RVA: 0x00266BD0 File Offset: 0x00264DD0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F00 RID: 36608 RVA: 0x00266C04 File Offset: 0x00264E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196967, XrefRangeEnd = 196977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170029D8 RID: 10712
			// (get) Token: 0x06008F01 RID: 36609 RVA: 0x00266C40 File Offset: 0x00264E40
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06008F02 RID: 36610 RVA: 0x00266C80 File Offset: 0x00264E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196977, XrefRangeEnd = 196982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170029D9 RID: 10713
			// (get) Token: 0x06008F03 RID: 36611 RVA: 0x00266CB4 File Offset: 0x00264EB4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008F04 RID: 36612 RVA: 0x00266CF4 File Offset: 0x00264EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196982, XrefRangeEnd = 196991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008F05 RID: 36613 RVA: 0x00266D34 File Offset: 0x00264F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008F06 RID: 36614 RVA: 0x0003D8F5 File Offset: 0x0003BAF5
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170029D2 RID: 10706
			// (get) Token: 0x06008F07 RID: 36615 RVA: 0x00266D74 File Offset: 0x00264F74
			// (set) Token: 0x06008F08 RID: 36616 RVA: 0x0003D8FE File Offset: 0x0003BAFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170029D3 RID: 10707
			// (get) Token: 0x06008F09 RID: 36617 RVA: 0x00266D9C File Offset: 0x00264F9C
			// (set) Token: 0x06008F0A RID: 36618 RVA: 0x0003D919 File Offset: 0x0003BB19
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029D4 RID: 10708
			// (get) Token: 0x06008F0B RID: 36619 RVA: 0x00266DCC File Offset: 0x00264FCC
			// (set) Token: 0x06008F0C RID: 36620 RVA: 0x0003D938 File Offset: 0x0003BB38
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170029D5 RID: 10709
			// (get) Token: 0x06008F0D RID: 36621 RVA: 0x00266DF4 File Offset: 0x00264FF4
			// (set) Token: 0x06008F0E RID: 36622 RVA: 0x0003D953 File Offset: 0x0003BB53
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029D6 RID: 10710
			// (get) Token: 0x06008F0F RID: 36623 RVA: 0x00266E24 File Offset: 0x00265024
			// (set) Token: 0x06008F10 RID: 36624 RVA: 0x0003D972 File Offset: 0x0003BB72
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170029D7 RID: 10711
			// (get) Token: 0x06008F11 RID: 36625 RVA: 0x00266E54 File Offset: 0x00265054
			// (set) Token: 0x06008F12 RID: 36626 RVA: 0x0003D991 File Offset: 0x0003BB91
			public unsafe ConnectionsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectionsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B3E RID: 23358
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B3F RID: 23359
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B40 RID: 23360
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005B41 RID: 23361
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04005B42 RID: 23362
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04005B43 RID: 23363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B44 RID: 23364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B45 RID: 23365
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B46 RID: 23366
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B47 RID: 23367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04005B48 RID: 23368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B49 RID: 23369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B4A RID: 23370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005B4B RID: 23371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200027A RID: 634
	public class ResolveSignetRingSwap : global::Canis.actions.Action
	{
		// Token: 0x06001AA2 RID: 6818 RVA: 0x000C0620 File Offset: 0x000BE820
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveSignetRingSwap()
		{
			Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ResolveSignetRingSwap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr);
			ResolveSignetRingSwap.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "wormMatch");
			ResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668443);
			ResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveSignetRingSwap_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668444);
			ResolveSignetRingSwap.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668445);
			ResolveSignetRingSwap.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668446);
			ResolveSignetRingSwap.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668447);
			ResolveSignetRingSwap.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, 100668448);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000C06DC File Offset: 0x000BE8DC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 135734, RefRangeEnd = 135759, XrefRangeStart = 135734, XrefRangeEnd = 135759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveSignetRingSwap(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000C0728 File Offset: 0x000BE928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143732, XrefRangeEnd = 143742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveSignetRingSwap(SerializedResolveSignetRingSwap serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveSignetRingSwap_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000C0788 File Offset: 0x000BE988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143742, XrefRangeEnd = 143748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveSignetRingSwap.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000C07D4 File Offset: 0x000BE9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143748, XrefRangeEnd = 143755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveSignetRingSwap.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000C0830 File Offset: 0x000BEA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143755, XrefRangeEnd = 143757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveSignetRingSwap.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000C0880 File Offset: 0x000BEA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143757, XrefRangeEnd = 143761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveSignetRingSwap.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0000B721 File Offset: 0x00009921
		public ResolveSignetRingSwap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000C08DC File Offset: 0x000BEADC
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0000B72A File Offset: 0x0000992A
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveSignetRingSwap_Match_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006BE RID: 1726
		[ObfuscatedName("worm.canis.actions.ResolveSignetRingSwap+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06005B58 RID: 23384 RVA: 0x001CAAD0 File Offset: 0x001C8CD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr);
				ResolveSignetRingSwap.__c__DisplayClass3_0.NativeFieldInfoPtr_currentAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr, "currentAbility");
				ResolveSignetRingSwap.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr, 100668449);
				ResolveSignetRingSwap.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr, 100668450);
			}

			// Token: 0x06005B59 RID: 23385 RVA: 0x001CAB38 File Offset: 0x001C8D38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B5A RID: 23386 RVA: 0x001CAB74 File Offset: 0x001C8D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143535, XrefRangeEnd = 143540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B5B RID: 23387 RVA: 0x00021D51 File Offset: 0x0001FF51
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017A8 RID: 6056
			// (get) Token: 0x06005B5C RID: 23388 RVA: 0x001CABC4 File Offset: 0x001C8DC4
			// (set) Token: 0x06005B5D RID: 23389 RVA: 0x00021D5A File Offset: 0x0001FF5A
			public unsafe SignetAbility currentAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass3_0.NativeFieldInfoPtr_currentAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass3_0.NativeFieldInfoPtr_currentAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B6F RID: 15215
			private static readonly IntPtr NativeFieldInfoPtr_currentAbility;

			// Token: 0x04003B70 RID: 15216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B71 RID: 15217
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_SignetAbility_0;
		}

		// Token: 0x020006BF RID: 1727
		[ObfuscatedName("worm.canis.actions.ResolveSignetRingSwap+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x06005B5E RID: 23390 RVA: 0x001CABF4 File Offset: 0x001C8DF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr);
				ResolveSignetRingSwap.__c__DisplayClass3_1.NativeFieldInfoPtr_newAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr, "newAbilityID");
				ResolveSignetRingSwap.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr, 100668451);
				ResolveSignetRingSwap.__c__DisplayClass3_1.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr, 100668452);
			}

			// Token: 0x06005B5F RID: 23391 RVA: 0x001CAC5C File Offset: 0x001C8E5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B60 RID: 23392 RVA: 0x001CAC98 File Offset: 0x001C8E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143540, XrefRangeEnd = 143545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__1(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass3_1.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B61 RID: 23393 RVA: 0x00021D79 File Offset: 0x0001FF79
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017A9 RID: 6057
			// (get) Token: 0x06005B62 RID: 23394 RVA: 0x001CACE8 File Offset: 0x001C8EE8
			// (set) Token: 0x06005B63 RID: 23395 RVA: 0x00021D82 File Offset: 0x0001FF82
			public unsafe AbilityID newAbilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass3_1.NativeFieldInfoPtr_newAbilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass3_1.NativeFieldInfoPtr_newAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B72 RID: 15218
			private static readonly IntPtr NativeFieldInfoPtr_newAbilityID;

			// Token: 0x04003B73 RID: 15219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B74 RID: 15220
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_SignetAbility_0;
		}

		// Token: 0x020006C0 RID: 1728
		[ObfuscatedName("worm.canis.actions.ResolveSignetRingSwap+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06005B64 RID: 23396 RVA: 0x001CAD18 File Offset: 0x001C8F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr);
				ResolveSignetRingSwap.__c__DisplayClass4_0.NativeFieldInfoPtr_previousAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr, "previousAbilityID");
				ResolveSignetRingSwap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr, 100668453);
				ResolveSignetRingSwap.__c__DisplayClass4_0.NativeMethodInfoPtr__undo_b__0_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr, 100668454);
			}

			// Token: 0x06005B65 RID: 23397 RVA: 0x001CAD80 File Offset: 0x001C8F80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B66 RID: 23398 RVA: 0x001CADBC File Offset: 0x001C8FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143545, XrefRangeEnd = 143550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _undo_b__0(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap.__c__DisplayClass4_0.NativeMethodInfoPtr__undo_b__0_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B67 RID: 23399 RVA: 0x00021DA1 File Offset: 0x0001FFA1
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017AA RID: 6058
			// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001CAE0C File Offset: 0x001C900C
			// (set) Token: 0x06005B69 RID: 23401 RVA: 0x00021DAA File Offset: 0x0001FFAA
			public unsafe AbilityID previousAbilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass4_0.NativeFieldInfoPtr_previousAbilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap.__c__DisplayClass4_0.NativeFieldInfoPtr_previousAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B75 RID: 15221
			private static readonly IntPtr NativeFieldInfoPtr_previousAbilityID;

			// Token: 0x04003B76 RID: 15222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B77 RID: 15223
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__0_Internal_Boolean_SignetAbility_0;
		}

		// Token: 0x020006C1 RID: 1729
		[ObfuscatedName("worm.canis.actions.ResolveSignetRingSwap+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06005B6A RID: 23402 RVA: 0x001CAE3C File Offset: 0x001C903C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr);
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<>1__state");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<>2__current");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<>4__this");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<>8__1");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<player>5__2");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__newAbility_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<newAbility>5__3");
				ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__childUndo_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, "<childUndo>5__4");
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668455);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668456);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668457);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668458);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668459);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668460);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668461);
				ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr, 100668462);
			}

			// Token: 0x06005B6B RID: 23403 RVA: 0x001CAFA8 File Offset: 0x001C91A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B6C RID: 23404 RVA: 0x001CAFF0 File Offset: 0x001C91F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B6D RID: 23405 RVA: 0x001CB024 File Offset: 0x001C9224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143550, XrefRangeEnd = 143697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170017B3 RID: 6067
			// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001CB060 File Offset: 0x001C9260
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005B6F RID: 23407 RVA: 0x001CB0A0 File Offset: 0x001C92A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143697, XrefRangeEnd = 143702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017B4 RID: 6068
			// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001CB0D4 File Offset: 0x001C92D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B71 RID: 23409 RVA: 0x001CB114 File Offset: 0x001C9314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143702, XrefRangeEnd = 143704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005B72 RID: 23410 RVA: 0x001CB154 File Offset: 0x001C9354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005B73 RID: 23411 RVA: 0x00021DC9 File Offset: 0x0001FFC9
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017AB RID: 6059
			// (get) Token: 0x06005B74 RID: 23412 RVA: 0x001CB194 File Offset: 0x001C9394
			// (set) Token: 0x06005B75 RID: 23413 RVA: 0x00021DD2 File Offset: 0x0001FFD2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017AC RID: 6060
			// (get) Token: 0x06005B76 RID: 23414 RVA: 0x001CB1BC File Offset: 0x001C93BC
			// (set) Token: 0x06005B77 RID: 23415 RVA: 0x00021DED File Offset: 0x0001FFED
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017AD RID: 6061
			// (get) Token: 0x06005B78 RID: 23416 RVA: 0x001CB1EC File Offset: 0x001C93EC
			// (set) Token: 0x06005B79 RID: 23417 RVA: 0x00021E0C File Offset: 0x0002000C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017AE RID: 6062
			// (get) Token: 0x06005B7A RID: 23418 RVA: 0x001CB214 File Offset: 0x001C9414
			// (set) Token: 0x06005B7B RID: 23419 RVA: 0x00021E27 File Offset: 0x00020027
			public unsafe ResolveSignetRingSwap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveSignetRingSwap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017AF RID: 6063
			// (get) Token: 0x06005B7C RID: 23420 RVA: 0x001CB244 File Offset: 0x001C9444
			// (set) Token: 0x06005B7D RID: 23421 RVA: 0x00021E46 File Offset: 0x00020046
			public unsafe ResolveSignetRingSwap.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveSignetRingSwap.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B0 RID: 6064
			// (get) Token: 0x06005B7E RID: 23422 RVA: 0x001CB274 File Offset: 0x001C9474
			// (set) Token: 0x06005B7F RID: 23423 RVA: 0x00021E65 File Offset: 0x00020065
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B1 RID: 6065
			// (get) Token: 0x06005B80 RID: 23424 RVA: 0x001CB2A4 File Offset: 0x001C94A4
			// (set) Token: 0x06005B81 RID: 23425 RVA: 0x00021E84 File Offset: 0x00020084
			public unsafe SignetAbility _newAbility_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__newAbility_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__newAbility_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B2 RID: 6066
			// (get) Token: 0x06005B82 RID: 23426 RVA: 0x001CB2D4 File Offset: 0x001C94D4
			// (set) Token: 0x06005B83 RID: 23427 RVA: 0x00021EA3 File Offset: 0x000200A3
			public unsafe UndoNode _childUndo_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__childUndo_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._execute_d__3.NativeFieldInfoPtr__childUndo_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B78 RID: 15224
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B79 RID: 15225
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B7A RID: 15226
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003B7B RID: 15227
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B7C RID: 15228
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003B7D RID: 15229
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003B7E RID: 15230
			private static readonly IntPtr NativeFieldInfoPtr__newAbility_5__3;

			// Token: 0x04003B7F RID: 15231
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__4;

			// Token: 0x04003B80 RID: 15232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B81 RID: 15233
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B82 RID: 15234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B83 RID: 15235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003B84 RID: 15236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B85 RID: 15237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B86 RID: 15238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003B87 RID: 15239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006C2 RID: 1730
		[ObfuscatedName("worm.canis.actions.ResolveSignetRingSwap+<undo>d__4")]
		public sealed class _undo_d__4 : Object
		{
			// Token: 0x06005B84 RID: 23428 RVA: 0x001CB304 File Offset: 0x001C9504
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__4()
			{
				Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveSignetRingSwap>.NativeClassPtr, "<undo>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr);
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<>1__state");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<>2__current");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "undoContext");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<>3__undoContext");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<>4__this");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<player>5__2");
				ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__previousAbility_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, "<previousAbility>5__3");
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668463);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668464);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668465);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668466);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668467);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668468);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668469);
				ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr, 100668470);
			}

			// Token: 0x06005B85 RID: 23429 RVA: 0x001CB470 File Offset: 0x001C9670
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveSignetRingSwap._undo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B86 RID: 23430 RVA: 0x001CB4B8 File Offset: 0x001C96B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B87 RID: 23431 RVA: 0x001CB4EC File Offset: 0x001C96EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143704, XrefRangeEnd = 143718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170017BD RID: 6077
			// (get) Token: 0x06005B88 RID: 23432 RVA: 0x001CB528 File Offset: 0x001C9728
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005B89 RID: 23433 RVA: 0x001CB568 File Offset: 0x001C9768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143718, XrefRangeEnd = 143723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017BE RID: 6078
			// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001CB59C File Offset: 0x001C979C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B8B RID: 23435 RVA: 0x001CB5DC File Offset: 0x001C97DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143723, XrefRangeEnd = 143732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005B8C RID: 23436 RVA: 0x001CB61C File Offset: 0x001C981C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveSignetRingSwap._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005B8D RID: 23437 RVA: 0x00021EC2 File Offset: 0x000200C2
			public _undo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017B5 RID: 6069
			// (get) Token: 0x06005B8E RID: 23438 RVA: 0x001CB65C File Offset: 0x001C985C
			// (set) Token: 0x06005B8F RID: 23439 RVA: 0x00021ECB File Offset: 0x000200CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017B6 RID: 6070
			// (get) Token: 0x06005B90 RID: 23440 RVA: 0x001CB684 File Offset: 0x001C9884
			// (set) Token: 0x06005B91 RID: 23441 RVA: 0x00021EE6 File Offset: 0x000200E6
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B7 RID: 6071
			// (get) Token: 0x06005B92 RID: 23442 RVA: 0x001CB6B4 File Offset: 0x001C98B4
			// (set) Token: 0x06005B93 RID: 23443 RVA: 0x00021F05 File Offset: 0x00020105
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017B8 RID: 6072
			// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001CB6DC File Offset: 0x001C98DC
			// (set) Token: 0x06005B95 RID: 23445 RVA: 0x00021F20 File Offset: 0x00020120
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B9 RID: 6073
			// (get) Token: 0x06005B96 RID: 23446 RVA: 0x001CB70C File Offset: 0x001C990C
			// (set) Token: 0x06005B97 RID: 23447 RVA: 0x00021F3F File Offset: 0x0002013F
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BA RID: 6074
			// (get) Token: 0x06005B98 RID: 23448 RVA: 0x001CB73C File Offset: 0x001C993C
			// (set) Token: 0x06005B99 RID: 23449 RVA: 0x00021F5E File Offset: 0x0002015E
			public unsafe ResolveSignetRingSwap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveSignetRingSwap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BB RID: 6075
			// (get) Token: 0x06005B9A RID: 23450 RVA: 0x001CB76C File Offset: 0x001C996C
			// (set) Token: 0x06005B9B RID: 23451 RVA: 0x00021F7D File Offset: 0x0002017D
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BC RID: 6076
			// (get) Token: 0x06005B9C RID: 23452 RVA: 0x001CB79C File Offset: 0x001C999C
			// (set) Token: 0x06005B9D RID: 23453 RVA: 0x00021F9C File Offset: 0x0002019C
			public unsafe SignetAbility _previousAbility_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__previousAbility_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveSignetRingSwap._undo_d__4.NativeFieldInfoPtr__previousAbility_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B88 RID: 15240
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B89 RID: 15241
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B8A RID: 15242
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003B8B RID: 15243
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003B8C RID: 15244
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003B8D RID: 15245
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B8E RID: 15246
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003B8F RID: 15247
			private static readonly IntPtr NativeFieldInfoPtr__previousAbility_5__3;

			// Token: 0x04003B90 RID: 15248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B91 RID: 15249
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B92 RID: 15250
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B93 RID: 15251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003B94 RID: 15252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B95 RID: 15253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B96 RID: 15254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003B97 RID: 15255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

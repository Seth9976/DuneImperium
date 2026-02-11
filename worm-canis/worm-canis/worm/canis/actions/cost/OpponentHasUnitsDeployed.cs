using System;
using Canis;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.cost
{
	// Token: 0x02000308 RID: 776
	public class OpponentHasUnitsDeployed<T> : CostAction where T : WormUnit
	{
		// Token: 0x06001FC1 RID: 8129 RVA: 0x000D5178 File Offset: 0x000D3378
		// Note: this type is marked as 'beforefieldinit'.
		static OpponentHasUnitsDeployed()
		{
			Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "OpponentHasUnitsDeployed`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr);
			OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, "amountRequirement");
			OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, "amountComparer");
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670964);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670965);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670966);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_Any_Public_Static_OpponentHasUnitsDeployed_1_T_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670967);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_AtLeast_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670968);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_MoreThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670969);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_AtMost_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670970);
			OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_LessThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, 100670971);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000D52AC File Offset: 0x000D34AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpponentHasUnitsDeployed(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amountRequirement;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(amountComparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000D5318 File Offset: 0x000D3518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000D5364 File Offset: 0x000D3564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174144, XrefRangeEnd = 174169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000D53BC File Offset: 0x000D35BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174195, RefRangeEnd = 174197, XrefRangeStart = 174169, XrefRangeEnd = 174195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OpponentHasUnitsDeployed<T> Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_Any_Public_Static_OpponentHasUnitsDeployed_1_T_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000D5400 File Offset: 0x000D3600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174197, XrefRangeEnd = 174223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OpponentHasUnitsDeployed<T> AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_AtLeast_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>>(intPtr3) : null;
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000D5454 File Offset: 0x000D3654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174223, XrefRangeEnd = 174249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OpponentHasUnitsDeployed<T> MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_MoreThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>>(intPtr3) : null;
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000D54A8 File Offset: 0x000D36A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174249, XrefRangeEnd = 174275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OpponentHasUnitsDeployed<T> AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_AtMost_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>>(intPtr3) : null;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000D54FC File Offset: 0x000D36FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174275, XrefRangeEnd = 174301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OpponentHasUnitsDeployed<T> LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.NativeMethodInfoPtr_LessThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>>(intPtr3) : null;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0000D340 File Offset: 0x0000B540
		public OpponentHasUnitsDeployed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000D5550 File Offset: 0x000D3750
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000D349 File Offset: 0x0000B549
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000D5578 File Offset: 0x000D3778
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000D364 File Offset: 0x0000B564
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_OpponentHasUnitsDeployed_1_T_Match_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_OpponentHasUnitsDeployed_1_T_Int32_Match_0;

		// Token: 0x020007BB RID: 1979
		[ObfuscatedName("worm.canis.actions.cost.OpponentHasUnitsDeployed`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06007010 RID: 28688 RVA: 0x0020AAA0 File Offset: 0x00208CA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr);
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9");
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9__5_0");
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9__6_0");
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9__7_0");
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9__8_0");
				OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, "<>9__9_0");
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670973);
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670974);
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670975);
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670976);
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670977);
				OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr, 100670978);
			}

			// Token: 0x06007011 RID: 28689 RVA: 0x0020ABF8 File Offset: 0x00208DF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007012 RID: 28690 RVA: 0x0020AC34 File Offset: 0x00208E34
			[CallerCount(0)]
			public unsafe bool _Any_b__5_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007013 RID: 28691 RVA: 0x0020AC8C File Offset: 0x00208E8C
			[CallerCount(0)]
			public unsafe bool _AtLeast_b__6_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007014 RID: 28692 RVA: 0x0020ACE4 File Offset: 0x00208EE4
			[CallerCount(0)]
			public unsafe bool _MoreThan_b__7_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007015 RID: 28693 RVA: 0x0020AD3C File Offset: 0x00208F3C
			[CallerCount(0)]
			public unsafe bool _AtMost_b__8_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007016 RID: 28694 RVA: 0x0020AD94 File Offset: 0x00208F94
			[CallerCount(0)]
			public unsafe bool _LessThan_b__9_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007017 RID: 28695 RVA: 0x0002C827 File Offset: 0x0002AA27
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC5 RID: 7877
			// (get) Token: 0x06007018 RID: 28696 RVA: 0x0020ADEC File Offset: 0x00208FEC
			// (set) Token: 0x06007019 RID: 28697 RVA: 0x0002C830 File Offset: 0x0002AA30
			public unsafe static OpponentHasUnitsDeployed<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OpponentHasUnitsDeployed<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EC6 RID: 7878
			// (get) Token: 0x0600701A RID: 28698 RVA: 0x0020AE14 File Offset: 0x00209014
			// (set) Token: 0x0600701B RID: 28699 RVA: 0x0002C842 File Offset: 0x0002AA42
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EC7 RID: 7879
			// (get) Token: 0x0600701C RID: 28700 RVA: 0x0020AE3C File Offset: 0x0020903C
			// (set) Token: 0x0600701D RID: 28701 RVA: 0x0002C854 File Offset: 0x0002AA54
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EC8 RID: 7880
			// (get) Token: 0x0600701E RID: 28702 RVA: 0x0020AE64 File Offset: 0x00209064
			// (set) Token: 0x0600701F RID: 28703 RVA: 0x0002C866 File Offset: 0x0002AA66
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EC9 RID: 7881
			// (get) Token: 0x06007020 RID: 28704 RVA: 0x0020AE8C File Offset: 0x0020908C
			// (set) Token: 0x06007021 RID: 28705 RVA: 0x0002C878 File Offset: 0x0002AA78
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ECA RID: 7882
			// (get) Token: 0x06007022 RID: 28706 RVA: 0x0020AEB4 File Offset: 0x002090B4
			// (set) Token: 0x06007023 RID: 28707 RVA: 0x0002C88A File Offset: 0x0002AA8A
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OpponentHasUnitsDeployed<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400486A RID: 18538
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400486B RID: 18539
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400486C RID: 18540
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400486D RID: 18541
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400486E RID: 18542
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400486F RID: 18543
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04004870 RID: 18544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004871 RID: 18545
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004872 RID: 18546
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004873 RID: 18547
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004874 RID: 18548
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004875 RID: 18549
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007BC RID: 1980
		[ObfuscatedName("worm.canis.actions.cost.OpponentHasUnitsDeployed`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06007024 RID: 28708 RVA: 0x0020AEDC File Offset: 0x002090DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr);
				OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_wm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr, "wm");
				OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr, 100670979);
				OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__CanBePaid_b__0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr, 100670980);
			}

			// Token: 0x06007025 RID: 28709 RVA: 0x0020AF80 File Offset: 0x00209180
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007026 RID: 28710 RVA: 0x0020AFBC File Offset: 0x002091BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174139, XrefRangeEnd = 174144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CanBePaid_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__CanBePaid_b__0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007027 RID: 28711 RVA: 0x0002C89C File Offset: 0x0002AA9C
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ECB RID: 7883
			// (get) Token: 0x06007028 RID: 28712 RVA: 0x0020B00C File Offset: 0x0020920C
			// (set) Token: 0x06007029 RID: 28713 RVA: 0x0002C8A5 File Offset: 0x0002AAA5
			public unsafe WormMatch wm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_wm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_wm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004876 RID: 18550
			private static readonly IntPtr NativeFieldInfoPtr_wm;

			// Token: 0x04004877 RID: 18551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004878 RID: 18552
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__0_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x020007BD RID: 1981
		[ObfuscatedName("worm.canis.actions.cost.OpponentHasUnitsDeployed`1+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600702A RID: 28714 RVA: 0x0020B03C File Offset: 0x0020923C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, "<>1__state");
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, "<>2__current");
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670981);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670982);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670983);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670984);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670985);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670986);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670987);
				OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr, 100670988);
			}

			// Token: 0x0600702B RID: 28715 RVA: 0x0020B180 File Offset: 0x00209380
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentHasUnitsDeployed<T>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600702C RID: 28716 RVA: 0x0020B1C8 File Offset: 0x002093C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600702D RID: 28717 RVA: 0x0020B1FC File Offset: 0x002093FC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001ECF RID: 7887
			// (get) Token: 0x0600702E RID: 28718 RVA: 0x0020B238 File Offset: 0x00209438
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600702F RID: 28719 RVA: 0x0020B278 File Offset: 0x00209478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001ED0 RID: 7888
			// (get) Token: 0x06007030 RID: 28720 RVA: 0x0020B2AC File Offset: 0x002094AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007031 RID: 28721 RVA: 0x0020B2EC File Offset: 0x002094EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007032 RID: 28722 RVA: 0x0020B32C File Offset: 0x0020952C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentHasUnitsDeployed<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007033 RID: 28723 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ECC RID: 7884
			// (get) Token: 0x06007034 RID: 28724 RVA: 0x0020B36C File Offset: 0x0020956C
			// (set) Token: 0x06007035 RID: 28725 RVA: 0x0002C8CD File Offset: 0x0002AACD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ECD RID: 7885
			// (get) Token: 0x06007036 RID: 28726 RVA: 0x0020B394 File Offset: 0x00209594
			// (set) Token: 0x06007037 RID: 28727 RVA: 0x0002C8E8 File Offset: 0x0002AAE8
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ECE RID: 7886
			// (get) Token: 0x06007038 RID: 28728 RVA: 0x0020B3C4 File Offset: 0x002095C4
			// (set) Token: 0x06007039 RID: 28729 RVA: 0x0002C907 File Offset: 0x0002AB07
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentHasUnitsDeployed<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04004879 RID: 18553
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400487A RID: 18554
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400487B RID: 18555
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400487C RID: 18556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400487D RID: 18557
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400487E RID: 18558
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400487F RID: 18559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004880 RID: 18560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004881 RID: 18561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004882 RID: 18562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004883 RID: 18563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

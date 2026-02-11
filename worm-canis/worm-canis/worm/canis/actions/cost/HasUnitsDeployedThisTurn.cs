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
	// Token: 0x020002FF RID: 767
	public class HasUnitsDeployedThisTurn<T> : CostAction where T : WormUnit
	{
		// Token: 0x06001F6A RID: 8042 RVA: 0x000D3938 File Offset: 0x000D1B38
		// Note: this type is marked as 'beforefieldinit'.
		static HasUnitsDeployedThisTurn()
		{
			Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "HasUnitsDeployedThisTurn`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr);
			HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, "amountRequirement");
			HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, "amountComparer");
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670816);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670817);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670818);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_Any_Public_Static_HasUnitsDeployedThisTurn_1_T_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670819);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670820);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670821);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670822);
			HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, 100670823);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000D3A6C File Offset: 0x000D1C6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasUnitsDeployedThisTurn(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000D3AD8 File Offset: 0x000D1CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000D3B24 File Offset: 0x000D1D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173438, XrefRangeEnd = 173469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000D3B7C File Offset: 0x000D1D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173469, XrefRangeEnd = 173495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsDeployedThisTurn<T> Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_Any_Public_Static_HasUnitsDeployedThisTurn_1_T_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000D3BC0 File Offset: 0x000D1DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173521, RefRangeEnd = 173522, XrefRangeStart = 173495, XrefRangeEnd = 173521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsDeployedThisTurn<T> AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>>(intPtr3) : null;
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000D3C14 File Offset: 0x000D1E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173522, XrefRangeEnd = 173548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsDeployedThisTurn<T> MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>>(intPtr3) : null;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000D3C68 File Offset: 0x000D1E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173548, XrefRangeEnd = 173574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsDeployedThisTurn<T> AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>>(intPtr3) : null;
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000D3CBC File Offset: 0x000D1EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173574, XrefRangeEnd = 173600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsDeployedThisTurn<T> LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>>(intPtr3) : null;
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0000D1B2 File Offset: 0x0000B3B2
		public HasUnitsDeployedThisTurn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000D3D10 File Offset: 0x000D1F10
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000D1BB File Offset: 0x0000B3BB
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x000D3D38 File Offset: 0x000D1F38
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000D1D6 File Offset: 0x0000B3D6
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_HasUnitsDeployedThisTurn_1_T_Match_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsDeployedThisTurn_1_T_Int32_Match_0;

		// Token: 0x020007AE RID: 1966
		[ObfuscatedName("worm.canis.actions.cost.HasUnitsDeployedThisTurn`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006F2D RID: 28461 RVA: 0x00207984 File Offset: 0x00205B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr);
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__4_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__5_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__6_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__7_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__8_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, "<>9__9_0");
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670825);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670826);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670827);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670828);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670829);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670830);
				HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr, 100670831);
			}

			// Token: 0x06006F2E RID: 28462 RVA: 0x00207B04 File Offset: 0x00205D04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006F2F RID: 28463 RVA: 0x00207B40 File Offset: 0x00205D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanBePaid_b__4_0(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006F30 RID: 28464 RVA: 0x00207B90 File Offset: 0x00205D90
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F31 RID: 28465 RVA: 0x00207BE8 File Offset: 0x00205DE8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F32 RID: 28466 RVA: 0x00207C40 File Offset: 0x00205E40
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F33 RID: 28467 RVA: 0x00207C98 File Offset: 0x00205E98
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F34 RID: 28468 RVA: 0x00207CF0 File Offset: 0x00205EF0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F35 RID: 28469 RVA: 0x0002C2F3 File Offset: 0x0002A4F3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E7F RID: 7807
			// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00207D48 File Offset: 0x00205F48
			// (set) Token: 0x06006F37 RID: 28471 RVA: 0x0002C2FC File Offset: 0x0002A4FC
			public unsafe static HasUnitsDeployedThisTurn<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasUnitsDeployedThisTurn<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E80 RID: 7808
			// (get) Token: 0x06006F38 RID: 28472 RVA: 0x00207D70 File Offset: 0x00205F70
			// (set) Token: 0x06006F39 RID: 28473 RVA: 0x0002C30E File Offset: 0x0002A50E
			public unsafe static Func<WormUnit, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E81 RID: 7809
			// (get) Token: 0x06006F3A RID: 28474 RVA: 0x00207D98 File Offset: 0x00205F98
			// (set) Token: 0x06006F3B RID: 28475 RVA: 0x0002C320 File Offset: 0x0002A520
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E82 RID: 7810
			// (get) Token: 0x06006F3C RID: 28476 RVA: 0x00207DC0 File Offset: 0x00205FC0
			// (set) Token: 0x06006F3D RID: 28477 RVA: 0x0002C332 File Offset: 0x0002A532
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E83 RID: 7811
			// (get) Token: 0x06006F3E RID: 28478 RVA: 0x00207DE8 File Offset: 0x00205FE8
			// (set) Token: 0x06006F3F RID: 28479 RVA: 0x0002C344 File Offset: 0x0002A544
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E84 RID: 7812
			// (get) Token: 0x06006F40 RID: 28480 RVA: 0x00207E10 File Offset: 0x00206010
			// (set) Token: 0x06006F41 RID: 28481 RVA: 0x0002C356 File Offset: 0x0002A556
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E85 RID: 7813
			// (get) Token: 0x06006F42 RID: 28482 RVA: 0x00207E38 File Offset: 0x00206038
			// (set) Token: 0x06006F43 RID: 28483 RVA: 0x0002C368 File Offset: 0x0002A568
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsDeployedThisTurn<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040047D5 RID: 18389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040047D6 RID: 18390
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040047D7 RID: 18391
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040047D8 RID: 18392
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040047D9 RID: 18393
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040047DA RID: 18394
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040047DB RID: 18395
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040047DC RID: 18396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040047DD RID: 18397
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_Boolean_WormUnit_0;

			// Token: 0x040047DE RID: 18398
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047DF RID: 18399
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047E0 RID: 18400
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047E1 RID: 18401
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047E2 RID: 18402
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007AF RID: 1967
		[ObfuscatedName("worm.canis.actions.cost.HasUnitsDeployedThisTurn`1+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06006F44 RID: 28484 RVA: 0x00207E60 File Offset: 0x00206060
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, "<>1__state");
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, "<>2__current");
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670832);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670833);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670834);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670835);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670836);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670837);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670838);
				HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr, 100670839);
			}

			// Token: 0x06006F45 RID: 28485 RVA: 0x00207FA4 File Offset: 0x002061A4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsDeployedThisTurn<T>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006F46 RID: 28486 RVA: 0x00207FEC File Offset: 0x002061EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006F47 RID: 28487 RVA: 0x00208020 File Offset: 0x00206220
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E89 RID: 7817
			// (get) Token: 0x06006F48 RID: 28488 RVA: 0x0020805C File Offset: 0x0020625C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006F49 RID: 28489 RVA: 0x0020809C File Offset: 0x0020629C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E8A RID: 7818
			// (get) Token: 0x06006F4A RID: 28490 RVA: 0x002080D0 File Offset: 0x002062D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006F4B RID: 28491 RVA: 0x00208110 File Offset: 0x00206310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006F4C RID: 28492 RVA: 0x00208150 File Offset: 0x00206350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006F4D RID: 28493 RVA: 0x0002C37A File Offset: 0x0002A57A
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E86 RID: 7814
			// (get) Token: 0x06006F4E RID: 28494 RVA: 0x00208190 File Offset: 0x00206390
			// (set) Token: 0x06006F4F RID: 28495 RVA: 0x0002C383 File Offset: 0x0002A583
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E87 RID: 7815
			// (get) Token: 0x06006F50 RID: 28496 RVA: 0x002081B8 File Offset: 0x002063B8
			// (set) Token: 0x06006F51 RID: 28497 RVA: 0x0002C39E File Offset: 0x0002A59E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E88 RID: 7816
			// (get) Token: 0x06006F52 RID: 28498 RVA: 0x002081E8 File Offset: 0x002063E8
			// (set) Token: 0x06006F53 RID: 28499 RVA: 0x0002C3BD File Offset: 0x0002A5BD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsDeployedThisTurn<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040047E3 RID: 18403
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040047E4 RID: 18404
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040047E5 RID: 18405
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040047E6 RID: 18406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040047E7 RID: 18407
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040047E8 RID: 18408
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040047E9 RID: 18409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040047EA RID: 18410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040047EB RID: 18411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040047EC RID: 18412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040047ED RID: 18413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

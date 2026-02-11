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
	// Token: 0x02000300 RID: 768
	public class HasUnitsGarrisoned<T> : CostAction where T : WormUnit
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x000D3D68 File Offset: 0x000D1F68
		// Note: this type is marked as 'beforefieldinit'.
		static HasUnitsGarrisoned()
		{
			Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "HasUnitsGarrisoned`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr);
			HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, "amountRequirement");
			HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, "amountComparer");
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670840);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670841);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670842);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_Any_Public_Static_HasUnitsGarrisoned_1_T_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670843);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670844);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670845);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670846);
			HasUnitsGarrisoned<T>.NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, 100670847);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000D3E9C File Offset: 0x000D209C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasUnitsGarrisoned(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x000D3F08 File Offset: 0x000D2108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasUnitsGarrisoned<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000D3F54 File Offset: 0x000D2154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173600, XrefRangeEnd = 173614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasUnitsGarrisoned<T>.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000D3FAC File Offset: 0x000D21AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 173640, RefRangeEnd = 173648, XrefRangeStart = 173614, XrefRangeEnd = 173640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsGarrisoned<T> Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr_Any_Public_Static_HasUnitsGarrisoned_1_T_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000D3FF0 File Offset: 0x000D21F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173674, RefRangeEnd = 173676, XrefRangeStart = 173648, XrefRangeEnd = 173674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsGarrisoned<T> AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>>(intPtr3) : null;
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000D4044 File Offset: 0x000D2244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173676, XrefRangeEnd = 173702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsGarrisoned<T> MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>>(intPtr3) : null;
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000D4098 File Offset: 0x000D2298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173702, XrefRangeEnd = 173728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsGarrisoned<T> AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>>(intPtr3) : null;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000D40EC File Offset: 0x000D22EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173728, XrefRangeEnd = 173754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasUnitsGarrisoned<T> LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>>(intPtr3) : null;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0000D1F5 File Offset: 0x0000B3F5
		public HasUnitsGarrisoned(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000D4140 File Offset: 0x000D2340
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0000D1FE File Offset: 0x0000B3FE
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000D4168 File Offset: 0x000D2368
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0000D219 File Offset: 0x0000B419
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_HasUnitsGarrisoned_1_T_Match_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasUnitsGarrisoned_1_T_Int32_Match_0;

		// Token: 0x020007B0 RID: 1968
		[ObfuscatedName("worm.canis.actions.cost.HasUnitsGarrisoned`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006F54 RID: 28500 RVA: 0x00208210 File Offset: 0x00206410
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr);
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9");
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9__5_0");
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9__6_0");
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9__7_0");
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9__8_0");
				HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, "<>9__9_0");
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670849);
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670850);
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670851);
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670852);
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670853);
				HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr, 100670854);
			}

			// Token: 0x06006F55 RID: 28501 RVA: 0x00208368 File Offset: 0x00206568
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsGarrisoned<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006F56 RID: 28502 RVA: 0x002083A4 File Offset: 0x002065A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F57 RID: 28503 RVA: 0x002083FC File Offset: 0x002065FC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F58 RID: 28504 RVA: 0x00208454 File Offset: 0x00206654
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F59 RID: 28505 RVA: 0x002084AC File Offset: 0x002066AC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F5A RID: 28506 RVA: 0x00208504 File Offset: 0x00206704
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F5B RID: 28507 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E8B RID: 7819
			// (get) Token: 0x06006F5C RID: 28508 RVA: 0x0020855C File Offset: 0x0020675C
			// (set) Token: 0x06006F5D RID: 28509 RVA: 0x0002C3E1 File Offset: 0x0002A5E1
			public unsafe static HasUnitsGarrisoned<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasUnitsGarrisoned<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E8C RID: 7820
			// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00208584 File Offset: 0x00206784
			// (set) Token: 0x06006F5F RID: 28511 RVA: 0x0002C3F3 File Offset: 0x0002A5F3
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E8D RID: 7821
			// (get) Token: 0x06006F60 RID: 28512 RVA: 0x002085AC File Offset: 0x002067AC
			// (set) Token: 0x06006F61 RID: 28513 RVA: 0x0002C405 File Offset: 0x0002A605
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E8E RID: 7822
			// (get) Token: 0x06006F62 RID: 28514 RVA: 0x002085D4 File Offset: 0x002067D4
			// (set) Token: 0x06006F63 RID: 28515 RVA: 0x0002C417 File Offset: 0x0002A617
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E8F RID: 7823
			// (get) Token: 0x06006F64 RID: 28516 RVA: 0x002085FC File Offset: 0x002067FC
			// (set) Token: 0x06006F65 RID: 28517 RVA: 0x0002C429 File Offset: 0x0002A629
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E90 RID: 7824
			// (get) Token: 0x06006F66 RID: 28518 RVA: 0x00208624 File Offset: 0x00206824
			// (set) Token: 0x06006F67 RID: 28519 RVA: 0x0002C43B File Offset: 0x0002A63B
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasUnitsGarrisoned<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040047EE RID: 18414
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040047EF RID: 18415
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040047F0 RID: 18416
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040047F1 RID: 18417
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040047F2 RID: 18418
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040047F3 RID: 18419
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040047F4 RID: 18420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040047F5 RID: 18421
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047F6 RID: 18422
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047F7 RID: 18423
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047F8 RID: 18424
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040047F9 RID: 18425
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007B1 RID: 1969
		[ObfuscatedName("worm.canis.actions.cost.HasUnitsGarrisoned`1+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06006F68 RID: 28520 RVA: 0x0020864C File Offset: 0x0020684C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasUnitsGarrisoned<T>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr);
				HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, "<>1__state");
				HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, "<>2__current");
				HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670855);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670856);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670857);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670858);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670859);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670860);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670861);
				HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr, 100670862);
			}

			// Token: 0x06006F69 RID: 28521 RVA: 0x00208790 File Offset: 0x00206990
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasUnitsGarrisoned<T>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006F6A RID: 28522 RVA: 0x002087D8 File Offset: 0x002069D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006F6B RID: 28523 RVA: 0x0020880C File Offset: 0x00206A0C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E94 RID: 7828
			// (get) Token: 0x06006F6C RID: 28524 RVA: 0x00208848 File Offset: 0x00206A48
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006F6D RID: 28525 RVA: 0x00208888 File Offset: 0x00206A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E95 RID: 7829
			// (get) Token: 0x06006F6E RID: 28526 RVA: 0x002088BC File Offset: 0x00206ABC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006F6F RID: 28527 RVA: 0x002088FC File Offset: 0x00206AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006F70 RID: 28528 RVA: 0x0020893C File Offset: 0x00206B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasUnitsGarrisoned<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006F71 RID: 28529 RVA: 0x0002C44D File Offset: 0x0002A64D
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E91 RID: 7825
			// (get) Token: 0x06006F72 RID: 28530 RVA: 0x0020897C File Offset: 0x00206B7C
			// (set) Token: 0x06006F73 RID: 28531 RVA: 0x0002C456 File Offset: 0x0002A656
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E92 RID: 7826
			// (get) Token: 0x06006F74 RID: 28532 RVA: 0x002089A4 File Offset: 0x00206BA4
			// (set) Token: 0x06006F75 RID: 28533 RVA: 0x0002C471 File Offset: 0x0002A671
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E93 RID: 7827
			// (get) Token: 0x06006F76 RID: 28534 RVA: 0x002089D4 File Offset: 0x00206BD4
			// (set) Token: 0x06006F77 RID: 28535 RVA: 0x0002C490 File Offset: 0x0002A690
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasUnitsGarrisoned<T>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040047FA RID: 18426
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040047FB RID: 18427
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040047FC RID: 18428
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040047FD RID: 18429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040047FE RID: 18430
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040047FF RID: 18431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004800 RID: 18432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004801 RID: 18433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004802 RID: 18434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004803 RID: 18435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004804 RID: 18436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

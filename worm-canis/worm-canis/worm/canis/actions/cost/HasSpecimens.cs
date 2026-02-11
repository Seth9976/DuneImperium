using System;
using Canis;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions.cost
{
	// Token: 0x02000302 RID: 770
	public class HasSpecimens : CostAction
	{
		// Token: 0x06001F94 RID: 8084 RVA: 0x000D45C8 File Offset: 0x000D27C8
		// Note: this type is marked as 'beforefieldinit'.
		static HasSpecimens()
		{
			Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "HasSpecimens");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr);
			HasSpecimens.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, "amountRequirement");
			HasSpecimens.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, "amountComparer");
			HasSpecimens.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670886);
			HasSpecimens.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670887);
			HasSpecimens.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670888);
			HasSpecimens.NativeMethodInfoPtr_Any_Public_Static_HasSpecimens_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670889);
			HasSpecimens.NativeMethodInfoPtr_AtLeast_Public_Static_HasSpecimens_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670890);
			HasSpecimens.NativeMethodInfoPtr_MoreThan_Public_Static_HasSpecimens_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670891);
			HasSpecimens.NativeMethodInfoPtr_AtMost_Public_Static_HasSpecimens_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670892);
			HasSpecimens.NativeMethodInfoPtr_LessThan_Public_Static_HasSpecimens_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, 100670893);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000D46C0 File Offset: 0x000D28C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasSpecimens(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000D472C File Offset: 0x000D292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173909, XrefRangeEnd = 173914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasSpecimens.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000D4778 File Offset: 0x000D2978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173914, XrefRangeEnd = 173928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasSpecimens.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000D47D0 File Offset: 0x000D29D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173948, RefRangeEnd = 173950, XrefRangeStart = 173928, XrefRangeEnd = 173948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasSpecimens Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr_Any_Public_Static_HasSpecimens_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasSpecimens>(intPtr3) : null;
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000D4814 File Offset: 0x000D2A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173970, RefRangeEnd = 173972, XrefRangeStart = 173950, XrefRangeEnd = 173970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasSpecimens AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr_AtLeast_Public_Static_HasSpecimens_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasSpecimens>(intPtr3) : null;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000D4868 File Offset: 0x000D2A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173972, XrefRangeEnd = 173992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasSpecimens MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr_MoreThan_Public_Static_HasSpecimens_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasSpecimens>(intPtr3) : null;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000D48BC File Offset: 0x000D2ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173992, XrefRangeEnd = 174012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasSpecimens AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr_AtMost_Public_Static_HasSpecimens_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasSpecimens>(intPtr3) : null;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000D4910 File Offset: 0x000D2B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174012, XrefRangeEnd = 174032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasSpecimens LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.NativeMethodInfoPtr_LessThan_Public_Static_HasSpecimens_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasSpecimens>(intPtr3) : null;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0000D27B File Offset: 0x0000B47B
		public HasSpecimens(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000D4964 File Offset: 0x000D2B64
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x0000D284 File Offset: 0x0000B484
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x000D498C File Offset: 0x000D2B8C
		// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x0000D29F File Offset: 0x0000B49F
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_HasSpecimens_Match_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasSpecimens_Int32_Match_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasSpecimens_Int32_Match_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasSpecimens_Int32_Match_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasSpecimens_Int32_Match_0;

		// Token: 0x020007B4 RID: 1972
		[ObfuscatedName("worm.canis.actions.cost.HasSpecimens+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006F9C RID: 28572 RVA: 0x002091E8 File Offset: 0x002073E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr);
				HasSpecimens.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9");
				HasSpecimens.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9__5_0");
				HasSpecimens.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9__6_0");
				HasSpecimens.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9__7_0");
				HasSpecimens.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9__8_0");
				HasSpecimens.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, "<>9__9_0");
				HasSpecimens.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670895);
				HasSpecimens.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670896);
				HasSpecimens.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670897);
				HasSpecimens.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670898);
				HasSpecimens.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670899);
				HasSpecimens.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr, 100670900);
			}

			// Token: 0x06006F9D RID: 28573 RVA: 0x00209304 File Offset: 0x00207504
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasSpecimens.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006F9E RID: 28574 RVA: 0x00209340 File Offset: 0x00207540
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006F9F RID: 28575 RVA: 0x00209398 File Offset: 0x00207598
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006FA0 RID: 28576 RVA: 0x002093F0 File Offset: 0x002075F0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006FA1 RID: 28577 RVA: 0x00209448 File Offset: 0x00207648
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006FA2 RID: 28578 RVA: 0x002094A0 File Offset: 0x002076A0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006FA3 RID: 28579 RVA: 0x0002C57E File Offset: 0x0002A77E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EA1 RID: 7841
			// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x002094F8 File Offset: 0x002076F8
			// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x0002C587 File Offset: 0x0002A787
			public unsafe static HasSpecimens.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasSpecimens.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA2 RID: 7842
			// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x00209520 File Offset: 0x00207720
			// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x0002C599 File Offset: 0x0002A799
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA3 RID: 7843
			// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x00209548 File Offset: 0x00207748
			// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x0002C5AB File Offset: 0x0002A7AB
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA4 RID: 7844
			// (get) Token: 0x06006FAA RID: 28586 RVA: 0x00209570 File Offset: 0x00207770
			// (set) Token: 0x06006FAB RID: 28587 RVA: 0x0002C5BD File Offset: 0x0002A7BD
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA5 RID: 7845
			// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00209598 File Offset: 0x00207798
			// (set) Token: 0x06006FAD RID: 28589 RVA: 0x0002C5CF File Offset: 0x0002A7CF
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA6 RID: 7846
			// (get) Token: 0x06006FAE RID: 28590 RVA: 0x002095C0 File Offset: 0x002077C0
			// (set) Token: 0x06006FAF RID: 28591 RVA: 0x0002C5E1 File Offset: 0x0002A7E1
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasSpecimens.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasSpecimens.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400481C RID: 18460
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400481D RID: 18461
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400481E RID: 18462
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400481F RID: 18463
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04004820 RID: 18464
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04004821 RID: 18465
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04004822 RID: 18466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004823 RID: 18467
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004824 RID: 18468
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004825 RID: 18469
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004826 RID: 18470
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004827 RID: 18471
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007B5 RID: 1973
		[ObfuscatedName("worm.canis.actions.cost.HasSpecimens+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06006FB0 RID: 28592 RVA: 0x002095E8 File Offset: 0x002077E8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasSpecimens>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr);
				HasSpecimens._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, "<>1__state");
				HasSpecimens._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, "<>2__current");
				HasSpecimens._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HasSpecimens._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670901);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670902);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670903);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670904);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670905);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670906);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670907);
				HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr, 100670908);
			}

			// Token: 0x06006FB1 RID: 28593 RVA: 0x002096F0 File Offset: 0x002078F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasSpecimens._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006FB2 RID: 28594 RVA: 0x00209738 File Offset: 0x00207938
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006FB3 RID: 28595 RVA: 0x0020976C File Offset: 0x0020796C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EAA RID: 7850
			// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x002097A8 File Offset: 0x002079A8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006FB5 RID: 28597 RVA: 0x002097E8 File Offset: 0x002079E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173902, XrefRangeEnd = 173907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EAB RID: 7851
			// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x0020981C File Offset: 0x00207A1C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006FB7 RID: 28599 RVA: 0x0020985C File Offset: 0x00207A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173907, XrefRangeEnd = 173909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006FB8 RID: 28600 RVA: 0x0020989C File Offset: 0x00207A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSpecimens._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006FB9 RID: 28601 RVA: 0x0002C5F3 File Offset: 0x0002A7F3
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EA7 RID: 7847
			// (get) Token: 0x06006FBA RID: 28602 RVA: 0x002098DC File Offset: 0x00207ADC
			// (set) Token: 0x06006FBB RID: 28603 RVA: 0x0002C5FC File Offset: 0x0002A7FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EA8 RID: 7848
			// (get) Token: 0x06006FBC RID: 28604 RVA: 0x00209904 File Offset: 0x00207B04
			// (set) Token: 0x06006FBD RID: 28605 RVA: 0x0002C617 File Offset: 0x0002A817
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EA9 RID: 7849
			// (get) Token: 0x06006FBE RID: 28606 RVA: 0x00209934 File Offset: 0x00207B34
			// (set) Token: 0x06006FBF RID: 28607 RVA: 0x0002C636 File Offset: 0x0002A836
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSpecimens._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04004828 RID: 18472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004829 RID: 18473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400482A RID: 18474
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400482B RID: 18475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400482C RID: 18476
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400482D RID: 18477
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400482E RID: 18478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400482F RID: 18479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004830 RID: 18480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004831 RID: 18481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004832 RID: 18482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

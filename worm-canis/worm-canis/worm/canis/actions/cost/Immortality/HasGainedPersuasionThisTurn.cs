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

namespace worm.canis.actions.cost.Immortality
{
	// Token: 0x02000313 RID: 787
	public class HasGainedPersuasionThisTurn : CostAction
	{
		// Token: 0x06002018 RID: 8216 RVA: 0x000D6808 File Offset: 0x000D4A08
		// Note: this type is marked as 'beforefieldinit'.
		static HasGainedPersuasionThisTurn()
		{
			Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.Immortality", "HasGainedPersuasionThisTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr);
			HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, "amountRequirement");
			HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, "amountComparer");
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671112);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671113);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671114);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_Any_Public_Static_HasGainedPersuasionThisTurn_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671115);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_AtLeast_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671116);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_MoreThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671117);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_AtMost_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671118);
			HasGainedPersuasionThisTurn.NativeMethodInfoPtr_LessThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, 100671119);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000D6900 File Offset: 0x000D4B00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasGainedPersuasionThisTurn(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000D696C File Offset: 0x000D4B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174814, XrefRangeEnd = 174819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasGainedPersuasionThisTurn.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000D69B8 File Offset: 0x000D4BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174819, XrefRangeEnd = 174835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasGainedPersuasionThisTurn.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000D6A10 File Offset: 0x000D4C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174835, XrefRangeEnd = 174855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasGainedPersuasionThisTurn Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr_Any_Public_Static_HasGainedPersuasionThisTurn_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn>(intPtr3) : null;
			}
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000D6A54 File Offset: 0x000D4C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174875, RefRangeEnd = 174876, XrefRangeStart = 174855, XrefRangeEnd = 174875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasGainedPersuasionThisTurn AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr_AtLeast_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn>(intPtr3) : null;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000D6AA8 File Offset: 0x000D4CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174876, XrefRangeEnd = 174896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasGainedPersuasionThisTurn MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr_MoreThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn>(intPtr3) : null;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000D6AFC File Offset: 0x000D4CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174896, XrefRangeEnd = 174916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasGainedPersuasionThisTurn AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr_AtMost_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn>(intPtr3) : null;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000D6B50 File Offset: 0x000D4D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174916, XrefRangeEnd = 174936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasGainedPersuasionThisTurn LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.NativeMethodInfoPtr_LessThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn>(intPtr3) : null;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		public HasGainedPersuasionThisTurn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000D6BA4 File Offset: 0x000D4DA4
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000D4ED File Offset: 0x0000B6ED
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000D6BCC File Offset: 0x000D4DCC
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000D508 File Offset: 0x0000B708
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_HasGainedPersuasionThisTurn_Match_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasGainedPersuasionThisTurn_Int32_Match_0;

		// Token: 0x020007CE RID: 1998
		[ObfuscatedName("worm.canis.actions.cost.Immortality.HasGainedPersuasionThisTurn+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600710C RID: 28940 RVA: 0x0020DDF0 File Offset: 0x0020BFF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr);
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9");
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9__5_0");
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9__6_0");
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9__7_0");
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9__8_0");
				HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, "<>9__9_0");
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671121);
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671122);
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671123);
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671124);
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671125);
				HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr, 100671126);
			}

			// Token: 0x0600710D RID: 28941 RVA: 0x0020DF0C File Offset: 0x0020C10C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasGainedPersuasionThisTurn.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600710E RID: 28942 RVA: 0x0020DF48 File Offset: 0x0020C148
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600710F RID: 28943 RVA: 0x0020DFA0 File Offset: 0x0020C1A0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007110 RID: 28944 RVA: 0x0020DFF8 File Offset: 0x0020C1F8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007111 RID: 28945 RVA: 0x0020E050 File Offset: 0x0020C250
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007112 RID: 28946 RVA: 0x0020E0A8 File Offset: 0x0020C2A8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007113 RID: 28947 RVA: 0x0002CE7F File Offset: 0x0002B07F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F10 RID: 7952
			// (get) Token: 0x06007114 RID: 28948 RVA: 0x0020E100 File Offset: 0x0020C300
			// (set) Token: 0x06007115 RID: 28949 RVA: 0x0002CE88 File Offset: 0x0002B088
			public unsafe static HasGainedPersuasionThisTurn.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasGainedPersuasionThisTurn.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F11 RID: 7953
			// (get) Token: 0x06007116 RID: 28950 RVA: 0x0020E128 File Offset: 0x0020C328
			// (set) Token: 0x06007117 RID: 28951 RVA: 0x0002CE9A File Offset: 0x0002B09A
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F12 RID: 7954
			// (get) Token: 0x06007118 RID: 28952 RVA: 0x0020E150 File Offset: 0x0020C350
			// (set) Token: 0x06007119 RID: 28953 RVA: 0x0002CEAC File Offset: 0x0002B0AC
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F13 RID: 7955
			// (get) Token: 0x0600711A RID: 28954 RVA: 0x0020E178 File Offset: 0x0020C378
			// (set) Token: 0x0600711B RID: 28955 RVA: 0x0002CEBE File Offset: 0x0002B0BE
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F14 RID: 7956
			// (get) Token: 0x0600711C RID: 28956 RVA: 0x0020E1A0 File Offset: 0x0020C3A0
			// (set) Token: 0x0600711D RID: 28957 RVA: 0x0002CED0 File Offset: 0x0002B0D0
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F15 RID: 7957
			// (get) Token: 0x0600711E RID: 28958 RVA: 0x0020E1C8 File Offset: 0x0020C3C8
			// (set) Token: 0x0600711F RID: 28959 RVA: 0x0002CEE2 File Offset: 0x0002B0E2
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasGainedPersuasionThisTurn.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004907 RID: 18695
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004908 RID: 18696
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04004909 RID: 18697
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400490A RID: 18698
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400490B RID: 18699
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400490C RID: 18700
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400490D RID: 18701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400490E RID: 18702
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x0400490F RID: 18703
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004910 RID: 18704
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004911 RID: 18705
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x04004912 RID: 18706
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007CF RID: 1999
		[ObfuscatedName("worm.canis.actions.cost.Immortality.HasGainedPersuasionThisTurn+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06007120 RID: 28960 RVA: 0x0020E1F0 File Offset: 0x0020C3F0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasGainedPersuasionThisTurn>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr);
				HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, "<>1__state");
				HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, "<>2__current");
				HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671127);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671128);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671129);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671130);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671131);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671132);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671133);
				HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr, 100671134);
			}

			// Token: 0x06007121 RID: 28961 RVA: 0x0020E2F8 File Offset: 0x0020C4F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasGainedPersuasionThisTurn._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007122 RID: 28962 RVA: 0x0020E340 File Offset: 0x0020C540
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007123 RID: 28963 RVA: 0x0020E374 File Offset: 0x0020C574
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001F19 RID: 7961
			// (get) Token: 0x06007124 RID: 28964 RVA: 0x0020E3B0 File Offset: 0x0020C5B0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007125 RID: 28965 RVA: 0x0020E3F0 File Offset: 0x0020C5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174807, XrefRangeEnd = 174812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001F1A RID: 7962
			// (get) Token: 0x06007126 RID: 28966 RVA: 0x0020E424 File Offset: 0x0020C624
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007127 RID: 28967 RVA: 0x0020E464 File Offset: 0x0020C664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174812, XrefRangeEnd = 174814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007128 RID: 28968 RVA: 0x0020E4A4 File Offset: 0x0020C6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGainedPersuasionThisTurn._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007129 RID: 28969 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F16 RID: 7958
			// (get) Token: 0x0600712A RID: 28970 RVA: 0x0020E4E4 File Offset: 0x0020C6E4
			// (set) Token: 0x0600712B RID: 28971 RVA: 0x0002CEFD File Offset: 0x0002B0FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001F17 RID: 7959
			// (get) Token: 0x0600712C RID: 28972 RVA: 0x0020E50C File Offset: 0x0020C70C
			// (set) Token: 0x0600712D RID: 28973 RVA: 0x0002CF18 File Offset: 0x0002B118
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F18 RID: 7960
			// (get) Token: 0x0600712E RID: 28974 RVA: 0x0020E53C File Offset: 0x0020C73C
			// (set) Token: 0x0600712F RID: 28975 RVA: 0x0002CF37 File Offset: 0x0002B137
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasGainedPersuasionThisTurn._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04004913 RID: 18707
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004914 RID: 18708
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004915 RID: 18709
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004916 RID: 18710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004917 RID: 18711
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004918 RID: 18712
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004919 RID: 18713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400491A RID: 18714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400491B RID: 18715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400491C RID: 18716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400491D RID: 18717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

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

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030A RID: 778
	public class HasTechTiles : CostAction
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x000D5798 File Offset: 0x000D3998
		// Note: this type is marked as 'beforefieldinit'.
		static HasTechTiles()
		{
			Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "HasTechTiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr);
			HasTechTiles.NativeFieldInfoPtr_amountRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, "amountRequirement");
			HasTechTiles.NativeFieldInfoPtr_amountComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, "amountComparer");
			HasTechTiles.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671005);
			HasTechTiles.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671006);
			HasTechTiles.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671007);
			HasTechTiles.NativeMethodInfoPtr_Any_Public_Static_HasTechTiles_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671008);
			HasTechTiles.NativeMethodInfoPtr_AtLeast_Public_Static_HasTechTiles_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671009);
			HasTechTiles.NativeMethodInfoPtr_MoreThan_Public_Static_HasTechTiles_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671010);
			HasTechTiles.NativeMethodInfoPtr_AtMost_Public_Static_HasTechTiles_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671011);
			HasTechTiles.NativeMethodInfoPtr_LessThan_Public_Static_HasTechTiles_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, 100671012);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000D5890 File Offset: 0x000D3A90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172606, RefRangeEnd = 172611, XrefRangeStart = 172606, XrefRangeEnd = 172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasTechTiles(int amountRequirement, Func<int, int, bool> amountComparer, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000D58FC File Offset: 0x000D3AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174382, XrefRangeEnd = 174387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasTechTiles.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000D5948 File Offset: 0x000D3B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174387, XrefRangeEnd = 174397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasTechTiles.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000D59A0 File Offset: 0x000D3BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174397, XrefRangeEnd = 174417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasTechTiles Any(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr_Any_Public_Static_HasTechTiles_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasTechTiles>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000D59E4 File Offset: 0x000D3BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174437, RefRangeEnd = 174439, XrefRangeStart = 174417, XrefRangeEnd = 174437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasTechTiles AtLeast(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr_AtLeast_Public_Static_HasTechTiles_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasTechTiles>(intPtr3) : null;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000D5A38 File Offset: 0x000D3C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174439, XrefRangeEnd = 174459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasTechTiles MoreThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr_MoreThan_Public_Static_HasTechTiles_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasTechTiles>(intPtr3) : null;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000D5A8C File Offset: 0x000D3C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174459, XrefRangeEnd = 174479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasTechTiles AtMost(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr_AtMost_Public_Static_HasTechTiles_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasTechTiles>(intPtr3) : null;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000D5AE0 File Offset: 0x000D3CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174479, XrefRangeEnd = 174499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HasTechTiles LessThan(int amount, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.NativeMethodInfoPtr_LessThan_Public_Static_HasTechTiles_Int32_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HasTechTiles>(intPtr3) : null;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0000D3C2 File Offset: 0x0000B5C2
		public HasTechTiles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000D5B34 File Offset: 0x000D3D34
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0000D3CB File Offset: 0x0000B5CB
		public unsafe int amountRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles.NativeFieldInfoPtr_amountRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles.NativeFieldInfoPtr_amountRequirement)) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000D5B5C File Offset: 0x000D3D5C
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public unsafe Func<int, int, bool> amountComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles.NativeFieldInfoPtr_amountComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles.NativeFieldInfoPtr_amountComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeFieldInfoPtr_amountRequirement;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_amountComparer;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_Int32_Int32_Boolean_Match_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_HasTechTiles_Match_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_AtLeast_Public_Static_HasTechTiles_Int32_Match_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_MoreThan_Public_Static_HasTechTiles_Int32_Match_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_AtMost_Public_Static_HasTechTiles_Int32_Match_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_HasTechTiles_Int32_Match_0;

		// Token: 0x020007C1 RID: 1985
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.HasTechTiles+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600705C RID: 28764 RVA: 0x0020BA54 File Offset: 0x00209C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr);
				HasTechTiles.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9");
				HasTechTiles.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9__5_0");
				HasTechTiles.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9__6_0");
				HasTechTiles.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9__7_0");
				HasTechTiles.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9__8_0");
				HasTechTiles.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, "<>9__9_0");
				HasTechTiles.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671014);
				HasTechTiles.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671015);
				HasTechTiles.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671016);
				HasTechTiles.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671017);
				HasTechTiles.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671018);
				HasTechTiles.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr, 100671019);
			}

			// Token: 0x0600705D RID: 28765 RVA: 0x0020BB70 File Offset: 0x00209D70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasTechTiles.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600705E RID: 28766 RVA: 0x0020BBAC File Offset: 0x00209DAC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600705F RID: 28767 RVA: 0x0020BC04 File Offset: 0x00209E04
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007060 RID: 28768 RVA: 0x0020BC5C File Offset: 0x00209E5C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007061 RID: 28769 RVA: 0x0020BCB4 File Offset: 0x00209EB4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007062 RID: 28770 RVA: 0x0020BD0C File Offset: 0x00209F0C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles.__c.NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007063 RID: 28771 RVA: 0x0002CA0B File Offset: 0x0002AC0B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EDB RID: 7899
			// (get) Token: 0x06007064 RID: 28772 RVA: 0x0020BD64 File Offset: 0x00209F64
			// (set) Token: 0x06007065 RID: 28773 RVA: 0x0002CA14 File Offset: 0x0002AC14
			public unsafe static HasTechTiles.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasTechTiles.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EDC RID: 7900
			// (get) Token: 0x06007066 RID: 28774 RVA: 0x0020BD8C File Offset: 0x00209F8C
			// (set) Token: 0x06007067 RID: 28775 RVA: 0x0002CA26 File Offset: 0x0002AC26
			public unsafe static Func<int, int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EDD RID: 7901
			// (get) Token: 0x06007068 RID: 28776 RVA: 0x0020BDB4 File Offset: 0x00209FB4
			// (set) Token: 0x06007069 RID: 28777 RVA: 0x0002CA38 File Offset: 0x0002AC38
			public unsafe static Func<int, int, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EDE RID: 7902
			// (get) Token: 0x0600706A RID: 28778 RVA: 0x0020BDDC File Offset: 0x00209FDC
			// (set) Token: 0x0600706B RID: 28779 RVA: 0x0002CA4A File Offset: 0x0002AC4A
			public unsafe static Func<int, int, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EDF RID: 7903
			// (get) Token: 0x0600706C RID: 28780 RVA: 0x0020BE04 File Offset: 0x0020A004
			// (set) Token: 0x0600706D RID: 28781 RVA: 0x0002CA5C File Offset: 0x0002AC5C
			public unsafe static Func<int, int, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EE0 RID: 7904
			// (get) Token: 0x0600706E RID: 28782 RVA: 0x0020BE2C File Offset: 0x0020A02C
			// (set) Token: 0x0600706F RID: 28783 RVA: 0x0002CA6E File Offset: 0x0002AC6E
			public unsafe static Func<int, int, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasTechTiles.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasTechTiles.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004898 RID: 18584
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004899 RID: 18585
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400489A RID: 18586
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400489B RID: 18587
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400489C RID: 18588
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400489D RID: 18589
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400489E RID: 18590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400489F RID: 18591
			private static readonly IntPtr NativeMethodInfoPtr__Any_b__5_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040048A0 RID: 18592
			private static readonly IntPtr NativeMethodInfoPtr__AtLeast_b__6_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040048A1 RID: 18593
			private static readonly IntPtr NativeMethodInfoPtr__MoreThan_b__7_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040048A2 RID: 18594
			private static readonly IntPtr NativeMethodInfoPtr__AtMost_b__8_0_Internal_Boolean_Int32_Int32_0;

			// Token: 0x040048A3 RID: 18595
			private static readonly IntPtr NativeMethodInfoPtr__LessThan_b__9_0_Internal_Boolean_Int32_Int32_0;
		}

		// Token: 0x020007C2 RID: 1986
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.HasTechTiles+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06007070 RID: 28784 RVA: 0x0020BE54 File Offset: 0x0020A054
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasTechTiles>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr);
				HasTechTiles._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, "<>1__state");
				HasTechTiles._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, "<>2__current");
				HasTechTiles._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HasTechTiles._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671020);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671021);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671022);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671023);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671024);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671025);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671026);
				HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr, 100671027);
			}

			// Token: 0x06007071 RID: 28785 RVA: 0x0020BF5C File Offset: 0x0020A15C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasTechTiles._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007072 RID: 28786 RVA: 0x0020BFA4 File Offset: 0x0020A1A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007073 RID: 28787 RVA: 0x0020BFD8 File Offset: 0x0020A1D8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EE4 RID: 7908
			// (get) Token: 0x06007074 RID: 28788 RVA: 0x0020C014 File Offset: 0x0020A214
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007075 RID: 28789 RVA: 0x0020C054 File Offset: 0x0020A254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174375, XrefRangeEnd = 174380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EE5 RID: 7909
			// (get) Token: 0x06007076 RID: 28790 RVA: 0x0020C088 File Offset: 0x0020A288
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007077 RID: 28791 RVA: 0x0020C0C8 File Offset: 0x0020A2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174380, XrefRangeEnd = 174382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007078 RID: 28792 RVA: 0x0020C108 File Offset: 0x0020A308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasTechTiles._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007079 RID: 28793 RVA: 0x0002CA80 File Offset: 0x0002AC80
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EE1 RID: 7905
			// (get) Token: 0x0600707A RID: 28794 RVA: 0x0020C148 File Offset: 0x0020A348
			// (set) Token: 0x0600707B RID: 28795 RVA: 0x0002CA89 File Offset: 0x0002AC89
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EE2 RID: 7906
			// (get) Token: 0x0600707C RID: 28796 RVA: 0x0020C170 File Offset: 0x0020A370
			// (set) Token: 0x0600707D RID: 28797 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EE3 RID: 7907
			// (get) Token: 0x0600707E RID: 28798 RVA: 0x0020C1A0 File Offset: 0x0020A3A0
			// (set) Token: 0x0600707F RID: 28799 RVA: 0x0002CAC3 File Offset: 0x0002ACC3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasTechTiles._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040048A4 RID: 18596
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040048A5 RID: 18597
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040048A6 RID: 18598
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040048A7 RID: 18599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040048A8 RID: 18600
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048A9 RID: 18601
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040048AA RID: 18602
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040048AB RID: 18603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048AC RID: 18604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040048AD RID: 18605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040048AE RID: 18606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	public class KerningTable : Object
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		// Note: this type is marked as 'beforefieldinit'.
		static KerningTable()
		{
			Il2CppClassPointerStore<KerningTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable>.NativeClassPtr);
			KerningTable.NativeFieldInfoPtr_kerningPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "kerningPairs");
			KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663883);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663884);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663885);
			KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663886);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663887);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663888);
			KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663889);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001C374 File Offset: 0x0001A574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041091, XrefRangeEnd = 1041099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041099, XrefRangeEnd = 1041119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKerningPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041119, XrefRangeEnd = 1041134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKerningPair(uint first, uint second, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001C44C File Offset: 0x0001A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041134, XrefRangeEnd = 1041149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041149, XrefRangeEnd = 1041165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int left, int right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001C50C File Offset: 0x0001A70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041165, XrefRangeEnd = 1041169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001C54C File Offset: 0x0001A74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041169, XrefRangeEnd = 1041208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortKerningPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public KerningTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001C580 File Offset: 0x0001A780
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00004DE1 File Offset: 0x00002FE1
		public unsafe List<KerningPair> kerningPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KerningPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_kerningPairs;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Void_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_SortKerningPairs_Public_Void_0;

		// Token: 0x0200008A RID: 138
		[ObfuscatedName("TMPro.KerningTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F2A RID: 3882 RVA: 0x0003CB4C File Offset: 0x0003AD4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr);
				KerningTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9");
				KerningTable.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_0");
				KerningTable.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_1");
				KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663891);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663892);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663893);
			}

			// Token: 0x06000F2B RID: 3883 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F2C RID: 3884 RVA: 0x0003CC2C File Offset: 0x0003AE2C
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_0(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F2D RID: 3885 RVA: 0x0003CC7C File Offset: 0x0003AE7C
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_1(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F2E RID: 3886 RVA: 0x000092A9 File Offset: 0x000074A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0003CCCC File Offset: 0x0003AECC
			// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000092B2 File Offset: 0x000074B2
			public unsafe static KerningTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
			// (set) Token: 0x06000F32 RID: 3890 RVA: 0x000092C4 File Offset: 0x000074C4
			public unsafe static Func<KerningPair, uint> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0003CD1C File Offset: 0x0003AF1C
			// (set) Token: 0x06000F34 RID: 3892 RVA: 0x000092D6 File Offset: 0x000074D6
			public unsafe static Func<KerningPair, uint> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BEF RID: 3055
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BF0 RID: 3056
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000BF1 RID: 3057
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04000BF2 RID: 3058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BF3 RID: 3059
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0;

			// Token: 0x04000BF4 RID: 3060
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0;
		}

		// Token: 0x0200008B RID: 139
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000F35 RID: 3893 RVA: 0x0003CD44 File Offset: 0x0003AF44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100663894);
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100663895);
			}

			// Token: 0x06000F36 RID: 3894 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F37 RID: 3895 RVA: 0x0003CDFC File Offset: 0x0003AFFC
			[CallerCount(0)]
			public unsafe bool _AddKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F38 RID: 3896 RVA: 0x000092E8 File Offset: 0x000074E8
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0003CE4C File Offset: 0x0003B04C
			// (set) Token: 0x06000F3A RID: 3898 RVA: 0x000092F1 File Offset: 0x000074F1
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0003CE74 File Offset: 0x0003B074
			// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0000930C File Offset: 0x0000750C
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BF5 RID: 3061
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BF6 RID: 3062
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BF7 RID: 3063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BF8 RID: 3064
			private static readonly IntPtr NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x0200008C RID: 140
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06000F3D RID: 3901 RVA: 0x0003CE9C File Offset: 0x0003B09C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100663896);
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100663897);
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x0003CF18 File Offset: 0x0003B118
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x0003CF54 File Offset: 0x0003B154
			[CallerCount(0)]
			public unsafe bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F40 RID: 3904 RVA: 0x00009327 File Offset: 0x00007527
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0003CFA4 File Offset: 0x0003B1A4
			// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00009330 File Offset: 0x00007530
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0003CFCC File Offset: 0x0003B1CC
			// (set) Token: 0x06000F44 RID: 3908 RVA: 0x0000934B File Offset: 0x0000754B
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BF9 RID: 3065
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BFA RID: 3066
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BFB RID: 3067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BFC RID: 3068
			private static readonly IntPtr NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x0200008D RID: 141
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000F45 RID: 3909 RVA: 0x0003CFF4 File Offset: 0x0003B1F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "left");
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "right");
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100663898);
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100663899);
			}

			// Token: 0x06000F46 RID: 3910 RVA: 0x0003D070 File Offset: 0x0003B270
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F47 RID: 3911 RVA: 0x0003D0AC File Offset: 0x0003B2AC
			[CallerCount(0)]
			public unsafe bool _RemoveKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F48 RID: 3912 RVA: 0x00009366 File Offset: 0x00007566
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0003D0FC File Offset: 0x0003B2FC
			// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0000936F File Offset: 0x0000756F
			public unsafe int left
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left)) = value;
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0003D124 File Offset: 0x0003B324
			// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0000938A File Offset: 0x0000758A
			public unsafe int right
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right)) = value;
				}
			}

			// Token: 0x04000BFD RID: 3069
			private static readonly IntPtr NativeFieldInfoPtr_left;

			// Token: 0x04000BFE RID: 3070
			private static readonly IntPtr NativeFieldInfoPtr_right;

			// Token: 0x04000BFF RID: 3071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C00 RID: 3072
			private static readonly IntPtr NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}
	}
}

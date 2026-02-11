using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class TMP_FontFeatureTable : Object
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0001D750 File Offset: 0x0001B950
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontFeatureTable()
		{
			Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontFeatureTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr);
			TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecords");
			TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecordLookupDictionary");
			TMP_FontFeatureTable.NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663940);
			TMP_FontFeatureTable.NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663941);
			TMP_FontFeatureTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663942);
			TMP_FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663943);
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0001D838 File Offset: 0x0001BA38
		public unsafe List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_GlyphPairAdjustmentRecord>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001D87C File Offset: 0x0001BA7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1041516, RefRangeEnd = 1041520, XrefRangeStart = 1041501, XrefRangeEnd = 1041516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontFeatureTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1041559, RefRangeEnd = 1041561, XrefRangeStart = 1041520, XrefRangeEnd = 1041559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphPairAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004EE6 File Offset: 0x000030E6
		public TMP_FontFeatureTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001D8EC File Offset: 0x0001BAEC
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00004EEF File Offset: 0x000030EF
		public unsafe List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001D91C File Offset: 0x0001BB1C
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00004F0E File Offset: 0x0000310E
		public unsafe Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0;

		// Token: 0x0200008E RID: 142
		[ObfuscatedName("TMPro.TMP_FontFeatureTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F4D RID: 3917 RVA: 0x0003D14C File Offset: 0x0003B34C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr);
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9");
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9__6_0");
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9__6_1");
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663945);
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663946);
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663947);
			}

			// Token: 0x06000F4E RID: 3918 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F4F RID: 3919 RVA: 0x0003D22C File Offset: 0x0003B42C
			[CallerCount(0)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F50 RID: 3920 RVA: 0x0003D27C File Offset: 0x0003B47C
			[CallerCount(0)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F51 RID: 3921 RVA: 0x000093A5 File Offset: 0x000075A5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0003D2CC File Offset: 0x0003B4CC
			// (set) Token: 0x06000F53 RID: 3923 RVA: 0x000093AE File Offset: 0x000075AE
			public unsafe static TMP_FontFeatureTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0003D2F4 File Offset: 0x0003B4F4
			// (set) Token: 0x06000F55 RID: 3925 RVA: 0x000093C0 File Offset: 0x000075C0
			public unsafe static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0003D31C File Offset: 0x0003B51C
			// (set) Token: 0x06000F57 RID: 3927 RVA: 0x000093D2 File Offset: 0x000075D2
			public unsafe static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C01 RID: 3073
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C02 RID: 3074
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000C03 RID: 3075
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04000C04 RID: 3076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C05 RID: 3077
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0;

			// Token: 0x04000C06 RID: 3078
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0;
		}
	}
}

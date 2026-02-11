using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class FontFeatureTable : Object
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0000AA94 File Offset: 0x00008C94
		// Note: this type is marked as 'beforefieldinit'.
		static FontFeatureTable()
		{
			Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontFeatureTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr);
			FontFeatureTable.NativeFieldInfoPtr_m_MultipleSubstitutionRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_MultipleSubstitutionRecords");
			FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_LigatureSubstitutionRecords");
			FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecords");
			FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_MarkToBaseAdjustmentRecords");
			FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_MarkToMarkAdjustmentRecords");
			FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_LigatureSubstitutionRecordLookup");
			FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecordLookup");
			FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_MarkToBaseAdjustmentRecordLookup");
			FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "m_MarkToMarkAdjustmentRecordLookup");
			FontFeatureTable.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, 100663431);
			FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, 100663432);
			FontFeatureTable.NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, 100663433);
			FontFeatureTable.NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, 100663434);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1099963, RefRangeEnd = 1099966, XrefRangeStart = 1099906, XrefRangeEnd = 1099963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontFeatureTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000AC04 File Offset: 0x00008E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100005, RefRangeEnd = 1100007, XrefRangeStart = 1099966, XrefRangeEnd = 1100005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphPairAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000AC38 File Offset: 0x00008E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100046, RefRangeEnd = 1100048, XrefRangeStart = 1100007, XrefRangeEnd = 1100046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortMarkToBaseAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000AC6C File Offset: 0x00008E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100087, RefRangeEnd = 1100089, XrefRangeStart = 1100048, XrefRangeEnd = 1100087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortMarkToMarkAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000028FB File Offset: 0x00000AFB
		public FontFeatureTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002904 File Offset: 0x00000B04
		public unsafe List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MultipleSubstitutionRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MultipleSubstitutionRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MultipleSubstitutionRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002923 File Offset: 0x00000B23
		public unsafe List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LigatureSubstitutionRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000AD00 File Offset: 0x00008F00
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002942 File Offset: 0x00000B42
		public unsafe List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000AD30 File Offset: 0x00008F30
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002961 File Offset: 0x00000B61
		public unsafe List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000AD60 File Offset: 0x00008F60
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002980 File Offset: 0x00000B80
		public unsafe List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000AD90 File Offset: 0x00008F90
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000299F File Offset: 0x00000B9F
		public unsafe Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, List<LigatureSubstitutionRecord>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000029BE File Offset: 0x00000BBE
		public unsafe Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000029DD File Offset: 0x00000BDD
		public unsafe Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, MarkToBaseAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000AE20 File Offset: 0x00009020
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000029FC File Offset: 0x00000BFC
		public unsafe Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, MarkToMarkAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontFeatureTable.NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000AE50 File Offset: 0x00009050
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002A1B File Offset: 0x00000C1B
		public List<MultipleSubstitutionRecord> multipleSubstitutionRecords
		{
			get
			{
				return this.m_MultipleSubstitutionRecords;
			}
			set
			{
				this.m_MultipleSubstitutionRecords = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000AE68 File Offset: 0x00009068
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002A25 File Offset: 0x00000C25
		public List<LigatureSubstitutionRecord> ligatureRecords
		{
			get
			{
				return this.m_LigatureSubstitutionRecords;
			}
			set
			{
				this.m_LigatureSubstitutionRecords = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000AE80 File Offset: 0x00009080
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002A2F File Offset: 0x00000C2F
		public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			get
			{
				return this.m_GlyphPairAdjustmentRecords;
			}
			set
			{
				this.m_GlyphPairAdjustmentRecords = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000AE98 File Offset: 0x00009098
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002A39 File Offset: 0x00000C39
		public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
		{
			get
			{
				return this.m_MarkToBaseAdjustmentRecords;
			}
			set
			{
				this.m_MarkToBaseAdjustmentRecords = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000AEB0 File Offset: 0x000090B0
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002A43 File Offset: 0x00000C43
		public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
		{
			get
			{
				return this.m_MarkToMarkAdjustmentRecords;
			}
			set
			{
				this.m_MarkToMarkAdjustmentRecords = value;
			}
		}

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleSubstitutionRecords;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_m_LigatureSubstitutionRecords;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0;

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("UnityEngine.TextCore.Text.FontFeatureTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000727 RID: 1831 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontFeatureTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr);
				FontFeatureTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__25_0");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__25_1");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__26_0");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__26_1");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__27_0");
				FontFeatureTable.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, "<>9__27_1");
				FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663436);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663437);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663438);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663439);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663440);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663441);
				FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr, 100663442);
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x0001BFEC File Offset: 0x0001A1EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontFeatureTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x0001C028 File Offset: 0x0001A228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099900, XrefRangeEnd = 1099902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__25_0(GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x0001C074 File Offset: 0x0001A274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099902, XrefRangeEnd = 1099904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__25_1(GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099904, XrefRangeEnd = 1099905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortMarkToBaseAdjustmentRecords_b__26_0(MarkToBaseAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x0001C10C File Offset: 0x0001A30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099905, XrefRangeEnd = 1099906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortMarkToBaseAdjustmentRecords_b__26_1(MarkToBaseAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x0001C158 File Offset: 0x0001A358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortMarkToMarkAdjustmentRecords_b__27_0(MarkToMarkAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortMarkToMarkAdjustmentRecords_b__27_1(MarkToMarkAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontFeatureTable.__c.NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x00006329 File Offset: 0x00004529
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000730 RID: 1840 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
			// (set) Token: 0x06000731 RID: 1841 RVA: 0x00006332 File Offset: 0x00004532
			public unsafe static FontFeatureTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontFeatureTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000732 RID: 1842 RVA: 0x0001C218 File Offset: 0x0001A418
			// (set) Token: 0x06000733 RID: 1843 RVA: 0x00006344 File Offset: 0x00004544
			public unsafe static Func<GlyphPairAdjustmentRecord, uint> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000734 RID: 1844 RVA: 0x0001C240 File Offset: 0x0001A440
			// (set) Token: 0x06000735 RID: 1845 RVA: 0x00006356 File Offset: 0x00004556
			public unsafe static Func<GlyphPairAdjustmentRecord, uint> __9__25_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001C268 File Offset: 0x0001A468
			// (set) Token: 0x06000737 RID: 1847 RVA: 0x00006368 File Offset: 0x00004568
			public unsafe static Func<MarkToBaseAdjustmentRecord, uint> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MarkToBaseAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001C290 File Offset: 0x0001A490
			// (set) Token: 0x06000739 RID: 1849 RVA: 0x0000637A File Offset: 0x0000457A
			public unsafe static Func<MarkToBaseAdjustmentRecord, uint> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MarkToBaseAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
			// (set) Token: 0x0600073B RID: 1851 RVA: 0x0000638C File Offset: 0x0000458C
			public unsafe static Func<MarkToMarkAdjustmentRecord, uint> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MarkToMarkAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
			// (set) Token: 0x0600073D RID: 1853 RVA: 0x0000639E File Offset: 0x0000459E
			public unsafe static Func<MarkToMarkAdjustmentRecord, uint> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MarkToMarkAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontFeatureTable.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005DD RID: 1501
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005DE RID: 1502
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040005DF RID: 1503
			private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

			// Token: 0x040005E0 RID: 1504
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x040005E1 RID: 1505
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x040005E2 RID: 1506
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040005E3 RID: 1507
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x040005E4 RID: 1508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005E5 RID: 1509
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0;

			// Token: 0x040005E6 RID: 1510
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0;

			// Token: 0x040005E7 RID: 1511
			private static readonly IntPtr NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0;

			// Token: 0x040005E8 RID: 1512
			private static readonly IntPtr NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0;

			// Token: 0x040005E9 RID: 1513
			private static readonly IntPtr NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0;

			// Token: 0x040005EA RID: 1514
			private static readonly IntPtr NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0;
		}

		// Token: 0x02000048 RID: 72
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class KerningPair : Object
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x0001BD00 File Offset: 0x00019F00
		// Note: this type is marked as 'beforefieldinit'.
		static KerningPair()
		{
			Il2CppClassPointerStore<KerningPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPair>.NativeClassPtr);
			KerningPair.NativeFieldInfoPtr_m_FirstGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyph");
			KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyph");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "xOffset");
			KerningPair.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "empty");
			KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_IgnoreSpacingAdjustments");
			KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663871);
			KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663872);
			KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663873);
			KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663874);
			KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663875);
			KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663876);
			KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663877);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663878);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663879);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663880);
			KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663881);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001BE98 File Offset: 0x0001A098
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0001BED4 File Offset: 0x0001A0D4
		public unsafe uint firstGlyph
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001BF14 File Offset: 0x0001A114
		public unsafe GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001BF50 File Offset: 0x0001A150
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0001BF8C File Offset: 0x0001A18C
		public unsafe uint secondGlyph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001BFCC File Offset: 0x0001A1CC
		public unsafe GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001C008 File Offset: 0x0001A208
		public unsafe bool ignoreSpacingAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001C044 File Offset: 0x0001A244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041088, XrefRangeEnd = 1041089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001C080 File Offset: 0x0001A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041089, XrefRangeEnd = 1041090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair(uint left, uint right, float offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041090, XrefRangeEnd = 1041091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstGlyph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstGlyphAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyph;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyphAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001C158 File Offset: 0x0001A358
		[CallerCount(0)]
		public unsafe void ConvertLegacyKerningData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004D1B File Offset: 0x00002F1B
		public KerningPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001C18C File Offset: 0x0001A38C
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00004D24 File Offset: 0x00002F24
		public unsafe uint m_FirstGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004D3F File Offset: 0x00002F3F
		public unsafe GlyphValueRecord_Legacy m_FirstGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00004D5A File Offset: 0x00002F5A
		public unsafe uint m_SecondGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001C204 File Offset: 0x0001A404
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00004D75 File Offset: 0x00002F75
		public unsafe GlyphValueRecord_Legacy m_SecondGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001C22C File Offset: 0x0001A42C
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00004D90 File Offset: 0x00002F90
		public unsafe float xOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001C254 File Offset: 0x0001A454
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00004DAB File Offset: 0x00002FAB
		public unsafe static KerningPair empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KerningPair.NativeFieldInfoPtr_empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningPair>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KerningPair.NativeFieldInfoPtr_empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001C27C File Offset: 0x0001A47C
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00004DBD File Offset: 0x00002FBD
		public unsafe bool m_IgnoreSpacingAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments)) = value;
			}
		}

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyph;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyphAdjustments;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyph;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyphAdjustments;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_xOffset;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreSpacingAdjustments;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0;
	}
}

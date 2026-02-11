using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphAdjustmentRecord
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphAdjustmentRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr);
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663924);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663925);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663926);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663927);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663928);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663929);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001D170 File Offset: 0x0001B370
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
		public unsafe uint glyphIndex
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0001D204 File Offset: 0x0001B404
		public unsafe TMP_GlyphValueRecord glyphValueRecord
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001D238 File Offset: 0x0001B438
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1038077, RefRangeEnd = 1038087, XrefRangeStart = 1038077, XrefRangeEnd = 1038087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphValueRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0001D278 File Offset: 0x0001B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041477, XrefRangeEnd = 1041483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref adjustmentRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00004E68 File Offset: 0x00003068
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0;

		// Token: 0x04000451 RID: 1105
		[FieldOffset(0)]
		public uint m_GlyphIndex;

		// Token: 0x04000452 RID: 1106
		[FieldOffset(4)]
		public TMP_GlyphValueRecord m_GlyphValueRecord;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	[StructLayout(2)]
	public struct GlyphAdjustmentRecord
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00006F70 File Offset: 0x00005170
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphAdjustmentRecord()
		{
			Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr);
			GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
			GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
			GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663410);
			GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663411);
			GlyphAdjustmentRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663412);
			GlyphAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663413);
			GlyphAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663414);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000702C File Offset: 0x0000522C
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002B18 File Offset: 0x00000D18
		public unsafe uint glyphIndex
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_GlyphIndex = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000705C File Offset: 0x0000525C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002B22 File Offset: 0x00000D22
		public unsafe GlyphValueRecord glyphValueRecord
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 685363, RefRangeEnd = 685371, XrefRangeStart = 685363, XrefRangeEnd = 685371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_GlyphValueRecord = value;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000708C File Offset: 0x0000528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253298, XrefRangeEnd = 1253302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000070BC File Offset: 0x000052BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253302, XrefRangeEnd = 1253306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007100 File Offset: 0x00005300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253306, XrefRangeEnd = 1253312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphAdjustmentRecord other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002B06 File Offset: 0x00000D06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007140 File Offset: 0x00005340
		public static bool operator ==(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs)
		{
			return lhs.m_GlyphIndex == rhs.m_GlyphIndex && lhs.m_GlyphValueRecord == rhs.m_GlyphValueRecord;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007174 File Offset: 0x00005374
		public static bool operator !=(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0;

		// Token: 0x0400013E RID: 318
		[FieldOffset(0)]
		public uint m_GlyphIndex;

		// Token: 0x0400013F RID: 319
		[FieldOffset(4)]
		public GlyphValueRecord m_GlyphValueRecord;
	}
}

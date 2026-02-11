using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	[StructLayout(2)]
	public struct GlyphPairAdjustmentRecord
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00007190 File Offset: 0x00005390
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphPairAdjustmentRecord()
		{
			Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphPairAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr);
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663415);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663416);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663417);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663418);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663419);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663420);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00007274 File Offset: 0x00005474
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B3E File Offset: 0x00000D3E
		public unsafe GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1253312, RefRangeEnd = 1253325, XrefRangeStart = 1253312, XrefRangeEnd = 1253312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FirstAdjustmentRecord = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000072A4 File Offset: 0x000054A4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002B48 File Offset: 0x00000D48
		public unsafe GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1252817, RefRangeEnd = 1252855, XrefRangeStart = 1252817, XrefRangeEnd = 1252855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SecondAdjustmentRecord = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000072D4 File Offset: 0x000054D4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002B52 File Offset: 0x00000D52
		public unsafe FontFeatureLookupFlags featureLookupFlags
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 678450, RefRangeEnd = 678472, XrefRangeStart = 678450, XrefRangeEnd = 678472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FeatureLookupFlags = value;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007304 File Offset: 0x00005504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253325, XrefRangeEnd = 1253329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007334 File Offset: 0x00005534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253329, XrefRangeEnd = 1253333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00007378 File Offset: 0x00005578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253333, XrefRangeEnd = 1253339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphPairAdjustmentRecord other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002B2C File Offset: 0x00000D2C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000073B8 File Offset: 0x000055B8
		public static bool operator ==(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs)
		{
			return lhs.m_FirstAdjustmentRecord == rhs.m_FirstAdjustmentRecord && lhs.m_SecondAdjustmentRecord == rhs.m_SecondAdjustmentRecord;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000073F4 File Offset: 0x000055F4
		public static bool operator !=(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0;

		// Token: 0x04000149 RID: 329
		[FieldOffset(0)]
		public GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		// Token: 0x0400014A RID: 330
		[FieldOffset(20)]
		public GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		// Token: 0x0400014B RID: 331
		[FieldOffset(40)]
		public FontFeatureLookupFlags m_FeatureLookupFlags;
	}
}

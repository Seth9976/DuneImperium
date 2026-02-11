using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	[StructLayout(2)]
	public struct MarkToBaseAdjustmentRecord
	{
		// Token: 0x0600018B RID: 395 RVA: 0x000075D0 File Offset: 0x000057D0
		// Note: this type is marked as 'beforefieldinit'.
		static MarkToBaseAdjustmentRecord()
		{
			Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MarkToBaseAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr);
			MarkToBaseAdjustmentRecord.NativeFieldInfoPtr_m_BaseGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_BaseGlyphID");
			MarkToBaseAdjustmentRecord.NativeFieldInfoPtr_m_BaseGlyphAnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_BaseGlyphAnchorPoint");
			MarkToBaseAdjustmentRecord.NativeFieldInfoPtr_m_MarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_MarkGlyphID");
			MarkToBaseAdjustmentRecord.NativeFieldInfoPtr_m_MarkPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_MarkPositionAdjustment");
			MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663425);
			MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663426);
			MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663427);
			MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663428);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000076A0 File Offset: 0x000058A0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002BBA File Offset: 0x00000DBA
		public unsafe uint baseGlyphID
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BaseGlyphID = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000076D0 File Offset: 0x000058D0
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public unsafe GlyphAnchorPoint baseGlyphAnchorPoint
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1253339, RefRangeEnd = 1253368, XrefRangeStart = 1253339, XrefRangeEnd = 1253339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BaseGlyphAnchorPoint = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00007700 File Offset: 0x00005900
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002BCE File Offset: 0x00000DCE
		public unsafe uint markGlyphID
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_MarkGlyphID = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007730 File Offset: 0x00005930
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public unsafe MarkPositionAdjustment markPositionAdjustment
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1253368, RefRangeEnd = 1253380, XrefRangeStart = 1253368, XrefRangeEnd = 1253368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToBaseAdjustmentRecord.NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_MarkPositionAdjustment = value;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseGlyphID;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseGlyphAnchorPoint;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkGlyphID;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkPositionAdjustment;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0;

		// Token: 0x04000160 RID: 352
		[FieldOffset(0)]
		public uint m_BaseGlyphID;

		// Token: 0x04000161 RID: 353
		[FieldOffset(4)]
		public GlyphAnchorPoint m_BaseGlyphAnchorPoint;

		// Token: 0x04000162 RID: 354
		[FieldOffset(12)]
		public uint m_MarkGlyphID;

		// Token: 0x04000163 RID: 355
		[FieldOffset(16)]
		public MarkPositionAdjustment m_MarkPositionAdjustment;
	}
}

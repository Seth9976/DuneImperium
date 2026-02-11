using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	[StructLayout(2)]
	public struct MarkToMarkAdjustmentRecord
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00007760 File Offset: 0x00005960
		// Note: this type is marked as 'beforefieldinit'.
		static MarkToMarkAdjustmentRecord()
		{
			Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MarkToMarkAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr);
			MarkToMarkAdjustmentRecord.NativeFieldInfoPtr_m_BaseMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphID");
			MarkToMarkAdjustmentRecord.NativeFieldInfoPtr_m_BaseMarkGlyphAnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphAnchorPoint");
			MarkToMarkAdjustmentRecord.NativeFieldInfoPtr_m_CombiningMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkGlyphID");
			MarkToMarkAdjustmentRecord.NativeFieldInfoPtr_m_CombiningMarkPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkPositionAdjustment");
			MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663429);
			MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663430);
			MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663431);
			MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663432);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00007830 File Offset: 0x00005A30
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public unsafe uint baseMarkGlyphID
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BaseMarkGlyphID = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007860 File Offset: 0x00005A60
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002BFE File Offset: 0x00000DFE
		public unsafe GlyphAnchorPoint baseMarkGlyphAnchorPoint
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1253339, RefRangeEnd = 1253368, XrefRangeStart = 1253339, XrefRangeEnd = 1253368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BaseMarkGlyphAnchorPoint = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002C08 File Offset: 0x00000E08
		public unsafe uint combiningMarkGlyphID
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CombiningMarkGlyphID = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000078C0 File Offset: 0x00005AC0
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002C12 File Offset: 0x00000E12
		public unsafe MarkPositionAdjustment combiningMarkPositionAdjustment
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1253368, RefRangeEnd = 1253380, XrefRangeStart = 1253368, XrefRangeEnd = 1253380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkToMarkAdjustmentRecord.NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CombiningMarkPositionAdjustment = value;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002BE2 File Offset: 0x00000DE2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseMarkGlyphID;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseMarkGlyphAnchorPoint;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_CombiningMarkGlyphID;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_CombiningMarkPositionAdjustment;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0;

		// Token: 0x0400016C RID: 364
		[FieldOffset(0)]
		public uint m_BaseMarkGlyphID;

		// Token: 0x0400016D RID: 365
		[FieldOffset(4)]
		public GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

		// Token: 0x0400016E RID: 366
		[FieldOffset(12)]
		public uint m_CombiningMarkGlyphID;

		// Token: 0x0400016F RID: 367
		[FieldOffset(16)]
		public MarkPositionAdjustment m_CombiningMarkPositionAdjustment;
	}
}

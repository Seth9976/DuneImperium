using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	[StructLayout(2)]
	public struct GlyphAnchorPoint
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00007410 File Offset: 0x00005610
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphAnchorPoint()
		{
			Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphAnchorPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr);
			GlyphAnchorPoint.NativeFieldInfoPtr_m_XCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, "m_XCoordinate");
			GlyphAnchorPoint.NativeFieldInfoPtr_m_YCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, "m_YCoordinate");
			GlyphAnchorPoint.NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663421);
			GlyphAnchorPoint.NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663422);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007490 File Offset: 0x00005690
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002B6E File Offset: 0x00000D6E
		public unsafe float xCoordinate
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAnchorPoint.NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XCoordinate = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000074C0 File Offset: 0x000056C0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002B78 File Offset: 0x00000D78
		public unsafe float yCoordinate
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAnchorPoint.NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YCoordinate = value;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002B5C File Offset: 0x00000D5C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_m_XCoordinate;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_m_YCoordinate;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0;

		// Token: 0x04000150 RID: 336
		[FieldOffset(0)]
		public float m_XCoordinate;

		// Token: 0x04000151 RID: 337
		[FieldOffset(4)]
		public float m_YCoordinate;
	}
}

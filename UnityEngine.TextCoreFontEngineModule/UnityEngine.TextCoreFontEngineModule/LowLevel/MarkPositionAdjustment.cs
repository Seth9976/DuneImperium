using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	[StructLayout(2)]
	public struct MarkPositionAdjustment
	{
		// Token: 0x06000185 RID: 389 RVA: 0x000074F0 File Offset: 0x000056F0
		// Note: this type is marked as 'beforefieldinit'.
		static MarkPositionAdjustment()
		{
			Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MarkPositionAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr);
			MarkPositionAdjustment.NativeFieldInfoPtr_m_XPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, "m_XPositionAdjustment");
			MarkPositionAdjustment.NativeFieldInfoPtr_m_YPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, "m_YPositionAdjustment");
			MarkPositionAdjustment.NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663423);
			MarkPositionAdjustment.NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663424);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00007570 File Offset: 0x00005770
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe float xPositionAdjustment
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkPositionAdjustment.NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XPositionAdjustment = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000075A0 File Offset: 0x000057A0
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002B9E File Offset: 0x00000D9E
		public unsafe float yPositionAdjustment
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkPositionAdjustment.NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YPositionAdjustment = value;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002B82 File Offset: 0x00000D82
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, ref this));
		}

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_XPositionAdjustment;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_YPositionAdjustment;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0;

		// Token: 0x04000156 RID: 342
		[FieldOffset(0)]
		public float m_XPositionAdjustment;

		// Token: 0x04000157 RID: 343
		[FieldOffset(4)]
		public float m_YPositionAdjustment;
	}
}

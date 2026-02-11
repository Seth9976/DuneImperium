using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D5 RID: 213
	[StructLayout(2)]
	public struct ShadowSliceData
	{
		// Token: 0x06001081 RID: 4225 RVA: 0x0004E798 File Offset: 0x0004C998
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowSliceData()
		{
			Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowSliceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr);
			ShadowSliceData.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "viewMatrix");
			ShadowSliceData.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "projectionMatrix");
			ShadowSliceData.NativeFieldInfoPtr_shadowTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "shadowTransform");
			ShadowSliceData.NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "offsetX");
			ShadowSliceData.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "offsetY");
			ShadowSliceData.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "resolution");
			ShadowSliceData.NativeFieldInfoPtr_splitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "splitData");
			ShadowSliceData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, 100665391);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0004E868 File Offset: 0x0004CA68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617191, RefRangeEnd = 617193, XrefRangeStart = 617185, XrefRangeEnd = 617191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSliceData.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00009EB4 File Offset: 0x000080B4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_viewMatrix;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_projectionMatrix;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_shadowTransform;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_offsetX;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_offsetY;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_resolution;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr_splitData;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000C10 RID: 3088
		[FieldOffset(0)]
		public Matrix4x4 viewMatrix;

		// Token: 0x04000C11 RID: 3089
		[FieldOffset(64)]
		public Matrix4x4 projectionMatrix;

		// Token: 0x04000C12 RID: 3090
		[FieldOffset(128)]
		public Matrix4x4 shadowTransform;

		// Token: 0x04000C13 RID: 3091
		[FieldOffset(192)]
		public int offsetX;

		// Token: 0x04000C14 RID: 3092
		[FieldOffset(196)]
		public int offsetY;

		// Token: 0x04000C15 RID: 3093
		[FieldOffset(200)]
		public int resolution;

		// Token: 0x04000C16 RID: 3094
		[FieldOffset(204)]
		public ShadowSplitData splitData;
	}
}

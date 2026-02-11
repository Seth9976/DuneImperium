using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000230 RID: 560
	[StructLayout(2)]
	public struct CullingAllocationInfo
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x000A0958 File Offset: 0x0009EB58
		// Note: this type is marked as 'beforefieldinit'.
		static CullingAllocationInfo()
		{
			Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingAllocationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr);
			CullingAllocationInfo.NativeFieldInfoPtr_visibleLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightsPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightsPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbesPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightCount");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightCount");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbeCount");
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0000ED77 File Offset: 0x0000CF77
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeFieldInfoPtr_visibleLightsPtr;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeFieldInfoPtr_visibleReflectionProbesPtr;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeFieldInfoPtr_visibleLightCount;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightCount;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeFieldInfoPtr_visibleReflectionProbeCount;

		// Token: 0x040021A2 RID: 8610
		[FieldOffset(0)]
		public IntPtr visibleLightsPtr;

		// Token: 0x040021A3 RID: 8611
		[FieldOffset(8)]
		public IntPtr visibleOffscreenVertexLightsPtr;

		// Token: 0x040021A4 RID: 8612
		[FieldOffset(16)]
		public IntPtr visibleReflectionProbesPtr;

		// Token: 0x040021A5 RID: 8613
		[FieldOffset(24)]
		public int visibleLightCount;

		// Token: 0x040021A6 RID: 8614
		[FieldOffset(28)]
		public int visibleOffscreenVertexLightCount;

		// Token: 0x040021A7 RID: 8615
		[FieldOffset(32)]
		public int visibleReflectionProbeCount;
	}
}

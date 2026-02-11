using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200006B RID: 107
	[StructLayout(2)]
	public struct BottleneckHistogram
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00029C38 File Offset: 0x00027E38
		// Note: this type is marked as 'beforefieldinit'.
		static BottleneckHistogram()
		{
			Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BottleneckHistogram");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr);
			BottleneckHistogram.NativeFieldInfoPtr_PresentLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "PresentLimited");
			BottleneckHistogram.NativeFieldInfoPtr_CPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "CPU");
			BottleneckHistogram.NativeFieldInfoPtr_GPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "GPU");
			BottleneckHistogram.NativeFieldInfoPtr_Balanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "Balanced");
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00004FC8 File Offset: 0x000031C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, ref this));
		}

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_PresentLimited;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_CPU;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_GPU;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_Balanced;

		// Token: 0x0400058F RID: 1423
		[FieldOffset(0)]
		public float PresentLimited;

		// Token: 0x04000590 RID: 1424
		[FieldOffset(4)]
		public float CPU;

		// Token: 0x04000591 RID: 1425
		[FieldOffset(8)]
		public float GPU;

		// Token: 0x04000592 RID: 1426
		[FieldOffset(12)]
		public float Balanced;
	}
}

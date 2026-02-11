using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200006D RID: 109
	[StructLayout(2)]
	public struct FrameTimeSample
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00029F50 File Offset: 0x00028150
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimeSample()
		{
			Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FrameTimeSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr);
			FrameTimeSample.NativeFieldInfoPtr_FramesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "FramesPerSecond");
			FrameTimeSample.NativeFieldInfoPtr_FullFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "FullFrameTime");
			FrameTimeSample.NativeFieldInfoPtr_MainThreadCPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "MainThreadCPUFrameTime");
			FrameTimeSample.NativeFieldInfoPtr_MainThreadCPUPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "MainThreadCPUPresentWaitTime");
			FrameTimeSample.NativeFieldInfoPtr_RenderThreadCPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "RenderThreadCPUFrameTime");
			FrameTimeSample.NativeFieldInfoPtr_GPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "GPUFrameTime");
			FrameTimeSample.NativeMethodInfoPtr__ctor_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, 100664504);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0002A00C File Offset: 0x0002820C
		[CallerCount(0)]
		public unsafe FrameTimeSample(float initValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSample.NativeMethodInfoPtr__ctor_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0000501D File Offset: 0x0000321D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, ref this));
		}

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_FramesPerSecond;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_FullFrameTime;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_MainThreadCPUFrameTime;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_MainThreadCPUPresentWaitTime;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_RenderThreadCPUFrameTime;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_GPUFrameTime;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_0;

		// Token: 0x040005A2 RID: 1442
		[FieldOffset(0)]
		public float FramesPerSecond;

		// Token: 0x040005A3 RID: 1443
		[FieldOffset(4)]
		public float FullFrameTime;

		// Token: 0x040005A4 RID: 1444
		[FieldOffset(8)]
		public float MainThreadCPUFrameTime;

		// Token: 0x040005A5 RID: 1445
		[FieldOffset(12)]
		public float MainThreadCPUPresentWaitTime;

		// Token: 0x040005A6 RID: 1446
		[FieldOffset(16)]
		public float RenderThreadCPUFrameTime;

		// Token: 0x040005A7 RID: 1447
		[FieldOffset(20)]
		public float GPUFrameTime;
	}
}

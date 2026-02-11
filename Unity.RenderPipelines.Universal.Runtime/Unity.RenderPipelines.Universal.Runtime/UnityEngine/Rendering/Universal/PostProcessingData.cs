using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000101 RID: 257
	[StructLayout(2)]
	public struct PostProcessingData
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x0005C330 File Offset: 0x0005A530
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingData()
		{
			Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr);
			PostProcessingData.NativeFieldInfoPtr_gradingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, "gradingMode");
			PostProcessingData.NativeFieldInfoPtr_lutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, "lutSize");
			PostProcessingData.NativeFieldInfoPtr_useFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, "useFastSRGBLinearConversion");
			PostProcessingData.NativeFieldInfoPtr_supportDataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, "supportDataDrivenLensFlare");
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0000C43C File Offset: 0x0000A63C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr_gradingMode;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeFieldInfoPtr_lutSize;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_useFastSRGBLinearConversion;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_supportDataDrivenLensFlare;

		// Token: 0x04000F41 RID: 3905
		[FieldOffset(0)]
		public ColorGradingMode gradingMode;

		// Token: 0x04000F42 RID: 3906
		[FieldOffset(4)]
		public int lutSize;

		// Token: 0x04000F43 RID: 3907
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool useFastSRGBLinearConversion;

		// Token: 0x04000F44 RID: 3908
		[FieldOffset(9)]
		[MarshalAs(4)]
		public bool supportDataDrivenLensFlare;
	}
}

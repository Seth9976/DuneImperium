using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000004 RID: 4
	[StructLayout(2)]
	public struct VFXCameraXRSettings
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003DE0 File Offset: 0x00001FE0
		// Note: this type is marked as 'beforefieldinit'.
		static VFXCameraXRSettings()
		{
			Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXCameraXRSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr);
			VFXCameraXRSettings.NativeFieldInfoPtr_viewTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewTotal");
			VFXCameraXRSettings.NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewCount");
			VFXCameraXRSettings.NativeFieldInfoPtr_viewOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewOffset");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002458 File Offset: 0x00000658
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_viewTotal;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_viewCount;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_viewOffset;

		// Token: 0x0400003A RID: 58
		[FieldOffset(0)]
		public uint viewTotal;

		// Token: 0x0400003B RID: 59
		[FieldOffset(4)]
		public uint viewCount;

		// Token: 0x0400003C RID: 60
		[FieldOffset(8)]
		public uint viewOffset;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	[StructLayout(2)]
	public struct FrustumPlanes
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x00062178 File Offset: 0x00060378
		// Note: this type is marked as 'beforefieldinit'.
		static FrustumPlanes()
		{
			Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrustumPlanes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr);
			FrustumPlanes.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "left");
			FrustumPlanes.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "right");
			FrustumPlanes.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "bottom");
			FrustumPlanes.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "top");
			FrustumPlanes.NativeFieldInfoPtr_zNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zNear");
			FrustumPlanes.NativeFieldInfoPtr_zFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zFar");
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00008122 File Offset: 0x00006322
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, ref this));
		}

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_zNear;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_zFar;

		// Token: 0x040012AE RID: 4782
		[FieldOffset(0)]
		public float left;

		// Token: 0x040012AF RID: 4783
		[FieldOffset(4)]
		public float right;

		// Token: 0x040012B0 RID: 4784
		[FieldOffset(8)]
		public float bottom;

		// Token: 0x040012B1 RID: 4785
		[FieldOffset(12)]
		public float top;

		// Token: 0x040012B2 RID: 4786
		[FieldOffset(16)]
		public float zNear;

		// Token: 0x040012B3 RID: 4787
		[FieldOffset(20)]
		public float zFar;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000134 RID: 308
	[StructLayout(2)]
	public struct UCircle
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x0006F3BC File Offset: 0x0006D5BC
		// Note: this type is marked as 'beforefieldinit'.
		static UCircle()
		{
			Il2CppClassPointerStore<UCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UCircle>.NativeClassPtr);
			UCircle.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UCircle>.NativeClassPtr, "center");
			UCircle.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UCircle>.NativeClassPtr, "radius");
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0000EFD6 File Offset: 0x0000D1D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UCircle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x0400132B RID: 4907
		[FieldOffset(0)]
		public float2 center;

		// Token: 0x0400132C RID: 4908
		[FieldOffset(8)]
		public float radius;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000135 RID: 309
	[StructLayout(2)]
	public struct UTriangle
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x0006F414 File Offset: 0x0006D614
		// Note: this type is marked as 'beforefieldinit'.
		static UTriangle()
		{
			Il2CppClassPointerStore<UTriangle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UTriangle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTriangle>.NativeClassPtr);
			UTriangle.NativeFieldInfoPtr_va = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "va");
			UTriangle.NativeFieldInfoPtr_vb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "vb");
			UTriangle.NativeFieldInfoPtr_vc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "vc");
			UTriangle.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "c");
			UTriangle.NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "area");
			UTriangle.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, "indices");
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UTriangle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeFieldInfoPtr_va;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeFieldInfoPtr_vb;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeFieldInfoPtr_vc;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_area;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x04001333 RID: 4915
		[FieldOffset(0)]
		public float2 va;

		// Token: 0x04001334 RID: 4916
		[FieldOffset(8)]
		public float2 vb;

		// Token: 0x04001335 RID: 4917
		[FieldOffset(16)]
		public float2 vc;

		// Token: 0x04001336 RID: 4918
		[FieldOffset(24)]
		public UCircle c;

		// Token: 0x04001337 RID: 4919
		[FieldOffset(36)]
		public float area;

		// Token: 0x04001338 RID: 4920
		[FieldOffset(40)]
		public int3 indices;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FD RID: 253
	[StructLayout(2)]
	public struct PreTile
	{
		// Token: 0x06001479 RID: 5241 RVA: 0x0005B740 File Offset: 0x00059940
		// Note: this type is marked as 'beforefieldinit'.
		static PreTile()
		{
			Il2CppClassPointerStore<PreTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PreTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreTile>.NativeClassPtr);
			PreTile.NativeFieldInfoPtr_planeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeLeft");
			PreTile.NativeFieldInfoPtr_planeRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeRight");
			PreTile.NativeFieldInfoPtr_planeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeBottom");
			PreTile.NativeFieldInfoPtr_planeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeTop");
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0000C117 File Offset: 0x0000A317
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreTile>.NativeClassPtr, ref this));
		}

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeFieldInfoPtr_planeLeft;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeFieldInfoPtr_planeRight;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeFieldInfoPtr_planeBottom;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeFieldInfoPtr_planeTop;

		// Token: 0x04000EEC RID: 3820
		[FieldOffset(0)]
		public float4 planeLeft;

		// Token: 0x04000EED RID: 3821
		[FieldOffset(16)]
		public float4 planeRight;

		// Token: 0x04000EEE RID: 3822
		[FieldOffset(32)]
		public float4 planeBottom;

		// Token: 0x04000EEF RID: 3823
		[FieldOffset(48)]
		public float4 planeTop;
	}
}

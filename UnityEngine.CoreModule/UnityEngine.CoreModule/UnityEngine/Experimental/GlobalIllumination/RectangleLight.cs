using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000274 RID: 628
	[StructLayout(2)]
	public struct RectangleLight
	{
		// Token: 0x06002B13 RID: 11027 RVA: 0x000AE920 File Offset: 0x000ACB20
		// Note: this type is marked as 'beforefieldinit'.
		static RectangleLight()
		{
			Il2CppClassPointerStore<RectangleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "RectangleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr);
			RectangleLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "instanceID");
			RectangleLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "shadow");
			RectangleLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "mode");
			RectangleLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "position");
			RectangleLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "orientation");
			RectangleLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "color");
			RectangleLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "indirectColor");
			RectangleLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "range");
			RectangleLight.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "width");
			RectangleLight.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "height");
			RectangleLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00010DAF File Offset: 0x0000EFAF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040025FA RID: 9722
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040025FB RID: 9723
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040025FC RID: 9724
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040025FD RID: 9725
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040025FE RID: 9726
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040025FF RID: 9727
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04002600 RID: 9728
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04002601 RID: 9729
		[FieldOffset(68)]
		public float range;

		// Token: 0x04002602 RID: 9730
		[FieldOffset(72)]
		public float width;

		// Token: 0x04002603 RID: 9731
		[FieldOffset(76)]
		public float height;

		// Token: 0x04002604 RID: 9732
		[FieldOffset(80)]
		public FalloffType falloff;
	}
}

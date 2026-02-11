using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000275 RID: 629
	[StructLayout(2)]
	public struct DiscLight
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x000AEA2C File Offset: 0x000ACC2C
		// Note: this type is marked as 'beforefieldinit'.
		static DiscLight()
		{
			Il2CppClassPointerStore<DiscLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DiscLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscLight>.NativeClassPtr);
			DiscLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "instanceID");
			DiscLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "shadow");
			DiscLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "mode");
			DiscLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "position");
			DiscLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "orientation");
			DiscLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "color");
			DiscLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "indirectColor");
			DiscLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "range");
			DiscLight.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "radius");
			DiscLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00010DC1 File Offset: 0x0000EFC1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x0400260F RID: 9743
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04002610 RID: 9744
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04002611 RID: 9745
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04002612 RID: 9746
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04002613 RID: 9747
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04002614 RID: 9748
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04002615 RID: 9749
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04002616 RID: 9750
		[FieldOffset(68)]
		public float range;

		// Token: 0x04002617 RID: 9751
		[FieldOffset(72)]
		public float radius;

		// Token: 0x04002618 RID: 9752
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}

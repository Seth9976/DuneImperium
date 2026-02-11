using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000271 RID: 625
	[StructLayout(2)]
	public struct DirectionalLight
	{
		// Token: 0x06002B0D RID: 11021 RVA: 0x000AE610 File Offset: 0x000AC810
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionalLight()
		{
			Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DirectionalLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
			DirectionalLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "instanceID");
			DirectionalLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "shadow");
			DirectionalLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "mode");
			DirectionalLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "position");
			DirectionalLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "orientation");
			DirectionalLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "color");
			DirectionalLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "indirectColor");
			DirectionalLight.NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "penumbraWidthRadian");
			DirectionalLight.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "direction");
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00010D79 File Offset: 0x0000EF79
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeFieldInfoPtr_penumbraWidthRadian;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x040025B8 RID: 9656
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040025B9 RID: 9657
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040025BA RID: 9658
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040025BB RID: 9659
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040025BC RID: 9660
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040025BD RID: 9661
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040025BE RID: 9662
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040025BF RID: 9663
		[FieldOffset(68)]
		public float penumbraWidthRadian;

		// Token: 0x040025C0 RID: 9664
		[FieldOffset(72)]
		public Vector3 direction;
	}
}

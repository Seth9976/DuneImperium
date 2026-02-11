using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000247 RID: 583
	[StructLayout(2)]
	public struct Transform3x4
	{
		// Token: 0x06002B03 RID: 11011 RVA: 0x000BAC30 File Offset: 0x000B8E30
		// Note: this type is marked as 'beforefieldinit'.
		static Transform3x4()
		{
			Il2CppClassPointerStore<Transform3x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Transform3x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform3x4>.NativeClassPtr);
			Transform3x4.NativeFieldInfoPtr_v0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform3x4>.NativeClassPtr, "v0");
			Transform3x4.NativeFieldInfoPtr_v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform3x4>.NativeClassPtr, "v1");
			Transform3x4.NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform3x4>.NativeClassPtr, "v2");
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00011502 File Offset: 0x0000F702
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Transform3x4>.NativeClassPtr, ref this));
		}

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeFieldInfoPtr_v0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_v1;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_v2;

		// Token: 0x04001EA4 RID: 7844
		[FieldOffset(0)]
		public Vector4 v0;

		// Token: 0x04001EA5 RID: 7845
		[FieldOffset(16)]
		public Vector4 v1;

		// Token: 0x04001EA6 RID: 7846
		[FieldOffset(32)]
		public Vector4 v2;
	}
}

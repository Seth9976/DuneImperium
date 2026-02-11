using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021A RID: 538
	[Serializable]
	[StructLayout(2)]
	public struct VectorImageVertex
	{
		// Token: 0x060028F6 RID: 10486 RVA: 0x000B3954 File Offset: 0x000B1B54
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImageVertex()
		{
			Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VectorImageVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr);
			VectorImageVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "position");
			VectorImageVertex.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "tint");
			VectorImageVertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "uv");
			VectorImageVertex.NativeFieldInfoPtr_settingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "settingIndex");
			VectorImageVertex.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "flags");
			VectorImageVertex.NativeFieldInfoPtr_circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "circle");
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0001084E File Offset: 0x0000EA4E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_settingIndex;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeFieldInfoPtr_circle;

		// Token: 0x04001CFB RID: 7419
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x04001CFC RID: 7420
		[FieldOffset(12)]
		public Color32 tint;

		// Token: 0x04001CFD RID: 7421
		[FieldOffset(16)]
		public Vector2 uv;

		// Token: 0x04001CFE RID: 7422
		[FieldOffset(24)]
		public uint settingIndex;

		// Token: 0x04001CFF RID: 7423
		[FieldOffset(28)]
		public Color32 flags;

		// Token: 0x04001D00 RID: 7424
		[FieldOffset(32)]
		public Vector4 circle;
	}
}

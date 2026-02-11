using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016B RID: 363
	[StructLayout(2)]
	public struct Vertex
	{
		// Token: 0x06001AE3 RID: 6883 RVA: 0x0007C060 File Offset: 0x0007A260
		// Note: this type is marked as 'beforefieldinit'.
		static Vertex()
		{
			Il2CppClassPointerStore<Vertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vertex>.NativeClassPtr);
			Vertex.NativeFieldInfoPtr_nearZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "nearZ");
			Vertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "position");
			Vertex.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "tint");
			Vertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "uv");
			Vertex.NativeFieldInfoPtr_xformClipPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "xformClipPages");
			Vertex.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "ids");
			Vertex.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "flags");
			Vertex.NativeFieldInfoPtr_opacityColorPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "opacityColorPages");
			Vertex.NativeFieldInfoPtr_settingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "settingIndex");
			Vertex.NativeFieldInfoPtr_circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "circle");
			Vertex.NativeFieldInfoPtr_textureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "textureId");
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0000C379 File Offset: 0x0000A579
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vertex>.NativeClassPtr, ref this));
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0007C16C File Offset: 0x0007A36C
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0000C38B File Offset: 0x0000A58B
		public unsafe static float nearZ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vertex.NativeFieldInfoPtr_nearZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vertex.NativeFieldInfoPtr_nearZ, (void*)(&value));
			}
		}

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_nearZ;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_xformClipPages;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr_ids;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeFieldInfoPtr_opacityColorPages;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr_settingIndex;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr_circle;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr_textureId;

		// Token: 0x040012A2 RID: 4770
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x040012A3 RID: 4771
		[FieldOffset(12)]
		public Color32 tint;

		// Token: 0x040012A4 RID: 4772
		[FieldOffset(16)]
		public Vector2 uv;

		// Token: 0x040012A5 RID: 4773
		[FieldOffset(24)]
		public Color32 xformClipPages;

		// Token: 0x040012A6 RID: 4774
		[FieldOffset(28)]
		public Color32 ids;

		// Token: 0x040012A7 RID: 4775
		[FieldOffset(32)]
		public Color32 flags;

		// Token: 0x040012A8 RID: 4776
		[FieldOffset(36)]
		public Color32 opacityColorPages;

		// Token: 0x040012A9 RID: 4777
		[FieldOffset(40)]
		public Color32 settingIndex;

		// Token: 0x040012AA RID: 4778
		[FieldOffset(44)]
		public Vector4 circle;

		// Token: 0x040012AB RID: 4779
		[FieldOffset(60)]
		public float textureId;
	}
}

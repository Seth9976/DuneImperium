using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct UIVertex
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00004678 File Offset: 0x00002878
		// Note: this type is marked as 'beforefieldinit'.
		static UIVertex()
		{
			Il2CppClassPointerStore<UIVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UIVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIVertex>.NativeClassPtr);
			UIVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "position");
			UIVertex.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "normal");
			UIVertex.NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "tangent");
			UIVertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "color");
			UIVertex.NativeFieldInfoPtr_uv0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv0");
			UIVertex.NativeFieldInfoPtr_uv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv1");
			UIVertex.NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv2");
			UIVertex.NativeFieldInfoPtr_uv3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv3");
			UIVertex.NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultColor");
			UIVertex.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultTangent");
			UIVertex.NativeFieldInfoPtr_simpleVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "simpleVert");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000024C0 File Offset: 0x000006C0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, ref this));
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000024D2 File Offset: 0x000006D2
		public unsafe static Color32 s_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_s_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000047A0 File Offset: 0x000029A0
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000024E0 File Offset: 0x000006E0
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000047BC File Offset: 0x000029BC
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000024EE File Offset: 0x000006EE
		public unsafe static UIVertex simpleVert
		{
			get
			{
				UIVertex uivertex;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_simpleVert, (void*)(&uivertex));
				return uivertex;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_simpleVert, (void*)(&value));
			}
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_normal;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_tangent;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_uv0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_uv1;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_uv2;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_uv3;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultColor;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_simpleVert;

		// Token: 0x04000084 RID: 132
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x04000085 RID: 133
		[FieldOffset(12)]
		public Vector3 normal;

		// Token: 0x04000086 RID: 134
		[FieldOffset(24)]
		public Vector4 tangent;

		// Token: 0x04000087 RID: 135
		[FieldOffset(40)]
		public Color32 color;

		// Token: 0x04000088 RID: 136
		[FieldOffset(44)]
		public Vector4 uv0;

		// Token: 0x04000089 RID: 137
		[FieldOffset(60)]
		public Vector4 uv1;

		// Token: 0x0400008A RID: 138
		[FieldOffset(76)]
		public Vector4 uv2;

		// Token: 0x0400008B RID: 139
		[FieldOffset(92)]
		public Vector4 uv3;
	}
}

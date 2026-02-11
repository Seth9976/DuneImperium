using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	[StructLayout(2)]
	public struct CombineInstance
	{
		// Token: 0x0600105C RID: 4188 RVA: 0x0005252C File Offset: 0x0005072C
		// Note: this type is marked as 'beforefieldinit'.
		static CombineInstance()
		{
			Il2CppClassPointerStore<CombineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CombineInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr);
			CombineInstance.NativeFieldInfoPtr_m_MeshInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_MeshInstanceID");
			CombineInstance.NativeFieldInfoPtr_m_SubMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_SubMeshIndex");
			CombineInstance.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_Transform");
			CombineInstance.NativeFieldInfoPtr_m_LightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_LightmapScaleOffset");
			CombineInstance.NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_RealtimeLightmapScaleOffset");
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000074A2 File Offset: 0x000056A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, ref this));
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x000525C0 File Offset: 0x000507C0
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x000074B4 File Offset: 0x000056B4
		public Mesh mesh
		{
			get
			{
				return Mesh.FromInstanceID(this.m_MeshInstanceID);
			}
			set
			{
				this.m_MeshInstanceID = ((value != null) ? value.GetInstanceID() : 0);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x000525E0 File Offset: 0x000507E0
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x000074CF File Offset: 0x000056CF
		public int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			set
			{
				this.m_SubMeshIndex = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000525F8 File Offset: 0x000507F8
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x000074D9 File Offset: 0x000056D9
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00052610 File Offset: 0x00050810
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000074E3 File Offset: 0x000056E3
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.m_LightmapScaleOffset;
			}
			set
			{
				this.m_LightmapScaleOffset = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00052628 File Offset: 0x00050828
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x000074ED File Offset: 0x000056ED
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.m_RealtimeLightmapScaleOffset;
			}
			set
			{
				this.m_RealtimeLightmapScaleOffset = value;
			}
		}

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshInstanceID;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_m_SubMeshIndex;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_m_LightmapScaleOffset;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset;

		// Token: 0x04000E83 RID: 3715
		[FieldOffset(0)]
		public int m_MeshInstanceID;

		// Token: 0x04000E84 RID: 3716
		[FieldOffset(4)]
		public int m_SubMeshIndex;

		// Token: 0x04000E85 RID: 3717
		[FieldOffset(8)]
		public Matrix4x4 m_Transform;

		// Token: 0x04000E86 RID: 3718
		[FieldOffset(72)]
		public Vector4 m_LightmapScaleOffset;

		// Token: 0x04000E87 RID: 3719
		[FieldOffset(88)]
		public Vector4 m_RealtimeLightmapScaleOffset;
	}
}

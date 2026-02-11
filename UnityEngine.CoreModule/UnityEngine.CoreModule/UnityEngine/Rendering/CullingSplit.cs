using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000224 RID: 548
	[StructLayout(2)]
	public struct CullingSplit
	{
		// Token: 0x060024A8 RID: 9384 RVA: 0x0009D840 File Offset: 0x0009BA40
		// Note: this type is marked as 'beforefieldinit'.
		static CullingSplit()
		{
			Il2CppClassPointerStore<CullingSplit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingSplit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr);
			CullingSplit.NativeFieldInfoPtr_sphereCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereCenter");
			CullingSplit.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereRadius");
			CullingSplit.NativeFieldInfoPtr_cullingPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneOffset");
			CullingSplit.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneCount");
			CullingSplit.NativeFieldInfoPtr_cascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cascadeBlendCullingFactor");
			CullingSplit.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "nearPlane");
			CullingSplit.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingMatrix");
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0000E640 File Offset: 0x0000C840
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, ref this));
		}

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr_sphereCenter;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneOffset;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneCount;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr_cascadeBlendCullingFactor;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x04002054 RID: 8276
		[FieldOffset(0)]
		public Vector3 sphereCenter;

		// Token: 0x04002055 RID: 8277
		[FieldOffset(12)]
		public float sphereRadius;

		// Token: 0x04002056 RID: 8278
		[FieldOffset(16)]
		public int cullingPlaneOffset;

		// Token: 0x04002057 RID: 8279
		[FieldOffset(20)]
		public int cullingPlaneCount;

		// Token: 0x04002058 RID: 8280
		[FieldOffset(24)]
		public float cascadeBlendCullingFactor;

		// Token: 0x04002059 RID: 8281
		[FieldOffset(28)]
		public float nearPlane;

		// Token: 0x0400205A RID: 8282
		[FieldOffset(32)]
		public Matrix4x4 cullingMatrix;
	}
}

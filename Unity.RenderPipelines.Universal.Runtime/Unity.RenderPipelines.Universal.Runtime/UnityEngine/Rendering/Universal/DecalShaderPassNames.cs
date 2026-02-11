using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000068 RID: 104
	public static class DecalShaderPassNames : Object
	{
		// Token: 0x06000917 RID: 2327 RVA: 0x00034B58 File Offset: 0x00032D58
		// Note: this type is marked as 'beforefieldinit'.
		static DecalShaderPassNames()
		{
			Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalShaderPassNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr);
			DecalShaderPassNames.NativeFieldInfoPtr_DecalPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalPreview");
			DecalShaderPassNames.NativeFieldInfoPtr_DBufferProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DBufferProjector");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalProjectorForwardEmissive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalProjectorForwardEmissive");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalScreenSpaceProjector");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalGBufferProjector");
			DecalShaderPassNames.NativeFieldInfoPtr_DBufferMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DBufferMesh");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalMeshForwardEmissive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalMeshForwardEmissive");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalScreenSpaceMesh");
			DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalShaderPassNames>.NativeClassPtr, "DecalGBufferMesh");
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00005EFE File Offset: 0x000040FE
		public DecalShaderPassNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00034C3C File Offset: 0x00032E3C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00005F07 File Offset: 0x00004107
		public unsafe static string DecalPreview
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalPreview, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalPreview, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00034C5C File Offset: 0x00032E5C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00005F19 File Offset: 0x00004119
		public unsafe static string DBufferProjector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DBufferProjector, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DBufferProjector, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00034C7C File Offset: 0x00032E7C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00005F2B File Offset: 0x0000412B
		public unsafe static string DecalProjectorForwardEmissive
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalProjectorForwardEmissive, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalProjectorForwardEmissive, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00034C9C File Offset: 0x00032E9C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00005F3D File Offset: 0x0000413D
		public unsafe static string DecalScreenSpaceProjector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceProjector, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceProjector, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00034CBC File Offset: 0x00032EBC
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00005F4F File Offset: 0x0000414F
		public unsafe static string DecalGBufferProjector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferProjector, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferProjector, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00034CDC File Offset: 0x00032EDC
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00005F61 File Offset: 0x00004161
		public unsafe static string DBufferMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DBufferMesh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DBufferMesh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00034CFC File Offset: 0x00032EFC
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00005F73 File Offset: 0x00004173
		public unsafe static string DecalMeshForwardEmissive
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalMeshForwardEmissive, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalMeshForwardEmissive, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00034D1C File Offset: 0x00032F1C
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00005F85 File Offset: 0x00004185
		public unsafe static string DecalScreenSpaceMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceMesh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalScreenSpaceMesh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00034D3C File Offset: 0x00032F3C
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00005F97 File Offset: 0x00004197
		public unsafe static string DecalGBufferMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferMesh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalShaderPassNames.NativeFieldInfoPtr_DecalGBufferMesh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_DecalPreview;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_DBufferProjector;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_DecalProjectorForwardEmissive;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_DecalScreenSpaceProjector;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_DecalGBufferProjector;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_DBufferMesh;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_DecalMeshForwardEmissive;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_DecalScreenSpaceMesh;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_DecalGBufferMesh;
	}
}

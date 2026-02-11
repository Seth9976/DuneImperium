using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000009 RID: 9
	public class XROcclusionMesh : Object
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000F948 File Offset: 0x0000DB48
		// Note: this type is marked as 'beforefieldinit'.
		static XROcclusionMesh()
		{
			Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XROcclusionMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr);
			XROcclusionMesh.NativeFieldInfoPtr_m_Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, "m_Pass");
			XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, "m_CombinedMesh");
			XROcclusionMesh.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, "m_Material");
			XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMeshHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, "m_CombinedMeshHashCode");
			XROcclusionMesh.NativeFieldInfoPtr_k_OcclusionMeshProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, "k_OcclusionMeshProfilingSampler");
			XROcclusionMesh.NativeMethodInfoPtr__ctor_Internal_Void_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663337);
			XROcclusionMesh.NativeMethodInfoPtr_SetMaterial_Internal_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663338);
			XROcclusionMesh.NativeMethodInfoPtr_get_hasValidOcclusionMesh_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663339);
			XROcclusionMesh.NativeMethodInfoPtr_RenderOcclusionMesh_Internal_Void_CommandBuffer_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663340);
			XROcclusionMesh.NativeMethodInfoPtr_UpdateCombinedMesh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663341);
			XROcclusionMesh.NativeMethodInfoPtr_IsOcclusionMeshSupported_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663342);
			XROcclusionMesh.NativeMethodInfoPtr_TryGetOcclusionMeshCombinedHashCode_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663343);
			XROcclusionMesh.NativeMethodInfoPtr_CreateOcclusionMeshCombined_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XROcclusionMesh(XRPass xrPass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XROcclusionMesh>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr__ctor_Internal_Void_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_SetMaterial_Internal_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		public unsafe bool hasValidOcclusionMesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953591, XrefRangeEnd = 953593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_get_hasValidOcclusionMesh_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000FB48 File Offset: 0x0000DD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953649, RefRangeEnd = 953650, XrefRangeStart = 953593, XrefRangeEnd = 953649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref occlusionMeshScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yFlip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_RenderOcclusionMesh_Internal_Void_CommandBuffer_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 953668, RefRangeEnd = 953671, XrefRangeStart = 953650, XrefRangeEnd = 953668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCombinedMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_UpdateCombinedMesh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 953673, RefRangeEnd = 953677, XrefRangeStart = 953671, XrefRangeEnd = 953673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOcclusionMeshSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_IsOcclusionMeshSupported_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953677, XrefRangeEnd = 953686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetOcclusionMeshCombinedHashCode(out int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_TryGetOcclusionMeshCombinedHashCode_Private_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953723, RefRangeEnd = 953724, XrefRangeStart = 953686, XrefRangeEnd = 953723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOcclusionMeshCombined()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XROcclusionMesh.NativeMethodInfoPtr_CreateOcclusionMeshCombined_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000023DB File Offset: 0x000005DB
		public XROcclusionMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000FC98 File Offset: 0x0000DE98
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000023E4 File Offset: 0x000005E4
		public unsafe XRPass m_Pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_Pass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_Pass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002403 File Offset: 0x00000603
		public unsafe Mesh m_CombinedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002422 File Offset: 0x00000622
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000FD28 File Offset: 0x0000DF28
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002441 File Offset: 0x00000641
		public unsafe int m_CombinedMeshHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMeshHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XROcclusionMesh.NativeFieldInfoPtr_m_CombinedMeshHashCode)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000245C File Offset: 0x0000065C
		public unsafe static ProfilingSampler k_OcclusionMeshProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XROcclusionMesh.NativeFieldInfoPtr_k_OcclusionMeshProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XROcclusionMesh.NativeFieldInfoPtr_k_OcclusionMeshProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_m_Pass;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinedMesh;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinedMeshHashCode;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_k_OcclusionMeshProfilingSampler;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XRPass_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Internal_Void_Material_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_hasValidOcclusionMesh_Internal_get_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_RenderOcclusionMesh_Internal_Void_CommandBuffer_Single_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCombinedMesh_Internal_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_IsOcclusionMeshSupported_Private_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOcclusionMeshCombinedHashCode_Private_Boolean_byref_Int32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_CreateOcclusionMeshCombined_Private_Void_0;
	}
}

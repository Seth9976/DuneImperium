using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public sealed class ParticleSystemRenderer : Renderer
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00005F44 File Offset: 0x00004144
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleSystemRenderer()
		{
			Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystemRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr);
			ParticleSystemRenderer.NativeMethodInfoPtr_EnableVertexStreams_Public_Void_ParticleSystemVertexStreams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663557);
			ParticleSystemRenderer.NativeMethodInfoPtr_DisableVertexStreams_Public_Void_ParticleSystemVertexStreams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663558);
			ParticleSystemRenderer.NativeMethodInfoPtr_AreVertexStreamsEnabled_Public_Boolean_ParticleSystemVertexStreams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663559);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetEnabledVertexStreams_Public_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663560);
			ParticleSystemRenderer.NativeMethodInfoPtr_Internal_SetVertexStreams_Internal_Void_ParticleSystemVertexStreams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663561);
			ParticleSystemRenderer.NativeMethodInfoPtr_Internal_GetEnabledVertexStreams_Internal_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663562);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663563);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663564);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663565);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663566);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_alignment_Public_get_ParticleSystemRenderSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663567);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_ParticleSystemRenderSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663568);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_renderMode_Public_get_ParticleSystemRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663569);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_renderMode_Public_set_Void_ParticleSystemRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663570);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_meshDistribution_Public_get_ParticleSystemMeshDistribution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663571);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_meshDistribution_Public_set_Void_ParticleSystemMeshDistribution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663572);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_sortMode_Public_get_ParticleSystemSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663573);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_sortMode_Public_set_Void_ParticleSystemSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663574);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_lengthScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663575);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_lengthScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663576);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_velocityScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663577);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_velocityScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663578);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_cameraVelocityScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663579);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_cameraVelocityScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663580);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_normalDirection_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663581);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_normalDirection_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663582);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663583);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663584);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_sortingFudge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663585);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_sortingFudge_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663586);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_minParticleSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663587);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_minParticleSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663588);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_maxParticleSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663589);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_maxParticleSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663590);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663591);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663592);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_flip_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663593);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_flip_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663594);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663595);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663596);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_trailMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663597);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_trailMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663598);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_oldTrailMaterial_Internal_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663599);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_enableGPUInstancing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663600);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_enableGPUInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663601);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_allowRoll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663602);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_allowRoll_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663603);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_freeformStretching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663604);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_freeformStretching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663605);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_rotateWithStretchDirection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663606);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_rotateWithStretchDirection_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663607);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663608);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663609);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663610);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663611);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663612);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshWeightings_Public_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663613);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663614);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663615);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_meshCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663616);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663617);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663618);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663619);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663620);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663621);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663622);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureNoIndicesInternal_Private_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663623);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663624);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663625);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663626);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663627);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663628);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663629);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_activeVertexStreamsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663630);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663631);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663632);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_activeTrailVertexStreamsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663633);
			ParticleSystemRenderer.NativeMethodInfoPtr_SetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663634);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663635);
			ParticleSystemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663636);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663637);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663638);
			ParticleSystemRenderer.NativeMethodInfoPtr_get_flip_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663639);
			ParticleSystemRenderer.NativeMethodInfoPtr_set_flip_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663640);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663641);
			ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663642);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000662C File Offset: 0x0000482C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221475, XrefRangeEnd = 1221476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableVertexStreams(ParticleSystemVertexStreams streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_EnableVertexStreams_Public_Void_ParticleSystemVertexStreams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000666C File Offset: 0x0000486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221476, XrefRangeEnd = 1221477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableVertexStreams(ParticleSystemVertexStreams streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_DisableVertexStreams_Public_Void_ParticleSystemVertexStreams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000066AC File Offset: 0x000048AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221477, XrefRangeEnd = 1221478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_AreVertexStreamsEnabled_Public_Boolean_ParticleSystemVertexStreams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000066F8 File Offset: 0x000048F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221478, XrefRangeEnd = 1221479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetEnabledVertexStreams_Public_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006744 File Offset: 0x00004944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221600, RefRangeEnd = 1221602, XrefRangeStart = 1221479, XrefRangeEnd = 1221600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_Internal_SetVertexStreams_Internal_Void_ParticleSystemVertexStreams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006790 File Offset: 0x00004990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221641, RefRangeEnd = 1221643, XrefRangeStart = 1221602, XrefRangeEnd = 1221641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref streams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_Internal_GetEnabledVertexStreams_Internal_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000067DC File Offset: 0x000049DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221643, XrefRangeEnd = 1221647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh, bool useTransform = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000682C File Offset: 0x00004A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221647, XrefRangeEnd = 1221650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006890 File Offset: 0x00004A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221650, XrefRangeEnd = 1221654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTrailsMesh(Mesh mesh, bool useTransform = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000068E0 File Offset: 0x00004AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221654, XrefRangeEnd = 1221657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00006980 File Offset: 0x00004B80
		public unsafe ParticleSystemRenderSpace alignment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221657, XrefRangeEnd = 1221659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_alignment_Public_get_ParticleSystemRenderSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221659, XrefRangeEnd = 1221661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_ParticleSystemRenderSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000069FC File Offset: 0x00004BFC
		public unsafe ParticleSystemRenderMode renderMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221661, XrefRangeEnd = 1221663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_renderMode_Public_get_ParticleSystemRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221663, XrefRangeEnd = 1221665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_renderMode_Public_set_Void_ParticleSystemRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00006A3C File Offset: 0x00004C3C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00006A78 File Offset: 0x00004C78
		public unsafe ParticleSystemMeshDistribution meshDistribution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221665, XrefRangeEnd = 1221667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_meshDistribution_Public_get_ParticleSystemMeshDistribution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221667, XrefRangeEnd = 1221669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_meshDistribution_Public_set_Void_ParticleSystemMeshDistribution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00006AB8 File Offset: 0x00004CB8
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public unsafe ParticleSystemSortMode sortMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221669, XrefRangeEnd = 1221671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_sortMode_Public_get_ParticleSystemSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221671, XrefRangeEnd = 1221673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_sortMode_Public_set_Void_ParticleSystemSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00006B34 File Offset: 0x00004D34
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe float lengthScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221673, XrefRangeEnd = 1221675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_lengthScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221675, XrefRangeEnd = 1221677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_lengthScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00006BB0 File Offset: 0x00004DB0
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00006BEC File Offset: 0x00004DEC
		public unsafe float velocityScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221677, XrefRangeEnd = 1221679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_velocityScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221679, XrefRangeEnd = 1221681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_velocityScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00006C2C File Offset: 0x00004E2C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00006C68 File Offset: 0x00004E68
		public unsafe float cameraVelocityScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221681, XrefRangeEnd = 1221683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_cameraVelocityScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221683, XrefRangeEnd = 1221685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_cameraVelocityScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public unsafe float normalDirection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221685, XrefRangeEnd = 1221687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_normalDirection_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221687, XrefRangeEnd = 1221689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_normalDirection_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00006D24 File Offset: 0x00004F24
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00006D60 File Offset: 0x00004F60
		public unsafe float shadowBias
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221689, XrefRangeEnd = 1221691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221691, XrefRangeEnd = 1221693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00006DA0 File Offset: 0x00004FA0
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00006DDC File Offset: 0x00004FDC
		public unsafe float sortingFudge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221693, XrefRangeEnd = 1221695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_sortingFudge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221695, XrefRangeEnd = 1221697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_sortingFudge_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00006E58 File Offset: 0x00005058
		public unsafe float minParticleSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221697, XrefRangeEnd = 1221699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_minParticleSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221699, XrefRangeEnd = 1221701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_minParticleSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00006E98 File Offset: 0x00005098
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00006ED4 File Offset: 0x000050D4
		public unsafe float maxParticleSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221701, XrefRangeEnd = 1221703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_maxParticleSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221703, XrefRangeEnd = 1221705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_maxParticleSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00006F50 File Offset: 0x00005150
		public unsafe Vector3 pivot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221705, XrefRangeEnd = 1221707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221707, XrefRangeEnd = 1221709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00006FCC File Offset: 0x000051CC
		public unsafe Vector3 flip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221709, XrefRangeEnd = 1221711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_flip_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221711, XrefRangeEnd = 1221713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_flip_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000700C File Offset: 0x0000520C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00007048 File Offset: 0x00005248
		public unsafe SpriteMaskInteraction maskInteraction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221713, XrefRangeEnd = 1221715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221715, XrefRangeEnd = 1221717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00007088 File Offset: 0x00005288
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000070C8 File Offset: 0x000052C8
		public unsafe Material trailMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221717, XrefRangeEnd = 1221719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_trailMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221719, XrefRangeEnd = 1221721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_trailMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000710C File Offset: 0x0000530C
		public unsafe Material oldTrailMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221721, XrefRangeEnd = 1221723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_oldTrailMaterial_Internal_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00007150 File Offset: 0x00005350
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000718C File Offset: 0x0000538C
		public unsafe bool enableGPUInstancing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221723, XrefRangeEnd = 1221725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_enableGPUInstancing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221725, XrefRangeEnd = 1221727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_enableGPUInstancing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000071CC File Offset: 0x000053CC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00007208 File Offset: 0x00005408
		public unsafe bool allowRoll
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221727, XrefRangeEnd = 1221729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_allowRoll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221729, XrefRangeEnd = 1221731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_allowRoll_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00007248 File Offset: 0x00005448
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00007284 File Offset: 0x00005484
		public unsafe bool freeformStretching
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221731, XrefRangeEnd = 1221733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_freeformStretching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221733, XrefRangeEnd = 1221735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_freeformStretching_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00007300 File Offset: 0x00005500
		public unsafe bool rotateWithStretchDirection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221735, XrefRangeEnd = 1221737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_rotateWithStretchDirection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221737, XrefRangeEnd = 1221739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_rotateWithStretchDirection_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00007340 File Offset: 0x00005540
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00007380 File Offset: 0x00005580
		public unsafe Mesh mesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221739, XrefRangeEnd = 1221741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221741, XrefRangeEnd = 1221743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000073C4 File Offset: 0x000055C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221743, XrefRangeEnd = 1221745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMeshes([Out] Il2CppReferenceArray<Mesh> meshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*meshes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Mesh>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00007424 File Offset: 0x00005624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221745, XrefRangeEnd = 1221747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshes(Il2CppReferenceArray<Mesh> meshes, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007474 File Offset: 0x00005674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221747, XrefRangeEnd = 1221750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshes(Il2CppReferenceArray<Mesh> meshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000074B8 File Offset: 0x000056B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221750, XrefRangeEnd = 1221752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMeshWeightings([Out] Il2CppStructArray<float> weightings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshWeightings_Public_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*weightings = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007518 File Offset: 0x00005718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221752, XrefRangeEnd = 1221754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshWeightings(Il2CppStructArray<float> weightings, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(weightings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007568 File Offset: 0x00005768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221754, XrefRangeEnd = 1221757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshWeightings(Il2CppStructArray<float> weightings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(weightings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000075AC File Offset: 0x000057AC
		public unsafe int meshCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221757, XrefRangeEnd = 1221759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_meshCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000075E8 File Offset: 0x000057E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221759, XrefRangeEnd = 1221762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007638 File Offset: 0x00005838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221762, XrefRangeEnd = 1221764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000769C File Offset: 0x0000589C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221764, XrefRangeEnd = 1221767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000076EC File Offset: 0x000058EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221767, XrefRangeEnd = 1221769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007750 File Offset: 0x00005950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221769, XrefRangeEnd = 1221775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			verticesTexture = ((intPtr4 == 0) ? null : new Texture2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000077C4 File Offset: 0x000059C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221775, XrefRangeEnd = 1221780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			verticesTexture = ((intPtr4 == 0) ? null : new Texture2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007848 File Offset: 0x00005A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221780, XrefRangeEnd = 1221782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureNoIndicesInternal_Private_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000078C8 File Offset: 0x00005AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221782, XrefRangeEnd = 1221787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			verticesTexture = ((intPtr5 == 0) ? null : new Texture2D(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indicesTexture = ((intPtr6 == 0) ? null : new Texture2D(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007964 File Offset: 0x00005B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221787, XrefRangeEnd = 1221791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			verticesTexture = ((intPtr5 == 0) ? null : new Texture2D(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indicesTexture = ((intPtr6 == 0) ? null : new Texture2D(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007A14 File Offset: 0x00005C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221791, XrefRangeEnd = 1221793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ParticleSystemRenderer.BakeTextureOutput(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221793, XrefRangeEnd = 1221798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			verticesTexture = ((intPtr5 == 0) ? null : new Texture2D(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indicesTexture = ((intPtr6 == 0) ? null : new Texture2D(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007B3C File Offset: 0x00005D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221798, XrefRangeEnd = 1221802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			verticesTexture = ((intPtr5 == 0) ? null : new Texture2D(intPtr5));
			IntPtr intPtr6 = intPtr2;
			indicesTexture = ((intPtr6 == 0) ? null : new Texture2D(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007BEC File Offset: 0x00005DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221802, XrefRangeEnd = 1221804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ParticleSystemRenderer.BakeTextureOutput(intPtr);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00007C78 File Offset: 0x00005E78
		public unsafe int activeVertexStreamsCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221804, XrefRangeEnd = 1221806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_activeVertexStreamsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007CB4 File Offset: 0x00005EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221806, XrefRangeEnd = 1221808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221808, XrefRangeEnd = 1221810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007D3C File Offset: 0x00005F3C
		public unsafe int activeTrailVertexStreamsCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221810, XrefRangeEnd = 1221812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_activeTrailVertexStreamsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007D78 File Offset: 0x00005F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221812, XrefRangeEnd = 1221814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_SetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007DBC File Offset: 0x00005FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221814, XrefRangeEnd = 1221816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007E00 File Offset: 0x00006000
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystemRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007E3C File Offset: 0x0000603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221816, XrefRangeEnd = 1221818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007E7C File Offset: 0x0000607C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221818, XrefRangeEnd = 1221820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pivot_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007EBC File Offset: 0x000060BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221820, XrefRangeEnd = 1221822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_flip_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_get_flip_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007EFC File Offset: 0x000060FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221822, XrefRangeEnd = 1221824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_flip_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_set_flip_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007F3C File Offset: 0x0000613C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221824, XrefRangeEnd = 1221826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ret = ((intPtr4 == 0) ? null : new ParticleSystemRenderer.BakeTextureOutput(intPtr4));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007FE4 File Offset: 0x000061E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221826, XrefRangeEnd = 1221828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeTrailsTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verticesTexture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicesTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_BakeTrailsTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ret = ((intPtr4 == 0) ? null : new ParticleSystemRenderer.BakeTextureOutput(intPtr4));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002059 File Offset: 0x00000259
		public ParticleSystemRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_EnableVertexStreams_Public_Void_ParticleSystemVertexStreams_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_DisableVertexStreams_Public_Void_ParticleSystemVertexStreams_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_AreVertexStreamsEnabled_Public_Boolean_ParticleSystemVertexStreams_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledVertexStreams_Public_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetVertexStreams_Internal_Void_ParticleSystemVertexStreams_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetEnabledVertexStreams_Internal_ParticleSystemVertexStreams_ParticleSystemVertexStreams_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_ParticleSystemRenderSpace_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_ParticleSystemRenderSpace_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_ParticleSystemRenderMode_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_ParticleSystemRenderMode_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_meshDistribution_Public_get_ParticleSystemMeshDistribution_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_set_meshDistribution_Public_set_Void_ParticleSystemMeshDistribution_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_sortMode_Public_get_ParticleSystemSortMode_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_set_sortMode_Public_set_Void_ParticleSystemSortMode_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_lengthScale_Public_get_Single_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_set_lengthScale_Public_set_Void_Single_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_velocityScale_Public_get_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_set_velocityScale_Public_set_Void_Single_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraVelocityScale_Public_get_Single_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_set_cameraVelocityScale_Public_set_Void_Single_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_normalDirection_Public_get_Single_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_set_normalDirection_Public_set_Void_Single_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingFudge_Public_get_Single_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingFudge_Public_set_Void_Single_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_minParticleSize_Public_get_Single_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_set_minParticleSize_Public_set_Void_Single_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_maxParticleSize_Public_get_Single_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_set_maxParticleSize_Public_set_Void_Single_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_flip_Public_get_Vector3_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_set_flip_Public_set_Void_Vector3_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_trailMaterial_Public_get_Material_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_set_trailMaterial_Public_set_Void_Material_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_oldTrailMaterial_Internal_set_Void_Material_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_enableGPUInstancing_Public_get_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_set_enableGPUInstancing_Public_set_Void_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_allowRoll_Public_get_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_set_allowRoll_Public_set_Void_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_get_freeformStretching_Public_get_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_set_freeformStretching_Public_set_Void_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_rotateWithStretchDirection_Public_get_Boolean_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_set_rotateWithStretchDirection_Public_set_Void_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_Int32_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshes_Public_Void_Il2CppReferenceArray_1_Mesh_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshWeightings_Public_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshWeightings_Public_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_meshCount_Public_get_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_ParticleSystemBakeMeshOptions_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsMesh_Public_Void_Mesh_Camera_ParticleSystemBakeMeshOptions_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_ParticleSystemBakeTextureOptions_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_BakeTextureNoIndicesInternal_Private_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_BakeTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_BakeTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_ParticleSystemBakeTextureOptions_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsTexture_Public_Int32_byref_Texture2D_byref_Texture2D_Camera_ParticleSystemBakeTextureOptions_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsTextureInternal_Private_BakeTextureOutput_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_activeVertexStreamsCount_Public_get_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTrailVertexStreamsCount_Public_get_Int32_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveTrailVertexStreams_Public_Void_List_1_ParticleSystemVertexStream_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_flip_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_set_flip_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_BakeTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_BakeTrailsTextureInternal_Injected_Private_Void_Texture2D_Texture2D_Camera_ParticleSystemBakeTextureOptions_byref_Int32_byref_BakeTextureOutput_0;

		// Token: 0x0200005B RID: 91
		public sealed class BakeTextureOutput : ValueType
		{
			// Token: 0x06000258 RID: 600 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
			// Note: this type is marked as 'beforefieldinit'.
			static BakeTextureOutput()
			{
				Il2CppClassPointerStore<ParticleSystemRenderer.BakeTextureOutput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, "BakeTextureOutput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemRenderer.BakeTextureOutput>.NativeClassPtr);
				ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemRenderer.BakeTextureOutput>.NativeClassPtr, "vertices");
				ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemRenderer.BakeTextureOutput>.NativeClassPtr, "indices");
			}

			// Token: 0x06000259 RID: 601 RVA: 0x00002B3C File Offset: 0x00000D3C
			public BakeTextureOutput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00002B45 File Offset: 0x00000D45
			public BakeTextureOutput()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystemRenderer.BakeTextureOutput>.NativeClassPtr))
			{
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600025B RID: 603 RVA: 0x0000C534 File Offset: 0x0000A734
			// (set) Token: 0x0600025C RID: 604 RVA: 0x00002B57 File Offset: 0x00000D57
			public unsafe Texture2D vertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_vertices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600025D RID: 605 RVA: 0x0000C564 File Offset: 0x0000A764
			// (set) Token: 0x0600025E RID: 606 RVA: 0x00002B76 File Offset: 0x00000D76
			public unsafe Texture2D indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystemRenderer.BakeTextureOutput.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeFieldInfoPtr_vertices;

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeFieldInfoPtr_indices;
		}
	}
}

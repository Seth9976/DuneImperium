using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000DB RID: 219
	public sealed class Mesh : Object
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x00049500 File Offset: 0x00047700
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh()
		{
			Il2CppClassPointerStore<Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh>.NativeClassPtr);
			Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665189);
			Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665190);
			Mesh.NativeMethodInfoPtr_FromInstanceID_Internal_Static_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665191);
			Mesh.NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665192);
			Mesh.NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665193);
			Mesh.NativeMethodInfoPtr_GetTotalIndexCount_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665194);
			Mesh.NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665195);
			Mesh.NativeMethodInfoPtr_InternalSetIndexBufferData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665196);
			Mesh.NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665197);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromPtr_Private_Void_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665198);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665199);
			Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665200);
			Mesh.NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665201);
			Mesh.NativeMethodInfoPtr_GetVertexAttributesAlloc_Private_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665202);
			Mesh.NativeMethodInfoPtr_GetVertexAttributesArray_Private_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665203);
			Mesh.NativeMethodInfoPtr_GetVertexAttributesList_Private_Int32_List_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665204);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeCountImpl_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665205);
			Mesh.NativeMethodInfoPtr_GetVertexAttribute_Public_VertexAttributeDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665206);
			Mesh.NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665207);
			Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665208);
			Mesh.NativeMethodInfoPtr_GetTrianglesCountImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665209);
			Mesh.NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665210);
			Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665211);
			Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665212);
			Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665213);
			Mesh.NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665214);
			Mesh.NativeMethodInfoPtr_GetTrianglesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665215);
			Mesh.NativeMethodInfoPtr_GetTrianglesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665216);
			Mesh.NativeMethodInfoPtr_GetIndicesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665217);
			Mesh.NativeMethodInfoPtr_GetIndicesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665218);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665219);
			Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665220);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeDimension_Public_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665221);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665222);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665223);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665224);
			Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665225);
			Mesh.NativeMethodInfoPtr_SetNativeArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665226);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665227);
			Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665228);
			Mesh.NativeMethodInfoPtr_get_vertexBufferCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665229);
			Mesh.NativeMethodInfoPtr_GetVertexBufferStride_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665230);
			Mesh.NativeMethodInfoPtr_GetNativeVertexBufferPtr_Public_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665231);
			Mesh.NativeMethodInfoPtr_GetNativeIndexBufferPtr_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665232);
			Mesh.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665233);
			Mesh.NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665234);
			Mesh.NativeMethodInfoPtr_GetBoneWeightBufferImpl_Private_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665235);
			Mesh.NativeMethodInfoPtr_GetBlendShapeBufferImpl_Private_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665236);
			Mesh.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665237);
			Mesh.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665238);
			Mesh.NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665239);
			Mesh.NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665240);
			Mesh.NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665241);
			Mesh.NativeMethodInfoPtr_ClearBlendShapes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665242);
			Mesh.NativeMethodInfoPtr_GetBlendShapeName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665243);
			Mesh.NativeMethodInfoPtr_GetBlendShapeIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665244);
			Mesh.NativeMethodInfoPtr_GetBlendShapeFrameCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665245);
			Mesh.NativeMethodInfoPtr_GetBlendShapeFrameWeight_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665246);
			Mesh.NativeMethodInfoPtr_GetBlendShapeFrameVertices_Public_Void_Int32_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665247);
			Mesh.NativeMethodInfoPtr_AddBlendShapeFrame_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665248);
			Mesh.NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Private_BlendShape_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665249);
			Mesh.NativeMethodInfoPtr_HasBoneWeights_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665250);
			Mesh.NativeMethodInfoPtr_GetBoneWeightsImpl_Private_Il2CppStructArray_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665251);
			Mesh.NativeMethodInfoPtr_SetBoneWeightsImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665252);
			Mesh.NativeMethodInfoPtr_SetBoneWeights_Public_Void_NativeArray_1_Byte_NativeArray_1_BoneWeight1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665253);
			Mesh.NativeMethodInfoPtr_InternalSetBoneWeights_Private_Void_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665254);
			Mesh.NativeMethodInfoPtr_GetAllBoneWeights_Public_NativeArray_1_BoneWeight1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665255);
			Mesh.NativeMethodInfoPtr_GetBonesPerVertex_Public_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665256);
			Mesh.NativeMethodInfoPtr_GetAllBoneWeightsArraySize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665257);
			Mesh.NativeMethodInfoPtr_GetBoneWeightBufferLayoutInternal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665258);
			Mesh.NativeMethodInfoPtr_GetAllBoneWeightsArray_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665259);
			Mesh.NativeMethodInfoPtr_GetBonesPerVertexArray_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665260);
			Mesh.NativeMethodInfoPtr_get_bindposeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665261);
			Mesh.NativeMethodInfoPtr_get_bindposes_Public_get_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665262);
			Mesh.NativeMethodInfoPtr_set_bindposes_Public_set_Void_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665263);
			Mesh.NativeMethodInfoPtr_GetBindposes_Public_NativeArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665264);
			Mesh.NativeMethodInfoPtr_GetBindposesArray_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665265);
			Mesh.NativeMethodInfoPtr_GetBoneWeightsNonAllocImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665266);
			Mesh.NativeMethodInfoPtr_GetBindposesNonAllocImpl_Private_Void_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665267);
			Mesh.NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665268);
			Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665269);
			Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665270);
			Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665271);
			Mesh.NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665272);
			Mesh.NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665273);
			Mesh.NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665274);
			Mesh.NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromArray_Private_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665275);
			Mesh.NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromNativeArray_Private_Void_IntPtr_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665276);
			Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665277);
			Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665278);
			Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665279);
			Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665280);
			Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665281);
			Mesh.NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665282);
			Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665283);
			Mesh.NativeMethodInfoPtr_MarkModified_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665284);
			Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665285);
			Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665286);
			Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetricImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665287);
			Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetricsImpl_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665288);
			Mesh.NativeMethodInfoPtr_GetUVDistributionMetric_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665289);
			Mesh.NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665290);
			Mesh.NativeMethodInfoPtr_OptimizeImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665291);
			Mesh.NativeMethodInfoPtr_OptimizeIndexBuffersImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665292);
			Mesh.NativeMethodInfoPtr_OptimizeReorderVertexBufferImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665293);
			Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665294);
			Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665295);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665296);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665297);
			Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665298);
			Mesh.NativeMethodInfoPtr_SetSizedNativeArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665299);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665300);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665301);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665302);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665303);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665304);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665305);
			Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665306);
			Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665307);
			Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665308);
			Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665309);
			Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665310);
			Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665311);
			Mesh.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665312);
			Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665313);
			Mesh.NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665314);
			Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665315);
			Mesh.NativeMethodInfoPtr_get_uv3_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665316);
			Mesh.NativeMethodInfoPtr_set_uv3_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665317);
			Mesh.NativeMethodInfoPtr_get_uv4_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665318);
			Mesh.NativeMethodInfoPtr_set_uv4_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665319);
			Mesh.NativeMethodInfoPtr_get_uv5_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665320);
			Mesh.NativeMethodInfoPtr_set_uv5_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665321);
			Mesh.NativeMethodInfoPtr_get_uv6_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665322);
			Mesh.NativeMethodInfoPtr_set_uv6_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665323);
			Mesh.NativeMethodInfoPtr_get_uv7_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665324);
			Mesh.NativeMethodInfoPtr_set_uv7_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665325);
			Mesh.NativeMethodInfoPtr_get_uv8_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665326);
			Mesh.NativeMethodInfoPtr_set_uv8_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665327);
			Mesh.NativeMethodInfoPtr_get_colors_Public_get_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665328);
			Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665329);
			Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665330);
			Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665331);
			Mesh.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665332);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665333);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665334);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665335);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665336);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665337);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665338);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665339);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665340);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665341);
			Mesh.NativeMethodInfoPtr_GetNormals_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665342);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665343);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665344);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665345);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665346);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665347);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665348);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665349);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665350);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665351);
			Mesh.NativeMethodInfoPtr_GetTangents_Public_Void_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665352);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665353);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665354);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665355);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665356);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665357);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665358);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665359);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665360);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665361);
			Mesh.NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665362);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665363);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665364);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665365);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665366);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665367);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665368);
			Mesh.NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665369);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665370);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665371);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665372);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665373);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665374);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665375);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665376);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665377);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665378);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665379);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665380);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665381);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665382);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665383);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665384);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665385);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665386);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665387);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665388);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665389);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665390);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665391);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665392);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665393);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665394);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665395);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665396);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665397);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665398);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665399);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665400);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665401);
			Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665402);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665403);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665404);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665405);
			Mesh.NativeMethodInfoPtr_get_vertexAttributeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665406);
			Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665407);
			Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665408);
			Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_List_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665409);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665410);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_NativeArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665411);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665412);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665413);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665414);
			Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665415);
			Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Il2CppReferenceArray_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665416);
			Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_List_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665417);
			Mesh.NativeMethodInfoPtr_AllocateWritableMeshData_Public_Static_MeshDataArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665418);
			Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Mesh_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665419);
			Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665420);
			Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_List_1_Mesh_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665421);
			Mesh.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665422);
			Mesh.NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665423);
			Mesh.NativeMethodInfoPtr_GetBoneWeightBuffer_Public_GraphicsBuffer_SkinWeights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665424);
			Mesh.NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_BlendShapeBufferLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665425);
			Mesh.NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665426);
			Mesh.NativeMethodInfoPtr_GetBlendShapeBufferRange_Public_BlendShapeBufferRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665427);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665428);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665429);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665430);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665431);
			Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665432);
			Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665433);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665434);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665435);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665436);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665437);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665438);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665439);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665440);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665441);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665442);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665443);
			Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665444);
			Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665445);
			Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665446);
			Mesh.NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665447);
			Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665448);
			Mesh.NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665449);
			Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665450);
			Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665451);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665452);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665453);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665454);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665455);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665456);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665457);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665458);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665459);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665460);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665461);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665462);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665463);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665464);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665465);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665466);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665467);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665468);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665469);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665470);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665471);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665472);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665473);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665474);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665475);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665476);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665477);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665478);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665479);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665480);
			Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665481);
			Mesh.NativeMethodInfoPtr_GetBindposes_Public_Void_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665482);
			Mesh.NativeMethodInfoPtr_GetBoneWeights_Public_Void_List_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665483);
			Mesh.NativeMethodInfoPtr_get_boneWeights_Public_get_Il2CppStructArray_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665484);
			Mesh.NativeMethodInfoPtr_set_boneWeights_Public_set_Void_Il2CppStructArray_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665485);
			Mesh.NativeMethodInfoPtr_get_skinWeightBufferLayout_Public_get_SkinWeights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665486);
			Mesh.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665487);
			Mesh.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665488);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665489);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665490);
			Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665491);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665492);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665493);
			Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665494);
			Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetric_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665495);
			Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetrics_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665496);
			Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665497);
			Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665498);
			Mesh.NativeMethodInfoPtr_Optimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665499);
			Mesh.NativeMethodInfoPtr_OptimizeIndexBuffers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665500);
			Mesh.NativeMethodInfoPtr_OptimizeReorderVertexBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665501);
			Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665502);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665503);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665504);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665505);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665506);
			Mesh.NativeMethodInfoPtr_GetVertexAttribute_Injected_Private_Void_Int32_byref_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665507);
			Mesh.NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Injected_Private_Void_Int32_byref_BlendShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665508);
			Mesh.NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665509);
			Mesh.NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665510);
			Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665511);
			Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665512);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0004AE80 File Offset: 0x00049080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653873, XrefRangeEnd = 653875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Mesh mono)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0004AEB8 File Offset: 0x000490B8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 653881, RefRangeEnd = 653914, XrefRangeStart = 653875, XrefRangeEnd = 653881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0004AEF4 File Offset: 0x000490F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653914, XrefRangeEnd = 653916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh FromInstanceID(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_FromInstanceID_Internal_Static_Mesh_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0004AF34 File Offset: 0x00049134
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0004AF70 File Offset: 0x00049170
		public unsafe UnityEngine.Rendering.IndexFormat indexFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653916, XrefRangeEnd = 653918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 653920, RefRangeEnd = 653925, XrefRangeStart = 653918, XrefRangeEnd = 653920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004AFB0 File Offset: 0x000491B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653925, XrefRangeEnd = 653927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetTotalIndexCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTotalIndexCount_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004AFEC File Offset: 0x000491EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653927, XrefRangeEnd = 653929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0004B038 File Offset: 0x00049238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 653931, RefRangeEnd = 653932, XrefRangeStart = 653929, XrefRangeEnd = 653931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetIndexBufferData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0004B0BC File Offset: 0x000492BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653934, RefRangeEnd = 653936, XrefRangeStart = 653932, XrefRangeEnd = 653934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0004B144 File Offset: 0x00049344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653936, XrefRangeEnd = 653938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributesPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributesCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromPtr_Private_Void_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0004B1A0 File Offset: 0x000493A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 653940, RefRangeEnd = 653944, XrefRangeStart = 653938, XrefRangeEnd = 653940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParamsFromArray(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0004B200 File Offset: 0x00049400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 653946, RefRangeEnd = 653947, XrefRangeStart = 653944, XrefRangeEnd = 653946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0004B294 File Offset: 0x00049494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653949, RefRangeEnd = 653951, XrefRangeStart = 653947, XrefRangeEnd = 653949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004B32C File Offset: 0x0004952C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653951, XrefRangeEnd = 653953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetVertexAttributesAlloc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributesAlloc_Private_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0004B36C File Offset: 0x0004956C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653953, XrefRangeEnd = 653955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributesArray(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributesArray_Private_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004B3BC File Offset: 0x000495BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653955, XrefRangeEnd = 653957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributesList(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributesList_Private_Int32_List_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0004B40C File Offset: 0x0004960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653957, XrefRangeEnd = 653959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeCountImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeCountImpl_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0004B448 File Offset: 0x00049648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653959, XrefRangeEnd = 653961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttribute_Public_VertexAttributeDescriptor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0004B494 File Offset: 0x00049694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653961, XrefRangeEnd = 653963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexStartImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0004B4E0 File Offset: 0x000496E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653963, XrefRangeEnd = 653965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCountImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0004B52C File Offset: 0x0004972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653965, XrefRangeEnd = 653967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetTrianglesCountImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesCountImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0004B578 File Offset: 0x00049778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653967, XrefRangeEnd = 653969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetBaseVertexImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0004B5C4 File Offset: 0x000497C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653969, XrefRangeEnd = 653971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTrianglesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0004B620 File Offset: 0x00049820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653971, XrefRangeEnd = 653973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0004B67C File Offset: 0x0004987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653973, XrefRangeEnd = 653975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0004B724 File Offset: 0x00049924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653977, RefRangeEnd = 653979, XrefRangeStart = 653975, XrefRangeEnd = 653977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indices;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0004B7C4 File Offset: 0x000499C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653979, XrefRangeEnd = 653981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTrianglesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0004B834 File Offset: 0x00049A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653981, XrefRangeEnd = 653983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTrianglesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<ushort>(intPtr4));
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0004B8A4 File Offset: 0x00049AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653983, XrefRangeEnd = 653985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndicesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0004B914 File Offset: 0x00049B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653985, XrefRangeEnd = 653987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndicesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<ushort>(intPtr4));
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0004B984 File Offset: 0x00049B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653989, RefRangeEnd = 653991, XrefRangeStart = 653987, XrefRangeEnd = 653989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004B9C4 File Offset: 0x00049BC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 653993, RefRangeEnd = 653998, XrefRangeStart = 653991, XrefRangeEnd = 653993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0004BA10 File Offset: 0x00049C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653998, XrefRangeEnd = 654000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeDimension_Public_Int32_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0004BA5C File Offset: 0x00049C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654000, XrefRangeEnd = 654002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0004BAA8 File Offset: 0x00049CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654002, XrefRangeEnd = 654004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0004BAF4 File Offset: 0x00049CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654004, XrefRangeEnd = 654006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0004BB40 File Offset: 0x00049D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654006, XrefRangeEnd = 654008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654008, XrefRangeEnd = 654010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref values;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNativeArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0004BC88 File Offset: 0x00049E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 654012, RefRangeEnd = 654014, XrefRangeStart = 654010, XrefRangeEnd = 654012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0004BCF0 File Offset: 0x00049EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654016, RefRangeEnd = 654019, XrefRangeStart = 654014, XrefRangeEnd = 654016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0004BD60 File Offset: 0x00049F60
		public unsafe int vertexBufferCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654019, XrefRangeEnd = 654021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexBufferCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0004BD9C File Offset: 0x00049F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654021, XrefRangeEnd = 654023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexBufferStride(int stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexBufferStride_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654023, XrefRangeEnd = 654025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetNativeVertexBufferPtr(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetNativeVertexBufferPtr_Public_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0004BE34 File Offset: 0x0004A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654025, XrefRangeEnd = 654027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetNativeIndexBufferPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetNativeIndexBufferPtr_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0004BE70 File Offset: 0x0004A070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654027, XrefRangeEnd = 654029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBufferImpl(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0004BEBC File Offset: 0x0004A0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654029, XrefRangeEnd = 654031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetIndexBufferImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004BEFC File Offset: 0x0004A0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654031, XrefRangeEnd = 654033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bonesPerVertex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeightBufferImpl_Private_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004BF48 File Offset: 0x0004A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654033, XrefRangeEnd = 654035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetBlendShapeBufferImpl(int layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeBufferImpl_Private_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0004BF94 File Offset: 0x0004A194
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x0004BFD0 File Offset: 0x0004A1D0
		public unsafe GraphicsBuffer.Target vertexBufferTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654035, XrefRangeEnd = 654037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654037, XrefRangeEnd = 654039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0004C010 File Offset: 0x0004A210
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0004C04C File Offset: 0x0004A24C
		public unsafe GraphicsBuffer.Target indexBufferTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654039, XrefRangeEnd = 654041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654041, XrefRangeEnd = 654043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0004C08C File Offset: 0x0004A28C
		public unsafe int blendShapeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654043, XrefRangeEnd = 654045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654045, XrefRangeEnd = 654047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBlendShapes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ClearBlendShapes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654047, XrefRangeEnd = 654049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBlendShapeName(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0004C140 File Offset: 0x0004A340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654049, XrefRangeEnd = 654051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBlendShapeIndex(string blendShapeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(blendShapeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0004C190 File Offset: 0x0004A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654051, XrefRangeEnd = 654053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBlendShapeFrameCount(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeFrameCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004C1DC File Offset: 0x0004A3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654053, XrefRangeEnd = 654055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeFrameWeight_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004C234 File Offset: 0x0004A434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654055, XrefRangeEnd = 654057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaVertices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaNormals);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaTangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeFrameVertices_Public_Void_Int32_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004C2B8 File Offset: 0x0004A4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654057, XrefRangeEnd = 654059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBlendShapeFrame(string shapeName, float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(shapeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameWeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaVertices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaNormals);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deltaTangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AddBlendShapeFrame_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0004C340 File Offset: 0x0004A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654059, XrefRangeEnd = 654061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendShape GetBlendShapeOffsetInternal(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Private_BlendShape_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004C38C File Offset: 0x0004A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654061, XrefRangeEnd = 654063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBoneWeights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_HasBoneWeights_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004C3C8 File Offset: 0x0004A5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654063, XrefRangeEnd = 654065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<BoneWeight> GetBoneWeightsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeightsImpl_Private_Il2CppStructArray_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BoneWeight>>(intPtr3) : null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0004C408 File Offset: 0x0004A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654065, XrefRangeEnd = 654067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoneWeightsImpl(Il2CppStructArray<BoneWeight> weights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(weights);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetBoneWeightsImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0004C44C File Offset: 0x0004A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654067, XrefRangeEnd = 654077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<BoneWeight1> weights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bonesPerVertex));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(weights));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetBoneWeights_Public_Void_NativeArray_1_Byte_NativeArray_1_BoneWeight1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0004C4AC File Offset: 0x0004A6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654077, XrefRangeEnd = 654079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bonesPerVertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bonesPerVertexSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weights;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weightsSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetBoneWeights_Private_Void_IntPtr_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0004C514 File Offset: 0x0004A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654079, XrefRangeEnd = 654087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<BoneWeight1> GetAllBoneWeights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllBoneWeights_Public_NativeArray_1_BoneWeight1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeArray<BoneWeight1>(intPtr);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0004C54C File Offset: 0x0004A74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654087, XrefRangeEnd = 654098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<byte> GetBonesPerVertex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBonesPerVertex_Public_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeArray<byte>(intPtr);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0004C584 File Offset: 0x0004A784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654098, XrefRangeEnd = 654100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAllBoneWeightsArraySize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllBoneWeightsArraySize_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0004C5C0 File Offset: 0x0004A7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654100, XrefRangeEnd = 654102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBoneWeightBufferLayoutInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeightBufferLayoutInternal_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0004C5FC File Offset: 0x0004A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654102, XrefRangeEnd = 654104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetAllBoneWeightsArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllBoneWeightsArray_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004C638 File Offset: 0x0004A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654104, XrefRangeEnd = 654106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetBonesPerVertexArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBonesPerVertexArray_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0004C674 File Offset: 0x0004A874
		public unsafe int bindposeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654106, XrefRangeEnd = 654108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bindposeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x0004C6F0 File Offset: 0x0004A8F0
		public unsafe Il2CppStructArray<Matrix4x4> bindposes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654108, XrefRangeEnd = 654110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bindposes_Public_get_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654110, XrefRangeEnd = 654112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bindposes_Public_set_Void_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0004C734 File Offset: 0x0004A934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654112, XrefRangeEnd = 654120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBindposes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBindposes_Public_NativeArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeArray<Matrix4x4>(intPtr);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0004C76C File Offset: 0x0004A96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654120, XrefRangeEnd = 654122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetBindposesArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBindposesArray_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0004C7A8 File Offset: 0x0004A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654122, XrefRangeEnd = 654124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBoneWeightsNonAllocImpl([Out] Il2CppStructArray<BoneWeight> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeightsNonAllocImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<BoneWeight>(intPtr4));
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0004C7FC File Offset: 0x0004A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654124, XrefRangeEnd = 654126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBindposesNonAllocImpl([Out] Il2CppStructArray<Matrix4x4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBindposesNonAllocImpl_Private_Void_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*values = ((intPtr4 == 0) ? null : new Il2CppStructArray<Matrix4x4>(intPtr4));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0004C850 File Offset: 0x0004AA50
		public unsafe bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654126, XrefRangeEnd = 654128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0004C88C File Offset: 0x0004AA8C
		public unsafe bool canAccess
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 654130, RefRangeEnd = 654141, XrefRangeStart = 654128, XrefRangeEnd = 654130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0004C8C8 File Offset: 0x0004AAC8
		public unsafe int vertexCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 654143, RefRangeEnd = 654146, XrefRangeStart = 654141, XrefRangeEnd = 654143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004C904 File Offset: 0x0004AB04
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x0004C940 File Offset: 0x0004AB40
		public unsafe int subMeshCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 654148, RefRangeEnd = 654152, XrefRangeStart = 654146, XrefRangeEnd = 654148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 654154, RefRangeEnd = 654155, XrefRangeStart = 654152, XrefRangeEnd = 654154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0004C980 File Offset: 0x0004AB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654155, XrefRangeEnd = 654157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMesh(int index, UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004C9DC File Offset: 0x0004ABDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 654159, RefRangeEnd = 654161, XrefRangeStart = 654157, XrefRangeEnd = 654159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0004CA28 File Offset: 0x0004AC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654161, XrefRangeEnd = 654163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllSubMeshesAtOnceFromArray(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromArray_Private_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004CA94 File Offset: 0x0004AC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 654165, RefRangeEnd = 654166, XrefRangeStart = 654163, XrefRangeEnd = 654165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromNativeArray_Private_Void_IntPtr_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0004CAFC File Offset: 0x0004ACFC
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0004CB38 File Offset: 0x0004AD38
		public unsafe Bounds bounds
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 654168, RefRangeEnd = 654172, XrefRangeStart = 654166, XrefRangeEnd = 654168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 654174, RefRangeEnd = 654177, XrefRangeStart = 654172, XrefRangeEnd = 654174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0004CB78 File Offset: 0x0004AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654177, XrefRangeEnd = 654179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearImpl(bool keepVertexLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepVertexLayout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654179, XrefRangeEnd = 654181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654181, XrefRangeEnd = 654183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0004CC38 File Offset: 0x0004AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654183, XrefRangeEnd = 654185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0004CC78 File Offset: 0x0004AE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654185, XrefRangeEnd = 654187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamicImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0004CCAC File Offset: 0x0004AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654187, XrefRangeEnd = 654189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkModified_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0004CCE0 File Offset: 0x0004AEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654189, XrefRangeEnd = 654191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshDataImpl(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markNoLongerReadable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004CD20 File Offset: 0x0004AF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654191, XrefRangeEnd = 654193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopologyImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004CD6C File Offset: 0x0004AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654193, XrefRangeEnd = 654195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvSetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvAreaThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetricImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654195, XrefRangeEnd = 654197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvAreaThreshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetricsImpl_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0004CDF8 File Offset: 0x0004AFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654197, XrefRangeEnd = 654199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetUVDistributionMetric(int uvSetIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvSetIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVDistributionMetric_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0004CE44 File Offset: 0x0004B044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654199, XrefRangeEnd = 654201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesImpl(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMatrices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasLightmapData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004CEB0 File Offset: 0x0004B0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654201, XrefRangeEnd = 654203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654203, XrefRangeEnd = 654205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeIndexBuffersImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeIndexBuffersImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004CF18 File Offset: 0x0004B118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654205, XrefRangeEnd = 654207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeReorderVertexBufferImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeReorderVertexBufferImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004CF4C File Offset: 0x0004B14C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654207, RefRangeEnd = 654210, XrefRangeStart = 654207, XrefRangeEnd = 654207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004CF8C File Offset: 0x0004B18C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654210, RefRangeEnd = 654213, XrefRangeStart = 654210, XrefRangeEnd = 654210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004CFCC File Offset: 0x0004B1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 654224, RefRangeEnd = 654225, XrefRangeStart = 654213, XrefRangeEnd = 654224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0004D02C File Offset: 0x0004B22C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 654238, RefRangeEnd = 654250, XrefRangeStart = 654225, XrefRangeEnd = 654238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0004D070 File Offset: 0x0004B270
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 654256, RefRangeEnd = 654277, XrefRangeStart = 654250, XrefRangeEnd = 654256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesArrayLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004D118 File Offset: 0x0004B318
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 654284, RefRangeEnd = 654289, XrefRangeStart = 654277, XrefRangeEnd = 654284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref values;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesArrayLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSizedNativeArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 654291, RefRangeEnd = 654292, XrefRangeStart = 654289, XrefRangeEnd = 654291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0004D234 File Offset: 0x0004B434
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 654295, RefRangeEnd = 654307, XrefRangeStart = 654292, XrefRangeEnd = 654295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004D294 File Offset: 0x0004B494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654311, RefRangeEnd = 654314, XrefRangeStart = 654307, XrefRangeEnd = 654311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004D32C File Offset: 0x0004B52C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 654319, RefRangeEnd = 654331, XrefRangeStart = 654314, XrefRangeEnd = 654319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 654338, RefRangeEnd = 654342, XrefRangeStart = 654331, XrefRangeEnd = 654338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004D414 File Offset: 0x0004B614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 654348, RefRangeEnd = 654349, XrefRangeStart = 654342, XrefRangeEnd = 654348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0004D490 File Offset: 0x0004B690
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x0004D4D0 File Offset: 0x0004B6D0
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 654352, RefRangeEnd = 654355, XrefRangeStart = 654349, XrefRangeEnd = 654352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 654358, RefRangeEnd = 654387, XrefRangeStart = 654355, XrefRangeEnd = 654358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0004D514 File Offset: 0x0004B714
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0004D554 File Offset: 0x0004B754
		public unsafe Il2CppStructArray<Vector3> normals
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 654390, RefRangeEnd = 654391, XrefRangeStart = 654387, XrefRangeEnd = 654390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 654394, RefRangeEnd = 654403, XrefRangeStart = 654391, XrefRangeEnd = 654394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004D598 File Offset: 0x0004B798
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x0004D5D8 File Offset: 0x0004B7D8
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 654406, RefRangeEnd = 654407, XrefRangeStart = 654403, XrefRangeEnd = 654406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 654410, RefRangeEnd = 654415, XrefRangeStart = 654407, XrefRangeEnd = 654410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004D61C File Offset: 0x0004B81C
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x0004D65C File Offset: 0x0004B85C
		public unsafe Il2CppStructArray<Vector2> uv
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654415, XrefRangeEnd = 654418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 654421, RefRangeEnd = 654437, XrefRangeStart = 654418, XrefRangeEnd = 654421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0004D6E0 File Offset: 0x0004B8E0
		public unsafe Il2CppStructArray<Vector2> uv2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654437, XrefRangeEnd = 654440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 654443, RefRangeEnd = 654454, XrefRangeStart = 654440, XrefRangeEnd = 654443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004D724 File Offset: 0x0004B924
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0004D764 File Offset: 0x0004B964
		public unsafe Il2CppStructArray<Vector2> uv3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654454, XrefRangeEnd = 654457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv3_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654457, XrefRangeEnd = 654460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv3_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x0004D7E8 File Offset: 0x0004B9E8
		public unsafe Il2CppStructArray<Vector2> uv4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654460, XrefRangeEnd = 654463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv4_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654463, XrefRangeEnd = 654466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv4_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004D82C File Offset: 0x0004BA2C
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0004D86C File Offset: 0x0004BA6C
		public unsafe Il2CppStructArray<Vector2> uv5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654466, XrefRangeEnd = 654469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv5_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654469, XrefRangeEnd = 654472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv5_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0004D8F0 File Offset: 0x0004BAF0
		public unsafe Il2CppStructArray<Vector2> uv6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654472, XrefRangeEnd = 654475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv6_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654475, XrefRangeEnd = 654478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv6_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004D934 File Offset: 0x0004BB34
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0004D974 File Offset: 0x0004BB74
		public unsafe Il2CppStructArray<Vector2> uv7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654478, XrefRangeEnd = 654481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv7_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654481, XrefRangeEnd = 654484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv7_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		public unsafe Il2CppStructArray<Vector2> uv8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654484, XrefRangeEnd = 654487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv8_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654487, XrefRangeEnd = 654490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv8_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0004DA3C File Offset: 0x0004BC3C
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		public unsafe Il2CppStructArray<Color> colors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654490, XrefRangeEnd = 654493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_colors_Public_get_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 654496, RefRangeEnd = 654497, XrefRangeStart = 654493, XrefRangeEnd = 654496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0004DB00 File Offset: 0x0004BD00
		public unsafe Il2CppStructArray<Color32> colors32
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 654500, RefRangeEnd = 654501, XrefRangeStart = 654497, XrefRangeEnd = 654500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 654504, RefRangeEnd = 654512, XrefRangeStart = 654501, XrefRangeEnd = 654504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0004DB44 File Offset: 0x0004BD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654512, XrefRangeEnd = 654517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVertices(List<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0004DB88 File Offset: 0x0004BD88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 654523, RefRangeEnd = 654529, XrefRangeStart = 654517, XrefRangeEnd = 654523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0004DBCC File Offset: 0x0004BDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654529, XrefRangeEnd = 654532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0004DC2C File Offset: 0x0004BE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654532, XrefRangeEnd = 654535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004DC98 File Offset: 0x0004BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654535, XrefRangeEnd = 654538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(Il2CppStructArray<Vector3> inVertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0004DCDC File Offset: 0x0004BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654538, XrefRangeEnd = 654540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0004DD3C File Offset: 0x0004BF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654540, XrefRangeEnd = 654542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0004DDA8 File Offset: 0x0004BFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654542, XrefRangeEnd = 654543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inVertices));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654543, XrefRangeEnd = 654544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inVertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004DE54 File Offset: 0x0004C054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654544, XrefRangeEnd = 654547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inVertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654547, XrefRangeEnd = 654552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNormals(List<Vector3> normals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetNormals_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004DF0C File Offset: 0x0004C10C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654558, RefRangeEnd = 654561, XrefRangeStart = 654552, XrefRangeEnd = 654558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004DF50 File Offset: 0x0004C150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654561, XrefRangeEnd = 654564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654564, XrefRangeEnd = 654567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004E01C File Offset: 0x0004C21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654567, XrefRangeEnd = 654570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(Il2CppStructArray<Vector3> inNormals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0004E060 File Offset: 0x0004C260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654570, XrefRangeEnd = 654572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654572, XrefRangeEnd = 654574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0004E12C File Offset: 0x0004C32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inNormals));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0004E174 File Offset: 0x0004C374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inNormals));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0004E1D8 File Offset: 0x0004C3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654574, XrefRangeEnd = 654577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inNormals));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0004E24C File Offset: 0x0004C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654577, XrefRangeEnd = 654582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTangents(List<Vector4> tangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tangents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTangents_Public_Void_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0004E290 File Offset: 0x0004C490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654588, RefRangeEnd = 654591, XrefRangeStart = 654582, XrefRangeEnd = 654588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004E2D4 File Offset: 0x0004C4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654591, XrefRangeEnd = 654594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004E334 File Offset: 0x0004C534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654594, XrefRangeEnd = 654597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004E3A0 File Offset: 0x0004C5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654597, XrefRangeEnd = 654600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(Il2CppStructArray<Vector4> inTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0004E3E4 File Offset: 0x0004C5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654600, XrefRangeEnd = 654602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0004E444 File Offset: 0x0004C644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654602, XrefRangeEnd = 654604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inTangents));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inTangents));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0004E55C File Offset: 0x0004C75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654604, XrefRangeEnd = 654607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inTangents));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654607, XrefRangeEnd = 654612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColors(List<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0004E614 File Offset: 0x0004C814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 654618, RefRangeEnd = 654620, XrefRangeStart = 654612, XrefRangeEnd = 654618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0004E658 File Offset: 0x0004C858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654620, XrefRangeEnd = 654623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0004E6B8 File Offset: 0x0004C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654623, XrefRangeEnd = 654626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0004E724 File Offset: 0x0004C924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654626, XrefRangeEnd = 654629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0004E768 File Offset: 0x0004C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654629, XrefRangeEnd = 654631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0004E7C8 File Offset: 0x0004C9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654631, XrefRangeEnd = 654633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0004E834 File Offset: 0x0004CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654633, XrefRangeEnd = 654638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColors(List<Color32> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004E878 File Offset: 0x0004CA78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654644, RefRangeEnd = 654647, XrefRangeStart = 654638, XrefRangeEnd = 654644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0004E8BC File Offset: 0x0004CABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654647, XrefRangeEnd = 654650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004E91C File Offset: 0x0004CB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654650, XrefRangeEnd = 654653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004E988 File Offset: 0x0004CB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654653, XrefRangeEnd = 654656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color32> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654656, XrefRangeEnd = 654658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color32> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004EA2C File Offset: 0x0004CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654658, XrefRangeEnd = 654660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Il2CppStructArray<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0004EA98 File Offset: 0x0004CC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors<T>(Unity.Collections.NativeArray<T> inColors) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inColors));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inColors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0004EB44 File Offset: 0x0004CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654660, XrefRangeEnd = 654663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inColors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 654676, RefRangeEnd = 654685, XrefRangeStart = 654663, XrefRangeEnd = 654676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0004EC40 File Offset: 0x0004CE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 654691, RefRangeEnd = 654692, XrefRangeStart = 654685, XrefRangeEnd = 654691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0004EC90 File Offset: 0x0004CE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654692, XrefRangeEnd = 654698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector3> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0004ECE0 File Offset: 0x0004CEE0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 654704, RefRangeEnd = 654716, XrefRangeStart = 654698, XrefRangeEnd = 654704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0004ED30 File Offset: 0x0004CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654716, XrefRangeEnd = 654719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0004ED9C File Offset: 0x0004CF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654719, XrefRangeEnd = 654722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0004EE18 File Offset: 0x0004D018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654722, XrefRangeEnd = 654725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector3> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0004EE84 File Offset: 0x0004D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654725, XrefRangeEnd = 654728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0004EF00 File Offset: 0x0004D100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654728, XrefRangeEnd = 654731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0004EF6C File Offset: 0x0004D16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654731, XrefRangeEnd = 654734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0004EFE8 File Offset: 0x0004D1E8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 654736, RefRangeEnd = 654745, XrefRangeStart = 654734, XrefRangeEnd = 654736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0004F070 File Offset: 0x0004D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654745, XrefRangeEnd = 654747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654747, XrefRangeEnd = 654749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector3> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0004F110 File Offset: 0x0004D310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654749, XrefRangeEnd = 654751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0004F160 File Offset: 0x0004D360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654751, XrefRangeEnd = 654752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654752, XrefRangeEnd = 654753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004F248 File Offset: 0x0004D448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654753, XrefRangeEnd = 654754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004F2B4 File Offset: 0x0004D4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654754, XrefRangeEnd = 654755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0004F330 File Offset: 0x0004D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654755, XrefRangeEnd = 654756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0004F39C File Offset: 0x0004D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654756, XrefRangeEnd = 654757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0004F418 File Offset: 0x0004D618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654757, XrefRangeEnd = 654758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(uvs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004F470 File Offset: 0x0004D670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654758, XrefRangeEnd = 654759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(uvs));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004F4E4 File Offset: 0x0004D6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654759, XrefRangeEnd = 654763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(uvs));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004F564 File Offset: 0x0004D764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 654773, RefRangeEnd = 654776, XrefRangeStart = 654763, XrefRangeEnd = 654773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004F5C4 File Offset: 0x0004D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654776, XrefRangeEnd = 654779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector2> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0004F614 File Offset: 0x0004D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654779, XrefRangeEnd = 654782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector3> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0004F664 File Offset: 0x0004D864
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 654785, RefRangeEnd = 654789, XrefRangeStart = 654782, XrefRangeEnd = 654785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004F6B4 File Offset: 0x0004D8B4
		public unsafe int vertexAttributeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexAttributeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0004F6F0 File Offset: 0x0004D8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654789, XrefRangeEnd = 654793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> GetVertexAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>>(intPtr3) : null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004F730 File Offset: 0x0004D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributes(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004F780 File Offset: 0x0004D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributes(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_List_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 653940, RefRangeEnd = 653944, XrefRangeStart = 653940, XrefRangeEnd = 653944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParams(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004F830 File Offset: 0x0004DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654793, XrefRangeEnd = 654799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(attributes));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_NativeArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004F888 File Offset: 0x0004DA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654799, XrefRangeEnd = 654803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004F918 File Offset: 0x0004DB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654803, XrefRangeEnd = 654807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654807, XrefRangeEnd = 654811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004FA28 File Offset: 0x0004DC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654811, XrefRangeEnd = 654812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh mesh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0004FA6C File Offset: 0x0004DC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654812, XrefRangeEnd = 654813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh.MeshDataArray AcquireReadOnlyMeshData(Il2CppReferenceArray<Mesh> meshes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Il2CppReferenceArray_1_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0004FAB0 File Offset: 0x0004DCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654813, XrefRangeEnd = 654818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh.MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_List_1_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654818, XrefRangeEnd = 654819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh.MeshDataArray AllocateWritableMeshData(int meshCount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref meshCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AllocateWritableMeshData_Public_Static_MeshDataArray_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004FB34 File Offset: 0x0004DD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654819, XrefRangeEnd = 654824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Mesh_MeshUpdateFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004FB88 File Offset: 0x0004DD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654824, XrefRangeEnd = 654825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Il2CppReferenceArray<Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004FBDC File Offset: 0x0004DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654825, XrefRangeEnd = 654830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, List<Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_List_1_Mesh_MeshUpdateFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0004FC30 File Offset: 0x0004DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654830, XrefRangeEnd = 654841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBuffer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0004FC7C File Offset: 0x0004DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654841, XrefRangeEnd = 654852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetIndexBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0004FCBC File Offset: 0x0004DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654852, XrefRangeEnd = 654885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeightBuffer_Public_GraphicsBuffer_SkinWeights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0004FD08 File Offset: 0x0004DF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654885, XrefRangeEnd = 654898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_BlendShapeBufferLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0004FD54 File Offset: 0x0004DF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654898, XrefRangeEnd = 654911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetBlendShapeBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004FD94 File Offset: 0x0004DF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654911, XrefRangeEnd = 654917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blendShapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeBufferRange_Public_BlendShapeBufferRange_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 654925, RefRangeEnd = 654927, XrefRangeStart = 654917, XrefRangeEnd = 654925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessIndices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0004FE14 File Offset: 0x0004E014
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 654935, RefRangeEnd = 654957, XrefRangeStart = 654927, XrefRangeEnd = 654935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorAboutTriangles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004FE6C File Offset: 0x0004E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654957, XrefRangeEnd = 654958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 654959, RefRangeEnd = 654961, XrefRangeStart = 654958, XrefRangeEnd = 654959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0004FF04 File Offset: 0x0004E104
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0004FF44 File Offset: 0x0004E144
		public unsafe Il2CppStructArray<int> triangles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654961, XrefRangeEnd = 654969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 654977, RefRangeEnd = 654992, XrefRangeStart = 654969, XrefRangeEnd = 654977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0004FF88 File Offset: 0x0004E188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654992, XrefRangeEnd = 654996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0004FFD4 File Offset: 0x0004E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 654996, XrefRangeEnd = 655000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00050030 File Offset: 0x0004E230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655000, XrefRangeEnd = 655025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTriangles(List<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00050080 File Offset: 0x0004E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655025, XrefRangeEnd = 655050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000500E0 File Offset: 0x0004E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655050, XrefRangeEnd = 655075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00050140 File Offset: 0x0004E340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655079, RefRangeEnd = 655081, XrefRangeStart = 655075, XrefRangeEnd = 655079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0005018C File Offset: 0x0004E38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655081, XrefRangeEnd = 655085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000501E8 File Offset: 0x0004E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655085, XrefRangeEnd = 655109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndices(List<int> indices, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00050238 File Offset: 0x0004E438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655109, XrefRangeEnd = 655133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndices(List<int> indices, int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00050298 File Offset: 0x0004E498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655133, XrefRangeEnd = 655157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Void_List_1_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655157, XrefRangeEnd = 655161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00050378 File Offset: 0x0004E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655161, XrefRangeEnd = 655165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000503F4 File Offset: 0x0004E5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655165, XrefRangeEnd = 655169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00050470 File Offset: 0x0004E670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655169, XrefRangeEnd = 655179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexStart(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000504BC File Offset: 0x0004E6BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 655189, RefRangeEnd = 655193, XrefRangeStart = 655179, XrefRangeEnd = 655189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCount(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00050508 File Offset: 0x0004E708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655193, XrefRangeEnd = 655203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetBaseVertex(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00050554 File Offset: 0x0004E754
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 655203, RefRangeEnd = 655215, XrefRangeStart = 655203, XrefRangeEnd = 655203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valuesLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000505B0 File Offset: 0x0004E7B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 655218, RefRangeEnd = 655226, XrefRangeStart = 655215, XrefRangeEnd = 655218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesArrayLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00050654 File Offset: 0x0004E854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655226, XrefRangeEnd = 655227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000506A4 File Offset: 0x0004E8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655227, XrefRangeEnd = 655228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00050704 File Offset: 0x0004E904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655232, RefRangeEnd = 655234, XrefRangeStart = 655228, XrefRangeEnd = 655232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00050770 File Offset: 0x0004E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655234, XrefRangeEnd = 655237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000507F8 File Offset: 0x0004E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655237, XrefRangeEnd = 655241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<ushort> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00050864 File Offset: 0x0004EA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655241, XrefRangeEnd = 655244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x000508EC File Offset: 0x0004EAEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 655245, RefRangeEnd = 655250, XrefRangeStart = 655244, XrefRangeEnd = 655245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0005093C File Offset: 0x0004EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655250, XrefRangeEnd = 655251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0005099C File Offset: 0x0004EB9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655260, RefRangeEnd = 655262, XrefRangeStart = 655251, XrefRangeEnd = 655260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00050A08 File Offset: 0x0004EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655262, XrefRangeEnd = 655268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00050A90 File Offset: 0x0004EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655268, XrefRangeEnd = 655277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00050AFC File Offset: 0x0004ECFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655277, XrefRangeEnd = 655283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00050B84 File Offset: 0x0004ED84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 655284, RefRangeEnd = 655285, XrefRangeStart = 655283, XrefRangeEnd = 655284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00050BE4 File Offset: 0x0004EDE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 655286, RefRangeEnd = 655287, XrefRangeStart = 655285, XrefRangeEnd = 655286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00050C50 File Offset: 0x0004EE50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655293, RefRangeEnd = 655295, XrefRangeStart = 655287, XrefRangeEnd = 655293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00050CCC File Offset: 0x0004EECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655295, XrefRangeEnd = 655300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00050D64 File Offset: 0x0004EF64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 655306, RefRangeEnd = 655307, XrefRangeStart = 655300, XrefRangeEnd = 655306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655307, XrefRangeEnd = 655312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00050E78 File Offset: 0x0004F078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655319, RefRangeEnd = 655321, XrefRangeStart = 655312, XrefRangeEnd = 655319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices<T>(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655327, RefRangeEnd = 655329, XrefRangeStart = 655321, XrefRangeEnd = 655327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00050F94 File Offset: 0x0004F194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655340, RefRangeEnd = 655342, XrefRangeStart = 655329, XrefRangeEnd = 655340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00051010 File Offset: 0x0004F210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655342, XrefRangeEnd = 655350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000510A8 File Offset: 0x0004F2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655350, XrefRangeEnd = 655361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00051124 File Offset: 0x0004F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655361, XrefRangeEnd = 655369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000511BC File Offset: 0x0004F3BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 655417, RefRangeEnd = 655420, XrefRangeStart = 655369, XrefRangeEnd = 655417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00051228 File Offset: 0x0004F428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655420, XrefRangeEnd = 655422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00051278 File Offset: 0x0004F478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655422, XrefRangeEnd = 655426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes(List<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000512E4 File Offset: 0x0004F4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655426, XrefRangeEnd = 655432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes(List<UnityEngine.Rendering.SubMeshDescriptor> desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00051334 File Offset: 0x0004F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655432, XrefRangeEnd = 655436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetSubMeshes_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000513A8 File Offset: 0x0004F5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655436, XrefRangeEnd = 655437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetSubMeshes_Public_Void_NativeArray_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00051400 File Offset: 0x0004F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655437, XrefRangeEnd = 655454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBindposes(List<Matrix4x4> bindposes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bindposes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBindposes_Public_Void_List_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00051444 File Offset: 0x0004F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655454, XrefRangeEnd = 655473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBoneWeights(List<BoneWeight> boneWeights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneWeights);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBoneWeights_Public_Void_List_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00051488 File Offset: 0x0004F688
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x000514C8 File Offset: 0x0004F6C8
		public unsafe Il2CppStructArray<BoneWeight> boneWeights
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_boneWeights_Public_get_Il2CppStructArray_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BoneWeight>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_boneWeights_Public_set_Void_Il2CppStructArray_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0005150C File Offset: 0x0004F70C
		public unsafe SkinWeights skinWeightBufferLayout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_skinWeightBufferLayout_Public_get_SkinWeights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00051548 File Offset: 0x0004F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool keepVertexLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepVertexLayout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00051588 File Offset: 0x0004F788
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 655475, RefRangeEnd = 655488, XrefRangeStart = 655473, XrefRangeEnd = 655475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000515BC File Offset: 0x0004F7BC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 655500, RefRangeEnd = 655517, XrefRangeStart = 655488, XrefRangeEnd = 655500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000515F0 File Offset: 0x0004F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655517, XrefRangeEnd = 655529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00051624 File Offset: 0x0004F824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655529, XrefRangeEnd = 655541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00051658 File Offset: 0x0004F858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655541, XrefRangeEnd = 655553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00051698 File Offset: 0x0004F898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655553, XrefRangeEnd = 655565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000516D8 File Offset: 0x0004F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655565, XrefRangeEnd = 655577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00051718 File Offset: 0x0004F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655577, XrefRangeEnd = 655589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvSetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvAreaThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetric_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00051764 File Offset: 0x0004F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655589, XrefRangeEnd = 655601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvAreaThreshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateUVDistributionMetrics_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000517A4 File Offset: 0x0004F9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655605, RefRangeEnd = 655607, XrefRangeStart = 655601, XrefRangeEnd = 655605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000517D8 File Offset: 0x0004F9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 655611, RefRangeEnd = 655612, XrefRangeStart = 655607, XrefRangeEnd = 655611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshData(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markNoLongerReadable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00051818 File Offset: 0x0004FA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655612, XrefRangeEnd = 655624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Optimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0005184C File Offset: 0x0004FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655624, XrefRangeEnd = 655636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeIndexBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeIndexBuffers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00051880 File Offset: 0x0004FA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655636, XrefRangeEnd = 655648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeReorderVertexBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeReorderVertexBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000518B4 File Offset: 0x0004FAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655648, XrefRangeEnd = 655658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopology(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00051900 File Offset: 0x0004FB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMatrices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasLightmapData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0005196C File Offset: 0x0004FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655658, XrefRangeEnd = 655660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMatrices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000519CC File Offset: 0x0004FBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655660, XrefRangeEnd = 655662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00051A1C File Offset: 0x0004FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655662, XrefRangeEnd = 655664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00051A60 File Offset: 0x0004FC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655664, XrefRangeEnd = 655666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVertexAttribute_Injected(int index, out UnityEngine.Rendering.VertexAttributeDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttribute_Injected_Private_Void_Int32_byref_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00051AAC File Offset: 0x0004FCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655666, XrefRangeEnd = 655668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlendShapeOffsetInternal_Injected(int index, out BlendShape ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Injected_Private_Void_Int32_byref_BlendShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00051AF8 File Offset: 0x0004FCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655668, XrefRangeEnd = 655670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMesh_Injected(int index, ref UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00051B54 File Offset: 0x0004FD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655670, XrefRangeEnd = 655672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSubMesh_Injected(int index, out UnityEngine.Rendering.SubMeshDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655672, XrefRangeEnd = 655674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00051BE0 File Offset: 0x0004FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655674, XrefRangeEnd = 655676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_bounds_Injected(ref Bounds value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000073A7 File Offset: 0x000055A7
		public void SetVertexBufferParamsFromArray(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParamsFromArray(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000073B6 File Offset: 0x000055B6
		public void SetVertexBufferParams(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParams(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000073C5 File Offset: 0x000055C5
		public Mesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_FromInstanceID_Internal_Static_Mesh_Int32_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalIndexCount_Internal_UInt32_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIndexBufferData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParamsFromPtr_Private_Void_Int32_IntPtr_Int32_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributesAlloc_Private_Array_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributesArray_Private_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributesList_Private_Int32_List_1_VertexAttributeDescriptor_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeCountImpl_Private_Int32_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttribute_Public_VertexAttributeDescriptor_Int32_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesCountImpl_Private_UInt32_Int32_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesNonAllocImpl_Private_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesNonAllocImpl16_Private_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeDimension_Public_Int32_VertexAttribute_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferCount_Public_get_Int32_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferStride_Public_Int32_Int32_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeVertexBufferPtr_Public_IntPtr_Int32_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeIndexBufferPtr_Public_IntPtr_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeightBufferImpl_Private_GraphicsBuffer_Int32_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeBufferImpl_Private_GraphicsBuffer_Int32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_ClearBlendShapes_Public_Void_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeName_Public_String_Int32_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeIndex_Public_Int32_String_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeFrameCount_Public_Int32_Int32_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeFrameWeight_Public_Single_Int32_Int32_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeFrameVertices_Public_Void_Int32_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_AddBlendShapeFrame_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Private_BlendShape_Int32_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_HasBoneWeights_Private_Boolean_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeightsImpl_Private_Il2CppStructArray_1_BoneWeight_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_SetBoneWeightsImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_SetBoneWeights_Public_Void_NativeArray_1_Byte_NativeArray_1_BoneWeight1_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetBoneWeights_Private_Void_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBoneWeights_Public_NativeArray_1_BoneWeight1_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_GetBonesPerVertex_Public_NativeArray_1_Byte_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBoneWeightsArraySize_Private_Int32_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeightBufferLayoutInternal_Private_Int32_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBoneWeightsArray_Private_IntPtr_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_GetBonesPerVertexArray_Private_IntPtr_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_get_bindposeCount_Public_get_Int32_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_bindposes_Public_get_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_set_bindposes_Public_set_Void_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_GetBindposes_Public_NativeArray_1_Matrix4x4_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_GetBindposesArray_Private_IntPtr_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeightsNonAllocImpl_Private_Void_Il2CppStructArray_1_BoneWeight_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_GetBindposesNonAllocImpl_Private_Void_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromArray_Private_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_SetAllSubMeshesAtOnceFromNativeArray_Private_Void_IntPtr_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_MarkModified_Public_Void_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateUVDistributionMetricImpl_Private_Void_Int32_Single_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateUVDistributionMetricsImpl_Private_Void_Single_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_GetUVDistributionMetric_Public_Single_Int32_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeImpl_Private_Void_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeIndexBuffersImpl_Private_Void_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeReorderVertexBufferImpl_Private_Void_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_SetSizedNativeArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_uv3_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_set_uv3_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_uv4_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_set_uv4_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_get_uv5_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_set_uv5_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_get_uv6_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_set_uv6_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_get_uv7_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_set_uv7_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_get_uv8_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_set_uv8_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_get_colors_Public_get_Il2CppStructArray_1_Color_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_GetNormals_Public_Void_List_1_Vector3_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_GetTangents_Public_Void_List_1_Vector4_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_GetColors_Public_Void_List_1_Color32_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector2_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector3_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexAttributeCount_Public_get_Int32_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributes_Public_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributes_Public_Int32_List_1_VertexAttributeDescriptor_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_NativeArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Mesh_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_Il2CppReferenceArray_1_Mesh_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_AcquireReadOnlyMeshData_Public_Static_MeshDataArray_List_1_Mesh_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_AllocateWritableMeshData_Public_Static_MeshDataArray_Int32_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Mesh_MeshUpdateFlags_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAndDisposeWritableMeshData_Public_Static_Void_MeshDataArray_List_1_Mesh_MeshUpdateFlags_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeightBuffer_Public_GraphicsBuffer_SkinWeights_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_BlendShapeBufferLayout_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeBuffer_Public_GraphicsBuffer_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeBufferRange_Public_BlendShapeBufferRange_Int32_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Void_List_1_Int32_Int32_Boolean_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Void_List_1_UInt16_Int32_Boolean_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Boolean_Int32_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Boolean_Int32_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_UInt16_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_Il2CppStructArray_1_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_List_1_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_MeshUpdateFlags_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_GetBindposes_Public_Void_List_1_Matrix4x4_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneWeights_Public_Void_List_1_BoneWeight_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_get_boneWeights_Public_get_Il2CppStructArray_1_BoneWeight_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_set_boneWeights_Public_set_Void_Il2CppStructArray_1_BoneWeight_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_get_skinWeightBufferLayout_Public_get_SkinWeights_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangents_Public_Void_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateUVDistributionMetric_Public_Void_Int32_Single_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateUVDistributionMetrics_Public_Void_Single_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamic_Public_Void_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Public_Void_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeIndexBuffers_Public_Void_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeReorderVertexBuffer_Public_Void_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttribute_Injected_Private_Void_Int32_byref_VertexAttributeDescriptor_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeOffsetInternal_Injected_Private_Void_Int32_byref_BlendShape_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x0200063A RID: 1594
		[StructLayout(2)]
		public struct MeshData
		{
			// Token: 0x06003572 RID: 13682 RVA: 0x00013D7D File Offset: 0x00011F7D
			// Note: this type is marked as 'beforefieldinit'.
			static MeshData()
			{
				Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "MeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr);
				Mesh.MeshData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, "m_Ptr");
			}

			// Token: 0x06003573 RID: 13683 RVA: 0x00013DB1 File Offset: 0x00011FB1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BC3 RID: 11203
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04002BC4 RID: 11204
			[FieldOffset(0)]
			public IntPtr m_Ptr;
		}

		// Token: 0x0200063B RID: 1595
		[DefaultMember("Item")]
		[StructLayout(2)]
		public struct MeshDataArray
		{
			// Token: 0x06003574 RID: 13684 RVA: 0x000B9200 File Offset: 0x000B7400
			// Note: this type is marked as 'beforefieldinit'.
			static MeshDataArray()
			{
				Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "MeshDataArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr);
				Mesh.MeshDataArray.NativeFieldInfoPtr_m_Ptrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, "m_Ptrs");
				Mesh.MeshDataArray.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, "m_Length");
				Mesh.MeshDataArray.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Private_Static_Void_Mesh_ptr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665513);
				Mesh.MeshDataArray.NativeMethodInfoPtr_AcquireReadOnlyMeshDatas_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665514);
				Mesh.MeshDataArray.NativeMethodInfoPtr_ReleaseMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665515);
				Mesh.MeshDataArray.NativeMethodInfoPtr_CreateNewMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665516);
				Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshesImpl_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665517);
				Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshImpl_Private_Static_Void_Mesh_IntPtr_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665518);
				Mesh.MeshDataArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665519);
				Mesh.MeshDataArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665520);
				Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshAndDispose_Internal_Void_Mesh_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665521);
				Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshesAndDispose_Internal_Void_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665522);
				Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665523);
				Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Mesh_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665524);
				Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, 100665525);
			}

			// Token: 0x06003575 RID: 13685 RVA: 0x000B9358 File Offset: 0x000B7558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653701, XrefRangeEnd = 653703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = datas;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_AcquireReadOnlyMeshData_Private_Static_Void_Mesh_ptr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003576 RID: 13686 RVA: 0x000B939C File Offset: 0x000B759C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653703, XrefRangeEnd = 653705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void AcquireReadOnlyMeshDatas(Il2CppReferenceArray<Mesh> meshes, IntPtr* datas, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = datas;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_AcquireReadOnlyMeshDatas_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003577 RID: 13687 RVA: 0x000B93F0 File Offset: 0x000B75F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653705, XrefRangeEnd = 653707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ReleaseMeshDatas(IntPtr* datas, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = datas;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_ReleaseMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003578 RID: 13688 RVA: 0x000B9430 File Offset: 0x000B7630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653707, XrefRangeEnd = 653709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CreateNewMeshDatas(IntPtr* datas, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = datas;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_CreateNewMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003579 RID: 13689 RVA: 0x000B9470 File Offset: 0x000B7670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653709, XrefRangeEnd = 653711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ApplyToMeshesImpl(Il2CppReferenceArray<Mesh> meshes, IntPtr* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = datas;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshesImpl_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_MeshUpdateFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357A RID: 13690 RVA: 0x000B94D0 File Offset: 0x000B76D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653711, XrefRangeEnd = 653713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ApplyToMeshImpl(Mesh mesh, IntPtr data, UnityEngine.Rendering.MeshUpdateFlags flags)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshImpl_Private_Static_Void_Mesh_IntPtr_MeshUpdateFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x0600357B RID: 13691 RVA: 0x000B9524 File Offset: 0x000B7724
			public unsafe int Length
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600357C RID: 13692 RVA: 0x000B9554 File Offset: 0x000B7754
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653718, RefRangeEnd = 653720, XrefRangeStart = 653713, XrefRangeEnd = 653718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357D RID: 13693 RVA: 0x000B957C File Offset: 0x000B777C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653736, RefRangeEnd = 653737, XrefRangeStart = 653720, XrefRangeEnd = 653736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMeshAndDispose(Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshAndDispose_Internal_Void_Mesh_MeshUpdateFlags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357E RID: 13694 RVA: 0x000B95C0 File Offset: 0x000B77C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653769, RefRangeEnd = 653771, XrefRangeStart = 653737, XrefRangeEnd = 653769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMeshesAndDispose(Il2CppReferenceArray<Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr_ApplyToMeshesAndDispose_Internal_Void_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357F RID: 13695 RVA: 0x000B9604 File Offset: 0x000B7804
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653804, RefRangeEnd = 653805, XrefRangeStart = 653771, XrefRangeEnd = 653804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshDataArray(Mesh mesh, bool checkReadWrite = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkReadWrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Mesh_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003580 RID: 13696 RVA: 0x000B9648 File Offset: 0x000B7848
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653853, RefRangeEnd = 653855, XrefRangeStart = 653805, XrefRangeEnd = 653853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshDataArray(Il2CppReferenceArray<Mesh> meshes, int meshesCount, bool checkReadWrite = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshesCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkReadWrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Mesh_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003581 RID: 13697 RVA: 0x000B969C File Offset: 0x000B789C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653871, RefRangeEnd = 653873, XrefRangeStart = 653855, XrefRangeEnd = 653871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshDataArray(int meshesCount)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref meshesCount;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MeshDataArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003582 RID: 13698 RVA: 0x00013DC3 File Offset: 0x00011FC3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh.MeshDataArray>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BC5 RID: 11205
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptrs;

			// Token: 0x04002BC6 RID: 11206
			private static readonly IntPtr NativeFieldInfoPtr_m_Length;

			// Token: 0x04002BC7 RID: 11207
			private static readonly IntPtr NativeMethodInfoPtr_AcquireReadOnlyMeshData_Private_Static_Void_Mesh_ptr_IntPtr_0;

			// Token: 0x04002BC8 RID: 11208
			private static readonly IntPtr NativeMethodInfoPtr_AcquireReadOnlyMeshDatas_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_0;

			// Token: 0x04002BC9 RID: 11209
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0;

			// Token: 0x04002BCA RID: 11210
			private static readonly IntPtr NativeMethodInfoPtr_CreateNewMeshDatas_Private_Static_Void_ptr_IntPtr_Int32_0;

			// Token: 0x04002BCB RID: 11211
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMeshesImpl_Private_Static_Void_Il2CppReferenceArray_1_Mesh_ptr_IntPtr_Int32_MeshUpdateFlags_0;

			// Token: 0x04002BCC RID: 11212
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMeshImpl_Private_Static_Void_Mesh_IntPtr_MeshUpdateFlags_0;

			// Token: 0x04002BCD RID: 11213
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

			// Token: 0x04002BCE RID: 11214
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002BCF RID: 11215
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMeshAndDispose_Internal_Void_Mesh_MeshUpdateFlags_0;

			// Token: 0x04002BD0 RID: 11216
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMeshesAndDispose_Internal_Void_Il2CppReferenceArray_1_Mesh_MeshUpdateFlags_0;

			// Token: 0x04002BD1 RID: 11217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Mesh_Boolean_0;

			// Token: 0x04002BD2 RID: 11218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Mesh_Int32_Boolean_0;

			// Token: 0x04002BD3 RID: 11219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04002BD4 RID: 11220
			[FieldOffset(0)]
			public IntPtr m_Ptrs;

			// Token: 0x04002BD5 RID: 11221
			[FieldOffset(8)]
			public int m_Length;
		}

		// Token: 0x0200063C RID: 1596
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>
		{
			// Token: 0x04002BD6 RID: 11222
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063D RID: 1597
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>
		{
			// Token: 0x04002BD7 RID: 11223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063E RID: 1598
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BD8 RID: 11224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200063F RID: 1599
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BD9 RID: 11225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000640 RID: 1600
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BDA RID: 11226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000641 RID: 1601
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BDB RID: 11227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000642 RID: 1602
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>
		{
			// Token: 0x04002BDC RID: 11228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000643 RID: 1603
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>
		{
			// Token: 0x04002BDD RID: 11229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000644 RID: 1604
		private sealed class MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BDE RID: 11230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000645 RID: 1605
		private sealed class MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002BDF RID: 11231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000646 RID: 1606
		private sealed class MethodInfoStoreGeneric_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BE0 RID: 11232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000647 RID: 1607
		private sealed class MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BE1 RID: 11233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000648 RID: 1608
		private sealed class MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002BE2 RID: 11234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000649 RID: 1609
		private sealed class MethodInfoStoreGeneric_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BE3 RID: 11235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064A RID: 1610
		private sealed class MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BE4 RID: 11236
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064B RID: 1611
		private sealed class MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002BE5 RID: 11237
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064C RID: 1612
		private sealed class MethodInfoStoreGeneric_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BE6 RID: 11238
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064D RID: 1613
		private sealed class MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BE7 RID: 11239
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064E RID: 1614
		private sealed class MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002BE8 RID: 11240
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064F RID: 1615
		private sealed class MethodInfoStoreGeneric_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BE9 RID: 11241
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000650 RID: 1616
		private sealed class MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BEA RID: 11242
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000651 RID: 1617
		private sealed class MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BEB RID: 11243
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000652 RID: 1618
		private sealed class MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002BEC RID: 11244
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000653 RID: 1619
		private sealed class MethodInfoStoreGeneric_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BED RID: 11245
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000654 RID: 1620
		private sealed class MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>
		{
			// Token: 0x04002BEE RID: 11246
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000655 RID: 1621
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BEF RID: 11247
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000656 RID: 1622
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF0 RID: 11248
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000657 RID: 1623
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF1 RID: 11249
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000658 RID: 1624
		private sealed class MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF2 RID: 11250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000659 RID: 1625
		private sealed class MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF3 RID: 11251
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065A RID: 1626
		private sealed class MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF4 RID: 11252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_List_1_T_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065B RID: 1627
		private sealed class MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0<T>
		{
			// Token: 0x04002BF5 RID: 11253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065C RID: 1628
		private sealed class MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0<T>
		{
			// Token: 0x04002BF6 RID: 11254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065D RID: 1629
		private sealed class MethodInfoStoreGeneric_SetSubMeshes_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF7 RID: 11255
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065E RID: 1630
		private sealed class MethodInfoStoreGeneric_SetSubMeshes_Public_Void_NativeArray_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002BF8 RID: 11256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetSubMeshes_Public_Void_NativeArray_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

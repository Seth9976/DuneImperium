using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A6 RID: 166
	public sealed class Shader : Object
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		// Note: this type is marked as 'beforefieldinit'.
		static Shader()
		{
			Il2CppClassPointerStore<Shader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Shader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shader>.NativeClassPtr);
			Shader.NativeMethodInfoPtr_get_globalShaderHardwareTier_Public_Static_get_ShaderHardwareTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664621);
			Shader.NativeMethodInfoPtr_set_globalShaderHardwareTier_Public_Static_set_Void_ShaderHardwareTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664622);
			Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664623);
			Shader.NativeMethodInfoPtr_FindBuiltin_Internal_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664624);
			Shader.NativeMethodInfoPtr_get_maximumChunksOverride_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664625);
			Shader.NativeMethodInfoPtr_set_maximumChunksOverride_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664626);
			Shader.NativeMethodInfoPtr_get_maximumLOD_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664627);
			Shader.NativeMethodInfoPtr_set_maximumLOD_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664628);
			Shader.NativeMethodInfoPtr_get_globalMaximumLOD_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664629);
			Shader.NativeMethodInfoPtr_set_globalMaximumLOD_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664630);
			Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664631);
			Shader.NativeMethodInfoPtr_get_globalRenderPipeline_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664632);
			Shader.NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664633);
			Shader.NativeMethodInfoPtr_get_enabledGlobalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664634);
			Shader.NativeMethodInfoPtr_get_globalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664635);
			Shader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664636);
			Shader.NativeMethodInfoPtr_GetEnabledGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664637);
			Shader.NativeMethodInfoPtr_GetAllGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664638);
			Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664639);
			Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664640);
			Shader.NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664641);
			Shader.NativeMethodInfoPtr_EnableKeywordFast_Internal_Static_Void_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664642);
			Shader.NativeMethodInfoPtr_DisableKeywordFast_Internal_Static_Void_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664643);
			Shader.NativeMethodInfoPtr_SetKeywordFast_Internal_Static_Void_GlobalKeyword_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664644);
			Shader.NativeMethodInfoPtr_IsKeywordEnabledFast_Internal_Static_Boolean_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664645);
			Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664646);
			Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664647);
			Shader.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_byref_GlobalKeyword_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664648);
			Shader.NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664649);
			Shader.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664650);
			Shader.NativeMethodInfoPtr_get_disableBatching_Internal_get_DisableBatchingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664651);
			Shader.NativeMethodInfoPtr_WarmupAllShaders_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664652);
			Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664653);
			Shader.NativeMethodInfoPtr_IDToTag_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664654);
			Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664655);
			Shader.NativeMethodInfoPtr_GetDependency_Public_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664656);
			Shader.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664657);
			Shader.NativeMethodInfoPtr_get_subshaderCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664658);
			Shader.NativeMethodInfoPtr_GetPassCountInSubshader_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664659);
			Shader.NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664660);
			Shader.NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664661);
			Shader.NativeMethodInfoPtr_FindSubshaderTagValue_Public_ShaderTagId_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664662);
			Shader.NativeMethodInfoPtr_Internal_FindPassTagValue_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664663);
			Shader.NativeMethodInfoPtr_Internal_FindPassTagValueInSubShader_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664664);
			Shader.NativeMethodInfoPtr_Internal_FindSubshaderTagValue_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664665);
			Shader.NativeMethodInfoPtr_SetGlobalIntImpl_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664666);
			Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664667);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664668);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixImpl_Private_Static_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664669);
			Shader.NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664670);
			Shader.NativeMethodInfoPtr_SetGlobalRenderTextureImpl_Private_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664671);
			Shader.NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664672);
			Shader.NativeMethodInfoPtr_SetGlobalGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664673);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664674);
			Shader.NativeMethodInfoPtr_SetGlobalConstantGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664675);
			Shader.NativeMethodInfoPtr_GetGlobalIntImpl_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664676);
			Shader.NativeMethodInfoPtr_GetGlobalFloatImpl_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664677);
			Shader.NativeMethodInfoPtr_GetGlobalVectorImpl_Private_Static_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664678);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixImpl_Private_Static_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664679);
			Shader.NativeMethodInfoPtr_GetGlobalTextureImpl_Private_Static_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664680);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664681);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664682);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664683);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArrayImpl_Private_Static_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664684);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArrayImpl_Private_Static_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664685);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArrayImpl_Private_Static_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664686);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArrayCountImpl_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664687);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArrayCountImpl_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664688);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArrayCountImpl_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664689);
			Shader.NativeMethodInfoPtr_ExtractGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664690);
			Shader.NativeMethodInfoPtr_ExtractGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664691);
			Shader.NativeMethodInfoPtr_ExtractGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664692);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664693);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664694);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664695);
			Shader.NativeMethodInfoPtr_ExtractGlobalFloatArray_Private_Static_Void_Int32_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664696);
			Shader.NativeMethodInfoPtr_ExtractGlobalVectorArray_Private_Static_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664697);
			Shader.NativeMethodInfoPtr_ExtractGlobalMatrixArray_Private_Static_Void_Int32_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664698);
			Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664699);
			Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664700);
			Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664701);
			Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664702);
			Shader.NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664703);
			Shader.NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664704);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664705);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664706);
			Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664707);
			Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664708);
			Shader.NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664709);
			Shader.NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664710);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664711);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664712);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664713);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664714);
			Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664715);
			Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664716);
			Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664717);
			Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664718);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664719);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664720);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_GraphicsBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664721);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664722);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664723);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664724);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664725);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664726);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664727);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664728);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664729);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664730);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664731);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664732);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664733);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664734);
			Shader.NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664735);
			Shader.NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664736);
			Shader.NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664737);
			Shader.NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664738);
			Shader.NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664739);
			Shader.NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664740);
			Shader.NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664741);
			Shader.NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664742);
			Shader.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664743);
			Shader.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664744);
			Shader.NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664745);
			Shader.NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664746);
			Shader.NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664747);
			Shader.NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664748);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664749);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664750);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664751);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664752);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664753);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664754);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664755);
			Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664756);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664757);
			Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664758);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664759);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664760);
			Shader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664761);
			Shader.NativeMethodInfoPtr_GetPropertyName_Private_Static_String_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664762);
			Shader.NativeMethodInfoPtr_GetPropertyNameId_Private_Static_Int32_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664763);
			Shader.NativeMethodInfoPtr_GetPropertyType_Private_Static_ShaderPropertyType_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664764);
			Shader.NativeMethodInfoPtr_GetPropertyDescription_Private_Static_String_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664765);
			Shader.NativeMethodInfoPtr_GetPropertyFlags_Private_Static_ShaderPropertyFlags_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664766);
			Shader.NativeMethodInfoPtr_GetPropertyAttributes_Private_Static_Il2CppStringArray_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664767);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultIntValue_Private_Static_Int32_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664768);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultValue_Private_Static_Vector4_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664769);
			Shader.NativeMethodInfoPtr_GetPropertyTextureDimension_Private_Static_TextureDimension_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664770);
			Shader.NativeMethodInfoPtr_GetPropertyTextureDefaultName_Private_Static_String_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664771);
			Shader.NativeMethodInfoPtr_FindTextureStackImpl_Private_Static_Boolean_Shader_Int32_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664772);
			Shader.NativeMethodInfoPtr_CheckPropertyIndex_Private_Static_Void_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664773);
			Shader.NativeMethodInfoPtr_GetPropertyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664774);
			Shader.NativeMethodInfoPtr_FindPropertyIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664775);
			Shader.NativeMethodInfoPtr_GetPropertyName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664776);
			Shader.NativeMethodInfoPtr_GetPropertyNameId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664777);
			Shader.NativeMethodInfoPtr_GetPropertyType_Public_ShaderPropertyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664778);
			Shader.NativeMethodInfoPtr_GetPropertyDescription_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664779);
			Shader.NativeMethodInfoPtr_GetPropertyFlags_Public_ShaderPropertyFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664780);
			Shader.NativeMethodInfoPtr_GetPropertyAttributes_Public_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664781);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultFloatValue_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664782);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultVectorValue_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664783);
			Shader.NativeMethodInfoPtr_GetPropertyRangeLimits_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664784);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultIntValue_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664785);
			Shader.NativeMethodInfoPtr_GetPropertyTextureDimension_Public_TextureDimension_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664786);
			Shader.NativeMethodInfoPtr_GetPropertyTextureDefaultName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664787);
			Shader.NativeMethodInfoPtr_FindTextureStack_Public_Boolean_Int32_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664788);
			Shader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664789);
			Shader.NativeMethodInfoPtr_EnableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664790);
			Shader.NativeMethodInfoPtr_DisableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664791);
			Shader.NativeMethodInfoPtr_SetKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664792);
			Shader.NativeMethodInfoPtr_IsKeywordEnabledFast_Injected_Private_Static_Boolean_byref_GlobalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664793);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664794);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664795);
			Shader.NativeMethodInfoPtr_GetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664796);
			Shader.NativeMethodInfoPtr_GetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664797);
			Shader.NativeMethodInfoPtr_GetPropertyDefaultValue_Injected_Private_Static_Void_Shader_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664798);
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0003CD00 File Offset: 0x0003AF00
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0003CD30 File Offset: 0x0003AF30
		public unsafe static UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650944, XrefRangeEnd = 650949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_globalShaderHardwareTier_Public_Static_get_ShaderHardwareTier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650949, XrefRangeEnd = 650954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_globalShaderHardwareTier_Public_Static_set_Void_ShaderHardwareTier_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0003CD64 File Offset: 0x0003AF64
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 650959, RefRangeEnd = 650988, XrefRangeStart = 650954, XrefRangeEnd = 650959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader Find(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650988, XrefRangeEnd = 650990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader FindBuiltin(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindBuiltin_Internal_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0003CDEC File Offset: 0x0003AFEC
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0003CE1C File Offset: 0x0003B01C
		public unsafe static int maximumChunksOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650990, XrefRangeEnd = 650992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_maximumChunksOverride_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650992, XrefRangeEnd = 650994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_maximumChunksOverride_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0003CE50 File Offset: 0x0003B050
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x0003CE8C File Offset: 0x0003B08C
		public unsafe int maximumLOD
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650994, XrefRangeEnd = 650996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_maximumLOD_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650996, XrefRangeEnd = 650998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_maximumLOD_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003CECC File Offset: 0x0003B0CC
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0003CEFC File Offset: 0x0003B0FC
		public unsafe static int globalMaximumLOD
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650998, XrefRangeEnd = 651000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_globalMaximumLOD_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651000, XrefRangeEnd = 651002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_globalMaximumLOD_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003CF30 File Offset: 0x0003B130
		public unsafe bool isSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 651004, RefRangeEnd = 651005, XrefRangeStart = 651002, XrefRangeEnd = 651004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003CF6C File Offset: 0x0003B16C
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0003CF98 File Offset: 0x0003B198
		public unsafe static string globalRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651005, XrefRangeEnd = 651007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_globalRenderPipeline_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 651009, RefRangeEnd = 651011, XrefRangeStart = 651007, XrefRangeEnd = 651009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		public unsafe static Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword> enabledGlobalKeywords
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651011, XrefRangeEnd = 651013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_enabledGlobalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword>>(intPtr3) : null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0003D004 File Offset: 0x0003B204
		public unsafe static Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword> globalKeywords
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651013, XrefRangeEnd = 651015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_globalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword>>(intPtr3) : null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003D038 File Offset: 0x0003B238
		public unsafe UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 651017, RefRangeEnd = 651018, XrefRangeStart = 651015, XrefRangeEnd = 651017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0003D074 File Offset: 0x0003B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword> GetEnabledGlobalKeywords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetEnabledGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword>>(intPtr3) : null;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0003D0A8 File Offset: 0x0003B2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword> GetAllGlobalKeywords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetAllGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.GlobalKeyword>>(intPtr3) : null;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003D0DC File Offset: 0x0003B2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 651020, RefRangeEnd = 651021, XrefRangeStart = 651018, XrefRangeEnd = 651020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeyword(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0003D114 File Offset: 0x0003B314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 651023, RefRangeEnd = 651024, XrefRangeStart = 651021, XrefRangeEnd = 651023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeyword(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0003D14C File Offset: 0x0003B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651024, XrefRangeEnd = 651026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordEnabled(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0003D190 File Offset: 0x0003B390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651026, XrefRangeEnd = 651028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeywordFast_Internal_Static_Void_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003D1CC File Offset: 0x0003B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651028, XrefRangeEnd = 651030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeywordFast_Internal_Static_Void_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003D208 File Offset: 0x0003B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651030, XrefRangeEnd = 651032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetKeywordFast_Internal_Static_Void_GlobalKeyword_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003D254 File Offset: 0x0003B454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651032, XrefRangeEnd = 651034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_IsKeywordEnabledFast_Internal_Static_Boolean_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003D29C File Offset: 0x0003B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651034, XrefRangeEnd = 651036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeyword([In] ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651036, XrefRangeEnd = 651038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeyword([In] ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003D30C File Offset: 0x0003B50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651038, XrefRangeEnd = 651040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyword([In] ref UnityEngine.Rendering.GlobalKeyword keyword, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_byref_GlobalKeyword_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003D354 File Offset: 0x0003B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651040, XrefRangeEnd = 651042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordEnabled([In] ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0003D398 File Offset: 0x0003B598
		public unsafe int renderQueue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651042, XrefRangeEnd = 651044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003D3D4 File Offset: 0x0003B5D4
		public unsafe DisableBatchingType disableBatching
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651044, XrefRangeEnd = 651046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_disableBatching_Internal_get_DisableBatchingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003D410 File Offset: 0x0003B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651046, XrefRangeEnd = 651048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarmupAllShaders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_WarmupAllShaders_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003D438 File Offset: 0x0003B638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651050, RefRangeEnd = 651052, XrefRangeStart = 651048, XrefRangeEnd = 651050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TagToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003D47C File Offset: 0x0003B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651052, XrefRangeEnd = 651054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IDToTag(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_IDToTag_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
		[CallerCount(174)]
		[CachedScanResults(RefRangeStart = 651056, RefRangeEnd = 651230, XrefRangeStart = 651054, XrefRangeEnd = 651056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropertyToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003D4F8 File Offset: 0x0003B6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651230, XrefRangeEnd = 651232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shader GetDependency(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetDependency_Public_Shader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0003D548 File Offset: 0x0003B748
		public unsafe int passCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 651234, RefRangeEnd = 651236, XrefRangeStart = 651232, XrefRangeEnd = 651234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003D584 File Offset: 0x0003B784
		public unsafe int subshaderCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651236, XrefRangeEnd = 651238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_subshaderCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651238, XrefRangeEnd = 651240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPassCountInSubshader(int subshaderIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subshaderIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPassCountInSubshader_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003D60C File Offset: 0x0003B80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651240, XrefRangeEnd = 651246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003D664 File Offset: 0x0003B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651246, XrefRangeEnd = 651254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subshaderIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_Int32_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651254, XrefRangeEnd = 651260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subshaderIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindSubshaderTagValue_Public_ShaderTagId_Int32_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003D724 File Offset: 0x0003B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651260, XrefRangeEnd = 651262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_FindPassTagValue(int passIndex, int tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Internal_FindPassTagValue_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003D77C File Offset: 0x0003B97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651262, XrefRangeEnd = 651264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subShaderIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Internal_FindPassTagValueInSubShader_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651264, XrefRangeEnd = 651266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subShaderIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Internal_FindSubshaderTagValue_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003D83C File Offset: 0x0003BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651266, XrefRangeEnd = 651268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalIntImpl(int name, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalIntImpl_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003D87C File Offset: 0x0003BA7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651270, RefRangeEnd = 651272, XrefRangeStart = 651268, XrefRangeEnd = 651270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatImpl(int name, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003D8BC File Offset: 0x0003BABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651272, XrefRangeEnd = 651274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl(int name, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651274, XrefRangeEnd = 651276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixImpl_Private_Static_Void_Int32_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003D93C File Offset: 0x0003BB3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651278, RefRangeEnd = 651280, XrefRangeStart = 651276, XrefRangeEnd = 651278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTextureImpl(int name, Texture value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003D980 File Offset: 0x0003BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651280, XrefRangeEnd = 651282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalRenderTextureImpl_Private_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651282, XrefRangeEnd = 651284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalBufferImpl(int name, ComputeBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003DA18 File Offset: 0x0003BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651284, XrefRangeEnd = 651286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003DA5C File Offset: 0x0003BC5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 651288, RefRangeEnd = 651291, XrefRangeStart = 651286, XrefRangeEnd = 651288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003DABC File Offset: 0x0003BCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651291, XrefRangeEnd = 651293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651293, XrefRangeEnd = 651295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalIntImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalIntImpl_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003DB5C File Offset: 0x0003BD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651295, XrefRangeEnd = 651297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetGlobalFloatImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatImpl_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003DB9C File Offset: 0x0003BD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651297, XrefRangeEnd = 651299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetGlobalVectorImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorImpl_Private_Static_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003DBDC File Offset: 0x0003BDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651299, XrefRangeEnd = 651301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGlobalMatrixImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixImpl_Private_Static_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003DC1C File Offset: 0x0003BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651301, XrefRangeEnd = 651303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture GetGlobalTextureImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalTextureImpl_Private_Static_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651303, XrefRangeEnd = 651305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0003DCB0 File Offset: 0x0003BEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651305, XrefRangeEnd = 651307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0003DD04 File Offset: 0x0003BF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651307, XrefRangeEnd = 651309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0003DD58 File Offset: 0x0003BF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651309, XrefRangeEnd = 651311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> GetGlobalFloatArrayImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArrayImpl_Private_Static_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0003DD98 File Offset: 0x0003BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651311, XrefRangeEnd = 651313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector4> GetGlobalVectorArrayImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArrayImpl_Private_Static_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0003DDD8 File Offset: 0x0003BFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651313, XrefRangeEnd = 651315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArrayImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArrayImpl_Private_Static_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0003DE18 File Offset: 0x0003C018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651315, XrefRangeEnd = 651317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalFloatArrayCountImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArrayCountImpl_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0003DE58 File Offset: 0x0003C058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651317, XrefRangeEnd = 651319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalVectorArrayCountImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArrayCountImpl_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0003DE98 File Offset: 0x0003C098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651319, XrefRangeEnd = 651321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalMatrixArrayCountImpl(int name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArrayCountImpl_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651321, XrefRangeEnd = 651323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*val = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0003DF2C File Offset: 0x0003C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651323, XrefRangeEnd = 651325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*val = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector4>(intPtr4));
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0003DF80 File Offset: 0x0003C180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651325, XrefRangeEnd = 651327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*val = ((intPtr4 == 0) ? null : new Il2CppStructArray<Matrix4x4>(intPtr4));
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 651347, RefRangeEnd = 651351, XrefRangeStart = 651327, XrefRangeEnd = 651347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0003E028 File Offset: 0x0003C228
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 651371, RefRangeEnd = 651375, XrefRangeStart = 651351, XrefRangeEnd = 651371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0003E07C File Offset: 0x0003C27C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 651395, RefRangeEnd = 651399, XrefRangeStart = 651375, XrefRangeEnd = 651395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0003E0D0 File Offset: 0x0003C2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651411, RefRangeEnd = 651413, XrefRangeStart = 651399, XrefRangeEnd = 651411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalFloatArray(int name, List<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalFloatArray_Private_Static_Void_Int32_List_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0003E114 File Offset: 0x0003C314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651425, RefRangeEnd = 651427, XrefRangeStart = 651413, XrefRangeEnd = 651425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalVectorArray(int name, List<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalVectorArray_Private_Static_Void_Int32_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0003E158 File Offset: 0x0003C358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651439, RefRangeEnd = 651441, XrefRangeStart = 651427, XrefRangeEnd = 651439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_ExtractGlobalMatrixArray_Private_Static_Void_Int32_List_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0003E19C File Offset: 0x0003C39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651441, XrefRangeEnd = 651445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInt(string name, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651445, XrefRangeEnd = 651447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInt(int nameID, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0003E220 File Offset: 0x0003C420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651447, XrefRangeEnd = 651451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloat(string name, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0003E264 File Offset: 0x0003C464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651270, RefRangeEnd = 651272, XrefRangeStart = 651270, XrefRangeEnd = 651272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloat(int nameID, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651451, XrefRangeEnd = 651455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInteger(string name, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003E2E8 File Offset: 0x0003C4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInteger(int nameID, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0003E328 File Offset: 0x0003C528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651455, XrefRangeEnd = 651459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(string name, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0003E36C File Offset: 0x0003C56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651459, XrefRangeEnd = 651461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(int nameID, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003E3AC File Offset: 0x0003C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651461, XrefRangeEnd = 651465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalColor(string name, Color value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 651467, RefRangeEnd = 651468, XrefRangeStart = 651465, XrefRangeEnd = 651467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalColor(int nameID, Color value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0003E430 File Offset: 0x0003C630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651468, XrefRangeEnd = 651472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_String_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0003E474 File Offset: 0x0003C674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651472, XrefRangeEnd = 651474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_Int32_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 651478, RefRangeEnd = 651479, XrefRangeStart = 651474, XrefRangeEnd = 651478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(string name, Texture value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0003E4FC File Offset: 0x0003C6FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 651278, RefRangeEnd = 651280, XrefRangeStart = 651278, XrefRangeEnd = 651280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(int nameID, Texture value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0003E540 File Offset: 0x0003C740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651479, XrefRangeEnd = 651483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_RenderTexture_RenderTextureSubElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0003E598 File Offset: 0x0003C798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0003E5EC File Offset: 0x0003C7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651483, XrefRangeEnd = 651487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0003E634 File Offset: 0x0003C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003E678 File Offset: 0x0003C878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651487, XrefRangeEnd = 651491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0003E6C0 File Offset: 0x0003C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0003E704 File Offset: 0x0003C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651491, XrefRangeEnd = 651495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_ComputeBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0003E768 File Offset: 0x0003C968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 651288, RefRangeEnd = 651291, XrefRangeStart = 651288, XrefRangeEnd = 651291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651495, XrefRangeEnd = 651499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_GraphicsBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0003E82C File Offset: 0x0003CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0003E88C File Offset: 0x0003CA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651499, XrefRangeEnd = 651507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(string name, List<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0003E8D4 File Offset: 0x0003CAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651507, XrefRangeEnd = 651513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(int nameID, List<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003E918 File Offset: 0x0003CB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651513, XrefRangeEnd = 651517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(string name, Il2CppStructArray<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003E960 File Offset: 0x0003CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651517, XrefRangeEnd = 651519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651519, XrefRangeEnd = 651527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(string name, List<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0003E9EC File Offset: 0x0003CBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651527, XrefRangeEnd = 651533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003EA30 File Offset: 0x0003CC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651533, XrefRangeEnd = 651537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_Il2CppStructArray_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0003EA78 File Offset: 0x0003CC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651537, XrefRangeEnd = 651539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003EABC File Offset: 0x0003CCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651539, XrefRangeEnd = 651547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003EB04 File Offset: 0x0003CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651547, XrefRangeEnd = 651553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003EB48 File Offset: 0x0003CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651553, XrefRangeEnd = 651557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_Il2CppStructArray_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003EB90 File Offset: 0x0003CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651557, XrefRangeEnd = 651559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003EBD4 File Offset: 0x0003CDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651559, XrefRangeEnd = 651563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalInt(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003EC18 File Offset: 0x0003CE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651563, XrefRangeEnd = 651565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalInt(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003EC58 File Offset: 0x0003CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651565, XrefRangeEnd = 651569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetGlobalFloat(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetGlobalFloat(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003ECDC File Offset: 0x0003CEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651569, XrefRangeEnd = 651573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalInteger(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003ED20 File Offset: 0x0003CF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalInteger(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0003ED60 File Offset: 0x0003CF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651573, XrefRangeEnd = 651577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetGlobalVector(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0003EDA4 File Offset: 0x0003CFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651577, XrefRangeEnd = 651579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetGlobalVector(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651579, XrefRangeEnd = 651583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetGlobalColor(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0003EE28 File Offset: 0x0003D028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651583, XrefRangeEnd = 651585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetGlobalColor(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003EE68 File Offset: 0x0003D068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651585, XrefRangeEnd = 651589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGlobalMatrix(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0003EEAC File Offset: 0x0003D0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651589, XrefRangeEnd = 651591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGlobalMatrix(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0003EEEC File Offset: 0x0003D0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651591, XrefRangeEnd = 651595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture GetGlobalTexture(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0003EF30 File Offset: 0x0003D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture GetGlobalTexture(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0003EF70 File Offset: 0x0003D170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651595, XrefRangeEnd = 651601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> GetGlobalFloatArray(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0003EFB4 File Offset: 0x0003D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651601, XrefRangeEnd = 651605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> GetGlobalFloatArray(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0003EFF4 File Offset: 0x0003D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651605, XrefRangeEnd = 651611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector4> GetGlobalVectorArray(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0003F038 File Offset: 0x0003D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651611, XrefRangeEnd = 651615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector4> GetGlobalVectorArray(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0003F078 File Offset: 0x0003D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651615, XrefRangeEnd = 651621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0003F0BC File Offset: 0x0003D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651621, XrefRangeEnd = 651625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651625, XrefRangeEnd = 651628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalFloatArray(string name, List<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0003F144 File Offset: 0x0003D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651628, XrefRangeEnd = 651629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalFloatArray(int nameID, List<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003F188 File Offset: 0x0003D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651629, XrefRangeEnd = 651632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalVectorArray(string name, List<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0003F1D0 File Offset: 0x0003D3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651632, XrefRangeEnd = 651633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003F214 File Offset: 0x0003D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651633, XrefRangeEnd = 651636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0003F25C File Offset: 0x0003D45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651636, XrefRangeEnd = 651637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651637, XrefRangeEnd = 651641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651641, XrefRangeEnd = 651643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPropertyName(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyName_Private_Static_String_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0003F328 File Offset: 0x0003D528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651643, XrefRangeEnd = 651645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPropertyNameId(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyNameId_Private_Static_Int32_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003F378 File Offset: 0x0003D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651645, XrefRangeEnd = 651647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyType_Private_Static_ShaderPropertyType_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0003F3C8 File Offset: 0x0003D5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651647, XrefRangeEnd = 651649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPropertyDescription(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDescription_Private_Static_String_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003F414 File Offset: 0x0003D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651649, XrefRangeEnd = 651651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyFlags_Private_Static_ShaderPropertyFlags_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0003F464 File Offset: 0x0003D664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651651, XrefRangeEnd = 651653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetPropertyAttributes(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyAttributes_Private_Static_Il2CppStringArray_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651653, XrefRangeEnd = 651655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultIntValue_Private_Static_Int32_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0003F508 File Offset: 0x0003D708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651655, XrefRangeEnd = 651657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultValue_Private_Static_Vector4_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0003F558 File Offset: 0x0003D758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651657, XrefRangeEnd = 651659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyTextureDimension_Private_Static_TextureDimension_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651659, XrefRangeEnd = 651661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyTextureDefaultName_Private_Static_String_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651661, XrefRangeEnd = 651663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIdx;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &layerIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindTextureStackImpl_Private_Static_Boolean_Shader_Int32_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			stackName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003F66C File Offset: 0x0003D86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651663, XrefRangeEnd = 651665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckPropertyIndex(Shader s, int propertyIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_CheckPropertyIndex_Private_Static_Void_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0003F6B0 File Offset: 0x0003D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651665, XrefRangeEnd = 651667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPropertyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0003F6EC File Offset: 0x0003D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651667, XrefRangeEnd = 651669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPropertyIndex(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindPropertyIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0003F73C File Offset: 0x0003D93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651669, XrefRangeEnd = 651680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyName(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003F780 File Offset: 0x0003D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651680, XrefRangeEnd = 651691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPropertyNameId(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyNameId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003F7CC File Offset: 0x0003D9CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 651702, RefRangeEnd = 651709, XrefRangeStart = 651691, XrefRangeEnd = 651702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyType_Public_ShaderPropertyType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003F818 File Offset: 0x0003DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651709, XrefRangeEnd = 651720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyDescription(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDescription_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0003F85C File Offset: 0x0003DA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651720, XrefRangeEnd = 651731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyFlags_Public_ShaderPropertyFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0003F8A8 File Offset: 0x0003DAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651731, XrefRangeEnd = 651742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetPropertyAttributes(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyAttributes_Public_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0003F8F4 File Offset: 0x0003DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651742, XrefRangeEnd = 651747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPropertyDefaultFloatValue(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultFloatValue_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0003F940 File Offset: 0x0003DB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651747, XrefRangeEnd = 651752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultVectorValue_Public_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0003F98C File Offset: 0x0003DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651752, XrefRangeEnd = 651757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPropertyRangeLimits(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyRangeLimits_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651757, XrefRangeEnd = 651775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPropertyDefaultIntValue(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultIntValue_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003FA24 File Offset: 0x0003DC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651775, XrefRangeEnd = 651793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyTextureDimension_Public_TextureDimension_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003FA70 File Offset: 0x0003DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651793, XrefRangeEnd = 651811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyTextureDefaultName(int propertyIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyTextureDefaultName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651811, XrefRangeEnd = 651829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &layerIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_FindTextureStack_Public_Boolean_Int32_byref_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			stackName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003FB28 File Offset: 0x0003DD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651829, XrefRangeEnd = 651831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0003FB68 File Offset: 0x0003DD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651831, XrefRangeEnd = 651833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651833, XrefRangeEnd = 651835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651835, XrefRangeEnd = 651837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0003FC20 File Offset: 0x0003DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651837, XrefRangeEnd = 651839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_IsKeywordEnabledFast_Injected_Private_Static_Boolean_byref_GlobalKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0003FC64 File Offset: 0x0003DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651839, XrefRangeEnd = 651841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0003FCA4 File Offset: 0x0003DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651841, XrefRangeEnd = 651843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651843, XrefRangeEnd = 651845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0003FD24 File Offset: 0x0003DF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651845, XrefRangeEnd = 651847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0003FD64 File Offset: 0x0003DF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651847, XrefRangeEnd = 651849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_GetPropertyDefaultValue_Injected_Private_Static_Void_Shader_Int32_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00006F36 File Offset: 0x00005136
		public Shader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_get_globalShaderHardwareTier_Public_Static_get_ShaderHardwareTier_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_set_globalShaderHardwareTier_Public_Static_set_Void_ShaderHardwareTier_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Shader_String_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_FindBuiltin_Internal_Static_Shader_String_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumChunksOverride_Public_Static_get_Int32_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumChunksOverride_Public_Static_set_Void_Int32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumLOD_Public_get_Int32_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumLOD_Public_set_Void_Int32_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_get_globalMaximumLOD_Public_Static_get_Int32_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_set_globalMaximumLOD_Public_Static_set_Void_Int32_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_get_globalRenderPipeline_Public_Static_get_String_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_get_enabledGlobalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_globalKeywords_Public_Static_get_Il2CppReferenceArray_1_GlobalKeyword_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_GetAllGlobalKeywords_Internal_Static_Il2CppReferenceArray_1_GlobalKeyword_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_String_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeywordFast_Internal_Static_Void_GlobalKeyword_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeywordFast_Internal_Static_Void_GlobalKeyword_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_SetKeywordFast_Internal_Static_Void_GlobalKeyword_Boolean_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordEnabledFast_Internal_Static_Boolean_GlobalKeyword_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_byref_GlobalKeyword_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_byref_GlobalKeyword_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyword_Public_Static_Void_byref_GlobalKeyword_Boolean_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordEnabled_Public_Static_Boolean_byref_GlobalKeyword_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_disableBatching_Internal_get_DisableBatchingType_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_WarmupAllShaders_Public_Static_Void_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_IDToTag_Internal_Static_String_Int32_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_GetDependency_Public_Shader_String_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_subshaderCount_Public_get_Int32_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_GetPassCountInSubshader_Public_Int32_Int32_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_ShaderTagId_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_FindPassTagValue_Public_ShaderTagId_Int32_Int32_ShaderTagId_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_FindSubshaderTagValue_Public_ShaderTagId_Int32_ShaderTagId_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FindPassTagValue_Private_Int32_Int32_Int32_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FindPassTagValueInSubShader_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FindSubshaderTagValue_Private_Int32_Int32_Int32_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalIntImpl_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixImpl_Private_Static_Void_Int32_Matrix4x4_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalRenderTextureImpl_Private_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantGraphicsBufferImpl_Private_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalIntImpl_Private_Static_Int32_Int32_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatImpl_Private_Static_Single_Int32_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorImpl_Private_Static_Vector4_Int32_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixImpl_Private_Static_Matrix4x4_Int32_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalTextureImpl_Private_Static_Texture_Int32_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArrayImpl_Private_Static_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArrayImpl_Private_Static_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArrayImpl_Private_Static_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArrayCountImpl_Private_Static_Int32_Int32_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArrayCountImpl_Private_Static_Int32_Int32_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArrayCountImpl_Private_Static_Int32_Int32_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalFloatArray_Private_Static_Void_Int32_List_1_Single_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalVectorArray_Private_Static_Void_Int32_List_1_Vector4_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_ExtractGlobalMatrixArray_Private_Static_Void_Int32_List_1_Matrix4x4_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_String_Int32_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInteger_Public_Static_Void_Int32_Int32_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_String_Matrix4x4_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrix_Public_Static_Void_Int32_Matrix4x4_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_ComputeBuffer_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_GraphicsBuffer_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_Int32_GraphicsBuffer_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_ComputeBuffer_Int32_Int32_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_String_GraphicsBuffer_Int32_Int32_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_GraphicsBuffer_Int32_Int32_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_String_Il2CppStructArray_1_Single_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_String_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_String_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_String_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInt_Public_Static_Int32_Int32_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_String_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloat_Public_Static_Single_Int32_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_String_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInteger_Public_Static_Int32_Int32_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVector_Public_Static_Vector4_Int32_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_String_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalColor_Public_Static_Color_Int32_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_String_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrix_Public_Static_Matrix4x4_Int32_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_String_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalTexture_Public_Static_Texture_Int32_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_String_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_String_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_String_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_String_List_1_Single_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatArray_Public_Static_Void_Int32_List_1_Single_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_String_List_1_Vector4_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorArray_Public_Static_Void_Int32_List_1_Vector4_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_String_List_1_Matrix4x4_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixArray_Public_Static_Void_Int32_List_1_Matrix4x4_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyName_Private_Static_String_Shader_Int32_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyNameId_Private_Static_Int32_Shader_Int32_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyType_Private_Static_ShaderPropertyType_Shader_Int32_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDescription_Private_Static_String_Shader_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyFlags_Private_Static_ShaderPropertyFlags_Shader_Int32_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyAttributes_Private_Static_Il2CppStringArray_Shader_Int32_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultIntValue_Private_Static_Int32_Shader_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultValue_Private_Static_Vector4_Shader_Int32_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyTextureDimension_Private_Static_TextureDimension_Shader_Int32_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyTextureDefaultName_Private_Static_String_Shader_Int32_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_FindTextureStackImpl_Private_Static_Boolean_Shader_Int32_byref_String_byref_Int32_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_CheckPropertyIndex_Private_Static_Void_Shader_Int32_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyCount_Public_Int32_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_FindPropertyIndex_Public_Int32_String_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyName_Public_String_Int32_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyNameId_Public_Int32_Int32_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyType_Public_ShaderPropertyType_Int32_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDescription_Public_String_Int32_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyFlags_Public_ShaderPropertyFlags_Int32_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyAttributes_Public_Il2CppStringArray_Int32_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultFloatValue_Public_Single_Int32_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultVectorValue_Public_Vector4_Int32_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyRangeLimits_Public_Vector2_Int32_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultIntValue_Public_Int32_Int32_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyTextureDimension_Public_TextureDimension_Int32_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyTextureDefaultName_Public_String_Int32_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_FindTextureStack_Public_Boolean_Int32_byref_String_byref_Int32_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_SetKeywordFast_Injected_Private_Static_Void_byref_GlobalKeyword_Boolean_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordEnabledFast_Injected_Private_Static_Boolean_byref_GlobalKeyword_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalMatrixImpl_Injected_Private_Static_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDefaultValue_Injected_Private_Static_Void_Shader_Int32_byref_Vector4_0;
	}
}

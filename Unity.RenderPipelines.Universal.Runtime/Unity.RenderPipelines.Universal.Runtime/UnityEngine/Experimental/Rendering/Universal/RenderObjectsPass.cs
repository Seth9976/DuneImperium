using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000007 RID: 7
	public class RenderObjectsPass : ScriptableRenderPass
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00016878 File Offset: 0x00014A78
		// Note: this type is marked as 'beforefieldinit'.
		static RenderObjectsPass()
		{
			Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Experimental.Rendering.Universal", "RenderObjectsPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr);
			RenderObjectsPass.NativeFieldInfoPtr_renderQueueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "renderQueueType");
			RenderObjectsPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_FilteringSettings");
			RenderObjectsPass.NativeFieldInfoPtr_m_CameraSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_CameraSettings");
			RenderObjectsPass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_ProfilerTag");
			RenderObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_ProfilingSampler");
			RenderObjectsPass.NativeFieldInfoPtr__overrideMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "<overrideMaterial>k__BackingField");
			RenderObjectsPass.NativeFieldInfoPtr__overrideMaterialPassIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "<overrideMaterialPassIndex>k__BackingField");
			RenderObjectsPass.NativeFieldInfoPtr__overrideShader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "<overrideShader>k__BackingField");
			RenderObjectsPass.NativeFieldInfoPtr__overrideShaderPassIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "<overrideShaderPassIndex>k__BackingField");
			RenderObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_ShaderTagIdList");
			RenderObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "m_RenderStateBlock");
			RenderObjectsPass.NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663356);
			RenderObjectsPass.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663357);
			RenderObjectsPass.NativeMethodInfoPtr_get_overrideMaterialPassIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663358);
			RenderObjectsPass.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663359);
			RenderObjectsPass.NativeMethodInfoPtr_get_overrideShader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663360);
			RenderObjectsPass.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663361);
			RenderObjectsPass.NativeMethodInfoPtr_get_overrideShaderPassIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663362);
			RenderObjectsPass.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663363);
			RenderObjectsPass.NativeMethodInfoPtr_SetDetphState_Public_Void_Boolean_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663364);
			RenderObjectsPass.NativeMethodInfoPtr_SetStencilState_Public_Void_Int32_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663365);
			RenderObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663366);
			RenderObjectsPass.NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663367);
			RenderObjectsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663368);
			RenderObjectsPass.NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_Void_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, 100663369);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00016A9C File Offset: 0x00014C9C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00016ADC File Offset: 0x00014CDC
		public unsafe Material overrideMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00016B20 File Offset: 0x00014D20
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00016B5C File Offset: 0x00014D5C
		public unsafe int overrideMaterialPassIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_get_overrideMaterialPassIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00016B9C File Offset: 0x00014D9C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00016BDC File Offset: 0x00014DDC
		public unsafe Shader overrideShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_get_overrideShader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00016C20 File Offset: 0x00014E20
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00016C5C File Offset: 0x00014E5C
		public unsafe int overrideShaderPassIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_get_overrideShaderPassIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00016C9C File Offset: 0x00014E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596623, XrefRangeEnd = 596627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDetphState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeEnabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref function;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_SetDetphState_Public_Void_Boolean_CompareFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00016CE8 File Offset: 0x00014EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596627, XrefRangeEnd = 596637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reference;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr_SetStencilState_Public_Void_Int32_CompareFunction_StencilOp_StencilOp_StencilOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00016D60 File Offset: 0x00014F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 596699, RefRangeEnd = 596701, XrefRangeStart = 596637, XrefRangeEnd = 596699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, Il2CppStringArray shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(profilerTag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassEvent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shaderTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00016DFC File Offset: 0x00014FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596701, XrefRangeEnd = 596710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, Il2CppStringArray shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref profileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassEvent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shaderTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00016E94 File Offset: 0x00015094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596710, XrefRangeEnd = 596776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderObjectsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00016EF0 File Offset: 0x000150F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596776, XrefRangeEnd = 596814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderObjectsPass.NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_Void_RenderGraph_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000022E5 File Offset: 0x000004E5
		public RenderObjectsPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00016F50 File Offset: 0x00015150
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000022EE File Offset: 0x000004EE
		public unsafe RenderQueueType renderQueueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_renderQueueType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_renderQueueType)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00016F78 File Offset: 0x00015178
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00016FA0 File Offset: 0x000151A0
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002324 File Offset: 0x00000524
		public unsafe RenderObjects.CustomCameraSettings m_CameraSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_CameraSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjects.CustomCameraSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_CameraSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00016FD0 File Offset: 0x000151D0
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002343 File Offset: 0x00000543
		public unsafe string m_ProfilerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ProfilerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ProfilerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00016FF8 File Offset: 0x000151F8
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002362 File Offset: 0x00000562
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00017028 File Offset: 0x00015228
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002381 File Offset: 0x00000581
		public unsafe Material _overrideMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00017058 File Offset: 0x00015258
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000023A0 File Offset: 0x000005A0
		public unsafe int _overrideMaterialPassIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideMaterialPassIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideMaterialPassIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00017080 File Offset: 0x00015280
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023BB File Offset: 0x000005BB
		public unsafe Shader _overrideShader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideShader_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideShader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000170B0 File Offset: 0x000152B0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023DA File Offset: 0x000005DA
		public unsafe int _overrideShaderPassIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideShaderPassIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr__overrideShaderPassIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000170D8 File Offset: 0x000152D8
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000023F5 File Offset: 0x000005F5
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00017108 File Offset: 0x00015308
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002414 File Offset: 0x00000614
		public unsafe RenderStateBlock m_RenderStateBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock)) = value;
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_renderQueueType;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraSettings;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__overrideMaterial_k__BackingField;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr__overrideMaterialPassIndex_k__BackingField;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr__overrideShader_k__BackingField;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr__overrideShaderPassIndex_k__BackingField;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderStateBlock;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideMaterialPassIndex_Public_get_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideShader_Public_get_Shader_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideShaderPassIndex_Public_get_Int32_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_SetDetphState_Public_Void_Boolean_CompareFunction_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilState_Public_Void_Int32_CompareFunction_StencilOp_StencilOp_StencilOp_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_RenderPassEvent_Il2CppStringArray_RenderQueueType_Int32_CustomCameraSettings_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Internal_Virtual_Void_RenderGraph_byref_RenderingData_0;

		// Token: 0x0200014A RID: 330
		public class PassData : Object
		{
			// Token: 0x06001B27 RID: 6951 RVA: 0x00071964 File Offset: 0x0006FB64
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr);
				RenderObjectsPass.PassData.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr, "pass");
				RenderObjectsPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr, "renderingData");
				RenderObjectsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr, 100663370);
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x000719CC File Offset: 0x0006FBCC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjectsPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x0000F590 File Offset: 0x0000D790
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00071A08 File Offset: 0x0006FC08
			// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0000F599 File Offset: 0x0000D799
			public unsafe RenderObjectsPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.PassData.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjectsPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.PassData.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00071A38 File Offset: 0x0006FC38
			// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjectsPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013AE RID: 5038
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x040013AF RID: 5039
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040013B0 RID: 5040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200014B RID: 331
		[ObfuscatedName("UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B2E RID: 6958 RVA: 0x00071A68 File Offset: 0x0006FC68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderObjectsPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr);
				RenderObjectsPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, "<>9");
				RenderObjectsPass.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, "<>9__27_0");
				RenderObjectsPass.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, "<>9__29_0");
				RenderObjectsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, 100663372);
				RenderObjectsPass.__c.NativeMethodInfoPtr__Execute_b__27_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, 100663373);
				RenderObjectsPass.__c.NativeMethodInfoPtr__RecordRenderGraph_b__29_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr, 100663374);
			}

			// Token: 0x06001B2F RID: 6959 RVA: 0x00071B0C File Offset: 0x0006FD0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjectsPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B30 RID: 6960 RVA: 0x00071B48 File Offset: 0x0006FD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596611, XrefRangeEnd = 596615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Execute_b__27_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ctx;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ds;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fs;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rsb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.__c.NativeMethodInfoPtr__Execute_b__27_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B31 RID: 6961 RVA: 0x00071BC8 File Offset: 0x0006FDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596615, XrefRangeEnd = 596623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecordRenderGraph_b__29_0(RenderObjectsPass.PassData data, RenderGraphContext rgContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjectsPass.__c.NativeMethodInfoPtr__RecordRenderGraph_b__29_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B32 RID: 6962 RVA: 0x0000F5E6 File Offset: 0x0000D7E6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00071C1C File Offset: 0x0006FE1C
			// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000F5EF File Offset: 0x0000D7EF
			public unsafe static RenderObjectsPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjectsPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00071C44 File Offset: 0x0006FE44
			// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0000F601 File Offset: 0x0000D801
			public unsafe static DebugHandler.DrawFunction __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler.DrawFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00071C6C File Offset: 0x0006FE6C
			// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0000F613 File Offset: 0x0000D813
			public unsafe static RenderFunc<RenderObjectsPass.PassData> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<RenderObjectsPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderObjectsPass.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013B1 RID: 5041
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013B2 RID: 5042
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040013B3 RID: 5043
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x040013B4 RID: 5044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013B5 RID: 5045
			private static readonly IntPtr NativeMethodInfoPtr__Execute_b__27_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

			// Token: 0x040013B6 RID: 5046
			private static readonly IntPtr NativeMethodInfoPtr__RecordRenderGraph_b__29_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}

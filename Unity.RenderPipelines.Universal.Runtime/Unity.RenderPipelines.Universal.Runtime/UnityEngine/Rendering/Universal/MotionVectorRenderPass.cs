using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B1 RID: 177
	public sealed class MotionVectorRenderPass : ScriptableRenderPass
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x000453D8 File Offset: 0x000435D8
		// Note: this type is marked as 'beforefieldinit'.
		static MotionVectorRenderPass()
		{
			Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionVectorRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr);
			MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "kPreviousViewProjectionNoJitter");
			MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "kViewProjectionNoJitter");
			MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitterStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "kPreviousViewProjectionNoJitterStereo");
			MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitterStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "kViewProjectionNoJitterStereo");
			MotionVectorRenderPass.NativeFieldInfoPtr_k_TargetFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "k_TargetFormat");
			MotionVectorRenderPass.NativeFieldInfoPtr_s_ShaderTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "s_ShaderTags");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_Color");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_Depth");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_CameraMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_CameraMaterial");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_ObjectMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_ObjectMaterial");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_FilteringSettings");
			MotionVectorRenderPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "m_PassData");
			MotionVectorRenderPass.NativeMethodInfoPtr__ctor_Internal_Void_RenderPassEvent_Material_Material_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665102);
			MotionVectorRenderPass.NativeMethodInfoPtr_Setup_Internal_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665103);
			MotionVectorRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665104);
			MotionVectorRenderPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665105);
			MotionVectorRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665106);
			MotionVectorRenderPass.NativeMethodInfoPtr_GetDrawingSettings_Private_Static_DrawingSettings_byref_RenderingData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665107);
			MotionVectorRenderPass.NativeMethodInfoPtr_DrawCameraMotionVectors_Private_Static_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_Camera_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665108);
			MotionVectorRenderPass.NativeMethodInfoPtr_DrawObjectMotionVectors_Private_Static_Void_ScriptableRenderContext_byref_RenderingData_Camera_Material_CommandBuffer_byref_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665109);
			MotionVectorRenderPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, 100665110);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000455AC File Offset: 0x000437AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612963, RefRangeEnd = 612964, XrefRangeStart = 612939, XrefRangeEnd = 612963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, Material objectMaterial, LayerMask opaqueLayerMask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectMaterial);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaqueLayerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr__ctor_Internal_Void_RenderPassEvent_Material_Material_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00045628 File Offset: 0x00043828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612978, RefRangeEnd = 612979, XrefRangeStart = 612964, XrefRangeEnd = 612978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle color, RTHandle depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depth);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_Setup_Internal_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0004567C File Offset: 0x0004387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612979, XrefRangeEnd = 612985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000456CC File Offset: 0x000438CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613051, RefRangeEnd = 613053, XrefRangeStart = 612985, XrefRangeEnd = 613051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, MotionVectorRenderPass.PassData passData, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00045724 File Offset: 0x00043924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613053, XrefRangeEnd = 613060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00045778 File Offset: 0x00043978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613087, RefRangeEnd = 613089, XrefRangeStart = 613060, XrefRangeEnd = 613087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DrawingSettings GetDrawingSettings(ref RenderingData renderingData, Material objectMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_GetDrawingSettings_Private_Static_DrawingSettings_byref_RenderingData_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000457CC File Offset: 0x000439CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613109, RefRangeEnd = 613110, XrefRangeStart = 613089, XrefRangeEnd = 613109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, Camera camera, Material cameraMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_DrawCameraMotionVectors_Private_Static_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_Camera_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00045848 File Offset: 0x00043A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613110, XrefRangeEnd = 613131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera, Material objectMaterial, CommandBuffer cmd, ref FilteringSettings filteringSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectMaterial);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_DrawObjectMotionVectors_Private_Static_Void_ScriptableRenderContext_byref_RenderingData_Camera_Material_CommandBuffer_byref_FilteringSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000458D4 File Offset: 0x00043AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613164, RefRangeEnd = 613165, XrefRangeStart = 613131, XrefRangeEnd = 613164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, ref TextureHandle cameraDepthTexture, [In] ref TextureHandle motionVectorColor, [In] ref TextureHandle motionVectorDepth, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraDepthTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &motionVectorColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &motionVectorDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00008862 File Offset: 0x00006A62
		public MotionVectorRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00045958 File Offset: 0x00043B58
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0000886B File Offset: 0x00006A6B
		public unsafe static string kPreviousViewProjectionNoJitter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00045978 File Offset: 0x00043B78
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0000887D File Offset: 0x00006A7D
		public unsafe static string kViewProjectionNoJitter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00045998 File Offset: 0x00043B98
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0000888F File Offset: 0x00006A8F
		public unsafe static string kPreviousViewProjectionNoJitterStereo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitterStereo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_kPreviousViewProjectionNoJitterStereo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x000459B8 File Offset: 0x00043BB8
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x000088A1 File Offset: 0x00006AA1
		public unsafe static string kViewProjectionNoJitterStereo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitterStereo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_kViewProjectionNoJitterStereo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x000459D8 File Offset: 0x00043BD8
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x000088B3 File Offset: 0x00006AB3
		public unsafe static GraphicsFormat k_TargetFormat
		{
			get
			{
				GraphicsFormat graphicsFormat;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_k_TargetFormat, (void*)(&graphicsFormat));
				return graphicsFormat;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_k_TargetFormat, (void*)(&value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000459F4 File Offset: 0x00043BF4
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x000088C1 File Offset: 0x00006AC1
		public unsafe static Il2CppStringArray s_ShaderTags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.NativeFieldInfoPtr_s_ShaderTags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.NativeFieldInfoPtr_s_ShaderTags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00045A1C File Offset: 0x00043C1C
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x000088D3 File Offset: 0x00006AD3
		public unsafe RTHandle m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_Color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_Color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00045A4C File Offset: 0x00043C4C
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x000088F2 File Offset: 0x00006AF2
		public unsafe RTHandle m_Depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_Depth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_Depth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00045A7C File Offset: 0x00043C7C
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00008911 File Offset: 0x00006B11
		public unsafe Material m_CameraMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_CameraMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_CameraMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00045AAC File Offset: 0x00043CAC
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00008930 File Offset: 0x00006B30
		public unsafe Material m_ObjectMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_ObjectMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_ObjectMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00045ADC File Offset: 0x00043CDC
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0000894F File Offset: 0x00006B4F
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00045B04 File Offset: 0x00043D04
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0000896A File Offset: 0x00006B6A
		public unsafe MotionVectorRenderPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionVectorRenderPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_kPreviousViewProjectionNoJitter;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_kViewProjectionNoJitter;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_kPreviousViewProjectionNoJitterStereo;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_kViewProjectionNoJitterStereo;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_k_TargetFormat;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTags;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_m_Depth;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraMaterial;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectMaterial;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RenderPassEvent_Material_Material_LayerMask_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Void_RTHandle_RTHandle_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_GetDrawingSettings_Private_Static_DrawingSettings_byref_RenderingData_Material_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_DrawCameraMotionVectors_Private_Static_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_Camera_Material_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_DrawObjectMotionVectors_Private_Static_Void_ScriptableRenderContext_byref_RenderingData_Camera_Material_CommandBuffer_byref_FilteringSettings_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001A7 RID: 423
		public class PassData : Object
		{
			// Token: 0x06001E8D RID: 7821 RVA: 0x0007A6F8 File Offset: 0x000788F8
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr);
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "motionVectorColor");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "motionVectorDepth");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "cameraDepth");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "renderingData");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "cameraMaterial");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_objectMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "objectMaterial");
				MotionVectorRenderPass.PassData.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, "filteringSettings");
				MotionVectorRenderPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr, 100665112);
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x0007A7C4 File Offset: 0x000789C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionVectorRenderPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x00011819 File Offset: 0x0000FA19
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0007A800 File Offset: 0x00078A00
			// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00011822 File Offset: 0x0000FA22
			public unsafe TextureHandle motionVectorColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorColor)) = value;
				}
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0007A828 File Offset: 0x00078A28
			// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0001183D File Offset: 0x0000FA3D
			public unsafe TextureHandle motionVectorDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_motionVectorDepth)) = value;
				}
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0007A850 File Offset: 0x00078A50
			// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00011858 File Offset: 0x0000FA58
			public unsafe TextureHandle cameraDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraDepth)) = value;
				}
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0007A878 File Offset: 0x00078A78
			// (set) Token: 0x06001E97 RID: 7831 RVA: 0x00011873 File Offset: 0x0000FA73
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0007A8A8 File Offset: 0x00078AA8
			// (set) Token: 0x06001E99 RID: 7833 RVA: 0x000118A1 File Offset: 0x0000FAA1
			public unsafe Material cameraMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_cameraMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0007A8D8 File Offset: 0x00078AD8
			// (set) Token: 0x06001E9B RID: 7835 RVA: 0x000118C0 File Offset: 0x0000FAC0
			public unsafe Material objectMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_objectMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_objectMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0007A908 File Offset: 0x00078B08
			// (set) Token: 0x06001E9D RID: 7837 RVA: 0x000118DF File Offset: 0x0000FADF
			public unsafe FilteringSettings filteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_filteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorRenderPass.PassData.NativeFieldInfoPtr_filteringSettings)) = value;
				}
			}

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorColor;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorDepth;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepth;

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeFieldInfoPtr_cameraMaterial;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeFieldInfoPtr_objectMaterial;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A8 RID: 424
		[ObfuscatedName("UnityEngine.Rendering.Universal.MotionVectorRenderPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E9E RID: 7838 RVA: 0x0007A930 File Offset: 0x00078B30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionVectorRenderPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr);
				MotionVectorRenderPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr, "<>9");
				MotionVectorRenderPass.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr, "<>9__21_0");
				MotionVectorRenderPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr, 100665114);
				MotionVectorRenderPass.__c.NativeMethodInfoPtr__Render_b__21_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr, 100665115);
			}

			// Token: 0x06001E9F RID: 7839 RVA: 0x0007A9AC File Offset: 0x00078BAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionVectorRenderPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA0 RID: 7840 RVA: 0x0007A9E8 File Offset: 0x00078BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612928, XrefRangeEnd = 612939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__21_0(MotionVectorRenderPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorRenderPass.__c.NativeMethodInfoPtr__Render_b__21_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA1 RID: 7841 RVA: 0x000118FA File Offset: 0x0000FAFA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0007AA3C File Offset: 0x00078C3C
			// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00011903 File Offset: 0x0000FB03
			public unsafe static MotionVectorRenderPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionVectorRenderPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x0007AA64 File Offset: 0x00078C64
			// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00011915 File Offset: 0x0000FB15
			public unsafe static RenderFunc<MotionVectorRenderPass.PassData> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotionVectorRenderPass.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<MotionVectorRenderPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionVectorRenderPass.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__21_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}

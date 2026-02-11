using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AF RID: 175
	public class HDRDebugViewPass : ScriptableRenderPass
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x00044CF4 File Offset: 0x00042EF4
		// Note: this type is marked as 'beforefieldinit'.
		static HDRDebugViewPass()
		{
			Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "HDRDebugViewPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr);
			HDRDebugViewPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "m_PassData");
			HDRDebugViewPass.NativeFieldInfoPtr_m_CIExyTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "m_CIExyTarget");
			HDRDebugViewPass.NativeFieldInfoPtr_m_PassthroughRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "m_PassthroughRT");
			HDRDebugViewPass.NativeFieldInfoPtr_m_CameraTargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "m_CameraTargetHandle");
			HDRDebugViewPass.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665082);
			HDRDebugViewPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665083);
			HDRDebugViewPass.NativeMethodInfoPtr_ConfigureDescriptorForCIEPrepass_Public_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665084);
			HDRDebugViewPass.NativeMethodInfoPtr_GetLuminanceParameters_Internal_Static_Vector4_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665085);
			HDRDebugViewPass.NativeMethodInfoPtr_ExecuteCIExyPrepass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665086);
			HDRDebugViewPass.NativeMethodInfoPtr_ExecuteHDRDebugViewFinalPass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665087);
			HDRDebugViewPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665088);
			HDRDebugViewPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_HDRDebugMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665089);
			HDRDebugViewPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665090);
			HDRDebugViewPass.NativeMethodInfoPtr_ExecutePass_Private_Void_CommandBuffer_PassData_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, 100665091);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00044E3C File Offset: 0x0004303C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612717, RefRangeEnd = 612718, XrefRangeStart = 612700, XrefRangeEnd = 612717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDRDebugViewPass(Material mat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00044E88 File Offset: 0x00043088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612718, XrefRangeEnd = 612722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureDescriptor(ref RenderTextureDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00044EBC File Offset: 0x000430BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612722, XrefRangeEnd = 612728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_ConfigureDescriptorForCIEPrepass_Public_Static_Void_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00044EF0 File Offset: 0x000430F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612728, XrefRangeEnd = 612734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetLuminanceParameters(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_GetLuminanceParameters_Internal_Static_Vector4_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00044F34 File Offset: 0x00043134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 612771, RefRangeEnd = 612773, XrefRangeStart = 612734, XrefRangeEnd = 612771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCIExyPrepass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTexture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xyTarget);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_ExecuteCIExyPrepass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00044FB4 File Offset: 0x000431B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 612805, RefRangeEnd = 612807, XrefRangeStart = 612773, XrefRangeEnd = 612805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteHDRDebugViewFinalPass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTexture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xyTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_ExecuteHDRDebugViewFinalPass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00045034 File Offset: 0x00043234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612810, RefRangeEnd = 612811, XrefRangeStart = 612807, XrefRangeEnd = 612810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00045068 File Offset: 0x00043268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 612830, RefRangeEnd = 612832, XrefRangeStart = 612811, XrefRangeEnd = 612830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ref CameraData cameraData, HDRDebugMode hdrdebugMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrdebugMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_HDRDebugMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000450BC File Offset: 0x000432BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612832, XrefRangeEnd = 612873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HDRDebugViewPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00045118 File Offset: 0x00043318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612873, XrefRangeEnd = 612877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecutePass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle xyTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTexture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xyTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.NativeMethodInfoPtr_ExecutePass_Private_Void_CommandBuffer_PassData_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000087D4 File Offset: 0x000069D4
		public HDRDebugViewPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00045194 File Offset: 0x00043394
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x000087DD File Offset: 0x000069DD
		public unsafe HDRDebugViewPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRDebugViewPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x000451C4 File Offset: 0x000433C4
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000087FC File Offset: 0x000069FC
		public unsafe RTHandle m_CIExyTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_CIExyTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_CIExyTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000451F4 File Offset: 0x000433F4
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0000881B File Offset: 0x00006A1B
		public unsafe RTHandle m_PassthroughRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_PassthroughRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_PassthroughRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00045224 File Offset: 0x00043424
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0000883A File Offset: 0x00006A3A
		public unsafe RTHandle m_CameraTargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_CameraTargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.NativeFieldInfoPtr_m_CameraTargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_m_CIExyTarget;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_m_PassthroughRT;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraTargetHandle;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDescriptorForCIEPrepass_Public_Static_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_GetLuminanceParameters_Internal_Static_Vector4_byref_CameraData_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCIExyPrepass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHDRDebugViewFinalPass_Private_Static_Void_CommandBuffer_PassData_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_HDRDebugMode_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Void_CommandBuffer_PassData_RTHandle_RTHandle_0;

		// Token: 0x020001A2 RID: 418
		public enum HDRDebugPassId
		{
			// Token: 0x040015D9 RID: 5593
			CIExyPrepass,
			// Token: 0x040015DA RID: 5594
			DebugViewPass
		}

		// Token: 0x020001A3 RID: 419
		public class PassData : Object
		{
			// Token: 0x06001E66 RID: 7782 RVA: 0x0007A1C0 File Offset: 0x000783C0
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr);
				HDRDebugViewPass.PassData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr, "material");
				HDRDebugViewPass.PassData.NativeFieldInfoPtr_hdrDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr, "hdrDebugMode");
				HDRDebugViewPass.PassData.NativeFieldInfoPtr_luminanceParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr, "luminanceParameters");
				HDRDebugViewPass.PassData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr, "cameraData");
				HDRDebugViewPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr, 100665092);
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x0007A250 File Offset: 0x00078450
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRDebugViewPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E68 RID: 7784 RVA: 0x000116D2 File Offset: 0x0000F8D2
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06001E69 RID: 7785 RVA: 0x0007A28C File Offset: 0x0007848C
			// (set) Token: 0x06001E6A RID: 7786 RVA: 0x000116DB File Offset: 0x0000F8DB
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06001E6B RID: 7787 RVA: 0x0007A2BC File Offset: 0x000784BC
			// (set) Token: 0x06001E6C RID: 7788 RVA: 0x000116FA File Offset: 0x0000F8FA
			public unsafe HDRDebugMode hdrDebugMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_hdrDebugMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_hdrDebugMode)) = value;
				}
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06001E6D RID: 7789 RVA: 0x0007A2E4 File Offset: 0x000784E4
			// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00011715 File Offset: 0x0000F915
			public unsafe Vector4 luminanceParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_luminanceParameters);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_luminanceParameters)) = value;
				}
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0007A30C File Offset: 0x0007850C
			// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00011730 File Offset: 0x0000F930
			public CameraData cameraData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_cameraData);
					return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRDebugViewPass.PassData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeFieldInfoPtr_hdrDebugMode;

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr_luminanceParameters;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeFieldInfoPtr_cameraData;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A4 RID: 420
		public class ShaderConstants : Object
		{
			// Token: 0x06001E71 RID: 7793 RVA: 0x0007A33C File Offset: 0x0007853C
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRDebugViewPass>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr);
				HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__DebugHDRModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, "_DebugHDRModeId");
				HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__HDRDebugParamsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, "_HDRDebugParamsId");
				HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__xyTextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, "_xyTextureId");
				HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__SizeOfHDRXYMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, "_SizeOfHDRXYMapping");
				HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__CIExyUAVIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, "_CIExyUAVIndex");
				HDRDebugViewPass.ShaderConstants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr, 100665093);
			}

			// Token: 0x06001E72 RID: 7794 RVA: 0x0007A3E0 File Offset: 0x000785E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderConstants()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRDebugViewPass.ShaderConstants>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRDebugViewPass.ShaderConstants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E73 RID: 7795 RVA: 0x0001175E File Offset: 0x0000F95E
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0007A41C File Offset: 0x0007861C
			// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00011767 File Offset: 0x0000F967
			public unsafe static int _DebugHDRModeId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__DebugHDRModeId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__DebugHDRModeId, (void*)(&value));
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0007A438 File Offset: 0x00078638
			// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00011775 File Offset: 0x0000F975
			public unsafe static int _HDRDebugParamsId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__HDRDebugParamsId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__HDRDebugParamsId, (void*)(&value));
				}
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0007A454 File Offset: 0x00078654
			// (set) Token: 0x06001E79 RID: 7801 RVA: 0x00011783 File Offset: 0x0000F983
			public unsafe static int _xyTextureId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__xyTextureId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__xyTextureId, (void*)(&value));
				}
			}

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0007A470 File Offset: 0x00078670
			// (set) Token: 0x06001E7B RID: 7803 RVA: 0x00011791 File Offset: 0x0000F991
			public unsafe static int _SizeOfHDRXYMapping
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__SizeOfHDRXYMapping, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__SizeOfHDRXYMapping, (void*)(&value));
				}
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0007A48C File Offset: 0x0007868C
			// (set) Token: 0x06001E7D RID: 7805 RVA: 0x0001179F File Offset: 0x0000F99F
			public unsafe static int _CIExyUAVIndex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__CIExyUAVIndex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRDebugViewPass.ShaderConstants.NativeFieldInfoPtr__CIExyUAVIndex, (void*)(&value));
				}
			}

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeFieldInfoPtr__DebugHDRModeId;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeFieldInfoPtr__HDRDebugParamsId;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeFieldInfoPtr__xyTextureId;

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeFieldInfoPtr__SizeOfHDRXYMapping;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeFieldInfoPtr__CIExyUAVIndex;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

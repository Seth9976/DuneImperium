using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000124 RID: 292
	public class FinalBlitPass : ScriptableRenderPass
	{
		// Token: 0x06001965 RID: 6501 RVA: 0x0006AD10 File Offset: 0x00068F10
		// Note: this type is marked as 'beforefieldinit'.
		static FinalBlitPass()
		{
			Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "FinalBlitPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr);
			FinalBlitPass.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "m_Source");
			FinalBlitPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "m_PassData");
			FinalBlitPass.NativeFieldInfoPtr_m_BlitMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "m_BlitMaterialData");
			FinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666283);
			FinalBlitPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666284);
			FinalBlitPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666285);
			FinalBlitPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666286);
			FinalBlitPass.NativeMethodInfoPtr_SetupHDROutput_Private_Static_Void_ColorGamut_Material_Operation_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666287);
			FinalBlitPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666288);
			FinalBlitPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666289);
			FinalBlitPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_byref_RenderingData_byref_BlitMaterialData_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666290);
			FinalBlitPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_RenderingData_byref_PassData_BlitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666291);
			FinalBlitPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_RenderingData_TextureHandle_TextureHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, 100666292);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0006AE44 File Offset: 0x00069044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628024, RefRangeEnd = 628026, XrefRangeStart = 627994, XrefRangeEnd = 628024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blitMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blitHDRMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0006AEB0 File Offset: 0x000690B0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0006AEE4 File Offset: 0x000690E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628026, XrefRangeEnd = 628045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RenderTargetHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0006AF30 File Offset: 0x00069130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628046, RefRangeEnd = 628047, XrefRangeStart = 628045, XrefRangeEnd = 628046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0006AF80 File Offset: 0x00069180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628047, XrefRangeEnd = 628054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hdrDisplayColorGamut;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrOperation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrOutputParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_SetupHDROutput_Private_Static_Void_ColorGamut_Material_Operation_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0006AFE0 File Offset: 0x000691E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628054, XrefRangeEnd = 628062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalBlitPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0006B040 File Offset: 0x00069240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628062, XrefRangeEnd = 628153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalBlitPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0006B09C File Offset: 0x0006929C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628161, RefRangeEnd = 628163, XrefRangeStart = 628153, XrefRangeEnd = 628161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ref RenderingData renderingData, [In] ref FinalBlitPass.BlitMaterialData blitMaterialData, RTHandle cameraTarget, RTHandle source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(blitMaterialData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraTarget);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_byref_RenderingData_byref_BlitMaterialData_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0006B10C File Offset: 0x0006930C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628168, RefRangeEnd = 628170, XrefRangeStart = 628163, XrefRangeEnd = 628168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPassData(ref RenderingData renderingData, ref FinalBlitPass.PassData passData, FinalBlitPass.BlitType blitType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_RenderingData_byref_PassData_BlitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			passData = ((intPtr4 == 0) ? null : new FinalBlitPass.PassData(intPtr4));
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0006B184 File Offset: 0x00069384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628223, RefRangeEnd = 628225, XrefRangeStart = 628170, XrefRangeEnd = 628223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, ref RenderingData renderingData, TextureHandle src, TextureHandle dest, TextureHandle overlayUITexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overlayUITexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_RenderingData_TextureHandle_TextureHandle_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0000E691 File Offset: 0x0000C891
		public FinalBlitPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0006B204 File Offset: 0x00069404
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000E69A File Offset: 0x0000C89A
		public unsafe RTHandle m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0006B234 File Offset: 0x00069434
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000E6B9 File Offset: 0x0000C8B9
		public unsafe FinalBlitPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalBlitPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0006B264 File Offset: 0x00069464
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
		public unsafe Il2CppReferenceArray<FinalBlitPass.BlitMaterialData> m_BlitMaterialData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_BlitMaterialData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FinalBlitPass.BlitMaterialData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.NativeFieldInfoPtr_m_BlitMaterialData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterialData;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RenderTargetHandle_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_SetupHDROutput_Private_Static_Void_ColorGamut_Material_Operation_Vector4_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_byref_RenderingData_byref_BlitMaterialData_RTHandle_RTHandle_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_InitPassData_Private_Void_byref_RenderingData_byref_PassData_BlitType_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_RenderingData_TextureHandle_TextureHandle_TextureHandle_0;

		// Token: 0x020001FB RID: 507
		public static class BlitPassNames : Object
		{
			// Token: 0x06002321 RID: 8993 RVA: 0x00084FDC File Offset: 0x000831DC
			// Note: this type is marked as 'beforefieldinit'.
			static BlitPassNames()
			{
				Il2CppClassPointerStore<FinalBlitPass.BlitPassNames>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "BlitPassNames");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass.BlitPassNames>.NativeClassPtr);
				FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_NearestSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.BlitPassNames>.NativeClassPtr, "NearestSampler");
				FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_BilinearSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.BlitPassNames>.NativeClassPtr, "BilinearSampler");
			}

			// Token: 0x06002322 RID: 8994 RVA: 0x000141AD File Offset: 0x000123AD
			public BlitPassNames(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x00085030 File Offset: 0x00083230
			// (set) Token: 0x06002324 RID: 8996 RVA: 0x000141B6 File Offset: 0x000123B6
			public unsafe static string NearestSampler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_NearestSampler, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_NearestSampler, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x06002325 RID: 8997 RVA: 0x00085050 File Offset: 0x00083250
			// (set) Token: 0x06002326 RID: 8998 RVA: 0x000141C8 File Offset: 0x000123C8
			public unsafe static string BilinearSampler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_BilinearSampler, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.BlitPassNames.NativeFieldInfoPtr_BilinearSampler, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400189A RID: 6298
			private static readonly IntPtr NativeFieldInfoPtr_NearestSampler;

			// Token: 0x0400189B RID: 6299
			private static readonly IntPtr NativeFieldInfoPtr_BilinearSampler;
		}

		// Token: 0x020001FC RID: 508
		public enum BlitType
		{
			// Token: 0x0400189D RID: 6301
			Core,
			// Token: 0x0400189E RID: 6302
			HDR,
			// Token: 0x0400189F RID: 6303
			Count
		}

		// Token: 0x020001FD RID: 509
		public sealed class BlitMaterialData : ValueType
		{
			// Token: 0x06002327 RID: 8999 RVA: 0x00085070 File Offset: 0x00083270
			// Note: this type is marked as 'beforefieldinit'.
			static BlitMaterialData()
			{
				Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "BlitMaterialData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr);
				FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr, "material");
				FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_nearestSamplerPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr, "nearestSamplerPass");
				FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_bilinearSamplerPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr, "bilinearSamplerPass");
			}

			// Token: 0x06002328 RID: 9000 RVA: 0x000141DA File Offset: 0x000123DA
			public BlitMaterialData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002329 RID: 9001 RVA: 0x000141E3 File Offset: 0x000123E3
			public BlitMaterialData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr))
			{
			}

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x0600232A RID: 9002 RVA: 0x000850D8 File Offset: 0x000832D8
			// (set) Token: 0x0600232B RID: 9003 RVA: 0x000141F5 File Offset: 0x000123F5
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x0600232C RID: 9004 RVA: 0x00085108 File Offset: 0x00083308
			// (set) Token: 0x0600232D RID: 9005 RVA: 0x00014214 File Offset: 0x00012414
			public unsafe int nearestSamplerPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_nearestSamplerPass);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_nearestSamplerPass)) = value;
				}
			}

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x0600232E RID: 9006 RVA: 0x00085130 File Offset: 0x00083330
			// (set) Token: 0x0600232F RID: 9007 RVA: 0x0001422F File Offset: 0x0001242F
			public unsafe int bilinearSamplerPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_bilinearSamplerPass);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.BlitMaterialData.NativeFieldInfoPtr_bilinearSamplerPass)) = value;
				}
			}

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeFieldInfoPtr_nearestSamplerPass;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeFieldInfoPtr_bilinearSamplerPass;
		}

		// Token: 0x020001FE RID: 510
		public class PassData : Object
		{
			// Token: 0x06002330 RID: 9008 RVA: 0x00085158 File Offset: 0x00083358
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr);
				FinalBlitPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "source");
				FinalBlitPass.PassData.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "destination");
				FinalBlitPass.PassData.NativeFieldInfoPtr_sourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "sourceID");
				FinalBlitPass.PassData.NativeFieldInfoPtr_hdrOutputLuminanceParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "hdrOutputLuminanceParams");
				FinalBlitPass.PassData.NativeFieldInfoPtr_requireSrgbConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "requireSrgbConversion");
				FinalBlitPass.PassData.NativeFieldInfoPtr_blitMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "blitMaterialData");
				FinalBlitPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, "renderingData");
				FinalBlitPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr, 100666293);
			}

			// Token: 0x06002331 RID: 9009 RVA: 0x00085224 File Offset: 0x00083424
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlitPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002332 RID: 9010 RVA: 0x0001424A File Offset: 0x0001244A
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06002333 RID: 9011 RVA: 0x00085260 File Offset: 0x00083460
			// (set) Token: 0x06002334 RID: 9012 RVA: 0x00014253 File Offset: 0x00012453
			public unsafe TextureHandle source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_source);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_source)) = value;
				}
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06002335 RID: 9013 RVA: 0x00085288 File Offset: 0x00083488
			// (set) Token: 0x06002336 RID: 9014 RVA: 0x0001426E File Offset: 0x0001246E
			public unsafe TextureHandle destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06002337 RID: 9015 RVA: 0x000852B0 File Offset: 0x000834B0
			// (set) Token: 0x06002338 RID: 9016 RVA: 0x00014289 File Offset: 0x00012489
			public unsafe int sourceID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_sourceID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_sourceID)) = value;
				}
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06002339 RID: 9017 RVA: 0x000852D8 File Offset: 0x000834D8
			// (set) Token: 0x0600233A RID: 9018 RVA: 0x000142A4 File Offset: 0x000124A4
			public unsafe Vector4 hdrOutputLuminanceParams
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_hdrOutputLuminanceParams);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_hdrOutputLuminanceParams)) = value;
				}
			}

			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x0600233B RID: 9019 RVA: 0x00085300 File Offset: 0x00083500
			// (set) Token: 0x0600233C RID: 9020 RVA: 0x000142BF File Offset: 0x000124BF
			public unsafe bool requireSrgbConversion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_requireSrgbConversion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_requireSrgbConversion)) = value;
				}
			}

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x0600233D RID: 9021 RVA: 0x00085328 File Offset: 0x00083528
			// (set) Token: 0x0600233E RID: 9022 RVA: 0x000142DA File Offset: 0x000124DA
			public FinalBlitPass.BlitMaterialData blitMaterialData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_blitMaterialData);
					return new FinalBlitPass.BlitMaterialData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_blitMaterialData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FinalBlitPass.BlitMaterialData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x0600233F RID: 9023 RVA: 0x00085358 File Offset: 0x00083558
			// (set) Token: 0x06002340 RID: 9024 RVA: 0x00014308 File Offset: 0x00012508
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlitPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeFieldInfoPtr_sourceID;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeFieldInfoPtr_hdrOutputLuminanceParams;

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeFieldInfoPtr_requireSrgbConversion;

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeFieldInfoPtr_blitMaterialData;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FF RID: 511
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002341 RID: 9025 RVA: 0x00085388 File Offset: 0x00083588
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBlitPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr);
				FinalBlitPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr, "<>9");
				FinalBlitPass.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr, "<>9__16_0");
				FinalBlitPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr, 100666295);
				FinalBlitPass.__c.NativeMethodInfoPtr__Render_b__16_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr, 100666296);
			}

			// Token: 0x06002342 RID: 9026 RVA: 0x00085404 File Offset: 0x00083604
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlitPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002343 RID: 9027 RVA: 0x00085440 File Offset: 0x00083640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627962, XrefRangeEnd = 627994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__16_0(FinalBlitPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlitPass.__c.NativeMethodInfoPtr__Render_b__16_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002344 RID: 9028 RVA: 0x00014336 File Offset: 0x00012536
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x06002345 RID: 9029 RVA: 0x00085494 File Offset: 0x00083694
			// (set) Token: 0x06002346 RID: 9030 RVA: 0x0001433F File Offset: 0x0001253F
			public unsafe static FinalBlitPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalBlitPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x06002347 RID: 9031 RVA: 0x000854BC File Offset: 0x000836BC
			// (set) Token: 0x06002348 RID: 9032 RVA: 0x00014351 File Offset: 0x00012551
			public unsafe static RenderFunc<FinalBlitPass.PassData> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FinalBlitPass.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<FinalBlitPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FinalBlitPass.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__16_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}

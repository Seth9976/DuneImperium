using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AD RID: 173
	public class DrawScreenSpaceUIPass : ScriptableRenderPass
	{
		// Token: 0x06000D9B RID: 3483 RVA: 0x000445C0 File Offset: 0x000427C0
		// Note: this type is marked as 'beforefieldinit'.
		static DrawScreenSpaceUIPass()
		{
			Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DrawScreenSpaceUIPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr);
			DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "m_PassData");
			DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_ColorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "m_ColorTarget");
			DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_DepthTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "m_DepthTarget");
			DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_RenderOffscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "m_RenderOffscreen");
			DrawScreenSpaceUIPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665060);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_ConfigureColorDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665061);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_ConfigureDepthDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665062);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665063);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665064);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665065);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665066);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_RenderOffscreen_Internal_Void_RenderGraph_Int32_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665067);
			DrawScreenSpaceUIPass.NativeMethodInfoPtr_RenderOverlay_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, 100665068);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000446F4 File Offset: 0x000428F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 612463, RefRangeEnd = 612467, XrefRangeStart = 612447, XrefRangeEnd = 612463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderOffscreen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0004474C File Offset: 0x0004294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612467, XrefRangeEnd = 612469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_ConfigureColorDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0004479C File Offset: 0x0004299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612469, XrefRangeEnd = 612471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_ConfigureDepthDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000447F8 File Offset: 0x000429F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612471, XrefRangeEnd = 612477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, DrawScreenSpaceUIPass.PassData passData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0004483C File Offset: 0x00042A3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 612479, RefRangeEnd = 612483, XrefRangeStart = 612477, XrefRangeEnd = 612479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00044870 File Offset: 0x00042A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 612496, RefRangeEnd = 612498, XrefRangeStart = 612483, XrefRangeEnd = 612496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ref CameraData cameraData, int depthBufferBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000448C4 File Offset: 0x00042AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612498, XrefRangeEnd = 612545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawScreenSpaceUIPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00044920 File Offset: 0x00042B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612545, XrefRangeEnd = 612588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOffscreen(RenderGraph renderGraph, int depthBufferBits, out TextureHandle output, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &output;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_RenderOffscreen_Internal_Void_RenderGraph_Int32_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00044994 File Offset: 0x00042B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612588, XrefRangeEnd = 612618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOverlay(RenderGraph renderGraph, [In] ref TextureHandle colorBuffer, [In] ref TextureHandle depthBuffer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.NativeMethodInfoPtr_RenderOverlay_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0000872F File Offset: 0x0000692F
		public DrawScreenSpaceUIPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00044A08 File Offset: 0x00042C08
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00008738 File Offset: 0x00006938
		public unsafe DrawScreenSpaceUIPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00044A38 File Offset: 0x00042C38
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00008757 File Offset: 0x00006957
		public unsafe RTHandle m_ColorTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_ColorTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_ColorTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00044A68 File Offset: 0x00042C68
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00008776 File Offset: 0x00006976
		public unsafe RTHandle m_DepthTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_DepthTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_DepthTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00044A98 File Offset: 0x00042C98
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00008795 File Offset: 0x00006995
		public unsafe bool m_RenderOffscreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_RenderOffscreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.NativeFieldInfoPtr_m_RenderOffscreen)) = value;
			}
		}

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTarget;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthTarget;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderOffscreen;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureColorDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDepthDescriptor_Public_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_CameraData_Int32_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_RenderOffscreen_Internal_Void_RenderGraph_Int32_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_RenderOverlay_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x0200019E RID: 414
		public class PassData : Object
		{
			// Token: 0x06001E3F RID: 7743 RVA: 0x00079BA8 File Offset: 0x00077DA8
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr);
				DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr, "cmd");
				DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr, "camera");
				DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_offscreenTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr, "offscreenTexture");
				DrawScreenSpaceUIPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr, 100665069);
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x00079C24 File Offset: 0x00077E24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawScreenSpaceUIPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E41 RID: 7745 RVA: 0x00011578 File Offset: 0x0000F778
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD1 RID: 2769
			// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00079C60 File Offset: 0x00077E60
			// (set) Token: 0x06001E43 RID: 7747 RVA: 0x00011581 File Offset: 0x0000F781
			public unsafe CommandBuffer cmd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_cmd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00079C90 File Offset: 0x00077E90
			// (set) Token: 0x06001E45 RID: 7749 RVA: 0x000115A0 File Offset: 0x0000F7A0
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00079CC0 File Offset: 0x00077EC0
			// (set) Token: 0x06001E47 RID: 7751 RVA: 0x000115BF File Offset: 0x0000F7BF
			public unsafe TextureHandle offscreenTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_offscreenTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawScreenSpaceUIPass.PassData.NativeFieldInfoPtr_offscreenTexture)) = value;
				}
			}

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeFieldInfoPtr_cmd;

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeFieldInfoPtr_offscreenTexture;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200019F RID: 415
		[ObfuscatedName("UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E48 RID: 7752 RVA: 0x00079CE8 File Offset: 0x00077EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawScreenSpaceUIPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr);
				DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, "<>9");
				DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, "<>9__12_0");
				DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, "<>9__13_0");
				DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, 100665071);
				DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__RenderOffscreen_b__12_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, 100665072);
				DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__RenderOverlay_b__13_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr, 100665073);
			}

			// Token: 0x06001E49 RID: 7753 RVA: 0x00079D8C File Offset: 0x00077F8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawScreenSpaceUIPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x00079DC8 File Offset: 0x00077FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612426, XrefRangeEnd = 612441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RenderOffscreen_b__12_0(DrawScreenSpaceUIPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__RenderOffscreen_b__12_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E4B RID: 7755 RVA: 0x00079E1C File Offset: 0x0007801C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612441, XrefRangeEnd = 612447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RenderOverlay_b__13_0(DrawScreenSpaceUIPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawScreenSpaceUIPass.__c.NativeMethodInfoPtr__RenderOverlay_b__13_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E4C RID: 7756 RVA: 0x000115DA File Offset: 0x0000F7DA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00079E70 File Offset: 0x00078070
			// (set) Token: 0x06001E4E RID: 7758 RVA: 0x000115E3 File Offset: 0x0000F7E3
			public unsafe static DrawScreenSpaceUIPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00079E98 File Offset: 0x00078098
			// (set) Token: 0x06001E50 RID: 7760 RVA: 0x000115F5 File Offset: 0x0000F7F5
			public unsafe static RenderFunc<DrawScreenSpaceUIPass.PassData> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DrawScreenSpaceUIPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x06001E51 RID: 7761 RVA: 0x00079EC0 File Offset: 0x000780C0
			// (set) Token: 0x06001E52 RID: 7762 RVA: 0x00011607 File Offset: 0x0000F807
			public unsafe static RenderFunc<DrawScreenSpaceUIPass.PassData> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DrawScreenSpaceUIPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawScreenSpaceUIPass.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeMethodInfoPtr__RenderOffscreen_b__12_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeMethodInfoPtr__RenderOverlay_b__13_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}

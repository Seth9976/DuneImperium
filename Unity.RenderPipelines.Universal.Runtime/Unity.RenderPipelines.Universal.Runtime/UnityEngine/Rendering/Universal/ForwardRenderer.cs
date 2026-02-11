using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200007D RID: 125
	public sealed class ForwardRenderer : ScriptableRenderer
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003AD60 File Offset: 0x00038F60
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardRenderer()
		{
			Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ForwardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr);
			ForwardRenderer.NativeFieldInfoPtr_k_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, "k_ErrorMessage");
			ForwardRenderer.NativeMethodInfoPtr__ctor_Public_Void_ForwardRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664713);
			ForwardRenderer.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664714);
			ForwardRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664715);
			ForwardRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664716);
			ForwardRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664717);
			ForwardRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664718);
			ForwardRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr, 100664719);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003AE30 File Offset: 0x00039030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608672, XrefRangeEnd = 608684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardRenderer(ForwardRendererData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardRenderer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr__ctor_Public_Void_ForwardRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003AE7C File Offset: 0x0003907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608684, XrefRangeEnd = 608693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003AED0 File Offset: 0x000390D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608693, XrefRangeEnd = 608702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003AF24 File Offset: 0x00039124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608702, XrefRangeEnd = 608711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullingParameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003AF78 File Offset: 0x00039178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608711, XrefRangeEnd = 608720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishRendering(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003AFBC File Offset: 0x000391BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608720, XrefRangeEnd = 608736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SwapColorBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003B000 File Offset: 0x00039200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608736, XrefRangeEnd = 608741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRenderer.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00006FB1 File Offset: 0x000051B1
		public ForwardRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0003B050 File Offset: 0x00039250
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00006FBA File Offset: 0x000051BA
		public unsafe static string k_ErrorMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardRenderer.NativeFieldInfoPtr_k_ErrorMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardRenderer.NativeFieldInfoPtr_k_ErrorMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_k_ErrorMessage;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ForwardRendererData_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;
	}
}

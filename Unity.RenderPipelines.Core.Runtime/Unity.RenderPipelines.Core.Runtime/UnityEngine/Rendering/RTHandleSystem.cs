using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BE RID: 190
	public class RTHandleSystem : Object
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x0003DE98 File Offset: 0x0003C098
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandleSystem()
		{
			Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr);
			RTHandleSystem.NativeFieldInfoPtr_m_HardwareDynamicResRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_HardwareDynamicResRequested");
			RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_AutoSizedRTs");
			RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_AutoSizedRTsArray");
			RTHandleSystem.NativeFieldInfoPtr_m_ResizeOnDemandRTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_ResizeOnDemandRTs");
			RTHandleSystem.NativeFieldInfoPtr_m_RTHandleProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_RTHandleProperties");
			RTHandleSystem.NativeFieldInfoPtr_m_MaxWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_MaxWidths");
			RTHandleSystem.NativeFieldInfoPtr_m_MaxHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, "m_MaxHeights");
			RTHandleSystem.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665225);
			RTHandleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665226);
			RTHandleSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665227);
			RTHandleSystem.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665228);
			RTHandleSystem.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665229);
			RTHandleSystem.NativeMethodInfoPtr_Release_Public_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665230);
			RTHandleSystem.NativeMethodInfoPtr_Remove_Internal_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665231);
			RTHandleSystem.NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665232);
			RTHandleSystem.NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665233);
			RTHandleSystem.NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665234);
			RTHandleSystem.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Internal_Vector2_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665235);
			RTHandleSystem.NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665236);
			RTHandleSystem.NativeMethodInfoPtr_SwitchResizeMode_Internal_Void_RTHandle_ResizeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665237);
			RTHandleSystem.NativeMethodInfoPtr_DemandResize_Private_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665238);
			RTHandleSystem.NativeMethodInfoPtr_GetMaxWidth_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665239);
			RTHandleSystem.NativeMethodInfoPtr_GetMaxHeight_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665240);
			RTHandleSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665241);
			RTHandleSystem.NativeMethodInfoPtr_Resize_Private_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665242);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665243);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665244);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665245);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665246);
			RTHandleSystem.NativeMethodInfoPtr_AllocAutoSizedRenderTexture_Private_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665247);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665248);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665249);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665250);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665251);
			RTHandleSystem.NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665252);
			RTHandleSystem.NativeMethodInfoPtr_DumpRTInfo_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr, 100665253);
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0003E198 File Offset: 0x0003C398
		public unsafe RTHandleProperties rtHandleProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972540, RefRangeEnd = 972541, XrefRangeStart = 972527, XrefRangeEnd = 972540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandleSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTHandleSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0003E210 File Offset: 0x0003C410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972541, XrefRangeEnd = 972542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0003E244 File Offset: 0x0003C444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 972577, RefRangeEnd = 972580, XrefRangeStart = 972542, XrefRangeEnd = 972577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0003E290 File Offset: 0x0003C490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972580, XrefRangeEnd = 972581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useLegacyDynamicResControl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 972591, RefRangeEnd = 972597, XrefRangeStart = 972581, XrefRangeEnd = 972591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(RTHandle rth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rth);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Release_Public_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0003E330 File Offset: 0x0003C530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972597, XrefRangeEnd = 972601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(RTHandle rth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rth);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Remove_Internal_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0003E374 File Offset: 0x0003C574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972601, XrefRangeEnd = 972602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetReferenceSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0003E3C0 File Offset: 0x0003C5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972602, XrefRangeEnd = 972603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferenceSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0003E40C File Offset: 0x0003C60C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 972613, RefRangeEnd = 972619, XrefRangeStart = 972603, XrefRangeEnd = 972613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferenceSize(int width, int height, bool reset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0003E468 File Offset: 0x0003C668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 972638, RefRangeEnd = 972641, XrefRangeStart = 972619, XrefRangeEnd = 972638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateRatioAgainstMaxSize([In] ref Vector2Int viewportSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewportSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Internal_Vector2_byref_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972641, XrefRangeEnd = 972656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHardwareDynamicResolutionState(bool enableHWDynamicRes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableHWDynamicRes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0003E4F4 File Offset: 0x0003C6F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972666, RefRangeEnd = 972668, XrefRangeStart = 972656, XrefRangeEnd = 972666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchResizeMode(RTHandle rth, RTHandleSystem.ResizeMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rth);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_SwitchResizeMode_Internal_Void_RTHandle_ResizeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0003E544 File Offset: 0x0003C744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972683, RefRangeEnd = 972684, XrefRangeStart = 972668, XrefRangeEnd = 972683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DemandResize(RTHandle rth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rth);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_DemandResize_Private_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0003E588 File Offset: 0x0003C788
		[CallerCount(0)]
		public unsafe int GetMaxWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_GetMaxWidth_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0003E5C4 File Offset: 0x0003C7C4
		[CallerCount(0)]
		public unsafe int GetMaxHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_GetMaxHeight_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0003E600 File Offset: 0x0003C800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 972703, RefRangeEnd = 972706, XrefRangeStart = 972684, XrefRangeEnd = 972703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0003E640 File Offset: 0x0003C840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972735, RefRangeEnd = 972736, XrefRangeStart = 972706, XrefRangeEnd = 972735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int width, int height, bool sizeChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Resize_Private_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0003E69C File Offset: 0x0003C89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972736, XrefRangeEnd = 972737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoGenerateMips;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindTextureMS;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryless;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0003E804 File Offset: 0x0003CA04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972801, RefRangeEnd = 972806, XrefRangeStart = 972737, XrefRangeEnd = 972801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapModeU;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapModeV;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapModeW;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoGenerateMips;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindTextureMS;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryless;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0003E98C File Offset: 0x0003CB8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972809, RefRangeEnd = 972811, XrefRangeStart = 972806, XrefRangeEnd = 972809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleFactor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoGenerateMips;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindTextureMS;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryless;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972813, RefRangeEnd = 972815, XrefRangeStart = 972811, XrefRangeEnd = 972813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaleFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoGenerateMips;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindTextureMS;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryless;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0003EC40 File Offset: 0x0003CE40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972883, RefRangeEnd = 972885, XrefRangeStart = 972815, XrefRangeEnd = 972883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoGenerateMips;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindTextureMS;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryless;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_AllocAutoSizedRenderTexture_Private_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0003EDA8 File Offset: 0x0003CFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972885, XrefRangeEnd = 972893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(RenderTexture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972893, XrefRangeEnd = 972903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0003EE48 File Offset: 0x0003D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972903, XrefRangeEnd = 972906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(RenderTargetIdentifier texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0003EE94 File Offset: 0x0003D094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 972914, RefRangeEnd = 972917, XrefRangeStart = 972906, XrefRangeEnd = 972914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Alloc(RenderTargetIdentifier texture, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0003EEF4 File Offset: 0x0003D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972917, XrefRangeEnd = 972923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(RTHandle tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0003EF38 File Offset: 0x0003D138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972923, XrefRangeEnd = 972959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DumpRTInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleSystem.NativeMethodInfoPtr_DumpRTInfo_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00007DC6 File Offset: 0x00005FC6
		public RTHandleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0003EF70 File Offset: 0x0003D170
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00007DCF File Offset: 0x00005FCF
		public unsafe bool m_HardwareDynamicResRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_HardwareDynamicResRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_HardwareDynamicResRequested)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0003EF98 File Offset: 0x0003D198
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00007DEA File Offset: 0x00005FEA
		public unsafe HashSet<RTHandle> m_AutoSizedRTs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00007E09 File Offset: 0x00006009
		public unsafe Il2CppReferenceArray<RTHandle> m_AutoSizedRTsArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTsArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_AutoSizedRTsArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0003EFF8 File Offset: 0x0003D1F8
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00007E28 File Offset: 0x00006028
		public unsafe HashSet<RTHandle> m_ResizeOnDemandRTs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_ResizeOnDemandRTs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_ResizeOnDemandRTs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0003F028 File Offset: 0x0003D228
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00007E47 File Offset: 0x00006047
		public unsafe RTHandleProperties m_RTHandleProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_RTHandleProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_RTHandleProperties)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0003F050 File Offset: 0x0003D250
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00007E62 File Offset: 0x00006062
		public unsafe int m_MaxWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_MaxWidths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_MaxWidths)) = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0003F078 File Offset: 0x0003D278
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00007E7D File Offset: 0x0000607D
		public unsafe int m_MaxHeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_MaxHeights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleSystem.NativeFieldInfoPtr_m_MaxHeights)) = value;
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_m_HardwareDynamicResRequested;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizedRTs;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizedRTsArray;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_m_ResizeOnDemandRTs;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_m_RTHandleProperties;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxWidths;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxHeights;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_RTHandle_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_RTHandle_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceSize_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Internal_Vector2_byref_Vector2Int_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Void_Boolean_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_SwitchResizeMode_Internal_Void_RTHandle_ResizeMode_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_DemandResize_Private_Void_RTHandle_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxWidth_Public_Int32_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxHeight_Public_Int32_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_AllocAutoSizedRenderTexture_Private_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTexture_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_Texture_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_RTHandle_RenderTargetIdentifier_String_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_DumpRTInfo_Internal_String_0;

		// Token: 0x020001EA RID: 490
		public enum ResizeMode
		{
			// Token: 0x04001313 RID: 4883
			Auto,
			// Token: 0x04001314 RID: 4884
			OnDemand
		}
	}
}

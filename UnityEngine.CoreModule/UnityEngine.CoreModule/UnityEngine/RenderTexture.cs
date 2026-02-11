using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E7 RID: 231
	public class RenderTexture : Texture
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x0005AC24 File Offset: 0x00058E24
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTexture()
		{
			Il2CppClassPointerStore<RenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr);
			RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665812);
			RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665813);
			RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665814);
			RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665815);
			RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665816);
			RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665817);
			RenderTexture.NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665818);
			RenderTexture.NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665819);
			RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665820);
			RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665821);
			RenderTexture.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665822);
			RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665823);
			RenderTexture.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665824);
			RenderTexture.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665825);
			RenderTexture.NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665826);
			RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665827);
			RenderTexture.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665828);
			RenderTexture.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665829);
			RenderTexture.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665830);
			RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665831);
			RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665832);
			RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665833);
			RenderTexture.NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665834);
			RenderTexture.NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665835);
			RenderTexture.NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665836);
			RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665837);
			RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665838);
			RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665839);
			RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665840);
			RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665841);
			RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665842);
			RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665843);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665844);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665845);
			RenderTexture.NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665846);
			RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665847);
			RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665848);
			RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665849);
			RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665850);
			RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665851);
			RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665852);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665853);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665854);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665855);
			RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665856);
			RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665857);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665858);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665859);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665860);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665861);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665862);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665863);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665864);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665865);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665866);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665867);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665868);
			RenderTexture.NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665869);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665870);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665871);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665872);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665873);
			RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665874);
			RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665875);
			RenderTexture.NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665876);
			RenderTexture.NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665877);
			RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665878);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665879);
			RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665880);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665881);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665882);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665883);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665884);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665885);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665886);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665887);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665888);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665889);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665890);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665891);
			RenderTexture.get_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.get_vrUsageDelegate>("UnityEngine.RenderTexture::get_vrUsage");
			RenderTexture.get_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.get_memorylessModeDelegate>("UnityEngine.RenderTexture::get_memorylessMode");
			RenderTexture.get_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_stencilFormatDelegate>("UnityEngine.RenderTexture::get_stencilFormat");
			RenderTexture.get_autoGenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.get_autoGenerateMipsDelegate>("UnityEngine.RenderTexture::get_autoGenerateMips");
			RenderTexture.get_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.get_bindTextureMSDelegate>("UnityEngine.RenderTexture::get_bindTextureMS");
			RenderTexture.get_enableRandomWriteDelegateField = IL2CPP.ResolveICall<RenderTexture.get_enableRandomWriteDelegate>("UnityEngine.RenderTexture::get_enableRandomWrite");
			RenderTexture.GetIsPowerOfTwoDelegateField = IL2CPP.ResolveICall<RenderTexture.GetIsPowerOfTwoDelegate>("UnityEngine.RenderTexture::GetIsPowerOfTwo");
			RenderTexture.SetShadowSamplingModeDelegateField = IL2CPP.ResolveICall<RenderTexture.SetShadowSamplingModeDelegate>("UnityEngine.RenderTexture::SetShadowSamplingMode");
			RenderTexture.GetNativeDepthBufferPtrDelegateField = IL2CPP.ResolveICall<RenderTexture.GetNativeDepthBufferPtrDelegate>("UnityEngine.RenderTexture::GetNativeDepthBufferPtr");
			RenderTexture.DiscardContentsDelegateField = IL2CPP.ResolveICall<RenderTexture.DiscardContentsDelegate>("UnityEngine.RenderTexture::DiscardContents");
			RenderTexture.MarkRestoreExpectedDelegateField = IL2CPP.ResolveICall<RenderTexture.MarkRestoreExpectedDelegate>("UnityEngine.RenderTexture::MarkRestoreExpected");
			RenderTexture.ResolveAADelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAADelegate>("UnityEngine.RenderTexture::ResolveAA");
			RenderTexture.ResolveAAToDelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAAToDelegate>("UnityEngine.RenderTexture::ResolveAATo");
			RenderTexture.SetGlobalShaderPropertyDelegateField = IL2CPP.ResolveICall<RenderTexture.SetGlobalShaderPropertyDelegate>("UnityEngine.RenderTexture::SetGlobalShaderProperty");
			RenderTexture.IsCreatedDelegateField = IL2CPP.ResolveICall<RenderTexture.IsCreatedDelegate>("UnityEngine.RenderTexture::IsCreated");
			RenderTexture.GenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.GenerateMipsDelegate>("UnityEngine.RenderTexture::GenerateMips");
			RenderTexture.ConvertToEquirectDelegateField = IL2CPP.ResolveICall<RenderTexture.ConvertToEquirectDelegate>("UnityEngine.RenderTexture::ConvertToEquirect");
			RenderTexture.SupportsStencilDelegateField = IL2CPP.ResolveICall<RenderTexture.SupportsStencilDelegate>("UnityEngine.RenderTexture::SupportsStencil");
			RenderTexture.get_depthDelegateField = IL2CPP.ResolveICall<RenderTexture.get_depthDelegate>("UnityEngine.RenderTexture::get_depth");
			RenderTexture.set_depthDelegateField = IL2CPP.ResolveICall<RenderTexture.set_depthDelegate>("UnityEngine.RenderTexture::set_depth");
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0005B3C0 File Offset: 0x000595C0
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0005B408 File Offset: 0x00059608
		public unsafe override int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656957, XrefRangeEnd = 656959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656959, XrefRangeEnd = 656961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0005B454 File Offset: 0x00059654
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0005B49C File Offset: 0x0005969C
		public unsafe override int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656961, XrefRangeEnd = 656963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656963, XrefRangeEnd = 656965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0005B4E8 File Offset: 0x000596E8
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0005B530 File Offset: 0x00059730
		public unsafe override UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656965, XrefRangeEnd = 656967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656967, XrefRangeEnd = 656969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0005B57C File Offset: 0x0005977C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656969, XrefRangeEnd = 656971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref suppressWarnings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0005B5C8 File Offset: 0x000597C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656971, XrefRangeEnd = 656973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0005B608 File Offset: 0x00059808
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0005B644 File Offset: 0x00059844
		public new unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 656975, RefRangeEnd = 656990, XrefRangeStart = 656973, XrefRangeEnd = 656975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0005B684 File Offset: 0x00059884
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x0005B6C0 File Offset: 0x000598C0
		public unsafe bool useMipMap
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 656992, RefRangeEnd = 656995, XrefRangeStart = 656990, XrefRangeEnd = 656992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 656997, RefRangeEnd = 657004, XrefRangeStart = 656995, XrefRangeEnd = 656997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0005B700 File Offset: 0x00059900
		public unsafe bool sRGB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657006, RefRangeEnd = 657007, XrefRangeStart = 657004, XrefRangeEnd = 657006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00007933 File Offset: 0x00005B33
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0005B73C File Offset: 0x0005993C
		public unsafe VRTextureUsage vrUsage
		{
			get
			{
				return RenderTexture.get_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 657009, RefRangeEnd = 657013, XrefRangeStart = 657007, XrefRangeEnd = 657009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00007945 File Offset: 0x00005B45
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0005B77C File Offset: 0x0005997C
		public unsafe RenderTextureMemoryless memorylessMode
		{
			get
			{
				return RenderTexture.get_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 657015, RefRangeEnd = 657019, XrefRangeStart = 657013, XrefRangeEnd = 657015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0005B7BC File Offset: 0x000599BC
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x00007957 File Offset: 0x00005B57
		public unsafe RenderTextureFormat format
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 657024, RefRangeEnd = 657026, XrefRangeStart = 657019, XrefRangeEnd = 657024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0000796D File Offset: 0x00005B6D
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0005B7F8 File Offset: 0x000599F8
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return RenderTexture.get_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 657028, RefRangeEnd = 657030, XrefRangeStart = 657026, XrefRangeEnd = 657028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0005B838 File Offset: 0x00059A38
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0005B874 File Offset: 0x00059A74
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657032, RefRangeEnd = 657033, XrefRangeStart = 657030, XrefRangeEnd = 657032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657033, XrefRangeEnd = 657035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x0000797F File Offset: 0x00005B7F
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0005B8B4 File Offset: 0x00059AB4
		public unsafe bool autoGenerateMips
		{
			get
			{
				return RenderTexture.get_autoGenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 657037, RefRangeEnd = 657044, XrefRangeStart = 657035, XrefRangeEnd = 657037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0005B8F4 File Offset: 0x00059AF4
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0005B930 File Offset: 0x00059B30
		public unsafe int volumeDepth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 657046, RefRangeEnd = 657048, XrefRangeStart = 657044, XrefRangeEnd = 657046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 657050, RefRangeEnd = 657057, XrefRangeStart = 657048, XrefRangeEnd = 657050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0005B970 File Offset: 0x00059B70
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0005B9AC File Offset: 0x00059BAC
		public unsafe int antiAliasing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 657059, RefRangeEnd = 657062, XrefRangeStart = 657057, XrefRangeEnd = 657059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 657064, RefRangeEnd = 657068, XrefRangeStart = 657062, XrefRangeEnd = 657064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00007991 File Offset: 0x00005B91
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x0005B9EC File Offset: 0x00059BEC
		public unsafe bool bindTextureMS
		{
			get
			{
				return RenderTexture.get_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 657070, RefRangeEnd = 657074, XrefRangeStart = 657068, XrefRangeEnd = 657070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000079A3 File Offset: 0x00005BA3
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0005BA2C File Offset: 0x00059C2C
		public unsafe bool enableRandomWrite
		{
			get
			{
				return RenderTexture.get_enableRandomWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 657076, RefRangeEnd = 657084, XrefRangeStart = 657074, XrefRangeEnd = 657076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0005BA6C File Offset: 0x00059C6C
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0005BAA8 File Offset: 0x00059CA8
		public unsafe bool useDynamicScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 657086, RefRangeEnd = 657088, XrefRangeStart = 657084, XrefRangeEnd = 657086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 657090, RefRangeEnd = 657096, XrefRangeStart = 657088, XrefRangeEnd = 657090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0005BAE8 File Offset: 0x00059CE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 657098, RefRangeEnd = 657104, XrefRangeStart = 657096, XrefRangeEnd = 657098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0005BB1C File Offset: 0x00059D1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 657106, RefRangeEnd = 657111, XrefRangeStart = 657104, XrefRangeEnd = 657106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActive(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0005BB54 File Offset: 0x00059D54
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0005BB88 File Offset: 0x00059D88
		public unsafe static RenderTexture active
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 657098, RefRangeEnd = 657104, XrefRangeStart = 657098, XrefRangeEnd = 657104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 657106, RefRangeEnd = 657111, XrefRangeStart = 657106, XrefRangeEnd = 657111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0005BBC0 File Offset: 0x00059DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657111, XrefRangeEnd = 657113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetColorBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0005BBFC File Offset: 0x00059DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657113, XrefRangeEnd = 657115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetDepthBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0005BC38 File Offset: 0x00059E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657115, XrefRangeEnd = 657117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMipMapCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0005BC78 File Offset: 0x00059E78
		public unsafe RenderBuffer colorBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657117, XrefRangeEnd = 657119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0005BCB4 File Offset: 0x00059EB4
		public unsafe RenderBuffer depthBuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657121, RefRangeEnd = 657122, XrefRangeStart = 657119, XrefRangeEnd = 657121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0005BCF0 File Offset: 0x00059EF0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 657124, RefRangeEnd = 657137, XrefRangeStart = 657122, XrefRangeEnd = 657124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0005BD2C File Offset: 0x00059F2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 657139, RefRangeEnd = 657145, XrefRangeStart = 657137, XrefRangeEnd = 657139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0005BD60 File Offset: 0x00059F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657145, XrefRangeEnd = 657147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSRGBReadWrite(bool srgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srgb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0005BDA0 File Offset: 0x00059FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657147, XrefRangeEnd = 657149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0005BDD8 File Offset: 0x00059FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657149, XrefRangeEnd = 657151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0005BE18 File Offset: 0x0005A018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657151, XrefRangeEnd = 657153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0005BE54 File Offset: 0x0005A054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657153, XrefRangeEnd = 657155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0005BE94 File Offset: 0x0005A094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657157, RefRangeEnd = 657158, XrefRangeStart = 657155, XrefRangeEnd = 657157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseTemporary(RenderTexture temp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0005BECC File Offset: 0x0005A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657158, XrefRangeEnd = 657165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0005BF08 File Offset: 0x0005A108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 657177, RefRangeEnd = 657180, XrefRangeStart = 657165, XrefRangeEnd = 657177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTextureDescriptor desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0005BF50 File Offset: 0x0005A150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657180, XrefRangeEnd = 657200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTexture textureToCopy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureToCopy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0005BF9C File Offset: 0x0005A19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657200, XrefRangeEnd = 657213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0005C010 File Offset: 0x0005A210
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 657218, RefRangeEnd = 657223, XrefRangeStart = 657213, XrefRangeEnd = 657218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0005C084 File Offset: 0x0005A284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657250, RefRangeEnd = 657251, XrefRangeStart = 657223, XrefRangeEnd = 657250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0005C104 File Offset: 0x0005A304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657277, RefRangeEnd = 657279, XrefRangeStart = 657251, XrefRangeEnd = 657277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0005C184 File Offset: 0x0005A384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657279, XrefRangeEnd = 657284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0005C1F8 File Offset: 0x0005A3F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657293, RefRangeEnd = 657295, XrefRangeStart = 657284, XrefRangeEnd = 657293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0005C278 File Offset: 0x0005A478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657307, RefRangeEnd = 657308, XrefRangeStart = 657295, XrefRangeEnd = 657307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0005C2EC File Offset: 0x0005A4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657320, RefRangeEnd = 657321, XrefRangeStart = 657308, XrefRangeEnd = 657320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0005C350 File Offset: 0x0005A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657321, XrefRangeEnd = 657329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 657346, RefRangeEnd = 657350, XrefRangeStart = 657329, XrefRangeEnd = 657346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0005C454 File Offset: 0x0005A654
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 657354, RefRangeEnd = 657359, XrefRangeStart = 657350, XrefRangeEnd = 657354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0005C4A0 File Offset: 0x0005A6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657359, XrefRangeEnd = 657360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0005C4EC File Offset: 0x0005A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0005C538 File Offset: 0x0005A738
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 657364, RefRangeEnd = 657376, XrefRangeStart = 657360, XrefRangeEnd = 657364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedShadowMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0005C584 File Offset: 0x0005A784
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00007AEC File Offset: 0x00005CEC
		public unsafe RenderTextureDescriptor descriptor
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 657378, RefRangeEnd = 657407, XrefRangeStart = 657376, XrefRangeEnd = 657378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderTexture.ValidateRenderTextureDesc(value);
				this.SetRenderTextureDescriptor(value);
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 657416, RefRangeEnd = 657426, XrefRangeStart = 657407, XrefRangeEnd = 657416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
		[CallerCount(0)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0005C634 File Offset: 0x0005A834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657426, XrefRangeEnd = 657428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0005C680 File Offset: 0x0005A880
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 657445, RefRangeEnd = 657452, XrefRangeStart = 657428, XrefRangeEnd = 657445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTextureFormat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0005C6CC File Offset: 0x0005A8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657455, RefRangeEnd = 657457, XrefRangeStart = 657452, XrefRangeEnd = 657455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0005C70C File Offset: 0x0005A90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657457, XrefRangeEnd = 657462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657462, XrefRangeEnd = 657469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0005C864 File Offset: 0x0005AA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657469, XrefRangeEnd = 657475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0005C908 File Offset: 0x0005AB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657475, XrefRangeEnd = 657481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0005C99C File Offset: 0x0005AB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657481, XrefRangeEnd = 657487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0005CA24 File Offset: 0x0005AC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657487, XrefRangeEnd = 657493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0005CA9C File Offset: 0x0005AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657493, XrefRangeEnd = 657499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0005CB08 File Offset: 0x0005AD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657499, XrefRangeEnd = 657501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0005CB48 File Offset: 0x0005AD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657501, XrefRangeEnd = 657503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDepthBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0005CB88 File Offset: 0x0005AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657503, XrefRangeEnd = 657505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0005CBC8 File Offset: 0x0005ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657505, XrefRangeEnd = 657507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDescriptor_Injected(out RenderTextureDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0005CC08 File Offset: 0x0005AE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657507, XrefRangeEnd = 657509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0000792A File Offset: 0x00005B2A
		public RenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000079B5 File Offset: 0x00005BB5
		public bool GetIsPowerOfTwo()
		{
			return RenderTexture.GetIsPowerOfTwoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x0005CC48 File Offset: 0x0005AE48
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x000079C7 File Offset: 0x00005BC7
		public bool isPowerOfTwo
		{
			get
			{
				return this.GetIsPowerOfTwo();
			}
			set
			{
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000079CA File Offset: 0x00005BCA
		public void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode)
		{
			RenderTexture.SetShadowSamplingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), samplingMode);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000079DD File Offset: 0x00005BDD
		public IntPtr GetNativeDepthBufferPtr()
		{
			return RenderTexture.GetNativeDepthBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000079EF File Offset: 0x00005BEF
		public void DiscardContents(bool discardColor, bool discardDepth)
		{
			RenderTexture.DiscardContentsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), discardColor, discardDepth);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00007A03 File Offset: 0x00005C03
		public void MarkRestoreExpected()
		{
			RenderTexture.MarkRestoreExpectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00007A15 File Offset: 0x00005C15
		public void DiscardContents()
		{
			this.DiscardContents(true, true);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00007A21 File Offset: 0x00005C21
		public void ResolveAA()
		{
			RenderTexture.ResolveAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00007A33 File Offset: 0x00005C33
		public void ResolveAATo(RenderTexture rt)
		{
			RenderTexture.ResolveAAToDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00007A4B File Offset: 0x00005C4B
		public void ResolveAntiAliasedSurface()
		{
			this.ResolveAA();
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00007A55 File Offset: 0x00005C55
		public void ResolveAntiAliasedSurface(RenderTexture target)
		{
			this.ResolveAATo(target);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00007A60 File Offset: 0x00005C60
		public void SetGlobalShaderProperty(string propertyName)
		{
			RenderTexture.SetGlobalShaderPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00007A78 File Offset: 0x00005C78
		public bool IsCreated()
		{
			return RenderTexture.IsCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00007A8A File Offset: 0x00005C8A
		public void GenerateMips()
		{
			RenderTexture.GenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00007A9C File Offset: 0x00005C9C
		public void ConvertToEquirect(RenderTexture equirect, [Optional] Camera.MonoOrStereoscopicEye eye)
		{
			RenderTexture.ConvertToEquirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(equirect), eye);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00007AB5 File Offset: 0x00005CB5
		public static bool SupportsStencil(RenderTexture rt)
		{
			return RenderTexture.SupportsStencilDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00007AC7 File Offset: 0x00005CC7
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x00007AD9 File Offset: 0x00005CD9
		public int depth
		{
			get
			{
				return RenderTexture.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0005CC60 File Offset: 0x0005AE60
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, RenderTexture.GetDepthStencilFormatLegacy(depthBuffer, format), format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0005CC8C File Offset: 0x0005AE8C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005CCB0 File Offset: 0x0005AEB0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005CCF0 File Offset: 0x0005AEF0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, 1);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0005CD0C File Offset: 0x0005AF0C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, RenderTextureFormat.Default);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0005CD28 File Offset: 0x0005AF28
		public static RenderTexture GetTemporary(int width, int height)
		{
			return RenderTexture.GetTemporary(width, height, 0);
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0005CD44 File Offset: 0x0005AF44
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00007AFE File Offset: 0x00005CFE
		public bool isCubemap
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Cube;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Cube : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0005CD60 File Offset: 0x0005AF60
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00007B0F File Offset: 0x00005D0F
		public bool isVolume
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Tex3D;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Tex3D : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0005CD7C File Offset: 0x0005AF7C
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00007B20 File Offset: 0x00005D20
		public static bool enabled
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0005CD90 File Offset: 0x0005AF90
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Boolean_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0;

		// Token: 0x04001020 RID: 4128
		private static readonly RenderTexture.get_vrUsageDelegate get_vrUsageDelegateField;

		// Token: 0x04001021 RID: 4129
		private static readonly RenderTexture.get_memorylessModeDelegate get_memorylessModeDelegateField;

		// Token: 0x04001022 RID: 4130
		private static readonly RenderTexture.get_stencilFormatDelegate get_stencilFormatDelegateField;

		// Token: 0x04001023 RID: 4131
		private static readonly RenderTexture.get_autoGenerateMipsDelegate get_autoGenerateMipsDelegateField;

		// Token: 0x04001024 RID: 4132
		private static readonly RenderTexture.get_bindTextureMSDelegate get_bindTextureMSDelegateField;

		// Token: 0x04001025 RID: 4133
		private static readonly RenderTexture.get_enableRandomWriteDelegate get_enableRandomWriteDelegateField;

		// Token: 0x04001026 RID: 4134
		private static readonly RenderTexture.GetIsPowerOfTwoDelegate GetIsPowerOfTwoDelegateField;

		// Token: 0x04001027 RID: 4135
		private static readonly RenderTexture.SetShadowSamplingModeDelegate SetShadowSamplingModeDelegateField;

		// Token: 0x04001028 RID: 4136
		private static readonly RenderTexture.GetNativeDepthBufferPtrDelegate GetNativeDepthBufferPtrDelegateField;

		// Token: 0x04001029 RID: 4137
		private static readonly RenderTexture.DiscardContentsDelegate DiscardContentsDelegateField;

		// Token: 0x0400102A RID: 4138
		private static readonly RenderTexture.MarkRestoreExpectedDelegate MarkRestoreExpectedDelegateField;

		// Token: 0x0400102B RID: 4139
		private static readonly RenderTexture.ResolveAADelegate ResolveAADelegateField;

		// Token: 0x0400102C RID: 4140
		private static readonly RenderTexture.ResolveAAToDelegate ResolveAAToDelegateField;

		// Token: 0x0400102D RID: 4141
		private static readonly RenderTexture.SetGlobalShaderPropertyDelegate SetGlobalShaderPropertyDelegateField;

		// Token: 0x0400102E RID: 4142
		private static readonly RenderTexture.IsCreatedDelegate IsCreatedDelegateField;

		// Token: 0x0400102F RID: 4143
		private static readonly RenderTexture.GenerateMipsDelegate GenerateMipsDelegateField;

		// Token: 0x04001030 RID: 4144
		private static readonly RenderTexture.ConvertToEquirectDelegate ConvertToEquirectDelegateField;

		// Token: 0x04001031 RID: 4145
		private static readonly RenderTexture.SupportsStencilDelegate SupportsStencilDelegateField;

		// Token: 0x04001032 RID: 4146
		private static readonly RenderTexture.get_depthDelegate get_depthDelegateField;

		// Token: 0x04001033 RID: 4147
		private static readonly RenderTexture.set_depthDelegate set_depthDelegateField;

		// Token: 0x020006A5 RID: 1701
		// (Invoke) Token: 0x06003628 RID: 13864
		private delegate VRTextureUsage get_vrUsageDelegate(IntPtr @this);

		// Token: 0x020006A6 RID: 1702
		// (Invoke) Token: 0x0600362A RID: 13866
		private delegate RenderTextureMemoryless get_memorylessModeDelegate(IntPtr @this);

		// Token: 0x020006A7 RID: 1703
		// (Invoke) Token: 0x0600362C RID: 13868
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormatDelegate(IntPtr @this);

		// Token: 0x020006A8 RID: 1704
		// (Invoke) Token: 0x0600362E RID: 13870
		private delegate bool get_autoGenerateMipsDelegate(IntPtr @this);

		// Token: 0x020006A9 RID: 1705
		// (Invoke) Token: 0x06003630 RID: 13872
		private delegate bool get_bindTextureMSDelegate(IntPtr @this);

		// Token: 0x020006AA RID: 1706
		// (Invoke) Token: 0x06003632 RID: 13874
		private delegate bool get_enableRandomWriteDelegate(IntPtr @this);

		// Token: 0x020006AB RID: 1707
		// (Invoke) Token: 0x06003634 RID: 13876
		private delegate bool GetIsPowerOfTwoDelegate(IntPtr @this);

		// Token: 0x020006AC RID: 1708
		// (Invoke) Token: 0x06003636 RID: 13878
		private delegate void SetShadowSamplingModeDelegate(IntPtr @this, UnityEngine.Rendering.ShadowSamplingMode samplingMode);

		// Token: 0x020006AD RID: 1709
		// (Invoke) Token: 0x06003638 RID: 13880
		private delegate IntPtr GetNativeDepthBufferPtrDelegate(IntPtr @this);

		// Token: 0x020006AE RID: 1710
		// (Invoke) Token: 0x0600363A RID: 13882
		private delegate void DiscardContentsDelegate(IntPtr @this, bool discardColor, bool discardDepth);

		// Token: 0x020006AF RID: 1711
		// (Invoke) Token: 0x0600363C RID: 13884
		private delegate void MarkRestoreExpectedDelegate(IntPtr @this);

		// Token: 0x020006B0 RID: 1712
		// (Invoke) Token: 0x0600363E RID: 13886
		private delegate void ResolveAADelegate(IntPtr @this);

		// Token: 0x020006B1 RID: 1713
		// (Invoke) Token: 0x06003640 RID: 13888
		private delegate void ResolveAAToDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x020006B2 RID: 1714
		// (Invoke) Token: 0x06003642 RID: 13890
		private delegate void SetGlobalShaderPropertyDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x020006B3 RID: 1715
		// (Invoke) Token: 0x06003644 RID: 13892
		private delegate bool IsCreatedDelegate(IntPtr @this);

		// Token: 0x020006B4 RID: 1716
		// (Invoke) Token: 0x06003646 RID: 13894
		private delegate void GenerateMipsDelegate(IntPtr @this);

		// Token: 0x020006B5 RID: 1717
		// (Invoke) Token: 0x06003648 RID: 13896
		private delegate void ConvertToEquirectDelegate(IntPtr @this, IntPtr equirect, Camera.MonoOrStereoscopicEye eye);

		// Token: 0x020006B6 RID: 1718
		// (Invoke) Token: 0x0600364A RID: 13898
		private delegate bool SupportsStencilDelegate(IntPtr rt);

		// Token: 0x020006B7 RID: 1719
		// (Invoke) Token: 0x0600364C RID: 13900
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x020006B8 RID: 1720
		// (Invoke) Token: 0x0600364E RID: 13902
		private delegate void set_depthDelegate(IntPtr @this, int value);
	}
}

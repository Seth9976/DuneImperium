using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E1 RID: 225
	public class Texture : Object
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x00052640 File Offset: 0x00050840
		// Note: this type is marked as 'beforefieldinit'.
		static Texture()
		{
			Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
			Texture.NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, "GenerateAllMips");
			Texture.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665546);
			Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665547);
			Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665548);
			Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665549);
			Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665550);
			Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665551);
			Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665552);
			Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665553);
			Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665554);
			Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665555);
			Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665556);
			Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665557);
			Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665558);
			Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665559);
			Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665560);
			Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665561);
			Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665562);
			Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665563);
			Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665564);
			Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665565);
			Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665566);
			Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665567);
			Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665568);
			Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665569);
			Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665570);
			Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665571);
			Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665572);
			Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665573);
			Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665574);
			Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665575);
			Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665576);
			Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665577);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665578);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665579);
			Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665580);
			Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665581);
			Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665583);
			Texture.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
			Texture.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
			Texture.get_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.get_globalMipmapLimitDelegate>("UnityEngine.Texture::get_globalMipmapLimit");
			Texture.set_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.set_globalMipmapLimitDelegate>("UnityEngine.Texture::set_globalMipmapLimit");
			Texture.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
			Texture.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<Texture.SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
			Texture.get_isNativeTextureDelegateField = IL2CPP.ResolveICall<Texture.get_isNativeTextureDelegate>("UnityEngine.Texture::get_isNativeTexture");
			Texture.get_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeUDelegate>("UnityEngine.Texture::get_wrapModeU");
			Texture.get_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeVDelegate>("UnityEngine.Texture::get_wrapModeV");
			Texture.get_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeWDelegate>("UnityEngine.Texture::get_wrapModeW");
			Texture.GetNativeTexturePtrDelegateField = IL2CPP.ResolveICall<Texture.GetNativeTexturePtrDelegate>("UnityEngine.Texture::GetNativeTexturePtr");
			Texture.IncrementUpdateCountDelegateField = IL2CPP.ResolveICall<Texture.IncrementUpdateCountDelegate>("UnityEngine.Texture::IncrementUpdateCount");
			Texture.Internal_GetStoredColorSpaceDelegateField = IL2CPP.ResolveICall<Texture.Internal_GetStoredColorSpaceDelegate>("UnityEngine.Texture::Internal_GetStoredColorSpace");
			Texture.get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
			Texture.get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
			Texture.get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
			Texture.get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
			Texture.get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
			Texture.get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
			Texture.get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
			Texture.get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
			Texture.get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
			Texture.get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
			Texture.get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
			Texture.get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
			Texture.set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
			Texture.get_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::get_streamingTextureDiscardUnusedMips");
			Texture.set_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::set_streamingTextureDiscardUnusedMips");
			Texture.get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
			Texture.set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00052B48 File Offset: 0x00050D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655701, XrefRangeEnd = 655705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00052B84 File Offset: 0x00050D84
		public unsafe int mipmapCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 655707, RefRangeEnd = 655711, XrefRangeStart = 655705, XrefRangeEnd = 655707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00052BC0 File Offset: 0x00050DC0
		public unsafe virtual UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655711, XrefRangeEnd = 655715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00052C08 File Offset: 0x00050E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655715, XrefRangeEnd = 655717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00052C44 File Offset: 0x00050E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655717, XrefRangeEnd = 655719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00052C80 File Offset: 0x00050E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655719, XrefRangeEnd = 655721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.TextureDimension GetDimension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00052CBC File Offset: 0x00050EBC
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00052D04 File Offset: 0x00050F04
		public unsafe virtual int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655721, XrefRangeEnd = 655726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00052D50 File Offset: 0x00050F50
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00052D98 File Offset: 0x00050F98
		public unsafe virtual int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655726, XrefRangeEnd = 655731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00052DE4 File Offset: 0x00050FE4
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00052E2C File Offset: 0x0005102C
		public unsafe virtual UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655731, XrefRangeEnd = 655736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00052E78 File Offset: 0x00051078
		public unsafe virtual bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655736, XrefRangeEnd = 655738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00052EC0 File Offset: 0x000510C0
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00052EFC File Offset: 0x000510FC
		public unsafe TextureWrapMode wrapMode
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 655740, RefRangeEnd = 655748, XrefRangeStart = 655738, XrefRangeEnd = 655740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 655750, RefRangeEnd = 655755, XrefRangeStart = 655748, XrefRangeEnd = 655750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00007579 File Offset: 0x00005779
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x00052F3C File Offset: 0x0005113C
		public unsafe TextureWrapMode wrapModeU
		{
			get
			{
				return Texture.get_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 655757, RefRangeEnd = 655759, XrefRangeStart = 655755, XrefRangeEnd = 655757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0000758B File Offset: 0x0000578B
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00052F7C File Offset: 0x0005117C
		public unsafe TextureWrapMode wrapModeV
		{
			get
			{
				return Texture.get_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 655761, RefRangeEnd = 655763, XrefRangeStart = 655759, XrefRangeEnd = 655761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0000759D File Offset: 0x0000579D
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x00052FBC File Offset: 0x000511BC
		public unsafe TextureWrapMode wrapModeW
		{
			get
			{
				return Texture.get_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 655765, RefRangeEnd = 655767, XrefRangeStart = 655763, XrefRangeEnd = 655765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00052FFC File Offset: 0x000511FC
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x00053038 File Offset: 0x00051238
		public unsafe FilterMode filterMode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 655769, RefRangeEnd = 655783, XrefRangeStart = 655767, XrefRangeEnd = 655769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 655785, RefRangeEnd = 655801, XrefRangeStart = 655783, XrefRangeEnd = 655785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00053078 File Offset: 0x00051278
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x000530B4 File Offset: 0x000512B4
		public unsafe int anisoLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 655803, RefRangeEnd = 655808, XrefRangeStart = 655801, XrefRangeEnd = 655803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 655810, RefRangeEnd = 655815, XrefRangeStart = 655808, XrefRangeEnd = 655810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000530F4 File Offset: 0x000512F4
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00053130 File Offset: 0x00051330
		public unsafe float mipMapBias
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 655817, RefRangeEnd = 655821, XrefRangeStart = 655815, XrefRangeEnd = 655817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 655823, RefRangeEnd = 655827, XrefRangeStart = 655821, XrefRangeEnd = 655823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00053170 File Offset: 0x00051370
		public unsafe Vector2 texelSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 655829, RefRangeEnd = 655831, XrefRangeStart = 655827, XrefRangeEnd = 655829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000531AC File Offset: 0x000513AC
		public unsafe uint updateCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 655833, RefRangeEnd = 655836, XrefRangeStart = 655831, XrefRangeEnd = 655833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000531E8 File Offset: 0x000513E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655836, XrefRangeEnd = 655838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetActiveTextureColorSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00053224 File Offset: 0x00051424
		public unsafe ColorSpace activeTextureColorSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 655840, RefRangeEnd = 655841, XrefRangeStart = 655838, XrefRangeEnd = 655840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00053260 File Offset: 0x00051460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 655843, RefRangeEnd = 655845, XrefRangeStart = 655841, XrefRangeEnd = 655843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetPixelDataSize(int mipLevel, int element = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mipLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000532B8 File Offset: 0x000514B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 655847, RefRangeEnd = 655850, XrefRangeStart = 655845, XrefRangeEnd = 655847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetPixelDataOffset(int mipLevel, int element = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mipLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00053310 File Offset: 0x00051510
		[CallerCount(0)]
		public unsafe TextureColorSpace GetTextureColorSpace(bool linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref linear;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0005335C File Offset: 0x0005155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655850, XrefRangeEnd = 655854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000533A8 File Offset: 0x000515A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 655874, RefRangeEnd = 655882, XrefRangeStart = 655854, XrefRangeEnd = 655874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000533F4 File Offset: 0x000515F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 655895, RefRangeEnd = 655905, XrefRangeStart = 655882, XrefRangeEnd = 655895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0005344C File Offset: 0x0005164C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 655913, RefRangeEnd = 655923, XrefRangeStart = 655905, XrefRangeEnd = 655913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNonReadableException(Texture t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0005349C File Offset: 0x0005169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655923, XrefRangeEnd = 655929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNativeArrayLengthOverflowException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x000534DC File Offset: 0x000516DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655929, XrefRangeEnd = 655931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_texelSize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000074F7 File Offset: 0x000056F7
		public Texture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0005351C File Offset: 0x0005171C
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00007500 File Offset: 0x00005700
		public unsafe static int GenerateAllMips
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0000750E File Offset: 0x0000570E
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0000751A File Offset: 0x0000571A
		public static int masterTextureLimit
		{
			get
			{
				return Texture.get_masterTextureLimitDelegateField();
			}
			set
			{
				Texture.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00007527 File Offset: 0x00005727
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00007533 File Offset: 0x00005733
		public static int globalMipmapLimit
		{
			get
			{
				return Texture.get_globalMipmapLimitDelegateField();
			}
			set
			{
				Texture.set_globalMipmapLimitDelegateField(value);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00007540 File Offset: 0x00005740
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x0000754C File Offset: 0x0000574C
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return Texture.get_anisotropicFilteringDelegateField();
			}
			set
			{
				Texture.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00007559 File Offset: 0x00005759
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
		{
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00007567 File Offset: 0x00005767
		public bool isNativeTexture
		{
			get
			{
				return Texture.get_isNativeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000075AF File Offset: 0x000057AF
		public IntPtr GetNativeTexturePtr()
		{
			return Texture.GetNativeTexturePtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00053538 File Offset: 0x00051738
		public int GetNativeTextureID()
		{
			return (int)this.GetNativeTexturePtr();
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000075C1 File Offset: 0x000057C1
		public void IncrementUpdateCount()
		{
			Texture.IncrementUpdateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000075D3 File Offset: 0x000057D3
		public TextureColorSpace Internal_GetStoredColorSpace()
		{
			return Texture.Internal_GetStoredColorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00053558 File Offset: 0x00051758
		public bool isDataSRGB
		{
			get
			{
				return this.Internal_GetStoredColorSpace() == TextureColorSpace.sRGB;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x000075E5 File Offset: 0x000057E5
		public static ulong totalTextureMemory
		{
			get
			{
				return Texture.get_totalTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000075F1 File Offset: 0x000057F1
		public static ulong desiredTextureMemory
		{
			get
			{
				return Texture.get_desiredTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x000075FD File Offset: 0x000057FD
		public static ulong targetTextureMemory
		{
			get
			{
				return Texture.get_targetTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00007609 File Offset: 0x00005809
		public static ulong currentTextureMemory
		{
			get
			{
				return Texture.get_currentTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00007615 File Offset: 0x00005815
		public static ulong nonStreamingTextureMemory
		{
			get
			{
				return Texture.get_nonStreamingTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00007621 File Offset: 0x00005821
		public static ulong streamingMipmapUploadCount
		{
			get
			{
				return Texture.get_streamingMipmapUploadCountDelegateField();
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0000762D File Offset: 0x0000582D
		public static ulong streamingRendererCount
		{
			get
			{
				return Texture.get_streamingRendererCountDelegateField();
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00007639 File Offset: 0x00005839
		public static ulong streamingTextureCount
		{
			get
			{
				return Texture.get_streamingTextureCountDelegateField();
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00007645 File Offset: 0x00005845
		public static ulong nonStreamingTextureCount
		{
			get
			{
				return Texture.get_nonStreamingTextureCountDelegateField();
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00007651 File Offset: 0x00005851
		public static ulong streamingTexturePendingLoadCount
		{
			get
			{
				return Texture.get_streamingTexturePendingLoadCountDelegateField();
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0000765D File Offset: 0x0000585D
		public static ulong streamingTextureLoadingCount
		{
			get
			{
				return Texture.get_streamingTextureLoadingCountDelegateField();
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00007669 File Offset: 0x00005869
		public static void SetStreamingTextureMaterialDebugProperties()
		{
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField();
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00007675 File Offset: 0x00005875
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00007681 File Offset: 0x00005881
		public static bool streamingTextureForceLoadAll
		{
			get
			{
				return Texture.get_streamingTextureForceLoadAllDelegateField();
			}
			set
			{
				Texture.set_streamingTextureForceLoadAllDelegateField(value);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0000768E File Offset: 0x0000588E
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000769A File Offset: 0x0000589A
		public static bool streamingTextureDiscardUnusedMips
		{
			get
			{
				return Texture.get_streamingTextureDiscardUnusedMipsDelegateField();
			}
			set
			{
				Texture.set_streamingTextureDiscardUnusedMipsDelegateField(value);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x000076A7 File Offset: 0x000058A7
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x000076B3 File Offset: 0x000058B3
		public static bool allowThreadedTextureCreation
		{
			get
			{
				return Texture.get_allowThreadedTextureCreationDelegateField();
			}
			set
			{
				Texture.set_allowThreadedTextureCreationDelegateField(value);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00053574 File Offset: 0x00051774
		public bool ValidateFormat(RenderTextureFormat format)
		{
			bool flag = SystemInfo.SupportsRenderTextureFormat(format);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				Debug.LogError(String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", format.ToString()), this);
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_GenerateAllMips;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly Texture.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x04000EAF RID: 3759
		private static readonly Texture.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x04000EB0 RID: 3760
		private static readonly Texture.get_globalMipmapLimitDelegate get_globalMipmapLimitDelegateField;

		// Token: 0x04000EB1 RID: 3761
		private static readonly Texture.set_globalMipmapLimitDelegate set_globalMipmapLimitDelegateField;

		// Token: 0x04000EB2 RID: 3762
		private static readonly Texture.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x04000EB3 RID: 3763
		private static readonly Texture.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x04000EB4 RID: 3764
		private static readonly Texture.SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;

		// Token: 0x04000EB5 RID: 3765
		private static readonly Texture.get_isNativeTextureDelegate get_isNativeTextureDelegateField;

		// Token: 0x04000EB6 RID: 3766
		private static readonly Texture.get_wrapModeUDelegate get_wrapModeUDelegateField;

		// Token: 0x04000EB7 RID: 3767
		private static readonly Texture.get_wrapModeVDelegate get_wrapModeVDelegateField;

		// Token: 0x04000EB8 RID: 3768
		private static readonly Texture.get_wrapModeWDelegate get_wrapModeWDelegateField;

		// Token: 0x04000EB9 RID: 3769
		private static readonly Texture.GetNativeTexturePtrDelegate GetNativeTexturePtrDelegateField;

		// Token: 0x04000EBA RID: 3770
		private static readonly Texture.IncrementUpdateCountDelegate IncrementUpdateCountDelegateField;

		// Token: 0x04000EBB RID: 3771
		private static readonly Texture.Internal_GetStoredColorSpaceDelegate Internal_GetStoredColorSpaceDelegateField;

		// Token: 0x04000EBC RID: 3772
		private static readonly Texture.get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;

		// Token: 0x04000EBD RID: 3773
		private static readonly Texture.get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;

		// Token: 0x04000EBE RID: 3774
		private static readonly Texture.get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;

		// Token: 0x04000EBF RID: 3775
		private static readonly Texture.get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;

		// Token: 0x04000EC0 RID: 3776
		private static readonly Texture.get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;

		// Token: 0x04000EC1 RID: 3777
		private static readonly Texture.get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;

		// Token: 0x04000EC2 RID: 3778
		private static readonly Texture.get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;

		// Token: 0x04000EC3 RID: 3779
		private static readonly Texture.get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;

		// Token: 0x04000EC4 RID: 3780
		private static readonly Texture.get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;

		// Token: 0x04000EC5 RID: 3781
		private static readonly Texture.get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;

		// Token: 0x04000EC6 RID: 3782
		private static readonly Texture.get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;

		// Token: 0x04000EC7 RID: 3783
		private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;

		// Token: 0x04000EC8 RID: 3784
		private static readonly Texture.get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000EC9 RID: 3785
		private static readonly Texture.set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000ECA RID: 3786
		private static readonly Texture.get_streamingTextureDiscardUnusedMipsDelegate get_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000ECB RID: 3787
		private static readonly Texture.set_streamingTextureDiscardUnusedMipsDelegate set_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000ECC RID: 3788
		private static readonly Texture.get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;

		// Token: 0x04000ECD RID: 3789
		private static readonly Texture.set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;

		// Token: 0x0200065F RID: 1631
		// (Invoke) Token: 0x060035A7 RID: 13735
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x02000660 RID: 1632
		// (Invoke) Token: 0x060035A9 RID: 13737
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x02000661 RID: 1633
		// (Invoke) Token: 0x060035AB RID: 13739
		private delegate int get_globalMipmapLimitDelegate();

		// Token: 0x02000662 RID: 1634
		// (Invoke) Token: 0x060035AD RID: 13741
		private delegate void set_globalMipmapLimitDelegate(int value);

		// Token: 0x02000663 RID: 1635
		// (Invoke) Token: 0x060035AF RID: 13743
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x02000664 RID: 1636
		// (Invoke) Token: 0x060035B1 RID: 13745
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x02000665 RID: 1637
		// (Invoke) Token: 0x060035B3 RID: 13747
		private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

		// Token: 0x02000666 RID: 1638
		// (Invoke) Token: 0x060035B5 RID: 13749
		private delegate bool get_isNativeTextureDelegate(IntPtr @this);

		// Token: 0x02000667 RID: 1639
		// (Invoke) Token: 0x060035B7 RID: 13751
		private delegate TextureWrapMode get_wrapModeUDelegate(IntPtr @this);

		// Token: 0x02000668 RID: 1640
		// (Invoke) Token: 0x060035B9 RID: 13753
		private delegate TextureWrapMode get_wrapModeVDelegate(IntPtr @this);

		// Token: 0x02000669 RID: 1641
		// (Invoke) Token: 0x060035BB RID: 13755
		private delegate TextureWrapMode get_wrapModeWDelegate(IntPtr @this);

		// Token: 0x0200066A RID: 1642
		// (Invoke) Token: 0x060035BD RID: 13757
		private delegate IntPtr GetNativeTexturePtrDelegate(IntPtr @this);

		// Token: 0x0200066B RID: 1643
		// (Invoke) Token: 0x060035BF RID: 13759
		private delegate void IncrementUpdateCountDelegate(IntPtr @this);

		// Token: 0x0200066C RID: 1644
		// (Invoke) Token: 0x060035C1 RID: 13761
		private delegate TextureColorSpace Internal_GetStoredColorSpaceDelegate(IntPtr @this);

		// Token: 0x0200066D RID: 1645
		// (Invoke) Token: 0x060035C3 RID: 13763
		private delegate ulong get_totalTextureMemoryDelegate();

		// Token: 0x0200066E RID: 1646
		// (Invoke) Token: 0x060035C5 RID: 13765
		private delegate ulong get_desiredTextureMemoryDelegate();

		// Token: 0x0200066F RID: 1647
		// (Invoke) Token: 0x060035C7 RID: 13767
		private delegate ulong get_targetTextureMemoryDelegate();

		// Token: 0x02000670 RID: 1648
		// (Invoke) Token: 0x060035C9 RID: 13769
		private delegate ulong get_currentTextureMemoryDelegate();

		// Token: 0x02000671 RID: 1649
		// (Invoke) Token: 0x060035CB RID: 13771
		private delegate ulong get_nonStreamingTextureMemoryDelegate();

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x060035CD RID: 13773
		private delegate ulong get_streamingMipmapUploadCountDelegate();

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x060035CF RID: 13775
		private delegate ulong get_streamingRendererCountDelegate();

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x060035D1 RID: 13777
		private delegate ulong get_streamingTextureCountDelegate();

		// Token: 0x02000675 RID: 1653
		// (Invoke) Token: 0x060035D3 RID: 13779
		private delegate ulong get_nonStreamingTextureCountDelegate();

		// Token: 0x02000676 RID: 1654
		// (Invoke) Token: 0x060035D5 RID: 13781
		private delegate ulong get_streamingTexturePendingLoadCountDelegate();

		// Token: 0x02000677 RID: 1655
		// (Invoke) Token: 0x060035D7 RID: 13783
		private delegate ulong get_streamingTextureLoadingCountDelegate();

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x060035D9 RID: 13785
		private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x060035DB RID: 13787
		private delegate bool get_streamingTextureForceLoadAllDelegate();

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x060035DD RID: 13789
		private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x060035DF RID: 13791
		private delegate bool get_streamingTextureDiscardUnusedMipsDelegate();

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x060035E1 RID: 13793
		private delegate void set_streamingTextureDiscardUnusedMipsDelegate(bool value);

		// Token: 0x0200067D RID: 1661
		// (Invoke) Token: 0x060035E3 RID: 13795
		private delegate bool get_allowThreadedTextureCreationDelegate();

		// Token: 0x0200067E RID: 1662
		// (Invoke) Token: 0x060035E5 RID: 13797
		private delegate void set_allowThreadedTextureCreationDelegate(bool value);
	}
}

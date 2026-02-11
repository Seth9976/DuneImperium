using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C0 RID: 192
	public class Texture2DAtlas : Object
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003F348 File Offset: 0x0003D548
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DAtlas()
		{
			Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Texture2DAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr);
			Texture2DAtlas.NativeFieldInfoPtr_kGPUTexInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "kGPUTexInvalid");
			Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMip0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "kGPUTexValidMip0");
			Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMipAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "kGPUTexValidMipAll");
			Texture2DAtlas.NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_AtlasTexture");
			Texture2DAtlas.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_Width");
			Texture2DAtlas.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_Height");
			Texture2DAtlas.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_Format");
			Texture2DAtlas.NativeFieldInfoPtr_m_UseMipMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_UseMipMaps");
			Texture2DAtlas.NativeFieldInfoPtr_m_IsAtlasTextureOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_IsAtlasTextureOwner");
			Texture2DAtlas.NativeFieldInfoPtr_m_AtlasAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_AtlasAllocator");
			Texture2DAtlas.NativeFieldInfoPtr_m_AllocationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_AllocationCache");
			Texture2DAtlas.NativeFieldInfoPtr_m_IsGPUTextureUpToDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_IsGPUTextureUpToDate");
			Texture2DAtlas.NativeFieldInfoPtr_m_TextureHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "m_TextureHashes");
			Texture2DAtlas.NativeFieldInfoPtr_fullScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "fullScaleOffset");
			Texture2DAtlas.NativeFieldInfoPtr_s_MaxMipLevelPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, "s_MaxMipLevelPadding");
			Texture2DAtlas.NativeMethodInfoPtr_get_maxMipLevelPadding_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665264);
			Texture2DAtlas.NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665265);
			Texture2DAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665266);
			Texture2DAtlas.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665267);
			Texture2DAtlas.NativeMethodInfoPtr_ResetAllocator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665268);
			Texture2DAtlas.NativeMethodInfoPtr_ClearTarget_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665269);
			Texture2DAtlas.NativeMethodInfoPtr_GetTextureMipmapCount_FamAndAssem_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665270);
			Texture2DAtlas.NativeMethodInfoPtr_Is2D_FamAndAssem_Boolean_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665271);
			Texture2DAtlas.NativeMethodInfoPtr_IsSingleChannelBlit_FamAndAssem_Boolean_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665272);
			Texture2DAtlas.NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665273);
			Texture2DAtlas.NativeMethodInfoPtr_MarkGPUTextureValid_FamAndAssem_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665274);
			Texture2DAtlas.NativeMethodInfoPtr_MarkGPUTextureInvalid_FamAndAssem_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665275);
			Texture2DAtlas.NativeMethodInfoPtr_BlitTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665276);
			Texture2DAtlas.NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665277);
			Texture2DAtlas.NativeMethodInfoPtr_BlitCubeTexture2D_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665278);
			Texture2DAtlas.NativeMethodInfoPtr_AllocateTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665279);
			Texture2DAtlas.NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Boolean_Texture_Int32_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665280);
			Texture2DAtlas.NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Virtual_New_Boolean_Int32_Int32_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665281);
			Texture2DAtlas.NativeMethodInfoPtr_GetTextureHash_FamAndAssem_Int32_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665282);
			Texture2DAtlas.NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665283);
			Texture2DAtlas.NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665284);
			Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665285);
			Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665286);
			Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665287);
			Texture2DAtlas.NativeMethodInfoPtr_GetCachedTextureSize_Internal_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665288);
			Texture2DAtlas.NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665289);
			Texture2DAtlas.NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665290);
			Texture2DAtlas.NativeMethodInfoPtr_AddTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665291);
			Texture2DAtlas.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_Texture_byref_Vector4_Vector4_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665292);
			Texture2DAtlas.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_byref_Vector4_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665293);
			Texture2DAtlas.NativeMethodInfoPtr_EnsureTextureSlot_Internal_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr, 100665294);
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0003F710 File Offset: 0x0003D910
		public unsafe static int maxMipLevelPadding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973034, XrefRangeEnd = 973038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_get_maxMipLevelPadding_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0003F740 File Offset: 0x0003D940
		public unsafe RTHandle AtlasTexture
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003F780 File Offset: 0x0003D980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973076, RefRangeEnd = 973078, XrefRangeStart = 973038, XrefRangeEnd = 973076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, bool powerOfTwoPadding = false, string name = "", bool useMipMap = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DAtlas>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref powerOfTwoPadding;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003F820 File Offset: 0x0003DA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973089, RefRangeEnd = 973090, XrefRangeStart = 973078, XrefRangeEnd = 973089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0003F854 File Offset: 0x0003DA54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 973098, RefRangeEnd = 973101, XrefRangeStart = 973090, XrefRangeEnd = 973098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAllocator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_ResetAllocator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0003F888 File Offset: 0x0003DA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973101, XrefRangeEnd = 973118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTarget(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_ClearTarget_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0003F8CC File Offset: 0x0003DACC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 973126, RefRangeEnd = 973130, XrefRangeStart = 973118, XrefRangeEnd = 973126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureMipmapCount(int width, int height)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_GetTextureMipmapCount_FamAndAssem_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003F924 File Offset: 0x0003DB24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 973135, RefRangeEnd = 973141, XrefRangeStart = 973130, XrefRangeEnd = 973135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Is2D(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_Is2D_FamAndAssem_Boolean_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0003F974 File Offset: 0x0003DB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973156, RefRangeEnd = 973158, XrefRangeStart = 973141, XrefRangeEnd = 973156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSingleChannelBlit(Texture source, Texture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_IsSingleChannelBlit_FamAndAssem_Boolean_Texture_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973178, RefRangeEnd = 973180, XrefRangeStart = 973158, XrefRangeEnd = 973178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, Texture2DAtlas.BlitType blitType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceScaleOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003FA60 File Offset: 0x0003DC60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 973184, RefRangeEnd = 973188, XrefRangeStart = 973180, XrefRangeEnd = 973184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGPUTextureValid(int instanceId, bool mipAreValid = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipAreValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_MarkGPUTextureValid_FamAndAssem_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003FAAC File Offset: 0x0003DCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973188, XrefRangeEnd = 973192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGPUTextureInvalid(int instanceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_MarkGPUTextureInvalid_FamAndAssem_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973192, XrefRangeEnd = 973206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceScaleOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_BlitTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003FB84 File Offset: 0x0003DD84
		[CallerCount(0)]
		public unsafe virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceScaleOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003FC1C File Offset: 0x0003DE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973206, XrefRangeEnd = 973219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true, int overrideInstanceID = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_BlitCubeTexture2D_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003FCA8 File Offset: 0x0003DEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973236, RefRangeEnd = 973237, XrefRangeStart = 973219, XrefRangeEnd = 973236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_AllocateTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003FD4C File Offset: 0x0003DF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973237, XrefRangeEnd = 973239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Boolean_Texture_Int32_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973239, XrefRangeEnd = 973255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Virtual_New_Boolean_Int32_Int32_Int32_byref_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003FE44 File Offset: 0x0003E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973255, XrefRangeEnd = 973260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureHash(Texture textureA, Texture textureB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_GetTextureHash_FamAndAssem_Int32_Texture_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0003FEA4 File Offset: 0x0003E0A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973262, RefRangeEnd = 973264, XrefRangeStart = 973260, XrefRangeEnd = 973262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureID(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973266, RefRangeEnd = 973267, XrefRangeStart = 973264, XrefRangeEnd = 973266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureID(Texture textureA, Texture textureB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003FF54 File Offset: 0x0003E154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973267, XrefRangeEnd = 973271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureA);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973274, RefRangeEnd = 973276, XrefRangeStart = 973271, XrefRangeEnd = 973274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCached(out Vector4 scaleOffset, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00040020 File Offset: 0x0003E220
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 973279, RefRangeEnd = 973284, XrefRangeStart = 973276, XrefRangeEnd = 973279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCached(out Vector4 scaleOffset, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00040078 File Offset: 0x0003E278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973287, RefRangeEnd = 973288, XrefRangeStart = 973284, XrefRangeEnd = 973287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetCachedTextureSize(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_GetCachedTextureSize_Internal_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000400C4 File Offset: 0x0003E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973288, XrefRangeEnd = 973306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedsUpdate(Texture texture, bool needMips = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needMips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0004012C File Offset: 0x0003E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973306, XrefRangeEnd = 973333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needMips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Texture_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000401A4 File Offset: 0x0003E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973333, XrefRangeEnd = 973335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_AddTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0004021C File Offset: 0x0003E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973335, XrefRangeEnd = 973337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true, bool blitMips = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newTexture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceScaleOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIfNeeded;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_Texture_byref_Vector4_Vector4_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000402D4 File Offset: 0x0003E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973337, XrefRangeEnd = 973341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true, bool blitMips = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIfNeeded;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitMips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DAtlas.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_byref_Vector4_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00040368 File Offset: 0x0003E568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973341, XrefRangeEnd = 973351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &isUploadNeeded;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleBias;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlas.NativeMethodInfoPtr_EnsureTextureSlot_Internal_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00007F30 File Offset: 0x00006130
		public Texture2DAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000403EC File Offset: 0x0003E5EC
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00007F39 File Offset: 0x00006139
		public unsafe static int kGPUTexInvalid
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexInvalid, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexInvalid, (void*)(&value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00040408 File Offset: 0x0003E608
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00007F47 File Offset: 0x00006147
		public unsafe static int kGPUTexValidMip0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMip0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMip0, (void*)(&value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00040424 File Offset: 0x0003E624
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00007F55 File Offset: 0x00006155
		public unsafe static int kGPUTexValidMipAll
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMipAll, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2DAtlas.NativeFieldInfoPtr_kGPUTexValidMipAll, (void*)(&value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00040440 File Offset: 0x0003E640
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00007F63 File Offset: 0x00006163
		public unsafe RTHandle m_AtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00040470 File Offset: 0x0003E670
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00007F82 File Offset: 0x00006182
		public unsafe int m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00040498 File Offset: 0x0003E698
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00007F9D File Offset: 0x0000619D
		public unsafe int m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000404C0 File Offset: 0x0003E6C0
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00007FB8 File Offset: 0x000061B8
		public unsafe GraphicsFormat m_Format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_Format)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x000404E8 File Offset: 0x0003E6E8
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00007FD3 File Offset: 0x000061D3
		public unsafe bool m_UseMipMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_UseMipMaps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_UseMipMaps)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00040510 File Offset: 0x0003E710
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00007FEE File Offset: 0x000061EE
		public unsafe bool m_IsAtlasTextureOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_IsAtlasTextureOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_IsAtlasTextureOwner)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00040538 File Offset: 0x0003E738
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00008009 File Offset: 0x00006209
		public unsafe AtlasAllocator m_AtlasAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AtlasAllocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AtlasAllocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00040568 File Offset: 0x0003E768
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00008028 File Offset: 0x00006228
		public unsafe Dictionary<int, ValueTuple<Vector4, Vector2Int>> m_AllocationCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AllocationCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<Vector4, Vector2Int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_AllocationCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00040598 File Offset: 0x0003E798
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00008047 File Offset: 0x00006247
		public unsafe Dictionary<int, int> m_IsGPUTextureUpToDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_IsGPUTextureUpToDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_IsGPUTextureUpToDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000405C8 File Offset: 0x0003E7C8
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00008066 File Offset: 0x00006266
		public unsafe Dictionary<int, int> m_TextureHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_TextureHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlas.NativeFieldInfoPtr_m_TextureHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000405F8 File Offset: 0x0003E7F8
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00008085 File Offset: 0x00006285
		public unsafe static Vector4 fullScaleOffset
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Texture2DAtlas.NativeFieldInfoPtr_fullScaleOffset, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2DAtlas.NativeFieldInfoPtr_fullScaleOffset, (void*)(&value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00040614 File Offset: 0x0003E814
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00008093 File Offset: 0x00006293
		public unsafe static int s_MaxMipLevelPadding
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2DAtlas.NativeFieldInfoPtr_s_MaxMipLevelPadding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2DAtlas.NativeFieldInfoPtr_s_MaxMipLevelPadding, (void*)(&value));
			}
		}

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_kGPUTexInvalid;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_kGPUTexValidMip0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_kGPUTexValidMipAll;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_m_Format;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_m_UseMipMaps;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAtlasTextureOwner;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasAllocator;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocationCache;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_m_IsGPUTextureUpToDate;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureHashes;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_fullScaleOffset;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_s_MaxMipLevelPadding;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_get_maxMipLevelPadding_Public_Static_get_Int32_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_Boolean_String_Boolean_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllocator_Public_Void_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_ClearTarget_Public_Void_CommandBuffer_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureMipmapCount_FamAndAssem_Int32_Int32_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Is2D_FamAndAssem_Boolean_Texture_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleChannelBlit_FamAndAssem_Boolean_Texture_Texture_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_MarkGPUTextureValid_FamAndAssem_Void_Int32_Boolean_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_MarkGPUTextureInvalid_FamAndAssem_Void_Int32_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_BlitCubeTexture2D_Public_Virtual_New_Void_CommandBuffer_Vector4_Texture_Boolean_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Boolean_Texture_Int32_Int32_byref_Vector4_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTextureWithoutBlit_Public_Virtual_New_Boolean_Int32_Int32_Int32_byref_Vector4_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureHash_FamAndAssem_Int32_Texture_Texture_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureID_Public_Int32_Texture_Texture_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_Texture_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Texture_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedTextureSize_Internal_Vector2Int_Int32_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Boolean_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_NeedsUpdate_Public_Virtual_New_Boolean_Texture_Texture_Boolean_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_AddTexture_Public_Virtual_New_Boolean_CommandBuffer_byref_Vector4_Texture_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_Texture_byref_Vector4_Vector4_Boolean_Boolean_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTexture_Public_Virtual_New_Boolean_CommandBuffer_Texture_byref_Vector4_Boolean_Boolean_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTextureSlot_Internal_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0;

		// Token: 0x020001ED RID: 493
		public enum BlitType
		{
			// Token: 0x04001322 RID: 4898
			Default,
			// Token: 0x04001323 RID: 4899
			CubeTo2DOctahedral,
			// Token: 0x04001324 RID: 4900
			SingleChannel,
			// Token: 0x04001325 RID: 4901
			CubeTo2DOctahedralSingleChannel
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B8 RID: 184
	public class PowerOfTwoTextureAtlas : Texture2DAtlas
	{
		// Token: 0x06000CE4 RID: 3300 RVA: 0x0003B5C0 File Offset: 0x000397C0
		// Note: this type is marked as 'beforefieldinit'.
		static PowerOfTwoTextureAtlas()
		{
			Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "PowerOfTwoTextureAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr);
			PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_MipPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, "m_MipPadding");
			PowerOfTwoTextureAtlas.NativeFieldInfoPtr_k_MipmapFactorApprox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, "k_MipmapFactorApprox");
			PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_RequestedTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, "m_RequestedTextures");
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665145);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_get_mipPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665146);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetTexturePadding_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665147);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Vector4_Texture_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665148);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Static_Vector4_byref_Vector2_byref_Vector2_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665149);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665150);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665151);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665152);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665153);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitOctahedralTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665154);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_TextureSizeToPowerOfTwo_Private_Void_Texture_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665155);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPowerOfTwoTextureSize_Private_Vector2_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665156);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_AllocateTexture_Public_Virtual_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665157);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ResetRequestedTexture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665158);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665159);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665160);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665161);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Private_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665162);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_RelayoutEntries_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665163);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetApproxCacheSizeInByte_Public_Static_Int64_Int32_Int32_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665164);
			PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetMaxCacheSizeForWeightInByte_Public_Static_Int32_Int32_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, 100665165);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0003B7D0 File Offset: 0x000399D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971869, RefRangeEnd = 971870, XrefRangeStart = 971858, XrefRangeEnd = 971869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, string name = "", bool useMipMap = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0003B864 File Offset: 0x00039A64
		public unsafe int mipPadding
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_get_mipPadding_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971870, XrefRangeEnd = 971871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTexturePadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetTexturePadding_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003B8DC File Offset: 0x00039ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971871, XrefRangeEnd = 971876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetPayloadScaleOffset(Texture texture, [In] ref Vector4 scaleOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Vector4_Texture_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003B938 File Offset: 0x00039B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971876, RefRangeEnd = 971877, XrefRangeStart = 971876, XrefRangeEnd = 971876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetPayloadScaleOffset([In] ref Vector2 textureSize, [In] ref Vector2 paddingSize, [In] ref Vector4 scaleOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &textureSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &paddingSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Static_Vector4_byref_Vector2_byref_Vector2_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0003B994 File Offset: 0x00039B94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 971908, RefRangeEnd = 971912, XrefRangeStart = 971877, XrefRangeEnd = 971908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, PowerOfTwoTextureAtlas.BlitType blitType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0003BA20 File Offset: 0x00039C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971912, XrefRangeEnd = 971916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0003BAB8 File Offset: 0x00039CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971916, XrefRangeEnd = 971920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0003BB44 File Offset: 0x00039D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971920, XrefRangeEnd = 971924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0003BBDC File Offset: 0x00039DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971924, XrefRangeEnd = 971928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_BlitOctahedralTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0003BC68 File Offset: 0x00039E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971928, XrefRangeEnd = 971930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_TextureSizeToPowerOfTwo_Private_Void_Texture_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971930, XrefRangeEnd = 971932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPowerOfTwoTextureSize(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetPowerOfTwoTextureSize_Private_Vector2_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003BD18 File Offset: 0x00039F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971932, XrefRangeEnd = 971940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerOfTwoTextureAtlas.NativeMethodInfoPtr_AllocateTexture_Public_Virtual_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003BDBC File Offset: 0x00039FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971940, XrefRangeEnd = 971944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRequestedTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ResetRequestedTexture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003BDF0 File Offset: 0x00039FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971944, XrefRangeEnd = 971946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReserveSpace(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0003BE40 File Offset: 0x0003A040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971946, XrefRangeEnd = 971948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReserveSpace(Texture texture, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003BEAC File Offset: 0x0003A0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971948, XrefRangeEnd = 971950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReserveSpace(Texture textureA, Texture textureB, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Texture_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003BF28 File Offset: 0x0003A128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 971955, RefRangeEnd = 971958, XrefRangeStart = 971950, XrefRangeEnd = 971955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReserveSpace(int id, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_ReserveSpace_Private_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0003BF90 File Offset: 0x0003A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971958, XrefRangeEnd = 972022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RelayoutEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_RelayoutEntries_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0003BFCC File Offset: 0x0003A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972022, XrefRangeEnd = 972027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nbElement;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipmap;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetApproxCacheSizeInByte_Public_Static_Int64_Int32_Int32_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0003C034 File Offset: 0x0003A234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972027, XrefRangeEnd = 972038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref weight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipmap;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.NativeMethodInfoPtr_GetMaxCacheSizeForWeightInByte_Public_Static_Int32_Int32_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00007B5D File Offset: 0x00005D5D
		public PowerOfTwoTextureAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0003C090 File Offset: 0x0003A290
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00007B66 File Offset: 0x00005D66
		public unsafe int m_MipPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_MipPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_MipPadding)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0003C0B8 File Offset: 0x0003A2B8
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00007B81 File Offset: 0x00005D81
		public unsafe static float k_MipmapFactorApprox
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_k_MipmapFactorApprox, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_k_MipmapFactorApprox, (void*)(&value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00007B8F File Offset: 0x00005D8F
		public unsafe Dictionary<int, Vector2Int> m_RequestedTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_RequestedTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerOfTwoTextureAtlas.NativeFieldInfoPtr_m_RequestedTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_m_MipPadding;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_k_MipmapFactorApprox;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestedTextures;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_FilterMode_String_Boolean_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_get_mipPadding_Public_get_Int32_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_GetTexturePadding_Private_Int32_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Vector4_Texture_byref_Vector4_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_GetPayloadScaleOffset_Public_Static_Vector4_byref_Vector2_byref_Vector2_byref_Vector4_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_Blit2DTexture_Private_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_BlitType_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_BlitTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_BlitOctahedralTexture_Public_Virtual_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_BlitOctahedralTextureMultiply_Public_Void_CommandBuffer_Vector4_Texture_Vector4_Boolean_Int32_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_TextureSizeToPowerOfTwo_Private_Void_Texture_byref_Int32_byref_Int32_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_GetPowerOfTwoTextureSize_Private_Vector2_Texture_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTexture_Public_Virtual_Boolean_CommandBuffer_byref_Vector4_Texture_Int32_Int32_Int32_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_ResetRequestedTexture_Public_Void_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Int32_Int32_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_ReserveSpace_Public_Boolean_Texture_Texture_Int32_Int32_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_ReserveSpace_Private_Boolean_Int32_Int32_Int32_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_RelayoutEntries_Public_Boolean_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_GetApproxCacheSizeInByte_Public_Static_Int64_Int32_Int32_Boolean_GraphicsFormat_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCacheSizeForWeightInByte_Public_Static_Int32_Int32_Boolean_GraphicsFormat_0;

		// Token: 0x020001E8 RID: 488
		public new enum BlitType
		{
			// Token: 0x0400130A RID: 4874
			Padding,
			// Token: 0x0400130B RID: 4875
			PaddingMultiply,
			// Token: 0x0400130C RID: 4876
			OctahedralPadding,
			// Token: 0x0400130D RID: 4877
			OctahedralPaddingMultiply
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("UnityEngine.Rendering.PowerOfTwoTextureAtlas+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A2D RID: 6701 RVA: 0x0006C68C File Offset: 0x0006A88C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerOfTwoTextureAtlas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr);
				PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr, "<>9");
				PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr, "<>9__23_0");
				PowerOfTwoTextureAtlas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr, 100665167);
				PowerOfTwoTextureAtlas.__c.NativeMethodInfoPtr__RelayoutEntries_b__23_0_Internal_Int32_ValueTuple_2_Int32_Vector2Int_ValueTuple_2_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr, 100665168);
			}

			// Token: 0x06001A2E RID: 6702 RVA: 0x0006C708 File Offset: 0x0006A908
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerOfTwoTextureAtlas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A2F RID: 6703 RVA: 0x0006C744 File Offset: 0x0006A944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971853, XrefRangeEnd = 971858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RelayoutEntries_b__23_0(ValueTuple<int, Vector2Int> c1, ValueTuple<int, Vector2Int> c2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c1));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c2));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerOfTwoTextureAtlas.__c.NativeMethodInfoPtr__RelayoutEntries_b__23_0_Internal_Int32_ValueTuple_2_Int32_Vector2Int_ValueTuple_2_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A30 RID: 6704 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
			// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000D2FA File Offset: 0x0000B4FA
			public unsafe static PowerOfTwoTextureAtlas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerOfTwoTextureAtlas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0006C7D8 File Offset: 0x0006A9D8
			// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0000D30C File Offset: 0x0000B50C
			public unsafe static Comparison<ValueTuple<int, Vector2Int>> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ValueTuple<int, Vector2Int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PowerOfTwoTextureAtlas.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeMethodInfoPtr__RelayoutEntries_b__23_0_Internal_Int32_ValueTuple_2_Int32_Vector2Int_ValueTuple_2_Int32_Vector2Int_0;
		}
	}
}

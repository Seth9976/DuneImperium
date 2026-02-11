using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C3 RID: 195
	public static class TextureXR : Object
	{
		// Token: 0x06000E0B RID: 3595 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		// Note: this type is marked as 'beforefieldinit'.
		static TextureXR()
		{
			Il2CppClassPointerStore<TextureXR>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureXR");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureXR>.NativeClassPtr);
			TextureXR.NativeFieldInfoPtr_m_MaxViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MaxViews");
			TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture2DArray");
			TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture");
			TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture2DArrayRTH");
			TextureXR.NativeFieldInfoPtr_m_BlackUIntTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTextureRTH");
			TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture2DArray");
			TextureXR.NativeFieldInfoPtr_m_ClearTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture");
			TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture2DArrayRTH");
			TextureXR.NativeFieldInfoPtr_m_ClearTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTextureRTH");
			TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture2DArray");
			TextureXR.NativeFieldInfoPtr_m_MagentaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture");
			TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture2DArrayRTH");
			TextureXR.NativeFieldInfoPtr_m_MagentaTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTextureRTH");
			TextureXR.NativeFieldInfoPtr_m_BlackTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture");
			TextureXR.NativeFieldInfoPtr_m_BlackTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture3D");
			TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture2DArray");
			TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture2DArrayRTH");
			TextureXR.NativeFieldInfoPtr_m_BlackTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTextureRTH");
			TextureXR.NativeFieldInfoPtr_m_BlackTexture3DRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture3DRTH");
			TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTexture2DArray");
			TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTexture2DArrayRTH");
			TextureXR.NativeFieldInfoPtr_m_WhiteTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTextureRTH");
			TextureXR.NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665325);
			TextureXR.NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665326);
			TextureXR.NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665327);
			TextureXR.NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665328);
			TextureXR.NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665329);
			TextureXR.NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665330);
			TextureXR.NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665331);
			TextureXR.NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665332);
			TextureXR.NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665333);
			TextureXR.NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665334);
			TextureXR.NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665335);
			TextureXR.NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665336);
			TextureXR.NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665337);
			TextureXR.NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665338);
			TextureXR.NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665339);
			TextureXR.NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100665340);
		}

		// Token: 0x17000460 RID: 1120
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00041308 File Offset: 0x0003F508
		public unsafe static int maxViews
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973570, XrefRangeEnd = 973574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0004133C File Offset: 0x0003F53C
		public unsafe static int slices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973574, XrefRangeEnd = 973578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0004136C File Offset: 0x0003F56C
		public unsafe static bool useTexArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973578, XrefRangeEnd = 973579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0004139C File Offset: 0x0003F59C
		public unsafe static TextureDimension dimension
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 973583, RefRangeEnd = 973585, XrefRangeStart = 973579, XrefRangeEnd = 973583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000413CC File Offset: 0x0003F5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973592, RefRangeEnd = 973593, XrefRangeStart = 973585, XrefRangeEnd = 973592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetBlackUIntTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00041400 File Offset: 0x0003F600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973600, RefRangeEnd = 973601, XrefRangeStart = 973593, XrefRangeEnd = 973600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetClearTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00041434 File Offset: 0x0003F634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973608, RefRangeEnd = 973609, XrefRangeStart = 973601, XrefRangeEnd = 973608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetMagentaTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00041468 File Offset: 0x0003F668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973616, RefRangeEnd = 973617, XrefRangeStart = 973609, XrefRangeEnd = 973616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetBlackTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0004149C File Offset: 0x0003F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973617, XrefRangeEnd = 973621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetBlackTextureArray()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000414D0 File Offset: 0x0003F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973621, XrefRangeEnd = 973625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetBlackTexture3D()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00041504 File Offset: 0x0003F704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973632, RefRangeEnd = 973633, XrefRangeStart = 973625, XrefRangeEnd = 973632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle GetWhiteTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00041538 File Offset: 0x0003F738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973633, XrefRangeEnd = 973830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clearR32_UIntShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00041580 File Offset: 0x0003F780
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 973854, RefRangeEnd = 973858, XrefRangeStart = 973830, XrefRangeEnd = 973854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr3) : null;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000415D8 File Offset: 0x0003F7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973889, RefRangeEnd = 973890, XrefRangeStart = 973858, XrefRangeEnd = 973889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clearR32_UIntShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00041630 File Offset: 0x0003F830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973890, XrefRangeEnd = 973910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clearR32_UIntShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00041688 File Offset: 0x0003F888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973910, XrefRangeEnd = 973917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture3D CreateBlackTexture3D(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureXR.NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr3) : null;
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0000820B File Offset: 0x0000640B
		public TextureXR(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000416CC File Offset: 0x0003F8CC
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00008214 File Offset: 0x00006414
		public unsafe static int m_MaxViews
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_MaxViews, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_MaxViews, (void*)(&value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000416E8 File Offset: 0x0003F8E8
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00008222 File Offset: 0x00006422
		public unsafe static Texture m_BlackUIntTexture2DArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00041710 File Offset: 0x0003F910
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00008234 File Offset: 0x00006434
		public unsafe static Texture m_BlackUIntTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00041738 File Offset: 0x0003F938
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00008246 File Offset: 0x00006446
		public unsafe static RTHandle m_BlackUIntTexture2DArrayRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00041760 File Offset: 0x0003F960
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00008258 File Offset: 0x00006458
		public unsafe static RTHandle m_BlackUIntTextureRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTextureRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackUIntTextureRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00041788 File Offset: 0x0003F988
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x0000826A File Offset: 0x0000646A
		public unsafe static Texture2DArray m_ClearTexture2DArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000417B0 File Offset: 0x0003F9B0
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0000827C File Offset: 0x0000647C
		public unsafe static Texture2D m_ClearTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000417D8 File Offset: 0x0003F9D8
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0000828E File Offset: 0x0000648E
		public unsafe static RTHandle m_ClearTexture2DArrayRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArrayRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_ClearTexture2DArrayRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00041800 File Offset: 0x0003FA00
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000082A0 File Offset: 0x000064A0
		public unsafe static RTHandle m_ClearTextureRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_ClearTextureRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_ClearTextureRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00041828 File Offset: 0x0003FA28
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000082B2 File Offset: 0x000064B2
		public unsafe static Texture2DArray m_MagentaTexture2DArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00041850 File Offset: 0x0003FA50
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000082C4 File Offset: 0x000064C4
		public unsafe static Texture2D m_MagentaTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00041878 File Offset: 0x0003FA78
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000082D6 File Offset: 0x000064D6
		public unsafe static RTHandle m_MagentaTexture2DArrayRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000418A0 File Offset: 0x0003FAA0
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000082E8 File Offset: 0x000064E8
		public unsafe static RTHandle m_MagentaTextureRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_MagentaTextureRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_MagentaTextureRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000418C8 File Offset: 0x0003FAC8
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x000082FA File Offset: 0x000064FA
		public unsafe static Texture2D m_BlackTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000418F0 File Offset: 0x0003FAF0
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x0000830C File Offset: 0x0000650C
		public unsafe static Texture3D m_BlackTexture3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture3D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture3D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00041918 File Offset: 0x0003FB18
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0000831E File Offset: 0x0000651E
		public unsafe static Texture2DArray m_BlackTexture2DArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00041940 File Offset: 0x0003FB40
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00008330 File Offset: 0x00006530
		public unsafe static RTHandle m_BlackTexture2DArrayRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArrayRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture2DArrayRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00041968 File Offset: 0x0003FB68
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00008342 File Offset: 0x00006542
		public unsafe static RTHandle m_BlackTextureRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTextureRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTextureRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00041990 File Offset: 0x0003FB90
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00008354 File Offset: 0x00006554
		public unsafe static RTHandle m_BlackTexture3DRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture3DRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_BlackTexture3DRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000419B8 File Offset: 0x0003FBB8
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00008366 File Offset: 0x00006566
		public unsafe static Texture2DArray m_WhiteTexture2DArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000419E0 File Offset: 0x0003FBE0
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00008378 File Offset: 0x00006578
		public unsafe static RTHandle m_WhiteTexture2DArrayRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00041A08 File Offset: 0x0003FC08
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0000838A File Offset: 0x0000658A
		public unsafe static RTHandle m_WhiteTextureRTH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureXR.NativeFieldInfoPtr_m_WhiteTextureRTH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureXR.NativeFieldInfoPtr_m_WhiteTextureRTH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxViews;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackUIntTexture2DArray;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackUIntTexture;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackUIntTextureRTH;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearTexture2DArray;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearTexture;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearTexture2DArrayRTH;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearTextureRTH;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaTexture2DArray;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaTexture;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaTextureRTH;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture3D;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture2DArray;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture2DArrayRTH;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTextureRTH;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture3DRTH;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTexture2DArray;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTextureRTH;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0;
	}
}

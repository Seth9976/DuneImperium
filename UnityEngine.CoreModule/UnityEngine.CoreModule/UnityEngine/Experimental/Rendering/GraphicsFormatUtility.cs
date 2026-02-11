using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000286 RID: 646
	public class GraphicsFormatUtility : Object
	{
		// Token: 0x06002B8F RID: 11151 RVA: 0x000B0298 File Offset: 0x000AE498
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFormatUtility()
		{
			Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "GraphicsFormatUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
			GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableNoStencil");
			GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableStencil");
			GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668643);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668644);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668645);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668646);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668647);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668648);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668649);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668650);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668651);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668652);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668653);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668654);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668655);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668656);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668657);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668658);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668659);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668660);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668661);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668662);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668663);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668664);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668665);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668666);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668667);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668668);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668669);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668670);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668671);
			GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
			GraphicsFormatUtility.IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
			GraphicsFormatUtility.GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
			GraphicsFormatUtility.GetAlphaComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetAlphaComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetAlphaComponentCount");
			GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString_Native_TextureFormat");
			GraphicsFormatUtility.IsCompressedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
			GraphicsFormatUtility.IsPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
			GraphicsFormatUtility.Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
			GraphicsFormatUtility.ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
			GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat_Native_TextureFormat");
			GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat_Native_TextureFormat");
			GraphicsFormatUtility.IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
			GraphicsFormatUtility.HasAlphaChannelDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannelDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel");
			GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel_Native_TextureFormat");
			GraphicsFormatUtility.IsDepthFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDepthFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDepthFormat");
			GraphicsFormatUtility.IsStencilFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsStencilFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsStencilFormat");
			GraphicsFormatUtility.IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
			GraphicsFormatUtility.IsFloatFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsFloatFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsFloatFormat");
			GraphicsFormatUtility.IsHalfFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHalfFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHalfFormat");
			GraphicsFormatUtility.IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
			GraphicsFormatUtility.IsSignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
			GraphicsFormatUtility.IsNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
			GraphicsFormatUtility.IsUNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
			GraphicsFormatUtility.IsSNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
			GraphicsFormatUtility.IsIntegerFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
			GraphicsFormatUtility.IsUIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
			GraphicsFormatUtility.IsSIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
			GraphicsFormatUtility.IsXRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
			GraphicsFormatUtility.IsDXTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
			GraphicsFormatUtility.IsRGTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
			GraphicsFormatUtility.IsBPTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
			GraphicsFormatUtility.IsBCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
			GraphicsFormatUtility.IsETCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
			GraphicsFormatUtility.IsEACFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
			GraphicsFormatUtility.IsASTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
			GraphicsFormatUtility.IsHDRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat");
			GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat_Native_TextureFormat");
			GraphicsFormatUtility.GetBlockWidthDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
			GraphicsFormatUtility.GetBlockHeightDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
			GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_2D");
			GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_3D");
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000B079C File Offset: 0x000AE99C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686247, RefRangeEnd = 686248, XrefRangeStart = 686245, XrefRangeEnd = 686247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetFormat(Texture texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000B07E0 File Offset: 0x000AE9E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 686253, RefRangeEnd = 686259, XrefRangeStart = 686248, XrefRangeEnd = 686253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x000B082C File Offset: 0x000AEA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686259, XrefRangeEnd = 686261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x000B0878 File Offset: 0x000AEA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686266, RefRangeEnd = 686267, XrefRangeStart = 686261, XrefRangeEnd = 686266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000B08C4 File Offset: 0x000AEAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686267, XrefRangeEnd = 686269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000B0910 File Offset: 0x000AEB10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686279, RefRangeEnd = 686281, XrefRangeStart = 686269, XrefRangeEnd = 686279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000B095C File Offset: 0x000AEB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686281, XrefRangeEnd = 686283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumDepthBits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x000B099C File Offset: 0x000AEB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686283, XrefRangeEnd = 686288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumDepthBits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000B09DC File Offset: 0x000AEBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686290, RefRangeEnd = 686292, XrefRangeStart = 686288, XrefRangeEnd = 686290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDepthBits(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000B0A1C File Offset: 0x000AEC1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686294, RefRangeEnd = 686297, XrefRangeStart = 686292, XrefRangeEnd = 686294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumDepthBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumStencilBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000B0A68 File Offset: 0x000AEC68
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 686317, RefRangeEnd = 686332, XrefRangeStart = 686297, XrefRangeEnd = 686317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSRGBFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000B0AA8 File Offset: 0x000AECA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686334, RefRangeEnd = 686335, XrefRangeStart = 686332, XrefRangeEnd = 686334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000B0AE8 File Offset: 0x000AECE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686337, RefRangeEnd = 686339, XrefRangeStart = 686335, XrefRangeEnd = 686337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetLinearFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000B0B28 File Offset: 0x000AED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686339, XrefRangeEnd = 686341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000B0B68 File Offset: 0x000AED68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 686343, RefRangeEnd = 686347, XrefRangeStart = 686341, XrefRangeEnd = 686343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetComponentCount(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686349, RefRangeEnd = 686350, XrefRangeStart = 686347, XrefRangeEnd = 686349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFormatString(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000B0BE0 File Offset: 0x000AEDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686350, XrefRangeEnd = 686352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000B0C20 File Offset: 0x000AEE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686357, RefRangeEnd = 686358, XrefRangeStart = 686352, XrefRangeEnd = 686357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000B0C60 File Offset: 0x000AEE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686358, XrefRangeEnd = 686360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeImage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000B0CAC File Offset: 0x000AEEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686365, RefRangeEnd = 686366, XrefRangeStart = 686360, XrefRangeEnd = 686365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000B0CEC File Offset: 0x000AEEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686368, RefRangeEnd = 686370, XrefRangeStart = 686366, XrefRangeEnd = 686368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAlphaOnlyFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000B0D2C File Offset: 0x000AEF2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686372, RefRangeEnd = 686374, XrefRangeStart = 686370, XrefRangeEnd = 686372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDepthStencilFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000B0D6C File Offset: 0x000AEF6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 686376, RefRangeEnd = 686381, XrefRangeStart = 686374, XrefRangeEnd = 686376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPVRTCFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000B0DAC File Offset: 0x000AEFAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 686383, RefRangeEnd = 686392, XrefRangeStart = 686381, XrefRangeEnd = 686383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCrunchFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000B0DEC File Offset: 0x000AEFEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 686394, RefRangeEnd = 686398, XrefRangeStart = 686392, XrefRangeEnd = 686394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000B0E2C File Offset: 0x000AF02C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686400, RefRangeEnd = 686402, XrefRangeStart = 686398, XrefRangeEnd = 686400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000B0E6C File Offset: 0x000AF06C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686404, RefRangeEnd = 686406, XrefRangeStart = 686402, XrefRangeEnd = 686404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x000B0EAC File Offset: 0x000AF0AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686408, RefRangeEnd = 686410, XrefRangeStart = 686406, XrefRangeEnd = 686408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000B0EEC File Offset: 0x000AF0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686412, RefRangeEnd = 686415, XrefRangeStart = 686410, XrefRangeEnd = 686412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetBlockSize(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00010FEB File Offset: 0x0000F1EB
		public GraphicsFormatUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000B0F2C File Offset: 0x000AF12C
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		public unsafe static Il2CppStructArray<GraphicsFormat> tableNoStencil
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000B0F54 File Offset: 0x000AF154
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00011006 File Offset: 0x0000F206
		public unsafe static Il2CppStructArray<GraphicsFormat> tableStencil
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000B0F7C File Offset: 0x000AF17C
		public static TextureFormat GetTextureFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormat(format);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00011018 File Offset: 0x0000F218
		public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField(format);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00011025 File Offset: 0x0000F225
		public static bool IsSwizzleFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormatDelegateField(format);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000B0F94 File Offset: 0x000AF194
		public static bool IsSwizzleFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00011032 File Offset: 0x0000F232
		public static uint GetColorComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCountDelegateField(format);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000B0FB4 File Offset: 0x000AF1B4
		public static uint GetColorComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0001103F File Offset: 0x0000F23F
		public static uint GetAlphaComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCountDelegateField(format);
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x000B0FD4 File Offset: 0x000AF1D4
		public static uint GetAlphaComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000B0FF4 File Offset: 0x000AF1F4
		public static uint GetComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000B1014 File Offset: 0x000AF214
		public static string GetFormatString_Native_TextureFormat(TextureFormat format)
		{
			IntPtr intPtr = GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegateField(format);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000B1034 File Offset: 0x000AF234
		public static string GetFormatString(TextureFormat format)
		{
			return GraphicsFormatUtility.GetFormatString_Native_TextureFormat(format);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x0001104C File Offset: 0x0000F24C
		public static bool IsCompressedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormatDelegateField(format);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000B104C File Offset: 0x000AF24C
		public static bool IsCompressedTextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormat(format);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00011059 File Offset: 0x0000F259
		public static bool IsPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormatDelegateField(format);
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000B1064 File Offset: 0x000AF264
		public static bool IsPackedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00011066 File Offset: 0x0000F266
		public static bool Is16BitPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormatDelegateField(format);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000B1084 File Offset: 0x000AF284
		public static bool Is16BitPackedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00011073 File Offset: 0x0000F273
		public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormatDelegateField(format);
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00011080 File Offset: 0x0000F280
		public static TextureFormat ConvertToAlphaFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000B10A4 File Offset: 0x000AF2A4
		public static TextureFormat ConvertToAlphaFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x0001108D File Offset: 0x0000F28D
		public static bool IsAlphaOnlyFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000B10BC File Offset: 0x000AF2BC
		public static bool IsAlphaOnlyFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x0001109A File Offset: 0x0000F29A
		public static bool IsAlphaTestFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormatDelegateField(format);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000B10D4 File Offset: 0x000AF2D4
		public static bool IsAlphaTestFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000110A7 File Offset: 0x0000F2A7
		public static bool HasAlphaChannel(GraphicsFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannelDelegateField(format);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000110B4 File Offset: 0x0000F2B4
		public static bool HasAlphaChannel_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000B10F4 File Offset: 0x000AF2F4
		public static bool HasAlphaChannel(TextureFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormat(format);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000110C1 File Offset: 0x0000F2C1
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDepthFormatDelegateField(format);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000110CE File Offset: 0x0000F2CE
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsStencilFormatDelegateField(format);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000110DB File Offset: 0x0000F2DB
		public static bool IsIEEE754Format(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIEEE754FormatDelegateField(format);
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public static bool IsFloatFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsFloatFormatDelegateField(format);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000110F5 File Offset: 0x0000F2F5
		public static bool IsHalfFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHalfFormatDelegateField(format);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00011102 File Offset: 0x0000F302
		public static bool IsUnsignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormatDelegateField(format);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000B110C File Offset: 0x000AF30C
		public static bool IsUnsignedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x0001110F File Offset: 0x0000F30F
		public static bool IsSignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormatDelegateField(format);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000B112C File Offset: 0x000AF32C
		public static bool IsSignedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x0001111C File Offset: 0x0000F31C
		public static bool IsNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsNormFormatDelegateField(format);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00011129 File Offset: 0x0000F329
		public static bool IsUNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUNormFormatDelegateField(format);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00011136 File Offset: 0x0000F336
		public static bool IsSNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSNormFormatDelegateField(format);
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00011143 File Offset: 0x0000F343
		public static bool IsIntegerFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIntegerFormatDelegateField(format);
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00011150 File Offset: 0x0000F350
		public static bool IsUIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUIntFormatDelegateField(format);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x0001115D File Offset: 0x0000F35D
		public static bool IsSIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSIntFormatDelegateField(format);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0001116A File Offset: 0x0000F36A
		public static bool IsXRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsXRFormatDelegateField(format);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00011177 File Offset: 0x0000F377
		public static bool IsDXTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormatDelegateField(format);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000B114C File Offset: 0x000AF34C
		public static bool IsDXTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00011184 File Offset: 0x0000F384
		public static bool IsRGTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormatDelegateField(format);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000B116C File Offset: 0x000AF36C
		public static bool IsRGTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00011191 File Offset: 0x0000F391
		public static bool IsBPTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormatDelegateField(format);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000B118C File Offset: 0x000AF38C
		public static bool IsBPTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0001119E File Offset: 0x0000F39E
		public static bool IsBCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBCFormatDelegateField(format);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000B11AC File Offset: 0x000AF3AC
		public static bool IsBCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsBCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000B11CC File Offset: 0x000AF3CC
		public static bool IsPVRTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsPVRTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000111AB File Offset: 0x0000F3AB
		public static bool IsETCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsETCFormatDelegateField(format);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000B11EC File Offset: 0x000AF3EC
		public static bool IsETCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsETCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public static bool IsEACFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsEACFormatDelegateField(format);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000B120C File Offset: 0x000AF40C
		public static bool IsEACFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsEACFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000111C5 File Offset: 0x0000F3C5
		public static bool IsASTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormatDelegateField(format);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000B122C File Offset: 0x000AF42C
		public static bool IsASTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000111D2 File Offset: 0x0000F3D2
		public static bool IsHDRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormatDelegateField(format);
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000111DF File Offset: 0x0000F3DF
		public static bool IsHDRFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000B124C File Offset: 0x000AF44C
		public static bool IsHDRFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000B1264 File Offset: 0x000AF464
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleR(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000B1284 File Offset: 0x000AF484
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleG(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000B12A4 File Offset: 0x000AF4A4
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleB(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000B12C4 File Offset: 0x000AF4C4
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleA(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000B12E4 File Offset: 0x000AF4E4
		public static uint GetBlockSize(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockSize(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000111EC File Offset: 0x0000F3EC
		public static uint GetBlockWidth(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidthDelegateField(format);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000B1304 File Offset: 0x000AF504
		public static uint GetBlockWidth(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidth(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000111F9 File Offset: 0x0000F3F9
		public static uint GetBlockHeight(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeightDelegateField(format);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000B1324 File Offset: 0x000AF524
		public static uint GetBlockHeight(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeight(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000B1344 File Offset: 0x000AF544
		public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, 1);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000B1360 File Offset: 0x000AF560
		public static uint ComputeMipmapSize(int width, int height, TextureFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00011206 File Offset: 0x0000F406
		public static uint ComputeMipChainSize_Native_2D(int width, int height, GraphicsFormat format, int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField(width, height, format, mipCount);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000B1380 File Offset: 0x000AF580
		public static uint ComputeMipChainSize(int width, int height, GraphicsFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, mipCount);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000B139C File Offset: 0x000AF59C
		public static uint ComputeMipChainSize(int width, int height, TextureFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000B13C0 File Offset: 0x000AF5C0
		public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, 1);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000B13DC File Offset: 0x000AF5DC
		public static uint ComputeMipmapSize(int width, int height, int depth, TextureFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00011216 File Offset: 0x0000F416
		public static uint ComputeMipChainSize_Native_3D(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField(width, height, depth, format, mipCount);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000B1400 File Offset: 0x000AF600
		public static uint ComputeMipChainSize(int width, int height, int depth, GraphicsFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, mipCount);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000B1420 File Offset: 0x000AF620
		public static uint ComputeMipChainSize(int width, int height, int depth, TextureFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
		}

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeFieldInfoPtr_tableNoStencil;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeFieldInfoPtr_tableStencil;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0;

		// Token: 0x04002755 RID: 10069
		private static readonly GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;

		// Token: 0x04002756 RID: 10070
		private static readonly GraphicsFormatUtility.IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;

		// Token: 0x04002757 RID: 10071
		private static readonly GraphicsFormatUtility.GetColorComponentCountDelegate GetColorComponentCountDelegateField;

		// Token: 0x04002758 RID: 10072
		private static readonly GraphicsFormatUtility.GetAlphaComponentCountDelegate GetAlphaComponentCountDelegateField;

		// Token: 0x04002759 RID: 10073
		private static readonly GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegate GetFormatString_Native_TextureFormatDelegateField;

		// Token: 0x0400275A RID: 10074
		private static readonly GraphicsFormatUtility.IsCompressedFormatDelegate IsCompressedFormatDelegateField;

		// Token: 0x0400275B RID: 10075
		private static readonly GraphicsFormatUtility.IsPackedFormatDelegate IsPackedFormatDelegateField;

		// Token: 0x0400275C RID: 10076
		private static readonly GraphicsFormatUtility.Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;

		// Token: 0x0400275D RID: 10077
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;

		// Token: 0x0400275E RID: 10078
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate ConvertToAlphaFormat_Native_TextureFormatDelegateField;

		// Token: 0x0400275F RID: 10079
		private static readonly GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate IsAlphaOnlyFormat_Native_TextureFormatDelegateField;

		// Token: 0x04002760 RID: 10080
		private static readonly GraphicsFormatUtility.IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;

		// Token: 0x04002761 RID: 10081
		private static readonly GraphicsFormatUtility.HasAlphaChannelDelegate HasAlphaChannelDelegateField;

		// Token: 0x04002762 RID: 10082
		private static readonly GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate HasAlphaChannel_Native_TextureFormatDelegateField;

		// Token: 0x04002763 RID: 10083
		private static readonly GraphicsFormatUtility.IsDepthFormatDelegate IsDepthFormatDelegateField;

		// Token: 0x04002764 RID: 10084
		private static readonly GraphicsFormatUtility.IsStencilFormatDelegate IsStencilFormatDelegateField;

		// Token: 0x04002765 RID: 10085
		private static readonly GraphicsFormatUtility.IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;

		// Token: 0x04002766 RID: 10086
		private static readonly GraphicsFormatUtility.IsFloatFormatDelegate IsFloatFormatDelegateField;

		// Token: 0x04002767 RID: 10087
		private static readonly GraphicsFormatUtility.IsHalfFormatDelegate IsHalfFormatDelegateField;

		// Token: 0x04002768 RID: 10088
		private static readonly GraphicsFormatUtility.IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;

		// Token: 0x04002769 RID: 10089
		private static readonly GraphicsFormatUtility.IsSignedFormatDelegate IsSignedFormatDelegateField;

		// Token: 0x0400276A RID: 10090
		private static readonly GraphicsFormatUtility.IsNormFormatDelegate IsNormFormatDelegateField;

		// Token: 0x0400276B RID: 10091
		private static readonly GraphicsFormatUtility.IsUNormFormatDelegate IsUNormFormatDelegateField;

		// Token: 0x0400276C RID: 10092
		private static readonly GraphicsFormatUtility.IsSNormFormatDelegate IsSNormFormatDelegateField;

		// Token: 0x0400276D RID: 10093
		private static readonly GraphicsFormatUtility.IsIntegerFormatDelegate IsIntegerFormatDelegateField;

		// Token: 0x0400276E RID: 10094
		private static readonly GraphicsFormatUtility.IsUIntFormatDelegate IsUIntFormatDelegateField;

		// Token: 0x0400276F RID: 10095
		private static readonly GraphicsFormatUtility.IsSIntFormatDelegate IsSIntFormatDelegateField;

		// Token: 0x04002770 RID: 10096
		private static readonly GraphicsFormatUtility.IsXRFormatDelegate IsXRFormatDelegateField;

		// Token: 0x04002771 RID: 10097
		private static readonly GraphicsFormatUtility.IsDXTCFormatDelegate IsDXTCFormatDelegateField;

		// Token: 0x04002772 RID: 10098
		private static readonly GraphicsFormatUtility.IsRGTCFormatDelegate IsRGTCFormatDelegateField;

		// Token: 0x04002773 RID: 10099
		private static readonly GraphicsFormatUtility.IsBPTCFormatDelegate IsBPTCFormatDelegateField;

		// Token: 0x04002774 RID: 10100
		private static readonly GraphicsFormatUtility.IsBCFormatDelegate IsBCFormatDelegateField;

		// Token: 0x04002775 RID: 10101
		private static readonly GraphicsFormatUtility.IsETCFormatDelegate IsETCFormatDelegateField;

		// Token: 0x04002776 RID: 10102
		private static readonly GraphicsFormatUtility.IsEACFormatDelegate IsEACFormatDelegateField;

		// Token: 0x04002777 RID: 10103
		private static readonly GraphicsFormatUtility.IsASTCFormatDelegate IsASTCFormatDelegateField;

		// Token: 0x04002778 RID: 10104
		private static readonly GraphicsFormatUtility.IsHDRFormatDelegate IsHDRFormatDelegateField;

		// Token: 0x04002779 RID: 10105
		private static readonly GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate IsHDRFormat_Native_TextureFormatDelegateField;

		// Token: 0x0400277A RID: 10106
		private static readonly GraphicsFormatUtility.GetBlockWidthDelegate GetBlockWidthDelegateField;

		// Token: 0x0400277B RID: 10107
		private static readonly GraphicsFormatUtility.GetBlockHeightDelegate GetBlockHeightDelegateField;

		// Token: 0x0400277C RID: 10108
		private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate ComputeMipChainSize_Native_2DDelegateField;

		// Token: 0x0400277D RID: 10109
		private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate ComputeMipChainSize_Native_3DDelegateField;

		// Token: 0x02000A6F RID: 2671
		// (Invoke) Token: 0x06003E02 RID: 15874
		private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A70 RID: 2672
		// (Invoke) Token: 0x06003E04 RID: 15876
		private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A71 RID: 2673
		// (Invoke) Token: 0x06003E06 RID: 15878
		private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A72 RID: 2674
		// (Invoke) Token: 0x06003E08 RID: 15880
		private delegate uint GetAlphaComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A73 RID: 2675
		// (Invoke) Token: 0x06003E0A RID: 15882
		private delegate IntPtr GetFormatString_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000A74 RID: 2676
		// (Invoke) Token: 0x06003E0C RID: 15884
		private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A75 RID: 2677
		// (Invoke) Token: 0x06003E0E RID: 15886
		private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A76 RID: 2678
		// (Invoke) Token: 0x06003E10 RID: 15888
		private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A77 RID: 2679
		// (Invoke) Token: 0x06003E12 RID: 15890
		private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A78 RID: 2680
		// (Invoke) Token: 0x06003E14 RID: 15892
		private delegate TextureFormat ConvertToAlphaFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000A79 RID: 2681
		// (Invoke) Token: 0x06003E16 RID: 15894
		private delegate bool IsAlphaOnlyFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000A7A RID: 2682
		// (Invoke) Token: 0x06003E18 RID: 15896
		private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A7B RID: 2683
		// (Invoke) Token: 0x06003E1A RID: 15898
		private delegate bool HasAlphaChannelDelegate(GraphicsFormat format);

		// Token: 0x02000A7C RID: 2684
		// (Invoke) Token: 0x06003E1C RID: 15900
		private delegate bool HasAlphaChannel_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000A7D RID: 2685
		// (Invoke) Token: 0x06003E1E RID: 15902
		private delegate bool IsDepthFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A7E RID: 2686
		// (Invoke) Token: 0x06003E20 RID: 15904
		private delegate bool IsStencilFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A7F RID: 2687
		// (Invoke) Token: 0x06003E22 RID: 15906
		private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

		// Token: 0x02000A80 RID: 2688
		// (Invoke) Token: 0x06003E24 RID: 15908
		private delegate bool IsFloatFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A81 RID: 2689
		// (Invoke) Token: 0x06003E26 RID: 15910
		private delegate bool IsHalfFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A82 RID: 2690
		// (Invoke) Token: 0x06003E28 RID: 15912
		private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A83 RID: 2691
		// (Invoke) Token: 0x06003E2A RID: 15914
		private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A84 RID: 2692
		// (Invoke) Token: 0x06003E2C RID: 15916
		private delegate bool IsNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A85 RID: 2693
		// (Invoke) Token: 0x06003E2E RID: 15918
		private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A86 RID: 2694
		// (Invoke) Token: 0x06003E30 RID: 15920
		private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A87 RID: 2695
		// (Invoke) Token: 0x06003E32 RID: 15922
		private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A88 RID: 2696
		// (Invoke) Token: 0x06003E34 RID: 15924
		private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A89 RID: 2697
		// (Invoke) Token: 0x06003E36 RID: 15926
		private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8A RID: 2698
		// (Invoke) Token: 0x06003E38 RID: 15928
		private delegate bool IsXRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8B RID: 2699
		// (Invoke) Token: 0x06003E3A RID: 15930
		private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8C RID: 2700
		// (Invoke) Token: 0x06003E3C RID: 15932
		private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8D RID: 2701
		// (Invoke) Token: 0x06003E3E RID: 15934
		private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8E RID: 2702
		// (Invoke) Token: 0x06003E40 RID: 15936
		private delegate bool IsBCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A8F RID: 2703
		// (Invoke) Token: 0x06003E42 RID: 15938
		private delegate bool IsETCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A90 RID: 2704
		// (Invoke) Token: 0x06003E44 RID: 15940
		private delegate bool IsEACFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A91 RID: 2705
		// (Invoke) Token: 0x06003E46 RID: 15942
		private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A92 RID: 2706
		// (Invoke) Token: 0x06003E48 RID: 15944
		private delegate bool IsHDRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A93 RID: 2707
		// (Invoke) Token: 0x06003E4A RID: 15946
		private delegate bool IsHDRFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000A94 RID: 2708
		// (Invoke) Token: 0x06003E4C RID: 15948
		private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

		// Token: 0x02000A95 RID: 2709
		// (Invoke) Token: 0x06003E4E RID: 15950
		private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

		// Token: 0x02000A96 RID: 2710
		// (Invoke) Token: 0x06003E50 RID: 15952
		private delegate uint ComputeMipChainSize_Native_2DDelegate(int width, int height, GraphicsFormat format, int mipCount);

		// Token: 0x02000A97 RID: 2711
		// (Invoke) Token: 0x06003E52 RID: 15954
		private delegate uint ComputeMipChainSize_Native_3DDelegate(int width, int height, int depth, GraphicsFormat format, int mipCount);
	}
}

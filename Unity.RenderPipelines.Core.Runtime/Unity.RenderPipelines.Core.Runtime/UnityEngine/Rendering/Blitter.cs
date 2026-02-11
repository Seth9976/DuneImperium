using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000CF RID: 207
	public static class Blitter : Object
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x00044FE8 File Offset: 0x000431E8
		// Note: this type is marked as 'beforefieldinit'.
		static Blitter()
		{
			Il2CppClassPointerStore<Blitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Blitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blitter>.NativeClassPtr);
			Blitter.NativeFieldInfoPtr_s_Blit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_Blit");
			Blitter.NativeFieldInfoPtr_s_BlitTexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitTexArray");
			Blitter.NativeFieldInfoPtr_s_BlitTexArraySingleSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitTexArraySingleSlice");
			Blitter.NativeFieldInfoPtr_s_BlitColorAndDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitColorAndDepth");
			Blitter.NativeFieldInfoPtr_s_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_PropertyBlock");
			Blitter.NativeFieldInfoPtr_s_TriangleMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_TriangleMesh");
			Blitter.NativeFieldInfoPtr_s_QuadMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_QuadMesh");
			Blitter.NativeFieldInfoPtr_s_DecodeHdrKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_DecodeHdrKeyword");
			Blitter.NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665492);
			Blitter.NativeMethodInfoPtr_Cleanup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665493);
			Blitter.NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665494);
			Blitter.NativeMethodInfoPtr_DrawTriangle_Private_Static_Void_CommandBuffer_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665495);
			Blitter.NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665496);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665497);
			Blitter.NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665498);
			Blitter.NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665499);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665500);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665501);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665502);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665503);
			Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665504);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665505);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665506);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665507);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665508);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665509);
			Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665510);
			Blitter.NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665511);
			Blitter.NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665512);
			Blitter.NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665513);
			Blitter.NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665514);
			Blitter.NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665515);
			Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665516);
			Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665517);
			Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665518);
			Blitter.NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665519);
			Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665521);
			Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665522);
			Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665523);
			Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100665524);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00045338 File Offset: 0x00043538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 975239, RefRangeEnd = 975241, XrefRangeStart = 975121, XrefRangeEnd = 975239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Shader blitPS, Shader blitColorAndDepthPS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blitPS);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blitColorAndDepthPS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00045380 File Offset: 0x00043580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 975277, RefRangeEnd = 975279, XrefRangeStart = 975241, XrefRangeEnd = 975277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cleanup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Cleanup_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000453A8 File Offset: 0x000435A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975284, XrefRangeStart = 975279, XrefRangeEnd = 975283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref singleSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000453F8 File Offset: 0x000435F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 975292, RefRangeEnd = 975298, XrefRangeStart = 975284, XrefRangeEnd = 975292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_DrawTriangle_Private_Static_Void_CommandBuffer_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00045450 File Offset: 0x00043650
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 975306, RefRangeEnd = 975320, XrefRangeStart = 975298, XrefRangeEnd = 975306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000454A8 File Offset: 0x000436A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 975346, RefRangeEnd = 975351, XrefRangeStart = 975320, XrefRangeEnd = 975346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0004551C File Offset: 0x0004371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975351, XrefRangeEnd = 975366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00045590 File Offset: 0x00043790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975366, XrefRangeEnd = 975394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceColor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceDepth);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00045614 File Offset: 0x00043814
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 975409, RefRangeEnd = 975423, XrefRangeStart = 975394, XrefRangeEnd = 975409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004568C File Offset: 0x0004388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975423, XrefRangeEnd = 975438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00045700 File Offset: 0x00043900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975438, XrefRangeEnd = 975456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00045774 File Offset: 0x00043974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975456, XrefRangeEnd = 975474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00045804 File Offset: 0x00043A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975474, XrefRangeEnd = 975485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00045868 File Offset: 0x00043A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975485, XrefRangeEnd = 975498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000458E0 File Offset: 0x00043AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975498, XrefRangeEnd = 975525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00045958 File Offset: 0x00043B58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 975538, RefRangeEnd = 975541, XrefRangeStart = 975525, XrefRangeEnd = 975538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000459D4 File Offset: 0x00043BD4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 975567, RefRangeEnd = 975598, XrefRangeStart = 975541, XrefRangeEnd = 975567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00045A6C File Offset: 0x00043C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975598, XrefRangeEnd = 975606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f, bool bilinear = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBias;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00045AF0 File Offset: 0x00043CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975606, XrefRangeEnd = 975620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f, bool bilinear = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destViewport;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00045B74 File Offset: 0x00043D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 975648, RefRangeEnd = 975650, XrefRangeStart = 975620, XrefRangeEnd = 975648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00045BF4 File Offset: 0x00043DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975700, RefRangeEnd = 975701, XrefRangeStart = 975650, XrefRangeEnd = 975700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00045C90 File Offset: 0x00043E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975751, RefRangeEnd = 975752, XrefRangeStart = 975701, XrefRangeEnd = 975751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00045D2C File Offset: 0x00043F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975785, RefRangeEnd = 975786, XrefRangeStart = 975752, XrefRangeEnd = 975785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00045DC8 File Offset: 0x00043FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975819, RefRangeEnd = 975820, XrefRangeStart = 975786, XrefRangeEnd = 975819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00045E64 File Offset: 0x00044064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975847, RefRangeEnd = 975848, XrefRangeStart = 975820, XrefRangeEnd = 975847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00045EC8 File Offset: 0x000440C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975897, RefRangeEnd = 975898, XrefRangeStart = 975848, XrefRangeEnd = 975897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Nullable<Vector4> decodeInstructions = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bilinear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingInPixels;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(decodeInstructions));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00045F70 File Offset: 0x00044170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975935, RefRangeEnd = 975936, XrefRangeStart = 975898, XrefRangeEnd = 975935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00045FD4 File Offset: 0x000441D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 975973, RefRangeEnd = 975974, XrefRangeStart = 975936, XrefRangeEnd = 975973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasTex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleBiasRT;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevelTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00046048 File Offset: 0x00044248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975974, XrefRangeEnd = 975977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0(float z)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref z;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00046088 File Offset: 0x00044288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975977, XrefRangeEnd = 975982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000460BC File Offset: 0x000442BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975982, XrefRangeEnd = 975985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1(float z)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref z;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000460FC File Offset: 0x000442FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975985, XrefRangeEnd = 975989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blitter.NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00008467 File Offset: 0x00006667
		public Blitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00046130 File Offset: 0x00044330
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00008470 File Offset: 0x00006670
		public unsafe static Material s_Blit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_Blit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_Blit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00046158 File Offset: 0x00044358
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00008482 File Offset: 0x00006682
		public unsafe static Material s_BlitTexArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_BlitTexArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_BlitTexArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00046180 File Offset: 0x00044380
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x00008494 File Offset: 0x00006694
		public unsafe static Material s_BlitTexArraySingleSlice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_BlitTexArraySingleSlice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_BlitTexArraySingleSlice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000461A8 File Offset: 0x000443A8
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x000084A6 File Offset: 0x000066A6
		public unsafe static Material s_BlitColorAndDepth
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_BlitColorAndDepth, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_BlitColorAndDepth, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000461D0 File Offset: 0x000443D0
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x000084B8 File Offset: 0x000066B8
		public unsafe static MaterialPropertyBlock s_PropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_PropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_PropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x000461F8 File Offset: 0x000443F8
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x000084CA File Offset: 0x000066CA
		public unsafe static Mesh s_TriangleMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_TriangleMesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_TriangleMesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00046220 File Offset: 0x00044420
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x000084DC File Offset: 0x000066DC
		public unsafe static Mesh s_QuadMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_QuadMesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_QuadMesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00046248 File Offset: 0x00044448
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x000084EE File Offset: 0x000066EE
		public unsafe static LocalKeyword s_DecodeHdrKeyword
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Blitter.NativeFieldInfoPtr_s_DecodeHdrKeyword, intPtr);
				return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blitter.NativeFieldInfoPtr_s_DecodeHdrKeyword, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_s_Blit;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_s_BlitTexArray;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr_s_BlitTexArraySingleSlice;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr_s_BlitColorAndDepth;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_s_PropertyBlock;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeFieldInfoPtr_s_TriangleMesh;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeFieldInfoPtr_s_QuadMesh;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeFieldInfoPtr_s_DecodeHdrKeyword;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Static_Void_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_DrawTriangle_Private_Static_Void_CommandBuffer_Material_Int32_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1;

		// Token: 0x020001F2 RID: 498
		public static class BlitShaderIDs : Object
		{
			// Token: 0x06001A65 RID: 6757 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
			// Note: this type is marked as 'beforefieldinit'.
			static BlitShaderIDs()
			{
				Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "BlitShaderIDs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr);
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitTexture");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitCubeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitCubeTexture");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitScaleBias");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitScaleBiasRt");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitMipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitMipLevel");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitTextureSize");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitPaddingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitPaddingSize");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitDecodeInstructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_BlitDecodeInstructions");
				Blitter.BlitShaderIDs.NativeFieldInfoPtr__InputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter.BlitShaderIDs>.NativeClassPtr, "_InputDepth");
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x0000D42F File Offset: 0x0000B62F
			public BlitShaderIDs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0006D3B4 File Offset: 0x0006B5B4
			// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000D438 File Offset: 0x0000B638
			public unsafe static int _BlitTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTexture, (void*)(&value));
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
			// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000D446 File Offset: 0x0000B646
			public unsafe static int _BlitCubeTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitCubeTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitCubeTexture, (void*)(&value));
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0006D3EC File Offset: 0x0006B5EC
			// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000D454 File Offset: 0x0000B654
			public unsafe static int _BlitScaleBias
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBias, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBias, (void*)(&value));
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0006D408 File Offset: 0x0006B608
			// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0000D462 File Offset: 0x0000B662
			public unsafe static int _BlitScaleBiasRt
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBiasRt, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitScaleBiasRt, (void*)(&value));
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0006D424 File Offset: 0x0006B624
			// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0000D470 File Offset: 0x0000B670
			public unsafe static int _BlitMipLevel
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitMipLevel, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitMipLevel, (void*)(&value));
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0006D440 File Offset: 0x0006B640
			// (set) Token: 0x06001A72 RID: 6770 RVA: 0x0000D47E File Offset: 0x0000B67E
			public unsafe static int _BlitTextureSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTextureSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitTextureSize, (void*)(&value));
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06001A73 RID: 6771 RVA: 0x0006D45C File Offset: 0x0006B65C
			// (set) Token: 0x06001A74 RID: 6772 RVA: 0x0000D48C File Offset: 0x0000B68C
			public unsafe static int _BlitPaddingSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitPaddingSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitPaddingSize, (void*)(&value));
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0006D478 File Offset: 0x0006B678
			// (set) Token: 0x06001A76 RID: 6774 RVA: 0x0000D49A File Offset: 0x0000B69A
			public unsafe static int _BlitDecodeInstructions
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitDecodeInstructions, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__BlitDecodeInstructions, (void*)(&value));
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0006D494 File Offset: 0x0006B694
			// (set) Token: 0x06001A78 RID: 6776 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
			public unsafe static int _InputDepth
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__InputDepth, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Blitter.BlitShaderIDs.NativeFieldInfoPtr__InputDepth, (void*)(&value));
				}
			}

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeFieldInfoPtr__BlitTexture;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeFieldInfoPtr__BlitCubeTexture;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeFieldInfoPtr__BlitScaleBias;

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeFieldInfoPtr__BlitScaleBiasRt;

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeFieldInfoPtr__BlitMipLevel;

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeFieldInfoPtr__BlitTextureSize;

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeFieldInfoPtr__BlitPaddingSize;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeFieldInfoPtr__BlitDecodeInstructions;

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeFieldInfoPtr__InputDepth;
		}
	}
}

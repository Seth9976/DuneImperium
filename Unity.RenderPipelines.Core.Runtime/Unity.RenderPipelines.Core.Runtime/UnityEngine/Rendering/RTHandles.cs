using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BB RID: 187
	public static class RTHandles : Object
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x0003CEE4 File Offset: 0x0003B0E4
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandles()
		{
			Il2CppClassPointerStore<RTHandles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandles>.NativeClassPtr);
			RTHandles.NativeFieldInfoPtr_s_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, "s_DefaultInstance");
			RTHandles.NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665198);
			RTHandles.NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665199);
			RTHandles.NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665200);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665201);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665202);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665203);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665204);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665205);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665206);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665207);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665208);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665209);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665210);
			RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665211);
			RTHandles.NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665212);
			RTHandles.NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665213);
			RTHandles.NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665214);
			RTHandles.NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665215);
			RTHandles.NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665216);
			RTHandles.NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665217);
			RTHandles.NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665218);
			RTHandles.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100665219);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		public unsafe static int maxWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972281, XrefRangeEnd = 972285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0003D110 File Offset: 0x0003B310
		public unsafe static int maxHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972285, XrefRangeEnd = 972289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0003D140 File Offset: 0x0003B340
		public unsafe static RTHandleProperties rtHandleProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 972293, RefRangeEnd = 972295, XrefRangeStart = 972289, XrefRangeEnd = 972293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0003D170 File Offset: 0x0003B370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972300, RefRangeEnd = 972305, XrefRangeStart = 972295, XrefRangeEnd = 972300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972305, XrefRangeEnd = 972310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0003D448 File Offset: 0x0003B648
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972322, RefRangeEnd = 972327, XrefRangeStart = 972310, XrefRangeEnd = 972322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc([In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972332, RefRangeEnd = 972333, XrefRangeStart = 972327, XrefRangeEnd = 972332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0003D630 File Offset: 0x0003B830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972345, RefRangeEnd = 972346, XrefRangeStart = 972333, XrefRangeEnd = 972345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(Vector2 scaleFactor, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleFactor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003D6D8 File Offset: 0x0003B8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972351, RefRangeEnd = 972352, XrefRangeStart = 972346, XrefRangeEnd = 972351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0003D828 File Offset: 0x0003BA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972364, RefRangeEnd = 972365, XrefRangeStart = 972352, XrefRangeEnd = 972364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaleFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 972379, RefRangeEnd = 972396, XrefRangeStart = 972365, XrefRangeEnd = 972379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(Texture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0003D918 File Offset: 0x0003BB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972396, XrefRangeEnd = 972408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(RenderTexture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0003D95C File Offset: 0x0003BB5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972415, RefRangeEnd = 972420, XrefRangeStart = 972408, XrefRangeEnd = 972415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(RenderTargetIdentifier tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0003D99C File Offset: 0x0003BB9C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 972425, RefRangeEnd = 972435, XrefRangeStart = 972420, XrefRangeEnd = 972425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(RenderTargetIdentifier tex, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972435, XrefRangeEnd = 972441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle Alloc(RTHandle tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0003DA34 File Offset: 0x0003BC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972447, RefRangeEnd = 972448, XrefRangeStart = 972441, XrefRangeEnd = 972447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0003DA74 File Offset: 0x0003BC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972448, XrefRangeEnd = 972453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useLegacyDynamicResControl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 972459, RefRangeEnd = 972477, XrefRangeStart = 972453, XrefRangeEnd = 972459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(RTHandle rth)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rth);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0003DAFC File Offset: 0x0003BCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972496, RefRangeEnd = 972497, XrefRangeStart = 972477, XrefRangeEnd = 972496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hwDynamicResRequested;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0003DB30 File Offset: 0x0003BD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972497, XrefRangeEnd = 972502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetReferenceSize(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0003DB70 File Offset: 0x0003BD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972502, XrefRangeEnd = 972507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetReferenceSize(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972507, XrefRangeEnd = 972512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CalculateRatioAgainstMaxSize(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandles.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00007D69 File Offset: 0x00005F69
		public RTHandles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00007D72 File Offset: 0x00005F72
		public unsafe static RTHandleSystem s_DefaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RTHandles.NativeFieldInfoPtr_s_DefaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandleSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTHandles.NativeFieldInfoPtr_s_DefaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultInstance;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0;
	}
}

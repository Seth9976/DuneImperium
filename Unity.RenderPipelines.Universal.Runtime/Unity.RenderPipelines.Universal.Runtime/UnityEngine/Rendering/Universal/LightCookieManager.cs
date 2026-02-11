using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000086 RID: 134
	public class LightCookieManager : Object
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x0003F7C4 File Offset: 0x0003D9C4
		// Note: this type is marked as 'beforefieldinit'.
		static LightCookieManager()
		{
			Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightCookieManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr);
			LightCookieManager.NativeFieldInfoPtr_s_DirLightProj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "s_DirLightProj");
			LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_AdditionalLightsCookieAtlas");
			LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_AdditionalLightsCookieShaderData");
			LightCookieManager.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_Settings");
			LightCookieManager.NativeFieldInfoPtr_m_WorkMem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_WorkMem");
			LightCookieManager.NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_VisibleLightIndexToShaderDataIndex");
			LightCookieManager.NativeFieldInfoPtr_k_MaxCookieSizeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "k_MaxCookieSizeDivisor");
			LightCookieManager.NativeFieldInfoPtr_m_CookieSizeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_CookieSizeDivisor");
			LightCookieManager.NativeFieldInfoPtr_m_PrevCookieRequestPixelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_PrevCookieRequestPixelCount");
			LightCookieManager.NativeFieldInfoPtr_m_PrevWarnFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_PrevWarnFrame");
			LightCookieManager.NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "<IsKeywordLightCookieEnabled>k__BackingField");
			LightCookieManager.NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664892);
			LightCookieManager.NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664893);
			LightCookieManager.NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664894);
			LightCookieManager.NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664895);
			LightCookieManager.NativeMethodInfoPtr_isInitialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664896);
			LightCookieManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664897);
			LightCookieManager.NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664898);
			LightCookieManager.NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_CommandBuffer_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664899);
			LightCookieManager.NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664900);
			LightCookieManager.NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664901);
			LightCookieManager.NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664902);
			LightCookieManager.NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664903);
			LightCookieManager.NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_byref_LightData_Il2CppReferenceArray_1_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664904);
			LightCookieManager.NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664905);
			LightCookieManager.NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664906);
			LightCookieManager.NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664907);
			LightCookieManager.NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664908);
			LightCookieManager.NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664909);
			LightCookieManager.NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664910);
			LightCookieManager.NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664911);
			LightCookieManager.NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664912);
			LightCookieManager.NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664913);
			LightCookieManager.NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_byref_LightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664914);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0003FA9C File Offset: 0x0003DC9C
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		public unsafe bool IsKeywordLightCookieEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0003FB18 File Offset: 0x0003DD18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 611359, RefRangeEnd = 611362, XrefRangeStart = 611353, XrefRangeEnd = 611359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCookieManager(ref LightCookieManager.Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0003FB60 File Offset: 0x0003DD60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611388, RefRangeEnd = 611389, XrefRangeStart = 611362, XrefRangeEnd = 611388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitAdditionalLights(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
		[CallerCount(0)]
		public unsafe bool isInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_isInitialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0003FBDC File Offset: 0x0003DDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611393, RefRangeEnd = 611394, XrefRangeStart = 611389, XrefRangeEnd = 611393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0003FC10 File Offset: 0x0003DE10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611394, RefRangeEnd = 611396, XrefRangeStart = 611394, XrefRangeEnd = 611394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLightCookieShaderDataIndex(int visibleLightIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibleLightIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0003FC5C File Offset: 0x0003DE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611418, RefRangeEnd = 611419, XrefRangeStart = 611396, XrefRangeEnd = 611418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ScriptableRenderContext ctx, CommandBuffer cmd, ref LightData lightData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ctx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_CommandBuffer_byref_LightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611440, RefRangeEnd = 611441, XrefRangeStart = 611419, XrefRangeEnd = 611440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &visibleMainLight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0003FD1C File Offset: 0x0003DF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611441, RefRangeEnd = 611442, XrefRangeStart = 611441, XrefRangeEnd = 611441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cookieFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0003FD68 File Offset: 0x0003DF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611442, XrefRangeEnd = 611451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(additionalLightData);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uvTransform;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			additionalLightData = ((intPtr4 == 0) ? null : new UniversalAdditionalLightData(intPtr4));
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0003FDD0 File Offset: 0x0003DFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611484, RefRangeEnd = 611485, XrefRangeStart = 611451, XrefRangeEnd = 611484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetupAdditionalLights(CommandBuffer cmd, ref LightData lightData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_byref_LightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0003FE30 File Offset: 0x0003E030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611521, RefRangeEnd = 611522, XrefRangeStart = 611485, XrefRangeEnd = 611521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterAndValidateAdditionalLights(ref LightData lightData, Il2CppReferenceArray<LightCookieManager.LightCookieMapping> validLightMappings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validLightMappings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_byref_LightData_Il2CppReferenceArray_1_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0003FE90 File Offset: 0x0003E090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611542, RefRangeEnd = 611543, XrefRangeStart = 611522, XrefRangeEnd = 611542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, Il2CppStructArray<Vector4> textureAtlasUVRects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(validLightMappings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureAtlasUVRects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0003FF04 File Offset: 0x0003E104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611557, RefRangeEnd = 611558, XrefRangeStart = 611543, XrefRangeEnd = 611557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FetchUVRects(CommandBuffer cmd, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, Il2CppStructArray<Vector4> textureAtlasUVRects, int cookieSizeDivisor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(validLightMappings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textureAtlasUVRects);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookieSizeDivisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0003FF84 File Offset: 0x0003E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611558, XrefRangeEnd = 611564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint ComputeCookieRequestPixelCount(ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(validLightMappings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611564, XrefRangeEnd = 611567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ApproximateCookieSizeDivisor(float requestAtlasRatio)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requestAtlasRatio;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00040020 File Offset: 0x0003E220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611572, RefRangeEnd = 611573, XrefRangeStart = 611567, XrefRangeEnd = 611572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookieSizeDivisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00040090 File Offset: 0x0003E290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611589, RefRangeEnd = 611590, XrefRangeStart = 611573, XrefRangeEnd = 611589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookieSizeDivisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00040100 File Offset: 0x0003E300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611590, XrefRangeEnd = 611597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeOctahedralCookieSize(Texture cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00040150 File Offset: 0x0003E350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611612, RefRangeEnd = 611614, XrefRangeStart = 611597, XrefRangeEnd = 611612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &uvScaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookieSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000401B0 File Offset: 0x0003E3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611614, XrefRangeEnd = 611618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &uvScaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amountPixels;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookieSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0004020C File Offset: 0x0003E40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611688, RefRangeEnd = 611689, XrefRangeStart = 611618, XrefRangeEnd = 611688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadAdditionalLights(CommandBuffer cmd, ref LightData lightData, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, ref LightCookieManager.WorkSlice<Vector4> validUvRects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(validLightMappings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(validUvRects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_byref_LightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000774D File Offset: 0x0000594D
		public LightCookieManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00040288 File Offset: 0x0003E488
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00007756 File Offset: 0x00005956
		public unsafe static Matrix4x4 s_DirLightProj
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(LightCookieManager.NativeFieldInfoPtr_s_DirLightProj, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightCookieManager.NativeFieldInfoPtr_s_DirLightProj, (void*)(&value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000402A4 File Offset: 0x0003E4A4
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00007764 File Offset: 0x00005964
		public unsafe Texture2DAtlas m_AdditionalLightsCookieAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DAtlas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000402D4 File Offset: 0x0003E4D4
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00007783 File Offset: 0x00005983
		public unsafe LightCookieManager.LightCookieShaderData m_AdditionalLightsCookieShaderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager.LightCookieShaderData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00040304 File Offset: 0x0003E504
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x000077A2 File Offset: 0x000059A2
		public unsafe LightCookieManager.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0004032C File Offset: 0x0003E52C
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x000077BD File Offset: 0x000059BD
		public unsafe LightCookieManager.WorkMemory m_WorkMem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_WorkMem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager.WorkMemory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_WorkMem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0004035C File Offset: 0x0003E55C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000077DC File Offset: 0x000059DC
		public unsafe Il2CppStructArray<int> m_VisibleLightIndexToShaderDataIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0004038C File Offset: 0x0003E58C
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x000077FB File Offset: 0x000059FB
		public unsafe static int k_MaxCookieSizeDivisor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LightCookieManager.NativeFieldInfoPtr_k_MaxCookieSizeDivisor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightCookieManager.NativeFieldInfoPtr_k_MaxCookieSizeDivisor, (void*)(&value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000403A8 File Offset: 0x0003E5A8
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00007809 File Offset: 0x00005A09
		public unsafe int m_CookieSizeDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_CookieSizeDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_CookieSizeDivisor)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000403D0 File Offset: 0x0003E5D0
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00007824 File Offset: 0x00005A24
		public unsafe uint m_PrevCookieRequestPixelCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_PrevCookieRequestPixelCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_PrevCookieRequestPixelCount)) = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000403F8 File Offset: 0x0003E5F8
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0000783F File Offset: 0x00005A3F
		public unsafe int m_PrevWarnFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_PrevWarnFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr_m_PrevWarnFrame)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00040420 File Offset: 0x0003E620
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0000785A File Offset: 0x00005A5A
		public unsafe bool _IsKeywordLightCookieEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_s_DirLightProj;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkMem;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxCookieSizeDivisor;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieSizeDivisor;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevCookieRequestPixelCount;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevWarnFrame;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_isInitialized_Public_Boolean_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_CommandBuffer_byref_LightData_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_byref_LightData_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_byref_LightData_Il2CppReferenceArray_1_LightCookieMapping_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_byref_LightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0;

		// Token: 0x02000192 RID: 402
		public static class ShaderProperty : Object
		{
			// Token: 0x06001DBC RID: 7612 RVA: 0x000782F4 File Offset: 0x000764F4
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderProperty()
			{
				Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "ShaderProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr);
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "mainLightTexture");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightWorldToLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "mainLightWorldToLight");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightCookieTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "mainLightCookieTextureFormat");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasTexture");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasTextureFormat");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieEnableBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsCookieEnableBits");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasUVRectBuffer");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasUVRects");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsWorldToLightBuffer");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsLightTypeBuffer");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsWorldToLights");
				LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderProperty>.NativeClassPtr, "additionalLightsLightTypes");
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x000111A0 File Offset: 0x0000F3A0
			public ShaderProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00078410 File Offset: 0x00076610
			// (set) Token: 0x06001DBF RID: 7615 RVA: 0x000111A9 File Offset: 0x0000F3A9
			public unsafe static int mainLightTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightTexture, (void*)(&value));
				}
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0007842C File Offset: 0x0007662C
			// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x000111B7 File Offset: 0x0000F3B7
			public unsafe static int mainLightWorldToLight
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightWorldToLight, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightWorldToLight, (void*)(&value));
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00078448 File Offset: 0x00076648
			// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x000111C5 File Offset: 0x0000F3C5
			public unsafe static int mainLightCookieTextureFormat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightCookieTextureFormat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_mainLightCookieTextureFormat, (void*)(&value));
				}
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00078464 File Offset: 0x00076664
			// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x000111D3 File Offset: 0x0000F3D3
			public unsafe static int additionalLightsCookieAtlasTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTexture, (void*)(&value));
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00078480 File Offset: 0x00076680
			// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x000111E1 File Offset: 0x0000F3E1
			public unsafe static int additionalLightsCookieAtlasTextureFormat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat, (void*)(&value));
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0007849C File Offset: 0x0007669C
			// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x000111EF File Offset: 0x0000F3EF
			public unsafe static int additionalLightsCookieEnableBits
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieEnableBits, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieEnableBits, (void*)(&value));
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000784B8 File Offset: 0x000766B8
			// (set) Token: 0x06001DCB RID: 7627 RVA: 0x000111FD File Offset: 0x0000F3FD
			public unsafe static int additionalLightsCookieAtlasUVRectBuffer
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer, (void*)(&value));
				}
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000784D4 File Offset: 0x000766D4
			// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0001120B File Offset: 0x0000F40B
			public unsafe static int additionalLightsCookieAtlasUVRects
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects, (void*)(&value));
				}
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000784F0 File Offset: 0x000766F0
			// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00011219 File Offset: 0x0000F419
			public unsafe static int additionalLightsWorldToLightBuffer
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLightBuffer, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLightBuffer, (void*)(&value));
				}
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0007850C File Offset: 0x0007670C
			// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00011227 File Offset: 0x0000F427
			public unsafe static int additionalLightsLightTypeBuffer
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypeBuffer, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypeBuffer, (void*)(&value));
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00078528 File Offset: 0x00076728
			// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00011235 File Offset: 0x0000F435
			public unsafe static int additionalLightsWorldToLights
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLights, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsWorldToLights, (void*)(&value));
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00078544 File Offset: 0x00076744
			// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00011243 File Offset: 0x0000F443
			public unsafe static int additionalLightsLightTypes
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypes, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderProperty.NativeFieldInfoPtr_additionalLightsLightTypes, (void*)(&value));
				}
			}

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeFieldInfoPtr_mainLightTexture;

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr_mainLightWorldToLight;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeFieldInfoPtr_mainLightCookieTextureFormat;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasTexture;

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCookieEnableBits;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsWorldToLightBuffer;

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsLightTypeBuffer;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsWorldToLights;

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeFieldInfoPtr_additionalLightsLightTypes;
		}

		// Token: 0x02000193 RID: 403
		public enum LightCookieShaderFormat
		{
			// Token: 0x04001573 RID: 5491
			None = -1,
			// Token: 0x04001574 RID: 5492
			RGB,
			// Token: 0x04001575 RID: 5493
			Alpha,
			// Token: 0x04001576 RID: 5494
			Red
		}

		// Token: 0x02000194 RID: 404
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x06001DD6 RID: 7638 RVA: 0x00078560 File Offset: 0x00076760
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr);
				LightCookieManager.Settings.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, "atlas");
				LightCookieManager.Settings.NativeFieldInfoPtr_maxAdditionalLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, "maxAdditionalLights");
				LightCookieManager.Settings.NativeFieldInfoPtr_cubeOctahedralSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, "cubeOctahedralSizeScale");
				LightCookieManager.Settings.NativeFieldInfoPtr_useStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, "useStructuredBuffer");
				LightCookieManager.Settings.NativeMethodInfoPtr_Create_Public_Static_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, 100664917);
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x000785F0 File Offset: 0x000767F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 611183, RefRangeEnd = 611186, XrefRangeStart = 611172, XrefRangeEnd = 611183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static LightCookieManager.Settings Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Settings.NativeMethodInfoPtr_Create_Public_Static_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001DD8 RID: 7640 RVA: 0x00011251 File Offset: 0x0000F451
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04001577 RID: 5495
			private static readonly IntPtr NativeFieldInfoPtr_atlas;

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeFieldInfoPtr_maxAdditionalLights;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeFieldInfoPtr_cubeOctahedralSizeScale;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeFieldInfoPtr_useStructuredBuffer;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Settings_0;

			// Token: 0x0400157C RID: 5500
			[FieldOffset(0)]
			public LightCookieManager.Settings.AtlasSettings atlas;

			// Token: 0x0400157D RID: 5501
			[FieldOffset(16)]
			public int maxAdditionalLights;

			// Token: 0x0400157E RID: 5502
			[FieldOffset(20)]
			public float cubeOctahedralSizeScale;

			// Token: 0x0400157F RID: 5503
			[FieldOffset(24)]
			[MarshalAs(4)]
			public bool useStructuredBuffer;

			// Token: 0x02000241 RID: 577
			[StructLayout(2)]
			public struct AtlasSettings
			{
				// Token: 0x06002519 RID: 9497 RVA: 0x0008A8AC File Offset: 0x00088AAC
				// Note: this type is marked as 'beforefieldinit'.
				static AtlasSettings()
				{
					Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager.Settings>.NativeClassPtr, "AtlasSettings");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr);
					LightCookieManager.Settings.AtlasSettings.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, "resolution");
					LightCookieManager.Settings.AtlasSettings.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, "format");
					LightCookieManager.Settings.AtlasSettings.NativeFieldInfoPtr_useMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, "useMips");
					LightCookieManager.Settings.AtlasSettings.NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, 100664918);
					LightCookieManager.Settings.AtlasSettings.NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, 100664919);
				}

				// Token: 0x17000D1E RID: 3358
				// (get) Token: 0x0600251A RID: 9498 RVA: 0x0008A93C File Offset: 0x00088B3C
				public unsafe bool isPow2
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611171, XrefRangeEnd = 611172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Settings.AtlasSettings.NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17000D1F RID: 3359
				// (get) Token: 0x0600251B RID: 9499 RVA: 0x0008A96C File Offset: 0x00088B6C
				public unsafe bool isSquare
				{
					[CallerCount(0)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Settings.AtlasSettings.NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600251C RID: 9500 RVA: 0x00015118 File Offset: 0x00013318
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightCookieManager.Settings.AtlasSettings>.NativeClassPtr, ref this));
				}

				// Token: 0x040019BB RID: 6587
				private static readonly IntPtr NativeFieldInfoPtr_resolution;

				// Token: 0x040019BC RID: 6588
				private static readonly IntPtr NativeFieldInfoPtr_format;

				// Token: 0x040019BD RID: 6589
				private static readonly IntPtr NativeFieldInfoPtr_useMips;

				// Token: 0x040019BE RID: 6590
				private static readonly IntPtr NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0;

				// Token: 0x040019BF RID: 6591
				private static readonly IntPtr NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0;

				// Token: 0x040019C0 RID: 6592
				[FieldOffset(0)]
				public Vector2Int resolution;

				// Token: 0x040019C1 RID: 6593
				[FieldOffset(8)]
				public GraphicsFormat format;

				// Token: 0x040019C2 RID: 6594
				[FieldOffset(12)]
				[MarshalAs(4)]
				public bool useMips;
			}
		}

		// Token: 0x02000195 RID: 405
		[StructLayout(2)]
		public struct Sorting
		{
			// Token: 0x06001DD9 RID: 7641 RVA: 0x00078620 File Offset: 0x00076820
			// Note: this type is marked as 'beforefieldinit'.
			static Sorting()
			{
				Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "Sorting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr);
				LightCookieManager.Sorting.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664920);
				LightCookieManager.Sorting.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664921);
				LightCookieManager.Sorting.NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664922);
				LightCookieManager.Sorting.NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664923);
				LightCookieManager.Sorting.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664924);
				LightCookieManager.Sorting.NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, 100664925);
			}

			// Token: 0x06001DDA RID: 7642 RVA: 0x000786C4 File Offset: 0x000768C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611186, XrefRangeEnd = 611187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void QuickSort<T>(Il2CppArrayBase<T> data, Func<T, T, int> compare)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compare);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DDB RID: 7643 RVA: 0x0007870C File Offset: 0x0007690C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 611196, RefRangeEnd = 611198, XrefRangeStart = 611187, XrefRangeEnd = 611196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void QuickSort<T>(Il2CppArrayBase<T> data, int start, int end, Func<T, T, int> compare)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compare);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DDC RID: 7644 RVA: 0x00078770 File Offset: 0x00076970
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 611200, RefRangeEnd = 611202, XrefRangeStart = 611198, XrefRangeEnd = 611200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T Median3Pivot<T>(Il2CppArrayBase<T> data, int start, int pivot, int end, Func<T, T, int> compare)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compare);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001DDD RID: 7645 RVA: 0x000787EC File Offset: 0x000769EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611202, XrefRangeEnd = 611206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Partition<T>(Il2CppArrayBase<T> data, int start, int end, Func<T, T, int> compare)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compare);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001DDE RID: 7646 RVA: 0x0007885C File Offset: 0x00076A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611206, XrefRangeEnd = 611207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InsertionSort<T>(Il2CppArrayBase<T> data, int start, int end, Func<T, T, int> compare)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compare);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DDF RID: 7647 RVA: 0x000788C0 File Offset: 0x00076AC0
			[CallerCount(0)]
			public unsafe static void Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0<T>(int a, int b, ref LightCookieManager.Sorting.__c__DisplayClass2_0<T> A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.Sorting.MethodInfoStoreGeneric_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x00011263 File Offset: 0x0000F463
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, ref this));
			}

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0;

			// Token: 0x02000242 RID: 578
			[ObfuscatedName("UnityEngine.Rendering.Universal.LightCookieManager+Sorting+<>c__DisplayClass2_0`1")]
			public sealed class __c__DisplayClass2_0<T> : ValueType
			{
				// Token: 0x0600251D RID: 9501 RVA: 0x0008A99C File Offset: 0x00088B9C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass2_0()
				{
					Il2CppClassPointerStore<LightCookieManager.Sorting.__c__DisplayClass2_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr, "<>c__DisplayClass2_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.Sorting.__c__DisplayClass2_0<T>>.NativeClassPtr);
					LightCookieManager.Sorting.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.Sorting.__c__DisplayClass2_0<T>>.NativeClassPtr, "data");
				}

				// Token: 0x0600251E RID: 9502 RVA: 0x0001512A File Offset: 0x0001332A
				public __c__DisplayClass2_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600251F RID: 9503 RVA: 0x00015133 File Offset: 0x00013333
				public __c__DisplayClass2_0()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.Sorting.__c__DisplayClass2_0<T>>.NativeClassPtr))
				{
				}

				// Token: 0x17000D20 RID: 3360
				// (get) Token: 0x06002520 RID: 9504 RVA: 0x0008AA18 File Offset: 0x00088C18
				// (set) Token: 0x06002521 RID: 9505 RVA: 0x00015145 File Offset: 0x00013345
				public unsafe Il2CppArrayBase<T> data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.Sorting.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_data);
						return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.Sorting.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040019C3 RID: 6595
				private static readonly IntPtr NativeFieldInfoPtr_data;
			}

			// Token: 0x02000243 RID: 579
			private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>
			{
				// Token: 0x040019C4 RID: 6596
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000244 RID: 580
			private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
			{
				// Token: 0x040019C5 RID: 6597
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000245 RID: 581
			private sealed class MethodInfoStoreGeneric_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0<T>
			{
				// Token: 0x040019C6 RID: 6598
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000246 RID: 582
			private sealed class MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
			{
				// Token: 0x040019C7 RID: 6599
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000247 RID: 583
			private sealed class MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
			{
				// Token: 0x040019C8 RID: 6600
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000248 RID: 584
			private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0<T>
			{
				// Token: 0x040019C9 RID: 6601
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCookieManager.Sorting.NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass2_0_1_T_PDM_0, Il2CppClassPointerStore<LightCookieManager.Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000196 RID: 406
		public sealed class LightCookieMapping : ValueType
		{
			// Token: 0x06001DE1 RID: 7649 RVA: 0x00078914 File Offset: 0x00076B14
			// Note: this type is marked as 'beforefieldinit'.
			static LightCookieMapping()
			{
				Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "LightCookieMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr);
				LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "visibleLightIndex");
				LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_lightBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "lightBufferIndex");
				LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "light");
				LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "s_CompareByCookieSize");
				LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "s_CompareByBufferIndex");
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x00011275 File Offset: 0x0000F475
			public LightCookieMapping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x0001127E File Offset: 0x0000F47E
			public LightCookieMapping()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000789A4 File Offset: 0x00076BA4
			// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00011290 File Offset: 0x0000F490
			public unsafe ushort visibleLightIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_visibleLightIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_visibleLightIndex)) = value;
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x000789CC File Offset: 0x00076BCC
			// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x000112AB File Offset: 0x0000F4AB
			public unsafe ushort lightBufferIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_lightBufferIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_lightBufferIndex)) = value;
				}
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000789F4 File Offset: 0x00076BF4
			// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x000112C6 File Offset: 0x0000F4C6
			public unsafe Light light
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_light);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00078A24 File Offset: 0x00076C24
			// (set) Token: 0x06001DEB RID: 7659 RVA: 0x000112E5 File Offset: 0x0000F4E5
			public unsafe static Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByCookieSize, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByCookieSize, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00078A4C File Offset: 0x00076C4C
			// (set) Token: 0x06001DED RID: 7661 RVA: 0x000112F7 File Offset: 0x0000F4F7
			public unsafe static Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByBufferIndex, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.LightCookieMapping.NativeFieldInfoPtr_s_CompareByBufferIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr_visibleLightIndex;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeFieldInfoPtr_lightBufferIndex;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeFieldInfoPtr_s_CompareByCookieSize;

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeFieldInfoPtr_s_CompareByBufferIndex;

			// Token: 0x02000249 RID: 585
			[ObfuscatedName("UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06002528 RID: 9512 RVA: 0x0008AC38 File Offset: 0x00088E38
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr);
					LightCookieManager.LightCookieMapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr, "<>9");
					LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr, 100664928);
					LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr, 100664929);
					LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr, 100664930);
				}

				// Token: 0x06002529 RID: 9513 RVA: 0x0008ACB4 File Offset: 0x00088EB4
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.LightCookieMapping.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600252A RID: 9514 RVA: 0x0008ACF0 File Offset: 0x00088EF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611207, XrefRangeEnd = 611211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int __cctor_b__6_0(LightCookieManager.LightCookieMapping a, LightCookieManager.LightCookieMapping b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600252B RID: 9515 RVA: 0x0008AD5C File Offset: 0x00088F5C
				[CallerCount(0)]
				public unsafe int __cctor_b__6_1(LightCookieManager.LightCookieMapping a, LightCookieManager.LightCookieMapping b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieMapping.__c.NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600252C RID: 9516 RVA: 0x00015164 File Offset: 0x00013364
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D21 RID: 3361
				// (get) Token: 0x0600252D RID: 9517 RVA: 0x0008ADC8 File Offset: 0x00088FC8
				// (set) Token: 0x0600252E RID: 9518 RVA: 0x0001516D File Offset: 0x0001336D
				public unsafe static LightCookieManager.LightCookieMapping.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LightCookieManager.LightCookieMapping.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager.LightCookieMapping.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LightCookieManager.LightCookieMapping.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040019CA RID: 6602
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040019CB RID: 6603
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040019CC RID: 6604
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0;

				// Token: 0x040019CD RID: 6605
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0;
			}
		}

		// Token: 0x02000197 RID: 407
		public sealed class WorkSlice<T> : ValueType
		{
			// Token: 0x06001DEE RID: 7662 RVA: 0x00078A74 File Offset: 0x00076C74
			// Note: this type is marked as 'beforefieldinit'.
			static WorkSlice()
			{
				Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "WorkSlice`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr);
				LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, "m_Data");
				LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, "m_Start");
				LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, "m_Length");
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664931);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664932);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664933);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664934);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664935);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664936);
				LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr, 100664937);
			}

			// Token: 0x06001DEF RID: 7663 RVA: 0x00078BA4 File Offset: 0x00076DA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 611213, RefRangeEnd = 611214, XrefRangeStart = 611211, XrefRangeEnd = 611213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkSlice(Il2CppArrayBase<T> src, int srcLen = -1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF0 RID: 7664 RVA: 0x00078C04 File Offset: 0x00076E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611214, XrefRangeEnd = 611220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkSlice(Il2CppArrayBase<T> src, int srcStart, int srcLen = -1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcStart;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB5 RID: 2741
			public unsafe T this[int index]
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 611220, RefRangeEnd = 611226, XrefRangeStart = 611220, XrefRangeEnd = 611220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00078D48 File Offset: 0x00076F48
			public unsafe int length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000AB7 RID: 2743
			// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00078D8C File Offset: 0x00076F8C
			public unsafe int capacity
			{
				[CallerCount(22)]
				[CachedScanResults(RefRangeStart = 336051, RefRangeEnd = 336073, XrefRangeStart = 336051, XrefRangeEnd = 336073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DF5 RID: 7669 RVA: 0x00078DD0 File Offset: 0x00076FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611226, XrefRangeEnd = 611228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Sort(Func<T, T, int> compare)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(compare);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkSlice<T>.NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DF6 RID: 7670 RVA: 0x00011309 File Offset: 0x0000F509
			public WorkSlice(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DF7 RID: 7671 RVA: 0x00011312 File Offset: 0x0000F512
			public WorkSlice()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.WorkSlice<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00078E18 File Offset: 0x00077018
			// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x00011324 File Offset: 0x0000F524
			public unsafe Il2CppArrayBase<T> m_Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Data);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00078E40 File Offset: 0x00077040
			// (set) Token: 0x06001DFB RID: 7675 RVA: 0x00011343 File Offset: 0x0000F543
			public unsafe int m_Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Start)) = value;
				}
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00078E68 File Offset: 0x00077068
			// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0001135E File Offset: 0x0000F55E
			public unsafe int m_Length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkSlice<T>.NativeFieldInfoPtr_m_Length)) = value;
				}
			}

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeFieldInfoPtr_m_Data;

			// Token: 0x0400158C RID: 5516
			private static readonly IntPtr NativeFieldInfoPtr_m_Start;

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeFieldInfoPtr_m_Length;

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0;
		}

		// Token: 0x02000198 RID: 408
		public class WorkMemory : Object
		{
			// Token: 0x06001DFE RID: 7678 RVA: 0x00078E90 File Offset: 0x00077090
			// Note: this type is marked as 'beforefieldinit'.
			static WorkMemory()
			{
				Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "WorkMemory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr);
				LightCookieManager.WorkMemory.NativeFieldInfoPtr_lightMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr, "lightMappings");
				LightCookieManager.WorkMemory.NativeFieldInfoPtr_uvRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr, "uvRects");
				LightCookieManager.WorkMemory.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr, 100664938);
				LightCookieManager.WorkMemory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr, 100664939);
			}

			// Token: 0x06001DFF RID: 7679 RVA: 0x00078F0C File Offset: 0x0007710C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611228, XrefRangeEnd = 611246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkMemory.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E00 RID: 7680 RVA: 0x00078F4C File Offset: 0x0007714C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkMemory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.WorkMemory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.WorkMemory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E01 RID: 7681 RVA: 0x00011379 File Offset: 0x0000F579
			public WorkMemory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00078F88 File Offset: 0x00077188
			// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00011382 File Offset: 0x0000F582
			public unsafe Il2CppReferenceArray<LightCookieManager.LightCookieMapping> lightMappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkMemory.NativeFieldInfoPtr_lightMappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightCookieManager.LightCookieMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkMemory.NativeFieldInfoPtr_lightMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00078FB8 File Offset: 0x000771B8
			// (set) Token: 0x06001E05 RID: 7685 RVA: 0x000113A1 File Offset: 0x0000F5A1
			public unsafe Il2CppStructArray<Vector4> uvRects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkMemory.NativeFieldInfoPtr_uvRects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.WorkMemory.NativeFieldInfoPtr_uvRects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeFieldInfoPtr_lightMappings;

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeFieldInfoPtr_uvRects;

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000199 RID: 409
		public sealed class ShaderBitArray : ValueType
		{
			// Token: 0x06001E06 RID: 7686 RVA: 0x00078FE8 File Offset: 0x000771E8
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderBitArray()
			{
				Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "ShaderBitArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr);
				LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_BitsPerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, "k_BitsPerElement");
				LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, "k_ElementShift");
				LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, "k_ElementMask");
				LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, "m_Data");
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_elemLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664940);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_bitCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664941);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664942);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664943);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664944);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_GetElementIndexAndBitOffset_Private_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664945);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664946);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664947);
				LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, 100664948);
			}

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00079118 File Offset: 0x00077318
			public unsafe int elemLength
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_elemLength_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x06001E08 RID: 7688 RVA: 0x0007915C File Offset: 0x0007735C
			public unsafe int bitCapacity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_bitCapacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000791A0 File Offset: 0x000773A0
			public unsafe Il2CppStructArray<float> data
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x000791E4 File Offset: 0x000773E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 611258, RefRangeEnd = 611259, XrefRangeStart = 611246, XrefRangeEnd = 611258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int bitCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bitCount;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x00079228 File Offset: 0x00077428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611259, XrefRangeEnd = 611260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E0C RID: 7692 RVA: 0x00079260 File Offset: 0x00077460
			[CallerCount(0)]
			public unsafe void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &elemIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bitOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_GetElementIndexAndBitOffset_Private_Void_Int32_byref_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC1 RID: 2753
			public unsafe bool this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611260, XrefRangeEnd = 611261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611261, XrefRangeEnd = 611262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E0F RID: 7695 RVA: 0x00079364 File Offset: 0x00077564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611262, XrefRangeEnd = 611273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.ShaderBitArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001E10 RID: 7696 RVA: 0x000113C0 File Offset: 0x0000F5C0
			public ShaderBitArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E11 RID: 7697 RVA: 0x000113C9 File Offset: 0x0000F5C9
			public ShaderBitArray()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr))
			{
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000793A0 File Offset: 0x000775A0
			// (set) Token: 0x06001E13 RID: 7699 RVA: 0x000113DB File Offset: 0x0000F5DB
			public unsafe static int k_BitsPerElement
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_BitsPerElement, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_BitsPerElement, (void*)(&value));
				}
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000793BC File Offset: 0x000775BC
			// (set) Token: 0x06001E15 RID: 7701 RVA: 0x000113E9 File Offset: 0x0000F5E9
			public unsafe static int k_ElementShift
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementShift, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementShift, (void*)(&value));
				}
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000793D8 File Offset: 0x000775D8
			// (set) Token: 0x06001E17 RID: 7703 RVA: 0x000113F7 File Offset: 0x0000F5F7
			public unsafe static int k_ElementMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_k_ElementMask, (void*)(&value));
				}
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x06001E18 RID: 7704 RVA: 0x000793F4 File Offset: 0x000775F4
			// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00011405 File Offset: 0x0000F605
			public unsafe Il2CppStructArray<float> m_Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_m_Data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.ShaderBitArray.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeFieldInfoPtr_k_BitsPerElement;

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeFieldInfoPtr_k_ElementShift;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeFieldInfoPtr_k_ElementMask;

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeFieldInfoPtr_m_Data;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeMethodInfoPtr_get_elemLength_Public_get_Int32_0;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeMethodInfoPtr_get_bitCapacity_Public_get_Int32_0;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Single_0;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr_GetElementIndexAndBitOffset_Private_Void_Int32_byref_Int32_byref_Int32_0;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x0200019A RID: 410
		public class LightCookieShaderData : Object
		{
			// Token: 0x06001E1A RID: 7706 RVA: 0x00079424 File Offset: 0x00077624
			// Note: this type is marked as 'beforefieldinit'.
			static LightCookieShaderData()
			{
				Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "LightCookieShaderData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr);
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_Size");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_UseStructuredBuffer");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_WorldToLightCpuData");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_AtlasUVRectCpuData");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_LightTypeCpuData");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_CookieEnableBitsCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_CookieEnableBitsCpuData");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_WorldToLightBuffer");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_AtlasUVRectBuffer");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "m_LightTypeBuffer");
				LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr__isUploaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, "<isUploaded>k__BackingField");
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664949);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664950);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664951);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664952);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664953);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664954);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664955);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664956);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664957);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664958);
				LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr, 100664959);
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000795F4 File Offset: 0x000777F4
			public unsafe Il2CppStructArray<Matrix4x4> worldToLights
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
				}
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00079634 File Offset: 0x00077834
			public unsafe LightCookieManager.ShaderBitArray cookieEnableBits
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new LightCookieManager.ShaderBitArray(intPtr);
				}
			}

			// Token: 0x17000ACE RID: 2766
			// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0007966C File Offset: 0x0007786C
			public unsafe Il2CppStructArray<Vector4> atlasUVRects
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
				}
			}

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000796AC File Offset: 0x000778AC
			public unsafe Il2CppStructArray<float> lightTypes
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
				}
			}

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000796EC File Offset: 0x000778EC
			// (set) Token: 0x06001E20 RID: 7712 RVA: 0x00079728 File Offset: 0x00077928
			public unsafe bool isUploaded
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x00079768 File Offset: 0x00077968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611273, XrefRangeEnd = 611275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LightCookieShaderData(int size, bool useStructuredBuffer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager.LightCookieShaderData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useStructuredBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x000797C0 File Offset: 0x000779C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611275, XrefRangeEnd = 611278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E23 RID: 7715 RVA: 0x000797F4 File Offset: 0x000779F4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 611319, RefRangeEnd = 611322, XrefRangeStart = 611278, XrefRangeEnd = 611319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x00079834 File Offset: 0x00077A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611322, XrefRangeEnd = 611347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Upload(CommandBuffer cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E25 RID: 7717 RVA: 0x00079878 File Offset: 0x00077A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611347, XrefRangeEnd = 611353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear(CommandBuffer cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCookieManager.LightCookieShaderData.NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E26 RID: 7718 RVA: 0x00011424 File Offset: 0x0000F624
			public LightCookieShaderData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x06001E27 RID: 7719 RVA: 0x000798BC File Offset: 0x00077ABC
			// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0001142D File Offset: 0x0000F62D
			public unsafe int m_Size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_Size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_Size)) = value;
				}
			}

			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000798E4 File Offset: 0x00077AE4
			// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00011448 File Offset: 0x0000F648
			public unsafe bool m_UseStructuredBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_UseStructuredBuffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_UseStructuredBuffer)) = value;
				}
			}

			// Token: 0x17000AC4 RID: 2756
			// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0007990C File Offset: 0x00077B0C
			// (set) Token: 0x06001E2C RID: 7724 RVA: 0x00011463 File Offset: 0x0000F663
			public unsafe Il2CppStructArray<Matrix4x4> m_WorldToLightCpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightCpuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightCpuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0007993C File Offset: 0x00077B3C
			// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00011482 File Offset: 0x0000F682
			public unsafe Il2CppStructArray<Vector4> m_AtlasUVRectCpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectCpuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectCpuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0007996C File Offset: 0x00077B6C
			// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000114A1 File Offset: 0x0000F6A1
			public unsafe Il2CppStructArray<float> m_LightTypeCpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeCpuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeCpuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0007999C File Offset: 0x00077B9C
			// (set) Token: 0x06001E32 RID: 7730 RVA: 0x000114C0 File Offset: 0x0000F6C0
			public LightCookieManager.ShaderBitArray m_CookieEnableBitsCpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_CookieEnableBitsCpuData);
					return new LightCookieManager.ShaderBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_CookieEnableBitsCpuData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LightCookieManager.ShaderBitArray>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000799CC File Offset: 0x00077BCC
			// (set) Token: 0x06001E34 RID: 7732 RVA: 0x000114EE File Offset: 0x0000F6EE
			public unsafe ComputeBuffer m_WorldToLightBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_WorldToLightBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000799FC File Offset: 0x00077BFC
			// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0001150D File Offset: 0x0000F70D
			public unsafe ComputeBuffer m_AtlasUVRectBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_AtlasUVRectBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00079A2C File Offset: 0x00077C2C
			// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0001152C File Offset: 0x0000F72C
			public unsafe ComputeBuffer m_LightTypeBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr_m_LightTypeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00079A5C File Offset: 0x00077C5C
			// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0001154B File Offset: 0x0000F74B
			public unsafe bool _isUploaded_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr__isUploaded_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCookieManager.LightCookieShaderData.NativeFieldInfoPtr__isUploaded_k__BackingField)) = value;
				}
			}

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeFieldInfoPtr_m_Size;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeFieldInfoPtr_m_WorldToLightCpuData;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeFieldInfoPtr_m_AtlasUVRectCpuData;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeFieldInfoPtr_m_LightTypeCpuData;

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeFieldInfoPtr_m_CookieEnableBitsCpuData;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeFieldInfoPtr_m_WorldToLightBuffer;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr_m_AtlasUVRectBuffer;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr_m_LightTypeBuffer;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeFieldInfoPtr__isUploaded_k__BackingField;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0;

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0;

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0;

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0;

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0;
		}
	}
}

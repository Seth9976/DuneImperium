using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000051 RID: 81
	public static class ShaderUtilities : global::Il2CppSystem.Object
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x0002735C File Offset: 0x0002555C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderUtilities()
		{
			Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ShaderUtilities");
			ShaderUtilities.NativeFieldInfoPtr_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MainTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceDilate");
			ShaderUtilities.NativeFieldInfoPtr_ID_Shininess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Shininess");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetX");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetY");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayDilate");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlaySoftness");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffset");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayIsoPerimeter");
			ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightNormal");
			ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightBold");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineWidth");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineSoftness");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Color");
			ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Width");
			ShaderUtilities.NativeFieldInfoPtr_ID_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Padding");
			ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GradientScale");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleX");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleY");
			ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_PerspectiveFilter");
			ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Sharpness");
			ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureWidth");
			ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureHeight");
			ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_BevelAmount");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOffset");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowPower");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOuter");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowInner");
			ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_LightAngle");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMap");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrix");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrixRotation");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskCoord");
			ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ClipRect");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessX");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessY");
			ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetX");
			ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetY");
			ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UseClipRect");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilID");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilOp");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilComp");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilReadMask");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilWriteMask");
			ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ShaderFlags");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_A");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_B");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_C");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Bevel");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Glow");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Underlay");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Ratios");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_SOFT");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_HARD");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_TEX");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Outline");
			ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_ZTestMode");
			ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_CullMode");
			ShaderUtilities.NativeFieldInfoPtr_m_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "m_clamp");
			ShaderUtilities.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "isInitialized");
			ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileSDF");
			ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileBitmap");
			ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664316);
			ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664317);
			ShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664319);
			ShaderUtilities.NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664320);
			ShaderUtilities.NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664321);
			ShaderUtilities.NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664322);
			ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664323);
			ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664324);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00027974 File Offset: 0x00025B74
		public unsafe static Shader ShaderRef_MobileSDF
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1045207, RefRangeEnd = 1045208, XrefRangeStart = 1045188, XrefRangeEnd = 1045207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000279A8 File Offset: 0x00025BA8
		public unsafe static Shader ShaderRef_MobileBitmap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1045227, RefRangeEnd = 1045228, XrefRangeStart = 1045208, XrefRangeEnd = 1045227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000279DC File Offset: 0x00025BDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1045477, RefRangeEnd = 1045485, XrefRangeStart = 1045228, XrefRangeEnd = 1045477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetShaderPropertyIDs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00027A04 File Offset: 0x00025C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1045556, RefRangeEnd = 1045558, XrefRangeStart = 1045485, XrefRangeEnd = 1045556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateShaderRatios(Material mat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00027A3C File Offset: 0x00025C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045558, XrefRangeEnd = 1045560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetFontExtent(Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00027A80 File Offset: 0x00025C80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1045588, RefRangeEnd = 1045593, XrefRangeStart = 1045560, XrefRangeEnd = 1045588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMaskingEnabled(Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00027AC4 File Offset: 0x00025CC4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1045701, RefRangeEnd = 1045710, XrefRangeStart = 1045593, XrefRangeEnd = 1045701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableExtraPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00027B24 File Offset: 0x00025D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045710, XrefRangeEnd = 1045816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPadding(Il2CppReferenceArray<Material> materials, bool enableExtraPadding, bool isBold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableExtraPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00006178 File Offset: 0x00004378
		public ShaderUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00027B84 File Offset: 0x00025D84
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00006181 File Offset: 0x00004381
		public unsafe static int ID_MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00027BA0 File Offset: 0x00025DA0
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0000618F File Offset: 0x0000438F
		public unsafe static int ID_FaceTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00027BBC File Offset: 0x00025DBC
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x0000619D File Offset: 0x0000439D
		public unsafe static int ID_FaceColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00027BD8 File Offset: 0x00025DD8
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000061AB File Offset: 0x000043AB
		public unsafe static int ID_FaceDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00027BF4 File Offset: 0x00025DF4
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000061B9 File Offset: 0x000043B9
		public unsafe static int ID_Shininess
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00027C10 File Offset: 0x00025E10
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x000061C7 File Offset: 0x000043C7
		public unsafe static int ID_UnderlayColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00027C2C File Offset: 0x00025E2C
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe static int ID_UnderlayOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00027C48 File Offset: 0x00025E48
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x000061E3 File Offset: 0x000043E3
		public unsafe static int ID_UnderlayOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00027C64 File Offset: 0x00025E64
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000061F1 File Offset: 0x000043F1
		public unsafe static int ID_UnderlayDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00027C80 File Offset: 0x00025E80
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000061FF File Offset: 0x000043FF
		public unsafe static int ID_UnderlaySoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00027C9C File Offset: 0x00025E9C
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0000620D File Offset: 0x0000440D
		public unsafe static int ID_UnderlayOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00027CB8 File Offset: 0x00025EB8
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe static int ID_UnderlayIsoPerimeter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00027CD4 File Offset: 0x00025ED4
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00006229 File Offset: 0x00004429
		public unsafe static int ID_WeightNormal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00027CF0 File Offset: 0x00025EF0
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe static int ID_WeightBold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00027D0C File Offset: 0x00025F0C
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00006245 File Offset: 0x00004445
		public unsafe static int ID_OutlineTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00027D28 File Offset: 0x00025F28
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00006253 File Offset: 0x00004453
		public unsafe static int ID_OutlineWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00027D44 File Offset: 0x00025F44
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00006261 File Offset: 0x00004461
		public unsafe static int ID_OutlineSoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00027D60 File Offset: 0x00025F60
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0000626F File Offset: 0x0000446F
		public unsafe static int ID_OutlineColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00027D7C File Offset: 0x00025F7C
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0000627D File Offset: 0x0000447D
		public unsafe static int ID_Outline2Color
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00027D98 File Offset: 0x00025F98
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0000628B File Offset: 0x0000448B
		public unsafe static int ID_Outline2Width
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00027DB4 File Offset: 0x00025FB4
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00006299 File Offset: 0x00004499
		public unsafe static int ID_Padding
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00027DD0 File Offset: 0x00025FD0
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000062A7 File Offset: 0x000044A7
		public unsafe static int ID_GradientScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00027DEC File Offset: 0x00025FEC
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x000062B5 File Offset: 0x000044B5
		public unsafe static int ID_ScaleX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00027E08 File Offset: 0x00026008
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x000062C3 File Offset: 0x000044C3
		public unsafe static int ID_ScaleY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00027E24 File Offset: 0x00026024
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000062D1 File Offset: 0x000044D1
		public unsafe static int ID_PerspectiveFilter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00027E40 File Offset: 0x00026040
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x000062DF File Offset: 0x000044DF
		public unsafe static int ID_Sharpness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x00027E5C File Offset: 0x0002605C
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x000062ED File Offset: 0x000044ED
		public unsafe static int ID_TextureWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00027E78 File Offset: 0x00026078
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000062FB File Offset: 0x000044FB
		public unsafe static int ID_TextureHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00027E94 File Offset: 0x00026094
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00006309 File Offset: 0x00004509
		public unsafe static int ID_BevelAmount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00027EB0 File Offset: 0x000260B0
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00006317 File Offset: 0x00004517
		public unsafe static int ID_GlowColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00027ECC File Offset: 0x000260CC
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00006325 File Offset: 0x00004525
		public unsafe static int ID_GlowOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00027EE8 File Offset: 0x000260E8
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00006333 File Offset: 0x00004533
		public unsafe static int ID_GlowPower
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00027F04 File Offset: 0x00026104
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00006341 File Offset: 0x00004541
		public unsafe static int ID_GlowOuter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00027F20 File Offset: 0x00026120
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0000634F File Offset: 0x0000454F
		public unsafe static int ID_GlowInner
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00027F3C File Offset: 0x0002613C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x0000635D File Offset: 0x0000455D
		public unsafe static int ID_LightAngle
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00027F58 File Offset: 0x00026158
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0000636B File Offset: 0x0000456B
		public unsafe static int ID_EnvMap
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00027F74 File Offset: 0x00026174
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00006379 File Offset: 0x00004579
		public unsafe static int ID_EnvMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00027F90 File Offset: 0x00026190
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00006387 File Offset: 0x00004587
		public unsafe static int ID_EnvMatrixRotation
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00027FAC File Offset: 0x000261AC
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00006395 File Offset: 0x00004595
		public unsafe static int ID_MaskCoord
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00027FC8 File Offset: 0x000261C8
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000063A3 File Offset: 0x000045A3
		public unsafe static int ID_ClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00027FE4 File Offset: 0x000261E4
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000063B1 File Offset: 0x000045B1
		public unsafe static int ID_MaskSoftnessX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00028000 File Offset: 0x00026200
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000063BF File Offset: 0x000045BF
		public unsafe static int ID_MaskSoftnessY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002801C File Offset: 0x0002621C
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000063CD File Offset: 0x000045CD
		public unsafe static int ID_VertexOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00028038 File Offset: 0x00026238
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x000063DB File Offset: 0x000045DB
		public unsafe static int ID_VertexOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00028054 File Offset: 0x00026254
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000063E9 File Offset: 0x000045E9
		public unsafe static int ID_UseClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00028070 File Offset: 0x00026270
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x000063F7 File Offset: 0x000045F7
		public unsafe static int ID_StencilID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002808C File Offset: 0x0002628C
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00006405 File Offset: 0x00004605
		public unsafe static int ID_StencilOp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000280A8 File Offset: 0x000262A8
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006413 File Offset: 0x00004613
		public unsafe static int ID_StencilComp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x000280C4 File Offset: 0x000262C4
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00006421 File Offset: 0x00004621
		public unsafe static int ID_StencilReadMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000280E0 File Offset: 0x000262E0
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0000642F File Offset: 0x0000462F
		public unsafe static int ID_StencilWriteMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000280FC File Offset: 0x000262FC
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0000643D File Offset: 0x0000463D
		public unsafe static int ID_ShaderFlags
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00028118 File Offset: 0x00026318
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0000644B File Offset: 0x0000464B
		public unsafe static int ID_ScaleRatio_A
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00028134 File Offset: 0x00026334
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00006459 File Offset: 0x00004659
		public unsafe static int ID_ScaleRatio_B
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00028150 File Offset: 0x00026350
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00006467 File Offset: 0x00004667
		public unsafe static int ID_ScaleRatio_C
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002816C File Offset: 0x0002636C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00006475 File Offset: 0x00004675
		public unsafe static string Keyword_Bevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002818C File Offset: 0x0002638C
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00006487 File Offset: 0x00004687
		public unsafe static string Keyword_Glow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000281AC File Offset: 0x000263AC
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00006499 File Offset: 0x00004699
		public unsafe static string Keyword_Underlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x000281CC File Offset: 0x000263CC
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000064AB File Offset: 0x000046AB
		public unsafe static string Keyword_Ratios
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000281EC File Offset: 0x000263EC
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000064BD File Offset: 0x000046BD
		public unsafe static string Keyword_MASK_SOFT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002820C File Offset: 0x0002640C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000064CF File Offset: 0x000046CF
		public unsafe static string Keyword_MASK_HARD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002822C File Offset: 0x0002642C
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000064E1 File Offset: 0x000046E1
		public unsafe static string Keyword_MASK_TEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002824C File Offset: 0x0002644C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x000064F3 File Offset: 0x000046F3
		public unsafe static string Keyword_Outline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002826C File Offset: 0x0002646C
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00006505 File Offset: 0x00004705
		public unsafe static string ShaderTag_ZTestMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0002828C File Offset: 0x0002648C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00006517 File Offset: 0x00004717
		public unsafe static string ShaderTag_CullMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x000282AC File Offset: 0x000264AC
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00006529 File Offset: 0x00004729
		public unsafe static float m_clamp
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x000282C8 File Offset: 0x000264C8
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00006537 File Offset: 0x00004737
		public unsafe static bool isInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000282E4 File Offset: 0x000264E4
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00006545 File Offset: 0x00004745
		public unsafe static Shader k_ShaderRef_MobileSDF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0002830C File Offset: 0x0002650C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00006557 File Offset: 0x00004757
		public unsafe static Shader k_ShaderRef_MobileBitmap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_ID_MainTex;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceTex;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceColor;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceDilate;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_ID_Shininess;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayColor;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetX;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetY;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayDilate;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlaySoftness;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffset;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayIsoPerimeter;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightNormal;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightBold;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineTex;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineWidth;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineSoftness;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineColor;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Color;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Width;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_ID_Padding;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_ID_GradientScale;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleX;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleY;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_ID_PerspectiveFilter;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_ID_Sharpness;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureWidth;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureHeight;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_ID_BevelAmount;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowColor;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOffset;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowPower;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOuter;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowInner;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_ID_LightAngle;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMap;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrix;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrixRotation;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskCoord;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_ID_ClipRect;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessX;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessY;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetX;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetY;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_ID_UseClipRect;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilID;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilOp;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilComp;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilReadMask;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilWriteMask;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_ID_ShaderFlags;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_A;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_B;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_C;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Bevel;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Glow;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Underlay;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Ratios;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_SOFT;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_HARD;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_TEX;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Outline;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_ZTestMode;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_CullMode;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_m_clamp;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileSDF;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileBitmap;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0;
	}
}

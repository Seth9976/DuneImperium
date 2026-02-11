using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000039 RID: 57
	public static class TextShaderUtilities : Object
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x000199C8 File Offset: 0x00017BC8
		// Note: this type is marked as 'beforefieldinit'.
		static TextShaderUtilities()
		{
			Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextShaderUtilities");
			TextShaderUtilities.NativeFieldInfoPtr_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_MainTex");
			TextShaderUtilities.NativeFieldInfoPtr_ID_FaceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_FaceTex");
			TextShaderUtilities.NativeFieldInfoPtr_ID_FaceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_FaceColor");
			TextShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_FaceDilate");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Shininess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Shininess");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineOffset1");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineOffset2");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineOffset3");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineMode");
			TextShaderUtilities.NativeFieldInfoPtr_ID_IsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_IsoPerimeter");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Softness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Softness");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayColor");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetX");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetY");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayDilate");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlaySoftness");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayOffset");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UnderlayIsoPerimeter");
			TextShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_WeightNormal");
			TextShaderUtilities.NativeFieldInfoPtr_ID_WeightBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_WeightBold");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineTex");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineWidth");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineSoftness");
			TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_OutlineColor");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Outline2Color");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Outline2Width");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Padding");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GradientScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GradientScale");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ScaleX");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ScaleY");
			TextShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_PerspectiveFilter");
			TextShaderUtilities.NativeFieldInfoPtr_ID_Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_Sharpness");
			TextShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_TextureWidth");
			TextShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_TextureHeight");
			TextShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_BevelAmount");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GlowColor");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GlowOffset");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GlowPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GlowPower");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GlowOuter");
			TextShaderUtilities.NativeFieldInfoPtr_ID_GlowInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_GlowInner");
			TextShaderUtilities.NativeFieldInfoPtr_ID_LightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_LightAngle");
			TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_EnvMap");
			TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_EnvMatrix");
			TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_EnvMatrixRotation");
			TextShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_MaskCoord");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ClipRect");
			TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessX");
			TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessY");
			TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_VertexOffsetX");
			TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_VertexOffsetY");
			TextShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_UseClipRect");
			TextShaderUtilities.NativeFieldInfoPtr_ID_StencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_StencilID");
			TextShaderUtilities.NativeFieldInfoPtr_ID_StencilOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_StencilOp");
			TextShaderUtilities.NativeFieldInfoPtr_ID_StencilComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_StencilComp");
			TextShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_StencilReadMask");
			TextShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_StencilWriteMask");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ShaderFlags");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_A");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_B");
			TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_C");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_Bevel");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_Glow");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_Underlay");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_Ratios");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_MASK_SOFT");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_MASK_HARD");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_MASK_TEX");
			TextShaderUtilities.NativeFieldInfoPtr_Keyword_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "Keyword_Outline");
			TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ShaderTag_ZTestMode");
			TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "ShaderTag_CullMode");
			TextShaderUtilities.NativeFieldInfoPtr_m_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "m_clamp");
			TextShaderUtilities.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "isInitialized");
			TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileSDF");
			TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileBitmap");
			TextShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, 100663741);
			TextShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, 100663742);
			TextShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShaderUtilities>.NativeClassPtr, 100663744);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00019FF4 File Offset: 0x000181F4
		public unsafe static Shader ShaderRef_MobileSDF
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1105852, RefRangeEnd = 1105853, XrefRangeStart = 1105807, XrefRangeEnd = 1105852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001A028 File Offset: 0x00018228
		public unsafe static Shader ShaderRef_MobileBitmap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1105898, RefRangeEnd = 1105899, XrefRangeStart = 1105853, XrefRangeEnd = 1105898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001A05C File Offset: 0x0001825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105899, XrefRangeEnd = 1106145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetShaderPropertyIDs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00005B38 File Offset: 0x00003D38
		public TextShaderUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001A084 File Offset: 0x00018284
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00005B41 File Offset: 0x00003D41
		public unsafe static int ID_MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001A0A0 File Offset: 0x000182A0
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00005B4F File Offset: 0x00003D4F
		public unsafe static int ID_FaceTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001A0BC File Offset: 0x000182BC
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00005B5D File Offset: 0x00003D5D
		public unsafe static int ID_FaceColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001A0D8 File Offset: 0x000182D8
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005B6B File Offset: 0x00003D6B
		public unsafe static int ID_FaceDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001A0F4 File Offset: 0x000182F4
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005B79 File Offset: 0x00003D79
		public unsafe static int ID_Shininess
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001A110 File Offset: 0x00018310
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00005B87 File Offset: 0x00003D87
		public unsafe static int ID_OutlineOffset1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset1, (void*)(&value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001A12C File Offset: 0x0001832C
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00005B95 File Offset: 0x00003D95
		public unsafe static int ID_OutlineOffset2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset2, (void*)(&value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001A148 File Offset: 0x00018348
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005BA3 File Offset: 0x00003DA3
		public unsafe static int ID_OutlineOffset3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineOffset3, (void*)(&value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001A164 File Offset: 0x00018364
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005BB1 File Offset: 0x00003DB1
		public unsafe static int ID_OutlineMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineMode, (void*)(&value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001A180 File Offset: 0x00018380
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005BBF File Offset: 0x00003DBF
		public unsafe static int ID_IsoPerimeter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_IsoPerimeter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_IsoPerimeter, (void*)(&value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001A19C File Offset: 0x0001839C
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00005BCD File Offset: 0x00003DCD
		public unsafe static int ID_Softness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Softness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Softness, (void*)(&value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001A1B8 File Offset: 0x000183B8
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005BDB File Offset: 0x00003DDB
		public unsafe static int ID_UnderlayColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001A1D4 File Offset: 0x000183D4
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00005BE9 File Offset: 0x00003DE9
		public unsafe static int ID_UnderlayOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001A1F0 File Offset: 0x000183F0
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00005BF7 File Offset: 0x00003DF7
		public unsafe static int ID_UnderlayOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001A20C File Offset: 0x0001840C
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00005C05 File Offset: 0x00003E05
		public unsafe static int ID_UnderlayDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001A228 File Offset: 0x00018428
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00005C13 File Offset: 0x00003E13
		public unsafe static int ID_UnderlaySoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001A244 File Offset: 0x00018444
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00005C21 File Offset: 0x00003E21
		public unsafe static int ID_UnderlayOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001A260 File Offset: 0x00018460
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00005C2F File Offset: 0x00003E2F
		public unsafe static int ID_UnderlayIsoPerimeter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001A27C File Offset: 0x0001847C
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00005C3D File Offset: 0x00003E3D
		public unsafe static int ID_WeightNormal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001A298 File Offset: 0x00018498
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005C4B File Offset: 0x00003E4B
		public unsafe static int ID_WeightBold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001A2B4 File Offset: 0x000184B4
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005C59 File Offset: 0x00003E59
		public unsafe static int ID_OutlineTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0001A2D0 File Offset: 0x000184D0
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00005C67 File Offset: 0x00003E67
		public unsafe static int ID_OutlineWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001A2EC File Offset: 0x000184EC
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005C75 File Offset: 0x00003E75
		public unsafe static int ID_OutlineSoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001A308 File Offset: 0x00018508
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005C83 File Offset: 0x00003E83
		public unsafe static int ID_OutlineColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001A324 File Offset: 0x00018524
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00005C91 File Offset: 0x00003E91
		public unsafe static int ID_Outline2Color
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001A340 File Offset: 0x00018540
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe static int ID_Outline2Width
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001A35C File Offset: 0x0001855C
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005CAD File Offset: 0x00003EAD
		public unsafe static int ID_Padding
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001A378 File Offset: 0x00018578
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005CBB File Offset: 0x00003EBB
		public unsafe static int ID_GradientScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001A394 File Offset: 0x00018594
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005CC9 File Offset: 0x00003EC9
		public unsafe static int ID_ScaleX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001A3B0 File Offset: 0x000185B0
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005CD7 File Offset: 0x00003ED7
		public unsafe static int ID_ScaleY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001A3CC File Offset: 0x000185CC
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005CE5 File Offset: 0x00003EE5
		public unsafe static int ID_PerspectiveFilter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001A3E8 File Offset: 0x000185E8
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00005CF3 File Offset: 0x00003EF3
		public unsafe static int ID_Sharpness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001A404 File Offset: 0x00018604
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00005D01 File Offset: 0x00003F01
		public unsafe static int ID_TextureWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001A420 File Offset: 0x00018620
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005D0F File Offset: 0x00003F0F
		public unsafe static int ID_TextureHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001A43C File Offset: 0x0001863C
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005D1D File Offset: 0x00003F1D
		public unsafe static int ID_BevelAmount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001A458 File Offset: 0x00018658
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00005D2B File Offset: 0x00003F2B
		public unsafe static int ID_GlowColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001A474 File Offset: 0x00018674
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00005D39 File Offset: 0x00003F39
		public unsafe static int ID_GlowOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001A490 File Offset: 0x00018690
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00005D47 File Offset: 0x00003F47
		public unsafe static int ID_GlowPower
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001A4AC File Offset: 0x000186AC
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00005D55 File Offset: 0x00003F55
		public unsafe static int ID_GlowOuter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001A4C8 File Offset: 0x000186C8
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00005D63 File Offset: 0x00003F63
		public unsafe static int ID_GlowInner
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001A4E4 File Offset: 0x000186E4
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00005D71 File Offset: 0x00003F71
		public unsafe static int ID_LightAngle
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001A500 File Offset: 0x00018700
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00005D7F File Offset: 0x00003F7F
		public unsafe static int ID_EnvMap
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001A51C File Offset: 0x0001871C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00005D8D File Offset: 0x00003F8D
		public unsafe static int ID_EnvMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001A538 File Offset: 0x00018738
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00005D9B File Offset: 0x00003F9B
		public unsafe static int ID_EnvMatrixRotation
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001A554 File Offset: 0x00018754
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00005DA9 File Offset: 0x00003FA9
		public unsafe static int ID_MaskCoord
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001A570 File Offset: 0x00018770
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public unsafe static int ID_ClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0001A58C File Offset: 0x0001878C
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00005DC5 File Offset: 0x00003FC5
		public unsafe static int ID_MaskSoftnessX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001A5A8 File Offset: 0x000187A8
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00005DD3 File Offset: 0x00003FD3
		public unsafe static int ID_MaskSoftnessY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001A5C4 File Offset: 0x000187C4
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00005DE1 File Offset: 0x00003FE1
		public unsafe static int ID_VertexOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001A5E0 File Offset: 0x000187E0
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005DEF File Offset: 0x00003FEF
		public unsafe static int ID_VertexOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001A5FC File Offset: 0x000187FC
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00005DFD File Offset: 0x00003FFD
		public unsafe static int ID_UseClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001A618 File Offset: 0x00018818
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00005E0B File Offset: 0x0000400B
		public unsafe static int ID_StencilID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001A634 File Offset: 0x00018834
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00005E19 File Offset: 0x00004019
		public unsafe static int ID_StencilOp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001A650 File Offset: 0x00018850
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00005E27 File Offset: 0x00004027
		public unsafe static int ID_StencilComp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001A66C File Offset: 0x0001886C
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005E35 File Offset: 0x00004035
		public unsafe static int ID_StencilReadMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001A688 File Offset: 0x00018888
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00005E43 File Offset: 0x00004043
		public unsafe static int ID_StencilWriteMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001A6A4 File Offset: 0x000188A4
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00005E51 File Offset: 0x00004051
		public unsafe static int ID_ShaderFlags
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001A6C0 File Offset: 0x000188C0
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00005E5F File Offset: 0x0000405F
		public unsafe static int ID_ScaleRatio_A
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0001A6DC File Offset: 0x000188DC
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005E6D File Offset: 0x0000406D
		public unsafe static int ID_ScaleRatio_B
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001A6F8 File Offset: 0x000188F8
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00005E7B File Offset: 0x0000407B
		public unsafe static int ID_ScaleRatio_C
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0001A714 File Offset: 0x00018914
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00005E89 File Offset: 0x00004089
		public unsafe static string Keyword_Bevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001A734 File Offset: 0x00018934
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00005E9B File Offset: 0x0000409B
		public unsafe static string Keyword_Glow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x0001A754 File Offset: 0x00018954
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00005EAD File Offset: 0x000040AD
		public unsafe static string Keyword_Underlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001A774 File Offset: 0x00018974
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00005EBF File Offset: 0x000040BF
		public unsafe static string Keyword_Ratios
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001A794 File Offset: 0x00018994
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00005ED1 File Offset: 0x000040D1
		public unsafe static string Keyword_MASK_SOFT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001A7B4 File Offset: 0x000189B4
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00005EE3 File Offset: 0x000040E3
		public unsafe static string Keyword_MASK_HARD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001A7D4 File Offset: 0x000189D4
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00005EF5 File Offset: 0x000040F5
		public unsafe static string Keyword_MASK_TEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x0001A7F4 File Offset: 0x000189F4
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00005F07 File Offset: 0x00004107
		public unsafe static string Keyword_Outline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001A814 File Offset: 0x00018A14
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00005F19 File Offset: 0x00004119
		public unsafe static string ShaderTag_ZTestMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0001A834 File Offset: 0x00018A34
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00005F2B File Offset: 0x0000412B
		public unsafe static string ShaderTag_CullMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0001A854 File Offset: 0x00018A54
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00005F3D File Offset: 0x0000413D
		public unsafe static float m_clamp
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0001A870 File Offset: 0x00018A70
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00005F4B File Offset: 0x0000414B
		public unsafe static bool isInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001A88C File Offset: 0x00018A8C
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00005F59 File Offset: 0x00004159
		public unsafe static Shader k_ShaderRef_MobileSDF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0001A8B4 File Offset: 0x00018AB4
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00005F6B File Offset: 0x0000416B
		public unsafe static Shader k_ShaderRef_MobileBitmap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00005F7D File Offset: 0x0000417D
		public static Shader ShaderRef_Sprite
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00005F8A File Offset: 0x0000418A
		public static void UpdateShaderRatios(Material mat)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001A8DC File Offset: 0x00018ADC
		public static Vector4 GetFontExtent(Material material)
		{
			return Vector4.zero;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00005F97 File Offset: 0x00004197
		public static bool IsMaskingEnabled(Material material)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00005FA4 File Offset: 0x000041A4
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		public static float ComputePaddingForProperties(Material mat)
		{
			Vector4 vector = mat.GetVector(TextShaderUtilities.ID_IsoPerimeter);
			Vector2 vector2 = mat.GetVector(TextShaderUtilities.ID_OutlineOffset1);
			Vector2 vector3 = mat.GetVector(TextShaderUtilities.ID_OutlineOffset2);
			Vector2 vector4 = mat.GetVector(TextShaderUtilities.ID_OutlineOffset3);
			bool flag = mat.GetFloat(TextShaderUtilities.ID_OutlineMode) != 0f;
			Vector4 vector5 = mat.GetVector(TextShaderUtilities.ID_Softness);
			float @float = mat.GetFloat(TextShaderUtilities.ID_GradientScale);
			float num = Mathf.Max(0f, vector.x + vector5.x * 0.5f);
			bool flag2 = !flag;
			if (flag2)
			{
				num = Mathf.Max(num, vector.y + vector5.y * 0.5f + Mathf.Max(Mathf.Abs(vector2.x), Mathf.Abs(vector2.y)));
				num = Mathf.Max(num, vector.z + vector5.z * 0.5f + Mathf.Max(Mathf.Abs(vector3.x), Mathf.Abs(vector3.y)));
				num = Mathf.Max(num, vector.w + vector5.w * 0.5f + Mathf.Max(Mathf.Abs(vector4.x), Mathf.Abs(vector4.y)));
			}
			else
			{
				float num2 = Mathf.Max(Mathf.Abs(vector2.x), Mathf.Abs(vector2.y));
				float num3 = Mathf.Max(Mathf.Abs(vector3.x), Mathf.Abs(vector3.y));
				num = Mathf.Max(num, vector.y + vector5.y * 0.5f + num2);
				num = Mathf.Max(num, vector.z + vector5.z * 0.5f + num3);
				float num4 = Mathf.Max(num2, num3);
				num += Mathf.Max(0f, vector.w + vector5.w * 0.5f - Mathf.Max(0f, num - num4));
			}
			Vector2 vector6 = mat.GetVector(TextShaderUtilities.ID_UnderlayOffset);
			float float2 = mat.GetFloat(TextShaderUtilities.ID_UnderlayDilate);
			float float3 = mat.GetFloat(TextShaderUtilities.ID_UnderlaySoftness);
			num = Mathf.Max(num, float2 + float3 * 0.5f + Mathf.Max(Mathf.Abs(vector6.x), Mathf.Abs(vector6.y)));
			return num * @float;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00005FB1 File Offset: 0x000041B1
		public static float GetPadding(Il2CppReferenceArray<Material> materials, bool enableExtraPadding, bool isBold)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_ID_MainTex;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceTex;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceColor;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceDilate;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_ID_Shininess;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineOffset1;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineOffset2;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineOffset3;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineMode;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_ID_IsoPerimeter;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_ID_Softness;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayColor;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetX;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetY;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayDilate;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlaySoftness;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffset;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayIsoPerimeter;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightNormal;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightBold;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineTex;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineWidth;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineSoftness;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineColor;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Color;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Width;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_ID_Padding;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_ID_GradientScale;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleX;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleY;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_ID_PerspectiveFilter;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_ID_Sharpness;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureWidth;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureHeight;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_ID_BevelAmount;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowColor;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOffset;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowPower;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOuter;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowInner;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_ID_LightAngle;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMap;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrix;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrixRotation;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskCoord;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_ID_ClipRect;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessX;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessY;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetX;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetY;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_ID_UseClipRect;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilID;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilOp;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilComp;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilReadMask;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilWriteMask;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_ID_ShaderFlags;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_A;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_B;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_C;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Bevel;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Glow;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Underlay;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Ratios;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_SOFT;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_HARD;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_TEX;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Outline;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_ZTestMode;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_CullMode;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_m_clamp;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileSDF;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileBitmap;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPropertyIDs_Internal_Static_Void_0;
	}
}

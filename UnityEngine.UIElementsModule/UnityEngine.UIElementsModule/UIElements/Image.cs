using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000062 RID: 98
	public class Image : VisualElement
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
		// Note: this type is marked as 'beforefieldinit'.
		static Image()
		{
			Il2CppClassPointerStore<Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Image");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image>.NativeClassPtr);
			Image.NativeFieldInfoPtr_m_ScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_ScaleMode");
			Image.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Image");
			Image.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Sprite");
			Image.NativeFieldInfoPtr_m_VectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_VectorImage");
			Image.NativeFieldInfoPtr_m_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_UV");
			Image.NativeFieldInfoPtr_m_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_TintColor");
			Image.NativeFieldInfoPtr_m_ImageIsInline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_ImageIsInline");
			Image.NativeFieldInfoPtr_m_ScaleModeIsInline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_ScaleModeIsInline");
			Image.NativeFieldInfoPtr_m_TintColorIsInline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_TintColorIsInline");
			Image.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "ussClassName");
			Image.NativeFieldInfoPtr_s_ImageProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_ImageProperty");
			Image.NativeFieldInfoPtr_s_SpriteProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_SpriteProperty");
			Image.NativeFieldInfoPtr_s_VectorImageProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_VectorImageProperty");
			Image.NativeFieldInfoPtr_s_ScaleModeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_ScaleModeProperty");
			Image.NativeFieldInfoPtr_s_TintColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_TintColorProperty");
			Image.NativeMethodInfoPtr_get_image_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664587);
			Image.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664588);
			Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664589);
			Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664590);
			Image.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664591);
			Image.NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664592);
			Image.NativeMethodInfoPtr_get_sourceRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664593);
			Image.NativeMethodInfoPtr_get_uv_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664594);
			Image.NativeMethodInfoPtr_set_uv_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664595);
			Image.NativeMethodInfoPtr_get_scaleMode_Public_get_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664596);
			Image.NativeMethodInfoPtr_get_tintColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664597);
			Image.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664598);
			Image.NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664599);
			Image.NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664600);
			Image.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664601);
			Image.NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664602);
			Image.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664603);
			Image.NativeMethodInfoPtr_ReadCustomProperties_Private_Void_ICustomStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664604);
			Image.NativeMethodInfoPtr_SetProperty_Private_Void_T0_byref_T0_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664605);
			Image.NativeMethodInfoPtr_ClearProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664606);
			Image.NativeMethodInfoPtr_SetScaleMode_Private_Void_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664607);
			Image.NativeMethodInfoPtr_SetTintColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664608);
			Image.NativeMethodInfoPtr_GetSourceRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664609);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0003CCEC File Offset: 0x0003AEEC
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x0003CD2C File Offset: 0x0003AF2C
		public unsafe Texture image
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_image_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295316, RefRangeEnd = 295318, XrefRangeStart = 295306, XrefRangeEnd = 295316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0003CD70 File Offset: 0x0003AF70
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295328, RefRangeEnd = 295330, XrefRangeStart = 295318, XrefRangeEnd = 295328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0003CE34 File Offset: 0x0003B034
		public unsafe VectorImage vectorImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295340, RefRangeEnd = 295341, XrefRangeStart = 295330, XrefRangeEnd = 295340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0003CE78 File Offset: 0x0003B078
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0003D688 File Offset: 0x0003B888
		public unsafe Rect sourceRect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295341, XrefRangeEnd = 295342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_sourceRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.GetSourceRect() == value;
				if (!flag)
				{
					bool flag2 = this.sprite != null;
					if (flag2)
					{
						Debug.LogError("Cannot set sourceRect on a sprite image");
					}
					else
					{
						this.CalculateUV(value);
					}
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0003CEB4 File Offset: 0x0003B0B4
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0003CEF0 File Offset: 0x0003B0F0
		public unsafe Rect uv
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_uv_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295342, RefRangeEnd = 295343, XrefRangeStart = 295342, XrefRangeEnd = 295342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_uv_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0003CF30 File Offset: 0x0003B130
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0003D6D0 File Offset: 0x0003B8D0
		public unsafe ScaleMode scaleMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_scaleMode_Public_get_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.m_ScaleMode == value && this.m_ScaleModeIsInline;
				if (!flag)
				{
					this.m_ScaleModeIsInline = true;
					this.SetScaleMode(value);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0003CF6C File Offset: 0x0003B16C
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0003D708 File Offset: 0x0003B908
		public unsafe Color tintColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_tintColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.m_TintColor == value && this.m_TintColorIsInline;
				if (!flag)
				{
					this.m_TintColorIsInline = true;
					this.SetTintColor(value);
				}
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295373, RefRangeEnd = 295375, XrefRangeStart = 295343, XrefRangeEnd = 295373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Image()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295381, RefRangeEnd = 295383, XrefRangeStart = 295375, XrefRangeEnd = 295381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureDisplaySize(Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0003D034 File Offset: 0x0003B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295383, XrefRangeEnd = 295395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureDisplaySize(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0003D084 File Offset: 0x0003B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295395, XrefRangeEnd = 295430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0003D104 File Offset: 0x0003B304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295430, XrefRangeEnd = 295473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0003D148 File Offset: 0x0003B348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295473, XrefRangeEnd = 295476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0003D18C File Offset: 0x0003B38C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295523, RefRangeEnd = 295526, XrefRangeStart = 295476, XrefRangeEnd = 295523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCustomProperties(ICustomStyle customStyleProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customStyleProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_ReadCustomProperties_Private_Void_ICustomStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295526, XrefRangeEnd = 295542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProperty<T0, T1, T2>(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1) where T0 : Object where T1 : Object where T2 : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = src;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref src;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(alt0);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(alt1);
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Image.MethodInfoStoreGeneric_SetProperty_Private_Void_T0_byref_T0_byref_T1_byref_T2_0<T0, T1, T2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr2;
			dst = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			alt0 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr8, false, false));
			IntPtr intPtr9 = intPtr4;
			alt1 = ((intPtr9 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr9, false, false));
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295572, RefRangeEnd = 295573, XrefRangeStart = 295542, XrefRangeEnd = 295572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_ClearProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003D300 File Offset: 0x0003B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295573, XrefRangeEnd = 295574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleMode(ScaleMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_SetScaleMode_Private_Void_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003D340 File Offset: 0x0003B540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295574, XrefRangeEnd = 295575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTintColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_SetTintColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0003D380 File Offset: 0x0003B580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295588, RefRangeEnd = 295590, XrefRangeStart = 295575, XrefRangeEnd = 295588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetSourceRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetSourceRect_Private_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00005292 File Offset: 0x00003492
		public Image(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x0000529B File Offset: 0x0000349B
		public unsafe ScaleMode m_ScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ScaleMode)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000052B6 File Offset: 0x000034B6
		public unsafe Texture m_Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0003D414 File Offset: 0x0003B614
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000052D5 File Offset: 0x000034D5
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0003D444 File Offset: 0x0003B644
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe VectorImage m_VectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_VectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_VectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0003D474 File Offset: 0x0003B674
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00005313 File Offset: 0x00003513
		public unsafe Rect m_UV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UV)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0003D49C File Offset: 0x0003B69C
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0000532E File Offset: 0x0000352E
		public unsafe Color m_TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_TintColor)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003D4C4 File Offset: 0x0003B6C4
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00005349 File Offset: 0x00003549
		public unsafe bool m_ImageIsInline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ImageIsInline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ImageIsInline)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0003D4EC File Offset: 0x0003B6EC
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00005364 File Offset: 0x00003564
		public unsafe bool m_ScaleModeIsInline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ScaleModeIsInline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_ScaleModeIsInline)) = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0003D514 File Offset: 0x0003B714
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0000537F File Offset: 0x0000357F
		public unsafe bool m_TintColorIsInline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_TintColorIsInline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_TintColorIsInline)) = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0003D53C File Offset: 0x0003B73C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0000539A File Offset: 0x0000359A
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0003D55C File Offset: 0x0003B75C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000053AC File Offset: 0x000035AC
		public unsafe static CustomStyleProperty<Texture2D> s_ImageProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<Texture2D>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_ImageProperty, intPtr);
				return new CustomStyleProperty<Texture2D>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<Texture2D>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_ImageProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0003D598 File Offset: 0x0003B798
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000053C3 File Offset: 0x000035C3
		public unsafe static CustomStyleProperty<Sprite> s_SpriteProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<Sprite>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_SpriteProperty, intPtr);
				return new CustomStyleProperty<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<Sprite>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_SpriteProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0003D5D4 File Offset: 0x0003B7D4
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000053DA File Offset: 0x000035DA
		public unsafe static CustomStyleProperty<VectorImage> s_VectorImageProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<VectorImage>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_VectorImageProperty, intPtr);
				return new CustomStyleProperty<VectorImage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<VectorImage>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_VectorImageProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0003D610 File Offset: 0x0003B810
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000053F1 File Offset: 0x000035F1
		public unsafe static CustomStyleProperty<string> s_ScaleModeProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<string>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_ScaleModeProperty, intPtr);
				return new CustomStyleProperty<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<string>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_ScaleModeProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0003D64C File Offset: 0x0003B84C
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00005408 File Offset: 0x00003608
		public unsafe static CustomStyleProperty<Color> s_TintColorProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_TintColorProperty, intPtr);
				return new CustomStyleProperty<Color>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_TintColorProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0000541F File Offset: 0x0000361F
		public void CalculateUV(Rect srcRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleMode;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_m_Image;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_m_VectorImage;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_m_UV;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_m_TintColor;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_m_ImageIsInline;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleModeIsInline;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_m_TintColorIsInline;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_s_ImageProperty;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_s_SpriteProperty;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_s_VectorImageProperty;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_s_ScaleModeProperty;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_s_TintColorProperty;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Texture_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceRect_Public_get_Rect_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Rect_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_set_uv_Public_set_Void_Rect_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleMode_Public_get_ScaleMode_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_get_tintColor_Public_get_Color_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Texture_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureDisplaySize_Private_Vector2_Sprite_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_ReadCustomProperties_Private_Void_ICustomStyle_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Private_Void_T0_byref_T0_byref_T1_byref_T2_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ClearProperty_Private_Void_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleMode_Private_Void_ScaleMode_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_SetTintColor_Private_Void_Color_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceRect_Private_Rect_0;

		// Token: 0x02000380 RID: 896
		public new class UxmlFactory : UxmlFactory<Image, Image.UxmlTraits>
		{
			// Token: 0x060037E0 RID: 14304 RVA: 0x000172BF File Offset: 0x000154BF
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Image.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Image>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image.UxmlFactory>.NativeClassPtr);
				Image.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image.UxmlFactory>.NativeClassPtr, 100664611);
			}

			// Token: 0x060037E1 RID: 14305 RVA: 0x000E49C4 File Offset: 0x000E2BC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295304, RefRangeEnd = 295305, XrefRangeStart = 295301, XrefRangeEnd = 295304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037E2 RID: 14306 RVA: 0x000172F3 File Offset: 0x000154F3
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027C0 RID: 10176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000381 RID: 897
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x060037E3 RID: 14307 RVA: 0x000172FC File Offset: 0x000154FC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Image.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Image>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image.UxmlTraits>.NativeClassPtr);
				Image.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image.UxmlTraits>.NativeClassPtr, 100664612);
			}

			// Token: 0x060037E4 RID: 14308 RVA: 0x000E4A00 File Offset: 0x000E2C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295305, XrefRangeEnd = 295306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037E5 RID: 14309 RVA: 0x00017330 File Offset: 0x00015530
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027C1 RID: 10177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000589 RID: 1417
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}

		// Token: 0x02000382 RID: 898
		private sealed class MethodInfoStoreGeneric_SetProperty_Private_Void_T0_byref_T0_byref_T1_byref_T2_0<T0, T1, T2>
		{
			// Token: 0x040027C2 RID: 10178
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Image.NativeMethodInfoPtr_SetProperty_Private_Void_T0_byref_T0_byref_T1_byref_T2_0, Il2CppClassPointerStore<Image>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200002F RID: 47
	public sealed class TextureDesc : ValueType
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x0001C44C File Offset: 0x0001A64C
		// Note: this type is marked as 'beforefieldinit'.
		static TextureDesc()
		{
			Il2CppClassPointerStore<TextureDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "TextureDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr);
			TextureDesc.NativeFieldInfoPtr_sizeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "sizeMode");
			TextureDesc.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "width");
			TextureDesc.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "height");
			TextureDesc.NativeFieldInfoPtr_slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "slices");
			TextureDesc.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "scale");
			TextureDesc.NativeFieldInfoPtr_func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "func");
			TextureDesc.NativeFieldInfoPtr_depthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "depthBufferBits");
			TextureDesc.NativeFieldInfoPtr_colorFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "colorFormat");
			TextureDesc.NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "filterMode");
			TextureDesc.NativeFieldInfoPtr_wrapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "wrapMode");
			TextureDesc.NativeFieldInfoPtr_dimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "dimension");
			TextureDesc.NativeFieldInfoPtr_enableRandomWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "enableRandomWrite");
			TextureDesc.NativeFieldInfoPtr_useMipMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "useMipMap");
			TextureDesc.NativeFieldInfoPtr_autoGenerateMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "autoGenerateMips");
			TextureDesc.NativeFieldInfoPtr_isShadowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "isShadowMap");
			TextureDesc.NativeFieldInfoPtr_anisoLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "anisoLevel");
			TextureDesc.NativeFieldInfoPtr_mipMapBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "mipMapBias");
			TextureDesc.NativeFieldInfoPtr_msaaSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "msaaSamples");
			TextureDesc.NativeFieldInfoPtr_bindTextureMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "bindTextureMS");
			TextureDesc.NativeFieldInfoPtr_useDynamicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "useDynamicScale");
			TextureDesc.NativeFieldInfoPtr_memoryless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "memoryless");
			TextureDesc.NativeFieldInfoPtr_vrUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "vrUsage");
			TextureDesc.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "name");
			TextureDesc.NativeFieldInfoPtr_fastMemoryDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "fastMemoryDesc");
			TextureDesc.NativeFieldInfoPtr_fallBackToBlackTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "fallBackToBlackTexture");
			TextureDesc.NativeFieldInfoPtr_disableFallBackToImportedTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "disableFallBackToImportedTexture");
			TextureDesc.NativeFieldInfoPtr_clearBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "clearBuffer");
			TextureDesc.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, "clearColor");
			TextureDesc.NativeMethodInfoPtr_InitDefaultValues_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663810);
			TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663811);
			TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663812);
			TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_ScaleFunc_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663813);
			TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663814);
			TextureDesc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr, 100663815);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001C724 File Offset: 0x0001A924
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958578, RefRangeEnd = 958581, XrefRangeStart = 958577, XrefRangeEnd = 958578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDefaultValues(bool dynamicResolution, bool xrReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dynamicResolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xrReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr_InitDefaultValues_Private_Void_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001C778 File Offset: 0x0001A978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 958582, RefRangeEnd = 958586, XrefRangeStart = 958581, XrefRangeEnd = 958582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamicResolution;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xrReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958586, XrefRangeEnd = 958587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamicResolution;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xrReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001C858 File Offset: 0x0001AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958587, XrefRangeEnd = 958589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamicResolution;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xrReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_ScaleFunc_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958589, XrefRangeEnd = 958590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc(TextureDesc input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr__ctor_Public_Void_TextureDesc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001C91C File Offset: 0x0001AB1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958599, RefRangeEnd = 958601, XrefRangeStart = 958590, XrefRangeEnd = 958599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureDesc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000038A4 File Offset: 0x00001AA4
		public TextureDesc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000038AD File Offset: 0x00001AAD
		public TextureDesc()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureDesc>.NativeClassPtr))
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0001C960 File Offset: 0x0001AB60
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000038BF File Offset: 0x00001ABF
		public unsafe TextureSizeMode sizeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_sizeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_sizeMode)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0001C988 File Offset: 0x0001AB88
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000038DA File Offset: 0x00001ADA
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000038F5 File Offset: 0x00001AF5
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003910 File Offset: 0x00001B10
		public unsafe int slices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_slices);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_slices)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001CA00 File Offset: 0x0001AC00
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0000392B File Offset: 0x00001B2B
		public unsafe Vector2 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001CA28 File Offset: 0x0001AC28
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003946 File Offset: 0x00001B46
		public unsafe ScaleFunc func
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_func);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_func), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001CA58 File Offset: 0x0001AC58
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003965 File Offset: 0x00001B65
		public unsafe DepthBits depthBufferBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_depthBufferBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_depthBufferBits)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001CA80 File Offset: 0x0001AC80
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003980 File Offset: 0x00001B80
		public unsafe GraphicsFormat colorFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_colorFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_colorFormat)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000399B File Offset: 0x00001B9B
		public unsafe FilterMode filterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_filterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_filterMode)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000039B6 File Offset: 0x00001BB6
		public unsafe TextureWrapMode wrapMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_wrapMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_wrapMode)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000039D1 File Offset: 0x00001BD1
		public unsafe TextureDimension dimension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_dimension);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_dimension)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001CB20 File Offset: 0x0001AD20
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000039EC File Offset: 0x00001BEC
		public unsafe bool enableRandomWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_enableRandomWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_enableRandomWrite)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001CB48 File Offset: 0x0001AD48
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003A07 File Offset: 0x00001C07
		public unsafe bool useMipMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_useMipMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_useMipMap)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001CB70 File Offset: 0x0001AD70
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003A22 File Offset: 0x00001C22
		public unsafe bool autoGenerateMips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_autoGenerateMips);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_autoGenerateMips)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001CB98 File Offset: 0x0001AD98
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003A3D File Offset: 0x00001C3D
		public unsafe bool isShadowMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_isShadowMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_isShadowMap)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003A58 File Offset: 0x00001C58
		public unsafe int anisoLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_anisoLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_anisoLevel)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003A73 File Offset: 0x00001C73
		public unsafe float mipMapBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_mipMapBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_mipMapBias)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0001CC10 File Offset: 0x0001AE10
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003A8E File Offset: 0x00001C8E
		public unsafe MSAASamples msaaSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_msaaSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_msaaSamples)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001CC38 File Offset: 0x0001AE38
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003AA9 File Offset: 0x00001CA9
		public unsafe bool bindTextureMS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_bindTextureMS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_bindTextureMS)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001CC60 File Offset: 0x0001AE60
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public unsafe bool useDynamicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_useDynamicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_useDynamicScale)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001CC88 File Offset: 0x0001AE88
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003ADF File Offset: 0x00001CDF
		public unsafe RenderTextureMemoryless memoryless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_memoryless);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_memoryless)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003AFA File Offset: 0x00001CFA
		public unsafe VRTextureUsage vrUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_vrUsage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_vrUsage)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003B15 File Offset: 0x00001D15
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001CD00 File Offset: 0x0001AF00
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003B34 File Offset: 0x00001D34
		public unsafe FastMemoryDesc fastMemoryDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_fastMemoryDesc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_fastMemoryDesc)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001CD28 File Offset: 0x0001AF28
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003B4F File Offset: 0x00001D4F
		public unsafe bool fallBackToBlackTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_fallBackToBlackTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_fallBackToBlackTexture)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001CD50 File Offset: 0x0001AF50
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003B6A File Offset: 0x00001D6A
		public unsafe bool disableFallBackToImportedTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_disableFallBackToImportedTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_disableFallBackToImportedTexture)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001CD78 File Offset: 0x0001AF78
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003B85 File Offset: 0x00001D85
		public unsafe bool clearBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_clearBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_clearBuffer)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public unsafe Color clearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_clearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureDesc.NativeFieldInfoPtr_clearColor)) = value;
			}
		}

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_sizeMode;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_slices;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_func;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_depthBufferBits;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_colorFormat;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_filterMode;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_wrapMode;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_dimension;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_enableRandomWrite;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_useMipMap;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_autoGenerateMips;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_isShadowMap;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_anisoLevel;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_mipMapBias;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_msaaSamples;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_bindTextureMS;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_useDynamicScale;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_memoryless;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_vrUsage;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_fastMemoryDesc;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_fallBackToBlackTexture;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_disableFallBackToImportedTexture;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_clearBuffer;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_clearColor;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_InitDefaultValues_Private_Void_Boolean_Boolean_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_Boolean_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScaleFunc_Boolean_Boolean_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureDesc_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

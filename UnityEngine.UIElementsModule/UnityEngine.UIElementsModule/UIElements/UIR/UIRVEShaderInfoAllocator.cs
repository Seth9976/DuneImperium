using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000278 RID: 632
	public sealed class UIRVEShaderInfoAllocator : ValueType
	{
		// Token: 0x06002EA6 RID: 11942 RVA: 0x000C646C File Offset: 0x000C466C
		// Note: this type is marked as 'beforefieldinit'.
		static UIRVEShaderInfoAllocator()
		{
			Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "UIRVEShaderInfoAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr);
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_Storage");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TransformAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_TransformAllocator");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRectAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_ClipRectAllocator");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_OpacityAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_OpacityAllocator");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ColorAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_ColorAllocator");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TextSettingsAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_TextSettingsAllocator");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_StorageReallyCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_StorageReallyCreated");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_VertexTexturingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_VertexTexturingEnabled");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Transforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_Transforms");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "m_ClipRects");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformTexel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransformTexel");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectTexel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "infiniteClipRectTexel");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityTexel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "fullOpacityTexel");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorTexel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "clearColorTexel");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsTexel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "defaultTextCoreSettingsTexel");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransformValue");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow0Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransformRow0Value");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow1Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransformRow1Value");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransformRow2Value");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "infiniteClipRectValue");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "fullOpacityValue");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "clearColorValue");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "defaultTextCoreSettingsValue");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "identityTransform");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "infiniteClipRect");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "fullOpacity");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "clearColor");
			UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, "defaultTextCoreSettings");
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_pageWidth_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670065);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_pageHeight_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670066);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocToTexelCoord_Private_Static_Vector2Int_byref_BitmapAllocator32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670067);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocToConstantBufferIndex_Private_Static_Int32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670068);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AtlasRectMatchesPage_Private_Static_Boolean_byref_BitmapAllocator32_BMPAlloc_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670069);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_transformConstants_Public_get_NativeSlice_1_Transform3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670070);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_clipRectConstants_Public_get_NativeSlice_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670071);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_atlas_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670072);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_Construct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670073);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ReallyCreateStorage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670074);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670075);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_IssuePendingStorageChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670076);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocTransform_Public_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670077);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocClipRect_Public_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670078);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocOpacity_Public_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670079);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocColor_Public_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670080);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocTextCoreSettings_Public_BMPAlloc_TextCoreSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670081);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetTransformValue_Public_Void_BMPAlloc_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670082);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetClipRectValue_Public_Void_BMPAlloc_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670083);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetOpacityValue_Public_Void_BMPAlloc_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670084);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetColorValue_Public_Void_BMPAlloc_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670085);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetTextCoreSettingValue_Public_Void_BMPAlloc_TextCoreSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670086);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeTransform_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670087);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeClipRect_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670088);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeOpacity_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670089);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeColor_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670090);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeTextCoreSettings_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670091);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_TransformAllocToVertexData_Public_Color32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670092);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ClipRectAllocToVertexData_Public_Color32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670093);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_OpacityAllocToVertexData_Public_Color32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670094);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ColorAllocToVertexData_Public_Color32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670095);
			UIRVEShaderInfoAllocator.NativeMethodInfoPtr_TextCoreSettingsToVertexData_Public_Color32_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr, 100670096);
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000C694C File Offset: 0x000C4B4C
		public unsafe static int pageWidth
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_pageWidth_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000C697C File Offset: 0x000C4B7C
		public unsafe static int pageHeight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_pageHeight_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000C69AC File Offset: 0x000C4BAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 352397, RefRangeEnd = 352401, XrefRangeStart = 352394, XrefRangeEnd = 352397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(allocator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alloc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocToTexelCoord_Private_Static_Vector2Int_byref_BitmapAllocator32_BMPAlloc_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000C69FC File Offset: 0x000C4BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352401, XrefRangeEnd = 352404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AllocToConstantBufferIndex(BMPAlloc alloc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocToConstantBufferIndex_Private_Static_Int32_BMPAlloc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000C6A3C File Offset: 0x000C4C3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352421, RefRangeEnd = 352426, XrefRangeStart = 352404, XrefRangeEnd = 352421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(allocator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defAlloc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AtlasRectMatchesPage_Private_Static_Boolean_byref_BitmapAllocator32_BMPAlloc_RectInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000C6A9C File Offset: 0x000C4C9C
		public unsafe NativeSlice<Transform3x4> transformConstants
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352429, RefRangeEnd = 352431, XrefRangeStart = 352426, XrefRangeEnd = 352429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_transformConstants_Public_get_NativeSlice_1_Transform3x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeSlice<Transform3x4>(intPtr);
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000C6AD8 File Offset: 0x000C4CD8
		public unsafe NativeSlice<Vector4> clipRectConstants
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352434, RefRangeEnd = 352436, XrefRangeStart = 352431, XrefRangeEnd = 352434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_clipRectConstants_Public_get_NativeSlice_1_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeSlice<Vector4>(intPtr);
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000C6B14 File Offset: 0x000C4D14
		public unsafe Texture atlas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352442, RefRangeEnd = 352444, XrefRangeStart = 352436, XrefRangeEnd = 352442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_get_atlas_Public_get_Texture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000C6B58 File Offset: 0x000C4D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352481, RefRangeEnd = 352482, XrefRangeStart = 352444, XrefRangeEnd = 352481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Construct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_Construct_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000C6B90 File Offset: 0x000C4D90
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 352537, RefRangeEnd = 352550, XrefRangeStart = 352482, XrefRangeEnd = 352537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReallyCreateStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ReallyCreateStorage_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000C6BC8 File Offset: 0x000C4DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352563, RefRangeEnd = 352564, XrefRangeStart = 352550, XrefRangeEnd = 352563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000C6C00 File Offset: 0x000C4E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352564, RefRangeEnd = 352565, XrefRangeStart = 352564, XrefRangeEnd = 352564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IssuePendingStorageChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_IssuePendingStorageChanges_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000C6C38 File Offset: 0x000C4E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352580, RefRangeEnd = 352581, XrefRangeStart = 352565, XrefRangeEnd = 352580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc AllocTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocTransform_Public_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000C6C7C File Offset: 0x000C4E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352596, RefRangeEnd = 352597, XrefRangeStart = 352581, XrefRangeEnd = 352596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc AllocClipRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocClipRect_Public_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000C6CC0 File Offset: 0x000C4EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352602, RefRangeEnd = 352603, XrefRangeStart = 352597, XrefRangeEnd = 352602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc AllocOpacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocOpacity_Public_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000C6D04 File Offset: 0x000C4F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352603, XrefRangeEnd = 352608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc AllocColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocColor_Public_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000C6D48 File Offset: 0x000C4F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352608, XrefRangeEnd = 352613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc AllocTextCoreSettings(TextCoreSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_AllocTextCoreSettings_Public_BMPAlloc_TextCoreSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x000C6D98 File Offset: 0x000C4F98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 352635, RefRangeEnd = 352638, XrefRangeStart = 352613, XrefRangeEnd = 352635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetTransformValue_Public_Void_BMPAlloc_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000C6DEC File Offset: 0x000C4FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352651, RefRangeEnd = 352653, XrefRangeStart = 352638, XrefRangeEnd = 352651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetClipRectValue_Public_Void_BMPAlloc_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000C6E40 File Offset: 0x000C5040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352664, RefRangeEnd = 352666, XrefRangeStart = 352653, XrefRangeEnd = 352664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpacityValue(BMPAlloc alloc, float opacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetOpacityValue_Public_Void_BMPAlloc_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x000C6E94 File Offset: 0x000C5094
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 352678, RefRangeEnd = 352686, XrefRangeStart = 352666, XrefRangeEnd = 352678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEditorContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetColorValue_Public_Void_BMPAlloc_Color_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000C6EF4 File Offset: 0x000C50F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352708, RefRangeEnd = 352710, XrefRangeStart = 352686, XrefRangeEnd = 352708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEditorContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_SetTextCoreSettingValue_Public_Void_BMPAlloc_TextCoreSettings_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x000C6F54 File Offset: 0x000C5154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352710, XrefRangeEnd = 352718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeTransform(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeTransform_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000C6F98 File Offset: 0x000C5198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352726, RefRangeEnd = 352727, XrefRangeStart = 352718, XrefRangeEnd = 352726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeClipRect(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeClipRect_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000C6FDC File Offset: 0x000C51DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352727, XrefRangeEnd = 352735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeOpacity(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeOpacity_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000C7020 File Offset: 0x000C5220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352735, XrefRangeEnd = 352743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeColor(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeColor_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000C7064 File Offset: 0x000C5264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352743, XrefRangeEnd = 352751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeTextCoreSettings(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_FreeTextCoreSettings_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000C70A8 File Offset: 0x000C52A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352765, RefRangeEnd = 352766, XrefRangeStart = 352751, XrefRangeEnd = 352765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 TransformAllocToVertexData(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_TransformAllocToVertexData_Public_Color32_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000C70F8 File Offset: 0x000C52F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352780, RefRangeEnd = 352781, XrefRangeStart = 352766, XrefRangeEnd = 352780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 ClipRectAllocToVertexData(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ClipRectAllocToVertexData_Public_Color32_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000C7148 File Offset: 0x000C5348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352795, RefRangeEnd = 352797, XrefRangeStart = 352781, XrefRangeEnd = 352795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 OpacityAllocToVertexData(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_OpacityAllocToVertexData_Public_Color32_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000C7198 File Offset: 0x000C5398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352811, RefRangeEnd = 352812, XrefRangeStart = 352797, XrefRangeEnd = 352811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 ColorAllocToVertexData(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_ColorAllocToVertexData_Public_Color32_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000C71E8 File Offset: 0x000C53E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352826, RefRangeEnd = 352827, XrefRangeStart = 352812, XrefRangeEnd = 352826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 TextCoreSettingsToVertexData(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRVEShaderInfoAllocator.NativeMethodInfoPtr_TextCoreSettingsToVertexData_Public_Color32_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0001344D File Offset: 0x0001164D
		public UIRVEShaderInfoAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00013456 File Offset: 0x00011656
		public UIRVEShaderInfoAllocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRVEShaderInfoAllocator>.NativeClassPtr))
		{
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x000C7238 File Offset: 0x000C5438
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00013468 File Offset: 0x00011668
		public unsafe BaseShaderInfoStorage m_Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseShaderInfoStorage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x000C7268 File Offset: 0x000C5468
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x00013487 File Offset: 0x00011687
		public BitmapAllocator32 m_TransformAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TransformAllocator);
				return new BitmapAllocator32(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TransformAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x000C7298 File Offset: 0x000C5498
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x000134B5 File Offset: 0x000116B5
		public BitmapAllocator32 m_ClipRectAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRectAllocator);
				return new BitmapAllocator32(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRectAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x000C72C8 File Offset: 0x000C54C8
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x000134E3 File Offset: 0x000116E3
		public BitmapAllocator32 m_OpacityAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_OpacityAllocator);
				return new BitmapAllocator32(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_OpacityAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x000C72F8 File Offset: 0x000C54F8
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00013511 File Offset: 0x00011711
		public BitmapAllocator32 m_ColorAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ColorAllocator);
				return new BitmapAllocator32(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ColorAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x000C7328 File Offset: 0x000C5528
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x0001353F File Offset: 0x0001173F
		public BitmapAllocator32 m_TextSettingsAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TextSettingsAllocator);
				return new BitmapAllocator32(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_TextSettingsAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x000C7358 File Offset: 0x000C5558
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x0001356D File Offset: 0x0001176D
		public unsafe bool m_StorageReallyCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_StorageReallyCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_StorageReallyCreated)) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x000C7380 File Offset: 0x000C5580
		// (set) Token: 0x06002ED8 RID: 11992 RVA: 0x00013588 File Offset: 0x00011788
		public unsafe bool m_VertexTexturingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_VertexTexturingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_VertexTexturingEnabled)) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x000C73A8 File Offset: 0x000C55A8
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x000135A3 File Offset: 0x000117A3
		public NativeArray<Transform3x4> m_Transforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Transforms);
				return new NativeArray<Transform3x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Transform3x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_Transforms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Transform3x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000C73D8 File Offset: 0x000C55D8
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x000135D1 File Offset: 0x000117D1
		public NativeArray<Vector4> m_ClipRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRects);
				return new NativeArray<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_m_ClipRects), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000C7408 File Offset: 0x000C5608
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x000135FF File Offset: 0x000117FF
		public unsafe static Vector2Int identityTransformTexel
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformTexel, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformTexel, (void*)(&value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000C7424 File Offset: 0x000C5624
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x0001360D File Offset: 0x0001180D
		public unsafe static Vector2Int infiniteClipRectTexel
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectTexel, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectTexel, (void*)(&value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x000C7440 File Offset: 0x000C5640
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x0001361B File Offset: 0x0001181B
		public unsafe static Vector2Int fullOpacityTexel
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityTexel, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityTexel, (void*)(&value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000C745C File Offset: 0x000C565C
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00013629 File Offset: 0x00011829
		public unsafe static Vector2Int clearColorTexel
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorTexel, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorTexel, (void*)(&value));
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000C7478 File Offset: 0x000C5678
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00013637 File Offset: 0x00011837
		public unsafe static Vector2Int defaultTextCoreSettingsTexel
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsTexel, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsTexel, (void*)(&value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x000C7494 File Offset: 0x000C5694
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00013645 File Offset: 0x00011845
		public unsafe static Matrix4x4 identityTransformValue
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformValue, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformValue, (void*)(&value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000C74B0 File Offset: 0x000C56B0
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00013653 File Offset: 0x00011853
		public unsafe static Vector4 identityTransformRow0Value
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow0Value, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow0Value, (void*)(&value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x000C74CC File Offset: 0x000C56CC
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00013661 File Offset: 0x00011861
		public unsafe static Vector4 identityTransformRow1Value
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow1Value, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow1Value, (void*)(&value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x000C74E8 File Offset: 0x000C56E8
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x0001366F File Offset: 0x0001186F
		public unsafe static Vector4 identityTransformRow2Value
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow2Value, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransformRow2Value, (void*)(&value));
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000C7504 File Offset: 0x000C5704
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x0001367D File Offset: 0x0001187D
		public unsafe static Vector4 infiniteClipRectValue
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectValue, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRectValue, (void*)(&value));
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x000C7520 File Offset: 0x000C5720
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x0001368B File Offset: 0x0001188B
		public unsafe static Vector4 fullOpacityValue
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityValue, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacityValue, (void*)(&value));
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000C753C File Offset: 0x000C573C
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x00013699 File Offset: 0x00011899
		public unsafe static Vector4 clearColorValue
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorValue, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColorValue, (void*)(&value));
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x000C7558 File Offset: 0x000C5758
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x000136A7 File Offset: 0x000118A7
		public unsafe static TextCoreSettings defaultTextCoreSettingsValue
		{
			get
			{
				TextCoreSettings textCoreSettings;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsValue, (void*)(&textCoreSettings));
				return textCoreSettings;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettingsValue, (void*)(&value));
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x000C7574 File Offset: 0x000C5774
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x000136B5 File Offset: 0x000118B5
		public unsafe static BMPAlloc identityTransform
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransform, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_identityTransform, (void*)(&value));
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x000C7590 File Offset: 0x000C5790
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x000136C3 File Offset: 0x000118C3
		public unsafe static BMPAlloc infiniteClipRect
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRect, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_infiniteClipRect, (void*)(&value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x000C75AC File Offset: 0x000C57AC
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x000136D1 File Offset: 0x000118D1
		public unsafe static BMPAlloc fullOpacity
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacity, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_fullOpacity, (void*)(&value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x000C75C8 File Offset: 0x000C57C8
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x000136DF File Offset: 0x000118DF
		public unsafe static BMPAlloc clearColor
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColor, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_clearColor, (void*)(&value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000C75E4 File Offset: 0x000C57E4
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x000136ED File Offset: 0x000118ED
		public unsafe static BMPAlloc defaultTextCoreSettings
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettings, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRVEShaderInfoAllocator.NativeFieldInfoPtr_defaultTextCoreSettings, (void*)(&value));
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x000C7600 File Offset: 0x000C5800
		public bool internalAtlasCreated
		{
			get
			{
				return this.m_StorageReallyCreated;
			}
		}

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeFieldInfoPtr_m_Storage;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformAllocator;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipRectAllocator;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeFieldInfoPtr_m_OpacityAllocator;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorAllocator;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeFieldInfoPtr_m_TextSettingsAllocator;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeFieldInfoPtr_m_StorageReallyCreated;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexTexturingEnabled;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeFieldInfoPtr_m_Transforms;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipRects;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeFieldInfoPtr_identityTransformTexel;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeFieldInfoPtr_infiniteClipRectTexel;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeFieldInfoPtr_fullOpacityTexel;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeFieldInfoPtr_clearColorTexel;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeFieldInfoPtr_defaultTextCoreSettingsTexel;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeFieldInfoPtr_identityTransformValue;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeFieldInfoPtr_identityTransformRow0Value;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeFieldInfoPtr_identityTransformRow1Value;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeFieldInfoPtr_identityTransformRow2Value;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeFieldInfoPtr_infiniteClipRectValue;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeFieldInfoPtr_fullOpacityValue;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeFieldInfoPtr_clearColorValue;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeFieldInfoPtr_defaultTextCoreSettingsValue;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeFieldInfoPtr_identityTransform;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeFieldInfoPtr_infiniteClipRect;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeFieldInfoPtr_fullOpacity;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeFieldInfoPtr_clearColor;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeFieldInfoPtr_defaultTextCoreSettings;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeMethodInfoPtr_get_pageWidth_Private_Static_get_Int32_0;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeMethodInfoPtr_get_pageHeight_Private_Static_get_Int32_0;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeMethodInfoPtr_AllocToTexelCoord_Private_Static_Vector2Int_byref_BitmapAllocator32_BMPAlloc_0;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeMethodInfoPtr_AllocToConstantBufferIndex_Private_Static_Int32_BMPAlloc_0;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_AtlasRectMatchesPage_Private_Static_Boolean_byref_BitmapAllocator32_BMPAlloc_RectInt_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_get_transformConstants_Public_get_NativeSlice_1_Transform3x4_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_get_clipRectConstants_Public_get_NativeSlice_1_Vector4_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_get_Texture_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Public_Void_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_ReallyCreateStorage_Private_Void_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_IssuePendingStorageChanges_Public_Void_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_AllocTransform_Public_BMPAlloc_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_AllocClipRect_Public_BMPAlloc_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_AllocOpacity_Public_BMPAlloc_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_AllocColor_Public_BMPAlloc_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_AllocTextCoreSettings_Public_BMPAlloc_TextCoreSettings_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformValue_Public_Void_BMPAlloc_Matrix4x4_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_SetClipRectValue_Public_Void_BMPAlloc_Vector4_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_SetOpacityValue_Public_Void_BMPAlloc_Single_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_SetColorValue_Public_Void_BMPAlloc_Color_Boolean_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_SetTextCoreSettingValue_Public_Void_BMPAlloc_TextCoreSettings_Boolean_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_FreeTransform_Public_Void_BMPAlloc_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_FreeClipRect_Public_Void_BMPAlloc_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_FreeOpacity_Public_Void_BMPAlloc_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_FreeColor_Public_Void_BMPAlloc_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_FreeTextCoreSettings_Public_Void_BMPAlloc_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_TransformAllocToVertexData_Public_Color32_BMPAlloc_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_ClipRectAllocToVertexData_Public_Color32_BMPAlloc_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_OpacityAllocToVertexData_Public_Color32_BMPAlloc_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_ColorAllocToVertexData_Public_Color32_BMPAlloc_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_TextCoreSettingsToVertexData_Public_Color32_BMPAlloc_0;
	}
}

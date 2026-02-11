using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E6 RID: 230
	public sealed class CubemapArray : Texture
	{
		// Token: 0x060011BE RID: 4542 RVA: 0x00059F1C File Offset: 0x0005811C
		// Note: this type is marked as 'beforefieldinit'.
		static CubemapArray()
		{
			Il2CppClassPointerStore<CubemapArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CubemapArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr);
			CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665794);
			CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665795);
			CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665796);
			CubemapArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665797);
			CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665798);
			CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665799);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665800);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665801);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665802);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665803);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665804);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665805);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665806);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665807);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665808);
			CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665809);
			CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665810);
			CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665811);
			CubemapArray.get_cubemapCountDelegateField = IL2CPP.ResolveICall<CubemapArray.get_cubemapCountDelegate>("UnityEngine.CubemapArray::get_cubemapCount");
			CubemapArray.get_formatDelegateField = IL2CPP.ResolveICall<CubemapArray.get_formatDelegate>("UnityEngine.CubemapArray::get_format");
			CubemapArray.GetPixelsDelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixelsDelegate>("UnityEngine.CubemapArray::GetPixels");
			CubemapArray.GetPixels32DelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixels32Delegate>("UnityEngine.CubemapArray::GetPixels32");
			CubemapArray.SetPixels32DelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixels32Delegate>("UnityEngine.CubemapArray::SetPixels32");
			CubemapArray.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImplArrayDelegate>("UnityEngine.CubemapArray::SetPixelDataImplArray");
			CubemapArray.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImplDelegate>("UnityEngine.CubemapArray::SetPixelDataImpl");
			CubemapArray.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<CubemapArray.GetImageDataPointerDelegate>("UnityEngine.CubemapArray::GetImageDataPointer");
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0005A12C File Offset: 0x0005832C
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656858, XrefRangeEnd = 656860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0005A168 File Offset: 0x00058368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656860, XrefRangeEnd = 656862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0005A200 File Offset: 0x00058400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656864, RefRangeEnd = 656866, XrefRangeStart = 656862, XrefRangeEnd = 656864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0005A28C File Offset: 0x0005848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656866, XrefRangeEnd = 656868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0005A2D8 File Offset: 0x000584D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656868, XrefRangeEnd = 656870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayElement;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0005A344 File Offset: 0x00058544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656872, RefRangeEnd = 656873, XrefRangeStart = 656870, XrefRangeEnd = 656872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0005A3A4 File Offset: 0x000585A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656873, XrefRangeEnd = 656879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0005A418 File Offset: 0x00058618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656879, XrefRangeEnd = 656881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0005A498 File Offset: 0x00058698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656886, RefRangeEnd = 656887, XrefRangeStart = 656881, XrefRangeEnd = 656886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0005A50C File Offset: 0x0005870C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 656902, RefRangeEnd = 656905, XrefRangeStart = 656887, XrefRangeEnd = 656902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0005A58C File Offset: 0x0005878C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 656923, RefRangeEnd = 656927, XrefRangeStart = 656905, XrefRangeEnd = 656923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0005A61C File Offset: 0x0005881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656927, XrefRangeEnd = 656928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0005A69C File Offset: 0x0005889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656928, XrefRangeEnd = 656934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005A72C File Offset: 0x0005892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656934, XrefRangeEnd = 656940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005A7AC File Offset: 0x000589AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656940, XrefRangeEnd = 656946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005A820 File Offset: 0x00058A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656946, XrefRangeEnd = 656951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005A86C File Offset: 0x00058A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656956, RefRangeEnd = 656957, XrefRangeStart = 656951, XrefRangeEnd = 656956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000078B5 File Offset: 0x00005AB5
		public CubemapArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000078BE File Offset: 0x00005ABE
		public int cubemapCount
		{
			get
			{
				return CubemapArray.get_cubemapCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000078D0 File Offset: 0x00005AD0
		public TextureFormat format
		{
			get
			{
				return CubemapArray.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement, int miplevel)
		{
			IntPtr intPtr = CubemapArray.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0005A904 File Offset: 0x00058B04
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement)
		{
			return this.GetPixels(face, arrayElement, 0);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0005A920 File Offset: 0x00058B20
		public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement, int miplevel)
		{
			IntPtr intPtr = CubemapArray.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0005A950 File Offset: 0x00058B50
		public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement)
		{
			return this.GetPixels32(face, arrayElement, 0);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000078E2 File Offset: 0x00005AE2
		public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement, int miplevel)
		{
			CubemapArray.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, arrayElement, miplevel);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000078FE File Offset: 0x00005AFE
		public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement)
		{
			this.SetPixels32(colors, face, arrayElement, 0);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005A96C File Offset: 0x00058B6C
		public bool SetPixelDataImplArray(Array data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return CubemapArray.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005A99C File Offset: 0x00058B9C
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return CubemapArray.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0000790C File Offset: 0x00005B0C
		public IntPtr GetImageDataPointer()
		{
			return CubemapArray.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0000791E File Offset: 0x00005B1E
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0005A9C4 File Offset: 0x00058BC4
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, int element, [Optional] int sourceDataStartIndex)
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = data == null || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImplArray(data, mipLevel, (int)face, element, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005AA3C File Offset: 0x00058C3C
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, int element, [Optional] int sourceDataStartIndex) where T : struct
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = !data.IsCreated || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int)face, element, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0005AABC File Offset: 0x00058CBC
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = mipLevel < 0 || mipLevel >= base.mipmapCount;
			if (flag2)
			{
				throw new ArgumentException(String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (base.mipmapCount - 1).ToString()));
			}
			bool flag3 = face < CubemapFace.PositiveX || face >= (CubemapFace)6;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("The passed in face ", face.ToString(), " is invalid.  The valid range is 0 through 5"));
			}
			bool flag4 = element < 0 || element >= this.cubemapCount;
			if (flag4)
			{
				throw new ArgumentException(String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (this.cubemapCount - 1).ToString()));
			}
			int num = (int)(element * 6 + face);
			ulong pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, num);
			ulong pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, num);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, num);
			int num2 = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num3 = pixelDataSize / (ulong)((long)num2);
			bool flag5 = num3 > 2147483647UL;
			if (flag5)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr intPtr;
			intPtr..ctor((long)this.GetImageDataPointer() + (long)(pixelDataOffset * (ulong)((long)num) + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num3, Unity.Collections.Allocator.None);
		}

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly CubemapArray.get_cubemapCountDelegate get_cubemapCountDelegateField;

		// Token: 0x04000FC9 RID: 4041
		private static readonly CubemapArray.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000FCA RID: 4042
		private static readonly CubemapArray.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x04000FCB RID: 4043
		private static readonly CubemapArray.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x04000FCC RID: 4044
		private static readonly CubemapArray.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x04000FCD RID: 4045
		private static readonly CubemapArray.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000FCE RID: 4046
		private static readonly CubemapArray.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x04000FCF RID: 4047
		private static readonly CubemapArray.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x0200069D RID: 1693
		// (Invoke) Token: 0x06003618 RID: 13848
		private delegate int get_cubemapCountDelegate(IntPtr @this);

		// Token: 0x0200069E RID: 1694
		// (Invoke) Token: 0x0600361A RID: 13850
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x0200069F RID: 1695
		// (Invoke) Token: 0x0600361C RID: 13852
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006A0 RID: 1696
		// (Invoke) Token: 0x0600361E RID: 13854
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006A1 RID: 1697
		// (Invoke) Token: 0x06003620 RID: 13856
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006A2 RID: 1698
		// (Invoke) Token: 0x06003622 RID: 13858
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006A3 RID: 1699
		// (Invoke) Token: 0x06003624 RID: 13860
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006A4 RID: 1700
		// (Invoke) Token: 0x06003626 RID: 13862
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);
	}
}

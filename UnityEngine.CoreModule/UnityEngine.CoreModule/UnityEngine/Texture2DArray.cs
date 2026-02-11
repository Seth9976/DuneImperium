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
	// Token: 0x020000E5 RID: 229
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x06001198 RID: 4504 RVA: 0x00059290 File Offset: 0x00057490
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DArray()
		{
			Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2DArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr);
			Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665778);
			Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665779);
			Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665780);
			Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665781);
			Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665782);
			Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665783);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665784);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665785);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665786);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665787);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665788);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665789);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665790);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665791);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665792);
			Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665793);
			Texture2DArray.get_depthDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_depthDelegate>("UnityEngine.Texture2DArray::get_depth");
			Texture2DArray.get_formatDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_formatDelegate>("UnityEngine.Texture2DArray::get_format");
			Texture2DArray.ApplyImplDelegateField = IL2CPP.ResolveICall<Texture2DArray.ApplyImplDelegate>("UnityEngine.Texture2DArray::ApplyImpl");
			Texture2DArray.GetPixelsDelegateField = IL2CPP.ResolveICall<Texture2DArray.GetPixelsDelegate>("UnityEngine.Texture2DArray::GetPixels");
			Texture2DArray.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2DArray::SetPixelDataImplArray");
			Texture2DArray.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplDelegate>("UnityEngine.Texture2DArray::SetPixelDataImpl");
			Texture2DArray.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.GetPixels32Delegate>("UnityEngine.Texture2DArray::GetPixels32");
			Texture2DArray.SetPixelsDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelsDelegate>("UnityEngine.Texture2DArray::SetPixels");
			Texture2DArray.SetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixels32Delegate>("UnityEngine.Texture2DArray::SetPixels32");
			Texture2DArray.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<Texture2DArray.GetImageDataPointerDelegate>("UnityEngine.Texture2DArray::GetImageDataPointer");
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00059498 File Offset: 0x00057698
		public unsafe static int allSlices
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 656739, RefRangeEnd = 656741, XrefRangeStart = 656737, XrefRangeEnd = 656739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000594C8 File Offset: 0x000576C8
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656741, XrefRangeEnd = 656743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00059504 File Offset: 0x00057704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656743, XrefRangeEnd = 656745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000595A8 File Offset: 0x000577A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 656747, RefRangeEnd = 656751, XrefRangeStart = 656745, XrefRangeEnd = 656747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00059640 File Offset: 0x00057840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656751, XrefRangeEnd = 656754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000596A8 File Offset: 0x000578A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 656761, RefRangeEnd = 656764, XrefRangeStart = 656754, XrefRangeEnd = 656761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00059710 File Offset: 0x00057910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656764, XrefRangeEnd = 656766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00059790 File Offset: 0x00057990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656766, XrefRangeEnd = 656778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00059820 File Offset: 0x00057A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656797, RefRangeEnd = 656799, XrefRangeStart = 656778, XrefRangeEnd = 656797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000598A0 File Offset: 0x00057AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656799, XrefRangeEnd = 656814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00059930 File Offset: 0x00057B30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 656834, RefRangeEnd = 656838, XrefRangeStart = 656814, XrefRangeEnd = 656834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000599CC File Offset: 0x00057BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656838, XrefRangeEnd = 656839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00059A5C File Offset: 0x00057C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656839, XrefRangeEnd = 656845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00059AF8 File Offset: 0x00057CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656845, XrefRangeEnd = 656851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00059B88 File Offset: 0x00057D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656857, RefRangeEnd = 656858, XrefRangeStart = 656851, XrefRangeEnd = 656857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00059C08 File Offset: 0x00057E08
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000077C1 File Offset: 0x000059C1
		public Texture2DArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000077CA File Offset: 0x000059CA
		public int depth
		{
			get
			{
				return Texture2DArray.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x000077DC File Offset: 0x000059DC
		public TextureFormat format
		{
			get
			{
				return Texture2DArray.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000077EE File Offset: 0x000059EE
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			Texture2DArray.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00059C3C File Offset: 0x00057E3C
		public Il2CppStructArray<Color> GetPixels(int arrayElement, int miplevel)
		{
			IntPtr intPtr = Texture2DArray.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00059C6C File Offset: 0x00057E6C
		public Il2CppStructArray<Color> GetPixels(int arrayElement)
		{
			return this.GetPixels(arrayElement, 0);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00007802 File Offset: 0x00005A02
		public bool SetPixelDataImplArray(Array data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00007822 File Offset: 0x00005A22
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00059C88 File Offset: 0x00057E88
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement, int miplevel)
		{
			IntPtr intPtr = Texture2DArray.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00059CB8 File Offset: 0x00057EB8
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement)
		{
			return this.GetPixels32(arrayElement, 0);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0000783D File Offset: 0x00005A3D
		public void SetPixels(Il2CppStructArray<Color> colors, int arrayElement, int miplevel)
		{
			Texture2DArray.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), arrayElement, miplevel);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00007857 File Offset: 0x00005A57
		public void SetPixels(Il2CppStructArray<Color> colors, int arrayElement)
		{
			this.SetPixels(colors, arrayElement, 0);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00007864 File Offset: 0x00005A64
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement, int miplevel)
		{
			Texture2DArray.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), arrayElement, miplevel);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0000787E File Offset: 0x00005A7E
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement)
		{
			this.SetPixels32(colors, arrayElement, 0);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000788B File Offset: 0x00005A8B
		public IntPtr GetImageDataPointer()
		{
			return Texture2DArray.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00059CD4 File Offset: 0x00057ED4
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000789D File Offset: 0x00005A9D
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000078A9 File Offset: 0x00005AA9
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00059D00 File Offset: 0x00057F00
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, element, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00059D74 File Offset: 0x00057F74
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, element, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00059DF4 File Offset: 0x00057FF4
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : struct
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
			bool flag3 = element < 0 || element >= this.depth;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (this.depth - 1).ToString()));
			}
			ulong pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, element);
			ulong pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, element);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, element);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag4 = num2 > 2147483647UL;
			if (flag4)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr intPtr;
			intPtr..ctor((long)this.GetImageDataPointer() + (long)(pixelDataOffset * (ulong)((long)element) + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly Texture2DArray.get_depthDelegate get_depthDelegateField;

		// Token: 0x04000FAD RID: 4013
		private static readonly Texture2DArray.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000FAE RID: 4014
		private static readonly Texture2DArray.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x04000FAF RID: 4015
		private static readonly Texture2DArray.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x04000FB0 RID: 4016
		private static readonly Texture2DArray.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000FB1 RID: 4017
		private static readonly Texture2DArray.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x04000FB2 RID: 4018
		private static readonly Texture2DArray.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x04000FB3 RID: 4019
		private static readonly Texture2DArray.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x04000FB4 RID: 4020
		private static readonly Texture2DArray.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x04000FB5 RID: 4021
		private static readonly Texture2DArray.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x02000693 RID: 1683
		// (Invoke) Token: 0x06003604 RID: 13828
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x02000694 RID: 1684
		// (Invoke) Token: 0x06003606 RID: 13830
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x02000695 RID: 1685
		// (Invoke) Token: 0x06003608 RID: 13832
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x0600360A RID: 13834
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int arrayElement, int miplevel);

		// Token: 0x02000697 RID: 1687
		// (Invoke) Token: 0x0600360C RID: 13836
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x02000698 RID: 1688
		// (Invoke) Token: 0x0600360E RID: 13838
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x02000699 RID: 1689
		// (Invoke) Token: 0x06003610 RID: 13840
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int arrayElement, int miplevel);

		// Token: 0x0200069A RID: 1690
		// (Invoke) Token: 0x06003612 RID: 13842
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, int arrayElement, int miplevel);

		// Token: 0x0200069B RID: 1691
		// (Invoke) Token: 0x06003614 RID: 13844
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, int arrayElement, int miplevel);

		// Token: 0x0200069C RID: 1692
		// (Invoke) Token: 0x06003616 RID: 13846
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);
	}
}

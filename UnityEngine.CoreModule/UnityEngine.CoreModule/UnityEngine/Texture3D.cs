using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	public sealed class Texture3D : Texture
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x0005817C File Offset: 0x0005637C
		// Note: this type is marked as 'beforefieldinit'.
		static Texture3D()
		{
			Il2CppClassPointerStore<Texture3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture3D>.NativeClassPtr);
			Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665754);
			Texture3D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665755);
			Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665756);
			Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665757);
			Texture3D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665758);
			Texture3D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665759);
			Texture3D.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665760);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665761);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665762);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665763);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665764);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665765);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665766);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665767);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665768);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665769);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665770);
			Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665771);
			Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665772);
			Texture3D.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665773);
			Texture3D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665774);
			Texture3D.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665775);
			Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665776);
			Texture3D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100665777);
			Texture3D.get_depthDelegateField = IL2CPP.ResolveICall<Texture3D.get_depthDelegate>("UnityEngine.Texture3D::get_depth");
			Texture3D.get_formatDelegateField = IL2CPP.ResolveICall<Texture3D.get_formatDelegate>("UnityEngine.Texture3D::get_format");
			Texture3D.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Texture3D.UpdateExternalTextureDelegate>("UnityEngine.Texture3D::UpdateExternalTexture");
			Texture3D.GetPixelsDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelsDelegate>("UnityEngine.Texture3D::GetPixels");
			Texture3D.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture3D.GetPixels32Delegate>("UnityEngine.Texture3D::GetPixels32");
			Texture3D.SetPixels32DelegateField = IL2CPP.ResolveICall<Texture3D.SetPixels32Delegate>("UnityEngine.Texture3D::SetPixels32");
			Texture3D.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelDataImplArrayDelegate>("UnityEngine.Texture3D::SetPixelDataImplArray");
			Texture3D.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<Texture3D.GetImageDataPointerDelegate>("UnityEngine.Texture3D::GetImageDataPointer");
			Texture3D.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelImpl_Injected");
			Texture3D.GetPixelBilinearImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelBilinearImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelBilinearImpl_Injected");
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00058424 File Offset: 0x00056624
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656601, XrefRangeEnd = 656603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00058460 File Offset: 0x00056660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656603, XrefRangeEnd = 656605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl(int mip, int x, int y, int z, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000584D8 File Offset: 0x000566D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656605, XrefRangeEnd = 656607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005858C File Offset: 0x0005678C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656609, RefRangeEnd = 656611, XrefRangeStart = 656607, XrefRangeEnd = 656609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00058634 File Offset: 0x00056834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656611, XrefRangeEnd = 656613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00058680 File Offset: 0x00056880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656615, RefRangeEnd = 656616, XrefRangeStart = 656613, XrefRangeEnd = 656615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000586D0 File Offset: 0x000568D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656618, RefRangeEnd = 656619, XrefRangeStart = 656616, XrefRangeEnd = 656618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataArraySize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDataStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00058754 File Offset: 0x00056954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656619, XrefRangeEnd = 656625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000587D4 File Offset: 0x000569D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656625, XrefRangeEnd = 656627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00058864 File Offset: 0x00056A64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 656632, RefRangeEnd = 656635, XrefRangeStart = 656627, XrefRangeEnd = 656632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000588E4 File Offset: 0x00056AE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 656650, RefRangeEnd = 656655, XrefRangeStart = 656635, XrefRangeEnd = 656650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00058974 File Offset: 0x00056B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656655, XrefRangeEnd = 656656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000589F4 File Offset: 0x00056BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656656, XrefRangeEnd = 656657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00058A84 File Offset: 0x00056C84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 656675, RefRangeEnd = 656680, XrefRangeStart = 656657, XrefRangeEnd = 656675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00058B20 File Offset: 0x00056D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656680, XrefRangeEnd = 656686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00058BA0 File Offset: 0x00056DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656686, XrefRangeEnd = 656692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00058C30 File Offset: 0x00056E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656692, XrefRangeEnd = 656698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00058CC0 File Offset: 0x00056EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656703, RefRangeEnd = 656705, XrefRangeStart = 656698, XrefRangeEnd = 656703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00058D0C File Offset: 0x00056F0C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 656706, RefRangeEnd = 656717, XrefRangeStart = 656705, XrefRangeEnd = 656706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00058D4C File Offset: 0x00056F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 656718, RefRangeEnd = 656719, XrefRangeStart = 656717, XrefRangeEnd = 656718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00058D80 File Offset: 0x00056F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656721, RefRangeEnd = 656723, XrefRangeStart = 656719, XrefRangeEnd = 656721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(int x, int y, int z, Color color, int mipLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00058DF8 File Offset: 0x00056FF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 656727, RefRangeEnd = 656735, XrefRangeStart = 656723, XrefRangeEnd = 656727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDataStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00058E5C File Offset: 0x0005705C
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00058E90 File Offset: 0x00057090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 656735, XrefRangeEnd = 656737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl_Injected(int mip, int x, int y, int z, ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000076EE File Offset: 0x000058EE
		public Texture3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x000076F7 File Offset: 0x000058F7
		public int depth
		{
			get
			{
				return Texture3D.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00007709 File Offset: 0x00005909
		public TextureFormat format
		{
			get
			{
				return Texture3D.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00058F08 File Offset: 0x00057108
		public Color GetPixelImpl(int mip, int x, int y, int z)
		{
			Color color;
			this.GetPixelImpl_Injected(mip, x, y, z, out color);
			return color;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00058F24 File Offset: 0x00057124
		public Color GetPixelBilinearImpl(int mip, float u, float v, float w)
		{
			Color color;
			this.GetPixelBilinearImpl_Injected(mip, u, v, w, out color);
			return color;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0000771B File Offset: 0x0000591B
		public void UpdateExternalTexture(IntPtr nativeTex)
		{
			Texture3D.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTex);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00058F40 File Offset: 0x00057140
		public Il2CppStructArray<Color> GetPixels(int miplevel)
		{
			IntPtr intPtr = Texture3D.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00058F70 File Offset: 0x00057170
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00058F8C File Offset: 0x0005718C
		public Il2CppStructArray<Color32> GetPixels32(int miplevel)
		{
			IntPtr intPtr = Texture3D.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00058FBC File Offset: 0x000571BC
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(0);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0000772E File Offset: 0x0000592E
		public void SetPixels(Il2CppStructArray<Color> colors)
		{
			this.SetPixels(colors, 0);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0000773A File Offset: 0x0000593A
		public void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture3D.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00007753 File Offset: 0x00005953
		public void SetPixels32(Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(colors, 0);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0000775F File Offset: 0x0000595F
		public bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture3D.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0000777D File Offset: 0x0000597D
		public IntPtr GetImageDataPointer()
		{
			return Texture3D.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00058FD8 File Offset: 0x000571D8
		public static Texture3D CreateExternalTexture(int width, int height, int depth, TextureFormat format, bool mipChain, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex may not be zero");
			}
			return new Texture3D(width, height, depth, format, mipChain ? (-1) : 1, nativeTex, false);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0005901C File Offset: 0x0005721C
		public void SetPixel(int x, int y, int z, Color color)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(0, x, y, z, color);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0005904C File Offset: 0x0005724C
		public Color GetPixel(int x, int y, int z)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(0, x, y, z);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00059080 File Offset: 0x00057280
		public Color GetPixel(int x, int y, int z, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(mipLevel, x, y, z);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000590B4 File Offset: 0x000572B4
		public Color GetPixelBilinear(float u, float v, float w)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(0, u, v, w);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x000590E8 File Offset: 0x000572E8
		public Color GetPixelBilinear(float u, float v, float w, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(mipLevel, u, v, w);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0005911C File Offset: 0x0005731C
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00059190 File Offset: 0x00057390
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = mipLevel < 0 || mipLevel >= base.mipmapCount;
			if (flag2)
			{
				throw new ArgumentException(String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through  ", (base.mipmapCount - 1).ToString()));
			}
			bool flag3 = this.GetImageDataPointer().ToInt64() == 0L;
			if (flag3)
			{
				throw new UnityException(String.Concat("Texture '", base.name, "' has no data."));
			}
			ulong pixelDataOffset = base.GetPixelDataOffset(mipLevel, 0);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, 0);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag4 = num2 > 2147483647UL;
			if (flag4)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr intPtr;
			intPtr..ctor((long)this.GetImageDataPointer() + (long)pixelDataOffset);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0000778F File Offset: 0x0000598F
		public void GetPixelImpl_Injected(int mip, int x, int y, int z, out Color ret)
		{
			Texture3D.GetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mip, x, y, z, out ret);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000077A8 File Offset: 0x000059A8
		public void GetPixelBilinearImpl_Injected(int mip, float u, float v, float w, out Color ret)
		{
			Texture3D.GetPixelBilinearImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mip, u, v, w, out ret);
		}

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly Texture3D.get_depthDelegate get_depthDelegateField;

		// Token: 0x04000F93 RID: 3987
		private static readonly Texture3D.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000F94 RID: 3988
		private static readonly Texture3D.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000F95 RID: 3989
		private static readonly Texture3D.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x04000F96 RID: 3990
		private static readonly Texture3D.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x04000F97 RID: 3991
		private static readonly Texture3D.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x04000F98 RID: 3992
		private static readonly Texture3D.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000F99 RID: 3993
		private static readonly Texture3D.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x04000F9A RID: 3994
		private static readonly Texture3D.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

		// Token: 0x04000F9B RID: 3995
		private static readonly Texture3D.GetPixelBilinearImpl_InjectedDelegate GetPixelBilinearImpl_InjectedDelegateField;

		// Token: 0x02000688 RID: 1672
		private sealed class MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002C07 RID: 11271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture3D.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Texture3D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x060035F0 RID: 13808
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x0200068A RID: 1674
		// (Invoke) Token: 0x060035F2 RID: 13810
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x0200068B RID: 1675
		// (Invoke) Token: 0x060035F4 RID: 13812
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTex);

		// Token: 0x0200068C RID: 1676
		// (Invoke) Token: 0x060035F6 RID: 13814
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int miplevel);

		// Token: 0x0200068D RID: 1677
		// (Invoke) Token: 0x060035F8 RID: 13816
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int miplevel);

		// Token: 0x0200068E RID: 1678
		// (Invoke) Token: 0x060035FA RID: 13818
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, int miplevel);

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x060035FC RID: 13820
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x02000690 RID: 1680
		// (Invoke) Token: 0x060035FE RID: 13822
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x06003600 RID: 13824
		private delegate void GetPixelImpl_InjectedDelegate(IntPtr @this, int mip, int x, int y, int z, [Out] IntPtr ret);

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x06003602 RID: 13826
		private delegate void GetPixelBilinearImpl_InjectedDelegate(IntPtr @this, int mip, float u, float v, float w, [Out] IntPtr ret);
	}
}

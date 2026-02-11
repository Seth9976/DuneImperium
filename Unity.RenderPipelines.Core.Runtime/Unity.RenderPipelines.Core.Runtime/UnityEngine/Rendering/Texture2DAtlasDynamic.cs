using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C2 RID: 194
	public class Texture2DAtlasDynamic : Object
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00040A20 File Offset: 0x0003EC20
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DAtlasDynamic()
		{
			Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Texture2DAtlasDynamic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr);
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_AtlasTexture");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_isAtlasTextureOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "isAtlasTextureOwner");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_Width");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_Height");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_Format");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_AtlasAllocator");
			Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AllocationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, "m_AllocationCache");
			Texture2DAtlasDynamic.NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665316);
			Texture2DAtlasDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665317);
			Texture2DAtlasDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665318);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665319);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_ResetAllocator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665320);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_AddTexture_Public_Boolean_CommandBuffer_byref_Vector4_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665321);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665322);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_EnsureTextureSlot_Public_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665323);
			Texture2DAtlasDynamic.NativeMethodInfoPtr_ReleaseTextureSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr, 100665324);
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00040B90 File Offset: 0x0003ED90
		public unsafe RTHandle AtlasTexture
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00040BD0 File Offset: 0x0003EDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973482, XrefRangeEnd = 973502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00040C44 File Offset: 0x0003EE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973502, XrefRangeEnd = 973518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DAtlasDynamic>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atlasTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00040CBC File Offset: 0x0003EEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973518, XrefRangeEnd = 973529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00040CF0 File Offset: 0x0003EEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973529, XrefRangeEnd = 973538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAllocator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_ResetAllocator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00040D24 File Offset: 0x0003EF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973538, XrefRangeEnd = 973546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_AddTexture_Public_Boolean_CommandBuffer_byref_Vector4_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00040D94 File Offset: 0x0003EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973546, XrefRangeEnd = 973550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCached(out Vector4 scaleOffset, int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scaleOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00040DEC File Offset: 0x0003EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973550, XrefRangeEnd = 973557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &isUploadNeeded;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scaleOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_EnsureTextureSlot_Public_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00040E70 File Offset: 0x0003F070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973557, XrefRangeEnd = 973570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseTextureSlot(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DAtlasDynamic.NativeMethodInfoPtr_ReleaseTextureSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00008139 File Offset: 0x00006339
		public Texture2DAtlasDynamic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00040EB0 File Offset: 0x0003F0B0
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00008142 File Offset: 0x00006342
		public unsafe RTHandle m_AtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00040EE0 File Offset: 0x0003F0E0
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00008161 File Offset: 0x00006361
		public unsafe bool isAtlasTextureOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_isAtlasTextureOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_isAtlasTextureOwner)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00040F08 File Offset: 0x0003F108
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0000817C File Offset: 0x0000637C
		public unsafe int m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00040F30 File Offset: 0x0003F130
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00008197 File Offset: 0x00006397
		public unsafe int m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00040F58 File Offset: 0x0003F158
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000081B2 File Offset: 0x000063B2
		public unsafe GraphicsFormat m_Format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_Format)) = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00040F80 File Offset: 0x0003F180
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x000081CD File Offset: 0x000063CD
		public unsafe AtlasAllocatorDynamic m_AtlasAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasAllocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocatorDynamic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AtlasAllocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00040FB0 File Offset: 0x0003F1B0
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x000081EC File Offset: 0x000063EC
		public unsafe Dictionary<int, Vector4> m_AllocationCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AllocationCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Texture2DAtlasDynamic.NativeFieldInfoPtr_m_AllocationCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_isAtlasTextureOwner;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_m_Format;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasAllocator;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocationCache;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_get_AtlasTexture_Public_get_RTHandle_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RTHandle_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllocator_Public_Void_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_AddTexture_Public_Boolean_CommandBuffer_byref_Vector4_Texture_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_IsCached_Public_Boolean_byref_Vector4_Int32_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTextureSlot_Public_Boolean_byref_Boolean_byref_Vector4_Int32_Int32_Int32_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTextureSlot_Public_Void_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000268 RID: 616
	public class ShaderInfoStorage<T> : BaseShaderInfoStorage where T : new()
	{
		// Token: 0x06002DBC RID: 11708 RVA: 0x000C3810 File Offset: 0x000C1A10
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderInfoStorage()
		{
			Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "ShaderInfoStorage`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr);
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_InitialSize");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_MaxSize");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_Format");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Convert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_Convert");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_Allocator");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_Texture");
			ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, "m_Texels");
			ShaderInfoStorage<T>.NativeMethodInfoPtr__ctor_Public_Void_TextureFormat_Func_2_Color_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669976);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669977);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_get_texture_Public_Virtual_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669978);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_AllocateRect_Public_Virtual_Boolean_Int32_Int32_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669979);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_SetTexel_Public_Virtual_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669980);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669981);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_CreateOrExpandTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669982);
			ShaderInfoStorage<T>.NativeMethodInfoPtr_CpuBlit_Private_Static_Void_NativeArray_1_T_Int32_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr, 100669983);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000C39A8 File Offset: 0x000C1BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351600, RefRangeEnd = 351602, XrefRangeStart = 351540, XrefRangeEnd = 351600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderInfoStorage(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderInfoStorage<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(convert);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorage<T>.NativeMethodInfoPtr__ctor_Public_Void_TextureFormat_Func_2_Color_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000C3A20 File Offset: 0x000C1C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351602, XrefRangeEnd = 351612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderInfoStorage<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000C3A6C File Offset: 0x000C1C6C
		public unsafe override Texture2D texture
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderInfoStorage<T>.NativeMethodInfoPtr_get_texture_Public_Virtual_get_Texture2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000C3AB8 File Offset: 0x000C1CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351612, XrefRangeEnd = 351619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllocateRect(int width, int height, out RectInt uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uvs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderInfoStorage<T>.NativeMethodInfoPtr_AllocateRect_Public_Virtual_Boolean_Int32_Int32_byref_RectInt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000C3B28 File Offset: 0x000C1D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351619, XrefRangeEnd = 351620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetTexel(int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderInfoStorage<T>.NativeMethodInfoPtr_SetTexel_Public_Virtual_Void_Int32_Int32_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000C3B90 File Offset: 0x000C1D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351620, XrefRangeEnd = 351625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderInfoStorage<T>.NativeMethodInfoPtr_UpdateTexture_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000C3BCC File Offset: 0x000C1DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351658, RefRangeEnd = 351659, XrefRangeStart = 351625, XrefRangeEnd = 351658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOrExpandTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorage<T>.NativeMethodInfoPtr_CreateOrExpandTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x000C3C00 File Offset: 0x000C1E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351659, XrefRangeEnd = 351664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorage<T>.NativeMethodInfoPtr_CpuBlit_Private_Static_Void_NativeArray_1_T_Int32_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00012C59 File Offset: 0x00010E59
		public ShaderInfoStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000C3C8C File Offset: 0x000C1E8C
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x00012C62 File Offset: 0x00010E62
		public unsafe int m_InitialSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_InitialSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_InitialSize)) = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x000C3CB4 File Offset: 0x000C1EB4
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x00012C7D File Offset: 0x00010E7D
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x000C3CDC File Offset: 0x000C1EDC
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe TextureFormat m_Format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Format)) = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x000C3D04 File Offset: 0x000C1F04
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x00012CB3 File Offset: 0x00010EB3
		public unsafe Func<Color, T> m_Convert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Convert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Color, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Convert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000C3D34 File Offset: 0x000C1F34
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x00012CD2 File Offset: 0x00010ED2
		public unsafe UIRAtlasAllocator m_Allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Allocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000C3D64 File Offset: 0x000C1F64
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x00012CF1 File Offset: 0x00010EF1
		public unsafe Texture2D m_Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x000C3D94 File Offset: 0x000C1F94
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x00012D10 File Offset: 0x00010F10
		public NativeArray<T> m_Texels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texels);
				return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderInfoStorage<T>.NativeFieldInfoPtr_m_Texels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialSize;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_m_Format;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_m_Convert;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_m_Allocator;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_m_Texture;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_m_Texels;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureFormat_Func_2_Color_T_Int32_Int32_0;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_Virtual_get_Texture2D_0;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeMethodInfoPtr_AllocateRect_Public_Virtual_Boolean_Int32_Int32_byref_RectInt_0;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeMethodInfoPtr_SetTexel_Public_Virtual_Void_Int32_Int32_Color_0;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTexture_Public_Virtual_Void_0;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrExpandTexture_Private_Void_0;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeMethodInfoPtr_CpuBlit_Private_Static_Void_NativeArray_1_T_Int32_Int32_NativeArray_1_T_Int32_Int32_0;
	}
}

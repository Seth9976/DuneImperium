using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000277 RID: 631
	public sealed class BitmapAllocator32 : ValueType
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x000C5FEC File Offset: 0x000C41EC
		// Note: this type is marked as 'beforefieldinit'.
		static BitmapAllocator32()
		{
			Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BitmapAllocator32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr);
			BitmapAllocator32.NativeFieldInfoPtr_m_PageHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "m_PageHeight");
			BitmapAllocator32.NativeFieldInfoPtr_m_Pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "m_Pages");
			BitmapAllocator32.NativeFieldInfoPtr_m_AllocMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "m_AllocMap");
			BitmapAllocator32.NativeFieldInfoPtr_m_EntryWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "m_EntryWidth");
			BitmapAllocator32.NativeFieldInfoPtr_m_EntryHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "m_EntryHeight");
			BitmapAllocator32.NativeMethodInfoPtr_Construct_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670057);
			BitmapAllocator32.NativeMethodInfoPtr_ForceFirstAlloc_Public_Void_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670058);
			BitmapAllocator32.NativeMethodInfoPtr_Allocate_Public_BMPAlloc_BaseShaderInfoStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670059);
			BitmapAllocator32.NativeMethodInfoPtr_Free_Public_Void_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670060);
			BitmapAllocator32.NativeMethodInfoPtr_get_entryWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670061);
			BitmapAllocator32.NativeMethodInfoPtr_get_entryHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670062);
			BitmapAllocator32.NativeMethodInfoPtr_GetAllocPageAtlasLocation_Internal_Void_Int32_byref_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670063);
			BitmapAllocator32.NativeMethodInfoPtr_CountTrailingZeroes_Private_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, 100670064);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000C6120 File Offset: 0x000C4320
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352296, RefRangeEnd = 352301, XrefRangeStart = 352279, XrefRangeEnd = 352296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pageHeight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_Construct_Public_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000C6180 File Offset: 0x000C4380
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352311, RefRangeEnd = 352316, XrefRangeStart = 352301, XrefRangeEnd = 352311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceFirstAlloc(ushort firstPageX, ushort firstPageY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstPageX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstPageY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_ForceFirstAlloc_Public_Void_UInt16_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000C61D4 File Offset: 0x000C43D4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 352342, RefRangeEnd = 352355, XrefRangeStart = 352316, XrefRangeEnd = 352342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BMPAlloc Allocate(BaseShaderInfoStorage storage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_Allocate_Public_BMPAlloc_BaseShaderInfoStorage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000C6228 File Offset: 0x000C4428
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 352372, RefRangeEnd = 352390, XrefRangeStart = 352355, XrefRangeEnd = 352372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(BMPAlloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_Free_Public_Void_BMPAlloc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000C626C File Offset: 0x000C446C
		public unsafe int entryWidth
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_get_entryWidth_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x000C62B0 File Offset: 0x000C44B0
		public unsafe int entryHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347794, RefRangeEnd = 347795, XrefRangeStart = 347794, XrefRangeEnd = 347795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_get_entryHeight_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000C62F4 File Offset: 0x000C44F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352390, XrefRangeEnd = 352393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref page;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_GetAllocPageAtlasLocation_Internal_Void_Int32_byref_UInt16_byref_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000C6354 File Offset: 0x000C4554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352393, RefRangeEnd = 352394, XrefRangeStart = 352393, XrefRangeEnd = 352393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte CountTrailingZeroes(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmapAllocator32.NativeMethodInfoPtr_CountTrailingZeroes_Private_Static_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x000133A3 File Offset: 0x000115A3
		public BitmapAllocator32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000133AC File Offset: 0x000115AC
		public BitmapAllocator32()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr))
		{
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000C6394 File Offset: 0x000C4594
		// (set) Token: 0x06002E9D RID: 11933 RVA: 0x000133BE File Offset: 0x000115BE
		public unsafe int m_PageHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_PageHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_PageHeight)) = value;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000C63BC File Offset: 0x000C45BC
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x000133D9 File Offset: 0x000115D9
		public unsafe List<BitmapAllocator32.Page> m_Pages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_Pages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BitmapAllocator32.Page>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_Pages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000C63EC File Offset: 0x000C45EC
		// (set) Token: 0x06002EA1 RID: 11937 RVA: 0x000133F8 File Offset: 0x000115F8
		public unsafe List<uint> m_AllocMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_AllocMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_AllocMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000C641C File Offset: 0x000C461C
		// (set) Token: 0x06002EA3 RID: 11939 RVA: 0x00013417 File Offset: 0x00011617
		public unsafe int m_EntryWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_EntryWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_EntryWidth)) = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x000C6444 File Offset: 0x000C4644
		// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x00013432 File Offset: 0x00011632
		public unsafe int m_EntryHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_EntryHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmapAllocator32.NativeFieldInfoPtr_m_EntryHeight)) = value;
			}
		}

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeFieldInfoPtr_m_PageHeight;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeFieldInfoPtr_m_Pages;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocMap;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeFieldInfoPtr_m_EntryWidth;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeFieldInfoPtr_m_EntryHeight;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_ForceFirstAlloc_Public_Void_UInt16_UInt16_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_BMPAlloc_BaseShaderInfoStorage_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_BMPAlloc_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_get_entryWidth_Public_get_Int32_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_get_entryHeight_Public_get_Int32_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocPageAtlasLocation_Internal_Void_Int32_byref_UInt16_byref_UInt16_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_CountTrailingZeroes_Private_Static_Byte_UInt32_0;

		// Token: 0x04002189 RID: 8585
		public const int kPageWidth = 32;

		// Token: 0x02000561 RID: 1377
		[StructLayout(2)]
		public struct Page
		{
			// Token: 0x06004205 RID: 16901 RVA: 0x00103B68 File Offset: 0x00101D68
			// Note: this type is marked as 'beforefieldinit'.
			static Page()
			{
				Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BitmapAllocator32>.NativeClassPtr, "Page");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr);
				BitmapAllocator32.Page.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr, "x");
				BitmapAllocator32.Page.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr, "y");
				BitmapAllocator32.Page.NativeFieldInfoPtr_freeSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr, "freeSlots");
			}

			// Token: 0x06004206 RID: 16902 RVA: 0x0001C18E File Offset: 0x0001A38E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapAllocator32.Page>.NativeClassPtr, ref this));
			}

			// Token: 0x04002E48 RID: 11848
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002E49 RID: 11849
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002E4A RID: 11850
			private static readonly IntPtr NativeFieldInfoPtr_freeSlots;

			// Token: 0x04002E4B RID: 11851
			[FieldOffset(0)]
			public ushort x;

			// Token: 0x04002E4C RID: 11852
			[FieldOffset(2)]
			public ushort y;

			// Token: 0x04002E4D RID: 11853
			[FieldOffset(4)]
			public int freeSlots;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000245 RID: 581
	public class Allocator2D : Object
	{
		// Token: 0x06002ADA RID: 10970 RVA: 0x000BA4E0 File Offset: 0x000B86E0
		// Note: this type is marked as 'beforefieldinit'.
		static Allocator2D()
		{
			Il2CppClassPointerStore<Allocator2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Allocator2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr);
			Allocator2D.NativeFieldInfoPtr_m_MinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_MinSize");
			Allocator2D.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_MaxSize");
			Allocator2D.NativeFieldInfoPtr_m_MaxAllocSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_MaxAllocSize");
			Allocator2D.NativeFieldInfoPtr_m_RowHeightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_RowHeightBias");
			Allocator2D.NativeFieldInfoPtr_m_Rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_Rows");
			Allocator2D.NativeFieldInfoPtr_m_Areas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "m_Areas");
			Allocator2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669709);
			Allocator2D.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_Alloc2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669710);
			Allocator2D.NativeMethodInfoPtr_Free_Public_Void_Alloc2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669711);
			Allocator2D.NativeMethodInfoPtr_BuildAreas_Private_Static_Void_List_1_Area_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669712);
			Allocator2D.NativeMethodInfoPtr_ComputeMaxAllocSize_Private_Static_Vector2Int_List_1_Area_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669713);
			Allocator2D.NativeMethodInfoPtr_BuildRowArray_Private_Static_Il2CppReferenceArray_1_Row_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, 100669714);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000BA600 File Offset: 0x000B8800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348163, RefRangeEnd = 348164, XrefRangeStart = 348113, XrefRangeEnd = 348163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowHeightBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000BA664 File Offset: 0x000B8864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348208, RefRangeEnd = 348209, XrefRangeStart = 348164, XrefRangeEnd = 348208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAllocate(int width, int height, out Allocator2D.Alloc2D alloc2D)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_Alloc2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			alloc2D = ((intPtr4 == 0) ? null : new Allocator2D.Alloc2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000BA6E0 File Offset: 0x000B88E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348226, RefRangeEnd = 348227, XrefRangeStart = 348209, XrefRangeEnd = 348226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(Allocator2D.Alloc2D alloc2D)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc2D));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr_Free_Public_Void_Alloc2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000BA728 File Offset: 0x000B8928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348252, RefRangeEnd = 348253, XrefRangeStart = 348227, XrefRangeEnd = 348252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(areas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr_BuildAreas_Private_Static_Void_List_1_Area_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000BA77C File Offset: 0x000B897C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348253, XrefRangeEnd = 348262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(areas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowHeightBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr_ComputeMaxAllocSize_Private_Static_Vector2Int_List_1_Area_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000BA7CC File Offset: 0x000B89CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348262, XrefRangeEnd = 348269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Allocator2D.Row> BuildRowArray(int maxRowHeight, int rowHeightBias)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxRowHeight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowHeightBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.NativeMethodInfoPtr_BuildRowArray_Private_Static_Il2CppReferenceArray_1_Row_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Allocator2D.Row>>(intPtr3) : null;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00011365 File Offset: 0x0000F565
		public Allocator2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000BA81C File Offset: 0x000B8A1C
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x0001136E File Offset: 0x0000F56E
		public unsafe Vector2Int m_MinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MinSize)) = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000BA844 File Offset: 0x000B8A44
		// (set) Token: 0x06002AE5 RID: 10981 RVA: 0x00011389 File Offset: 0x0000F589
		public unsafe Vector2Int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000BA86C File Offset: 0x000B8A6C
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x000113A4 File Offset: 0x0000F5A4
		public unsafe Vector2Int m_MaxAllocSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MaxAllocSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_MaxAllocSize)) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000BA894 File Offset: 0x000B8A94
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x000113BF File Offset: 0x0000F5BF
		public unsafe int m_RowHeightBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_RowHeightBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_RowHeightBias)) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000BA8BC File Offset: 0x000B8ABC
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x000113DA File Offset: 0x0000F5DA
		public unsafe Il2CppReferenceArray<Allocator2D.Row> m_Rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_Rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Allocator2D.Row>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_Rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000BA8EC File Offset: 0x000B8AEC
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x000113F9 File Offset: 0x0000F5F9
		public unsafe List<Allocator2D.Area> m_Areas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_Areas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Allocator2D.Area>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.NativeFieldInfoPtr_m_Areas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x00011418 File Offset: 0x0000F618
		public Vector2Int minSize
		{
			get
			{
				return this.m_MinSize;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x00011420 File Offset: 0x0000F620
		public Vector2Int maxSize
		{
			get
			{
				return this.m_MaxSize;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x00011428 File Offset: 0x0000F628
		public Vector2Int maxAllocSize
		{
			get
			{
				return this.m_MaxAllocSize;
			}
		}

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeFieldInfoPtr_m_MinSize;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxAllocSize;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeFieldInfoPtr_m_RowHeightBias;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeFieldInfoPtr_m_Rows;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeFieldInfoPtr_m_Areas;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2Int_Int32_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_Alloc2D_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_Alloc2D_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_BuildAreas_Private_Static_Void_List_1_Area_Vector2Int_Vector2Int_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMaxAllocSize_Private_Static_Vector2Int_List_1_Area_Int32_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_BuildRowArray_Private_Static_Il2CppReferenceArray_1_Row_Int32_Int32_0;

		// Token: 0x02000540 RID: 1344
		public class Area : Object
		{
			// Token: 0x060040CE RID: 16590 RVA: 0x00100B84 File Offset: 0x000FED84
			// Note: this type is marked as 'beforefieldinit'.
			static Area()
			{
				Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "Area");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr);
				Allocator2D.Area.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr, "rect");
				Allocator2D.Area.NativeFieldInfoPtr_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr, "allocator");
				Allocator2D.Area.NativeMethodInfoPtr__ctor_Public_Void_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr, 100669715);
			}

			// Token: 0x060040CF RID: 16591 RVA: 0x00100BEC File Offset: 0x000FEDEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348064, RefRangeEnd = 348066, XrefRangeStart = 348058, XrefRangeEnd = 348064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Area(RectInt rect)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Allocator2D.Area>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rect;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.Area.NativeMethodInfoPtr__ctor_Public_Void_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060040D0 RID: 16592 RVA: 0x0001B463 File Offset: 0x00019663
			public Area(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001365 RID: 4965
			// (get) Token: 0x060040D1 RID: 16593 RVA: 0x00100C34 File Offset: 0x000FEE34
			// (set) Token: 0x060040D2 RID: 16594 RVA: 0x0001B46C File Offset: 0x0001966C
			public unsafe RectInt rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Area.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Area.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x17001366 RID: 4966
			// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00100C5C File Offset: 0x000FEE5C
			// (set) Token: 0x060040D4 RID: 16596 RVA: 0x0001B487 File Offset: 0x00019687
			public unsafe BestFitAllocator allocator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Area.NativeFieldInfoPtr_allocator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Area.NativeFieldInfoPtr_allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DA0 RID: 11680
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002DA1 RID: 11681
			private static readonly IntPtr NativeFieldInfoPtr_allocator;

			// Token: 0x04002DA2 RID: 11682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectInt_0;
		}

		// Token: 0x02000541 RID: 1345
		public class Row : LinkedPoolItem<Allocator2D.Row>
		{
			// Token: 0x060040D5 RID: 16597 RVA: 0x00100C8C File Offset: 0x000FEE8C
			// Note: this type is marked as 'beforefieldinit'.
			static Row()
			{
				Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "Row");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr);
				Allocator2D.Row.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "rect");
				Allocator2D.Row.NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "area");
				Allocator2D.Row.NativeFieldInfoPtr_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "allocator");
				Allocator2D.Row.NativeFieldInfoPtr_alloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "alloc");
				Allocator2D.Row.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "next");
				Allocator2D.Row.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, "pool");
				Allocator2D.Row.NativeMethodInfoPtr_Create_Private_Static_Row_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, 100669716);
				Allocator2D.Row.NativeMethodInfoPtr_Reset_Private_Static_Void_Row_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, 100669717);
				Allocator2D.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr, 100669718);
			}

			// Token: 0x060040D6 RID: 16598 RVA: 0x00100D6C File Offset: 0x000FEF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348066, XrefRangeEnd = 348072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Allocator2D.Row Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.Row.NativeMethodInfoPtr_Create_Private_Static_Row_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Allocator2D.Row>(intPtr3) : null;
			}

			// Token: 0x060040D7 RID: 16599 RVA: 0x00100DA0 File Offset: 0x000FEFA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348072, XrefRangeEnd = 348098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Reset(Allocator2D.Row row)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.Row.NativeMethodInfoPtr_Reset_Private_Static_Void_Row_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060040D8 RID: 16600 RVA: 0x00100DD8 File Offset: 0x000FEFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348098, XrefRangeEnd = 348101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Row()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Allocator2D.Row>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040D9 RID: 16601 RVA: 0x0001B4A6 File Offset: 0x000196A6
			public Row(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001367 RID: 4967
			// (get) Token: 0x060040DA RID: 16602 RVA: 0x00100E14 File Offset: 0x000FF014
			// (set) Token: 0x060040DB RID: 16603 RVA: 0x0001B4AF File Offset: 0x000196AF
			public unsafe RectInt rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x17001368 RID: 4968
			// (get) Token: 0x060040DC RID: 16604 RVA: 0x00100E3C File Offset: 0x000FF03C
			// (set) Token: 0x060040DD RID: 16605 RVA: 0x0001B4CA File Offset: 0x000196CA
			public unsafe Allocator2D.Area area
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_area);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Allocator2D.Area>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_area), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001369 RID: 4969
			// (get) Token: 0x060040DE RID: 16606 RVA: 0x00100E6C File Offset: 0x000FF06C
			// (set) Token: 0x060040DF RID: 16607 RVA: 0x0001B4E9 File Offset: 0x000196E9
			public unsafe BestFitAllocator allocator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_allocator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136A RID: 4970
			// (get) Token: 0x060040E0 RID: 16608 RVA: 0x00100E9C File Offset: 0x000FF09C
			// (set) Token: 0x060040E1 RID: 16609 RVA: 0x0001B508 File Offset: 0x00019708
			public Alloc alloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_alloc);
					return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_alloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700136B RID: 4971
			// (get) Token: 0x060040E2 RID: 16610 RVA: 0x00100ECC File Offset: 0x000FF0CC
			// (set) Token: 0x060040E3 RID: 16611 RVA: 0x0001B536 File Offset: 0x00019736
			public unsafe Allocator2D.Row next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Allocator2D.Row>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Row.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136C RID: 4972
			// (get) Token: 0x060040E4 RID: 16612 RVA: 0x00100EFC File Offset: 0x000FF0FC
			// (set) Token: 0x060040E5 RID: 16613 RVA: 0x0001B555 File Offset: 0x00019755
			public unsafe static LinkedPool<Allocator2D.Row> pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Allocator2D.Row.NativeFieldInfoPtr_pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedPool<Allocator2D.Row>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Allocator2D.Row.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DA3 RID: 11683
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002DA4 RID: 11684
			private static readonly IntPtr NativeFieldInfoPtr_area;

			// Token: 0x04002DA5 RID: 11685
			private static readonly IntPtr NativeFieldInfoPtr_allocator;

			// Token: 0x04002DA6 RID: 11686
			private static readonly IntPtr NativeFieldInfoPtr_alloc;

			// Token: 0x04002DA7 RID: 11687
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002DA8 RID: 11688
			private static readonly IntPtr NativeFieldInfoPtr_pool;

			// Token: 0x04002DA9 RID: 11689
			private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_Row_0;

			// Token: 0x04002DAA RID: 11690
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Static_Void_Row_0;

			// Token: 0x04002DAB RID: 11691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000542 RID: 1346
		public sealed class Alloc2D : ValueType
		{
			// Token: 0x060040E6 RID: 16614 RVA: 0x00100F24 File Offset: 0x000FF124
			// Note: this type is marked as 'beforefieldinit'.
			static Alloc2D()
			{
				Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Allocator2D>.NativeClassPtr, "Alloc2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr);
				Allocator2D.Alloc2D.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr, "rect");
				Allocator2D.Alloc2D.NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr, "row");
				Allocator2D.Alloc2D.NativeFieldInfoPtr_alloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr, "alloc");
				Allocator2D.Alloc2D.NativeMethodInfoPtr__ctor_Public_Void_Row_Alloc_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr, 100669720);
			}

			// Token: 0x060040E7 RID: 16615 RVA: 0x00100FA0 File Offset: 0x000FF1A0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348111, RefRangeEnd = 348113, XrefRangeStart = 348101, XrefRangeEnd = 348111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Alloc2D(Allocator2D.Row row, Alloc alloc, int width, int height)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Allocator2D.Alloc2D.NativeMethodInfoPtr__ctor_Public_Void_Row_Alloc_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040E8 RID: 16616 RVA: 0x0001B567 File Offset: 0x00019767
			public Alloc2D(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060040E9 RID: 16617 RVA: 0x0001B570 File Offset: 0x00019770
			public Alloc2D()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Allocator2D.Alloc2D>.NativeClassPtr))
			{
			}

			// Token: 0x1700136D RID: 4973
			// (get) Token: 0x060040EA RID: 16618 RVA: 0x00101024 File Offset: 0x000FF224
			// (set) Token: 0x060040EB RID: 16619 RVA: 0x0001B582 File Offset: 0x00019782
			public unsafe RectInt rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x1700136E RID: 4974
			// (get) Token: 0x060040EC RID: 16620 RVA: 0x0010104C File Offset: 0x000FF24C
			// (set) Token: 0x060040ED RID: 16621 RVA: 0x0001B59D File Offset: 0x0001979D
			public unsafe Allocator2D.Row row
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_row);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Allocator2D.Row>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_row), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136F RID: 4975
			// (get) Token: 0x060040EE RID: 16622 RVA: 0x0010107C File Offset: 0x000FF27C
			// (set) Token: 0x060040EF RID: 16623 RVA: 0x0001B5BC File Offset: 0x000197BC
			public Alloc alloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_alloc);
					return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Allocator2D.Alloc2D.NativeFieldInfoPtr_alloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002DAC RID: 11692
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002DAD RID: 11693
			private static readonly IntPtr NativeFieldInfoPtr_row;

			// Token: 0x04002DAE RID: 11694
			private static readonly IntPtr NativeFieldInfoPtr_alloc;

			// Token: 0x04002DAF RID: 11695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Row_Alloc_Int32_Int32_0;
		}
	}
}

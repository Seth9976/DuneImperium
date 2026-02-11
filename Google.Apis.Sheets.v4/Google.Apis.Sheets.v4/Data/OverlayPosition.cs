using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200008B RID: 139
	public class OverlayPosition : Object
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x0003271C File Offset: 0x0003091C
		// Note: this type is marked as 'beforefieldinit'.
		static OverlayPosition()
		{
			Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "OverlayPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr);
			OverlayPosition.NativeFieldInfoPtr__AnchorCell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<AnchorCell>k__BackingField");
			OverlayPosition.NativeFieldInfoPtr__HeightPixels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<HeightPixels>k__BackingField");
			OverlayPosition.NativeFieldInfoPtr__OffsetXPixels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<OffsetXPixels>k__BackingField");
			OverlayPosition.NativeFieldInfoPtr__OffsetYPixels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<OffsetYPixels>k__BackingField");
			OverlayPosition.NativeFieldInfoPtr__WidthPixels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<WidthPixels>k__BackingField");
			OverlayPosition.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, "<ETag>k__BackingField");
			OverlayPosition.NativeMethodInfoPtr_get_AnchorCell_Public_Virtual_New_get_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664779);
			OverlayPosition.NativeMethodInfoPtr_set_AnchorCell_Public_Virtual_New_set_Void_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664780);
			OverlayPosition.NativeMethodInfoPtr_get_HeightPixels_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664781);
			OverlayPosition.NativeMethodInfoPtr_set_HeightPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664782);
			OverlayPosition.NativeMethodInfoPtr_get_OffsetXPixels_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664783);
			OverlayPosition.NativeMethodInfoPtr_set_OffsetXPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664784);
			OverlayPosition.NativeMethodInfoPtr_get_OffsetYPixels_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664785);
			OverlayPosition.NativeMethodInfoPtr_set_OffsetYPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664786);
			OverlayPosition.NativeMethodInfoPtr_get_WidthPixels_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664787);
			OverlayPosition.NativeMethodInfoPtr_set_WidthPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664788);
			OverlayPosition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664789);
			OverlayPosition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664790);
			OverlayPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr, 100664791);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000328C8 File Offset: 0x00030AC8
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00032914 File Offset: 0x00030B14
		public unsafe virtual GridCoordinate AnchorCell
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_AnchorCell_Public_Virtual_New_get_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridCoordinate>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_AnchorCell_Public_Virtual_New_set_Void_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00032964 File Offset: 0x00030B64
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000329A8 File Offset: 0x00030BA8
		public unsafe virtual Nullable<int> HeightPixels
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_HeightPixels_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_HeightPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x000329FC File Offset: 0x00030BFC
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00032A40 File Offset: 0x00030C40
		public unsafe virtual Nullable<int> OffsetXPixels
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_OffsetXPixels_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_OffsetXPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00032A94 File Offset: 0x00030C94
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00032AD8 File Offset: 0x00030CD8
		public unsafe virtual Nullable<int> OffsetYPixels
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_OffsetYPixels_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_OffsetYPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00032B2C File Offset: 0x00030D2C
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00032B70 File Offset: 0x00030D70
		public unsafe virtual Nullable<int> WidthPixels
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_WidthPixels_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_WidthPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00032BC4 File Offset: 0x00030DC4
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00032C08 File Offset: 0x00030E08
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverlayPosition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00032C58 File Offset: 0x00030E58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverlayPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00006F75 File Offset: 0x00005175
		public OverlayPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00032C94 File Offset: 0x00030E94
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00006F7E File Offset: 0x0000517E
		public unsafe GridCoordinate _AnchorCell_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__AnchorCell_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridCoordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__AnchorCell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00032CC4 File Offset: 0x00030EC4
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00006F9D File Offset: 0x0000519D
		public Nullable<int> _HeightPixels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__HeightPixels_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__HeightPixels_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00032CF4 File Offset: 0x00030EF4
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00006FCB File Offset: 0x000051CB
		public Nullable<int> _OffsetXPixels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__OffsetXPixels_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__OffsetXPixels_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00032D24 File Offset: 0x00030F24
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00006FF9 File Offset: 0x000051F9
		public Nullable<int> _OffsetYPixels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__OffsetYPixels_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__OffsetYPixels_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00032D54 File Offset: 0x00030F54
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00007027 File Offset: 0x00005227
		public Nullable<int> _WidthPixels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__WidthPixels_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__WidthPixels_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00032D84 File Offset: 0x00030F84
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00007055 File Offset: 0x00005255
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayPosition.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr__AnchorCell_k__BackingField;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr__HeightPixels_k__BackingField;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr__OffsetXPixels_k__BackingField;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr__OffsetYPixels_k__BackingField;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr__WidthPixels_k__BackingField;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_AnchorCell_Public_Virtual_New_get_GridCoordinate_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_set_AnchorCell_Public_Virtual_New_set_Void_GridCoordinate_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightPixels_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetXPixels_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetXPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetYPixels_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetYPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthPixels_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthPixels_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

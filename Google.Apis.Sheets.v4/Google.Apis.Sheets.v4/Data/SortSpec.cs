using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000A6 RID: 166
	public class SortSpec : Object
	{
		// Token: 0x06000E0D RID: 3597 RVA: 0x00040F04 File Offset: 0x0003F104
		// Note: this type is marked as 'beforefieldinit'.
		static SortSpec()
		{
			Il2CppClassPointerStore<SortSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SortSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortSpec>.NativeClassPtr);
			SortSpec.NativeFieldInfoPtr__BackgroundColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<BackgroundColor>k__BackingField");
			SortSpec.NativeFieldInfoPtr__BackgroundColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<BackgroundColorStyle>k__BackingField");
			SortSpec.NativeFieldInfoPtr__DimensionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<DimensionIndex>k__BackingField");
			SortSpec.NativeFieldInfoPtr__ForegroundColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<ForegroundColor>k__BackingField");
			SortSpec.NativeFieldInfoPtr__ForegroundColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<ForegroundColorStyle>k__BackingField");
			SortSpec.NativeFieldInfoPtr__SortOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<SortOrder>k__BackingField");
			SortSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, "<ETag>k__BackingField");
			SortSpec.NativeMethodInfoPtr_get_BackgroundColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665236);
			SortSpec.NativeMethodInfoPtr_set_BackgroundColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665237);
			SortSpec.NativeMethodInfoPtr_get_BackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665238);
			SortSpec.NativeMethodInfoPtr_set_BackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665239);
			SortSpec.NativeMethodInfoPtr_get_DimensionIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665240);
			SortSpec.NativeMethodInfoPtr_set_DimensionIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665241);
			SortSpec.NativeMethodInfoPtr_get_ForegroundColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665242);
			SortSpec.NativeMethodInfoPtr_set_ForegroundColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665243);
			SortSpec.NativeMethodInfoPtr_get_ForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665244);
			SortSpec.NativeMethodInfoPtr_set_ForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665245);
			SortSpec.NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665246);
			SortSpec.NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665247);
			SortSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665248);
			SortSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665249);
			SortSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortSpec>.NativeClassPtr, 100665250);
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x000410EC File Offset: 0x0003F2EC
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x00041138 File Offset: 0x0003F338
		public unsafe virtual Color BackgroundColor
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_BackgroundColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_BackgroundColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00041188 File Offset: 0x0003F388
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x000411D4 File Offset: 0x0003F3D4
		public unsafe virtual ColorStyle BackgroundColorStyle
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_BackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_BackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00041224 File Offset: 0x0003F424
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00041268 File Offset: 0x0003F468
		public unsafe virtual Nullable<int> DimensionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_DimensionIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_DimensionIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000412BC File Offset: 0x0003F4BC
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00041308 File Offset: 0x0003F508
		public unsafe virtual Color ForegroundColor
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_ForegroundColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_ForegroundColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00041358 File Offset: 0x0003F558
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x000413A4 File Offset: 0x0003F5A4
		public unsafe virtual ColorStyle ForegroundColorStyle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_ForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_ForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x000413F4 File Offset: 0x0003F5F4
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00041438 File Offset: 0x0003F638
		public unsafe virtual string SortOrder
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00041488 File Offset: 0x0003F688
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x000414CC File Offset: 0x0003F6CC
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0004151C File Offset: 0x0003F71C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00008C15 File Offset: 0x00006E15
		public SortSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00041558 File Offset: 0x0003F758
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00008C1E File Offset: 0x00006E1E
		public unsafe Color _BackgroundColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__BackgroundColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__BackgroundColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00041588 File Offset: 0x0003F788
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00008C3D File Offset: 0x00006E3D
		public unsafe ColorStyle _BackgroundColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__BackgroundColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__BackgroundColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000415B8 File Offset: 0x0003F7B8
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00008C5C File Offset: 0x00006E5C
		public Nullable<int> _DimensionIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__DimensionIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__DimensionIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x000415E8 File Offset: 0x0003F7E8
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00008C8A File Offset: 0x00006E8A
		public unsafe Color _ForegroundColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ForegroundColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ForegroundColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00041618 File Offset: 0x0003F818
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00008CA9 File Offset: 0x00006EA9
		public unsafe ColorStyle _ForegroundColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ForegroundColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ForegroundColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00041648 File Offset: 0x0003F848
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00008CC8 File Offset: 0x00006EC8
		public unsafe string _SortOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__SortOrder_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__SortOrder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00041670 File Offset: 0x0003F870
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00008CE7 File Offset: 0x00006EE7
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr__BackgroundColor_k__BackingField;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr__BackgroundColorStyle_k__BackingField;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr__DimensionIndex_k__BackingField;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr__ForegroundColor_k__BackingField;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr__ForegroundColorStyle_k__BackingField;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr__SortOrder_k__BackingField;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_get_BackgroundColor_Public_Virtual_New_get_Color_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_set_BackgroundColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_get_BackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_set_BackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_get_DimensionIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_set_DimensionIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_get_ForegroundColor_Public_Virtual_New_get_Color_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_set_ForegroundColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_get_ForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_set_ForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

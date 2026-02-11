using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200008D RID: 141
	public class PasteDataRequest : Object
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x00033334 File Offset: 0x00031534
		// Note: this type is marked as 'beforefieldinit'.
		static PasteDataRequest()
		{
			Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PasteDataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr);
			PasteDataRequest.NativeFieldInfoPtr__Coordinate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<Coordinate>k__BackingField");
			PasteDataRequest.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<Data>k__BackingField");
			PasteDataRequest.NativeFieldInfoPtr__Delimiter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<Delimiter>k__BackingField");
			PasteDataRequest.NativeFieldInfoPtr__Html_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<Html>k__BackingField");
			PasteDataRequest.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<Type>k__BackingField");
			PasteDataRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, "<ETag>k__BackingField");
			PasteDataRequest.NativeMethodInfoPtr_get_Coordinate_Public_Virtual_New_get_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664803);
			PasteDataRequest.NativeMethodInfoPtr_set_Coordinate_Public_Virtual_New_set_Void_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664804);
			PasteDataRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664805);
			PasteDataRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664806);
			PasteDataRequest.NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664807);
			PasteDataRequest.NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664808);
			PasteDataRequest.NativeMethodInfoPtr_get_Html_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664809);
			PasteDataRequest.NativeMethodInfoPtr_set_Html_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664810);
			PasteDataRequest.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664811);
			PasteDataRequest.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664812);
			PasteDataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664813);
			PasteDataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664814);
			PasteDataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr, 100664815);
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000334E0 File Offset: 0x000316E0
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0003352C File Offset: 0x0003172C
		public unsafe virtual GridCoordinate Coordinate
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_Coordinate_Public_Virtual_New_get_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_Coordinate_Public_Virtual_New_set_Void_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0003357C File Offset: 0x0003177C
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x000335C0 File Offset: 0x000317C0
		public unsafe virtual string Data
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00033610 File Offset: 0x00031810
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00033654 File Offset: 0x00031854
		public unsafe virtual string Delimiter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000336A4 File Offset: 0x000318A4
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000336E8 File Offset: 0x000318E8
		public unsafe virtual Nullable<bool> Html
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_Html_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_Html_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0003373C File Offset: 0x0003193C
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00033780 File Offset: 0x00031980
		public unsafe virtual string Type
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000337D0 File Offset: 0x000319D0
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00033814 File Offset: 0x00031A14
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasteDataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00033864 File Offset: 0x00031A64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PasteDataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PasteDataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasteDataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00007154 File Offset: 0x00005354
		public PasteDataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000338A0 File Offset: 0x00031AA0
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0000715D File Offset: 0x0000535D
		public unsafe GridCoordinate _Coordinate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Coordinate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridCoordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Coordinate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000338D0 File Offset: 0x00031AD0
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0000717C File Offset: 0x0000537C
		public unsafe string _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Data_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000338F8 File Offset: 0x00031AF8
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0000719B File Offset: 0x0000539B
		public unsafe string _Delimiter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Delimiter_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Delimiter_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00033920 File Offset: 0x00031B20
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x000071BA File Offset: 0x000053BA
		public Nullable<bool> _Html_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Html_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Html_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00033950 File Offset: 0x00031B50
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x000071E8 File Offset: 0x000053E8
		public unsafe string _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Type_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00033978 File Offset: 0x00031B78
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00007207 File Offset: 0x00005407
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasteDataRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr__Coordinate_k__BackingField;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr__Delimiter_k__BackingField;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr__Html_k__BackingField;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_get_Coordinate_Public_Virtual_New_get_GridCoordinate_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_set_Coordinate_Public_Virtual_New_set_Void_GridCoordinate_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_get_Html_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_set_Html_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

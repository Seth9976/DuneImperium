using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200001E RID: 30
	public class BasicChartAxis : Object
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicChartAxis()
		{
			Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BasicChartAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr);
			BasicChartAxis.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<Format>k__BackingField");
			BasicChartAxis.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<Position>k__BackingField");
			BasicChartAxis.NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<Title>k__BackingField");
			BasicChartAxis.NativeFieldInfoPtr__TitleTextPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<TitleTextPosition>k__BackingField");
			BasicChartAxis.NativeFieldInfoPtr__ViewWindowOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<ViewWindowOptions>k__BackingField");
			BasicChartAxis.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, "<ETag>k__BackingField");
			BasicChartAxis.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663738);
			BasicChartAxis.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663739);
			BasicChartAxis.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663740);
			BasicChartAxis.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663741);
			BasicChartAxis.NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663742);
			BasicChartAxis.NativeMethodInfoPtr_set_Title_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663743);
			BasicChartAxis.NativeMethodInfoPtr_get_TitleTextPosition_Public_Virtual_New_get_TextPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663744);
			BasicChartAxis.NativeMethodInfoPtr_set_TitleTextPosition_Public_Virtual_New_set_Void_TextPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663745);
			BasicChartAxis.NativeMethodInfoPtr_get_ViewWindowOptions_Public_Virtual_New_get_ChartAxisViewWindowOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663746);
			BasicChartAxis.NativeMethodInfoPtr_set_ViewWindowOptions_Public_Virtual_New_set_Void_ChartAxisViewWindowOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663747);
			BasicChartAxis.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663748);
			BasicChartAxis.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663749);
			BasicChartAxis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr, 100663750);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00011FA4 File Offset: 0x000101A4
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00011FF0 File Offset: 0x000101F0
		public unsafe virtual TextFormat Format
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00012040 File Offset: 0x00010240
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00012084 File Offset: 0x00010284
		public unsafe virtual string Position
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000120D4 File Offset: 0x000102D4
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00012118 File Offset: 0x00010318
		public unsafe virtual string Title
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_Title_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00012168 File Offset: 0x00010368
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000121B4 File Offset: 0x000103B4
		public unsafe virtual TextPosition TitleTextPosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_TitleTextPosition_Public_Virtual_New_get_TextPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_TitleTextPosition_Public_Virtual_New_set_Void_TextPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00012204 File Offset: 0x00010404
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00012250 File Offset: 0x00010450
		public unsafe virtual ChartAxisViewWindowOptions ViewWindowOptions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_ViewWindowOptions_Public_Virtual_New_get_ChartAxisViewWindowOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartAxisViewWindowOptions>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_ViewWindowOptions_Public_Virtual_New_set_Void_ChartAxisViewWindowOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000122A0 File Offset: 0x000104A0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000122E4 File Offset: 0x000104E4
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartAxis.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00012334 File Offset: 0x00010534
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicChartAxis()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChartAxis>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChartAxis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002D29 File Offset: 0x00000F29
		public BasicChartAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00012370 File Offset: 0x00010570
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002D32 File Offset: 0x00000F32
		public unsafe TextFormat _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000123A0 File Offset: 0x000105A0
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002D51 File Offset: 0x00000F51
		public unsafe string _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Position_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000123C8 File Offset: 0x000105C8
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002D70 File Offset: 0x00000F70
		public unsafe string _Title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000123F0 File Offset: 0x000105F0
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002D8F File Offset: 0x00000F8F
		public unsafe TextPosition _TitleTextPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__TitleTextPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__TitleTextPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00012420 File Offset: 0x00010620
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002DAE File Offset: 0x00000FAE
		public unsafe ChartAxisViewWindowOptions _ViewWindowOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__ViewWindowOptions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartAxisViewWindowOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__ViewWindowOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00012450 File Offset: 0x00010650
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002DCD File Offset: 0x00000FCD
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartAxis.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr__TitleTextPosition_k__BackingField;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr__ViewWindowOptions_k__BackingField;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_String_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_set_Title_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_TitleTextPosition_Public_Virtual_New_get_TextPosition_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_set_TitleTextPosition_Public_Virtual_New_set_Void_TextPosition_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewWindowOptions_Public_Virtual_New_get_ChartAxisViewWindowOptions_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewWindowOptions_Public_Virtual_New_set_Void_ChartAxisViewWindowOptions_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

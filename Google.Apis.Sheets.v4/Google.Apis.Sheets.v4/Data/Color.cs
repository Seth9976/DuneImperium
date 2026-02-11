using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000043 RID: 67
	public class Color : Object
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x0001F1F8 File Offset: 0x0001D3F8
		// Note: this type is marked as 'beforefieldinit'.
		static Color()
		{
			Il2CppClassPointerStore<Color>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "Color");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color>.NativeClassPtr);
			Color.NativeFieldInfoPtr__Alpha_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "<Alpha>k__BackingField");
			Color.NativeFieldInfoPtr__Blue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "<Blue>k__BackingField");
			Color.NativeFieldInfoPtr__Green_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "<Green>k__BackingField");
			Color.NativeFieldInfoPtr__Red_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "<Red>k__BackingField");
			Color.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "<ETag>k__BackingField");
			Color.NativeMethodInfoPtr_get_Alpha_Public_Virtual_New_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664161);
			Color.NativeMethodInfoPtr_set_Alpha_Public_Virtual_New_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664162);
			Color.NativeMethodInfoPtr_get_Blue_Public_Virtual_New_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664163);
			Color.NativeMethodInfoPtr_set_Blue_Public_Virtual_New_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664164);
			Color.NativeMethodInfoPtr_get_Green_Public_Virtual_New_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664165);
			Color.NativeMethodInfoPtr_set_Green_Public_Virtual_New_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664166);
			Color.NativeMethodInfoPtr_get_Red_Public_Virtual_New_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664167);
			Color.NativeMethodInfoPtr_set_Red_Public_Virtual_New_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664168);
			Color.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664169);
			Color.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664170);
			Color.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100664171);
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001F368 File Offset: 0x0001D568
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		public unsafe virtual Nullable<float> Alpha
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_get_Alpha_Public_Virtual_New_get_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<float>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_set_Alpha_Public_Virtual_New_set_Void_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001F400 File Offset: 0x0001D600
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0001F444 File Offset: 0x0001D644
		public unsafe virtual Nullable<float> Blue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_get_Blue_Public_Virtual_New_get_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<float>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_set_Blue_Public_Virtual_New_set_Void_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001F498 File Offset: 0x0001D698
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		public unsafe virtual Nullable<float> Green
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_get_Green_Public_Virtual_New_get_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<float>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_set_Green_Public_Virtual_New_set_Void_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001F530 File Offset: 0x0001D730
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0001F574 File Offset: 0x0001D774
		public unsafe virtual Nullable<float> Red
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_get_Red_Public_Virtual_New_get_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<float>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_set_Red_Public_Virtual_New_set_Void_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001F60C File Offset: 0x0001D80C
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Color.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001F65C File Offset: 0x0001D85C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Color>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000475B File Offset: 0x0000295B
		public Color(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001F698 File Offset: 0x0001D898
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004764 File Offset: 0x00002964
		public Nullable<float> _Alpha_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Alpha_k__BackingField);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Alpha_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00004792 File Offset: 0x00002992
		public Nullable<float> _Blue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Blue_k__BackingField);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Blue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x000047C0 File Offset: 0x000029C0
		public Nullable<float> _Green_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Green_k__BackingField);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Green_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001F728 File Offset: 0x0001D928
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000047EE File Offset: 0x000029EE
		public Nullable<float> _Red_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Red_k__BackingField);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__Red_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001F758 File Offset: 0x0001D958
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0000481C File Offset: 0x00002A1C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Color.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr__Alpha_k__BackingField;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr__Blue_k__BackingField;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr__Green_k__BackingField;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr__Red_k__BackingField;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_get_Alpha_Public_Virtual_New_get_Nullable_1_Single_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_set_Alpha_Public_Virtual_New_set_Void_Nullable_1_Single_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_get_Blue_Public_Virtual_New_get_Nullable_1_Single_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_set_Blue_Public_Virtual_New_set_Void_Nullable_1_Single_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_get_Green_Public_Virtual_New_get_Nullable_1_Single_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_set_Green_Public_Virtual_New_set_Void_Nullable_1_Single_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_get_Red_Public_Virtual_New_get_Nullable_1_Single_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_set_Red_Public_Virtual_New_set_Void_Nullable_1_Single_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

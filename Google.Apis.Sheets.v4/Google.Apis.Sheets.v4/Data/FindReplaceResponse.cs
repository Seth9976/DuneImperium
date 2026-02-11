using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000072 RID: 114
	public class FindReplaceResponse : Object
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x0002B224 File Offset: 0x00029424
		// Note: this type is marked as 'beforefieldinit'.
		static FindReplaceResponse()
		{
			Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "FindReplaceResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr);
			FindReplaceResponse.NativeFieldInfoPtr__FormulasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<FormulasChanged>k__BackingField");
			FindReplaceResponse.NativeFieldInfoPtr__OccurrencesChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<OccurrencesChanged>k__BackingField");
			FindReplaceResponse.NativeFieldInfoPtr__RowsChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<RowsChanged>k__BackingField");
			FindReplaceResponse.NativeFieldInfoPtr__SheetsChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<SheetsChanged>k__BackingField");
			FindReplaceResponse.NativeFieldInfoPtr__ValuesChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<ValuesChanged>k__BackingField");
			FindReplaceResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, "<ETag>k__BackingField");
			FindReplaceResponse.NativeMethodInfoPtr_get_FormulasChanged_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664546);
			FindReplaceResponse.NativeMethodInfoPtr_set_FormulasChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664547);
			FindReplaceResponse.NativeMethodInfoPtr_get_OccurrencesChanged_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664548);
			FindReplaceResponse.NativeMethodInfoPtr_set_OccurrencesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664549);
			FindReplaceResponse.NativeMethodInfoPtr_get_RowsChanged_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664550);
			FindReplaceResponse.NativeMethodInfoPtr_set_RowsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664551);
			FindReplaceResponse.NativeMethodInfoPtr_get_SheetsChanged_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664552);
			FindReplaceResponse.NativeMethodInfoPtr_set_SheetsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664553);
			FindReplaceResponse.NativeMethodInfoPtr_get_ValuesChanged_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664554);
			FindReplaceResponse.NativeMethodInfoPtr_set_ValuesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664555);
			FindReplaceResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664556);
			FindReplaceResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664557);
			FindReplaceResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr, 100664558);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002B3D0 File Offset: 0x000295D0
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x0002B414 File Offset: 0x00029614
		public unsafe virtual Nullable<int> FormulasChanged
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_FormulasChanged_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_FormulasChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002B468 File Offset: 0x00029668
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x0002B4AC File Offset: 0x000296AC
		public unsafe virtual Nullable<int> OccurrencesChanged
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_OccurrencesChanged_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_OccurrencesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0002B500 File Offset: 0x00029700
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0002B544 File Offset: 0x00029744
		public unsafe virtual Nullable<int> RowsChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_RowsChanged_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_RowsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0002B598 File Offset: 0x00029798
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0002B5DC File Offset: 0x000297DC
		public unsafe virtual Nullable<int> SheetsChanged
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_SheetsChanged_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_SheetsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002B630 File Offset: 0x00029830
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x0002B674 File Offset: 0x00029874
		public unsafe virtual Nullable<int> ValuesChanged
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_ValuesChanged_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_ValuesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0002B6C8 File Offset: 0x000298C8
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x0002B70C File Offset: 0x0002990C
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindReplaceResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0002B75C File Offset: 0x0002995C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FindReplaceResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindReplaceResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FindReplaceResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00005FFE File Offset: 0x000041FE
		public FindReplaceResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0002B798 File Offset: 0x00029998
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00006007 File Offset: 0x00004207
		public Nullable<int> _FormulasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__FormulasChanged_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__FormulasChanged_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0002B7C8 File Offset: 0x000299C8
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00006035 File Offset: 0x00004235
		public Nullable<int> _OccurrencesChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__OccurrencesChanged_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__OccurrencesChanged_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0002B7F8 File Offset: 0x000299F8
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00006063 File Offset: 0x00004263
		public Nullable<int> _RowsChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__RowsChanged_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__RowsChanged_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0002B828 File Offset: 0x00029A28
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00006091 File Offset: 0x00004291
		public Nullable<int> _SheetsChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__SheetsChanged_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__SheetsChanged_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0002B858 File Offset: 0x00029A58
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000060BF File Offset: 0x000042BF
		public Nullable<int> _ValuesChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__ValuesChanged_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__ValuesChanged_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0002B888 File Offset: 0x00029A88
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x000060ED File Offset: 0x000042ED
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FindReplaceResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr__FormulasChanged_k__BackingField;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr__OccurrencesChanged_k__BackingField;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr__RowsChanged_k__BackingField;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr__SheetsChanged_k__BackingField;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr__ValuesChanged_k__BackingField;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_FormulasChanged_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_set_FormulasChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_get_OccurrencesChanged_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_set_OccurrencesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_get_RowsChanged_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_set_RowsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_SheetsChanged_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_set_SheetsChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_ValuesChanged_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_set_ValuesChanged_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

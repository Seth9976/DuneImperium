using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200003B RID: 59
	public class ChartAxisViewWindowOptions : Object
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// Note: this type is marked as 'beforefieldinit'.
		static ChartAxisViewWindowOptions()
		{
			Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ChartAxisViewWindowOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr);
			ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMax_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, "<ViewWindowMax>k__BackingField");
			ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, "<ViewWindowMin>k__BackingField");
			ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, "<ViewWindowMode>k__BackingField");
			ChartAxisViewWindowOptions.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, "<ETag>k__BackingField");
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMax_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664075);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMax_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664076);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMin_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664077);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMin_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664078);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMode_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664079);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMode_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664080);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664081);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664082);
			ChartAxisViewWindowOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr, 100664083);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001C824 File Offset: 0x0001AA24
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0001C868 File Offset: 0x0001AA68
		public unsafe virtual Nullable<double> ViewWindowMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMax_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMax_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001C8BC File Offset: 0x0001AABC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0001C900 File Offset: 0x0001AB00
		public unsafe virtual Nullable<double> ViewWindowMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMin_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMin_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001C954 File Offset: 0x0001AB54
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0001C998 File Offset: 0x0001AB98
		public unsafe virtual string ViewWindowMode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ViewWindowMode_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ViewWindowMode_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartAxisViewWindowOptions.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChartAxisViewWindowOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartAxisViewWindowOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChartAxisViewWindowOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000421E File Offset: 0x0000241E
		public ChartAxisViewWindowOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00004227 File Offset: 0x00002427
		public Nullable<double> _ViewWindowMax_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMax_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMax_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00004255 File Offset: 0x00002455
		public Nullable<double> _ViewWindowMin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMin_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMin_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001CB18 File Offset: 0x0001AD18
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00004283 File Offset: 0x00002483
		public unsafe string _ViewWindowMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ViewWindowMode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001CB40 File Offset: 0x0001AD40
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000042A2 File Offset: 0x000024A2
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartAxisViewWindowOptions.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr__ViewWindowMax_k__BackingField;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr__ViewWindowMin_k__BackingField;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr__ViewWindowMode_k__BackingField;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewWindowMax_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewWindowMax_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewWindowMin_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewWindowMin_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewWindowMode_Public_Virtual_New_get_String_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewWindowMode_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

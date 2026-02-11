using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000482 RID: 1154
	[Serializable]
	public class EraInfo : Object
	{
		// Token: 0x0600461A RID: 17946 RVA: 0x00148030 File Offset: 0x00146230
		// Note: this type is marked as 'beforefieldinit'.
		static EraInfo()
		{
			Il2CppClassPointerStore<EraInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EraInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EraInfo>.NativeClassPtr);
			EraInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "era");
			EraInfo.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "ticks");
			EraInfo.NativeFieldInfoPtr_yearOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "yearOffset");
			EraInfo.NativeFieldInfoPtr_minEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "minEraYear");
			EraInfo.NativeFieldInfoPtr_maxEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "maxEraYear");
			EraInfo.NativeFieldInfoPtr_eraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "eraName");
			EraInfo.NativeFieldInfoPtr_abbrevEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "abbrevEraName");
			EraInfo.NativeFieldInfoPtr_englishEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "englishEraName");
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100673593);
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100673594);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00148128 File Offset: 0x00146328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410210, XrefRangeEnd = 1410216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x001481C4 File Offset: 0x001463C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1410225, RefRangeEnd = 1410230, XrefRangeStart = 1410216, XrefRangeEnd = 1410225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eraName);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abbrevEraName);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(englishEraName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x0001973F File Offset: 0x0001793F
		public EraInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x0014829C File Offset: 0x0014649C
		// (set) Token: 0x0600461F RID: 17951 RVA: 0x00019748 File Offset: 0x00017948
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06004620 RID: 17952 RVA: 0x001482C4 File Offset: 0x001464C4
		// (set) Token: 0x06004621 RID: 17953 RVA: 0x00019763 File Offset: 0x00017963
		public unsafe long ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x001482EC File Offset: 0x001464EC
		// (set) Token: 0x06004623 RID: 17955 RVA: 0x0001977E File Offset: 0x0001797E
		public unsafe int yearOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset)) = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00148314 File Offset: 0x00146514
		// (set) Token: 0x06004625 RID: 17957 RVA: 0x00019799 File Offset: 0x00017999
		public unsafe int minEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear)) = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x0014833C File Offset: 0x0014653C
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x000197B4 File Offset: 0x000179B4
		public unsafe int maxEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear)) = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x00148364 File Offset: 0x00146564
		// (set) Token: 0x06004629 RID: 17961 RVA: 0x000197CF File Offset: 0x000179CF
		public unsafe string eraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x0014838C File Offset: 0x0014658C
		// (set) Token: 0x0600462B RID: 17963 RVA: 0x000197EE File Offset: 0x000179EE
		public unsafe string abbrevEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x001483B4 File Offset: 0x001465B4
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x0001980D File Offset: 0x00017A0D
		public unsafe string englishEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeFieldInfoPtr_yearOffset;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeFieldInfoPtr_minEraYear;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeFieldInfoPtr_maxEraYear;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeFieldInfoPtr_eraName;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeFieldInfoPtr_abbrevEraName;

		// Token: 0x040039E8 RID: 14824
		private static readonly IntPtr NativeFieldInfoPtr_englishEraName;

		// Token: 0x040039E9 RID: 14825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0;
	}
}

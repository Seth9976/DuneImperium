using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013F RID: 319
	public static class AppContextDefaultValues : Object
	{
		// Token: 0x060015DD RID: 5597 RVA: 0x0008FF20 File Offset: 0x0008E120
		// Note: this type is marked as 'beforefieldinit'.
		static AppContextDefaultValues()
		{
			Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContextDefaultValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr);
			AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceJapaneseEraYearRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr, "SwitchEnforceJapaneseEraYearRanges");
			AppContextDefaultValues.NativeFieldInfoPtr_SwitchFormatJapaneseFirstYearAsANumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr, "SwitchFormatJapaneseFirstYearAsANumber");
			AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceLegacyJapaneseDateParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr, "SwitchEnforceLegacyJapaneseDateParsing");
			AppContextDefaultValues.NativeMethodInfoPtr_PopulateDefaultValues_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr, 100667191);
			AppContextDefaultValues.NativeMethodInfoPtr_TryGetSwitchOverride_Public_Static_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppContextDefaultValues>.NativeClassPtr, 100667192);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0008FFB4 File Offset: 0x0008E1B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateDefaultValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppContextDefaultValues.NativeMethodInfoPtr_PopulateDefaultValues_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0008FFDC File Offset: 0x0008E1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343872, RefRangeEnd = 1343874, XrefRangeStart = 1343872, XrefRangeEnd = 1343872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSwitchOverride(string switchName, out bool overrideValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(switchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &overrideValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppContextDefaultValues.NativeMethodInfoPtr_TryGetSwitchOverride_Public_Static_Boolean_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00006C75 File Offset: 0x00004E75
		public AppContextDefaultValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0009002C File Offset: 0x0008E22C
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00006C7E File Offset: 0x00004E7E
		public unsafe static string SwitchEnforceJapaneseEraYearRanges
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceJapaneseEraYearRanges, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceJapaneseEraYearRanges, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0009004C File Offset: 0x0008E24C
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00006C90 File Offset: 0x00004E90
		public unsafe static string SwitchFormatJapaneseFirstYearAsANumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchFormatJapaneseFirstYearAsANumber, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchFormatJapaneseFirstYearAsANumber, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0009006C File Offset: 0x0008E26C
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00006CA2 File Offset: 0x00004EA2
		public unsafe static string SwitchEnforceLegacyJapaneseDateParsing
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceLegacyJapaneseDateParsing, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextDefaultValues.NativeFieldInfoPtr_SwitchEnforceLegacyJapaneseDateParsing, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeFieldInfoPtr_SwitchEnforceJapaneseEraYearRanges;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeFieldInfoPtr_SwitchFormatJapaneseFirstYearAsANumber;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeFieldInfoPtr_SwitchEnforceLegacyJapaneseDateParsing;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDefaultValues_Public_Static_Void_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSwitchOverride_Public_Static_Boolean_String_byref_Boolean_0;
	}
}

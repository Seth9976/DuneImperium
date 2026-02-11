using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000495 RID: 1173
	[Serializable]
	public class CultureInfo : Object
	{
		// Token: 0x06004879 RID: 18553 RVA: 0x00151414 File Offset: 0x0014F614
		// Note: this type is marked as 'beforefieldinit'.
		static CultureInfo()
		{
			Il2CppClassPointerStore<CultureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr);
			CultureInfo.NativeFieldInfoPtr_invariant_culture_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "invariant_culture_info");
			CultureInfo.NativeFieldInfoPtr_shared_table_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_table_lock");
			CultureInfo.NativeFieldInfoPtr_default_current_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_current_culture");
			CultureInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isReadOnly");
			CultureInfo.NativeFieldInfoPtr_cultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cultureID");
			CultureInfo.NativeFieldInfoPtr_parent_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_lcid");
			CultureInfo.NativeFieldInfoPtr_datetime_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "datetime_index");
			CultureInfo.NativeFieldInfoPtr_number_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "number_index");
			CultureInfo.NativeFieldInfoPtr_default_calendar_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_calendar_type");
			CultureInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_useUserOverride");
			CultureInfo.NativeFieldInfoPtr_numInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "numInfo");
			CultureInfo.NativeFieldInfoPtr_dateTimeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "dateTimeInfo");
			CultureInfo.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textInfo");
			CultureInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_name");
			CultureInfo.NativeFieldInfoPtr_englishname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "englishname");
			CultureInfo.NativeFieldInfoPtr_nativename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "nativename");
			CultureInfo.NativeFieldInfoPtr_iso3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso3lang");
			CultureInfo.NativeFieldInfoPtr_iso2lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso2lang");
			CultureInfo.NativeFieldInfoPtr_win3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "win3lang");
			CultureInfo.NativeFieldInfoPtr_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "territory");
			CultureInfo.NativeFieldInfoPtr_native_calendar_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "native_calendar_names");
			CultureInfo.NativeFieldInfoPtr_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "compareInfo");
			CultureInfo.NativeFieldInfoPtr_textinfo_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textinfo_data");
			CultureInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_dataItem");
			CultureInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "calendar");
			CultureInfo.NativeFieldInfoPtr_parent_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_culture");
			CultureInfo.NativeFieldInfoPtr_constructed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "constructed");
			CultureInfo.NativeFieldInfoPtr_cached_serialized_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cached_serialized_form");
			CultureInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_cultureData");
			CultureInfo.NativeFieldInfoPtr_m_isInherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isInherited");
			CultureInfo.NativeFieldInfoPtr_InvariantCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "InvariantCultureId");
			CultureInfo.NativeFieldInfoPtr_CalendarTypeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "CalendarTypeBits");
			CultureInfo.NativeFieldInfoPtr_LOCALE_INVARIANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "LOCALE_INVARIANT");
			CultureInfo.NativeFieldInfoPtr_MSG_READONLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "MSG_READONLY");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentUICulture");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentCulture");
			CultureInfo.NativeFieldInfoPtr_shared_by_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_number");
			CultureInfo.NativeFieldInfoPtr_shared_by_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_name");
			CultureInfo.NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_UserPreferredCultureInfoInAppX");
			CultureInfo.NativeFieldInfoPtr_IsTaiwanSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "IsTaiwanSku");
			CultureInfo.NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673889);
			CultureInfo.NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673890);
			CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673891);
			CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673892);
			CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673893);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673894);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673895);
			CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673896);
			CultureInfo.NativeMethodInfoPtr_get__name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673897);
			CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673898);
			CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673899);
			CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673900);
			CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673901);
			CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673902);
			CultureInfo.NativeMethodInfoPtr_get_TwoLetterISOLanguageName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673903);
			CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673904);
			CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673905);
			CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673906);
			CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673907);
			CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673908);
			CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673909);
			CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673910);
			CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673911);
			CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673912);
			CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673913);
			CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673914);
			CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673915);
			CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673916);
			CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673917);
			CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673918);
			CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673919);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673920);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673921);
			CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673922);
			CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673923);
			CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673924);
			CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673925);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673926);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673927);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673928);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673929);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673930);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673931);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673932);
			CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673933);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673934);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673935);
			CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673936);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673937);
			CultureInfo.NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673938);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673939);
			CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673940);
			CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673941);
			CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673942);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673943);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673944);
			CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673945);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673946);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673947);
			CultureInfo.NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673948);
			CultureInfo.NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673949);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673950);
			CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673951);
			CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673952);
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x00151C64 File Offset: 0x0014FE64
		public unsafe CultureData _cultureData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x00151CA4 File Offset: 0x0014FEA4
		public unsafe bool _isInherited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x00151CE0 File Offset: 0x0014FEE0
		public unsafe static CultureInfo InvariantCulture
		{
			[CallerCount(704)]
			[CachedScanResults(RefRangeStart = 1412028, RefRangeEnd = 1412732, XrefRangeStart = 1412023, XrefRangeEnd = 1412028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x00151D14 File Offset: 0x0014FF14
		public unsafe static CultureInfo CurrentCulture
		{
			[CallerCount(119)]
			[CachedScanResults(RefRangeStart = 1412735, RefRangeEnd = 1412854, XrefRangeStart = 1412732, XrefRangeEnd = 1412735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x00151D48 File Offset: 0x0014FF48
		public unsafe static CultureInfo CurrentUICulture
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1412857, RefRangeEnd = 1412861, XrefRangeStart = 1412854, XrefRangeEnd = 1412857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00151D7C File Offset: 0x0014FF7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1412890, RefRangeEnd = 1412893, XrefRangeStart = 1412861, XrefRangeEnd = 1412890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentCulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00151DB0 File Offset: 0x0014FFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412893, XrefRangeEnd = 1412897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentUICulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x00151DE4 File Offset: 0x0014FFE4
		public unsafe string Territory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00151E1C File Offset: 0x0015001C
		public unsafe string _name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get__name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x00151E54 File Offset: 0x00150054
		public unsafe virtual int LCID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00151E9C File Offset: 0x0015009C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x00151EE0 File Offset: 0x001500E0
		public unsafe virtual Calendar Calendar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412897, XrefRangeEnd = 1412903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x00151F2C File Offset: 0x0015012C
		public unsafe virtual CultureInfo Parent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412903, XrefRangeEnd = 1412918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x00151F78 File Offset: 0x00150178
		public unsafe virtual TextInfo TextInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412918, XrefRangeEnd = 1412932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x00151FC4 File Offset: 0x001501C4
		public unsafe virtual string TwoLetterISOLanguageName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412932, XrefRangeEnd = 1412933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_TwoLetterISOLanguageName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00152008 File Offset: 0x00150208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412933, XrefRangeEnd = 1412944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00152054 File Offset: 0x00150254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412944, XrefRangeEnd = 1412948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x001520AC File Offset: 0x001502AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1412971, RefRangeEnd = 1412972, XrefRangeStart = 1412948, XrefRangeEnd = 1412971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> GetCultures(CultureTypes types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref types;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x001520EC File Offset: 0x001502EC
		[CallerCount(0)]
		public unsafe CultureInfo.Data GetTextInfoData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00152128 File Offset: 0x00150328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412972, XrefRangeEnd = 1412973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00152170 File Offset: 0x00150370
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x001521B4 File Offset: 0x001503B4
		public unsafe virtual CompareInfo CompareInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412973, XrefRangeEnd = 1412987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x00152200 File Offset: 0x00150400
		public unsafe virtual bool IsNeutralCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412987, XrefRangeEnd = 1412988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00152248 File Offset: 0x00150448
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNeutral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x0015227C File Offset: 0x0015047C
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x001522C8 File Offset: 0x001504C8
		public unsafe virtual NumberFormatInfo NumberFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412988, XrefRangeEnd = 1412996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412996, XrefRangeEnd = 1413011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x00152318 File Offset: 0x00150518
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x00152364 File Offset: 0x00150564
		public unsafe virtual DateTimeFormatInfo DateTimeFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413011, XrefRangeEnd = 1413032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413032, XrefRangeEnd = 1413047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x001523B4 File Offset: 0x001505B4
		public unsafe virtual string EnglishName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413047, XrefRangeEnd = 1413048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x001523F8 File Offset: 0x001505F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413048, XrefRangeEnd = 1413062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00152454 File Offset: 0x00150654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413062, XrefRangeEnd = 1413063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Construct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00152488 File Offset: 0x00150688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413063, XrefRangeEnd = 1413064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_lcid(int lcid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x001524D4 File Offset: 0x001506D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413064, XrefRangeEnd = 1413065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00152524 File Offset: 0x00150724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413065, XrefRangeEnd = 1413066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_current_locale_name()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00152550 File Offset: 0x00150750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413066, XrefRangeEnd = 1413067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> internal_get_cultures(bool neutral, bool specific, bool installed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref neutral;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specific;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref installed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x001525AC File Offset: 0x001507AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413067, XrefRangeEnd = 1413099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInvariant(bool read_only)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref read_only;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x001525EC File Offset: 0x001507EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413099, XrefRangeEnd = 1413103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo CreateTextInfo(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x00152638 File Offset: 0x00150838
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1413104, RefRangeEnd = 1413108, XrefRangeStart = 1413103, XrefRangeEnd = 1413104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00152680 File Offset: 0x00150880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413108, XrefRangeEnd = 1413109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x001526D8 File Offset: 0x001508D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1413118, RefRangeEnd = 1413123, XrefRangeStart = 1413109, XrefRangeEnd = 1413118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0015273C File Offset: 0x0015093C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1413124, RefRangeEnd = 1413136, XrefRangeStart = 1413123, XrefRangeEnd = 1413124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00152788 File Offset: 0x00150988
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1413137, RefRangeEnd = 1413142, XrefRangeStart = 1413136, XrefRangeEnd = 1413137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x001527E4 File Offset: 0x001509E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1413160, RefRangeEnd = 1413166, XrefRangeStart = 1413142, XrefRangeEnd = 1413160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x0015284C File Offset: 0x00150A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413166, XrefRangeEnd = 1413167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00152888 File Offset: 0x00150A88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1413202, RefRangeEnd = 1413204, XrefRangeStart = 1413167, XrefRangeEnd = 1413202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void insert_into_shared_tables(CultureInfo c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x001528C0 File Offset: 0x00150AC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1413228, RefRangeEnd = 1413232, XrefRangeStart = 1413204, XrefRangeEnd = 1413228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(int culture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00152900 File Offset: 0x00150B00
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1413256, RefRangeEnd = 1413269, XrefRangeStart = 1413232, XrefRangeEnd = 1413256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x00152944 File Offset: 0x00150B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1413273, RefRangeEnd = 1413274, XrefRangeStart = 1413269, XrefRangeEnd = 1413273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateCulture(string name, bool reference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00152998 File Offset: 0x00150B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1413290, RefRangeEnd = 1413291, XrefRangeStart = 1413274, XrefRangeEnd = 1413290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCulture(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x001529DC File Offset: 0x00150BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1413295, RefRangeEnd = 1413297, XrefRangeStart = 1413291, XrefRangeEnd = 1413295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ConstructLocaleFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00152A2C File Offset: 0x00150C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1413863, RefRangeEnd = 1413864, XrefRangeStart = 1413297, XrefRangeEnd = 1413863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060048AD RID: 18605 RVA: 0x00152A70 File Offset: 0x00150C70
		public unsafe int CalendarType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1413864, RefRangeEnd = 1413867, XrefRangeStart = 1413864, XrefRangeEnd = 1413864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x00152AAC File Offset: 0x00150CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1413888, RefRangeEnd = 1413889, XrefRangeStart = 1413867, XrefRangeEnd = 1413888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar CreateCalendar(int calendarType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x00152AEC File Offset: 0x00150CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413889, XrefRangeEnd = 1413900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNotFoundException(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x00152B30 File Offset: 0x00150D30
		public unsafe static CultureInfo DefaultThreadCurrentCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413900, XrefRangeEnd = 1413905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x00152B64 File Offset: 0x00150D64
		public unsafe static CultureInfo DefaultThreadCurrentUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413905, XrefRangeEnd = 1413910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x00152B98 File Offset: 0x00150D98
		public unsafe string SortName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x00152BD0 File Offset: 0x00150DD0
		public unsafe static CultureInfo UserDefaultUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413910, XrefRangeEnd = 1413917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00152C04 File Offset: 0x00150E04
		public unsafe static CultureInfo UserDefaultCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413917, XrefRangeEnd = 1413921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x00152C38 File Offset: 0x00150E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413921, XrefRangeEnd = 1413923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onCultureInfoChangedInAppX);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00152C70 File Offset: 0x00150E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413923, XrefRangeEnd = 1413936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCultureInfoChangedInAppX(string language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00152CA8 File Offset: 0x00150EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413936, XrefRangeEnd = 1413956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x00152CDC File Offset: 0x00150EDC
		public unsafe bool HasInvariantCultureName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1413966, RefRangeEnd = 1413972, XrefRangeStart = 1413956, XrefRangeEnd = 1413966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00152D18 File Offset: 0x00150F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1413978, RefRangeEnd = 1413979, XrefRangeStart = 1413972, XrefRangeEnd = 1413978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyCultureName(string cultureName, bool throwException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0001A626 File Offset: 0x00018826
		public CultureInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x00152D68 File Offset: 0x00150F68
		// (set) Token: 0x060048BC RID: 18620 RVA: 0x0001A62F File Offset: 0x0001882F
		public unsafe static CultureInfo invariant_culture_info
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060048BD RID: 18621 RVA: 0x00152D90 File Offset: 0x00150F90
		// (set) Token: 0x060048BE RID: 18622 RVA: 0x0001A641 File Offset: 0x00018841
		public unsafe static Object shared_table_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060048BF RID: 18623 RVA: 0x00152DB8 File Offset: 0x00150FB8
		// (set) Token: 0x060048C0 RID: 18624 RVA: 0x0001A653 File Offset: 0x00018853
		public unsafe static CultureInfo default_current_culture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x00152DE0 File Offset: 0x00150FE0
		// (set) Token: 0x060048C2 RID: 18626 RVA: 0x0001A665 File Offset: 0x00018865
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x00152E08 File Offset: 0x00151008
		// (set) Token: 0x060048C4 RID: 18628 RVA: 0x0001A680 File Offset: 0x00018880
		public unsafe int cultureID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID)) = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x00152E30 File Offset: 0x00151030
		// (set) Token: 0x060048C6 RID: 18630 RVA: 0x0001A69B File Offset: 0x0001889B
		public unsafe int parent_lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid)) = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x00152E58 File Offset: 0x00151058
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x0001A6B6 File Offset: 0x000188B6
		public unsafe int datetime_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index)) = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00152E80 File Offset: 0x00151080
		// (set) Token: 0x060048CA RID: 18634 RVA: 0x0001A6D1 File Offset: 0x000188D1
		public unsafe int number_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index)) = value;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00152EA8 File Offset: 0x001510A8
		// (set) Token: 0x060048CC RID: 18636 RVA: 0x0001A6EC File Offset: 0x000188EC
		public unsafe int default_calendar_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type)) = value;
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00152ED0 File Offset: 0x001510D0
		// (set) Token: 0x060048CE RID: 18638 RVA: 0x0001A707 File Offset: 0x00018907
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x00152EF8 File Offset: 0x001510F8
		// (set) Token: 0x060048D0 RID: 18640 RVA: 0x0001A722 File Offset: 0x00018922
		public unsafe NumberFormatInfo numInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x00152F28 File Offset: 0x00151128
		// (set) Token: 0x060048D2 RID: 18642 RVA: 0x0001A741 File Offset: 0x00018941
		public unsafe DateTimeFormatInfo dateTimeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x00152F58 File Offset: 0x00151158
		// (set) Token: 0x060048D4 RID: 18644 RVA: 0x0001A760 File Offset: 0x00018960
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x00152F88 File Offset: 0x00151188
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x0001A77F File Offset: 0x0001897F
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00152FB0 File Offset: 0x001511B0
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x0001A79E File Offset: 0x0001899E
		public unsafe string englishname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x00152FD8 File Offset: 0x001511D8
		// (set) Token: 0x060048DA RID: 18650 RVA: 0x0001A7BD File Offset: 0x000189BD
		public unsafe string nativename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x00153000 File Offset: 0x00151200
		// (set) Token: 0x060048DC RID: 18652 RVA: 0x0001A7DC File Offset: 0x000189DC
		public unsafe string iso3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x00153028 File Offset: 0x00151228
		// (set) Token: 0x060048DE RID: 18654 RVA: 0x0001A7FB File Offset: 0x000189FB
		public unsafe string iso2lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x00153050 File Offset: 0x00151250
		// (set) Token: 0x060048E0 RID: 18656 RVA: 0x0001A81A File Offset: 0x00018A1A
		public unsafe string win3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x00153078 File Offset: 0x00151278
		// (set) Token: 0x060048E2 RID: 18658 RVA: 0x0001A839 File Offset: 0x00018A39
		public unsafe string territory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x001530A0 File Offset: 0x001512A0
		// (set) Token: 0x060048E4 RID: 18660 RVA: 0x0001A858 File Offset: 0x00018A58
		public unsafe Il2CppStringArray native_calendar_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x001530D0 File Offset: 0x001512D0
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x0001A877 File Offset: 0x00018A77
		public unsafe CompareInfo compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x00153100 File Offset: 0x00151300
		// (set) Token: 0x060048E8 RID: 18664 RVA: 0x0001A896 File Offset: 0x00018A96
		public unsafe void* textinfo_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data)) = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x00153124 File Offset: 0x00151324
		// (set) Token: 0x060048EA RID: 18666 RVA: 0x0001A8B1 File Offset: 0x00018AB1
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0015314C File Offset: 0x0015134C
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x0001A8CC File Offset: 0x00018ACC
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x0015317C File Offset: 0x0015137C
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x0001A8EB File Offset: 0x00018AEB
		public unsafe CultureInfo parent_culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x001531AC File Offset: 0x001513AC
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x0001A90A File Offset: 0x00018B0A
		public unsafe bool constructed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed)) = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x001531D4 File Offset: 0x001513D4
		// (set) Token: 0x060048F2 RID: 18674 RVA: 0x0001A925 File Offset: 0x00018B25
		public unsafe Il2CppStructArray<byte> cached_serialized_form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x00153204 File Offset: 0x00151404
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x0001A944 File Offset: 0x00018B44
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x00153234 File Offset: 0x00151434
		// (set) Token: 0x060048F6 RID: 18678 RVA: 0x0001A963 File Offset: 0x00018B63
		public unsafe bool m_isInherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited)) = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x0015325C File Offset: 0x0015145C
		// (set) Token: 0x060048F8 RID: 18680 RVA: 0x0001A97E File Offset: 0x00018B7E
		public unsafe static int InvariantCultureId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&value));
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x00153278 File Offset: 0x00151478
		// (set) Token: 0x060048FA RID: 18682 RVA: 0x0001A98C File Offset: 0x00018B8C
		public unsafe static int CalendarTypeBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&value));
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x00153294 File Offset: 0x00151494
		// (set) Token: 0x060048FC RID: 18684 RVA: 0x0001A99A File Offset: 0x00018B9A
		public unsafe static int LOCALE_INVARIANT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_LOCALE_INVARIANT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_LOCALE_INVARIANT, (void*)(&value));
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x001532B0 File Offset: 0x001514B0
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		public unsafe static string MSG_READONLY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x001532D0 File Offset: 0x001514D0
		// (set) Token: 0x06004900 RID: 18688 RVA: 0x0001A9BA File Offset: 0x00018BBA
		public unsafe static CultureInfo s_DefaultThreadCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x001532F8 File Offset: 0x001514F8
		// (set) Token: 0x06004902 RID: 18690 RVA: 0x0001A9CC File Offset: 0x00018BCC
		public unsafe static CultureInfo s_DefaultThreadCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x00153320 File Offset: 0x00151520
		// (set) Token: 0x06004904 RID: 18692 RVA: 0x0001A9DE File Offset: 0x00018BDE
		public unsafe static Dictionary<int, CultureInfo> shared_by_number
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x00153348 File Offset: 0x00151548
		// (set) Token: 0x06004906 RID: 18694 RVA: 0x0001A9F0 File Offset: 0x00018BF0
		public unsafe static Dictionary<string, CultureInfo> shared_by_name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x00153370 File Offset: 0x00151570
		// (set) Token: 0x06004908 RID: 18696 RVA: 0x0001AA02 File Offset: 0x00018C02
		public unsafe static CultureInfo s_UserPreferredCultureInfoInAppX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x00153398 File Offset: 0x00151598
		// (set) Token: 0x0600490A RID: 18698 RVA: 0x0001AA14 File Offset: 0x00018C14
		public unsafe static bool IsTaiwanSku
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&value));
			}
		}

		// Token: 0x04003B93 RID: 15251
		private static readonly IntPtr NativeFieldInfoPtr_invariant_culture_info;

		// Token: 0x04003B94 RID: 15252
		private static readonly IntPtr NativeFieldInfoPtr_shared_table_lock;

		// Token: 0x04003B95 RID: 15253
		private static readonly IntPtr NativeFieldInfoPtr_default_current_culture;

		// Token: 0x04003B96 RID: 15254
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04003B97 RID: 15255
		private static readonly IntPtr NativeFieldInfoPtr_cultureID;

		// Token: 0x04003B98 RID: 15256
		private static readonly IntPtr NativeFieldInfoPtr_parent_lcid;

		// Token: 0x04003B99 RID: 15257
		private static readonly IntPtr NativeFieldInfoPtr_datetime_index;

		// Token: 0x04003B9A RID: 15258
		private static readonly IntPtr NativeFieldInfoPtr_number_index;

		// Token: 0x04003B9B RID: 15259
		private static readonly IntPtr NativeFieldInfoPtr_default_calendar_type;

		// Token: 0x04003B9C RID: 15260
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeFieldInfoPtr_numInfo;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeInfo;

		// Token: 0x04003B9F RID: 15263
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x04003BA0 RID: 15264
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04003BA1 RID: 15265
		private static readonly IntPtr NativeFieldInfoPtr_englishname;

		// Token: 0x04003BA2 RID: 15266
		private static readonly IntPtr NativeFieldInfoPtr_nativename;

		// Token: 0x04003BA3 RID: 15267
		private static readonly IntPtr NativeFieldInfoPtr_iso3lang;

		// Token: 0x04003BA4 RID: 15268
		private static readonly IntPtr NativeFieldInfoPtr_iso2lang;

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_win3lang;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_territory;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_native_calendar_names;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_compareInfo;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_textinfo_data;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeFieldInfoPtr_parent_culture;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeFieldInfoPtr_constructed;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeFieldInfoPtr_cached_serialized_form;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_m_isInherited;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_InvariantCultureId;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeFieldInfoPtr_CalendarTypeBits;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeFieldInfoPtr_LOCALE_INVARIANT;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeFieldInfoPtr_MSG_READONLY;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentCulture;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_number;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_name;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeFieldInfoPtr_IsTaiwanSku;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_get_Territory_Internal_get_String_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_get__name_Internal_get_String_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoLetterISOLanguageName_Public_Virtual_New_get_String_0;

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0;

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfoData_Private_Data_0;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeMethodInfoPtr_CheckNeutral_Private_Void_0;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0;

		// Token: 0x04003BD4 RID: 15316
		private static readonly IntPtr NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0;

		// Token: 0x04003BD5 RID: 15317
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0;

		// Token: 0x04003BD6 RID: 15318
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0;

		// Token: 0x04003BD7 RID: 15319
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04003BD8 RID: 15320
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0;

		// Token: 0x04003BD9 RID: 15321
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Private_Void_0;

		// Token: 0x04003BDA RID: 15322
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0;

		// Token: 0x04003BDB RID: 15323
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0;

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0;

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0;

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0;

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003BE2 RID: 15330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0;

		// Token: 0x04003BE3 RID: 15331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003BE4 RID: 15332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04003BE5 RID: 15333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0;

		// Token: 0x04003BE6 RID: 15334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0;

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0;

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0;

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeMethodInfoPtr_get_SortName_Internal_get_String_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0;

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0;

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0;

		// Token: 0x020006DA RID: 1754
		[StructLayout(2)]
		public struct Data
		{
			// Token: 0x06005D58 RID: 23896 RVA: 0x001A662C File Offset: 0x001A482C
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr);
				CultureInfo.Data.NativeFieldInfoPtr_ansi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ansi");
				CultureInfo.Data.NativeFieldInfoPtr_ebcdic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ebcdic");
				CultureInfo.Data.NativeFieldInfoPtr_mac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "mac");
				CultureInfo.Data.NativeFieldInfoPtr_oem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "oem");
				CultureInfo.Data.NativeFieldInfoPtr_right_to_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "right_to_left");
				CultureInfo.Data.NativeFieldInfoPtr_list_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "list_sep");
			}

			// Token: 0x06005D59 RID: 23897 RVA: 0x00022163 File Offset: 0x00020363
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, ref this));
			}

			// Token: 0x04004C14 RID: 19476
			private static readonly IntPtr NativeFieldInfoPtr_ansi;

			// Token: 0x04004C15 RID: 19477
			private static readonly IntPtr NativeFieldInfoPtr_ebcdic;

			// Token: 0x04004C16 RID: 19478
			private static readonly IntPtr NativeFieldInfoPtr_mac;

			// Token: 0x04004C17 RID: 19479
			private static readonly IntPtr NativeFieldInfoPtr_oem;

			// Token: 0x04004C18 RID: 19480
			private static readonly IntPtr NativeFieldInfoPtr_right_to_left;

			// Token: 0x04004C19 RID: 19481
			private static readonly IntPtr NativeFieldInfoPtr_list_sep;

			// Token: 0x04004C1A RID: 19482
			[FieldOffset(0)]
			public int ansi;

			// Token: 0x04004C1B RID: 19483
			[FieldOffset(4)]
			public int ebcdic;

			// Token: 0x04004C1C RID: 19484
			[FieldOffset(8)]
			public int mac;

			// Token: 0x04004C1D RID: 19485
			[FieldOffset(12)]
			public int oem;

			// Token: 0x04004C1E RID: 19486
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool right_to_left;

			// Token: 0x04004C1F RID: 19487
			[FieldOffset(17)]
			public byte list_sep;
		}

		// Token: 0x020006DB RID: 1755
		public sealed class OnCultureInfoChangedDelegate : MulticastDelegate
		{
			// Token: 0x06005D5A RID: 23898 RVA: 0x00022175 File Offset: 0x00020375
			// Note: this type is marked as 'beforefieldinit'.
			static OnCultureInfoChangedDelegate()
			{
				Il2CppClassPointerStore<CultureInfo.OnCultureInfoChangedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "OnCultureInfoChangedDelegate");
				CultureInfo.OnCultureInfoChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo.OnCultureInfoChangedDelegate>.NativeClassPtr, 100673954);
				CultureInfo.OnCultureInfoChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo.OnCultureInfoChangedDelegate>.NativeClassPtr, 100673955);
			}

			// Token: 0x06005D5B RID: 23899 RVA: 0x001A66D0 File Offset: 0x001A48D0
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCultureInfoChangedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo.OnCultureInfoChangedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.OnCultureInfoChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D5C RID: 23900 RVA: 0x001A672C File Offset: 0x001A492C
			[CallerCount(0)]
			public unsafe void Invoke(string language)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.OnCultureInfoChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005D5D RID: 23901 RVA: 0x000221B3 File Offset: 0x000203B3
			public OnCultureInfoChangedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005D5E RID: 23902 RVA: 0x000221BC File Offset: 0x000203BC
			public static implicit operator CultureInfo.OnCultureInfoChangedDelegate(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<CultureInfo.OnCultureInfoChangedDelegate>(A_0);
			}

			// Token: 0x06005D5F RID: 23903 RVA: 0x000221C4 File Offset: 0x000203C4
			public static CultureInfo.OnCultureInfoChangedDelegate operator +(CultureInfo.OnCultureInfoChangedDelegate A_0, CultureInfo.OnCultureInfoChangedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CultureInfo.OnCultureInfoChangedDelegate>();
			}

			// Token: 0x06005D60 RID: 23904 RVA: 0x000221D2 File Offset: 0x000203D2
			public static CultureInfo.OnCultureInfoChangedDelegate operator -(CultureInfo.OnCultureInfoChangedDelegate A_0, CultureInfo.OnCultureInfoChangedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CultureInfo.OnCultureInfoChangedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004C20 RID: 19488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004C21 RID: 19489
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;
		}
	}
}

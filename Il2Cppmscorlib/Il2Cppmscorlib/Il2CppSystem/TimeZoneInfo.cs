using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000057 RID: 87
	[Serializable]
	public sealed class TimeZoneInfo : Object
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x0003C03C File Offset: 0x0003A23C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneInfo()
		{
			Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr);
			TimeZoneInfo.NativeFieldInfoPtr_lazyHaveRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "lazyHaveRegistry");
			TimeZoneInfo.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_id");
			TimeZoneInfo.NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_displayName");
			TimeZoneInfo.NativeFieldInfoPtr__standardDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_standardDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr__daylightDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_daylightDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr__baseUtcOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_baseUtcOffset");
			TimeZoneInfo.NativeFieldInfoPtr__supportsDaylightSavingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_supportsDaylightSavingTime");
			TimeZoneInfo.NativeFieldInfoPtr__adjustmentRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_adjustmentRules");
			TimeZoneInfo.NativeFieldInfoPtr_s_utcTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_utcTimeZone");
			TimeZoneInfo.NativeFieldInfoPtr_s_cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_cachedData");
			TimeZoneInfo.NativeFieldInfoPtr_s_maxDateOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_maxDateOnly");
			TimeZoneInfo.NativeFieldInfoPtr_s_minDateOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_minDateOnly");
			TimeZoneInfo.NativeFieldInfoPtr_MaxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "MaxOffset");
			TimeZoneInfo.NativeFieldInfoPtr_MinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "MinOffset");
			TimeZoneInfo.NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664147);
			TimeZoneInfo.NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664148);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664149);
			TimeZoneInfo.NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664150);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664151);
			TimeZoneInfo.NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664152);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664153);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664154);
			TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664155);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664156);
			TimeZoneInfo.NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664157);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664158);
			TimeZoneInfo.NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664159);
			TimeZoneInfo.NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664160);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664161);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664162);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664163);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664164);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664165);
			TimeZoneInfo.NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664166);
			TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664167);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664168);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664169);
			TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664170);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664171);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664172);
			TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664173);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664174);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664175);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664176);
			TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664177);
			TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664178);
			TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664179);
			TimeZoneInfo.NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664180);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664181);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664182);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664183);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664184);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664185);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664186);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664187);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664188);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664189);
			TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664190);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664191);
			TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664192);
			TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664193);
			TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664194);
			TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664195);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664196);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664197);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664198);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664199);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664200);
			TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664201);
			TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664202);
			TimeZoneInfo.NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664203);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664204);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664205);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664206);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664207);
			TimeZoneInfo.NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664208);
			TimeZoneInfo.NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664209);
			TimeZoneInfo.NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664210);
			TimeZoneInfo.NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664211);
			TimeZoneInfo.NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664212);
			TimeZoneInfo.NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664213);
			TimeZoneInfo.NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664214);
			TimeZoneInfo.NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664215);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664216);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664217);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664218);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664219);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664220);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664221);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664222);
			TimeZoneInfo.NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664223);
			TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664224);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664225);
			TimeZoneInfo.NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664226);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664228);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0003C7D8 File Offset: 0x0003A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294852, XrefRangeEnd = 1294861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateAllSystemTimeZones(TimeZoneInfo.CachedData cachedData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0003C810 File Offset: 0x0003AA10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294880, RefRangeEnd = 1294882, XrefRangeStart = 1294861, XrefRangeEnd = 1294880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateAllSystemTimeZonesFromRegistry(TimeZoneInfo.CachedData cachedData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0003C848 File Offset: 0x0003AA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294915, RefRangeEnd = 1294917, XrefRangeStart = 1294882, XrefRangeEnd = 1294915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &zone;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294917, XrefRangeEnd = 1294918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckDaylightSavingTimeNotSupported([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0003C8E0 File Offset: 0x0003AAE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1294945, RefRangeEnd = 1294949, XrefRangeStart = 1294918, XrefRangeEnd = 1294945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation([In] ref Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZoneInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultBaseUtcOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0003C94C File Offset: 0x0003AB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294949, XrefRangeEnd = 1294969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindIdFromTimeZoneInformation([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZone;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0003C994 File Offset: 0x0003AB94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294981, RefRangeEnd = 1294982, XrefRangeStart = 1294969, XrefRangeEnd = 1294981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294992, RefRangeEnd = 1294994, XrefRangeStart = 1294982, XrefRangeEnd = 1294992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetLocalTimeZoneFromWin32Data([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZoneInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0003CA28 File Offset: 0x0003AC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295043, RefRangeEnd = 1295044, XrefRangeStart = 1294994, XrefRangeEnd = 1295043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0003CA74 File Offset: 0x0003AC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295053, RefRangeEnd = 1295055, XrefRangeStart = 1295044, XrefRangeEnd = 1295053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransitionTimeFromTimeZoneInformation([In] ref Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZoneInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartDate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0003CAD0 File Offset: 0x0003ACD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295156, RefRangeEnd = 1295157, XrefRangeStart = 1295055, XrefRangeEnd = 1295156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreateAdjustmentRules(string id, [In] ref Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> rules, out Exception e, int defaultBaseUtcOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &defaultTimeZoneInformation;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultBaseUtcOffset;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			rules = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			e = ((intPtr6 == 0) ? null : new Exception(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0003CB74 File Offset: 0x0003AD74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295161, RefRangeEnd = 1295163, XrefRangeStart = 1295157, XrefRangeEnd = 1295161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtzi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0003CBD8 File Offset: 0x0003ADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295163, XrefRangeEnd = 1295164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCompareStandardDate([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, [In] ref Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZone;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &registryTimeZoneInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0003CC24 File Offset: 0x0003AE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295211, RefRangeEnd = 1295212, XrefRangeStart = 1295164, XrefRangeEnd = 1295211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCompareTimeZoneInformationToRegistry([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &timeZone;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstDisabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0003CC84 File Offset: 0x0003AE84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1295239, RefRangeEnd = 1295242, XrefRangeStart = 1295212, XrefRangeEnd = 1295239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryGetLocalizedNameByMuiNativeResource(string resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0003CCC0 File Offset: 0x0003AEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295250, RefRangeEnd = 1295251, XrefRangeStart = 1295242, XrefRangeEnd = 1295250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295314, RefRangeEnd = 1295315, XrefRangeStart = 1295251, XrefRangeEnd = 1295314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			displayName = IL2CPP.Il2CppStringToManaged(intPtr);
			standardName = IL2CPP.Il2CppStringToManaged(intPtr2);
			daylightName = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0003CD94 File Offset: 0x0003AF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295315, XrefRangeEnd = 1295324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			value = ((intPtr5 == 0) ? null : new TimeZoneInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			e = ((intPtr6 == 0) ? null : new Exception(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0003CE1C File Offset: 0x0003B01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295324, XrefRangeEnd = 1295381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			value = ((intPtr5 == 0) ? null : new TimeZoneInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			e = ((intPtr6 == 0) ? null : new Exception(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0003CEA4 File Offset: 0x0003B0A4
		public unsafe static bool HaveRegistry
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1295389, RefRangeEnd = 1295394, XrefRangeStart = 1295381, XrefRangeEnd = 1295389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295394, XrefRangeEnd = 1295400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lpTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0003CF34 File Offset: 0x0003B134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295400, XrefRangeEnd = 1295406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0003CF88 File Offset: 0x0003B188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295406, XrefRangeEnd = 1295412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(lpTimeZoneInformation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &FirstYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &LastYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1295418, RefRangeEnd = 1295421, XrefRangeStart = 1295412, XrefRangeEnd = 1295418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wYear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pdtzi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ptzi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0003D048 File Offset: 0x0003B248
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1295448, RefRangeEnd = 1295452, XrefRangeStart = 1295421, XrefRangeEnd = 1295448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultBaseUtcOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0003D0B8 File Offset: 0x0003B2B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295462, RefRangeEnd = 1295464, XrefRangeStart = 1295452, XrefRangeEnd = 1295462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartDate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0003D11C File Offset: 0x0003B31C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295546, RefRangeEnd = 1295548, XrefRangeStart = 1295464, XrefRangeEnd = 1295546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0003D168 File Offset: 0x0003B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295548, XrefRangeEnd = 1295578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0003D19C File Offset: 0x0003B39C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295595, RefRangeEnd = 1295597, XrefRangeStart = 1295578, XrefRangeEnd = 1295595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295683, RefRangeEnd = 1295685, XrefRangeStart = 1295597, XrefRangeEnd = 1295683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemTimeZonesWinRTFallback(TimeZoneInfo.CachedData cachedData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0003D218 File Offset: 0x0003B418
		public unsafe string Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0003D250 File Offset: 0x0003B450
		public unsafe string DisplayName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295685, XrefRangeEnd = 1295687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0003D288 File Offset: 0x0003B488
		public unsafe TimeSpan BaseUtcOffset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0003D2C4 File Offset: 0x0003B4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1295695, RefRangeEnd = 1295698, XrefRangeStart = 1295687, XrefRangeEnd = 1295695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ruleIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0003D32C File Offset: 0x0003B52C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1295703, RefRangeEnd = 1295712, XrefRangeStart = 1295698, XrefRangeEnd = 1295703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0003D378 File Offset: 0x0003B578
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1295719, RefRangeEnd = 1295725, XrefRangeStart = 1295712, XrefRangeEnd = 1295719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295730, RefRangeEnd = 1295732, XrefRangeStart = 1295725, XrefRangeEnd = 1295730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0003D41C File Offset: 0x0003B61C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1295744, RefRangeEnd = 1295747, XrefRangeStart = 1295732, XrefRangeEnd = 1295744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0003D488 File Offset: 0x0003B688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295747, XrefRangeEnd = 1295752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0003D4F8 File Offset: 0x0003B6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295787, RefRangeEnd = 1295789, XrefRangeStart = 1295752, XrefRangeEnd = 1295787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0003D57C File Offset: 0x0003B77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295801, RefRangeEnd = 1295802, XrefRangeStart = 1295789, XrefRangeEnd = 1295801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0003D5C8 File Offset: 0x0003B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295802, XrefRangeEnd = 1295804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0003D618 File Offset: 0x0003B818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295804, XrefRangeEnd = 1295808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0003D668 File Offset: 0x0003B868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295808, XrefRangeEnd = 1295816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1295876, RefRangeEnd = 1295877, XrefRangeStart = 1295816, XrefRangeEnd = 1295876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr3) : null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0003D6D8 File Offset: 0x0003B8D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1295899, RefRangeEnd = 1295901, XrefRangeStart = 1295877, XrefRangeEnd = 1295899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameRules(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0003D728 File Offset: 0x0003B928
		public unsafe static TimeZoneInfo Local
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1295907, RefRangeEnd = 1295921, XrefRangeStart = 1295901, XrefRangeEnd = 1295907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0003D75C File Offset: 0x0003B95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0003D794 File Offset: 0x0003B994
		public unsafe static TimeZoneInfo Utc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295921, XrefRangeEnd = 1295925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1295936, RefRangeEnd = 1295941, XrefRangeStart = 1295925, XrefRangeEnd = 1295936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableDaylightSavingTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0003D87C File Offset: 0x0003BA7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1295945, RefRangeEnd = 1295950, XrefRangeStart = 1295941, XrefRangeEnd = 1295945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295950, XrefRangeEnd = 1295954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0003D938 File Offset: 0x0003BB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295954, XrefRangeEnd = 1295978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0003D994 File Offset: 0x0003BB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1295978, XrefRangeEnd = 1296051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296051, XrefRangeEnd = 1296052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<int> ruleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ruleIndex = ((intPtr4 == 0) ? null : new Nullable<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr5) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0003DA68 File Offset: 0x0003BC68
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1296066, RefRangeEnd = 1296074, XrefRangeStart = 1296052, XrefRangeEnd = 1296066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<int> ruleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeisUtc;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ruleIndex = ((intPtr4 == 0) ? null : new Nullable<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr5) : null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296097, RefRangeEnd = 1296098, XrefRangeStart = 1296074, XrefRangeEnd = 1296097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousRule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateOnly;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeisUtc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0003DB74 File Offset: 0x0003BD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296098, XrefRangeEnd = 1296099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0003DBDC File Offset: 0x0003BDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296099, XrefRangeEnd = 1296100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0003DC44 File Offset: 0x0003BE44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1296119, RefRangeEnd = 1296125, XrefRangeStart = 1296100, XrefRangeEnd = 1296119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToUtc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296125, XrefRangeEnd = 1296167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0003DD18 File Offset: 0x0003BF18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1296177, RefRangeEnd = 1296182, XrefRangeStart = 1296167, XrefRangeEnd = 1296177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ruleIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296244, RefRangeEnd = 1296246, XrefRangeStart = 1296182, XrefRangeEnd = 1296244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0003DDF8 File Offset: 0x0003BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296246, XrefRangeEnd = 1296256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseUtcOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ruleIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0003DE6C File Offset: 0x0003C06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296256, XrefRangeEnd = 1296262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseUtcOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0003DEC8 File Offset: 0x0003C0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296380, RefRangeEnd = 1296382, XrefRangeStart = 1296262, XrefRangeEnd = 1296380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref utc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ruleIndex));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0003DF70 File Offset: 0x0003C170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296405, RefRangeEnd = 1296407, XrefRangeStart = 1296382, XrefRangeEnd = 1296405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreYearAdjustment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0003DFEC File Offset: 0x0003C1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296457, RefRangeEnd = 1296458, XrefRangeStart = 1296407, XrefRangeEnd = 1296457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0003E04C File Offset: 0x0003C24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296508, RefRangeEnd = 1296509, XrefRangeStart = 1296458, XrefRangeEnd = 1296508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0003E0AC File Offset: 0x0003C2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296509, XrefRangeEnd = 1296530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0003E10C File Offset: 0x0003C30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296537, RefRangeEnd = 1296538, XrefRangeStart = 1296530, XrefRangeEnd = 1296537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0003E15C File Offset: 0x0003C35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296542, RefRangeEnd = 1296543, XrefRangeStart = 1296538, XrefRangeEnd = 1296542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDaylightSavings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0003E1BC File Offset: 0x0003C3BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1296586, RefRangeEnd = 1296590, XrefRangeStart = 1296543, XrefRangeEnd = 1296586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDaylightSavings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0003E228 File Offset: 0x0003C428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296624, RefRangeEnd = 1296626, XrefRangeStart = 1296590, XrefRangeEnd = 1296624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0003E274 File Offset: 0x0003C474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296639, RefRangeEnd = 1296641, XrefRangeStart = 1296626, XrefRangeEnd = 1296639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstDisabled;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysFallbackToLocalMachine;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			value = ((intPtr5 == 0) ? null : new TimeZoneInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			e = ((intPtr6 == 0) ? null : new Exception(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0003E32C File Offset: 0x0003C52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296641, XrefRangeEnd = 1296677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstDisabled;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedData);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			value = ((intPtr5 == 0) ? null : new TimeZoneInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			e = ((intPtr6 == 0) ? null : new Exception(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0003E3D4 File Offset: 0x0003C5D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1296692, RefRangeEnd = 1296695, XrefRangeStart = 1296677, XrefRangeEnd = 1296692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, out bool adjustmentRulesSupportDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &adjustmentRulesSupportDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0003E438 File Offset: 0x0003C638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296703, RefRangeEnd = 1296705, XrefRangeStart = 1296695, XrefRangeEnd = 1296703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0003E478 File Offset: 0x0003C678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296705, XrefRangeEnd = 1296717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseUtcOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296732, RefRangeEnd = 1296733, XrefRangeStart = 1296717, XrefRangeEnd = 1296732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseUtcOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0003E518 File Offset: 0x0003C718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296733, XrefRangeEnd = 1296736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000399A File Offset: 0x00001B9A
		public TimeZoneInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0003E554 File Offset: 0x0003C754
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x000039A3 File Offset: 0x00001BA3
		public unsafe static Lazy<bool> lazyHaveRegistry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_lazyHaveRegistry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_lazyHaveRegistry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0003E57C File Offset: 0x0003C77C
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x000039B5 File Offset: 0x00001BB5
		public unsafe string _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000039D4 File Offset: 0x00001BD4
		public unsafe string _displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0003E5CC File Offset: 0x0003C7CC
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000039F3 File Offset: 0x00001BF3
		public unsafe string _standardDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__standardDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__standardDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0003E5F4 File Offset: 0x0003C7F4
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00003A12 File Offset: 0x00001C12
		public unsafe string _daylightDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__daylightDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__daylightDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0003E61C File Offset: 0x0003C81C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003A31 File Offset: 0x00001C31
		public unsafe TimeSpan _baseUtcOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__baseUtcOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__baseUtcOffset)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0003E644 File Offset: 0x0003C844
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003A4C File Offset: 0x00001C4C
		public unsafe bool _supportsDaylightSavingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__supportsDaylightSavingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__supportsDaylightSavingTime)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0003E66C File Offset: 0x0003C86C
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003A67 File Offset: 0x00001C67
		public unsafe Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> _adjustmentRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__adjustmentRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr__adjustmentRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0003E69C File Offset: 0x0003C89C
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003A86 File Offset: 0x00001C86
		public unsafe static TimeZoneInfo s_utcTimeZone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_s_utcTimeZone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_s_utcTimeZone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003A98 File Offset: 0x00001C98
		public unsafe static TimeZoneInfo.CachedData s_cachedData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_s_cachedData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.CachedData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_s_cachedData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0003E6EC File Offset: 0x0003C8EC
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00003AAA File Offset: 0x00001CAA
		public unsafe static DateTime s_maxDateOnly
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_s_maxDateOnly, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_s_maxDateOnly, (void*)(&value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0003E708 File Offset: 0x0003C908
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public unsafe static DateTime s_minDateOnly
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_s_minDateOnly, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_s_minDateOnly, (void*)(&value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0003E724 File Offset: 0x0003C924
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00003AC6 File Offset: 0x00001CC6
		public unsafe static TimeSpan MaxOffset
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_MaxOffset, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_MaxOffset, (void*)(&value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0003E740 File Offset: 0x0003C940
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public unsafe static TimeSpan MinOffset
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_MinOffset, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_MinOffset, (void*)(&value));
			}
		}

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_lazyHaveRegistry;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr__displayName;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr__standardDisplayName;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr__daylightDisplayName;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr__baseUtcOffset;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr__supportsDaylightSavingTime;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr__adjustmentRules;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_s_utcTimeZone;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedData;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_s_maxDateOnly;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_s_minDateOnly;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_MaxOffset;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_MinOffset;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0200057B RID: 1403
		public sealed class CachedData : Object
		{
			// Token: 0x06005609 RID: 22025 RVA: 0x0018D8C4 File Offset: 0x0018BAC4
			// Note: this type is marked as 'beforefieldinit'.
			static CachedData()
			{
				Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "CachedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr);
				TimeZoneInfo.CachedData.NativeFieldInfoPtr__oneYearLocalFromUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, "_oneYearLocalFromUtc");
				TimeZoneInfo.CachedData.NativeFieldInfoPtr__localTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, "_localTimeZone");
				TimeZoneInfo.CachedData.NativeFieldInfoPtr__systemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, "_systemTimeZones");
				TimeZoneInfo.CachedData.NativeFieldInfoPtr__readOnlySystemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, "_readOnlySystemTimeZones");
				TimeZoneInfo.CachedData.NativeFieldInfoPtr__allSystemTimeZonesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, "_allSystemTimeZonesRead");
				TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664229);
				TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664230);
				TimeZoneInfo.CachedData.NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664231);
				TimeZoneInfo.CachedData.NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664232);
				TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664233);
				TimeZoneInfo.CachedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr, 100664234);
			}

			// Token: 0x0600560A RID: 22026 RVA: 0x0018D9CC File Offset: 0x0018BBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294389, XrefRangeEnd = 1294401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo GetCurrentOneYearLocal()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}

			// Token: 0x0600560B RID: 22027 RVA: 0x0018DA00 File Offset: 0x0018BC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294401, XrefRangeEnd = 1294425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeZoneInfo.OffsetAndRule GetOneYearLocalFromUtc(int year)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref year;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.OffsetAndRule>(intPtr3) : null;
				}
			}

			// Token: 0x0600560C RID: 22028 RVA: 0x0018DA4C File Offset: 0x0018BC4C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1294439, RefRangeEnd = 1294443, XrefRangeStart = 1294425, XrefRangeEnd = 1294439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeZoneInfo CreateLocal()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}

			// Token: 0x170015F9 RID: 5625
			// (get) Token: 0x0600560D RID: 22029 RVA: 0x0018DA8C File Offset: 0x0018BC8C
			public unsafe TimeZoneInfo Local
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294443, XrefRangeEnd = 1294445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
				}
			}

			// Token: 0x0600560E RID: 22030 RVA: 0x0018DACC File Offset: 0x0018BCCC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1294449, RefRangeEnd = 1294452, XrefRangeStart = 1294445, XrefRangeEnd = 1294449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timeZone);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600560F RID: 22031 RVA: 0x0018DB1C File Offset: 0x0018BD1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CachedData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.CachedData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.CachedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005610 RID: 22032 RVA: 0x0001E923 File Offset: 0x0001CB23
			public CachedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F4 RID: 5620
			// (get) Token: 0x06005611 RID: 22033 RVA: 0x0018DB58 File Offset: 0x0018BD58
			// (set) Token: 0x06005612 RID: 22034 RVA: 0x0001E92C File Offset: 0x0001CB2C
			public unsafe TimeZoneInfo.OffsetAndRule _oneYearLocalFromUtc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__oneYearLocalFromUtc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.OffsetAndRule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__oneYearLocalFromUtc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F5 RID: 5621
			// (get) Token: 0x06005613 RID: 22035 RVA: 0x0018DB88 File Offset: 0x0018BD88
			// (set) Token: 0x06005614 RID: 22036 RVA: 0x0001E94B File Offset: 0x0001CB4B
			public unsafe TimeZoneInfo _localTimeZone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__localTimeZone);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__localTimeZone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F6 RID: 5622
			// (get) Token: 0x06005615 RID: 22037 RVA: 0x0018DBB8 File Offset: 0x0018BDB8
			// (set) Token: 0x06005616 RID: 22038 RVA: 0x0001E96A File Offset: 0x0001CB6A
			public unsafe Dictionary<string, TimeZoneInfo> _systemTimeZones
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__systemTimeZones);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TimeZoneInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__systemTimeZones), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F7 RID: 5623
			// (get) Token: 0x06005617 RID: 22039 RVA: 0x0018DBE8 File Offset: 0x0018BDE8
			// (set) Token: 0x06005618 RID: 22040 RVA: 0x0001E989 File Offset: 0x0001CB89
			public unsafe ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__readOnlySystemTimeZones);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__readOnlySystemTimeZones), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F8 RID: 5624
			// (get) Token: 0x06005619 RID: 22041 RVA: 0x0018DC18 File Offset: 0x0018BE18
			// (set) Token: 0x0600561A RID: 22042 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
			public unsafe bool _allSystemTimeZonesRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__allSystemTimeZonesRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.CachedData.NativeFieldInfoPtr__allSystemTimeZonesRead)) = value;
				}
			}

			// Token: 0x0400463A RID: 17978
			private static readonly IntPtr NativeFieldInfoPtr__oneYearLocalFromUtc;

			// Token: 0x0400463B RID: 17979
			private static readonly IntPtr NativeFieldInfoPtr__localTimeZone;

			// Token: 0x0400463C RID: 17980
			private static readonly IntPtr NativeFieldInfoPtr__systemTimeZones;

			// Token: 0x0400463D RID: 17981
			private static readonly IntPtr NativeFieldInfoPtr__readOnlySystemTimeZones;

			// Token: 0x0400463E RID: 17982
			private static readonly IntPtr NativeFieldInfoPtr__allSystemTimeZonesRead;

			// Token: 0x0400463F RID: 17983
			private static readonly IntPtr NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0;

			// Token: 0x04004640 RID: 17984
			private static readonly IntPtr NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0;

			// Token: 0x04004641 RID: 17985
			private static readonly IntPtr NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0;

			// Token: 0x04004642 RID: 17986
			private static readonly IntPtr NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0;

			// Token: 0x04004643 RID: 17987
			private static readonly IntPtr NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0;

			// Token: 0x04004644 RID: 17988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200057C RID: 1404
		public sealed class OffsetAndRule : Object
		{
			// Token: 0x0600561B RID: 22043 RVA: 0x0018DC40 File Offset: 0x0018BE40
			// Note: this type is marked as 'beforefieldinit'.
			static OffsetAndRule()
			{
				Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "OffsetAndRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr);
				TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr, "Year");
				TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr, "Offset");
				TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr, "Rule");
				TimeZoneInfo.OffsetAndRule.NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr, 100664235);
			}

			// Token: 0x0600561C RID: 22044 RVA: 0x0018DCBC File Offset: 0x0018BEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294452, XrefRangeEnd = 1294454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OffsetAndRule(int year, TimeSpan offset, TimeZoneInfo.AdjustmentRule rule)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.OffsetAndRule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref year;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.OffsetAndRule.NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600561D RID: 22045 RVA: 0x0001E9C3 File Offset: 0x0001CBC3
			public OffsetAndRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015FA RID: 5626
			// (get) Token: 0x0600561E RID: 22046 RVA: 0x0018DD24 File Offset: 0x0018BF24
			// (set) Token: 0x0600561F RID: 22047 RVA: 0x0001E9CC File Offset: 0x0001CBCC
			public unsafe int Year
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Year);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Year)) = value;
				}
			}

			// Token: 0x170015FB RID: 5627
			// (get) Token: 0x06005620 RID: 22048 RVA: 0x0018DD4C File Offset: 0x0018BF4C
			// (set) Token: 0x06005621 RID: 22049 RVA: 0x0001E9E7 File Offset: 0x0001CBE7
			public unsafe TimeSpan Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x170015FC RID: 5628
			// (get) Token: 0x06005622 RID: 22050 RVA: 0x0018DD74 File Offset: 0x0018BF74
			// (set) Token: 0x06005623 RID: 22051 RVA: 0x0001EA02 File Offset: 0x0001CC02
			public unsafe TimeZoneInfo.AdjustmentRule Rule
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Rule);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.OffsetAndRule.NativeFieldInfoPtr_Rule), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004645 RID: 17989
			private static readonly IntPtr NativeFieldInfoPtr_Year;

			// Token: 0x04004646 RID: 17990
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04004647 RID: 17991
			private static readonly IntPtr NativeFieldInfoPtr_Rule;

			// Token: 0x04004648 RID: 17992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0;
		}

		// Token: 0x0200057D RID: 1405
		[StructLayout(3, CharSet = 3)]
		public sealed class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
		{
			// Token: 0x06005624 RID: 22052 RVA: 0x0018DDA4 File Offset: 0x0018BFA4
			// Note: this type is marked as 'beforefieldinit'.
			static DYNAMIC_TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "DYNAMIC_TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr);
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TZI");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
			}

			// Token: 0x06005625 RID: 22053 RVA: 0x0001EA21 File Offset: 0x0001CC21
			public DYNAMIC_TIME_ZONE_INFORMATION(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005626 RID: 22054 RVA: 0x0001EA2A File Offset: 0x0001CC2A
			public DYNAMIC_TIME_ZONE_INFORMATION()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr))
			{
			}

			// Token: 0x170015FD RID: 5629
			// (get) Token: 0x06005627 RID: 22055 RVA: 0x0018DE0C File Offset: 0x0018C00C
			// (set) Token: 0x06005628 RID: 22056 RVA: 0x0001EA3C File Offset: 0x0001CC3C
			public unsafe Interop.Kernel32.TIME_ZONE_INFORMATION TZI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI)) = value;
				}
			}

			// Token: 0x170015FE RID: 5630
			// (get) Token: 0x06005629 RID: 22057 RVA: 0x0018DE34 File Offset: 0x0018C034
			// (set) Token: 0x0600562A RID: 22058 RVA: 0x0001EA57 File Offset: 0x0001CC57
			public unsafe string TimeZoneKeyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015FF RID: 5631
			// (get) Token: 0x0600562B RID: 22059 RVA: 0x0018DE5C File Offset: 0x0018C05C
			// (set) Token: 0x0600562C RID: 22060 RVA: 0x0001EA76 File Offset: 0x0001CC76
			public unsafe byte DynamicDaylightTimeDisabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled)) = value;
				}
			}

			// Token: 0x04004649 RID: 17993
			private static readonly IntPtr NativeFieldInfoPtr_TZI;

			// Token: 0x0400464A RID: 17994
			private static readonly IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

			// Token: 0x0400464B RID: 17995
			private static readonly IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;
		}

		// Token: 0x0200057E RID: 1406
		public enum TimeZoneInfoResult
		{
			// Token: 0x0400464D RID: 17997
			Success,
			// Token: 0x0400464E RID: 17998
			TimeZoneNotFoundException,
			// Token: 0x0400464F RID: 17999
			InvalidTimeZoneException,
			// Token: 0x04004650 RID: 18000
			SecurityException
		}

		// Token: 0x0200057F RID: 1407
		[Serializable]
		public sealed class AdjustmentRule : Object
		{
			// Token: 0x0600562D RID: 22061 RVA: 0x0018DE84 File Offset: 0x0018C084
			// Note: this type is marked as 'beforefieldinit'.
			static AdjustmentRule()
			{
				Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "AdjustmentRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr);
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_dateStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_dateEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_daylightDelta");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_daylightTransitionStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_daylightTransitionEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__baseUtcOffsetDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_baseUtcOffsetDelta");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__noDaylightTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "_noDaylightTransitions");
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664236);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664237);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664238);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664239);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664240);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664241);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664242);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664243);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664244);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664245);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664246);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664247);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664248);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664249);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664250);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664251);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664252);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664253);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100664254);
			}

			// Token: 0x17001607 RID: 5639
			// (get) Token: 0x0600562E RID: 22062 RVA: 0x0018E0B8 File Offset: 0x0018C2B8
			public unsafe DateTime DateStart
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001608 RID: 5640
			// (get) Token: 0x0600562F RID: 22063 RVA: 0x0018E0F4 File Offset: 0x0018C2F4
			public unsafe DateTime DateEnd
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001609 RID: 5641
			// (get) Token: 0x06005630 RID: 22064 RVA: 0x0018E130 File Offset: 0x0018C330
			public unsafe TimeSpan DaylightDelta
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160A RID: 5642
			// (get) Token: 0x06005631 RID: 22065 RVA: 0x0018E16C File Offset: 0x0018C36C
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160B RID: 5643
			// (get) Token: 0x06005632 RID: 22066 RVA: 0x0018E1A8 File Offset: 0x0018C3A8
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160C RID: 5644
			// (get) Token: 0x06005633 RID: 22067 RVA: 0x0018E1E4 File Offset: 0x0018C3E4
			public unsafe TimeSpan BaseUtcOffsetDelta
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160D RID: 5645
			// (get) Token: 0x06005634 RID: 22068 RVA: 0x0018E220 File Offset: 0x0018C420
			public unsafe bool NoDaylightTransitions
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160E RID: 5646
			// (get) Token: 0x06005635 RID: 22069 RVA: 0x0018E25C File Offset: 0x0018C45C
			public unsafe bool HasDaylightSaving
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 1294466, RefRangeEnd = 1294472, XrefRangeStart = 1294454, XrefRangeEnd = 1294466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005636 RID: 22070 RVA: 0x0018E298 File Offset: 0x0018C498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294472, XrefRangeEnd = 1294489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.AdjustmentRule other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005637 RID: 22071 RVA: 0x0018E2E8 File Offset: 0x0018C4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294489, XrefRangeEnd = 1294493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005638 RID: 22072 RVA: 0x0018E324 File Offset: 0x0018C524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294493, XrefRangeEnd = 1294495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noDaylightTransitions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005639 RID: 22073 RVA: 0x0018E3C0 File Offset: 0x0018C5C0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1294500, RefRangeEnd = 1294504, XrefRangeStart = 1294495, XrefRangeEnd = 1294500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noDaylightTransitions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}

			// Token: 0x0600563A RID: 22074 RVA: 0x0018E454 File Offset: 0x0018C654
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1294518, RefRangeEnd = 1294524, XrefRangeStart = 1294504, XrefRangeEnd = 1294518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsStartDateMarkerForBeginningOfYear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600563B RID: 22075 RVA: 0x0018E490 File Offset: 0x0018C690
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1294538, RefRangeEnd = 1294545, XrefRangeStart = 1294524, XrefRangeEnd = 1294538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEndDateMarkerForEndOfYear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600563C RID: 22076 RVA: 0x0018E4CC File Offset: 0x0018C6CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1294599, RefRangeEnd = 1294602, XrefRangeStart = 1294545, XrefRangeEnd = 1294599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noDaylightTransitions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600563D RID: 22077 RVA: 0x0018E544 File Offset: 0x0018C744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294602, XrefRangeEnd = 1294603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600563E RID: 22078 RVA: 0x0018E588 File Offset: 0x0018C788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294603, XrefRangeEnd = 1294634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600563F RID: 22079 RVA: 0x0018E5E4 File Offset: 0x0018C7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294634, XrefRangeEnd = 1294697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005640 RID: 22080 RVA: 0x0018E648 File Offset: 0x0018C848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294697, XrefRangeEnd = 1294700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005641 RID: 22081 RVA: 0x0001EA91 File Offset: 0x0001CC91
			public AdjustmentRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001600 RID: 5632
			// (get) Token: 0x06005642 RID: 22082 RVA: 0x0018E684 File Offset: 0x0018C884
			// (set) Token: 0x06005643 RID: 22083 RVA: 0x0001EA9A File Offset: 0x0001CC9A
			public unsafe DateTime _dateStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateStart)) = value;
				}
			}

			// Token: 0x17001601 RID: 5633
			// (get) Token: 0x06005644 RID: 22084 RVA: 0x0018E6AC File Offset: 0x0018C8AC
			// (set) Token: 0x06005645 RID: 22085 RVA: 0x0001EAB5 File Offset: 0x0001CCB5
			public unsafe DateTime _dateEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__dateEnd)) = value;
				}
			}

			// Token: 0x17001602 RID: 5634
			// (get) Token: 0x06005646 RID: 22086 RVA: 0x0018E6D4 File Offset: 0x0018C8D4
			// (set) Token: 0x06005647 RID: 22087 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
			public unsafe TimeSpan _daylightDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightDelta)) = value;
				}
			}

			// Token: 0x17001603 RID: 5635
			// (get) Token: 0x06005648 RID: 22088 RVA: 0x0018E6FC File Offset: 0x0018C8FC
			// (set) Token: 0x06005649 RID: 22089 RVA: 0x0001EAEB File Offset: 0x0001CCEB
			public unsafe TimeZoneInfo.TransitionTime _daylightTransitionStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionStart)) = value;
				}
			}

			// Token: 0x17001604 RID: 5636
			// (get) Token: 0x0600564A RID: 22090 RVA: 0x0018E724 File Offset: 0x0018C924
			// (set) Token: 0x0600564B RID: 22091 RVA: 0x0001EB06 File Offset: 0x0001CD06
			public unsafe TimeZoneInfo.TransitionTime _daylightTransitionEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__daylightTransitionEnd)) = value;
				}
			}

			// Token: 0x17001605 RID: 5637
			// (get) Token: 0x0600564C RID: 22092 RVA: 0x0018E74C File Offset: 0x0018C94C
			// (set) Token: 0x0600564D RID: 22093 RVA: 0x0001EB21 File Offset: 0x0001CD21
			public unsafe TimeSpan _baseUtcOffsetDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__baseUtcOffsetDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__baseUtcOffsetDelta)) = value;
				}
			}

			// Token: 0x17001606 RID: 5638
			// (get) Token: 0x0600564E RID: 22094 RVA: 0x0018E774 File Offset: 0x0018C974
			// (set) Token: 0x0600564F RID: 22095 RVA: 0x0001EB3C File Offset: 0x0001CD3C
			public unsafe bool _noDaylightTransitions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__noDaylightTransitions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr__noDaylightTransitions)) = value;
				}
			}

			// Token: 0x04004651 RID: 18001
			private static readonly IntPtr NativeFieldInfoPtr__dateStart;

			// Token: 0x04004652 RID: 18002
			private static readonly IntPtr NativeFieldInfoPtr__dateEnd;

			// Token: 0x04004653 RID: 18003
			private static readonly IntPtr NativeFieldInfoPtr__daylightDelta;

			// Token: 0x04004654 RID: 18004
			private static readonly IntPtr NativeFieldInfoPtr__daylightTransitionStart;

			// Token: 0x04004655 RID: 18005
			private static readonly IntPtr NativeFieldInfoPtr__daylightTransitionEnd;

			// Token: 0x04004656 RID: 18006
			private static readonly IntPtr NativeFieldInfoPtr__baseUtcOffsetDelta;

			// Token: 0x04004657 RID: 18007
			private static readonly IntPtr NativeFieldInfoPtr__noDaylightTransitions;

			// Token: 0x04004658 RID: 18008
			private static readonly IntPtr NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0;

			// Token: 0x04004659 RID: 18009
			private static readonly IntPtr NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0;

			// Token: 0x0400465A RID: 18010
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0;

			// Token: 0x0400465B RID: 18011
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0;

			// Token: 0x0400465C RID: 18012
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0;

			// Token: 0x0400465D RID: 18013
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0;

			// Token: 0x0400465E RID: 18014
			private static readonly IntPtr NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0;

			// Token: 0x0400465F RID: 18015
			private static readonly IntPtr NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0;

			// Token: 0x04004660 RID: 18016
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0;

			// Token: 0x04004661 RID: 18017
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004662 RID: 18018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0;

			// Token: 0x04004663 RID: 18019
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0;

			// Token: 0x04004664 RID: 18020
			private static readonly IntPtr NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0;

			// Token: 0x04004665 RID: 18021
			private static readonly IntPtr NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0;

			// Token: 0x04004666 RID: 18022
			private static readonly IntPtr NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0;

			// Token: 0x04004667 RID: 18023
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x04004668 RID: 18024
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004669 RID: 18025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400466A RID: 18026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}

		// Token: 0x02000580 RID: 1408
		[Serializable]
		[StructLayout(2)]
		public struct TransitionTime
		{
			// Token: 0x06005650 RID: 22096 RVA: 0x0018E79C File Offset: 0x0018C99C
			// Note: this type is marked as 'beforefieldinit'.
			static TransitionTime()
			{
				Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TransitionTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr);
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_timeOfDay");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_month");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__week = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_week");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_day");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_dayOfWeek");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr__isFixedDateRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "_isFixedDateRule");
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664255);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664256);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664257);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664258);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664259);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664260);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664261);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664262);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664263);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664264);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664265);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664266);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664267);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664268);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664269);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664270);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100664271);
			}

			// Token: 0x1700160F RID: 5647
			// (get) Token: 0x06005651 RID: 22097 RVA: 0x0018E994 File Offset: 0x0018CB94
			public unsafe DateTime TimeOfDay
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001610 RID: 5648
			// (get) Token: 0x06005652 RID: 22098 RVA: 0x0018E9C4 File Offset: 0x0018CBC4
			public unsafe int Month
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001611 RID: 5649
			// (get) Token: 0x06005653 RID: 22099 RVA: 0x0018E9F4 File Offset: 0x0018CBF4
			public unsafe int Week
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001612 RID: 5650
			// (get) Token: 0x06005654 RID: 22100 RVA: 0x0018EA24 File Offset: 0x0018CC24
			public unsafe int Day
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001613 RID: 5651
			// (get) Token: 0x06005655 RID: 22101 RVA: 0x0018EA54 File Offset: 0x0018CC54
			public unsafe DayOfWeek DayOfWeek
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001614 RID: 5652
			// (get) Token: 0x06005656 RID: 22102 RVA: 0x0018EA84 File Offset: 0x0018CC84
			public unsafe bool IsFixedDateRule
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005657 RID: 22103 RVA: 0x0018EAB4 File Offset: 0x0018CCB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294700, XrefRangeEnd = 1294704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005658 RID: 22104 RVA: 0x0018EAF8 File Offset: 0x0018CCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294704, XrefRangeEnd = 1294705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005659 RID: 22105 RVA: 0x0018EB44 File Offset: 0x0018CD44
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1294709, RefRangeEnd = 1294720, XrefRangeStart = 1294705, XrefRangeEnd = 1294709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.TransitionTime other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600565A RID: 22106 RVA: 0x0018EB84 File Offset: 0x0018CD84
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600565B RID: 22107 RVA: 0x0018EBB4 File Offset: 0x0018CDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294720, XrefRangeEnd = 1294721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixedDateRule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600565C RID: 22108 RVA: 0x0018EC2C File Offset: 0x0018CE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294721, XrefRangeEnd = 1294722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x0018EC88 File Offset: 0x0018CE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294722, XrefRangeEnd = 1294723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600565E RID: 22110 RVA: 0x0018ECF0 File Offset: 0x0018CEF0
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1294733, RefRangeEnd = 1294746, XrefRangeStart = 1294723, XrefRangeEnd = 1294733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600565F RID: 22111 RVA: 0x0018ED5C File Offset: 0x0018CF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294746, XrefRangeEnd = 1294747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005660 RID: 22112 RVA: 0x0018ED94 File Offset: 0x0018CF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294747, XrefRangeEnd = 1294768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005661 RID: 22113 RVA: 0x0018EDE4 File Offset: 0x0018CFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294768, XrefRangeEnd = 1294821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionTime(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005662 RID: 22114 RVA: 0x0001EB57 File Offset: 0x0001CD57
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, ref this));
			}

			// Token: 0x0400466B RID: 18027
			private static readonly IntPtr NativeFieldInfoPtr__timeOfDay;

			// Token: 0x0400466C RID: 18028
			private static readonly IntPtr NativeFieldInfoPtr__month;

			// Token: 0x0400466D RID: 18029
			private static readonly IntPtr NativeFieldInfoPtr__week;

			// Token: 0x0400466E RID: 18030
			private static readonly IntPtr NativeFieldInfoPtr__day;

			// Token: 0x0400466F RID: 18031
			private static readonly IntPtr NativeFieldInfoPtr__dayOfWeek;

			// Token: 0x04004670 RID: 18032
			private static readonly IntPtr NativeFieldInfoPtr__isFixedDateRule;

			// Token: 0x04004671 RID: 18033
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0;

			// Token: 0x04004672 RID: 18034
			private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

			// Token: 0x04004673 RID: 18035
			private static readonly IntPtr NativeMethodInfoPtr_get_Week_Public_get_Int32_0;

			// Token: 0x04004674 RID: 18036
			private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

			// Token: 0x04004675 RID: 18037
			private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

			// Token: 0x04004676 RID: 18038
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0;

			// Token: 0x04004677 RID: 18039
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004678 RID: 18040
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0;

			// Token: 0x04004679 RID: 18041
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0;

			// Token: 0x0400467A RID: 18042
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400467B RID: 18043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0;

			// Token: 0x0400467C RID: 18044
			private static readonly IntPtr NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0;

			// Token: 0x0400467D RID: 18045
			private static readonly IntPtr NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0;

			// Token: 0x0400467E RID: 18046
			private static readonly IntPtr NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0;

			// Token: 0x0400467F RID: 18047
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x04004680 RID: 18048
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004681 RID: 18049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004682 RID: 18050
			[FieldOffset(0)]
			public readonly DateTime _timeOfDay;

			// Token: 0x04004683 RID: 18051
			[FieldOffset(8)]
			public readonly byte _month;

			// Token: 0x04004684 RID: 18052
			[FieldOffset(9)]
			public readonly byte _week;

			// Token: 0x04004685 RID: 18053
			[FieldOffset(10)]
			public readonly byte _day;

			// Token: 0x04004686 RID: 18054
			[FieldOffset(12)]
			public readonly DayOfWeek _dayOfWeek;

			// Token: 0x04004687 RID: 18055
			[FieldOffset(16)]
			[MarshalAs(4)]
			public readonly bool _isFixedDateRule;
		}

		// Token: 0x02000581 RID: 1409
		[ObfuscatedName("System.TimeZoneInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005663 RID: 22115 RVA: 0x0018EE34 File Offset: 0x0018D034
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr);
				TimeZoneInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9");
				TimeZoneInfo.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9__49_0");
				TimeZoneInfo.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9__110_0");
				TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100664273);
				TimeZoneInfo.__c.NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100664274);
				TimeZoneInfo.__c.NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100664275);
				TimeZoneInfo.__c.NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100664276);
			}

			// Token: 0x06005664 RID: 22116 RVA: 0x0018EEEC File Offset: 0x0018D0EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005665 RID: 22117 RVA: 0x0018EF28 File Offset: 0x0018D128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294821, XrefRangeEnd = 1294830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSystemTimeZonesWinRTFallback_b__49_0(TimeZoneInfo x, TimeZoneInfo y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005666 RID: 22118 RVA: 0x0018EF88 File Offset: 0x0018D188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294830, XrefRangeEnd = 1294839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSystemTimeZones_b__110_0(TimeZoneInfo x, TimeZoneInfo y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005667 RID: 22119 RVA: 0x0018EFE8 File Offset: 0x0018D1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294839, XrefRangeEnd = 1294852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__157_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005668 RID: 22120 RVA: 0x0001EB69 File Offset: 0x0001CD69
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001615 RID: 5653
			// (get) Token: 0x06005669 RID: 22121 RVA: 0x0018F024 File Offset: 0x0018D224
			// (set) Token: 0x0600566A RID: 22122 RVA: 0x0001EB72 File Offset: 0x0001CD72
			public unsafe static TimeZoneInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001616 RID: 5654
			// (get) Token: 0x0600566B RID: 22123 RVA: 0x0018F04C File Offset: 0x0018D24C
			// (set) Token: 0x0600566C RID: 22124 RVA: 0x0001EB84 File Offset: 0x0001CD84
			public unsafe static Comparison<TimeZoneInfo> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001617 RID: 5655
			// (get) Token: 0x0600566D RID: 22125 RVA: 0x0018F074 File Offset: 0x0018D274
			// (set) Token: 0x0600566E RID: 22126 RVA: 0x0001EB96 File Offset: 0x0001CD96
			public unsafe static Comparison<TimeZoneInfo> __9__110_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__110_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004688 RID: 18056
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004689 RID: 18057
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x0400468A RID: 18058
			private static readonly IntPtr NativeFieldInfoPtr___9__110_0;

			// Token: 0x0400468B RID: 18059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400468C RID: 18060
			private static readonly IntPtr NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0;

			// Token: 0x0400468D RID: 18061
			private static readonly IntPtr NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0;

			// Token: 0x0400468E RID: 18062
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0;
		}
	}
}

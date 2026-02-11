using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x02000041 RID: 65
	public class TimeTextInfo : Object
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00018BC8 File Offset: 0x00016DC8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeTextInfo()
		{
			Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "TimeTextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr);
			TimeTextInfo.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "d");
			TimeTextInfo.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "day");
			TimeTextInfo.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "h");
			TimeTextInfo.NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "hour");
			TimeTextInfo.NativeFieldInfoPtr_lessThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "lessThan");
			TimeTextInfo.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "m");
			TimeTextInfo.NativeFieldInfoPtr_millisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "millisecond");
			TimeTextInfo.NativeFieldInfoPtr_minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "minute");
			TimeTextInfo.NativeFieldInfoPtr_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "ms");
			TimeTextInfo.NativeFieldInfoPtr_PluralRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "PluralRule");
			TimeTextInfo.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "s");
			TimeTextInfo.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "second");
			TimeTextInfo.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "w");
			TimeTextInfo.NativeFieldInfoPtr_week = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "week");
			TimeTextInfo.NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, 100664061);
			TimeTextInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, 100664062);
			TimeTextInfo.NativeMethodInfoPtr_GetValue_Private_Static_String_PluralRuleDelegate_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, 100664063);
			TimeTextInfo.NativeMethodInfoPtr_GetLessThanText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, 100664064);
			TimeTextInfo.NativeMethodInfoPtr_GetUnitText_Public_Virtual_New_String_TimeSpanFormatOptions_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, 100664065);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00018D74 File Offset: 0x00016F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1070758, RefRangeEnd = 1070759, XrefRangeStart = 1070743, XrefRangeEnd = 1070758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeTextInfo(PluralRules.PluralRuleDelegate pluralRule, Il2CppStringArray week, Il2CppStringArray day, Il2CppStringArray hour, Il2CppStringArray minute, Il2CppStringArray second, Il2CppStringArray millisecond, Il2CppStringArray w, Il2CppStringArray d, Il2CppStringArray h, Il2CppStringArray m, Il2CppStringArray s, Il2CppStringArray ms, string lessThan)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pluralRule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(week);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(day);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hour);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minute);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(millisecond);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ms);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lessThan);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00018EBC File Offset: 0x000170BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070759, XrefRangeEnd = 1070816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeTextInfo(string week, string day, string hour, string minute, string second, string millisecond, string lessThan)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(week);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(day);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hour);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(minute);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(second);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(millisecond);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lessThan);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00018F78 File Offset: 0x00017178
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1070825, RefRangeEnd = 1070837, XrefRangeStart = 1070816, XrefRangeEnd = 1070825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetValue(PluralRules.PluralRuleDelegate pluralRule, int value, Il2CppStringArray units)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pluralRule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(units);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.NativeMethodInfoPtr_GetValue_Private_Static_String_PluralRuleDelegate_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00018FD4 File Offset: 0x000171D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070837, XrefRangeEnd = 1070838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLessThanText(string minimumValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(minimumValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.NativeMethodInfoPtr_GetLessThanText_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001901C File Offset: 0x0001721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070838, XrefRangeEnd = 1070850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetUnitText(TimeSpanFormatOptions unit, int value, bool abbr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref abbr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeTextInfo.NativeMethodInfoPtr_GetUnitText_Public_Virtual_New_String_TimeSpanFormatOptions_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003510 File Offset: 0x00001710
		public TimeTextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00019088 File Offset: 0x00017288
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003519 File Offset: 0x00001719
		public unsafe Il2CppStringArray d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000190B8 File Offset: 0x000172B8
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003538 File Offset: 0x00001738
		public unsafe Il2CppStringArray day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_day);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_day), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000190E8 File Offset: 0x000172E8
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003557 File Offset: 0x00001757
		public unsafe Il2CppStringArray h
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_h);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_h), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00019118 File Offset: 0x00017318
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003576 File Offset: 0x00001776
		public unsafe Il2CppStringArray hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_hour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_hour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00019148 File Offset: 0x00017348
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003595 File Offset: 0x00001795
		public unsafe string lessThan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_lessThan);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_lessThan), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00019170 File Offset: 0x00017370
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000035B4 File Offset: 0x000017B4
		public unsafe Il2CppStringArray m
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_m);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000191A0 File Offset: 0x000173A0
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000035D3 File Offset: 0x000017D3
		public unsafe Il2CppStringArray millisecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_millisecond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_millisecond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000191D0 File Offset: 0x000173D0
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000035F2 File Offset: 0x000017F2
		public unsafe Il2CppStringArray minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_minute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_minute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00019200 File Offset: 0x00017400
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003611 File Offset: 0x00001811
		public unsafe Il2CppStringArray ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_ms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_ms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00019230 File Offset: 0x00017430
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003630 File Offset: 0x00001830
		public unsafe PluralRules.PluralRuleDelegate PluralRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_PluralRule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_PluralRule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00019260 File Offset: 0x00017460
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000364F File Offset: 0x0000184F
		public unsafe Il2CppStringArray s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00019290 File Offset: 0x00017490
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0000366E File Offset: 0x0000186E
		public unsafe Il2CppStringArray second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000192C0 File Offset: 0x000174C0
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000368D File Offset: 0x0000188D
		public unsafe Il2CppStringArray w
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_w);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_w), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000192F0 File Offset: 0x000174F0
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x000036AC File Offset: 0x000018AC
		public unsafe Il2CppStringArray week
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_week);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeTextInfo.NativeFieldInfoPtr_week), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_day;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_h;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_hour;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_lessThan;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_m;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_millisecond;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_minute;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_ms;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_PluralRule;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_week;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_Static_String_PluralRuleDelegate_Int32_Il2CppStringArray_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_GetLessThanText_Public_String_String_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitText_Public_Virtual_New_String_TimeSpanFormatOptions_Int32_Boolean_0;

		// Token: 0x0200013C RID: 316
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TimeTextInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000E04 RID: 3588 RVA: 0x0003D6C4 File Offset: 0x0003B8C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeTextInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr);
				TimeTextInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr, "<>9");
				TimeTextInfo.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr, "<>9__15_0");
				TimeTextInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr, 100664067);
				TimeTextInfo.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr, 100664068);
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x0003D740 File Offset: 0x0003B940
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeTextInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E06 RID: 3590 RVA: 0x0003D77C File Offset: 0x0003B97C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__15_0(Decimal d, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeTextInfo.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E07 RID: 3591 RVA: 0x00007D23 File Offset: 0x00005F23
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0003D7D4 File Offset: 0x0003B9D4
			// (set) Token: 0x06000E09 RID: 3593 RVA: 0x00007D2C File Offset: 0x00005F2C
			public unsafe static TimeTextInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeTextInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeTextInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeTextInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0003D7FC File Offset: 0x0003B9FC
			// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00007D3E File Offset: 0x00005F3E
			public unsafe static PluralRules.PluralRuleDelegate __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeTextInfo.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeTextInfo.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009AF RID: 2479
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009B0 RID: 2480
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040009B1 RID: 2481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009B2 RID: 2482
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Int32_Decimal_Int32_0;
		}
	}
}

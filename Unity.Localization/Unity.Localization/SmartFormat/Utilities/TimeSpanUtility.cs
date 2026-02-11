using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x0200003E RID: 62
	public static class TimeSpanUtility : Object
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0001870C File Offset: 0x0001690C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanUtility()
		{
			Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "TimeSpanUtility");
			TimeSpanUtility.NativeFieldInfoPtr_AbbreviateAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "AbbreviateAll");
			TimeSpanUtility.NativeFieldInfoPtr_LessThanAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "LessThanAll");
			TimeSpanUtility.NativeFieldInfoPtr_RangeAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "RangeAll");
			TimeSpanUtility.NativeFieldInfoPtr_TruncateAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "TruncateAll");
			TimeSpanUtility.NativeFieldInfoPtr__DefaultFormatOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "<DefaultFormatOptions>k__BackingField");
			TimeSpanUtility.NativeFieldInfoPtr__AbsoluteDefaults_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "<AbsoluteDefaults>k__BackingField");
			TimeSpanUtility.NativeMethodInfoPtr_ToTimeString_Public_Static_String_TimeSpan_TimeSpanFormatOptions_TimeTextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, 100664042);
			TimeSpanUtility.NativeMethodInfoPtr_get_DefaultFormatOptions_Public_Static_get_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, 100664044);
			TimeSpanUtility.NativeMethodInfoPtr_set_DefaultFormatOptions_Public_Static_set_Void_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, 100664045);
			TimeSpanUtility.NativeMethodInfoPtr_get_AbsoluteDefaults_Public_Static_get_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, 100664046);
			TimeSpanUtility.NativeMethodInfoPtr_Round_Public_Static_TimeSpan_TimeSpan_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, 100664047);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00018810 File Offset: 0x00016A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1070564, RefRangeEnd = 1070565, XrefRangeStart = 1070395, XrefRangeEnd = 1070564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToTimeString(this TimeSpan FromTime, TimeSpanFormatOptions options, TimeTextInfo timeTextInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref FromTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(timeTextInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanUtility.NativeMethodInfoPtr_ToTimeString_Public_Static_String_TimeSpan_TimeSpanFormatOptions_TimeTextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00018868 File Offset: 0x00016A68
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00018898 File Offset: 0x00016A98
		public unsafe static TimeSpanFormatOptions DefaultFormatOptions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070565, XrefRangeEnd = 1070569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanUtility.NativeMethodInfoPtr_get_DefaultFormatOptions_Public_Static_get_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070569, XrefRangeEnd = 1070573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanUtility.NativeMethodInfoPtr_set_DefaultFormatOptions_Public_Static_set_Void_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000188CC File Offset: 0x00016ACC
		public unsafe static TimeSpanFormatOptions AbsoluteDefaults
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070573, XrefRangeEnd = 1070577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanUtility.NativeMethodInfoPtr_get_AbsoluteDefaults_Public_Static_get_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000188FC File Offset: 0x00016AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070577, XrefRangeEnd = 1070583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Round(this TimeSpan fromTime, long intervalTicks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalTicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanUtility.NativeMethodInfoPtr_Round_Public_Static_TimeSpan_TimeSpan_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003498 File Offset: 0x00001698
		public TimeSpanUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00018948 File Offset: 0x00016B48
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000034A1 File Offset: 0x000016A1
		public unsafe static TimeSpanFormatOptions AbbreviateAll
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr_AbbreviateAll, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr_AbbreviateAll, (void*)(&value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00018964 File Offset: 0x00016B64
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000034AF File Offset: 0x000016AF
		public unsafe static TimeSpanFormatOptions LessThanAll
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr_LessThanAll, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr_LessThanAll, (void*)(&value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00018980 File Offset: 0x00016B80
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000034BD File Offset: 0x000016BD
		public unsafe static TimeSpanFormatOptions RangeAll
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr_RangeAll, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr_RangeAll, (void*)(&value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0001899C File Offset: 0x00016B9C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000034CB File Offset: 0x000016CB
		public unsafe static TimeSpanFormatOptions TruncateAll
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr_TruncateAll, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr_TruncateAll, (void*)(&value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000189B8 File Offset: 0x00016BB8
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000034D9 File Offset: 0x000016D9
		public unsafe static TimeSpanFormatOptions _DefaultFormatOptions_k__BackingField
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr__DefaultFormatOptions_k__BackingField, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr__DefaultFormatOptions_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000189D4 File Offset: 0x00016BD4
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000034E7 File Offset: 0x000016E7
		public unsafe static TimeSpanFormatOptions _AbsoluteDefaults_k__BackingField
		{
			get
			{
				TimeSpanFormatOptions timeSpanFormatOptions;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.NativeFieldInfoPtr__AbsoluteDefaults_k__BackingField, (void*)(&timeSpanFormatOptions));
				return timeSpanFormatOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.NativeFieldInfoPtr__AbsoluteDefaults_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_AbbreviateAll;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_LessThanAll;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_RangeAll;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_TruncateAll;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr__DefaultFormatOptions_k__BackingField;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__AbsoluteDefaults_k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeString_Public_Static_String_TimeSpan_TimeSpanFormatOptions_TimeTextInfo_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultFormatOptions_Public_Static_get_TimeSpanFormatOptions_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultFormatOptions_Public_Static_set_Void_TimeSpanFormatOptions_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsoluteDefaults_Public_Static_get_TimeSpanFormatOptions_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_TimeSpan_TimeSpan_Int64_0;

		// Token: 0x0200013A RID: 314
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TimeSpanUtility+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000DE8 RID: 3560 RVA: 0x0003D204 File Offset: 0x0003B404
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<TimeSpanUtility.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanUtility>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanUtility.__O>.NativeClassPtr);
				TimeSpanUtility.__O.NativeFieldInfoPtr__0___Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility.__O>.NativeClassPtr, "<0>__Floor");
				TimeSpanUtility.__O.NativeFieldInfoPtr__1___Ceiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanUtility.__O>.NativeClassPtr, "<1>__Ceiling");
			}

			// Token: 0x06000DE9 RID: 3561 RVA: 0x00007C4B File Offset: 0x00005E4B
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0003D258 File Offset: 0x0003B458
			// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00007C54 File Offset: 0x00005E54
			public unsafe static Func<double, double> _0___Floor
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.__O.NativeFieldInfoPtr__0___Floor, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.__O.NativeFieldInfoPtr__0___Floor, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0003D280 File Offset: 0x0003B480
			// (set) Token: 0x06000DED RID: 3565 RVA: 0x00007C66 File Offset: 0x00005E66
			public unsafe static Func<double, double> _1___Ceiling
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeSpanUtility.__O.NativeFieldInfoPtr__1___Ceiling, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeSpanUtility.__O.NativeFieldInfoPtr__1___Ceiling, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400099F RID: 2463
			private static readonly IntPtr NativeFieldInfoPtr__0___Floor;

			// Token: 0x040009A0 RID: 2464
			private static readonly IntPtr NativeFieldInfoPtr__1___Ceiling;
		}
	}
}

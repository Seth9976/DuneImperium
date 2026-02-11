using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000A1 RID: 161
	public sealed class ParsingInfo : ValueType
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x000589F8 File Offset: 0x00056BF8
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingInfo()
		{
			Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParsingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr);
			ParsingInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "calendar");
			ParsingInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "dayOfWeek");
			ParsingInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "timeMark");
			ParsingInfo.NativeFieldInfoPtr_fUseHour12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseHour12");
			ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseTwoDigitYear");
			ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowInnerWhite");
			ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowTrailingWhite");
			ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fCustomNumberParser");
			ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "parseNumberDelegate");
			ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, 100665226);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00058AF0 File Offset: 0x00056CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307446, RefRangeEnd = 1307447, XrefRangeStart = 1307446, XrefRangeEnd = 1307446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public ParsingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00004CAE File Offset: 0x00002EAE
		public ParsingInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00058B28 File Offset: 0x00056D28
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00058B58 File Offset: 0x00056D58
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00004CDF File Offset: 0x00002EDF
		public unsafe int dayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00058B80 File Offset: 0x00056D80
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00004CFA File Offset: 0x00002EFA
		public unsafe DateTimeParse.TM timeMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00058BA8 File Offset: 0x00056DA8
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00004D15 File Offset: 0x00002F15
		public unsafe bool fUseHour12
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00058BD0 File Offset: 0x00056DD0
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00004D30 File Offset: 0x00002F30
		public unsafe bool fUseTwoDigitYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear)) = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00058BF8 File Offset: 0x00056DF8
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x00004D4B File Offset: 0x00002F4B
		public unsafe bool fAllowInnerWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00058C20 File Offset: 0x00056E20
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00004D66 File Offset: 0x00002F66
		public unsafe bool fAllowTrailingWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00058C48 File Offset: 0x00056E48
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00004D81 File Offset: 0x00002F81
		public unsafe bool fCustomNumberParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00058C70 File Offset: 0x00056E70
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00004D9C File Offset: 0x00002F9C
		public unsafe DateTimeParse.MatchNumberDelegate parseNumberDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_fUseHour12;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_fUseTwoDigitYear;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_fAllowInnerWhite;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_fAllowTrailingWhite;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_fCustomNumberParser;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_parseNumberDelegate;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}

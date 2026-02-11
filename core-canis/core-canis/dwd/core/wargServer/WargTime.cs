using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace dwd.core.wargServer
{
	// Token: 0x02000123 RID: 291
	public sealed class WargTime : ValueType
	{
		// Token: 0x06001041 RID: 4161 RVA: 0x00054058 File Offset: 0x00052258
		// Note: this type is marked as 'beforefieldinit'.
		static WargTime()
		{
			Il2CppClassPointerStore<WargTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.wargServer", "WargTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WargTime>.NativeClassPtr);
			WargTime.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargTime>.NativeClassPtr, "timestamp");
			WargTime.NativeFieldInfoPtr__asDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargTime>.NativeClassPtr, "_asDateTime");
			WargTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargTime>.NativeClassPtr, "MinValue");
			WargTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WargTime>.NativeClassPtr, "MaxValue");
			WargTime.NativeMethodInfoPtr_get_asDateTime_Private_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665666);
			WargTime.NativeMethodInfoPtr_get_AsLocalTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665667);
			WargTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665668);
			WargTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665669);
			WargTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_WargTime_WargTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665670);
			WargTime.NativeMethodInfoPtr_op_Addition_Public_Static_WargTime_WargTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665671);
			WargTime.NativeMethodInfoPtr_FromMilliseconds_Public_Static_WargTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665672);
			WargTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665673);
			WargTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665674);
			WargTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665675);
			WargTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665676);
			WargTime.NativeMethodInfoPtr_AddMonths_Public_WargTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665677);
			WargTime.NativeMethodInfoPtr_AddDays_Public_WargTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665678);
			WargTime.NativeMethodInfoPtr_AddHours_Public_WargTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665679);
			WargTime.NativeMethodInfoPtr_AddTimeSpan_Public_WargTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665680);
			WargTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665681);
			WargTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665682);
			WargTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665683);
			WargTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665684);
			WargTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665685);
			WargTime.NativeMethodInfoPtr_GetYear_Public_Int32_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665686);
			WargTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665687);
			WargTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665688);
			WargTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665689);
			WargTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665690);
			WargTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665691);
			WargTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665692);
			WargTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665693);
			WargTime.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665694);
			WargTime.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665695);
			WargTime.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WargTime>.NativeClassPtr, 100665696);
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00054344 File Offset: 0x00052544
		public unsafe DateTime asDateTime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 869531, RefRangeEnd = 869546, XrefRangeStart = 869520, XrefRangeEnd = 869531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_asDateTime_Private_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00054388 File Offset: 0x00052588
		public unsafe DateTime AsLocalTime
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 869554, RefRangeEnd = 869581, XrefRangeStart = 869546, XrefRangeEnd = 869554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_AsLocalTime_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000543CC File Offset: 0x000525CC
		[CallerCount(0)]
		public unsafe WargTime(long timestamp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WargTime>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timestamp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00054418 File Offset: 0x00052618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869581, XrefRangeEnd = 869585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00054478 File Offset: 0x00052678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869585, XrefRangeEnd = 869592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WargTime operator -(WargTime left, TimeSpan right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_WargTime_WargTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new WargTime(intPtr);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000544C8 File Offset: 0x000526C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869592, XrefRangeEnd = 869599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WargTime operator +(WargTime left, TimeSpan right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_Addition_Public_Static_WargTime_WargTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new WargTime(intPtr);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00054518 File Offset: 0x00052718
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 869599, RefRangeEnd = 869606, XrefRangeStart = 869599, XrefRangeEnd = 869599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WargTime FromMilliseconds(long ms)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ms;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_FromMilliseconds_Public_Static_WargTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00054550 File Offset: 0x00052750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869606, XrefRangeEnd = 869611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000545A4 File Offset: 0x000527A4
		[CallerCount(0)]
		public unsafe bool Equals(WargTime other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WargTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000545FC File Offset: 0x000527FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869611, XrefRangeEnd = 869612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00054640 File Offset: 0x00052840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869612, XrefRangeEnd = 869613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(WargTime other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_WargTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00054698 File Offset: 0x00052898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869613, XrefRangeEnd = 869625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WargTime AddMonths(int months)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref months;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_AddMonths_Public_WargTime_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x000546E4 File Offset: 0x000528E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869625, XrefRangeEnd = 869637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WargTime AddDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_AddDays_Public_WargTime_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00054730 File Offset: 0x00052930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869637, XrefRangeEnd = 869649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WargTime AddHours(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hours;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_AddHours_Public_WargTime_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0005477C File Offset: 0x0005297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869649, XrefRangeEnd = 869661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WargTime AddTimeSpan(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_AddTimeSpan_Public_WargTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x000547C8 File Offset: 0x000529C8
		public unsafe int Day
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869661, XrefRangeEnd = 869669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0005480C File Offset: 0x00052A0C
		public unsafe int Month
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869669, XrefRangeEnd = 869677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00054850 File Offset: 0x00052A50
		public unsafe int Year
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869677, XrefRangeEnd = 869685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00054894 File Offset: 0x00052A94
		public unsafe int Hour
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869685, XrefRangeEnd = 869693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x000548D8 File Offset: 0x00052AD8
		public unsafe int Minute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869693, XrefRangeEnd = 869701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0005491C File Offset: 0x00052B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869701, XrefRangeEnd = 869706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetYear(Calendar calendar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calendar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_GetYear_Public_Int32_Calendar_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00054970 File Offset: 0x00052B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869706, XrefRangeEnd = 869709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000549D0 File Offset: 0x00052BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869709, XrefRangeEnd = 869712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00054A30 File Offset: 0x00052C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869712, RefRangeEnd = 869713, XrefRangeStart = 869712, XrefRangeEnd = 869712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00054A90 File Offset: 0x00052C90
		[CallerCount(0)]
		public unsafe static bool operator <(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00054AF0 File Offset: 0x00052CF0
		[CallerCount(0)]
		public unsafe static bool operator >=(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00054B50 File Offset: 0x00052D50
		[CallerCount(0)]
		public unsafe static bool operator <=(WargTime left, WargTime right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00054BB0 File Offset: 0x00052DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869713, XrefRangeEnd = 869721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00054BEC File Offset: 0x00052DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869721, XrefRangeEnd = 869729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00054C3C File Offset: 0x00052E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869729, XrefRangeEnd = 869737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_ToString_Public_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00054C8C File Offset: 0x00052E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869737, XrefRangeEnd = 869745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WargTime.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000079FF File Offset: 0x00005BFF
		public WargTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00007A08 File Offset: 0x00005C08
		public WargTime()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WargTime>.NativeClassPtr))
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00054CEC File Offset: 0x00052EEC
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00007A1A File Offset: 0x00005C1A
		public unsafe long timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargTime.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargTime.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x00054D14 File Offset: 0x00052F14
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x00007A35 File Offset: 0x00005C35
		public Nullable<DateTime> _asDateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargTime.NativeFieldInfoPtr__asDateTime);
				return new Nullable<DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WargTime.NativeFieldInfoPtr__asDateTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00054D44 File Offset: 0x00052F44
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x00007A63 File Offset: 0x00005C63
		public unsafe static WargTime MinValue
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(WargTime.NativeFieldInfoPtr_MinValue, intPtr);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WargTime.NativeFieldInfoPtr_MinValue, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00054D80 File Offset: 0x00052F80
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x00007A7A File Offset: 0x00005C7A
		public unsafe static WargTime MaxValue
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(WargTime.NativeFieldInfoPtr_MaxValue, intPtr);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WargTime.NativeFieldInfoPtr_MaxValue, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr__asDateTime;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_asDateTime_Private_get_DateTime_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_get_AsLocalTime_Public_get_DateTime_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_WargTime_WargTime_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_WargTime_WargTime_TimeSpan_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_WargTime_WargTime_TimeSpan_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_FromMilliseconds_Public_Static_WargTime_Int64_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WargTime_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_WargTime_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_AddMonths_Public_WargTime_Int32_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_AddDays_Public_WargTime_Int32_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_AddHours_Public_WargTime_Int32_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_AddTimeSpan_Public_WargTime_TimeSpan_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Int32_Calendar_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_WargTime_WargTime_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001FC RID: 508
	[StructLayout(2)]
	public struct XsdDuration
	{
		// Token: 0x06002C9B RID: 11419 RVA: 0x000CDEC4 File Offset: 0x000CC0C4
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDuration()
		{
			Il2CppClassPointerStore<XsdDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr);
			XsdDuration.NativeFieldInfoPtr_years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "years");
			XsdDuration.NativeFieldInfoPtr_months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "months");
			XsdDuration.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "days");
			XsdDuration.NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "hours");
			XsdDuration.NativeFieldInfoPtr_minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "minutes");
			XsdDuration.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "seconds");
			XsdDuration.NativeFieldInfoPtr_nanoseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "nanoseconds");
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669750);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669751);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669752);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669753);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669754);
			XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669755);
			XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669756);
			XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669757);
			XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669758);
			XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669759);
			XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669760);
			XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669761);
			XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669762);
			XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669763);
			XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669764);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669765);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669766);
			XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669767);
			XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669768);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669769);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669770);
			XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669771);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000CE138 File Offset: 0x000CC338
		[CallerCount(0)]
		public unsafe XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isNegative;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref years;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref months;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref days;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nanoseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000CE1CC File Offset: 0x000CC3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424716, RefRangeEnd = 424717, XrefRangeStart = 424715, XrefRangeEnd = 424716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(TimeSpan timeSpan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000CE200 File Offset: 0x000CC400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424720, RefRangeEnd = 424724, XrefRangeStart = 424717, XrefRangeEnd = 424720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000CE240 File Offset: 0x000CC440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424725, RefRangeEnd = 424726, XrefRangeStart = 424724, XrefRangeEnd = 424725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000CE278 File Offset: 0x000CC478
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424727, RefRangeEnd = 424731, XrefRangeStart = 424726, XrefRangeEnd = 424727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000CE2BC File Offset: 0x000CC4BC
		public unsafe bool IsNegative
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x000CE2EC File Offset: 0x000CC4EC
		public unsafe int Years
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000CE31C File Offset: 0x000CC51C
		public unsafe int Months
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x000CE34C File Offset: 0x000CC54C
		public unsafe int Days
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000CE37C File Offset: 0x000CC57C
		public unsafe int Hours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x000CE3AC File Offset: 0x000CC5AC
		public unsafe int Minutes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000CE3DC File Offset: 0x000CC5DC
		public unsafe int Seconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000CE40C File Offset: 0x000CC60C
		public unsafe int Nanoseconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000CE43C File Offset: 0x000CC63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424732, RefRangeEnd = 424733, XrefRangeStart = 424731, XrefRangeEnd = 424732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ToTimeSpan()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000CE46C File Offset: 0x000CC66C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 424734, RefRangeEnd = 424737, XrefRangeStart = 424733, XrefRangeEnd = 424734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000CE4AC File Offset: 0x000CC6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424738, RefRangeEnd = 424739, XrefRangeStart = 424737, XrefRangeEnd = 424738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(out TimeSpan result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000CE4EC File Offset: 0x000CC6EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 424744, RefRangeEnd = 424749, XrefRangeStart = 424739, XrefRangeEnd = 424744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000CE53C File Offset: 0x000CC73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424750, RefRangeEnd = 424751, XrefRangeStart = 424749, XrefRangeEnd = 424750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000CE568 File Offset: 0x000CC768
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424807, RefRangeEnd = 424811, XrefRangeStart = 424751, XrefRangeEnd = 424807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000CE5A0 File Offset: 0x000CC7A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424812, RefRangeEnd = 424813, XrefRangeStart = 424811, XrefRangeEnd = 424812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000CE5F4 File Offset: 0x000CC7F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424882, RefRangeEnd = 424886, XrefRangeStart = 424813, XrefRangeEnd = 424882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000CE654 File Offset: 0x000CC854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424886, XrefRangeEnd = 424890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eatDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &numDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000126A6 File Offset: 0x000108A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, ref this));
		}

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeFieldInfoPtr_years;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeFieldInfoPtr_months;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeFieldInfoPtr_days;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeFieldInfoPtr_hours;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeFieldInfoPtr_minutes;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeFieldInfoPtr_seconds;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeFieldInfoPtr_nanoseconds;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_get_Years_Public_get_Int32_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_get_Months_Public_get_Int32_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_get_Days_Public_get_Int32_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_DurationType_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04002220 RID: 8736
		[FieldOffset(0)]
		public int years;

		// Token: 0x04002221 RID: 8737
		[FieldOffset(4)]
		public int months;

		// Token: 0x04002222 RID: 8738
		[FieldOffset(8)]
		public int days;

		// Token: 0x04002223 RID: 8739
		[FieldOffset(12)]
		public int hours;

		// Token: 0x04002224 RID: 8740
		[FieldOffset(16)]
		public int minutes;

		// Token: 0x04002225 RID: 8741
		[FieldOffset(20)]
		public int seconds;

		// Token: 0x04002226 RID: 8742
		[FieldOffset(24)]
		public uint nanoseconds;

		// Token: 0x0200027E RID: 638
		public enum Parts
		{
			// Token: 0x040027DA RID: 10202
			HasNone,
			// Token: 0x040027DB RID: 10203
			HasYears,
			// Token: 0x040027DC RID: 10204
			HasMonths,
			// Token: 0x040027DD RID: 10205
			HasDays = 4,
			// Token: 0x040027DE RID: 10206
			HasHours = 8,
			// Token: 0x040027DF RID: 10207
			HasMinutes = 16,
			// Token: 0x040027E0 RID: 10208
			HasSeconds = 32
		}

		// Token: 0x0200027F RID: 639
		public enum DurationType
		{
			// Token: 0x040027E2 RID: 10210
			Duration,
			// Token: 0x040027E3 RID: 10211
			YearMonthDuration,
			// Token: 0x040027E4 RID: 10212
			DayTimeDuration
		}
	}
}

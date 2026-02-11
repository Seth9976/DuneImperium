using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000014 RID: 20
	public class LoggerFilterRule : Object
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00004450 File Offset: 0x00002650
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerFilterRule()
		{
			Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerFilterRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr);
			LoggerFilterRule.NativeFieldInfoPtr__ProviderName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, "<ProviderName>k__BackingField");
			LoggerFilterRule.NativeFieldInfoPtr__CategoryName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, "<CategoryName>k__BackingField");
			LoggerFilterRule.NativeFieldInfoPtr__LogLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, "<LogLevel>k__BackingField");
			LoggerFilterRule.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, "<Filter>k__BackingField");
			LoggerFilterRule.NativeMethodInfoPtr_get_ProviderName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, 100663354);
			LoggerFilterRule.NativeMethodInfoPtr_get_CategoryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, 100663355);
			LoggerFilterRule.NativeMethodInfoPtr_get_LogLevel_Public_get_Nullable_1_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, 100663356);
			LoggerFilterRule.NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterRule>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004520 File Offset: 0x00002720
		public unsafe string ProviderName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterRule.NativeMethodInfoPtr_get_ProviderName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004558 File Offset: 0x00002758
		public unsafe string CategoryName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterRule.NativeMethodInfoPtr_get_CategoryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004590 File Offset: 0x00002790
		public unsafe Nullable<LogLevel> LogLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterRule.NativeMethodInfoPtr_get_LogLevel_Public_get_Nullable_1_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<LogLevel>(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe Func<string, string, LogLevel, bool> Filter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterRule.NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<string, string, LogLevel, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000024A1 File Offset: 0x000006A1
		public LoggerFilterRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004608 File Offset: 0x00002808
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000024AA File Offset: 0x000006AA
		public unsafe string _ProviderName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__ProviderName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__ProviderName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004630 File Offset: 0x00002830
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000024C9 File Offset: 0x000006C9
		public unsafe string _CategoryName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__CategoryName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__CategoryName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004658 File Offset: 0x00002858
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000024E8 File Offset: 0x000006E8
		public Nullable<LogLevel> _LogLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__LogLevel_k__BackingField);
				return new Nullable<LogLevel>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Il2CppMicrosoft.Extensions.Logging.LogLevel>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__LogLevel_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Il2CppMicrosoft.Extensions.Logging.LogLevel>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004688 File Offset: 0x00002888
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002516 File Offset: 0x00000716
		public unsafe Func<string, string, LogLevel, bool> _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, LogLevel, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterRule.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr__ProviderName_k__BackingField;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr__CategoryName_k__BackingField;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr__LogLevel_k__BackingField;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderName_Public_get_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoryName_Public_get_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_LogLevel_Public_get_Nullable_1_LogLevel_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0;
	}
}

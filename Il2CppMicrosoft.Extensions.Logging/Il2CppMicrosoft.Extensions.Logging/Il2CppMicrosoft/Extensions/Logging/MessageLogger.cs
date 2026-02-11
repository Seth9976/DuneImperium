using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000015 RID: 21
	public sealed class MessageLogger : ValueType
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000046B8 File Offset: 0x000028B8
		// Note: this type is marked as 'beforefieldinit'.
		static MessageLogger()
		{
			Il2CppClassPointerStore<MessageLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "MessageLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr);
			MessageLogger.NativeFieldInfoPtr__Logger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, "<Logger>k__BackingField");
			MessageLogger.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, "<Category>k__BackingField");
			MessageLogger.NativeFieldInfoPtr__ProviderTypeFullName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, "<ProviderTypeFullName>k__BackingField");
			MessageLogger.NativeFieldInfoPtr__MinLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, "<MinLevel>k__BackingField");
			MessageLogger.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, "<Filter>k__BackingField");
			MessageLogger.NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_String_Nullable_1_LogLevel_Func_4_String_String_LogLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663358);
			MessageLogger.NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663359);
			MessageLogger.NativeMethodInfoPtr_get_Category_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663360);
			MessageLogger.NativeMethodInfoPtr_get_ProviderTypeFullName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663361);
			MessageLogger.NativeMethodInfoPtr_get_MinLevel_Public_get_Nullable_1_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663362);
			MessageLogger.NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663363);
			MessageLogger.NativeMethodInfoPtr_IsEnabled_Public_Boolean_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr, 100663364);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000047D8 File Offset: 0x000029D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264333, XrefRangeEnd = 1264337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageLogger(ILogger logger, string category, string providerTypeFullName, Nullable<LogLevel> minLevel, Func<string, string, LogLevel, bool> filter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerTypeFullName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(minLevel));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_String_Nullable_1_LogLevel_Func_4_String_String_LogLevel_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004878 File Offset: 0x00002A78
		public unsafe ILogger Logger
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000048BC File Offset: 0x00002ABC
		public unsafe string Category
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_get_Category_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000048F8 File Offset: 0x00002AF8
		public unsafe string ProviderTypeFullName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_get_ProviderTypeFullName_Private_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004934 File Offset: 0x00002B34
		public unsafe Nullable<LogLevel> MinLevel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_get_MinLevel_Public_get_Nullable_1_LogLevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<LogLevel>(intPtr);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004970 File Offset: 0x00002B70
		public unsafe Func<string, string, LogLevel, bool> Filter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<string, string, LogLevel, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000049B4 File Offset: 0x00002BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264339, RefRangeEnd = 1264340, XrefRangeStart = 1264337, XrefRangeEnd = 1264339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(LogLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageLogger.NativeMethodInfoPtr_IsEnabled_Public_Boolean_LogLevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002535 File Offset: 0x00000735
		public MessageLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000253E File Offset: 0x0000073E
		public MessageLogger()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageLogger>.NativeClassPtr))
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004A04 File Offset: 0x00002C04
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002550 File Offset: 0x00000750
		public unsafe ILogger _Logger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Logger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Logger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004A34 File Offset: 0x00002C34
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000256F File Offset: 0x0000076F
		public unsafe string _Category_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Category_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Category_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004A5C File Offset: 0x00002C5C
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000258E File Offset: 0x0000078E
		public unsafe string _ProviderTypeFullName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__ProviderTypeFullName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__ProviderTypeFullName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000025AD File Offset: 0x000007AD
		public Nullable<LogLevel> _MinLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__MinLevel_k__BackingField);
				return new Nullable<LogLevel>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<LogLevel>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__MinLevel_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<LogLevel>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004AB4 File Offset: 0x00002CB4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000025DB File Offset: 0x000007DB
		public unsafe Func<string, string, LogLevel, bool> _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, LogLevel, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageLogger.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__Logger_k__BackingField;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__Category_k__BackingField;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__ProviderTypeFullName_k__BackingField;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr__MinLevel_k__BackingField;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_String_Nullable_1_LogLevel_Func_4_String_String_LogLevel_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_get_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderTypeFullName_Private_get_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLevel_Public_get_Nullable_1_LogLevel_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_Func_4_String_String_LogLevel_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_LogLevel_0;
	}
}

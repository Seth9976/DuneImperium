using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection;
using Il2CppMicrosoft.Extensions.Options;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000010 RID: 16
	public class LoggerFactory : Object
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000037DC File Offset: 0x000019DC
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerFactory()
		{
			Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr);
			LoggerFactory.NativeFieldInfoPtr__loggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_loggers");
			LoggerFactory.NativeFieldInfoPtr__providerRegistrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_providerRegistrations");
			LoggerFactory.NativeFieldInfoPtr__sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_sync");
			LoggerFactory.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_disposed");
			LoggerFactory.NativeFieldInfoPtr__changeTokenRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_changeTokenRegistration");
			LoggerFactory.NativeFieldInfoPtr__filterOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_filterOptions");
			LoggerFactory.NativeFieldInfoPtr__scopeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_scopeProvider");
			LoggerFactory.NativeFieldInfoPtr__factoryOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "_factoryOptions");
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663327);
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663328);
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663329);
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663330);
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663331);
			LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_IExternalScopeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663332);
			LoggerFactory.NativeMethodInfoPtr_Create_Public_Static_ILoggerFactory_Action_1_ILoggingBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663333);
			LoggerFactory.NativeMethodInfoPtr_RefreshFilters_Private_Void_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663334);
			LoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663335);
			LoggerFactory.NativeMethodInfoPtr_AddProviderRegistration_Private_Void_ILoggerProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663336);
			LoggerFactory.NativeMethodInfoPtr_CreateLoggers_Private_Il2CppReferenceArray_1_LoggerInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663337);
			LoggerFactory.NativeMethodInfoPtr_ApplyFilters_Private_ValueTuple_2_Il2CppReferenceArray_1_MessageLogger_Il2CppReferenceArray_1_ScopeLogger_Il2CppReferenceArray_1_LoggerInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663338);
			LoggerFactory.NativeMethodInfoPtr_CheckDisposed_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663339);
			LoggerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, 100663340);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000039C4 File Offset: 0x00001BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263983, XrefRangeEnd = 1264006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003A00 File Offset: 0x00001C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264006, XrefRangeEnd = 1264023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory(IEnumerable<ILoggerProvider> providers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003A4C File Offset: 0x00001C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264023, XrefRangeEnd = 1264029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory(IEnumerable<ILoggerProvider> providers, LoggerFilterOptions filterOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003AAC File Offset: 0x00001CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264029, XrefRangeEnd = 1264030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory(IEnumerable<ILoggerProvider> providers, IOptionsMonitor<LoggerFilterOptions> filterOption)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterOption);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003B0C File Offset: 0x00001D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264030, XrefRangeEnd = 1264031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory(IEnumerable<ILoggerProvider> providers, IOptionsMonitor<LoggerFilterOptions> filterOption, IOptions<LoggerFactoryOptions> options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterOption);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003B7C File Offset: 0x00001D7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1264102, RefRangeEnd = 1264107, XrefRangeStart = 1264031, XrefRangeEnd = 1264102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactory(IEnumerable<ILoggerProvider> providers, IOptionsMonitor<LoggerFilterOptions> filterOption, IOptions<LoggerFactoryOptions> options = null, IExternalScopeProvider scopeProvider = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterOption);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopeProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_IExternalScopeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003C00 File Offset: 0x00001E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1264151, RefRangeEnd = 1264154, XrefRangeStart = 1264107, XrefRangeEnd = 1264151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ILoggerFactory Create(Action<ILoggingBuilder> configure)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(configure);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_Create_Public_Static_ILoggerFactory_Action_1_ILoggingBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr3) : null;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003C44 File Offset: 0x00001E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264179, RefRangeEnd = 1264180, XrefRangeStart = 1264154, XrefRangeEnd = 1264179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFilters(LoggerFilterOptions filterOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterOptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_RefreshFilters_Private_Void_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003C88 File Offset: 0x00001E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264180, XrefRangeEnd = 1264202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger CreateLogger(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264225, RefRangeEnd = 1264226, XrefRangeStart = 1264202, XrefRangeEnd = 1264225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProviderRegistration(ILoggerProvider provider, bool dispose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispose;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_AddProviderRegistration_Private_Void_ILoggerProvider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003D28 File Offset: 0x00001F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264245, RefRangeEnd = 1264246, XrefRangeStart = 1264226, XrefRangeEnd = 1264245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<LoggerInformation> CreateLoggers(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_CreateLoggers_Private_Il2CppReferenceArray_1_LoggerInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoggerInformation>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003D78 File Offset: 0x00001F78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264289, RefRangeEnd = 1264291, XrefRangeStart = 1264246, XrefRangeEnd = 1264289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Il2CppReferenceArray<MessageLogger>, Il2CppReferenceArray<ScopeLogger>> ApplyFilters(Il2CppReferenceArray<LoggerInformation> loggers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loggers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_ApplyFilters_Private_ValueTuple_2_Il2CppReferenceArray_1_MessageLogger_Il2CppReferenceArray_1_ScopeLogger_Il2CppReferenceArray_1_LoggerInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Il2CppReferenceArray<MessageLogger>, Il2CppReferenceArray<ScopeLogger>>(intPtr);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264291, XrefRangeEnd = 1264292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoggerFactory.NativeMethodInfoPtr_CheckDisposed_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003E08 File Offset: 0x00002008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264292, XrefRangeEnd = 1264314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022DF File Offset: 0x000004DF
		public LoggerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003E3C File Offset: 0x0000203C
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000022E8 File Offset: 0x000004E8
		public unsafe ConcurrentDictionary<string, Logger> _loggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__loggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, Logger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__loggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003E6C File Offset: 0x0000206C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002307 File Offset: 0x00000507
		public unsafe List<LoggerFactory.ProviderRegistration> _providerRegistrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__providerRegistrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoggerFactory.ProviderRegistration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__providerRegistrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003E9C File Offset: 0x0000209C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe Object _sync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__sync);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__sync), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003ECC File Offset: 0x000020CC
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002345 File Offset: 0x00000545
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003EF4 File Offset: 0x000020F4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002360 File Offset: 0x00000560
		public unsafe IDisposable _changeTokenRegistration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__changeTokenRegistration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__changeTokenRegistration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003F24 File Offset: 0x00002124
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe LoggerFilterOptions _filterOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__filterOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggerFilterOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__filterOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003F54 File Offset: 0x00002154
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe IExternalScopeProvider _scopeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__scopeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExternalScopeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__scopeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003F84 File Offset: 0x00002184
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000023BD File Offset: 0x000005BD
		public unsafe LoggerFactoryOptions _factoryOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__factoryOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggerFactoryOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.NativeFieldInfoPtr__factoryOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__loggers;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__providerRegistrations;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__sync;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr__changeTokenRegistration;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr__filterOptions;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr__scopeProvider;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr__factoryOptions;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_LoggerFilterOptions_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ILoggerProvider_IOptionsMonitor_1_LoggerFilterOptions_IOptions_1_LoggerFactoryOptions_IExternalScopeProvider_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ILoggerFactory_Action_1_ILoggingBuilder_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFilters_Private_Void_LoggerFilterOptions_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_AddProviderRegistration_Private_Void_ILoggerProvider_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_CreateLoggers_Private_Il2CppReferenceArray_1_LoggerInformation_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFilters_Private_ValueTuple_2_Il2CppReferenceArray_1_MessageLogger_Il2CppReferenceArray_1_ScopeLogger_Il2CppReferenceArray_1_LoggerInformation_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000021 RID: 33
		public sealed class ProviderRegistration : ValueType
		{
			// Token: 0x060000E3 RID: 227 RVA: 0x00005580 File Offset: 0x00003780
			// Note: this type is marked as 'beforefieldinit'.
			static ProviderRegistration()
			{
				Il2CppClassPointerStore<LoggerFactory.ProviderRegistration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "ProviderRegistration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactory.ProviderRegistration>.NativeClassPtr);
				LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory.ProviderRegistration>.NativeClassPtr, "Provider");
				LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_ShouldDispose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory.ProviderRegistration>.NativeClassPtr, "ShouldDispose");
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00002810 File Offset: 0x00000A10
			public ProviderRegistration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00002819 File Offset: 0x00000A19
			public ProviderRegistration()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory.ProviderRegistration>.NativeClassPtr))
			{
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000055D4 File Offset: 0x000037D4
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000282B File Offset: 0x00000A2B
			public unsafe ILoggerProvider Provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_Provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoggerProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_Provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005604 File Offset: 0x00003804
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000284A File Offset: 0x00000A4A
			public unsafe bool ShouldDispose
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_ShouldDispose);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.ProviderRegistration.NativeFieldInfoPtr_ShouldDispose)) = value;
				}
			}

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeFieldInfoPtr_Provider;

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeFieldInfoPtr_ShouldDispose;
		}

		// Token: 0x02000022 RID: 34
		public sealed class DisposingLoggerFactory : Object
		{
			// Token: 0x060000EA RID: 234 RVA: 0x0000562C File Offset: 0x0000382C
			// Note: this type is marked as 'beforefieldinit'.
			static DisposingLoggerFactory()
			{
				Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "DisposingLoggerFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr);
				LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__loggerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr, "_loggerFactory");
				LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__serviceProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr, "_serviceProvider");
				LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr, 100663341);
				LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr, 100663342);
				LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr, 100663343);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x000056BC File Offset: 0x000038BC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisposingLoggerFactory(ILoggerFactory loggerFactory, ServiceProvider serviceProvider)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactory.DisposingLoggerFactory>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(loggerFactory);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000EC RID: 236 RVA: 0x0000571C File Offset: 0x0000391C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263977, XrefRangeEnd = 1263979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00005750 File Offset: 0x00003950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263979, XrefRangeEnd = 1263983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ILogger CreateLogger(string categoryName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactory.DisposingLoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
				}
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00002865 File Offset: 0x00000A65
			public DisposingLoggerFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000EF RID: 239 RVA: 0x000057A0 File Offset: 0x000039A0
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000286E File Offset: 0x00000A6E
			public unsafe ILoggerFactory _loggerFactory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__loggerFactory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__loggerFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000F1 RID: 241 RVA: 0x000057D0 File Offset: 0x000039D0
			// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000288D File Offset: 0x00000A8D
			public unsafe ServiceProvider _serviceProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__serviceProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactory.DisposingLoggerFactory.NativeFieldInfoPtr__serviceProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeFieldInfoPtr__loggerFactory;

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr__serviceProvider;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_ServiceProvider_0;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0;
		}

		// Token: 0x02000023 RID: 35
		public sealed class LoggerFactoryDebugView : Object
		{
			// Token: 0x060000F3 RID: 243 RVA: 0x000028AC File Offset: 0x00000AAC
			// Note: this type is marked as 'beforefieldinit'.
			static LoggerFactoryDebugView()
			{
				Il2CppClassPointerStore<LoggerFactory.LoggerFactoryDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoggerFactory>.NativeClassPtr, "LoggerFactoryDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactory.LoggerFactoryDebugView>.NativeClassPtr);
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x000028CC File Offset: 0x00000ACC
			public LoggerFactoryDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}

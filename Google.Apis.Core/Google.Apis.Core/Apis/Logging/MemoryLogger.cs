using System;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Logging
{
	// Token: 0x0200001C RID: 28
	public sealed class MemoryLogger : BaseLogger
	{
		// Token: 0x06000124 RID: 292 RVA: 0x000086FC File Offset: 0x000068FC
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryLogger()
		{
			Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Logging", "MemoryLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr);
			MemoryLogger.NativeFieldInfoPtr__maximumEntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, "_maximumEntryCount");
			MemoryLogger.NativeFieldInfoPtr__logEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, "_logEntries");
			MemoryLogger.NativeFieldInfoPtr__LogEntries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, "<LogEntries>k__BackingField");
			MemoryLogger.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Int32_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, 100663466);
			MemoryLogger.NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Int32_IClock_List_1_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, 100663467);
			MemoryLogger.NativeMethodInfoPtr_get_LogEntries_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, 100663468);
			MemoryLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, 100663469);
			MemoryLogger.NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr, 100663470);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000087CC File Offset: 0x000069CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211102, XrefRangeEnd = 1211109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryLogger(LogLevel minimumLogLevel, int maximumEntryCount = 1000, IClock clock = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLogLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumEntryCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryLogger.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Int32_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008834 File Offset: 0x00006A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1211118, RefRangeEnd = 1211120, XrefRangeStart = 1211109, XrefRangeEnd = 1211118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryLogger(LogLevel minimumLogLevel, int maximumEntryCount, IClock clock, List<string> logEntries, Type forType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLogLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumEntryCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logEntries);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryLogger.NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Int32_IClock_List_1_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000088C4 File Offset: 0x00006AC4
		public unsafe IList<string> LogEntries
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryLogger.NativeMethodInfoPtr_get_LogEntries_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008904 File Offset: 0x00006B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211120, XrefRangeEnd = 1211124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ILogger BuildNewLogger(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008954 File Offset: 0x00006B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211124, XrefRangeEnd = 1211132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Log(LogLevel logLevel, string formattedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formattedMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryLogger.NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000026B3 File Offset: 0x000008B3
		public MemoryLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000089A4 File Offset: 0x00006BA4
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000026BC File Offset: 0x000008BC
		public unsafe int _maximumEntryCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__maximumEntryCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__maximumEntryCount)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000089CC File Offset: 0x00006BCC
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000026D7 File Offset: 0x000008D7
		public unsafe List<string> _logEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__logEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__logEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000089FC File Offset: 0x00006BFC
		// (set) Token: 0x06000130 RID: 304 RVA: 0x000026F6 File Offset: 0x000008F6
		public unsafe IList<string> _LogEntries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__LogEntries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryLogger.NativeFieldInfoPtr__LogEntries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__maximumEntryCount;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__logEntries;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__LogEntries_k__BackingField;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Int32_IClock_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Int32_IClock_List_1_String_Type_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_LogEntries_Public_get_IList_1_String_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0;
	}
}

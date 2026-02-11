using System;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Logging
{
	// Token: 0x02000019 RID: 25
	public sealed class ConsoleLogger : BaseLogger
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00008084 File Offset: 0x00006284
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleLogger()
		{
			Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Logging", "ConsoleLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr);
			ConsoleLogger.NativeFieldInfoPtr__LogToStdOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, "<LogToStdOut>k__BackingField");
			ConsoleLogger.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Boolean_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, 100663453);
			ConsoleLogger.NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Boolean_IClock_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, 100663454);
			ConsoleLogger.NativeMethodInfoPtr_get_LogToStdOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, 100663455);
			ConsoleLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, 100663456);
			ConsoleLogger.NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr, 100663457);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000812C File Offset: 0x0000632C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211082, XrefRangeEnd = 1211083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleLogger(LogLevel minimumLogLevel, bool logToStdOut = false, IClock clock = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLogLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logToStdOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleLogger.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Boolean_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008194 File Offset: 0x00006394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211083, XrefRangeEnd = 1211084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleLogger(LogLevel minimumLogLevel, bool logToStdOut, IClock clock, Type forType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLogLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logToStdOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleLogger.NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Boolean_IClock_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00008210 File Offset: 0x00006410
		public unsafe bool LogToStdOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleLogger.NativeMethodInfoPtr_get_LogToStdOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000824C File Offset: 0x0000644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211084, XrefRangeEnd = 1211088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ILogger BuildNewLogger(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000829C File Offset: 0x0000649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211088, XrefRangeEnd = 1211102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleLogger.NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000263A File Offset: 0x0000083A
		public ConsoleLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000082EC File Offset: 0x000064EC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe bool _LogToStdOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleLogger.NativeFieldInfoPtr__LogToStdOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleLogger.NativeFieldInfoPtr__LogToStdOut_k__BackingField)) = value;
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr__LogToStdOut_k__BackingField;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogLevel_Boolean_IClock_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_LogLevel_Boolean_IClock_Type_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_LogToStdOut_Public_get_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_BuildNewLogger_Protected_Virtual_ILogger_Type_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Log_Protected_Virtual_Void_LogLevel_String_0;
	}
}

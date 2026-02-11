using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000090 RID: 144
	public class LogDispatcher : MonoBehaviour
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x0003A7D4 File Offset: 0x000389D4
		// Note: this type is marked as 'beforefieldinit'.
		static LogDispatcher()
		{
			Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "LogDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr);
			LogDispatcher.NativeFieldInfoPtr_logMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, "logMessageReceived");
			LogDispatcher.NativeFieldInfoPtr_processors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, "processors");
			LogDispatcher.NativeFieldInfoPtr_pending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, "pending");
			LogDispatcher.NativeMethodInfoPtr_add_logMessageReceived_Public_add_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664717);
			LogDispatcher.NativeMethodInfoPtr_remove_logMessageReceived_Public_rem_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664718);
			LogDispatcher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664719);
			LogDispatcher.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664720);
			LogDispatcher.NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664721);
			LogDispatcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664722);
			LogDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, 100664723);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0003A8CC File Offset: 0x00038ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862675, RefRangeEnd = 862677, XrefRangeStart = 862671, XrefRangeEnd = 862675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_logMessageReceived(Application.LogCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_add_logMessageReceived_Public_add_Void_LogCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0003A910 File Offset: 0x00038B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862681, RefRangeEnd = 862683, XrefRangeStart = 862677, XrefRangeEnd = 862681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_logMessageReceived(Application.LogCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_remove_logMessageReceived_Public_rem_Void_LogCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0003A954 File Offset: 0x00038B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862683, XrefRangeEnd = 862697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0003A988 File Offset: 0x00038B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862697, XrefRangeEnd = 862707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0003A9BC File Offset: 0x00038BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862707, XrefRangeEnd = 862712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLog(string logString, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0003AA20 File Offset: 0x00038C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862712, XrefRangeEnd = 862718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0003AA54 File Offset: 0x00038C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862718, XrefRangeEnd = 862743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00005A14 File Offset: 0x00003C14
		public LogDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0003AA90 File Offset: 0x00038C90
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00005A1D File Offset: 0x00003C1D
		public unsafe Application.LogCallback logMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_logMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_logMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0003AAC0 File Offset: 0x00038CC0
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00005A3C File Offset: 0x00003C3C
		public unsafe Il2CppReferenceArray<LogProcessor> processors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_processors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LogProcessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_processors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0003AAF0 File Offset: 0x00038CF0
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00005A5B File Offset: 0x00003C5B
		public unsafe ConcurrentQueue<LogDispatcher.LogEntry> pending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_pending);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<LogDispatcher.LogEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.NativeFieldInfoPtr_pending), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_logMessageReceived;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_processors;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_pending;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_add_logMessageReceived_Public_add_Void_LogCallback_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_remove_logMessageReceived_Public_rem_Void_LogCallback_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028C RID: 652
		public sealed class LogEntry : ValueType
		{
			// Token: 0x06001F50 RID: 8016 RVA: 0x0008E4D8 File Offset: 0x0008C6D8
			// Note: this type is marked as 'beforefieldinit'.
			static LogEntry()
			{
				Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, "LogEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr);
				LogDispatcher.LogEntry.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr, "Log");
				LogDispatcher.LogEntry.NativeFieldInfoPtr_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr, "Stack");
				LogDispatcher.LogEntry.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr, "Type");
				LogDispatcher.LogEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr, 100664724);
			}

			// Token: 0x06001F51 RID: 8017 RVA: 0x0008E554 File Offset: 0x0008C754
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 862668, RefRangeEnd = 862671, XrefRangeStart = 862666, XrefRangeEnd = 862668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogEntry(string log, string stack, LogType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stack);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.LogEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F52 RID: 8018 RVA: 0x0000D56D File Offset: 0x0000B76D
			public LogEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F53 RID: 8019 RVA: 0x0000D576 File Offset: 0x0000B776
			public LogEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogDispatcher.LogEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06001F54 RID: 8020 RVA: 0x0008E5C4 File Offset: 0x0008C7C4
			// (set) Token: 0x06001F55 RID: 8021 RVA: 0x0000D588 File Offset: 0x0000B788
			public unsafe string Log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Log);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Log), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0008E5EC File Offset: 0x0008C7EC
			// (set) Token: 0x06001F57 RID: 8023 RVA: 0x0000D5A7 File Offset: 0x0000B7A7
			public unsafe string Stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Stack);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Stack), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0008E614 File Offset: 0x0008C814
			// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0000D5C6 File Offset: 0x0000B7C6
			public unsafe LogType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogDispatcher.LogEntry.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeFieldInfoPtr_Log;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr_Stack;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0;
		}

		// Token: 0x0200028D RID: 653
		[ObfuscatedName("dwd.core.util.LogDispatcher+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F5A RID: 8026 RVA: 0x0008E63C File Offset: 0x0008C83C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogDispatcher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr);
				LogDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr, "<>9");
				LogDispatcher.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr, "<>9__10_0");
				LogDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr, 100664726);
				LogDispatcher.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr, 100664727);
			}

			// Token: 0x06001F5B RID: 8027 RVA: 0x0008E6B8 File Offset: 0x0008C8B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogDispatcher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F5C RID: 8028 RVA: 0x0008E6F4 File Offset: 0x0008C8F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__10_0(string <p0>, string <p1>, LogType <p2>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(<p1>);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p2>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogDispatcher.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F5D RID: 8029 RVA: 0x0000D5E1 File Offset: 0x0000B7E1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0008E758 File Offset: 0x0008C958
			// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000D5EA File Offset: 0x0000B7EA
			public unsafe static LogDispatcher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LogDispatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogDispatcher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LogDispatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001F60 RID: 8032 RVA: 0x0008E780 File Offset: 0x0008C980
			// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000D5FC File Offset: 0x0000B7FC
			public unsafe static Application.LogCallback __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LogDispatcher.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LogDispatcher.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_String_String_LogType_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000093 RID: 147
	public class TraceEventCache : Object
	{
		// Token: 0x06000AD4 RID: 2772 RVA: 0x000453C4 File Offset: 0x000435C4
		// Note: this type is marked as 'beforefieldinit'.
		static TraceEventCache()
		{
			Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "TraceEventCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr);
			TraceEventCache.NativeFieldInfoPtr_processId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, "processId");
			TraceEventCache.NativeFieldInfoPtr_processName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, "processName");
			TraceEventCache.NativeFieldInfoPtr_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, "timeStamp");
			TraceEventCache.NativeFieldInfoPtr_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, "dateTime");
			TraceEventCache.NativeFieldInfoPtr_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, "stackTrace");
			TraceEventCache.NativeMethodInfoPtr_get_Callstack_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664916);
			TraceEventCache.NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664917);
			TraceEventCache.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664918);
			TraceEventCache.NativeMethodInfoPtr_get_ProcessId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664919);
			TraceEventCache.NativeMethodInfoPtr_get_ThreadId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664920);
			TraceEventCache.NativeMethodInfoPtr_get_Timestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664921);
			TraceEventCache.NativeMethodInfoPtr_InitProcessInfo_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664922);
			TraceEventCache.NativeMethodInfoPtr_GetProcessId_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664923);
			TraceEventCache.NativeMethodInfoPtr_GetThreadId_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664924);
			TraceEventCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr, 100664925);
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00045520 File Offset: 0x00043720
		public unsafe string Callstack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442815, XrefRangeEnd = 442817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_Callstack_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00045558 File Offset: 0x00043758
		public unsafe Stack LogicalOperationStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442817, XrefRangeEnd = 442840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr3) : null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00045598 File Offset: 0x00043798
		public unsafe DateTime DateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442840, XrefRangeEnd = 442848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000455D4 File Offset: 0x000437D4
		public unsafe int ProcessId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442848, XrefRangeEnd = 442852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_ProcessId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00045610 File Offset: 0x00043810
		public unsafe string ThreadId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442852, XrefRangeEnd = 442859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_ThreadId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00045648 File Offset: 0x00043848
		public unsafe long Timestamp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442859, XrefRangeEnd = 442863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_get_Timestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00045684 File Offset: 0x00043884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442878, RefRangeEnd = 442881, XrefRangeStart = 442863, XrefRangeEnd = 442878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitProcessInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_InitProcessInfo_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000456AC File Offset: 0x000438AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_GetProcessId_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000456DC File Offset: 0x000438DC
		[CallerCount(7918)]
		[CachedScanResults(RefRangeStart = 442884, RefRangeEnd = 450802, XrefRangeStart = 442881, XrefRangeEnd = 442884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetThreadId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr_GetThreadId_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0004570C File Offset: 0x0004390C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 450807, RefRangeEnd = 450808, XrefRangeStart = 450802, XrefRangeEnd = 450807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceEventCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceEventCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceEventCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public TraceEventCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00045748 File Offset: 0x00043948
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public unsafe static int processId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TraceEventCache.NativeFieldInfoPtr_processId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceEventCache.NativeFieldInfoPtr_processId, (void*)(&value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00045764 File Offset: 0x00043964
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00005CE7 File Offset: 0x00003EE7
		public unsafe static string processName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceEventCache.NativeFieldInfoPtr_processName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceEventCache.NativeFieldInfoPtr_processName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00045784 File Offset: 0x00043984
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00005CF9 File Offset: 0x00003EF9
		public unsafe long timeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_timeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_timeStamp)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000457AC File Offset: 0x000439AC
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00005D14 File Offset: 0x00003F14
		public unsafe DateTime dateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_dateTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_dateTime)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000457D4 File Offset: 0x000439D4
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00005D2F File Offset: 0x00003F2F
		public unsafe string stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_stackTrace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceEventCache.NativeFieldInfoPtr_stackTrace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_processId;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_processName;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_timeStamp;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_dateTime;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_stackTrace;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_Callstack_Public_get_String_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessId_Public_get_Int32_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadId_Public_get_String_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_Timestamp_Public_get_Int64_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_InitProcessInfo_Private_Static_Void_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessId_Internal_Static_Int32_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadId_Internal_Static_Int32_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000054 RID: 84
	public sealed class RuntimeThread : Object
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00036210 File Offset: 0x00034410
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeThread()
		{
			Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "RuntimeThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr);
			RuntimeThread.NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, "OptimalMaxSpinWaitsPerSpinIteration");
			RuntimeThread.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, "thread");
			RuntimeThread.NativeMethodInfoPtr__ctor_Private_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663923);
			RuntimeThread.NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663924);
			RuntimeThread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663925);
			RuntimeThread.NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663926);
			RuntimeThread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663927);
			RuntimeThread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663928);
			RuntimeThread.NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663929);
			RuntimeThread.NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663930);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00036308 File Offset: 0x00034508
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeThread(Thread t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr__ctor_Private_Void_Thread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00036354 File Offset: 0x00034554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281183, RefRangeEnd = 1281184, XrefRangeStart = 1281174, XrefRangeEnd = 1281183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeThread>(intPtr3) : null;
		}

		// Token: 0x17000104 RID: 260
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000363A8 File Offset: 0x000345A8
		public unsafe bool IsBackground
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1281186, RefRangeEnd = 1281187, XrefRangeStart = 1281184, XrefRangeEnd = 1281186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000363E8 File Offset: 0x000345E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281189, RefRangeEnd = 1281190, XrefRangeStart = 1281187, XrefRangeEnd = 1281189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0003642C File Offset: 0x0003462C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281191, RefRangeEnd = 1281192, XrefRangeStart = 1281190, XrefRangeEnd = 1281191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sleep(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00036460 File Offset: 0x00034660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281195, RefRangeEnd = 1281196, XrefRangeStart = 1281192, XrefRangeEnd = 1281195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Yield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00036490 File Offset: 0x00034690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281197, RefRangeEnd = 1281198, XrefRangeStart = 1281196, XrefRangeEnd = 1281197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SpinWait(int iterations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iterations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000364D0 File Offset: 0x000346D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCurrentProcessorId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeThread.NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003813 File Offset: 0x00001A13
		public RuntimeThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00036500 File Offset: 0x00034700
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0000381C File Offset: 0x00001A1C
		public unsafe static int OptimalMaxSpinWaitsPerSpinIteration
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RuntimeThread.NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeThread.NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration, (void*)(&value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0003651C File Offset: 0x0003471C
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0000382A File Offset: 0x00001A2A
		public unsafe Thread thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeThread.NativeFieldInfoPtr_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeThread.NativeFieldInfoPtr_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Thread_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0;
	}
}

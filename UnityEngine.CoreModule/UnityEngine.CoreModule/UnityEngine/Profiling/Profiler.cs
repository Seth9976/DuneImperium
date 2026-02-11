using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

namespace UnityEngine.Profiling
{
	// Token: 0x0200018B RID: 395
	public sealed class Profiler : Object
	{
		// Token: 0x06001D7C RID: 7548 RVA: 0x00086ED8 File Offset: 0x000850D8
		// Note: this type is marked as 'beforefieldinit'.
		static Profiler()
		{
			Il2CppClassPointerStore<Profiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Profiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiler>.NativeClassPtr);
			Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100667417);
			Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100667418);
			Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100667419);
			Profiler.get_supportedDelegateField = IL2CPP.ResolveICall<Profiler.get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");
			Profiler.get_logFileDelegateField = IL2CPP.ResolveICall<Profiler.get_logFileDelegate>("UnityEngine.Profiling.Profiler::get_logFile");
			Profiler.set_logFileDelegateField = IL2CPP.ResolveICall<Profiler.set_logFileDelegate>("UnityEngine.Profiling.Profiler::set_logFile");
			Profiler.get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");
			Profiler.set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");
			Profiler.get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");
			Profiler.set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");
			Profiler.get_enabledDelegateField = IL2CPP.ResolveICall<Profiler.get_enabledDelegate>("UnityEngine.Profiling.Profiler::get_enabled");
			Profiler.set_enabledDelegateField = IL2CPP.ResolveICall<Profiler.set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");
			Profiler.get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");
			Profiler.set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");
			Profiler.SetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");
			Profiler.GetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");
			Profiler.AddFramesFromFile_InternalDelegateField = IL2CPP.ResolveICall<Profiler.AddFramesFromFile_InternalDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal");
			Profiler.BeginThreadProfilingInternalDelegateField = IL2CPP.ResolveICall<Profiler.BeginThreadProfilingInternalDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal");
			Profiler.BeginSampleImplDelegateField = IL2CPP.ResolveICall<Profiler.BeginSampleImplDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl");
			Profiler.EndSampleDelegateField = IL2CPP.ResolveICall<Profiler.EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");
			Profiler.get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");
			Profiler.GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");
			Profiler.SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<Profiler.SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");
			Profiler.GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<Profiler.GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");
			Profiler.GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");
			Profiler.GetTotalReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong");
			Profiler.InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<Profiler.InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");
			Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<Profiler.GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");
			Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array");
			Profiler.Internal_EmitGlobalMetaData_NativeDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native");
			Profiler.GetCategoriesCountDelegateField = IL2CPP.ResolveICall<Profiler.GetCategoriesCountDelegate>("UnityEngine.Profiling.Profiler::GetCategoriesCount");
			Profiler.Internal_SetCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_SetCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_SetCategoryEnabled");
			Profiler.Internal_IsCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_IsCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_IsCategoryEnabled");
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00087108 File Offset: 0x00085308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677565, RefRangeEnd = 677566, XrefRangeStart = 677563, XrefRangeEnd = 677565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetRuntimeMemorySizeLong(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0008714C File Offset: 0x0008534C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677568, RefRangeEnd = 677569, XrefRangeStart = 677566, XrefRangeEnd = 677568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetMonoUsedSizeLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0008717C File Offset: 0x0008537C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 677571, RefRangeEnd = 677574, XrefRangeStart = 677569, XrefRangeEnd = 677571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTotalAllocatedMemoryLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0000B032 File Offset: 0x00009232
		public Profiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0000B03B File Offset: 0x0000923B
		public static bool supported
		{
			get
			{
				return Profiler.get_supportedDelegateField();
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000871AC File Offset: 0x000853AC
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000B047 File Offset: 0x00009247
		public static string logFile
		{
			get
			{
				IntPtr intPtr = Profiler.get_logFileDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Profiler.set_logFileDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0000B059 File Offset: 0x00009259
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000B065 File Offset: 0x00009265
		public static bool enableBinaryLog
		{
			get
			{
				return Profiler.get_enableBinaryLogDelegateField();
			}
			set
			{
				Profiler.set_enableBinaryLogDelegateField(value);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0000B072 File Offset: 0x00009272
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000B07E File Offset: 0x0000927E
		public static int maxUsedMemory
		{
			get
			{
				return Profiler.get_maxUsedMemoryDelegateField();
			}
			set
			{
				Profiler.set_maxUsedMemoryDelegateField(value);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0000B08B File Offset: 0x0000928B
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000B097 File Offset: 0x00009297
		public static bool enabled
		{
			get
			{
				return Profiler.get_enabledDelegateField();
			}
			set
			{
				Profiler.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0000B0A4 File Offset: 0x000092A4
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public static bool enableAllocationCallstacks
		{
			get
			{
				return Profiler.get_enableAllocationCallstacksDelegateField();
			}
			set
			{
				Profiler.set_enableAllocationCallstacksDelegateField(value);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0000B0BD File Offset: 0x000092BD
		public static void SetAreaEnabled(ProfilerArea area, bool enabled)
		{
			Profiler.SetAreaEnabledDelegateField(area, enabled);
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000871CC File Offset: 0x000853CC
		public static int areaCount
		{
			get
			{
				return Enum.GetNames(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>())).Length;
			}
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0000B0CB File Offset: 0x000092CB
		public static bool GetAreaEnabled(ProfilerArea area)
		{
			return Profiler.GetAreaEnabledDelegateField(area);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x000871F4 File Offset: 0x000853F4
		public static void AddFramesFromFile(string file)
		{
			bool flag = String.IsNullOrEmpty(file);
			if (flag)
			{
				Debug.LogError("AddFramesFromFile: Invalid or empty path");
			}
			else
			{
				Profiler.AddFramesFromFile_Internal(file, true);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0000B0D8 File Offset: 0x000092D8
		public static void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
		{
			Profiler.AddFramesFromFile_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(file), keepExistingFrames);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00087224 File Offset: 0x00085424
		public static void BeginThreadProfiling(string threadGroupName, string threadName)
		{
			bool flag = String.IsNullOrEmpty(threadGroupName);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string", "threadGroupName");
			}
			bool flag2 = String.IsNullOrEmpty(threadName);
			if (flag2)
			{
				throw new ArgumentException("Argument should be a valid string", "threadName");
			}
			Profiler.BeginThreadProfilingInternal(threadGroupName, threadName);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0000B0EB File Offset: 0x000092EB
		public static void BeginThreadProfilingInternal(string threadGroupName, string threadName)
		{
			Profiler.BeginThreadProfilingInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(threadGroupName), IL2CPP.ManagedStringToIl2Cpp(threadName));
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0000B103 File Offset: 0x00009303
		public static void EndThreadProfiling()
		{
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0000B106 File Offset: 0x00009306
		public static void BeginSample(string name)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, null);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0000B118 File Offset: 0x00009318
		public static void BeginSample(string name, Object targetObject)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, targetObject);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00087270 File Offset: 0x00085470
		public static void ValidateArguments(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string.", "name");
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0000B12A File Offset: 0x0000932A
		public static void BeginSampleImpl(string name, Object targetObject)
		{
			Profiler.BeginSampleImplDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0000B142 File Offset: 0x00009342
		public static void EndSample()
		{
			Profiler.EndSampleDelegateField();
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0008729C File Offset: 0x0008549C
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000B14E File Offset: 0x0000934E
		public static int maxNumberOfSamplesPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000872B0 File Offset: 0x000854B0
		public static uint usedHeapSize
		{
			get
			{
				return (uint)Profiler.usedHeapSizeLong;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0000B151 File Offset: 0x00009351
		public static long usedHeapSizeLong
		{
			get
			{
				return Profiler.get_usedHeapSizeLongDelegateField();
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000872C8 File Offset: 0x000854C8
		public static int GetRuntimeMemorySize(Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000872E4 File Offset: 0x000854E4
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0000B15D File Offset: 0x0000935D
		public static long GetMonoHeapSizeLong()
		{
			return Profiler.GetMonoHeapSizeLongDelegateField();
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000872FC File Offset: 0x000854FC
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0000B169 File Offset: 0x00009369
		public static bool SetTempAllocatorRequestedSize(uint size)
		{
			return Profiler.SetTempAllocatorRequestedSizeDelegateField(size);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000B176 File Offset: 0x00009376
		public static uint GetTempAllocatorSize()
		{
			return Profiler.GetTempAllocatorSizeDelegateField();
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00087314 File Offset: 0x00085514
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0008732C File Offset: 0x0008552C
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0000B182 File Offset: 0x00009382
		public static long GetTotalUnusedReservedMemoryLong()
		{
			return Profiler.GetTotalUnusedReservedMemoryLongDelegateField();
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00087344 File Offset: 0x00085544
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0000B18E File Offset: 0x0000938E
		public static long GetTotalReservedMemoryLong()
		{
			return Profiler.GetTotalReservedMemoryLongDelegateField();
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0008735C File Offset: 0x0008555C
		public static long GetTotalFragmentationInfo(Unity.Collections.NativeArray<int> stats)
		{
			return Profiler.InternalGetTotalFragmentationInfo((IntPtr)stats.GetUnsafePtr<int>(), stats.Length);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0000B19A File Offset: 0x0000939A
		public static long InternalGetTotalFragmentationInfo(IntPtr pStats, int count)
		{
			return Profiler.InternalGetTotalFragmentationInfoDelegateField(pStats, count);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0000B1A8 File Offset: 0x000093A8
		public static long GetAllocatedMemoryForGraphicsDriver()
		{
			return Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField();
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00087388 File Offset: 0x00085588
		public unsafe static void EmitFrameMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), true);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000873F0 File Offset: 0x000855F0
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), true);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), true);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00087464 File Offset: 0x00085664
		public unsafe static void EmitSessionMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), false);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000874CC File Offset: 0x000856CC
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), false);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0000B1DB File Offset: 0x000093DB
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), false);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0000B202 File Offset: 0x00009402
		public unsafe static void Internal_EmitGlobalMetaData_Array(void* id, int idLen, int tag, Array data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField(id, idLen, tag, IL2CPP.Il2CppObjectBaseToPtr(data), count, elementSize, frameData);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000B21D File Offset: 0x0000941D
		public unsafe static void Internal_EmitGlobalMetaData_Native(void* id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_NativeDelegateField(id, idLen, tag, data, count, elementSize, frameData);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00087540 File Offset: 0x00085740
		public static void SetCategoryEnabled(Unity.Profiling.ProfilerCategory category, bool enabled)
		{
			bool flag = category == Unity.Profiling.ProfilerCategory.Any;
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid category", "category");
			}
			Profiler.Internal_SetCategoryEnabled(category, enabled);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00087584 File Offset: 0x00085784
		public static bool IsCategoryEnabled(Unity.Profiling.ProfilerCategory category)
		{
			bool flag = category == Unity.Profiling.ProfilerCategory.Any;
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid category", "category");
			}
			return Profiler.Internal_IsCategoryEnabled(category);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0000B233 File Offset: 0x00009433
		public static uint GetCategoriesCount()
		{
			return Profiler.GetCategoriesCountDelegateField();
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000875C8 File Offset: 0x000857C8
		public static void GetAllCategories(Il2CppStructArray<Unity.Profiling.ProfilerCategory> categories)
		{
			int num = 0;
			while ((long)num < Math.Min((long)((ulong)Profiler.GetCategoriesCount()), (long)categories.Length))
			{
				categories[num] = new Unity.Profiling.ProfilerCategory((ushort)num);
				num++;
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00087608 File Offset: 0x00085808
		public static void GetAllCategories(Unity.Collections.NativeArray<Unity.Profiling.ProfilerCategory> categories)
		{
			int num = 0;
			while ((long)num < Math.Min((long)((ulong)Profiler.GetCategoriesCount()), (long)categories.Length))
			{
				categories[num] = new Unity.Profiling.ProfilerCategory((ushort)num);
				num++;
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0000B23F File Offset: 0x0000943F
		public static void Internal_SetCategoryEnabled(ushort categoryId, bool enabled)
		{
			Profiler.Internal_SetCategoryEnabledDelegateField(categoryId, enabled);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000B24D File Offset: 0x0000944D
		public static bool Internal_IsCategoryEnabled(ushort categoryId)
		{
			return Profiler.Internal_IsCategoryEnabledDelegateField(categoryId);
		}

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0;

		// Token: 0x04001A1E RID: 6686
		public const uint invalidProfilerArea = 4294967295U;

		// Token: 0x04001A1F RID: 6687
		private static readonly Profiler.get_supportedDelegate get_supportedDelegateField;

		// Token: 0x04001A20 RID: 6688
		private static readonly Profiler.get_logFileDelegate get_logFileDelegateField;

		// Token: 0x04001A21 RID: 6689
		private static readonly Profiler.set_logFileDelegate set_logFileDelegateField;

		// Token: 0x04001A22 RID: 6690
		private static readonly Profiler.get_enableBinaryLogDelegate get_enableBinaryLogDelegateField;

		// Token: 0x04001A23 RID: 6691
		private static readonly Profiler.set_enableBinaryLogDelegate set_enableBinaryLogDelegateField;

		// Token: 0x04001A24 RID: 6692
		private static readonly Profiler.get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField;

		// Token: 0x04001A25 RID: 6693
		private static readonly Profiler.set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField;

		// Token: 0x04001A26 RID: 6694
		private static readonly Profiler.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04001A27 RID: 6695
		private static readonly Profiler.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04001A28 RID: 6696
		private static readonly Profiler.get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField;

		// Token: 0x04001A29 RID: 6697
		private static readonly Profiler.set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField;

		// Token: 0x04001A2A RID: 6698
		private static readonly Profiler.SetAreaEnabledDelegate SetAreaEnabledDelegateField;

		// Token: 0x04001A2B RID: 6699
		private static readonly Profiler.GetAreaEnabledDelegate GetAreaEnabledDelegateField;

		// Token: 0x04001A2C RID: 6700
		private static readonly Profiler.AddFramesFromFile_InternalDelegate AddFramesFromFile_InternalDelegateField;

		// Token: 0x04001A2D RID: 6701
		private static readonly Profiler.BeginThreadProfilingInternalDelegate BeginThreadProfilingInternalDelegateField;

		// Token: 0x04001A2E RID: 6702
		private static readonly Profiler.BeginSampleImplDelegate BeginSampleImplDelegateField;

		// Token: 0x04001A2F RID: 6703
		private static readonly Profiler.EndSampleDelegate EndSampleDelegateField;

		// Token: 0x04001A30 RID: 6704
		private static readonly Profiler.get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField;

		// Token: 0x04001A31 RID: 6705
		private static readonly Profiler.GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField;

		// Token: 0x04001A32 RID: 6706
		private static readonly Profiler.SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField;

		// Token: 0x04001A33 RID: 6707
		private static readonly Profiler.GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField;

		// Token: 0x04001A34 RID: 6708
		private static readonly Profiler.GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField;

		// Token: 0x04001A35 RID: 6709
		private static readonly Profiler.GetTotalReservedMemoryLongDelegate GetTotalReservedMemoryLongDelegateField;

		// Token: 0x04001A36 RID: 6710
		private static readonly Profiler.InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField;

		// Token: 0x04001A37 RID: 6711
		private static readonly Profiler.GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField;

		// Token: 0x04001A38 RID: 6712
		private static readonly Profiler.Internal_EmitGlobalMetaData_ArrayDelegate Internal_EmitGlobalMetaData_ArrayDelegateField;

		// Token: 0x04001A39 RID: 6713
		private static readonly Profiler.Internal_EmitGlobalMetaData_NativeDelegate Internal_EmitGlobalMetaData_NativeDelegateField;

		// Token: 0x04001A3A RID: 6714
		private static readonly Profiler.GetCategoriesCountDelegate GetCategoriesCountDelegateField;

		// Token: 0x04001A3B RID: 6715
		private static readonly Profiler.Internal_SetCategoryEnabledDelegate Internal_SetCategoryEnabledDelegateField;

		// Token: 0x04001A3C RID: 6716
		private static readonly Profiler.Internal_IsCategoryEnabledDelegate Internal_IsCategoryEnabledDelegateField;

		// Token: 0x0200080D RID: 2061
		// (Invoke) Token: 0x060038CA RID: 14538
		private delegate bool get_supportedDelegate();

		// Token: 0x0200080E RID: 2062
		// (Invoke) Token: 0x060038CC RID: 14540
		private delegate IntPtr get_logFileDelegate();

		// Token: 0x0200080F RID: 2063
		// (Invoke) Token: 0x060038CE RID: 14542
		private delegate void set_logFileDelegate(IntPtr value);

		// Token: 0x02000810 RID: 2064
		// (Invoke) Token: 0x060038D0 RID: 14544
		private delegate bool get_enableBinaryLogDelegate();

		// Token: 0x02000811 RID: 2065
		// (Invoke) Token: 0x060038D2 RID: 14546
		private delegate void set_enableBinaryLogDelegate(bool value);

		// Token: 0x02000812 RID: 2066
		// (Invoke) Token: 0x060038D4 RID: 14548
		private delegate int get_maxUsedMemoryDelegate();

		// Token: 0x02000813 RID: 2067
		// (Invoke) Token: 0x060038D6 RID: 14550
		private delegate void set_maxUsedMemoryDelegate(int value);

		// Token: 0x02000814 RID: 2068
		// (Invoke) Token: 0x060038D8 RID: 14552
		private delegate bool get_enabledDelegate();

		// Token: 0x02000815 RID: 2069
		// (Invoke) Token: 0x060038DA RID: 14554
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000816 RID: 2070
		// (Invoke) Token: 0x060038DC RID: 14556
		private delegate bool get_enableAllocationCallstacksDelegate();

		// Token: 0x02000817 RID: 2071
		// (Invoke) Token: 0x060038DE RID: 14558
		private delegate void set_enableAllocationCallstacksDelegate(bool value);

		// Token: 0x02000818 RID: 2072
		// (Invoke) Token: 0x060038E0 RID: 14560
		private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

		// Token: 0x02000819 RID: 2073
		// (Invoke) Token: 0x060038E2 RID: 14562
		private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

		// Token: 0x0200081A RID: 2074
		// (Invoke) Token: 0x060038E4 RID: 14564
		private delegate void AddFramesFromFile_InternalDelegate(IntPtr file, bool keepExistingFrames);

		// Token: 0x0200081B RID: 2075
		// (Invoke) Token: 0x060038E6 RID: 14566
		private delegate void BeginThreadProfilingInternalDelegate(IntPtr threadGroupName, IntPtr threadName);

		// Token: 0x0200081C RID: 2076
		// (Invoke) Token: 0x060038E8 RID: 14568
		private delegate void BeginSampleImplDelegate(IntPtr name, IntPtr targetObject);

		// Token: 0x0200081D RID: 2077
		// (Invoke) Token: 0x060038EA RID: 14570
		private delegate void EndSampleDelegate();

		// Token: 0x0200081E RID: 2078
		// (Invoke) Token: 0x060038EC RID: 14572
		private delegate long get_usedHeapSizeLongDelegate();

		// Token: 0x0200081F RID: 2079
		// (Invoke) Token: 0x060038EE RID: 14574
		private delegate long GetMonoHeapSizeLongDelegate();

		// Token: 0x02000820 RID: 2080
		// (Invoke) Token: 0x060038F0 RID: 14576
		private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

		// Token: 0x02000821 RID: 2081
		// (Invoke) Token: 0x060038F2 RID: 14578
		private delegate uint GetTempAllocatorSizeDelegate();

		// Token: 0x02000822 RID: 2082
		// (Invoke) Token: 0x060038F4 RID: 14580
		private delegate long GetTotalUnusedReservedMemoryLongDelegate();

		// Token: 0x02000823 RID: 2083
		// (Invoke) Token: 0x060038F6 RID: 14582
		private delegate long GetTotalReservedMemoryLongDelegate();

		// Token: 0x02000824 RID: 2084
		// (Invoke) Token: 0x060038F8 RID: 14584
		private delegate long InternalGetTotalFragmentationInfoDelegate(IntPtr pStats, int count);

		// Token: 0x02000825 RID: 2085
		// (Invoke) Token: 0x060038FA RID: 14586
		private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

		// Token: 0x02000826 RID: 2086
		// (Invoke) Token: 0x060038FC RID: 14588
		private delegate void Internal_EmitGlobalMetaData_ArrayDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);

		// Token: 0x02000827 RID: 2087
		// (Invoke) Token: 0x060038FE RID: 14590
		private delegate void Internal_EmitGlobalMetaData_NativeDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);

		// Token: 0x02000828 RID: 2088
		// (Invoke) Token: 0x06003900 RID: 14592
		private delegate uint GetCategoriesCountDelegate();

		// Token: 0x02000829 RID: 2089
		// (Invoke) Token: 0x06003902 RID: 14594
		private delegate void Internal_SetCategoryEnabledDelegate(ushort categoryId, bool enabled);

		// Token: 0x0200082A RID: 2090
		// (Invoke) Token: 0x06003904 RID: 14596
		private delegate bool Internal_IsCategoryEnabledDelegate(ushort categoryId);
	}
}

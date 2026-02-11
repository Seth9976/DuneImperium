using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Jobs
{
	// Token: 0x02000190 RID: 400
	public static class IJobParallelForTransformExtensions : Object
	{
		// Token: 0x06001DEA RID: 7658 RVA: 0x00087F14 File Offset: 0x00086114
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForTransformExtensions()
		{
			Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "IJobParallelForTransformExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr);
			IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100667440);
			IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100667441);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00087F6C File Offset: 0x0008616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00087F9C File Offset: 0x0008619C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677710, XrefRangeEnd = 677714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Jobs.JobHandle Schedule<T>(this T jobData, TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn = default(Unity.Jobs.JobHandle)) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = jobData;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref jobData;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transforms;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOn;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0000B397 File Offset: 0x00009597
		public IJobParallelForTransformExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public static void EarlyJobInit<T>() where T : struct
		{
			IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.Initialize();
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00088030 File Offset: 0x00086230
		public static Unity.Jobs.JobHandle ScheduleReadOnly<T>(T jobData, TransformAccessArray transforms, int batchSize, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00088068 File Offset: 0x00086268
		public static void RunReadOnly<T>(T jobData, TransformAccessArray transforms) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), default(Unity.Jobs.JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000880AC File Offset: 0x000862AC
		public static Unity.Jobs.JobHandle ScheduleByRef<T>(ref T jobData, TransformAccessArray transforms, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransform(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule());
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000880E0 File Offset: 0x000862E0
		public static Unity.Jobs.JobHandle ScheduleReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms, int batchSize, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00088118 File Offset: 0x00086318
		public static void RunReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), default(Unity.Jobs.JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
		}

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0;

		// Token: 0x0200082B RID: 2091
		public sealed class TransformParallelForLoopStruct<T> : ValueType where T : new()
		{
			// Token: 0x06003905 RID: 14597 RVA: 0x000BCF98 File Offset: 0x000BB198
			// Note: this type is marked as 'beforefieldinit'.
			static TransformParallelForLoopStruct()
			{
				Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, "TransformParallelForLoopStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr);
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100667442);
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100667443);
			}

			// Token: 0x06003906 RID: 14598 RVA: 0x000BD03C File Offset: 0x000BB23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677657, XrefRangeEnd = 677685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x000BD064 File Offset: 0x000BB264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677685, XrefRangeEnd = 677710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
			{
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobData);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobData2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x0001413E File Offset: 0x0001233E
			public TransformParallelForLoopStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003909 RID: 14601 RVA: 0x00014147 File Offset: 0x00012347
			public TransformParallelForLoopStruct()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x0600390A RID: 14602 RVA: 0x000BD0EC File Offset: 0x000BB2EC
			// (set) Token: 0x0600390B RID: 14603 RVA: 0x00014159 File Offset: 0x00012359
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04002CB9 RID: 11449
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x04002CBA RID: 11450
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x04002CBB RID: 11451
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000BE1 RID: 3041
			public sealed class TransformJobData : ValueType
			{
				// Token: 0x060040BF RID: 16575 RVA: 0x000BFCC8 File Offset: 0x000BDEC8
				// Note: this type is marked as 'beforefieldinit'.
				static TransformJobData()
				{
					Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "TransformJobData"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, "TransformAccessArray");
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, "IsReadOnly");
				}

				// Token: 0x060040C0 RID: 16576 RVA: 0x00016967 File Offset: 0x00014B67
				public TransformJobData(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060040C1 RID: 16577 RVA: 0x00016970 File Offset: 0x00014B70
				public TransformJobData()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr))
				{
				}

				// Token: 0x17000A46 RID: 2630
				// (get) Token: 0x060040C2 RID: 16578 RVA: 0x000BFD58 File Offset: 0x000BDF58
				// (set) Token: 0x060040C3 RID: 16579 RVA: 0x00016982 File Offset: 0x00014B82
				public unsafe IntPtr TransformAccessArray
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray)) = value;
					}
				}

				// Token: 0x17000A47 RID: 2631
				// (get) Token: 0x060040C4 RID: 16580 RVA: 0x000BFD80 File Offset: 0x000BDF80
				// (set) Token: 0x060040C5 RID: 16581 RVA: 0x0001699D File Offset: 0x00014B9D
				public unsafe int IsReadOnly
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly)) = value;
					}
				}

				// Token: 0x04002DD5 RID: 11733
				private static readonly IntPtr NativeFieldInfoPtr_TransformAccessArray;

				// Token: 0x04002DD6 RID: 11734
				private static readonly IntPtr NativeFieldInfoPtr_IsReadOnly;
			}

			// Token: 0x02000BE2 RID: 3042
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x060040C6 RID: 16582 RVA: 0x000BFDA8 File Offset: 0x000BDFA8
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100667445);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100667446);
				}

				// Token: 0x060040C7 RID: 16583 RVA: 0x000BFE2C File Offset: 0x000BE02C
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 642857, RefRangeEnd = 642859, XrefRangeStart = 642857, XrefRangeEnd = 642859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060040C8 RID: 16584 RVA: 0x000BFE88 File Offset: 0x000BE088
				[CallerCount(0)]
				public unsafe void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobData);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x060040C9 RID: 16585 RVA: 0x000169B8 File Offset: 0x00014BB8
				public ExecuteJobFunction(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002DD7 RID: 11735
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002DD8 RID: 11736
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x0200082C RID: 2092
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x04002CBC RID: 11452
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200082D RID: 2093
		private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>
		{
			// Token: 0x04002CBD RID: 11453
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

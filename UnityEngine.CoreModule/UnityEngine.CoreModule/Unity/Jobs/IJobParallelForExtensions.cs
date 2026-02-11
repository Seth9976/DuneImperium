using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x0200000E RID: 14
	public static class IJobParallelForExtensions : Object
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000171E4 File Offset: 0x000153E4
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForExtensions()
		{
			Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobParallelForExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr);
			IJobParallelForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, 100663323);
			IJobParallelForExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0001723C File Offset: 0x0001543C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643025, XrefRangeEnd = 643032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0001726C File Offset: 0x0001546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643032, XrefRangeEnd = 643035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOn;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000227F File Offset: 0x0000047F
		public IJobParallelForExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002288 File Offset: 0x00000488
		public static void EarlyJobInit<T>() where T : struct
		{
			IJobParallelForExtensions.ParallelForJobStruct<T>.Initialize();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00017310 File Offset: 0x00015510
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00017348 File Offset: 0x00015548
		public static JobHandle ScheduleByRef<T>(ref T jobData, int arrayLength, int innerloopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, innerloopBatchCount);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00017378 File Offset: 0x00015578
		public static void RunByRef<T>(ref T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0;

		// Token: 0x0200037F RID: 895
		public sealed class ParallelForJobStruct<T> : ValueType where T : new()
		{
			// Token: 0x06002FD2 RID: 12242 RVA: 0x000B64D8 File Offset: 0x000B46D8
			// Note: this type is marked as 'beforefieldinit'.
			static ParallelForJobStruct()
			{
				Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, "ParallelForJobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr);
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, 100663325);
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, 100663326);
			}

			// Token: 0x06002FD3 RID: 12243 RVA: 0x000B657C File Offset: 0x000B477C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642988, XrefRangeEnd = 643016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FD4 RID: 12244 RVA: 0x000B65A4 File Offset: 0x000B47A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643016, XrefRangeEnd = 643025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
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
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06002FD5 RID: 12245 RVA: 0x0001366A File Offset: 0x0001186A
			public ParallelForJobStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FD6 RID: 12246 RVA: 0x00013673 File Offset: 0x00011873
			public ParallelForJobStruct()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x000B662C File Offset: 0x000B482C
			// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00013685 File Offset: 0x00011885
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04002ABF RID: 10943
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x04002AC0 RID: 10944
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x04002AC1 RID: 10945
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000BDD RID: 3037
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x060040AA RID: 16554 RVA: 0x000BF6DC File Offset: 0x000BD8DC
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663328);
					IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663329);
				}

				// Token: 0x060040AB RID: 16555 RVA: 0x000BF760 File Offset: 0x000BD960
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 642857, RefRangeEnd = 642859, XrefRangeStart = 642857, XrefRangeEnd = 642859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060040AC RID: 16556 RVA: 0x000BF7BC File Offset: 0x000BD9BC
				[CallerCount(0)]
				public unsafe void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x060040AD RID: 16557 RVA: 0x000168FA File Offset: 0x00014AFA
				public ExecuteJobFunction(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002DC8 RID: 11720
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002DC9 RID: 11721
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x02000380 RID: 896
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x04002AC2 RID: 10946
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000381 RID: 897
		private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>
		{
			// Token: 0x04002AC3 RID: 10947
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0, Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

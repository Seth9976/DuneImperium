using System;
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
	// Token: 0x0200000C RID: 12
	public static class IJobForExtensions : Object
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00016F70 File Offset: 0x00015170
		// Note: this type is marked as 'beforefieldinit'.
		static IJobForExtensions()
		{
			Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobForExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr);
			IJobForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr, 100663315);
			IJobForExtensions.NativeMethodInfoPtr_ScheduleParallel_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr, 100663316);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00016FC8 File Offset: 0x000151C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642968, XrefRangeEnd = 642976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00016FF8 File Offset: 0x000151F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642987, RefRangeEnd = 642988, XrefRangeStart = 642976, XrefRangeEnd = 642987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallel<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : new()
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependency;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.MethodInfoStoreGeneric_ScheduleParallel_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002235 File Offset: 0x00000435
		public IJobForExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000223E File Offset: 0x0000043E
		public static void EarlyJobInit<T>() where T : struct
		{
			IJobForExtensions.ForJobStruct<T>.Initialize();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0001709C File Offset: 0x0001529C
		public static JobHandle Schedule<T>(T jobData, int arrayLength, JobHandle dependency) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Single);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000170CC File Offset: 0x000152CC
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00017104 File Offset: 0x00015304
		public static JobHandle ScheduleByRef<T>(ref T jobData, int arrayLength, JobHandle dependency) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Single);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00017134 File Offset: 0x00015334
		public static JobHandle ScheduleParallelByRef<T>(ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, innerloopBatchCount);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00017164 File Offset: 0x00015364
		public static void RunByRef<T>(ref T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallel_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0;

		// Token: 0x0200037C RID: 892
		public sealed class ForJobStruct<T> : ValueType where T : new()
		{
			// Token: 0x06002FC9 RID: 12233 RVA: 0x000B62A0 File Offset: 0x000B44A0
			// Note: this type is marked as 'beforefieldinit'.
			static ForJobStruct()
			{
				Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr, "ForJobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr);
				IJobForExtensions.ForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobForExtensions.ForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr, 100663317);
				IJobForExtensions.ForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr, 100663318);
			}

			// Token: 0x06002FCA RID: 12234 RVA: 0x000B6344 File Offset: 0x000B4544
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642962, RefRangeEnd = 642964, XrefRangeStart = 642934, XrefRangeEnd = 642962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.ForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FCB RID: 12235 RVA: 0x000B636C File Offset: 0x000B456C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642964, XrefRangeEnd = 642968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.ForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06002FCC RID: 12236 RVA: 0x00013638 File Offset: 0x00011838
			public ForJobStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FCD RID: 12237 RVA: 0x00013641 File Offset: 0x00011841
			public ForJobStruct()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000B63F4 File Offset: 0x000B45F4
			// (set) Token: 0x06002FCF RID: 12239 RVA: 0x00013653 File Offset: 0x00011853
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobForExtensions.ForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobForExtensions.ForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04002ABA RID: 10938
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x04002ABB RID: 10939
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x04002ABC RID: 10940
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000BDC RID: 3036
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x060040A6 RID: 16550 RVA: 0x000BF568 File Offset: 0x000BD768
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663320);
					IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663321);
				}

				// Token: 0x060040A7 RID: 16551 RVA: 0x000BF5EC File Offset: 0x000BD7EC
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 642857, RefRangeEnd = 642859, XrefRangeStart = 642857, XrefRangeEnd = 642859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060040A8 RID: 16552 RVA: 0x000BF648 File Offset: 0x000BD848
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobForExtensions.ForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x060040A9 RID: 16553 RVA: 0x000168F1 File Offset: 0x00014AF1
				public ExecuteJobFunction(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002DC6 RID: 11718
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002DC7 RID: 11719
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x0200037D RID: 893
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x04002ABD RID: 10941
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200037E RID: 894
		private sealed class MethodInfoStoreGeneric_ScheduleParallel_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>
		{
			// Token: 0x04002ABE RID: 10942
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobForExtensions.NativeMethodInfoPtr_ScheduleParallel_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0, Il2CppClassPointerStore<IJobForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

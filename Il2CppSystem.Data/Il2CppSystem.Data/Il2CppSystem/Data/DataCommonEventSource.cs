using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Data
{
	// Token: 0x02000021 RID: 33
	public class DataCommonEventSource : EventSource
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		// Note: this type is marked as 'beforefieldinit'.
		static DataCommonEventSource()
		{
			Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataCommonEventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr);
			DataCommonEventSource.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, "Log");
			DataCommonEventSource.NativeFieldInfoPtr_s_nextScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, "s_nextScopeId");
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664098);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664099);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664100);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664101);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664102);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664103);
			DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_T5_T6_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664104);
			DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664105);
			DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664106);
			DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664107);
			DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664108);
			DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664109);
			DataCommonEventSource.NativeMethodInfoPtr_ExitScope_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664110);
			DataCommonEventSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr, 100664111);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001C918 File Offset: 0x0001AB18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 897813, RefRangeEnd = 897819, XrefRangeStart = 897804, XrefRangeEnd = 897813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001C95C File Offset: 0x0001AB5C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 897828, RefRangeEnd = 897858, XrefRangeStart = 897819, XrefRangeEnd = 897828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0>(string format, T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_0<T0>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897868, RefRangeEnd = 897871, XrefRangeStart = 897858, XrefRangeEnd = 897868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0, T1>(string format, T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_0<T0, T1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001CABC File Offset: 0x0001ACBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897882, RefRangeEnd = 897885, XrefRangeStart = 897871, XrefRangeEnd = 897882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_0<T0, T1, T2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897908, RefRangeEnd = 897909, XrefRangeStart = 897885, XrefRangeEnd = 897908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_0<T0, T1, T2, T3>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897934, RefRangeEnd = 897935, XrefRangeStart = 897909, XrefRangeEnd = 897934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897967, RefRangeEnd = 897968, XrefRangeStart = 897935, XrefRangeEnd = 897967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			IntPtr intPtr9;
			IntPtr intPtr8 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr9);
			Il2CppException.RaiseExceptionIfNecessary(intPtr9);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001D12C File Offset: 0x0001B32C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 897978, RefRangeEnd = 897982, XrefRangeStart = 897968, XrefRangeEnd = 897978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long EnterScope(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001D17C File Offset: 0x0001B37C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 897991, RefRangeEnd = 898007, XrefRangeStart = 897982, XrefRangeEnd = 897991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long EnterScope<T1>(string format, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_0<T1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001D214 File Offset: 0x0001B414
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 898017, RefRangeEnd = 898026, XrefRangeStart = 898007, XrefRangeEnd = 898017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_0<T1, T2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898037, RefRangeEnd = 898039, XrefRangeStart = 898026, XrefRangeEnd = 898037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_T3_0<T1, T2, T3>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001D41C File Offset: 0x0001B61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898062, RefRangeEnd = 898064, XrefRangeStart = 898039, XrefRangeEnd = 898062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = arg4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg4;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_T3_T4_0<T1, T2, T3, T4>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001D58C File Offset: 0x0001B78C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 898065, RefRangeEnd = 898114, XrefRangeStart = 898064, XrefRangeEnd = 898065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitScope(long scopeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scopeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.NativeMethodInfoPtr_ExitScope_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataCommonEventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCommonEventSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003451 File Offset: 0x00001651
		public DataCommonEventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0001D608 File Offset: 0x0001B808
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000345A File Offset: 0x0000165A
		public unsafe static DataCommonEventSource Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataCommonEventSource.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataCommonEventSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataCommonEventSource.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0001D630 File Offset: 0x0001B830
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0000346C File Offset: 0x0000166C
		public unsafe static long s_nextScopeId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DataCommonEventSource.NativeFieldInfoPtr_s_nextScopeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataCommonEventSource.NativeFieldInfoPtr_s_nextScopeId, (void*)(&value));
			}
		}

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_s_nextScopeId;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_T5_T6_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_EnterScope_Internal_Int64_String_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_T4_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_ExitScope_Internal_Void_Int64_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D2 RID: 210
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_0<T0>
		{
			// Token: 0x040010F2 RID: 4338
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D3 RID: 211
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_0<T0, T1>
		{
			// Token: 0x040010F3 RID: 4339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D4 RID: 212
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_0<T0, T1, T2>
		{
			// Token: 0x040010F4 RID: 4340
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D5 RID: 213
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_0<T0, T1, T2, T3>
		{
			// Token: 0x040010F5 RID: 4341
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D6 RID: 214
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4>
		{
			// Token: 0x040010F6 RID: 4342
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D7 RID: 215
		private sealed class MethodInfoStoreGeneric_Trace_Internal_Void_String_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x040010F7 RID: 4343
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_Trace_Internal_Void_String_T0_T1_T2_T3_T4_T5_T6_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D8 RID: 216
		private sealed class MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_0<T1>
		{
			// Token: 0x040010F8 RID: 4344
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D9 RID: 217
		private sealed class MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_0<T1, T2>
		{
			// Token: 0x040010F9 RID: 4345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DA RID: 218
		private sealed class MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_T3_0<T1, T2, T3>
		{
			// Token: 0x040010FA RID: 4346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DB RID: 219
		private sealed class MethodInfoStoreGeneric_EnterScope_Internal_Int64_String_T1_T2_T3_T4_0<T1, T2, T3, T4>
		{
			// Token: 0x040010FB RID: 4347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataCommonEventSource.NativeMethodInfoPtr_EnterScope_Internal_Int64_String_T1_T2_T3_T4_0, Il2CppClassPointerStore<DataCommonEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			}))));
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000165 RID: 357
	public sealed class ComputeBuffer : Object
	{
		// Token: 0x06001A11 RID: 6673 RVA: 0x0007A678 File Offset: 0x00078878
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBuffer()
		{
			Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr);
			ComputeBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, "m_Ptr");
			ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666923);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666924);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666925);
			ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666926);
			ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666927);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666928);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666929);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666930);
			ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666931);
			ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666932);
			ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666933);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666934);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666935);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666936);
			ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666937);
			ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666938);
			ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666939);
			ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666940);
			ComputeBuffer.IsValidBufferDelegateField = IL2CPP.ResolveICall<ComputeBuffer.IsValidBufferDelegate>("UnityEngine.ComputeBuffer::IsValidBuffer");
			ComputeBuffer.get_usageDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_usageDelegate>("UnityEngine.ComputeBuffer::get_usage");
			ComputeBuffer.InternalGetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalGetDataDelegate>("UnityEngine.ComputeBuffer::InternalGetData");
			ComputeBuffer.BeginBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.BeginBufferWriteDelegate>("UnityEngine.ComputeBuffer::BeginBufferWrite");
			ComputeBuffer.EndBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.EndBufferWriteDelegate>("UnityEngine.ComputeBuffer::EndBufferWrite");
			ComputeBuffer.SetCounterValueDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetCounterValueDelegate>("UnityEngine.ComputeBuffer::SetCounterValue");
			ComputeBuffer.CopyCountDelegateField = IL2CPP.ResolveICall<ComputeBuffer.CopyCountDelegate>("UnityEngine.ComputeBuffer::CopyCount");
			ComputeBuffer.GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<ComputeBuffer.GetNativeBufferPtrDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr");
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0007A89C File Offset: 0x00078A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673081, XrefRangeEnd = 673091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0007A8D0 File Offset: 0x00078AD0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 673099, RefRangeEnd = 673118, XrefRangeStart = 673091, XrefRangeEnd = 673099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0007A904 File Offset: 0x00078B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673118, XrefRangeEnd = 673125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0007A944 File Offset: 0x00078B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673125, XrefRangeEnd = 673127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0007A9AC File Offset: 0x00078BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673127, XrefRangeEnd = 673129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBuffer(ComputeBuffer buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0007A9E4 File Offset: 0x00078BE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 673130, RefRangeEnd = 673136, XrefRangeStart = 673129, XrefRangeEnd = 673130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0007AA3C File Offset: 0x00078C3C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 673137, RefRangeEnd = 673151, XrefRangeStart = 673136, XrefRangeEnd = 673137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0007AAA0 File Offset: 0x00078CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673156, RefRangeEnd = 673158, XrefRangeStart = 673151, XrefRangeEnd = 673156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0007AB20 File Offset: 0x00078D20
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 673099, RefRangeEnd = 673118, XrefRangeStart = 673099, XrefRangeEnd = 673118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0007AB54 File Offset: 0x00078D54
		public unsafe int count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673160, RefRangeEnd = 673162, XrefRangeStart = 673158, XrefRangeEnd = 673160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0007AB90 File Offset: 0x00078D90
		public unsafe int stride
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 673164, RefRangeEnd = 673172, XrefRangeStart = 673162, XrefRangeEnd = 673164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0007ABCC File Offset: 0x00078DCC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 673178, RefRangeEnd = 673196, XrefRangeStart = 673172, XrefRangeEnd = 673178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(Array data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0007AC10 File Offset: 0x00078E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673196, XrefRangeEnd = 673199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0007AC58 File Offset: 0x00078E58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673207, RefRangeEnd = 673210, XrefRangeStart = 673199, XrefRangeEnd = 673207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0007ACC4 File Offset: 0x00078EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673212, RefRangeEnd = 673213, XrefRangeStart = 673210, XrefRangeEnd = 673212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0007AD3C File Offset: 0x00078F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673215, RefRangeEnd = 673216, XrefRangeStart = 673213, XrefRangeEnd = 673215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000538 RID: 1336
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0007ADB8 File Offset: 0x00078FB8
		public unsafe string name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673218, RefRangeEnd = 673220, XrefRangeStart = 673216, XrefRangeEnd = 673218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0007ADFC File Offset: 0x00078FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673218, RefRangeEnd = 673220, XrefRangeStart = 673218, XrefRangeEnd = 673220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000A165 File Offset: 0x00008365
		public ComputeBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0007AE40 File Offset: 0x00079040
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0000A16E File Offset: 0x0000836E
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0000A189 File Offset: 0x00008389
		public static bool IsValidBuffer(ComputeBuffer buf)
		{
			return ComputeBuffer.IsValidBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0007AE68 File Offset: 0x00079068
		public bool IsValid()
		{
			return this.m_Ptr != IntPtr.Zero && ComputeBuffer.IsValidBuffer(this);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0000A19B File Offset: 0x0000839B
		public ComputeBufferMode usage
		{
			get
			{
				return ComputeBuffer.get_usageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0007AE98 File Offset: 0x00079098
		public void SetData<T>(List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0007AF0C File Offset: 0x0007910C
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0007AFBC File Offset: 0x000791BC
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, computeBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0007B02C File Offset: 0x0007922C
		public void GetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0007B094 File Offset: 0x00079294
		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0000A1AD File Offset: 0x000083AD
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0000A1CB File Offset: 0x000083CB
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return ComputeBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0000A1DF File Offset: 0x000083DF
		public Unity.Collections.NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0000A1EC File Offset: 0x000083EC
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			ComputeBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0007B138 File Offset: 0x00079338
		public void EndWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0000A1FF File Offset: 0x000083FF
		public void SetCounterValue(uint counterValue)
		{
			ComputeBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0000A212 File Offset: 0x00008412
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			ComputeBuffer.CopyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000A22B File Offset: 0x0000842B
		public IntPtr GetNativeBufferPtr()
		{
			return ComputeBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

		// Token: 0x0400173D RID: 5949
		private static readonly ComputeBuffer.IsValidBufferDelegate IsValidBufferDelegateField;

		// Token: 0x0400173E RID: 5950
		private static readonly ComputeBuffer.get_usageDelegate get_usageDelegateField;

		// Token: 0x0400173F RID: 5951
		private static readonly ComputeBuffer.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x04001740 RID: 5952
		private static readonly ComputeBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField;

		// Token: 0x04001741 RID: 5953
		private static readonly ComputeBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField;

		// Token: 0x04001742 RID: 5954
		private static readonly ComputeBuffer.SetCounterValueDelegate SetCounterValueDelegateField;

		// Token: 0x04001743 RID: 5955
		private static readonly ComputeBuffer.CopyCountDelegate CopyCountDelegateField;

		// Token: 0x04001744 RID: 5956
		private static readonly ComputeBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField;

		// Token: 0x02000783 RID: 1923
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002CA1 RID: 11425
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000784 RID: 1924
		// (Invoke) Token: 0x060037B5 RID: 14261
		private delegate bool IsValidBufferDelegate(IntPtr buf);

		// Token: 0x02000785 RID: 1925
		// (Invoke) Token: 0x060037B7 RID: 14263
		private delegate ComputeBufferMode get_usageDelegate(IntPtr @this);

		// Token: 0x02000786 RID: 1926
		// (Invoke) Token: 0x060037B9 RID: 14265
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000787 RID: 1927
		// (Invoke) Token: 0x060037BB RID: 14267
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x02000788 RID: 1928
		// (Invoke) Token: 0x060037BD RID: 14269
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x02000789 RID: 1929
		// (Invoke) Token: 0x060037BF RID: 14271
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x0200078A RID: 1930
		// (Invoke) Token: 0x060037C1 RID: 14273
		private delegate void CopyCountDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x0200078B RID: 1931
		// (Invoke) Token: 0x060037C3 RID: 14275
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);
	}
}

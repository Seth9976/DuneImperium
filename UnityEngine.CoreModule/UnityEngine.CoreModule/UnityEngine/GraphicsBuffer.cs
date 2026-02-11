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
	// Token: 0x020000A9 RID: 169
	public sealed class GraphicsBuffer : Object
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x00045928 File Offset: 0x00043B28
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsBuffer()
		{
			Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GraphicsBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr);
			GraphicsBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, "m_Ptr");
			GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665037);
			GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665038);
			GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665039);
			GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665040);
			GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665041);
			GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665042);
			GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665043);
			GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665044);
			GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665045);
			GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665046);
			GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665047);
			GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665048);
			GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665049);
			GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665050);
			GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100665051);
			GraphicsBuffer.IsValidBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.IsValidBufferDelegate>("UnityEngine.GraphicsBuffer::IsValidBuffer");
			GraphicsBuffer.get_countDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_countDelegate>("UnityEngine.GraphicsBuffer::get_count");
			GraphicsBuffer.get_strideDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_strideDelegate>("UnityEngine.GraphicsBuffer::get_stride");
			GraphicsBuffer.get_targetDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_targetDelegate>("UnityEngine.GraphicsBuffer::get_target");
			GraphicsBuffer.GetUsageFlagsDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetUsageFlagsDelegate>("UnityEngine.GraphicsBuffer::GetUsageFlags");
			GraphicsBuffer.InternalSetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetData");
			GraphicsBuffer.InternalGetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalGetDataDelegate>("UnityEngine.GraphicsBuffer::InternalGetData");
			GraphicsBuffer.GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetNativeBufferPtrDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr");
			GraphicsBuffer.BeginBufferWriteDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.BeginBufferWriteDelegate>("UnityEngine.GraphicsBuffer::BeginBufferWrite");
			GraphicsBuffer.EndBufferWriteDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.EndBufferWriteDelegate>("UnityEngine.GraphicsBuffer::EndBufferWrite");
			GraphicsBuffer.SetCounterValueDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetCounterValueDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue");
			GraphicsBuffer.CopyCountCCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCCDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC");
			GraphicsBuffer.CopyCountGCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGCDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC");
			GraphicsBuffer.CopyCountCGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCGDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG");
			GraphicsBuffer.CopyCountGGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGGDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG");
			GraphicsBuffer.get_bufferHandle_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_bufferHandle_InjectedDelegate>("UnityEngine.GraphicsBuffer::get_bufferHandle_Injected");
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00045B88 File Offset: 0x00043D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653232, XrefRangeEnd = 653242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00045BBC File Offset: 0x00043DBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 653250, RefRangeEnd = 653255, XrefRangeStart = 653242, XrefRangeEnd = 653250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00045BF0 File Offset: 0x00043DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653255, XrefRangeEnd = 653262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00045C30 File Offset: 0x00043E30
		[CallerCount(0)]
		public unsafe static bool RequiresCompute(GraphicsBuffer.Target target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00045C70 File Offset: 0x00043E70
		[CallerCount(0)]
		public unsafe static bool IsVertexIndexOrCopyOnly(GraphicsBuffer.Target target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00045CB0 File Offset: 0x00043EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653262, XrefRangeEnd = 653264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usageFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00045D18 File Offset: 0x00043F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653264, XrefRangeEnd = 653266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBuffer(GraphicsBuffer buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00045D50 File Offset: 0x00043F50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 653268, RefRangeEnd = 653271, XrefRangeStart = 653266, XrefRangeEnd = 653268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer(GraphicsBuffer.Target target, int count, int stride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00045DB4 File Offset: 0x00043FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 653275, RefRangeEnd = 653276, XrefRangeStart = 653271, XrefRangeEnd = 653275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialization(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usageFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00045E1C File Offset: 0x0004401C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 653250, RefRangeEnd = 653255, XrefRangeStart = 653250, XrefRangeEnd = 653255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00045E50 File Offset: 0x00044050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653276, XrefRangeEnd = 653279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00045E98 File Offset: 0x00044098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653283, RefRangeEnd = 653285, XrefRangeStart = 653279, XrefRangeEnd = 653283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graphicsBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00045F0C File Offset: 0x0004410C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653287, RefRangeEnd = 653289, XrefRangeStart = 653285, XrefRangeEnd = 653287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graphicsBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002EB RID: 747
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00045F84 File Offset: 0x00044184
		public unsafe string name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653291, RefRangeEnd = 653293, XrefRangeStart = 653289, XrefRangeEnd = 653291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00045FC8 File Offset: 0x000441C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 653291, RefRangeEnd = 653293, XrefRangeStart = 653291, XrefRangeEnd = 653293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00006F5A File Offset: 0x0000515A
		public GraphicsBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0004600C File Offset: 0x0004420C
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00006F63 File Offset: 0x00005163
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00006F7E File Offset: 0x0000517E
		public static bool IsValidBuffer(GraphicsBuffer buf)
		{
			return GraphicsBuffer.IsValidBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00046034 File Offset: 0x00044234
		public bool IsValid()
		{
			return this.m_Ptr != IntPtr.Zero && GraphicsBuffer.IsValidBuffer(this);
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00006F90 File Offset: 0x00005190
		public int count
		{
			get
			{
				return GraphicsBuffer.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00006FA2 File Offset: 0x000051A2
		public int stride
		{
			get
			{
				return GraphicsBuffer.get_strideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00006FB4 File Offset: 0x000051B4
		public GraphicsBuffer.Target target
		{
			get
			{
				return GraphicsBuffer.get_targetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00006FC6 File Offset: 0x000051C6
		public GraphicsBuffer.UsageFlags GetUsageFlags()
		{
			return GraphicsBuffer.GetUsageFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00046064 File Offset: 0x00044264
		public GraphicsBuffer.UsageFlags usageFlags
		{
			get
			{
				return this.GetUsageFlags();
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0004607C File Offset: 0x0004427C
		public GraphicsBufferHandle bufferHandle
		{
			get
			{
				GraphicsBufferHandle graphicsBufferHandle;
				this.get_bufferHandle_Injected(out graphicsBufferHandle);
				return graphicsBufferHandle;
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00046094 File Offset: 0x00044294
		public void SetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000460FC File Offset: 0x000442FC
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
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00046170 File Offset: 0x00044370
		public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00046214 File Offset: 0x00044414
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00006FD8 File Offset: 0x000051D8
		public void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000462C4 File Offset: 0x000444C4
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0004632C File Offset: 0x0004452C
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00006FF6 File Offset: 0x000051F6
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00007014 File Offset: 0x00005214
		public IntPtr GetNativeBufferPtr()
		{
			return GraphicsBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00007026 File Offset: 0x00005226
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return GraphicsBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0000703A File Offset: 0x0000523A
		public Unity.Collections.NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00007047 File Offset: 0x00005247
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			GraphicsBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000463D0 File Offset: 0x000445D0
		public void UnlockBufferAfterWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0000705A File Offset: 0x0000525A
		public void SetCounterValue(uint counterValue)
		{
			GraphicsBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0000706D File Offset: 0x0000526D
		public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00007086 File Offset: 0x00005286
		public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0000709F File Offset: 0x0000529F
		public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000070B8 File Offset: 0x000052B8
		public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x000070D1 File Offset: 0x000052D1
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000070DD File Offset: 0x000052DD
		public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000070E9 File Offset: 0x000052E9
		public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000070F5 File Offset: 0x000052F5
		public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00007101 File Offset: 0x00005301
		public void get_bufferHandle_Injected(out GraphicsBufferHandle ret)
		{
			GraphicsBuffer.get_bufferHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly GraphicsBuffer.IsValidBufferDelegate IsValidBufferDelegateField;

		// Token: 0x04000B15 RID: 2837
		private static readonly GraphicsBuffer.get_countDelegate get_countDelegateField;

		// Token: 0x04000B16 RID: 2838
		private static readonly GraphicsBuffer.get_strideDelegate get_strideDelegateField;

		// Token: 0x04000B17 RID: 2839
		private static readonly GraphicsBuffer.get_targetDelegate get_targetDelegateField;

		// Token: 0x04000B18 RID: 2840
		private static readonly GraphicsBuffer.GetUsageFlagsDelegate GetUsageFlagsDelegateField;

		// Token: 0x04000B19 RID: 2841
		private static readonly GraphicsBuffer.InternalSetDataDelegate InternalSetDataDelegateField;

		// Token: 0x04000B1A RID: 2842
		private static readonly GraphicsBuffer.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x04000B1B RID: 2843
		private static readonly GraphicsBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField;

		// Token: 0x04000B1C RID: 2844
		private static readonly GraphicsBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField;

		// Token: 0x04000B1D RID: 2845
		private static readonly GraphicsBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField;

		// Token: 0x04000B1E RID: 2846
		private static readonly GraphicsBuffer.SetCounterValueDelegate SetCounterValueDelegateField;

		// Token: 0x04000B1F RID: 2847
		private static readonly GraphicsBuffer.CopyCountCCDelegate CopyCountCCDelegateField;

		// Token: 0x04000B20 RID: 2848
		private static readonly GraphicsBuffer.CopyCountGCDelegate CopyCountGCDelegateField;

		// Token: 0x04000B21 RID: 2849
		private static readonly GraphicsBuffer.CopyCountCGDelegate CopyCountCGDelegateField;

		// Token: 0x04000B22 RID: 2850
		private static readonly GraphicsBuffer.CopyCountGGDelegate CopyCountGGDelegateField;

		// Token: 0x04000B23 RID: 2851
		private static readonly GraphicsBuffer.get_bufferHandle_InjectedDelegate get_bufferHandle_InjectedDelegateField;

		// Token: 0x02000604 RID: 1540
		[Flags]
		public enum Target
		{
			// Token: 0x04002BA0 RID: 11168
			Vertex = 1,
			// Token: 0x04002BA1 RID: 11169
			Index = 2,
			// Token: 0x04002BA2 RID: 11170
			CopySource = 4,
			// Token: 0x04002BA3 RID: 11171
			CopyDestination = 8,
			// Token: 0x04002BA4 RID: 11172
			Structured = 16,
			// Token: 0x04002BA5 RID: 11173
			Raw = 32,
			// Token: 0x04002BA6 RID: 11174
			Append = 64,
			// Token: 0x04002BA7 RID: 11175
			Counter = 128,
			// Token: 0x04002BA8 RID: 11176
			IndirectArguments = 256,
			// Token: 0x04002BA9 RID: 11177
			Constant = 512
		}

		// Token: 0x02000605 RID: 1541
		[Flags]
		public enum UsageFlags
		{
			// Token: 0x04002BAB RID: 11179
			None = 0,
			// Token: 0x04002BAC RID: 11180
			LockBufferForWrite = 1
		}

		// Token: 0x02000606 RID: 1542
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002BAD RID: 11181
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000607 RID: 1543
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04002BAE RID: 11182
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000608 RID: 1544
		// (Invoke) Token: 0x0600351B RID: 13595
		private delegate bool IsValidBufferDelegate(IntPtr buf);

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x0600351D RID: 13597
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x0200060A RID: 1546
		// (Invoke) Token: 0x0600351F RID: 13599
		private delegate int get_strideDelegate(IntPtr @this);

		// Token: 0x0200060B RID: 1547
		// (Invoke) Token: 0x06003521 RID: 13601
		private delegate GraphicsBuffer.Target get_targetDelegate(IntPtr @this);

		// Token: 0x0200060C RID: 1548
		// (Invoke) Token: 0x06003523 RID: 13603
		private delegate GraphicsBuffer.UsageFlags GetUsageFlagsDelegate(IntPtr @this);

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x06003525 RID: 13605
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x06003527 RID: 13607
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x06003529 RID: 13609
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000610 RID: 1552
		// (Invoke) Token: 0x0600352B RID: 13611
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x02000611 RID: 1553
		// (Invoke) Token: 0x0600352D RID: 13613
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x02000612 RID: 1554
		// (Invoke) Token: 0x0600352F RID: 13615
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x02000613 RID: 1555
		// (Invoke) Token: 0x06003531 RID: 13617
		private delegate void CopyCountCCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000614 RID: 1556
		// (Invoke) Token: 0x06003533 RID: 13619
		private delegate void CopyCountGCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000615 RID: 1557
		// (Invoke) Token: 0x06003535 RID: 13621
		private delegate void CopyCountCGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000616 RID: 1558
		// (Invoke) Token: 0x06003537 RID: 13623
		private delegate void CopyCountGGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000617 RID: 1559
		// (Invoke) Token: 0x06003539 RID: 13625
		private delegate void get_bufferHandle_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}

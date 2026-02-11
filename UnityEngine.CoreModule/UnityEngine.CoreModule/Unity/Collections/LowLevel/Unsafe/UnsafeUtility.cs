using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000054 RID: 84
	public static class UnsafeUtility : Object
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0001D348 File Offset: 0x0001B548
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeUtility()
		{
			Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
			UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663530);
			UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663531);
			UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663532);
			UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663533);
			UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663534);
			UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663535);
			UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663536);
			UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663537);
			UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663538);
			UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663539);
			UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663540);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663541);
			UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663542);
			UnsafeUtility.NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663543);
			UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663544);
			UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663545);
			UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663546);
			UnsafeUtility.NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663547);
			UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663548);
			UnsafeUtility.NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663549);
			UnsafeUtility.NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663550);
			UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663551);
			UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663552);
			UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663553);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663554);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663555);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663556);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663557);
			UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663558);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663559);
			UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663560);
			UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663561);
			UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663562);
			UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663563);
			UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663564);
			UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663565);
			UnsafeUtility.GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
			UnsafeUtility.GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
			UnsafeUtility.PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
			UnsafeUtility.PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
			UnsafeUtility.ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
			UnsafeUtility.CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
			UnsafeUtility.CheckForLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CheckForLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CheckForLeaks");
			UnsafeUtility.ForgiveLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ForgiveLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ForgiveLeaks");
			UnsafeUtility.GetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetLeakDetectionMode");
			UnsafeUtility.SetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.SetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SetLeakDetectionMode");
			UnsafeUtility.MemCpyReplicateDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
			UnsafeUtility.MemMoveDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemMoveDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemMove");
			UnsafeUtility.MemCmpDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCmpDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCmp");
			UnsafeUtility.IsUnmanagedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
			UnsafeUtility.IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
			UnsafeUtility.LogErrorDelegateField = IL2CPP.ResolveICall<UnsafeUtility.LogErrorDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError");
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001D738 File Offset: 0x0001B938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644009, XrefRangeEnd = 644015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlittable<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001D768 File Offset: 0x0001B968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 644017, RefRangeEnd = 644020, XrefRangeStart = 644015, XrefRangeEnd = 644017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref category;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callstacksToSkip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001D7C4 File Offset: 0x0001B9C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644022, RefRangeEnd = 644024, XrefRangeStart = 644020, XrefRangeEnd = 644022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeakErase(IntPtr handle, LeakCategory category)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001D810 File Offset: 0x0001BA10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644026, RefRangeEnd = 644028, XrefRangeStart = 644024, XrefRangeEnd = 644026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callstacksToSkip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001D870 File Offset: 0x0001BA70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644030, RefRangeEnd = 644031, XrefRangeStart = 644028, XrefRangeEnd = 644030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeTracked(void* memory, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = memory;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 644033, RefRangeEnd = 644037, XrefRangeStart = 644031, XrefRangeEnd = 644033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001D900 File Offset: 0x0001BB00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644039, RefRangeEnd = 644041, XrefRangeStart = 644037, XrefRangeEnd = 644039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = memory;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001D940 File Offset: 0x0001BB40
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 644043, RefRangeEnd = 644075, XrefRangeStart = 644041, XrefRangeEnd = 644043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001D98C File Offset: 0x0001BB8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 644077, RefRangeEnd = 644080, XrefRangeStart = 644075, XrefRangeEnd = 644077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationStride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceStride;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001DA04 File Offset: 0x0001BC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644082, RefRangeEnd = 644083, XrefRangeStart = 644080, XrefRangeEnd = 644082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0001DA54 File Offset: 0x0001BC54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 644085, RefRangeEnd = 644091, XrefRangeStart = 644083, XrefRangeEnd = 644085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemClear(void* destination, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0001DA94 File Offset: 0x0001BC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644188, RefRangeEnd = 644190, XrefRangeStart = 644091, XrefRangeEnd = 644188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644192, RefRangeEnd = 644193, XrefRangeStart = 644190, XrefRangeEnd = 644192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlittable(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644195, RefRangeEnd = 644196, XrefRangeStart = 644193, XrefRangeEnd = 644195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetScriptingTypeFlags(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001DB60 File Offset: 0x0001BD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644196, XrefRangeEnd = 644197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlittableValueType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 644216, RefRangeEnd = 644219, XrefRangeStart = 644197, XrefRangeEnd = 644216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 644221, RefRangeEnd = 644226, XrefRangeStart = 644219, XrefRangeEnd = 644221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArrayBlittable(Array arr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001DC38 File Offset: 0x0001BE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644226, XrefRangeEnd = 644227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericListBlittable<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0001DC68 File Offset: 0x0001BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644227, XrefRangeEnd = 644230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetReasonForArrayNonBlittable(Array arr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644230, XrefRangeEnd = 644243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetReasonForGenericListNonBlittable<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644243, XrefRangeEnd = 644247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnmanaged<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsUnmanaged_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 644248, RefRangeEnd = 644252, XrefRangeStart = 644247, XrefRangeEnd = 644248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AlignOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644252, XrefRangeEnd = 644253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : new()
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref output;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr2, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				output = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		[CallerCount(0)]
		public unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : new()
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref output;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr2, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				output = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001DE30 File Offset: 0x0001C030
		[CallerCount(0)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001DE78 File Offset: 0x0001C078
		[CallerCount(0)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001DED0 File Offset: 0x0001C0D0
		[CallerCount(0)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001DF58 File Offset: 0x0001C158
		[CallerCount(0)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* AddressOf<T>(ref T output) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				output = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001E040 File Offset: 0x0001C240
		[CallerCount(0)]
		public unsafe static int SizeOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001E070 File Offset: 0x0001C270
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T As<U, T>(ref U from)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(from);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				from = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<U>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>(void* ptr) where T : new()
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		[CallerCount(0)]
		public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : new()
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001E134 File Offset: 0x0001C334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644253, XrefRangeEnd = 644254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EnumToInt<T>(T enumValue) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = enumValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref enumValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		[CallerCount(0)]
		public unsafe static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(enumValue);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intValue;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			enumValue = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001E208 File Offset: 0x0001C408
		[CallerCount(0)]
		public unsafe static bool EnumEquals<T>(T lhs, T rhs) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = lhs;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref lhs;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = rhs;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref rhs;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000367E File Offset: 0x0000187E
		public UnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003687 File Offset: 0x00001887
		public static int GetFieldOffsetInStruct(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003699 File Offset: 0x00001899
		public static int GetFieldOffsetInClass(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
		public static int GetFieldOffset(FieldInfo field)
		{
			bool isValueType = field.DeclaringType.IsValueType;
			int num;
			if (isValueType)
			{
				num = UnsafeUtility.GetFieldOffsetInStruct(field);
			}
			else
			{
				bool isClass = field.DeclaringType.IsClass;
				if (isClass)
				{
					num = UnsafeUtility.GetFieldOffsetInClass(field);
				}
				else
				{
					num = -1;
				}
			}
			return num;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001E30C File Offset: 0x0001C50C
		public unsafe static void* PinGCObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddress(target, out gcHandle);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001E328 File Offset: 0x0001C528
		public unsafe static void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddress(target, out gcHandle);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000036AB File Offset: 0x000018AB
		public unsafe static void* PinSystemArrayAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000036BE File Offset: 0x000018BE
		public unsafe static void* PinSystemObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000036D1 File Offset: 0x000018D1
		public static void ReleaseGCObject(ulong gcHandle)
		{
			UnsafeUtility.ReleaseGCObjectDelegateField(gcHandle);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000036DE File Offset: 0x000018DE
		public unsafe static void CopyObjectAddressToPtr(Object target, void* dstPtr)
		{
			UnsafeUtility.CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), dstPtr);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000036F1 File Offset: 0x000018F1
		public static int CheckForLeaks()
		{
			return UnsafeUtility.CheckForLeaksDelegateField();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000036FD File Offset: 0x000018FD
		public static int ForgiveLeaks()
		{
			return UnsafeUtility.ForgiveLeaksDelegateField();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003709 File Offset: 0x00001909
		public static NativeLeakDetectionMode GetLeakDetectionMode()
		{
			return UnsafeUtility.GetLeakDetectionModeDelegateField();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003715 File Offset: 0x00001915
		public static void SetLeakDetectionMode(NativeLeakDetectionMode value)
		{
			UnsafeUtility.SetLeakDetectionModeDelegateField(value);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001E344 File Offset: 0x0001C544
		public static bool IsValidAllocator(Allocator allocator)
		{
			return allocator > Allocator.None;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00003722 File Offset: 0x00001922
		public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
		{
			UnsafeUtility.MemCpyReplicateDelegateField(destination, source, size, count);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003732 File Offset: 0x00001932
		public unsafe static void MemMove(void* destination, void* source, long size)
		{
			UnsafeUtility.MemMoveDelegateField(destination, source, size);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003741 File Offset: 0x00001941
		public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
		{
			return UnsafeUtility.MemCmpDelegateField(ptr1, ptr2, size);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003750 File Offset: 0x00001950
		public static bool IsUnmanaged(Type type)
		{
			return UnsafeUtility.IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003762 File Offset: 0x00001962
		public static bool IsValidNativeContainerElementType(Type type)
		{
			return UnsafeUtility.IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003774 File Offset: 0x00001974
		public static void LogError(string msg, string filename, int linenumber)
		{
			UnsafeUtility.LogErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(msg), IL2CPP.ManagedStringToIl2Cpp(filename), linenumber);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001E35C File Offset: 0x0001C55C
		public static string GetReasonForTypeNonBlittable(Type t)
		{
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(t, t.Name);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001E37C File Offset: 0x0001C57C
		public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		public static bool IsNativeContainerType<T>()
		{
			return (UnsafeUtility.TypeFlagsCache.flags & 2) != 0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public static bool IsValidNativeContainerElementType<T>()
		{
			return UnsafeUtility.TypeFlagsCache.flags == 0;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000378D File Offset: 0x0000198D
		public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			UnsafeUtility.InternalCopyStructureToPtr<T>(ref input, ptr);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003798 File Offset: 0x00001998
		public unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			*(T*)ptr = input;
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0;

		// Token: 0x04000212 RID: 530
		public const int kIsManaged = 1;

		// Token: 0x04000213 RID: 531
		public const int kIsNativeContainer = 2;

		// Token: 0x04000214 RID: 532
		private static readonly UnsafeUtility.GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;

		// Token: 0x04000215 RID: 533
		private static readonly UnsafeUtility.GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;

		// Token: 0x04000216 RID: 534
		private static readonly UnsafeUtility.PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;

		// Token: 0x04000217 RID: 535
		private static readonly UnsafeUtility.PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;

		// Token: 0x04000218 RID: 536
		private static readonly UnsafeUtility.ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;

		// Token: 0x04000219 RID: 537
		private static readonly UnsafeUtility.CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;

		// Token: 0x0400021A RID: 538
		private static readonly UnsafeUtility.CheckForLeaksDelegate CheckForLeaksDelegateField;

		// Token: 0x0400021B RID: 539
		private static readonly UnsafeUtility.ForgiveLeaksDelegate ForgiveLeaksDelegateField;

		// Token: 0x0400021C RID: 540
		private static readonly UnsafeUtility.GetLeakDetectionModeDelegate GetLeakDetectionModeDelegateField;

		// Token: 0x0400021D RID: 541
		private static readonly UnsafeUtility.SetLeakDetectionModeDelegate SetLeakDetectionModeDelegateField;

		// Token: 0x0400021E RID: 542
		private static readonly UnsafeUtility.MemCpyReplicateDelegate MemCpyReplicateDelegateField;

		// Token: 0x0400021F RID: 543
		private static readonly UnsafeUtility.MemMoveDelegate MemMoveDelegateField;

		// Token: 0x04000220 RID: 544
		private static readonly UnsafeUtility.MemCmpDelegate MemCmpDelegateField;

		// Token: 0x04000221 RID: 545
		private static readonly UnsafeUtility.IsUnmanagedDelegate IsUnmanagedDelegateField;

		// Token: 0x04000222 RID: 546
		private static readonly UnsafeUtility.IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;

		// Token: 0x04000223 RID: 547
		private static readonly UnsafeUtility.LogErrorDelegate LogErrorDelegateField;

		// Token: 0x020003D5 RID: 981
		public sealed class TypeFlagsCache<T> : ValueType
		{
			// Token: 0x060030A4 RID: 12452 RVA: 0x000B799C File Offset: 0x000B5B9C
			// Note: this type is marked as 'beforefieldinit'.
			static TypeFlagsCache()
			{
				Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "TypeFlagsCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr, "flags");
				UnsafeUtility.TypeFlagsCache<T>.NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr, 100663567);
			}

			// Token: 0x060030A5 RID: 12453 RVA: 0x000B7A20 File Offset: 0x000B5C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644003, XrefRangeEnd = 644009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Init(ref int flags)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &flags;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.TypeFlagsCache<T>.NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030A6 RID: 12454 RVA: 0x000138E3 File Offset: 0x00011AE3
			public TypeFlagsCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030A7 RID: 12455 RVA: 0x000138EC File Offset: 0x00011AEC
			public TypeFlagsCache()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000B7A54 File Offset: 0x000B5C54
			// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000138FE File Offset: 0x00011AFE
			public unsafe static int flags
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags, (void*)(&value));
				}
			}

			// Token: 0x04002B08 RID: 11016
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04002B09 RID: 11017
			private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0;
		}

		// Token: 0x020003D6 RID: 982
		public sealed class AlignOfHelper<T> : ValueType where T : new()
		{
			// Token: 0x060030AA RID: 12458 RVA: 0x000B7A70 File Offset: 0x000B5C70
			// Note: this type is marked as 'beforefieldinit'.
			static AlignOfHelper()
			{
				Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr);
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "dummy");
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "data");
			}

			// Token: 0x060030AB RID: 12459 RVA: 0x0001390C File Offset: 0x00011B0C
			public AlignOfHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030AC RID: 12460 RVA: 0x00013915 File Offset: 0x00011B15
			public AlignOfHelper()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x060030AD RID: 12461 RVA: 0x000B7B00 File Offset: 0x000B5D00
			// (set) Token: 0x060030AE RID: 12462 RVA: 0x00013927 File Offset: 0x00011B27
			public unsafe byte dummy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy)) = value;
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x060030AF RID: 12463 RVA: 0x000B7B28 File Offset: 0x000B5D28
			// (set) Token: 0x060030B0 RID: 12464 RVA: 0x000B7B50 File Offset: 0x000B5D50
			public unsafe T data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04002B0A RID: 11018
			private static readonly IntPtr NativeFieldInfoPtr_dummy;

			// Token: 0x04002B0B RID: 11019
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x020003D7 RID: 983
		private sealed class MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>
		{
			// Token: 0x04002B0C RID: 11020
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D8 RID: 984
		private sealed class MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>
		{
			// Token: 0x04002B0D RID: 11021
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D9 RID: 985
		private sealed class MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>
		{
			// Token: 0x04002B0E RID: 11022
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DA RID: 986
		private sealed class MethodInfoStoreGeneric_IsUnmanaged_Public_Static_Boolean_0<T>
		{
			// Token: 0x04002B0F RID: 11023
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DB RID: 987
		private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04002B10 RID: 11024
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DC RID: 988
		private sealed class MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002B11 RID: 11025
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DD RID: 989
		private sealed class MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002B12 RID: 11026
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DE RID: 990
		private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002B13 RID: 11027
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DF RID: 991
		private sealed class MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>
		{
			// Token: 0x04002B14 RID: 11028
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E0 RID: 992
		private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
		{
			// Token: 0x04002B15 RID: 11029
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E1 RID: 993
		private sealed class MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>
		{
			// Token: 0x04002B16 RID: 11030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E2 RID: 994
		private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002B17 RID: 11031
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E3 RID: 995
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04002B18 RID: 11032
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E4 RID: 996
		private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>
		{
			// Token: 0x04002B19 RID: 11033
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E5 RID: 997
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04002B1A RID: 11034
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E6 RID: 998
		private sealed class MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002B1B RID: 11035
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E7 RID: 999
		private sealed class MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>
		{
			// Token: 0x04002B1C RID: 11036
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E8 RID: 1000
		private sealed class MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>
		{
			// Token: 0x04002B1D RID: 11037
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E9 RID: 1001
		private sealed class MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>
		{
			// Token: 0x04002B1E RID: 11038
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003EA RID: 1002
		// (Invoke) Token: 0x060030C5 RID: 12485
		private delegate int GetFieldOffsetInStructDelegate(IntPtr field);

		// Token: 0x020003EB RID: 1003
		// (Invoke) Token: 0x060030C7 RID: 12487
		private delegate int GetFieldOffsetInClassDelegate(IntPtr field);

		// Token: 0x020003EC RID: 1004
		// (Invoke) Token: 0x060030C9 RID: 12489
		private delegate IntPtr PinSystemArrayAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x020003ED RID: 1005
		// (Invoke) Token: 0x060030CB RID: 12491
		private delegate IntPtr PinSystemObjectAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x020003EE RID: 1006
		// (Invoke) Token: 0x060030CD RID: 12493
		private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

		// Token: 0x020003EF RID: 1007
		// (Invoke) Token: 0x060030CF RID: 12495
		private delegate void CopyObjectAddressToPtrDelegate(IntPtr target, IntPtr dstPtr);

		// Token: 0x020003F0 RID: 1008
		// (Invoke) Token: 0x060030D1 RID: 12497
		private delegate int CheckForLeaksDelegate();

		// Token: 0x020003F1 RID: 1009
		// (Invoke) Token: 0x060030D3 RID: 12499
		private delegate int ForgiveLeaksDelegate();

		// Token: 0x020003F2 RID: 1010
		// (Invoke) Token: 0x060030D5 RID: 12501
		private delegate NativeLeakDetectionMode GetLeakDetectionModeDelegate();

		// Token: 0x020003F3 RID: 1011
		// (Invoke) Token: 0x060030D7 RID: 12503
		private delegate void SetLeakDetectionModeDelegate(NativeLeakDetectionMode value);

		// Token: 0x020003F4 RID: 1012
		// (Invoke) Token: 0x060030D9 RID: 12505
		private delegate void MemCpyReplicateDelegate(IntPtr destination, IntPtr source, int size, int count);

		// Token: 0x020003F5 RID: 1013
		// (Invoke) Token: 0x060030DB RID: 12507
		private delegate void MemMoveDelegate(IntPtr destination, IntPtr source, long size);

		// Token: 0x020003F6 RID: 1014
		// (Invoke) Token: 0x060030DD RID: 12509
		private delegate int MemCmpDelegate(IntPtr ptr1, IntPtr ptr2, long size);

		// Token: 0x020003F7 RID: 1015
		// (Invoke) Token: 0x060030DF RID: 12511
		private delegate bool IsUnmanagedDelegate(IntPtr type);

		// Token: 0x020003F8 RID: 1016
		// (Invoke) Token: 0x060030E1 RID: 12513
		private delegate bool IsValidNativeContainerElementTypeDelegate(IntPtr type);

		// Token: 0x020003F9 RID: 1017
		// (Invoke) Token: 0x060030E3 RID: 12515
		private delegate void LogErrorDelegate(IntPtr msg, IntPtr filename, int linenumber);
	}
}

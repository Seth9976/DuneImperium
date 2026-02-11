using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000002 RID: 2
	public static class Unsafe : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020E0 File Offset: 0x000002E0
		// Note: this type is marked as 'beforefieldinit'.
		static Unsafe()
		{
			Il2CppClassPointerStore<Unsafe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.Unsafe.dll", "Unity.Burst", "Unsafe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unsafe>.NativeClassPtr);
			Unsafe.NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663297);
			Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663298);
			Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663299);
			Unsafe.NativeMethodInfoPtr_Write_Public_Static_Void_ptr_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663300);
			Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_ptr_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663301);
			Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663302);
			Unsafe.NativeMethodInfoPtr_Copy_Public_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663303);
			Unsafe.NativeMethodInfoPtr_Copy_Public_Static_Void_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663304);
			Unsafe.NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663305);
			Unsafe.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663306);
			Unsafe.NativeMethodInfoPtr_CopyBlock_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663307);
			Unsafe.NativeMethodInfoPtr_CopyBlock_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663308);
			Unsafe.NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663309);
			Unsafe.NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663310);
			Unsafe.NativeMethodInfoPtr_InitBlock_Public_Static_Void_ptr_Void_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663311);
			Unsafe.NativeMethodInfoPtr_InitBlock_Public_Static_Void_byref_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663312);
			Unsafe.NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_ptr_Void_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663313);
			Unsafe.NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_byref_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663314);
			Unsafe.NativeMethodInfoPtr_As_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663315);
			Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663316);
			Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663317);
			Unsafe.NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663318);
			Unsafe.NativeMethodInfoPtr_Unbox_Public_Static_byref_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663319);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663320);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663321);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663322);
			Unsafe.NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663323);
			Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663324);
			Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663325);
			Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663326);
			Unsafe.NativeMethodInfoPtr_SubtractByteOffset_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663327);
			Unsafe.NativeMethodInfoPtr_ByteOffset_Public_Static_IntPtr_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663328);
			Unsafe.NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663329);
			Unsafe.NativeMethodInfoPtr_IsAddressGreaterThan_Public_Static_Boolean_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663330);
			Unsafe.NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100663331);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000023CC File Offset: 0x000005CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275167, XrefRangeEnd = 1275171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Read<T>(void* source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Read_Public_Static_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002408 File Offset: 0x00000608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ReadUnaligned<T>(void* source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_ReadUnaligned_Public_Static_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002444 File Offset: 0x00000644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ReadUnaligned<T>(ref byte source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_ReadUnaligned_Public_Static_T_byref_Byte_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002480 File Offset: 0x00000680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275171, XrefRangeEnd = 1275177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write<T>(void* destination, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Write_Public_Static_Void_ptr_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000024FC File Offset: 0x000006FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteUnaligned<T>(void* destination, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_WriteUnaligned_Public_Static_Void_ptr_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002578 File Offset: 0x00000778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteUnaligned<T>(ref byte destination, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &destination;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_WriteUnaligned_Public_Static_Void_byref_Byte_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025F4 File Offset: 0x000007F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275177, XrefRangeEnd = 1275183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy<T>(void* destination, ref T source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Copy_Public_Static_Void_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002650 File Offset: 0x00000850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy<T>(ref T destination, void* source)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Copy_Public_Static_Void_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			destination = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026AC File Offset: 0x000008AC
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* AsPointer<T>(ref T value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AsPointer_Public_Static_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026FC File Offset: 0x000008FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275183, XrefRangeEnd = 1275184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000272C File Offset: 0x0000092C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275184, XrefRangeEnd = 1275185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyBlock(void* destination, void* source, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_CopyBlock_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002778 File Offset: 0x00000978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyBlock(ref byte destination, ref byte source, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_CopyBlock_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027C8 File Offset: 0x000009C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyBlockUnaligned(void* destination, void* source, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002814 File Offset: 0x00000A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002864 File Offset: 0x00000A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275186, RefRangeEnd = 1275187, XrefRangeStart = 1275185, XrefRangeEnd = 1275186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = startAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_InitBlock_Public_Static_Void_ptr_Void_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000028B4 File Offset: 0x00000AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275186, RefRangeEnd = 1275187, XrefRangeStart = 1275186, XrefRangeEnd = 1275187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitBlock(ref byte startAddress, byte value, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &startAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_InitBlock_Public_Static_Void_byref_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002904 File Offset: 0x00000B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275186, RefRangeEnd = 1275187, XrefRangeStart = 1275186, XrefRangeEnd = 1275187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = startAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_ptr_Void_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002954 File Offset: 0x00000B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275186, RefRangeEnd = 1275187, XrefRangeStart = 1275186, XrefRangeEnd = 1275187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &startAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_byref_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000029A4 File Offset: 0x00000BA4
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T As<T>(Object o) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_As_Public_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000029E4 File Offset: 0x00000BE4
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>(void* source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002A18 File Offset: 0x00000C18
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>(ref T source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002A68 File Offset: 0x00000C68
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref TTo As<TFrom, TTo>(ref TFrom source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_As_Public_Static_byref_TTo_byref_TFrom_0<TFrom, TTo>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TFrom>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002AB8 File Offset: 0x00000CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275187, XrefRangeEnd = 1275192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T Unbox<T>(Object box) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Unbox_Public_Static_byref_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275192, XrefRangeEnd = 1275193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T Add<T>(ref T source, int elementOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B50 File Offset: 0x00000D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275193, XrefRangeEnd = 1275194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Add<T>(void* source, int elementOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Add_Public_Static_ptr_Void_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B90 File Offset: 0x00000D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275194, XrefRangeEnd = 1275195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T Add<T>(ref T source, IntPtr elementOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[CallerCount(0)]
		public unsafe static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C50 File Offset: 0x00000E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275195, XrefRangeEnd = 1275196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T Subtract<T>(ref T source, int elementOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Subtract_Public_Static_byref_T_byref_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275196, XrefRangeEnd = 1275197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Subtract<T>(void* source, int elementOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Subtract_Public_Static_ptr_Void_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275197, XrefRangeEnd = 1275198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T Subtract<T>(ref T source, IntPtr elementOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_Subtract_Public_Static_byref_T_byref_T_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D50 File Offset: 0x00000F50
		[CallerCount(0)]
		public unsafe static ref T SubtractByteOffset<T>(ref T source, IntPtr byteOffset)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOffset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_SubtractByteOffset_Public_Static_byref_T_byref_T_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002DB0 File Offset: 0x00000FB0
		[CallerCount(0)]
		public unsafe static IntPtr ByteOffset<T>(ref T origin, ref T target)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(origin);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_ByteOffset_Public_Static_IntPtr_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			origin = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			target = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E38 File Offset: 0x00001038
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreSame<T>(ref T left, ref T right)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(left);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AreSame_Public_Static_Boolean_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			left = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			right = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002EC0 File Offset: 0x000010C0
		[CallerCount(0)]
		public unsafe static bool IsAddressGreaterThan<T>(ref T left, ref T right)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(left);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_IsAddressGreaterThan_Public_Static_Boolean_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			left = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			right = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F48 File Offset: 0x00001148
		[CallerCount(0)]
		public unsafe static bool IsAddressLessThan<T>(ref T left, ref T right)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(left);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			left = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			right = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		public Unsafe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_ptr_Void_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_ptr_Void_T_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_ptr_Void_T_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_ptr_Void_byref_T_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_byref_T_ptr_Void_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_CopyBlock_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_CopyBlock_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_ptr_Void_ptr_Void_UInt32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_CopyBlockUnaligned_Public_Static_Void_byref_Byte_byref_Byte_UInt32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_InitBlock_Public_Static_Void_ptr_Void_Byte_UInt32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_InitBlock_Public_Static_Void_byref_Byte_Byte_UInt32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_ptr_Void_Byte_UInt32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_byref_Byte_Byte_UInt32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_T_Object_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Unbox_Public_Static_byref_T_Object_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_Int32_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_ptr_Void_ptr_Void_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_SubtractByteOffset_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ByteOffset_Public_Static_IntPtr_byref_T_byref_T_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressGreaterThan_Public_Static_Boolean_byref_T_byref_T_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0;

		// Token: 0x02000005 RID: 5
		private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_ptr_Void_0<T>
		{
			// Token: 0x04000026 RID: 38
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000006 RID: 6
		private sealed class MethodInfoStoreGeneric_ReadUnaligned_Public_Static_T_ptr_Void_0<T>
		{
			// Token: 0x04000027 RID: 39
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000007 RID: 7
		private sealed class MethodInfoStoreGeneric_ReadUnaligned_Public_Static_T_byref_Byte_0<T>
		{
			// Token: 0x04000028 RID: 40
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000008 RID: 8
		private sealed class MethodInfoStoreGeneric_Write_Public_Static_Void_ptr_Void_T_0<T>
		{
			// Token: 0x04000029 RID: 41
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Write_Public_Static_Void_ptr_Void_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000009 RID: 9
		private sealed class MethodInfoStoreGeneric_WriteUnaligned_Public_Static_Void_ptr_Void_T_0<T>
		{
			// Token: 0x0400002A RID: 42
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_ptr_Void_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000A RID: 10
		private sealed class MethodInfoStoreGeneric_WriteUnaligned_Public_Static_Void_byref_Byte_T_0<T>
		{
			// Token: 0x0400002B RID: 43
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000B RID: 11
		private sealed class MethodInfoStoreGeneric_Copy_Public_Static_Void_ptr_Void_byref_T_0<T>
		{
			// Token: 0x0400002C RID: 44
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Copy_Public_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000C RID: 12
		private sealed class MethodInfoStoreGeneric_Copy_Public_Static_Void_byref_T_ptr_Void_0<T>
		{
			// Token: 0x0400002D RID: 45
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Copy_Public_Static_Void_byref_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000D RID: 13
		private sealed class MethodInfoStoreGeneric_AsPointer_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x0400002E RID: 46
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000E RID: 14
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x0400002F RID: 47
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000F RID: 15
		private sealed class MethodInfoStoreGeneric_As_Public_Static_T_Object_0<T>
		{
			// Token: 0x04000030 RID: 48
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_As_Public_Static_T_Object_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000010 RID: 16
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04000031 RID: 49
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000011 RID: 17
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_byref_T_0<T>
		{
			// Token: 0x04000032 RID: 50
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000012 RID: 18
		private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_TTo_byref_TFrom_0<TFrom, TTo>
		{
			// Token: 0x04000033 RID: 51
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000013 RID: 19
		private sealed class MethodInfoStoreGeneric_Unbox_Public_Static_byref_T_Object_0<T>
		{
			// Token: 0x04000034 RID: 52
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Unbox_Public_Static_byref_T_Object_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000014 RID: 20
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_Int32_0<T>
		{
			// Token: 0x04000035 RID: 53
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000015 RID: 21
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_ptr_Void_ptr_Void_Int32_0<T>
		{
			// Token: 0x04000036 RID: 54
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000016 RID: 22
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x04000037 RID: 55
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000017 RID: 23
		private sealed class MethodInfoStoreGeneric_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x04000038 RID: 56
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000018 RID: 24
		private sealed class MethodInfoStoreGeneric_Subtract_Public_Static_byref_T_byref_T_Int32_0<T>
		{
			// Token: 0x04000039 RID: 57
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000019 RID: 25
		private sealed class MethodInfoStoreGeneric_Subtract_Public_Static_ptr_Void_ptr_Void_Int32_0<T>
		{
			// Token: 0x0400003A RID: 58
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_ptr_Void_ptr_Void_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001A RID: 26
		private sealed class MethodInfoStoreGeneric_Subtract_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x0400003B RID: 59
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Subtract_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001B RID: 27
		private sealed class MethodInfoStoreGeneric_SubtractByteOffset_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x0400003C RID: 60
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_SubtractByteOffset_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_ByteOffset_Public_Static_IntPtr_byref_T_byref_T_0<T>
		{
			// Token: 0x0400003D RID: 61
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_ByteOffset_Public_Static_IntPtr_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001D RID: 29
		private sealed class MethodInfoStoreGeneric_AreSame_Public_Static_Boolean_byref_T_byref_T_0<T>
		{
			// Token: 0x0400003E RID: 62
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_IsAddressGreaterThan_Public_Static_Boolean_byref_T_byref_T_0<T>
		{
			// Token: 0x0400003F RID: 63
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_IsAddressGreaterThan_Public_Static_Boolean_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0<T>
		{
			// Token: 0x04000040 RID: 64
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

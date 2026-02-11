using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003E1 RID: 993
	public static class Unsafe : Object
	{
		// Token: 0x06003A47 RID: 14919 RVA: 0x00118EC8 File Offset: 0x001170C8
		// Note: this type is marked as 'beforefieldinit'.
		static Unsafe()
		{
			Il2CppClassPointerStore<Unsafe>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "Unsafe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unsafe>.NativeClassPtr);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100671996);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100671997);
			Unsafe.NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100671998);
			Unsafe.NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100671999);
			Unsafe.NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672000);
			Unsafe.NativeMethodInfoPtr_As_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672001);
			Unsafe.NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672002);
			Unsafe.NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672003);
			Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672004);
			Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672005);
			Unsafe.NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_byref_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672006);
			Unsafe.NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672007);
			Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672008);
			Unsafe.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672009);
			Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672010);
			Unsafe.NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672011);
			Unsafe.NativeMethodInfoPtr_AddByteOffset_Internal_Static_byref_T_byref_T_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unsafe>.NativeClassPtr, 100672012);
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x0011904C File Offset: 0x0011724C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 634855, RefRangeEnd = 634861, XrefRangeStart = 634855, XrefRangeEnd = 634861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003A49 RID: 14921 RVA: 0x001190AC File Offset: 0x001172AC
		[CallerCount(0)]
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

		// Token: 0x06003A4A RID: 14922 RVA: 0x0011910C File Offset: 0x0011730C
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 1346403, RefRangeEnd = 1346468, XrefRangeStart = 1346403, XrefRangeEnd = 1346468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003A4B RID: 14923 RVA: 0x0011914C File Offset: 0x0011734C
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

		// Token: 0x06003A4C RID: 14924 RVA: 0x001191AC File Offset: 0x001173AC
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

		// Token: 0x06003A4D RID: 14925 RVA: 0x00119234 File Offset: 0x00117434
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

		// Token: 0x06003A4E RID: 14926 RVA: 0x00119274 File Offset: 0x00117474
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

		// Token: 0x06003A4F RID: 14927 RVA: 0x001192C4 File Offset: 0x001174C4
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

		// Token: 0x06003A50 RID: 14928 RVA: 0x00119314 File Offset: 0x00117514
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

		// Token: 0x06003A51 RID: 14929 RVA: 0x00119348 File Offset: 0x00117548
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>([In] ref T source)
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

		// Token: 0x06003A52 RID: 14930 RVA: 0x00119398 File Offset: 0x00117598
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

		// Token: 0x06003A53 RID: 14931 RVA: 0x001193E8 File Offset: 0x001175E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003A54 RID: 14932 RVA: 0x00119424 File Offset: 0x00117624
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003A55 RID: 14933 RVA: 0x00119460 File Offset: 0x00117660
		[CallerCount(0)]
		public unsafe static int SizeOf<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00119490 File Offset: 0x00117690
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003A57 RID: 14935 RVA: 0x0011950C File Offset: 0x0011770C
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

		// Token: 0x06003A58 RID: 14936 RVA: 0x00119594 File Offset: 0x00117794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396459, XrefRangeEnd = 1396460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AddByteOffset<T>(ref T source, ulong byteOffset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Unsafe.MethodInfoStoreGeneric_AddByteOffset_Internal_Static_byref_T_byref_T_UInt64_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00015ABA File Offset: 0x00013CBA
		public Unsafe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_T_Object_0;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0;

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeMethodInfoPtr_InitBlockUnaligned_Public_Static_Void_byref_Byte_Byte_UInt32_0;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeMethodInfoPtr_AddByteOffset_Internal_Static_byref_T_byref_T_UInt64_0;

		// Token: 0x020006A4 RID: 1700
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_Int32_0<T>
		{
			// Token: 0x04004AFD RID: 19197
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A5 RID: 1701
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x04004AFE RID: 19198
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A6 RID: 1702
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_ptr_Void_ptr_Void_Int32_0<T>
		{
			// Token: 0x04004AFF RID: 19199
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Add_Public_Static_ptr_Void_ptr_Void_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A7 RID: 1703
		private sealed class MethodInfoStoreGeneric_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0<T>
		{
			// Token: 0x04004B00 RID: 19200
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AddByteOffset_Public_Static_byref_T_byref_T_IntPtr_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A8 RID: 1704
		private sealed class MethodInfoStoreGeneric_AreSame_Public_Static_Boolean_byref_T_byref_T_0<T>
		{
			// Token: 0x04004B01 RID: 19201
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AreSame_Public_Static_Boolean_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A9 RID: 1705
		private sealed class MethodInfoStoreGeneric_As_Public_Static_T_Object_0<T>
		{
			// Token: 0x04004B02 RID: 19202
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_As_Public_Static_T_Object_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006AA RID: 1706
		private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_TTo_byref_TFrom_0<TFrom, TTo>
		{
			// Token: 0x04004B03 RID: 19203
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_As_Public_Static_byref_TTo_byref_TFrom_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
			}))));
		}

		// Token: 0x020006AB RID: 1707
		private sealed class MethodInfoStoreGeneric_AsPointer_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04004B04 RID: 19204
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsPointer_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006AC RID: 1708
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04004B05 RID: 19205
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006AD RID: 1709
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_byref_T_0<T>
		{
			// Token: 0x04004B06 RID: 19206
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006AE RID: 1710
		private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_ptr_Void_0<T>
		{
			// Token: 0x04004B07 RID: 19207
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_Read_Public_Static_T_ptr_Void_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006AF RID: 1711
		private sealed class MethodInfoStoreGeneric_ReadUnaligned_Public_Static_T_byref_Byte_0<T>
		{
			// Token: 0x04004B08 RID: 19208
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_ReadUnaligned_Public_Static_T_byref_Byte_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006B0 RID: 1712
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04004B09 RID: 19209
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006B1 RID: 1713
		private sealed class MethodInfoStoreGeneric_WriteUnaligned_Public_Static_Void_byref_Byte_T_0<T>
		{
			// Token: 0x04004B0A RID: 19210
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_WriteUnaligned_Public_Static_Void_byref_Byte_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006B2 RID: 1714
		private sealed class MethodInfoStoreGeneric_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0<T>
		{
			// Token: 0x04004B0B RID: 19211
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_IsAddressLessThan_Public_Static_Boolean_byref_T_byref_T_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006B3 RID: 1715
		private sealed class MethodInfoStoreGeneric_AddByteOffset_Internal_Static_byref_T_byref_T_UInt64_0<T>
		{
			// Token: 0x04004B0C RID: 19212
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Unsafe.NativeMethodInfoPtr_AddByteOffset_Internal_Static_byref_T_byref_T_UInt64_0, Il2CppClassPointerStore<Unsafe>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

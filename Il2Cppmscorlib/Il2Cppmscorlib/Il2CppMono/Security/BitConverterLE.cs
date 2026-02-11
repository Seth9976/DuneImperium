using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x0200002A RID: 42
	public sealed class BitConverterLE : Object
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0002D480 File Offset: 0x0002B680
		// Note: this type is marked as 'beforefieldinit'.
		static BitConverterLE()
		{
			Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "BitConverterLE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr);
			BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663593);
			BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663594);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663595);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663596);
			BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663597);
			BitConverterLE.NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663598);
			BitConverterLE.NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663599);
			BitConverterLE.NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663600);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0002D550 File Offset: 0x0002B750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277726, XrefRangeEnd = 1277729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUIntBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0002D590 File Offset: 0x0002B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277729, XrefRangeEnd = 1277732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetULongBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277735, RefRangeEnd = 1277736, XrefRangeStart = 1277732, XrefRangeEnd = 1277735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0002D610 File Offset: 0x0002B810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277739, RefRangeEnd = 1277740, XrefRangeStart = 1277736, XrefRangeEnd = 1277739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0002D650 File Offset: 0x0002B850
		[CallerCount(0)]
		public unsafe static void UIntFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		[CallerCount(0)]
		public unsafe static void ULongFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277740, RefRangeEnd = 1277741, XrefRangeStart = 1277740, XrefRangeEnd = 1277740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0002D748 File Offset: 0x0002B948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277741, RefRangeEnd = 1277742, XrefRangeStart = 1277741, XrefRangeEnd = 1277741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002DCE File Offset: 0x00000FCE
		public BitConverterLE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0;
	}
}

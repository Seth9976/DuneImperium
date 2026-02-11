using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Buffers;

namespace Il2CppSystem
{
	// Token: 0x0200007D RID: 125
	public static class BitConverter : Object
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00044464 File Offset: 0x00042664
		// Note: this type is marked as 'beforefieldinit'.
		static BitConverter()
		{
			Il2CppClassPointerStore<BitConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BitConverter");
			BitConverter.NativeFieldInfoPtr_IsLittleEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, "IsLittleEndian");
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664420);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664421);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664422);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664423);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664424);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664425);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664426);
			BitConverter.NativeMethodInfoPtr_TryWriteBytes_Public_Static_Boolean_Span_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664427);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664428);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664429);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664430);
			BitConverter.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664431);
			BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664432);
			BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664433);
			BitConverter.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664434);
			BitConverter.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664435);
			BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664436);
			BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664437);
			BitConverter.NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664438);
			BitConverter.NativeMethodInfoPtr_SingleToInt32Bits_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664439);
			BitConverter.NativeMethodInfoPtr_Int32BitsToSingle_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664440);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00044644 File Offset: 0x00042844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1298992, RefRangeEnd = 1298993, XrefRangeStart = 1298989, XrefRangeEnd = 1298992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00044684 File Offset: 0x00042884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1298996, RefRangeEnd = 1298997, XrefRangeStart = 1298993, XrefRangeEnd = 1298996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000446C4 File Offset: 0x000428C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299000, RefRangeEnd = 1299001, XrefRangeStart = 1298997, XrefRangeEnd = 1299000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00044704 File Offset: 0x00042904
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1299004, RefRangeEnd = 1299011, XrefRangeStart = 1299001, XrefRangeEnd = 1299004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00044744 File Offset: 0x00042944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299014, RefRangeEnd = 1299015, XrefRangeStart = 1299011, XrefRangeEnd = 1299014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00044784 File Offset: 0x00042984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1299018, RefRangeEnd = 1299020, XrefRangeStart = 1299015, XrefRangeEnd = 1299018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000447C4 File Offset: 0x000429C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1299023, RefRangeEnd = 1299025, XrefRangeStart = 1299020, XrefRangeEnd = 1299023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00044804 File Offset: 0x00042A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299029, RefRangeEnd = 1299030, XrefRangeStart = 1299025, XrefRangeEnd = 1299029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryWriteBytes(Span<byte> destination, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_TryWriteBytes_Public_Static_Boolean_Span_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00044858 File Offset: 0x00042A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299033, RefRangeEnd = 1299034, XrefRangeStart = 1299030, XrefRangeEnd = 1299033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00044898 File Offset: 0x00042A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299037, RefRangeEnd = 1299038, XrefRangeStart = 1299034, XrefRangeEnd = 1299037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000448D8 File Offset: 0x00042AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299041, RefRangeEnd = 1299042, XrefRangeStart = 1299038, XrefRangeEnd = 1299041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00044918 File Offset: 0x00042B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299044, RefRangeEnd = 1299045, XrefRangeStart = 1299042, XrefRangeEnd = 1299044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00044968 File Offset: 0x00042B68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1299047, RefRangeEnd = 1299056, XrefRangeStart = 1299045, XrefRangeEnd = 1299047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000449B8 File Offset: 0x00042BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1299061, RefRangeEnd = 1299063, XrefRangeStart = 1299056, XrefRangeEnd = 1299061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ReadOnlySpan<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ReadOnlySpan_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00044A00 File Offset: 0x00042C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299044, RefRangeEnd = 1299045, XrefRangeStart = 1299044, XrefRangeEnd = 1299045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00044A50 File Offset: 0x00042C50
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1299047, RefRangeEnd = 1299056, XrefRangeStart = 1299047, XrefRangeEnd = 1299056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00044AA0 File Offset: 0x00042CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299088, RefRangeEnd = 1299089, XrefRangeStart = 1299063, XrefRangeEnd = 1299088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00044AF8 File Offset: 0x00042CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299089, XrefRangeEnd = 1299092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00044B34 File Offset: 0x00042D34
		[CallerCount(0)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00044B74 File Offset: 0x00042D74
		[CallerCount(0)]
		public unsafe static int SingleToInt32Bits(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_SingleToInt32Bits_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00044BB4 File Offset: 0x00042DB4
		[CallerCount(0)]
		public unsafe static float Int32BitsToSingle(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_Int32BitsToSingle_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00004156 File Offset: 0x00002356
		public BitConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00044BF4 File Offset: 0x00042DF4
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x0000415F File Offset: 0x0000235F
		public unsafe static bool IsLittleEndian
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BitConverter.NativeFieldInfoPtr_IsLittleEndian, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BitConverter.NativeFieldInfoPtr_IsLittleEndian, (void*)(&value));
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_IsLittleEndian;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Char_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt16_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Static_Boolean_Span_1_Byte_UInt32_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Single_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Double_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_SingleToInt32Bits_Public_Static_Int32_Single_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_Int32BitsToSingle_Public_Static_Single_Int32_0;

		// Token: 0x02000583 RID: 1411
		[ObfuscatedName("System.BitConverter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005680 RID: 22144 RVA: 0x0018F3FC File Offset: 0x0018D5FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr);
				BitConverter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr, "<>9");
				BitConverter.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr, "<>9__38_0");
				BitConverter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr, 100664443);
				BitConverter.__c.NativeMethodInfoPtr__ToString_b__38_0_Internal_Void_Span_1_Char_ValueTuple_3_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr, 100664444);
			}

			// Token: 0x06005681 RID: 22145 RVA: 0x0018F478 File Offset: 0x0018D678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitConverter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005682 RID: 22146 RVA: 0x0018F4B4 File Offset: 0x0018D6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1298975, XrefRangeEnd = 1298989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ToString_b__38_0(Span<char> dst, ValueTuple<Il2CppStructArray<byte>, int, int> state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.__c.NativeMethodInfoPtr__ToString_b__38_0_Internal_Void_Span_1_Char_ValueTuple_3_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005683 RID: 22147 RVA: 0x0001EC33 File Offset: 0x0001CE33
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161E RID: 5662
			// (get) Token: 0x06005684 RID: 22148 RVA: 0x0018F514 File Offset: 0x0018D714
			// (set) Token: 0x06005685 RID: 22149 RVA: 0x0001EC3C File Offset: 0x0001CE3C
			public unsafe static BitConverter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BitConverter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitConverter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BitConverter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161F RID: 5663
			// (get) Token: 0x06005686 RID: 22150 RVA: 0x0018F53C File Offset: 0x0018D73C
			// (set) Token: 0x06005687 RID: 22151 RVA: 0x0001EC4E File Offset: 0x0001CE4E
			public unsafe static SpanAction<char, ValueTuple<Il2CppStructArray<byte>, int, int>> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BitConverter.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpanAction<char, ValueTuple<Il2CppStructArray<byte>, int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BitConverter.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004699 RID: 18073
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400469A RID: 18074
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x0400469B RID: 18075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400469C RID: 18076
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__38_0_Internal_Void_Span_1_Char_ValueTuple_3_Il2CppStructArray_1_Byte_Int32_Int32_0;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x0200003E RID: 62
	public static class CoreUnsafeUtils : Object
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		// Note: this type is marked as 'beforefieldinit'.
		static CoreUnsafeUtils()
		{
			Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreUnsafeUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr);
			CoreUnsafeUtils.NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663892);
			CoreUnsafeUtils.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663893);
			CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663894);
			CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663895);
			CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663896);
			CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663897);
			CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663898);
			CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663899);
			CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663900);
			CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663901);
			CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663902);
			CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663903);
			CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663904);
			CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663905);
			CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663906);
			CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663907);
			CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663908);
			CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663909);
			CoreUnsafeUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663910);
			CoreUnsafeUtils.NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663911);
			CoreUnsafeUtils.NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663912);
			CoreUnsafeUtils.NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663913);
			CoreUnsafeUtils.NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663914);
			CoreUnsafeUtils.NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663915);
			CoreUnsafeUtils.NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100663916);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001F610 File Offset: 0x0001D810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959475, XrefRangeEnd = 959477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTo<T>(this List<T> list, void* dest, int count) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001F664 File Offset: 0x0001D864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959478, RefRangeEnd = 959479, XrefRangeStart = 959477, XrefRangeEnd = 959478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTo<T>(this Il2CppArrayBase<T> list, void* dest, int count) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		[CallerCount(0)]
		public unsafe static void CalculateRadixParams(int radixBits, out int bitStates)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radixBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bitStates;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[CallerCount(0)]
		public unsafe static int CalculateRadixSupportSize(int bitStates, int arrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitStates;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001F744 File Offset: 0x0001D944
		[CallerCount(0)]
		public unsafe static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitStates;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = supportArray;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			bucketIndices = ((intPtr7 == 0) ? null : new uint*(intPtr7));
			IntPtr intPtr8 = intPtr2;
			bucketSizes = ((intPtr8 == 0) ? null : new uint*(intPtr8));
			IntPtr intPtr9 = intPtr3;
			bucketPrefix = ((intPtr9 == 0) ? null : new uint*(intPtr9));
			IntPtr intPtr10 = intPtr4;
			arrayOutput = ((intPtr10 == 0) ? null : new uint*(intPtr10));
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001F820 File Offset: 0x0001DA20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 959480, RefRangeEnd = 959482, XrefRangeStart = 959479, XrefRangeEnd = 959480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MergeSort(uint* array, uint* support, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = support;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001F86C File Offset: 0x0001DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959482, XrefRangeEnd = 959492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MergeSort(Il2CppStructArray<uint> arr, int sortSize, ref Il2CppStructArray<uint> supportArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(supportArray);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			supportArray = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959492, XrefRangeEnd = 959506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(supportArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001F934 File Offset: 0x0001DB34
		[CallerCount(0)]
		public unsafe static void InsertionSort(uint* arr, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = arr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001F974 File Offset: 0x0001DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959506, XrefRangeEnd = 959511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(Il2CppStructArray<uint> arr, int sortSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959511, XrefRangeEnd = 959519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(NativeArray<uint> arr, int sortSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001FA04 File Offset: 0x0001DC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 959520, RefRangeEnd = 959522, XrefRangeStart = 959519, XrefRangeEnd = 959520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = support;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radixBits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitStates;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959522, XrefRangeEnd = 959533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RadixSort(Il2CppStructArray<uint> arr, int sortSize, ref Il2CppStructArray<uint> supportArray, int radixBits = 8)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(supportArray);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radixBits;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			supportArray = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959533, XrefRangeEnd = 959547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(supportArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radixBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001FB54 File Offset: 0x0001DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959547, XrefRangeEnd = 959552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort(Il2CppStructArray<uint> arr, int left, int right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 959564, RefRangeEnd = 959566, XrefRangeStart = 959552, XrefRangeEnd = 959564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<T>(int count, void* data) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959566, XrefRangeEnd = 959568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<TValue, TKey, TGetter>(int count, void* data) where TValue : new() where TKey : new() where TGetter : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<TValue, TKey, TGetter>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001FC28 File Offset: 0x0001DE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959578, RefRangeEnd = 959579, XrefRangeStart = 959568, XrefRangeEnd = 959578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : new() where TKey : new() where TGetter : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001FC78 File Offset: 0x0001DE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959579, XrefRangeEnd = 959590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(void* data, int count, T v) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = v;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref v;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959610, RefRangeEnd = 959611, XrefRangeStart = 959590, XrefRangeEnd = 959610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : new() where TOldGetter : new() where TNewValue : new() where TNewGetter : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldHashCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = oldHashes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHashCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = newHashes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = addIndices;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = removeIndices;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &addCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0<TOldValue, TOldGetter, TNewValue, TNewGetter>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001FDAC File Offset: 0x0001DFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959611, XrefRangeEnd = 959614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldHashCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = oldHashes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHashCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = newHashes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = addIndices;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = removeIndices;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &addCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001FE4C File Offset: 0x0001E04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959618, RefRangeEnd = 959619, XrefRangeStart = 959614, XrefRangeEnd = 959618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) where TValue : new() where TGetter : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hashes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = outHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0<TValue, TGetter>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001FE98 File Offset: 0x0001E098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959619, XrefRangeEnd = 959622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineHashes(int count, Hash128* hashes, Hash128* outHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hashes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = outHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959622, XrefRangeEnd = 959629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : new() where TKey : new() where TGetter : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.MethodInfoStoreGeneric_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001FF3C File Offset: 0x0001E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959629, XrefRangeEnd = 959641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HaveDuplicates(Il2CppStructArray<int> arr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004079 File Offset: 0x00002279
		public CoreUnsafeUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0;

		// Token: 0x0200016A RID: 362
		[StructLayout(2)]
		public struct FixedBufferStringQueue
		{
			// Token: 0x060015FC RID: 5628 RVA: 0x0005F600 File Offset: 0x0005D800
			// Note: this type is marked as 'beforefieldinit'.
			static FixedBufferStringQueue()
			{
				Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "FixedBufferStringQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr_m_ReadCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "m_ReadCursor");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr_m_WriteCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "m_WriteCursor");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr_m_BufferEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "m_BufferEnd");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr_m_BufferStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "m_BufferStart");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr_m_BufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "m_BufferLength");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, "<Count>k__BackingField");
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663917);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663918);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663919);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_TryPush_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663920);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663921);
				CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, 100663922);
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x060015FD RID: 5629 RVA: 0x0005F71C File Offset: 0x0005D91C
			// (set) Token: 0x060015FE RID: 5630 RVA: 0x0005F74C File Offset: 0x0005D94C
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060015FF RID: 5631 RVA: 0x0005F780 File Offset: 0x0005D980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959470, XrefRangeEnd = 959471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FixedBufferStringQueue(byte* ptr, int length)
			{
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ptr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0, ref this, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001600 RID: 5632 RVA: 0x0005F7C0 File Offset: 0x0005D9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959471, XrefRangeEnd = 959473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryPush(string v)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_TryPush_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001601 RID: 5633 RVA: 0x0005F804 File Offset: 0x0005DA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959473, XrefRangeEnd = 959474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryPop(out string v)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0, ref this, (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					v = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001602 RID: 5634 RVA: 0x0005F850 File Offset: 0x0005DA50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959474, XrefRangeEnd = 959475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.FixedBufferStringQueue.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001603 RID: 5635 RVA: 0x0000B18C File Offset: 0x0000938C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreUnsafeUtils.FixedBufferStringQueue>.NativeClassPtr, ref this));
			}

			// Token: 0x04001002 RID: 4098
			private static readonly IntPtr NativeFieldInfoPtr_m_ReadCursor;

			// Token: 0x04001003 RID: 4099
			private static readonly IntPtr NativeFieldInfoPtr_m_WriteCursor;

			// Token: 0x04001004 RID: 4100
			private static readonly IntPtr NativeFieldInfoPtr_m_BufferEnd;

			// Token: 0x04001005 RID: 4101
			private static readonly IntPtr NativeFieldInfoPtr_m_BufferStart;

			// Token: 0x04001006 RID: 4102
			private static readonly IntPtr NativeFieldInfoPtr_m_BufferLength;

			// Token: 0x04001007 RID: 4103
			private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

			// Token: 0x04001008 RID: 4104
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04001009 RID: 4105
			private static readonly IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;

			// Token: 0x0400100A RID: 4106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0;

			// Token: 0x0400100B RID: 4107
			private static readonly IntPtr NativeMethodInfoPtr_TryPush_Public_Boolean_String_0;

			// Token: 0x0400100C RID: 4108
			private static readonly IntPtr NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0;

			// Token: 0x0400100D RID: 4109
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400100E RID: 4110
			[FieldOffset(0)]
			public IntPtr m_ReadCursor;

			// Token: 0x0400100F RID: 4111
			[FieldOffset(8)]
			public IntPtr m_WriteCursor;

			// Token: 0x04001010 RID: 4112
			[FieldOffset(16)]
			public readonly IntPtr m_BufferEnd;

			// Token: 0x04001011 RID: 4113
			[FieldOffset(24)]
			public readonly IntPtr m_BufferStart;

			// Token: 0x04001012 RID: 4114
			[FieldOffset(32)]
			public readonly int m_BufferLength;

			// Token: 0x04001013 RID: 4115
			[FieldOffset(36)]
			public int _Count_k__BackingField;
		}

		// Token: 0x0200016B RID: 363
		public class IKeyGetter<TValue, TKey> : Il2CppObjectBase
		{
			// Token: 0x06001604 RID: 5636 RVA: 0x0005F878 File Offset: 0x0005DA78
			// Note: this type is marked as 'beforefieldinit'.
			static IKeyGetter()
			{
				Il2CppClassPointerStore<CoreUnsafeUtils.IKeyGetter<TValue, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "IKeyGetter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
				})).TypeHandle.value);
				CoreUnsafeUtils.IKeyGetter<TValue, TKey>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.IKeyGetter<TValue, TKey>>.NativeClassPtr, 100663923);
			}

			// Token: 0x06001605 RID: 5637 RVA: 0x0005F8FC File Offset: 0x0005DAFC
			[CallerCount(0)]
			public unsafe virtual TKey Get(ref TValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(v);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CoreUnsafeUtils.IKeyGetter<TValue, TKey>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					v = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr4, false, false));
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr2, false, true);
				}
			}

			// Token: 0x06001606 RID: 5638 RVA: 0x0000B19E File Offset: 0x0000939E
			public IKeyGetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001014 RID: 4116
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0;
		}

		// Token: 0x0200016C RID: 364
		public sealed class DefaultKeyGetter<T> : ValueType
		{
			// Token: 0x06001607 RID: 5639 RVA: 0x0005F96C File Offset: 0x0005DB6C
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultKeyGetter()
			{
				Il2CppClassPointerStore<CoreUnsafeUtils.DefaultKeyGetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "DefaultKeyGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUnsafeUtils.DefaultKeyGetter<T>>.NativeClassPtr);
				CoreUnsafeUtils.DefaultKeyGetter<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.DefaultKeyGetter<T>>.NativeClassPtr, 100663924);
			}

			// Token: 0x06001608 RID: 5640 RVA: 0x0005F9E8 File Offset: 0x0005DBE8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 351672, RefRangeEnd = 351676, XrefRangeStart = 351672, XrefRangeEnd = 351676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T Get(ref T v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(v);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.DefaultKeyGetter<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					v = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06001609 RID: 5641 RVA: 0x0000B1A7 File Offset: 0x000093A7
			public DefaultKeyGetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600160A RID: 5642 RVA: 0x0000B1B0 File Offset: 0x000093B0
			public DefaultKeyGetter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreUnsafeUtils.DefaultKeyGetter<T>>.NativeClassPtr))
			{
			}

			// Token: 0x04001015 RID: 4117
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0;
		}

		// Token: 0x0200016D RID: 365
		[StructLayout(2)]
		public struct UintKeyGetter
		{
			// Token: 0x0600160B RID: 5643 RVA: 0x0000B1C2 File Offset: 0x000093C2
			// Note: this type is marked as 'beforefieldinit'.
			static UintKeyGetter()
			{
				Il2CppClassPointerStore<CoreUnsafeUtils.UintKeyGetter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "UintKeyGetter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUnsafeUtils.UintKeyGetter>.NativeClassPtr);
				CoreUnsafeUtils.UintKeyGetter.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils.UintKeyGetter>.NativeClassPtr, 100663925);
			}

			// Token: 0x0600160C RID: 5644 RVA: 0x0005FA50 File Offset: 0x0005DC50
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Get(ref uint v)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUnsafeUtils.UintKeyGetter.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600160D RID: 5645 RVA: 0x0000B1F6 File Offset: 0x000093F6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreUnsafeUtils.UintKeyGetter>.NativeClassPtr, ref this));
			}

			// Token: 0x04001016 RID: 4118
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0;
		}

		// Token: 0x0200016E RID: 366
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04001017 RID: 4119
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200016F RID: 367
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04001018 RID: 4120
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000170 RID: 368
		private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<T>
		{
			// Token: 0x04001019 RID: 4121
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000171 RID: 369
		private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<TValue, TKey, TGetter>
		{
			// Token: 0x0400101A RID: 4122
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000172 RID: 370
		private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>
		{
			// Token: 0x0400101B RID: 4123
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000173 RID: 371
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0<T>
		{
			// Token: 0x0400101C RID: 4124
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000174 RID: 372
		private sealed class MethodInfoStoreGeneric_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0<TOldValue, TOldGetter, TNewValue, TNewGetter>
		{
			// Token: 0x0400101D RID: 4125
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOldValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOldGetter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewGetter>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000175 RID: 373
		private sealed class MethodInfoStoreGeneric_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0<TValue, TGetter>
		{
			// Token: 0x0400101E RID: 4126
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000176 RID: 374
		private sealed class MethodInfoStoreGeneric_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>
		{
			// Token: 0x0400101F RID: 4127
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
			}))));
		}
	}
}

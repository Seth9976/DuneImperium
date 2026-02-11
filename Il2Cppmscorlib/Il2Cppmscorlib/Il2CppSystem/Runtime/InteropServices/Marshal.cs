using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Security;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000399 RID: 921
	public static class Marshal : Object
	{
		// Token: 0x0600382B RID: 14379 RVA: 0x00111B04 File Offset: 0x0010FD04
		// Note: this type is marked as 'beforefieldinit'.
		static Marshal()
		{
			Il2CppClassPointerStore<Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "Marshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal>.NativeClassPtr);
			Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemMaxDBCSCharSize");
			Marshal.NativeFieldInfoPtr_SystemDefaultCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemDefaultCharSize");
			Marshal.NativeFieldInfoPtr_MarshalerInstanceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceCache");
			Marshal.NativeFieldInfoPtr_MarshalerInstanceCacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceCacheLock");
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671687);
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671688);
			Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671689);
			Marshal.NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671690);
			Marshal.NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671691);
			Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671692);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671693);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671694);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671695);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671696);
			Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671697);
			Marshal.NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671698);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671699);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671700);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671701);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671702);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671703);
			Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671704);
			Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671705);
			Marshal.NativeMethodInfoPtr_ClearBSTR_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671706);
			Marshal.NativeMethodInfoPtr_ZeroFreeBSTR_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671707);
			Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671708);
			Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671709);
			Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671710);
			Marshal.NativeMethodInfoPtr_IsComObject_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671711);
			Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671712);
			Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671713);
			Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671714);
			Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671715);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671716);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671717);
			Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671718);
			Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671719);
			Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671720);
			Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671721);
			Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671722);
			Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671723);
			Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671724);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671725);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671726);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671727);
			Marshal.NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671728);
			Marshal.NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671729);
			Marshal.NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671730);
			Marshal.NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671731);
			Marshal.NativeMethodInfoPtr_SecureStringToBSTR_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671732);
			Marshal.NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671733);
			Marshal.NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671734);
			Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671735);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671736);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671737);
			Marshal.NativeMethodInfoPtr_BufferToBSTR_Private_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671738);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671739);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671740);
			Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671741);
			Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671742);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671743);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671744);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671745);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671746);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671747);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671748);
			Marshal.NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671749);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00112070 File Offset: 0x00110270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391773, XrefRangeEnd = 1391774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocHGlobal(IntPtr cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x001120B0 File Offset: 0x001102B0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1391779, RefRangeEnd = 1391800, XrefRangeStart = 1391774, XrefRangeEnd = 1391779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocHGlobal(int cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x001120F0 File Offset: 0x001102F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1391804, RefRangeEnd = 1391807, XrefRangeStart = 1391800, XrefRangeEnd = 1391804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00112150 File Offset: 0x00110350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391807, XrefRangeEnd = 1391808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = fixed_source_element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x001121C0 File Offset: 0x001103C0
		[CallerCount(0)]
		public unsafe static bool skip_fixed(Array array, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00112210 File Offset: 0x00110410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391808, XrefRangeEnd = 1391819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_to_unmanaged(Il2CppStructArray<byte> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00112270 File Offset: 0x00110470
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1391838, RefRangeEnd = 1391847, XrefRangeStart = 1391819, XrefRangeEnd = 1391838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<byte> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x001122D0 File Offset: 0x001104D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391858, RefRangeEnd = 1391859, XrefRangeStart = 1391847, XrefRangeEnd = 1391858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<short> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00112330 File Offset: 0x00110530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391870, RefRangeEnd = 1391871, XrefRangeStart = 1391859, XrefRangeEnd = 1391870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<int> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00112390 File Offset: 0x00110590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1391882, RefRangeEnd = 1391884, XrefRangeStart = 1391871, XrefRangeEnd = 1391882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<IntPtr> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x001123F0 File Offset: 0x001105F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1391888, RefRangeEnd = 1391893, XrefRangeStart = 1391884, XrefRangeEnd = 1391888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00112450 File Offset: 0x00110650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391893, XrefRangeEnd = 1391894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = fixed_destination_element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x001124C0 File Offset: 0x001106C0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1391905, RefRangeEnd = 1391921, XrefRangeStart = 1391894, XrefRangeEnd = 1391905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<byte> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00112520 File Offset: 0x00110720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1391932, RefRangeEnd = 1391934, XrefRangeStart = 1391921, XrefRangeEnd = 1391932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<char> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00112580 File Offset: 0x00110780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1391945, RefRangeEnd = 1391947, XrefRangeStart = 1391934, XrefRangeEnd = 1391945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<short> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x001125E0 File Offset: 0x001107E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1391958, RefRangeEnd = 1391960, XrefRangeStart = 1391947, XrefRangeEnd = 1391958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<int> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x00112640 File Offset: 0x00110840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391971, RefRangeEnd = 1391972, XrefRangeStart = 1391960, XrefRangeEnd = 1391971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<IntPtr> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x001126A0 File Offset: 0x001108A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391973, RefRangeEnd = 1391974, XrefRangeStart = 1391972, XrefRangeEnd = 1391973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeBSTR(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x001126D4 File Offset: 0x001108D4
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1391975, RefRangeEnd = 1392013, XrefRangeStart = 1391974, XrefRangeEnd = 1391975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHGlobal(IntPtr hglobal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hglobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00112708 File Offset: 0x00110908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392013, XrefRangeEnd = 1392023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearBSTR(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ClearBSTR_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x0011273C File Offset: 0x0011093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392023, XrefRangeEnd = 1392037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroFreeBSTR(IntPtr s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ZeroFreeBSTR_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00112770 File Offset: 0x00110970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392037, XrefRangeEnd = 1392049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearUnicode(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x001127A4 File Offset: 0x001109A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1392076, RefRangeEnd = 1392079, XrefRangeStart = 1392049, XrefRangeEnd = 1392076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x001127D8 File Offset: 0x001109D8
		[CallerCount(0)]
		public unsafe static int GetHRForException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0011281C File Offset: 0x00110A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392079, XrefRangeEnd = 1392080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComObject(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_IsComObject_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00112860 File Offset: 0x00110A60
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1392081, RefRangeEnd = 1392107, XrefRangeStart = 1392080, XrefRangeEnd = 1392081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLastWin32Error()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00112890 File Offset: 0x00110A90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1392108, RefRangeEnd = 1392113, XrefRangeStart = 1392107, XrefRangeEnd = 1392108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringAnsi(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x001128C8 File Offset: 0x00110AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392114, RefRangeEnd = 1392115, XrefRangeStart = 1392113, XrefRangeEnd = 1392114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringAnsi(IntPtr ptr, int len)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00112910 File Offset: 0x00110B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392116, RefRangeEnd = 1392118, XrefRangeStart = 1392115, XrefRangeEnd = 1392116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUni(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00112948 File Offset: 0x00110B48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1392119, RefRangeEnd = 1392125, XrefRangeStart = 1392118, XrefRangeEnd = 1392119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PtrToStructure(IntPtr ptr, Type structureType)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(structureType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0011299C File Offset: 0x00110B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392136, RefRangeEnd = 1392137, XrefRangeStart = 1392125, XrefRangeEnd = 1392136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PtrToStructure<T>(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x001129D8 File Offset: 0x00110BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392138, RefRangeEnd = 1392139, XrefRangeStart = 1392137, XrefRangeEnd = 1392138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00112A24 File Offset: 0x00110C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392139, XrefRangeEnd = 1392141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00112A70 File Offset: 0x00110C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392141, XrefRangeEnd = 1392143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadInt32(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00112ABC File Offset: 0x00110CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392143, XrefRangeEnd = 1392145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ReadInt64(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00112B08 File Offset: 0x00110D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392158, RefRangeEnd = 1392159, XrefRangeStart = 1392145, XrefRangeEnd = 1392158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00112B54 File Offset: 0x00110D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392159, XrefRangeEnd = 1392160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReleaseInternal(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00112B94 File Offset: 0x00110D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392171, RefRangeEnd = 1392172, XrefRangeStart = 1392160, XrefRangeEnd = 1392171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Release(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00112BD4 File Offset: 0x00110DD4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1392173, RefRangeEnd = 1392186, XrefRangeStart = 1392172, XrefRangeEnd = 1392173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00112C18 File Offset: 0x00110E18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1392195, RefRangeEnd = 1392200, XrefRangeStart = 1392186, XrefRangeEnd = 1392195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00112C48 File Offset: 0x00110E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392200, XrefRangeEnd = 1392209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf<T>(T structure)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = structure;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref structure;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00112CC0 File Offset: 0x00110EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392209, XrefRangeEnd = 1392210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToHGlobalAnsi(char* s, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00112D0C File Offset: 0x00110F0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1392216, RefRangeEnd = 1392221, XrefRangeStart = 1392210, XrefRangeEnd = 1392216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToHGlobalAnsi(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00112D50 File Offset: 0x00110F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392221, XrefRangeEnd = 1392222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToHGlobalUni(char* s, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00112D9C File Offset: 0x00110F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392228, RefRangeEnd = 1392230, XrefRangeStart = 1392222, XrefRangeEnd = 1392228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToHGlobalUni(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00112DE0 File Offset: 0x00110FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392245, RefRangeEnd = 1392246, XrefRangeStart = 1392230, XrefRangeEnd = 1392245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToBSTR(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToBSTR_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00112E24 File Offset: 0x00111024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392246, XrefRangeEnd = 1392254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringGlobalAllocator(int len)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00112E64 File Offset: 0x00111064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392271, RefRangeEnd = 1392272, XrefRangeStart = 1392254, XrefRangeEnd = 1392271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allocator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00112EB8 File Offset: 0x001110B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392292, RefRangeEnd = 1392293, XrefRangeStart = 1392272, XrefRangeEnd = 1392292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00112EFC File Offset: 0x001110FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392294, RefRangeEnd = 1392295, XrefRangeStart = 1392293, XrefRangeEnd = 1392294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr(Object structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(structure);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00112F50 File Offset: 0x00111150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392295, XrefRangeEnd = 1392303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr3 = ref *ptr2;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = structure;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref structure;
				}
				ptr3 = intPtr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>.Pointer, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00112FD8 File Offset: 0x001111D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392303, XrefRangeEnd = 1392304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr BufferToBSTR(char* ptr, int slen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_BufferToBSTR_Private_Static_IntPtr_ptr_Char_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00113024 File Offset: 0x00111224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392305, RefRangeEnd = 1392307, XrefRangeStart = 1392304, XrefRangeEnd = 1392305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00113074 File Offset: 0x00111274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392315, RefRangeEnd = 1392317, XrefRangeStart = 1392307, XrefRangeEnd = 1392315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement<T>(Il2CppArrayBase<T> arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x001130C4 File Offset: 0x001112C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392317, XrefRangeEnd = 1392319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00113114 File Offset: 0x00111314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392319, XrefRangeEnd = 1392321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00113164 File Offset: 0x00111364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392321, XrefRangeEnd = 1392322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x001131B8 File Offset: 0x001113B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1392367, RefRangeEnd = 1392369, XrefRangeStart = 1392322, XrefRangeEnd = 1392367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x0011320C File Offset: 0x0011140C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392379, RefRangeEnd = 1392380, XrefRangeStart = 1392369, XrefRangeEnd = 1392379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, false, true);
			}
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00113248 File Offset: 0x00111448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392381, RefRangeEnd = 1392382, XrefRangeStart = 1392380, XrefRangeEnd = 1392381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x0011328C File Offset: 0x0011148C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392392, RefRangeEnd = 1392393, XrefRangeStart = 1392382, XrefRangeEnd = 1392392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegate(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x001132D0 File Offset: 0x001114D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1392418, RefRangeEnd = 1392427, XrefRangeStart = 1392393, XrefRangeEnd = 1392418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDelegate).IsValueType)
				{
					TDelegate tdelegate = d;
					intPtr = ((tdelegate is string) ? IL2CPP.ManagedStringToIl2Cpp(tdelegate as string) : IL2CPP.Il2CppObjectBaseToPtr(tdelegate as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref d;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00113348 File Offset: 0x00111548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392427, XrefRangeEnd = 1392514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookie);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomMarshaler>(intPtr3) : null;
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00014997 File Offset: 0x00012B97
		public Marshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x001133A0 File Offset: 0x001115A0
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x000149A0 File Offset: 0x00012BA0
		public unsafe static int SystemMaxDBCSCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x001133BC File Offset: 0x001115BC
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x000149AE File Offset: 0x00012BAE
		public unsafe static int SystemDefaultCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x001133D8 File Offset: 0x001115D8
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x000149BC File Offset: 0x00012BBC
		public unsafe static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_MarshalerInstanceCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_MarshalerInstanceCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x00113400 File Offset: 0x00111600
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x000149CE File Offset: 0x00012BCE
		public unsafe static Object MarshalerInstanceCacheLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_MarshalerInstanceCacheLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_MarshalerInstanceCacheLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeFieldInfoPtr_SystemMaxDBCSCharSize;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeFieldInfoPtr_SystemDefaultCharSize;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeFieldInfoPtr_MarshalerInstanceCache;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeFieldInfoPtr_MarshalerInstanceCacheLock;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr_ClearBSTR_Private_Static_Void_IntPtr_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr_ZeroFreeBSTR_Public_Static_Void_IntPtr_0;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_IsComObject_Public_Static_Boolean_Object_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToBSTR_Public_Static_IntPtr_SecureString_0;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_BufferToBSTR_Private_Static_IntPtr_ptr_Char_Int32_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0;

		// Token: 0x0200067B RID: 1659
		public sealed class SecureStringAllocator : MulticastDelegate
		{
			// Token: 0x06005B84 RID: 23428 RVA: 0x000212BC File Offset: 0x0001F4BC
			// Note: this type is marked as 'beforefieldinit'.
			static SecureStringAllocator()
			{
				Il2CppClassPointerStore<Marshal.SecureStringAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SecureStringAllocator");
				Marshal.SecureStringAllocator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.SecureStringAllocator>.NativeClassPtr, 100671751);
				Marshal.SecureStringAllocator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.SecureStringAllocator>.NativeClassPtr, 100671752);
			}

			// Token: 0x06005B85 RID: 23429 RVA: 0x001A03F8 File Offset: 0x0019E5F8
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 863764, RefRangeEnd = 863782, XrefRangeStart = 863764, XrefRangeEnd = 863782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecureStringAllocator(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marshal.SecureStringAllocator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.SecureStringAllocator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B86 RID: 23430 RVA: 0x001A0454 File Offset: 0x0019E654
			[CallerCount(0)]
			public unsafe IntPtr Invoke(int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref len;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.SecureStringAllocator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B87 RID: 23431 RVA: 0x000212FA File Offset: 0x0001F4FA
			public SecureStringAllocator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B88 RID: 23432 RVA: 0x00021303 File Offset: 0x0001F503
			public static implicit operator Marshal.SecureStringAllocator(Func<int, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<Marshal.SecureStringAllocator>(A_0);
			}

			// Token: 0x06005B89 RID: 23433 RVA: 0x0002130B File Offset: 0x0001F50B
			public static Marshal.SecureStringAllocator operator +(Marshal.SecureStringAllocator A_0, Marshal.SecureStringAllocator A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Marshal.SecureStringAllocator>();
			}

			// Token: 0x06005B8A RID: 23434 RVA: 0x00021319 File Offset: 0x0001F519
			public static Marshal.SecureStringAllocator operator -(Marshal.SecureStringAllocator A_0, Marshal.SecureStringAllocator A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Marshal.SecureStringAllocator>();
				}
				return delegate2;
			}

			// Token: 0x04004A8A RID: 19082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004A8B RID: 19083
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0;
		}

		// Token: 0x0200067C RID: 1660
		public class MarshalerInstanceKeyComparer : Object
		{
			// Token: 0x06005B8B RID: 23435 RVA: 0x001A04A0 File Offset: 0x0019E6A0
			// Note: this type is marked as 'beforefieldinit'.
			static MarshalerInstanceKeyComparer()
			{
				Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceKeyComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr);
				Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr, 100671753);
				Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr, 100671754);
				Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr, 100671755);
			}

			// Token: 0x06005B8C RID: 23436 RVA: 0x001A0508 File Offset: 0x0019E708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391757, XrefRangeEnd = 1391760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005B8D RID: 23437 RVA: 0x001A0574 File Offset: 0x0019E774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391760, XrefRangeEnd = 1391763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int GetHashCode(ValueTuple<Type, string> key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B8E RID: 23438 RVA: 0x001A05C8 File Offset: 0x0019E7C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MarshalerInstanceKeyComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marshal.MarshalerInstanceKeyComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MarshalerInstanceKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B8F RID: 23439 RVA: 0x0002132A File Offset: 0x0001F52A
			public MarshalerInstanceKeyComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004A8C RID: 19084
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0;

			// Token: 0x04004A8D RID: 19085
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0;

			// Token: 0x04004A8E RID: 19086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200067D RID: 1661
		[ObfuscatedName("System.Runtime.InteropServices.Marshal+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005B90 RID: 23440 RVA: 0x001A0604 File Offset: 0x0019E804
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr);
				Marshal.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr, "<>9");
				Marshal.__c.NativeFieldInfoPtr___9__201_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr, "<>9__201_0");
				Marshal.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr, 100671757);
				Marshal.__c.NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr, 100671758);
			}

			// Token: 0x06005B91 RID: 23441 RVA: 0x001A0680 File Offset: 0x0019E880
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marshal.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B92 RID: 23442 RVA: 0x001A06BC File Offset: 0x0019E8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391763, XrefRangeEnd = 1391773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<ValueTuple<Type, string>, ICustomMarshaler> _GetCustomMarshalerInstance_b__201_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.__c.NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(intPtr3) : null;
			}

			// Token: 0x06005B93 RID: 23443 RVA: 0x00021333 File Offset: 0x0001F533
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001772 RID: 6002
			// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001A06FC File Offset: 0x0019E8FC
			// (set) Token: 0x06005B95 RID: 23445 RVA: 0x0002133C File Offset: 0x0001F53C
			public unsafe static Marshal.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Marshal.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Marshal.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Marshal.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001773 RID: 6003
			// (get) Token: 0x06005B96 RID: 23446 RVA: 0x001A0724 File Offset: 0x0019E924
			// (set) Token: 0x06005B97 RID: 23447 RVA: 0x0002134E File Offset: 0x0001F54E
			public unsafe static Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>> __9__201_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Marshal.__c.NativeFieldInfoPtr___9__201_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Marshal.__c.NativeFieldInfoPtr___9__201_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A8F RID: 19087
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004A90 RID: 19088
			private static readonly IntPtr NativeFieldInfoPtr___9__201_0;

			// Token: 0x04004A91 RID: 19089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004A92 RID: 19090
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0;
		}

		// Token: 0x0200067E RID: 1662
		private sealed class MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>
		{
			// Token: 0x04004A93 RID: 19091
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200067F RID: 1663
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04004A94 RID: 19092
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000680 RID: 1664
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_T_0<T>
		{
			// Token: 0x04004A95 RID: 19093
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000681 RID: 1665
		private sealed class MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>
		{
			// Token: 0x04004A96 RID: 19094
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000682 RID: 1666
		private sealed class MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004A97 RID: 19095
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000683 RID: 1667
		private sealed class MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>
		{
			// Token: 0x04004A98 RID: 19096
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
		}

		// Token: 0x02000684 RID: 1668
		private sealed class MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>
		{
			// Token: 0x04004A99 RID: 19097
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
		}
	}
}

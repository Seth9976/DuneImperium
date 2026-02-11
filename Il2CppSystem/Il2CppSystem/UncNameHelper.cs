using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000069 RID: 105
	public class UncNameHelper : Object
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00035EF8 File Offset: 0x000340F8
		// Note: this type is marked as 'beforefieldinit'.
		static UncNameHelper()
		{
			Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UncNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr);
			UncNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr, 100664397);
			UncNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr, 100664398);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00035F50 File Offset: 0x00034150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436672, RefRangeEnd = 436673, XrefRangeStart = 436654, XrefRangeEnd = 436672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00035FB8 File Offset: 0x000341B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436677, RefRangeEnd = 436678, XrefRangeStart = 436673, XrefRangeEnd = 436677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000041C6 File Offset: 0x000023C6
		public UncNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0;
	}
}

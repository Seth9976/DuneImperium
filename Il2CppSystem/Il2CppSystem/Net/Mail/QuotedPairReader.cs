using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x0200024E RID: 590
	public static class QuotedPairReader : Object
	{
		// Token: 0x06002766 RID: 10086 RVA: 0x000B4014 File Offset: 0x000B2214
		// Note: this type is marked as 'beforefieldinit'.
		static QuotedPairReader()
		{
			Il2CppClassPointerStore<QuotedPairReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "QuotedPairReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuotedPairReader>.NativeClassPtr);
			QuotedPairReader.NativeMethodInfoPtr_CountQuotedChars_Internal_Static_Int32_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuotedPairReader>.NativeClassPtr, 100669155);
			QuotedPairReader.NativeMethodInfoPtr_CountBackslashes_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuotedPairReader>.NativeClassPtr, 100669156);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000B406C File Offset: 0x000B226C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 491019, RefRangeEnd = 491023, XrefRangeStart = 491004, XrefRangeEnd = 491019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountQuotedChars(string data, int index, bool permitUnicodeEscaping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permitUnicodeEscaping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuotedPairReader.NativeMethodInfoPtr_CountQuotedChars_Internal_Static_Int32_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000B40CC File Offset: 0x000B22CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491023, XrefRangeEnd = 491028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountBackslashes(string data, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuotedPairReader.NativeMethodInfoPtr_CountBackslashes_Private_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00011018 File Offset: 0x0000F218
		public QuotedPairReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_CountQuotedChars_Internal_Static_Int32_String_Int32_Boolean_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_CountBackslashes_Private_Static_Int32_String_Int32_0;
	}
}

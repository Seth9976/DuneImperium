using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x02000250 RID: 592
	public static class WhitespaceReader : Object
	{
		// Token: 0x0600276F RID: 10095 RVA: 0x000B42A0 File Offset: 0x000B24A0
		// Note: this type is marked as 'beforefieldinit'.
		static WhitespaceReader()
		{
			Il2CppClassPointerStore<WhitespaceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "WhitespaceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhitespaceReader>.NativeClassPtr);
			WhitespaceReader.NativeMethodInfoPtr_ReadFwsReverse_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhitespaceReader>.NativeClassPtr, 100669160);
			WhitespaceReader.NativeMethodInfoPtr_ReadCfwsReverse_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhitespaceReader>.NativeClassPtr, 100669161);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000B42F8 File Offset: 0x000B24F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 491084, RefRangeEnd = 491091, XrefRangeStart = 491060, XrefRangeEnd = 491084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadFwsReverse(string data, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhitespaceReader.NativeMethodInfoPtr_ReadFwsReverse_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000B4348 File Offset: 0x000B2548
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 491113, RefRangeEnd = 491121, XrefRangeStart = 491091, XrefRangeEnd = 491113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadCfwsReverse(string data, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhitespaceReader.NativeMethodInfoPtr_ReadCfwsReverse_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0001102A File Offset: 0x0000F22A
		public WhitespaceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_ReadFwsReverse_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_ReadCfwsReverse_Internal_Static_Int32_String_Int32_0;
	}
}

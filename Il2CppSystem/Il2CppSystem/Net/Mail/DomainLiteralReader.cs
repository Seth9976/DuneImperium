using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x0200024B RID: 587
	public static class DomainLiteralReader : Object
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x00010F8B File Offset: 0x0000F18B
		// Note: this type is marked as 'beforefieldinit'.
		static DomainLiteralReader()
		{
			Il2CppClassPointerStore<DomainLiteralReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "DomainLiteralReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainLiteralReader>.NativeClassPtr);
			DomainLiteralReader.NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainLiteralReader>.NativeClassPtr, 100669146);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000B3C7C File Offset: 0x000B1E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490790, RefRangeEnd = 490791, XrefRangeStart = 490774, XrefRangeEnd = 490790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadReverse(string data, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainLiteralReader.NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		public DomainLiteralReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x0200024C RID: 588
	public static class DotAtomReader : Object
	{
		// Token: 0x0600275A RID: 10074 RVA: 0x00010FCD File Offset: 0x0000F1CD
		// Note: this type is marked as 'beforefieldinit'.
		static DotAtomReader()
		{
			Il2CppClassPointerStore<DotAtomReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "DotAtomReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DotAtomReader>.NativeClassPtr);
			DotAtomReader.NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DotAtomReader>.NativeClassPtr, 100669147);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490807, RefRangeEnd = 490809, XrefRangeStart = 490791, XrefRangeEnd = 490807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DotAtomReader.NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00011006 File Offset: 0x0000F206
		public DotAtomReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr_ReadReverse_Internal_Static_Int32_String_Int32_0;
	}
}

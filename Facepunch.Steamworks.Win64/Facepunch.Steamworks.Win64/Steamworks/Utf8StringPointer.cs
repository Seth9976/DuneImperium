using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000CE RID: 206
	[StructLayout(2)]
	public struct Utf8StringPointer
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x0005481C File Offset: 0x00052A1C
		// Note: this type is marked as 'beforefieldinit'.
		static Utf8StringPointer()
		{
			Il2CppClassPointerStore<Utf8StringPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Utf8StringPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utf8StringPointer>.NativeClassPtr);
			Utf8StringPointer.NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utf8StringPointer>.NativeClassPtr, "ptr");
			Utf8StringPointer.NativeMethodInfoPtr_op_Implicit_Public_Static_String_Utf8StringPointer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringPointer>.NativeClassPtr, 100666455);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00054874 File Offset: 0x00052A74
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 948255, RefRangeEnd = 948290, XrefRangeStart = 948248, XrefRangeEnd = 948255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(Utf8StringPointer p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringPointer.NativeMethodInfoPtr_op_Implicit_Public_Static_String_Utf8StringPointer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00003415 File Offset: 0x00001615
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Utf8StringPointer>.NativeClassPtr, ref this));
		}

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeFieldInfoPtr_ptr;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_Utf8StringPointer_0;

		// Token: 0x04001362 RID: 4962
		[FieldOffset(0)]
		public IntPtr ptr;
	}
}

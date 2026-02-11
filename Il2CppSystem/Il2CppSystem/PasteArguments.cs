using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000057 RID: 87
	public static class PasteArguments : Object
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x0002F344 File Offset: 0x0002D544
		// Note: this type is marked as 'beforefieldinit'.
		static PasteArguments()
		{
			Il2CppClassPointerStore<PasteArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "PasteArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasteArguments>.NativeClassPtr);
			PasteArguments.NativeMethodInfoPtr_AppendArgument_Internal_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteArguments>.NativeClassPtr, 100664178);
			PasteArguments.NativeMethodInfoPtr_ContainsNoWhitespaceOrQuotes_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasteArguments>.NativeClassPtr, 100664179);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002F39C File Offset: 0x0002D59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433664, RefRangeEnd = 433665, XrefRangeStart = 433655, XrefRangeEnd = 433664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendArgument(StringBuilder stringBuilder, string argument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasteArguments.NativeMethodInfoPtr_AppendArgument_Internal_Static_Void_StringBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433665, XrefRangeEnd = 433671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsNoWhitespaceOrQuotes(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasteArguments.NativeMethodInfoPtr_ContainsNoWhitespaceOrQuotes_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00003A53 File Offset: 0x00001C53
		public PasteArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_AppendArgument_Internal_Static_Void_StringBuilder_String_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_ContainsNoWhitespaceOrQuotes_Private_Static_Boolean_String_0;
	}
}

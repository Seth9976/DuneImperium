using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x020000CC RID: 204
	public static class UserGeneratedStringProcessor : Object
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x0000684D File Offset: 0x00004A4D
		// Note: this type is marked as 'beforefieldinit'.
		static UserGeneratedStringProcessor()
		{
			Il2CppClassPointerStore<UserGeneratedStringProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "UserGeneratedStringProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserGeneratedStringProcessor>.NativeClassPtr);
			UserGeneratedStringProcessor.NativeMethodInfoPtr_ProcessUserGeneratedString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserGeneratedStringProcessor>.NativeClassPtr, 100664915);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00030DD0 File Offset: 0x0002EFD0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 993411, RefRangeEnd = 993419, XrefRangeStart = 993409, XrefRangeEnd = 993411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ProcessUserGeneratedString(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserGeneratedStringProcessor.NativeMethodInfoPtr_ProcessUserGeneratedString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00006886 File Offset: 0x00004A86
		public UserGeneratedStringProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUserGeneratedString_Public_Static_String_String_0;
	}
}

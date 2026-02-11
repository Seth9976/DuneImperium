using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000191 RID: 401
	public static class TcpValidationHelpers : Object
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x0000A7B7 File Offset: 0x000089B7
		// Note: this type is marked as 'beforefieldinit'.
		static TcpValidationHelpers()
		{
			Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "TcpValidationHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr);
			TcpValidationHelpers.NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr, 100667166);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0007C580 File Offset: 0x0007A780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 471202, RefRangeEnd = 471205, XrefRangeStart = 471202, XrefRangeEnd = 471202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidatePortNumber(int port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpValidationHelpers.NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000A7F0 File Offset: 0x000089F0
		public TcpValidationHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0;
	}
}

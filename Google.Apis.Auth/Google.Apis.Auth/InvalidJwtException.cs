using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth
{
	// Token: 0x02000004 RID: 4
	public class InvalidJwtException : Exception
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000020F4 File Offset: 0x000002F4
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidJwtException()
		{
			Il2CppClassPointerStore<InvalidJwtException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth", "InvalidJwtException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidJwtException>.NativeClassPtr);
			InvalidJwtException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidJwtException>.NativeClassPtr, 100663357);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00007C18 File Offset: 0x00005E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152674, XrefRangeEnd = 1152678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidJwtException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidJwtException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidJwtException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000212D File Offset: 0x0000032D
		public InvalidJwtException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

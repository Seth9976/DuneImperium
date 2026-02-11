using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class HttpRequestException : Exception
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00007D18 File Offset: 0x00005F18
		// Note: this type is marked as 'beforefieldinit'.
		static HttpRequestException()
		{
			Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpRequestException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr);
			HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr, 100663438);
			HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr, 100663439);
			HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr, 100663440);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171784, XrefRangeEnd = 1171788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007DC0 File Offset: 0x00005FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171788, XrefRangeEnd = 1171792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007E0C File Offset: 0x0000600C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171792, XrefRangeEnd = 1171796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000265E File Offset: 0x0000085E
		public HttpRequestException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;
	}
}

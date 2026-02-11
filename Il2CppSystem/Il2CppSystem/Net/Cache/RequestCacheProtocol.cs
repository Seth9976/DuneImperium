using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022F RID: 559
	public class RequestCacheProtocol : Object
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x000101A8 File Offset: 0x0000E3A8
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheProtocol()
		{
			Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheProtocol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr);
			RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr, 100668765);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000A9D3C File Offset: 0x000A7F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487238, RefRangeEnd = 487240, XrefRangeStart = 487232, XrefRangeEnd = 487238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCacheProtocol(Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000101E1 File Offset: 0x0000E3E1
		public RequestCacheProtocol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022B RID: 555
	public class RequestCachingSectionInternal : Object
	{
		// Token: 0x060024DF RID: 9439 RVA: 0x000A9894 File Offset: 0x000A7A94
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCachingSectionInternal()
		{
			Il2CppClassPointerStore<RequestCachingSectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCachingSectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCachingSectionInternal>.NativeClassPtr);
			RequestCachingSectionInternal.NativeFieldInfoPtr_DisableAllCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCachingSectionInternal>.NativeClassPtr, "DisableAllCaching");
			RequestCachingSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachingSectionInternal>.NativeClassPtr, 100668757);
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000A98EC File Offset: 0x000A7AEC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487154, XrefRangeEnd = 487155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCachingSectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCachingSectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCachingSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000100FA File Offset: 0x0000E2FA
		public RequestCachingSectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000A9928 File Offset: 0x000A7B28
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00010103 File Offset: 0x0000E303
		public unsafe bool DisableAllCaching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachingSectionInternal.NativeFieldInfoPtr_DisableAllCaching);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachingSectionInternal.NativeFieldInfoPtr_DisableAllCaching)) = value;
			}
		}

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeFieldInfoPtr_DisableAllCaching;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

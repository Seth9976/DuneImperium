using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022A RID: 554
	public class RequestCacheValidator : Object
	{
		// Token: 0x060024DC RID: 9436 RVA: 0x000100B8 File Offset: 0x0000E2B8
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheValidator()
		{
			Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr);
			RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr, 100668756);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000A9854 File Offset: 0x000A7A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487152, RefRangeEnd = 487154, XrefRangeStart = 487131, XrefRangeEnd = 487152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateValidator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000100F1 File Offset: 0x0000E2F1
		public RequestCacheValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_CreateValidator_Public_Object_0;
	}
}

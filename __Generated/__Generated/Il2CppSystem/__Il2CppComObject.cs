using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000003 RID: 3
	public class __Il2CppComObject : Object
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002092 File Offset: 0x00000292
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComObject()
		{
			Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "System", "__Il2CppComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr);
			__Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D0 File Offset: 0x000003D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275255, XrefRangeEnd = 1275258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020CB File Offset: 0x000002CB
		public __Il2CppComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000004 RID: 4
	public sealed class __Il2CppComDelegate : __Il2CppComObject
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020D4 File Offset: 0x000002D4
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComDelegate()
		{
			Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "System", "__Il2CppComDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr);
			__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000220C File Offset: 0x0000040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000210D File Offset: 0x0000030D
		public __Il2CppComDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

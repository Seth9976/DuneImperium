using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200015A RID: 346
	public sealed class WaitForEndOfFrame : YieldInstruction
	{
		// Token: 0x060019E0 RID: 6624 RVA: 0x00009F31 File Offset: 0x00008131
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForEndOfFrame()
		{
			Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForEndOfFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr);
			WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr, 100666906);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00079F20 File Offset: 0x00078120
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForEndOfFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00009F6A File Offset: 0x0000816A
		public WaitForEndOfFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

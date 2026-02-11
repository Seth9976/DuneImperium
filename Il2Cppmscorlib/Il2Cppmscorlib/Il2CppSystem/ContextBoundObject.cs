using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200012E RID: 302
	[Serializable]
	public class ContextBoundObject : MarshalByRefObject
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x000065FE File Offset: 0x000047FE
		// Note: this type is marked as 'beforefieldinit'.
		static ContextBoundObject()
		{
			Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextBoundObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr);
			ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr, 100666859);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00087120 File Offset: 0x00085320
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextBoundObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00006637 File Offset: 0x00004837
		public ContextBoundObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

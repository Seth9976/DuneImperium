using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200017F RID: 383
	public class __ComObject : Object
	{
		// Token: 0x06001956 RID: 6486 RVA: 0x0000827D File Offset: 0x0000647D
		// Note: this type is marked as 'beforefieldinit'.
		static __ComObject()
		{
			Il2CppClassPointerStore<__ComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__ComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__ComObject>.NativeClassPtr);
			__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__ComObject>.NativeClassPtr, 100667662);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0009D1DC File Offset: 0x0009B3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350091, XrefRangeEnd = 1350100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __ComObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__ComObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000082B6 File Offset: 0x000064B6
		public __ComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}

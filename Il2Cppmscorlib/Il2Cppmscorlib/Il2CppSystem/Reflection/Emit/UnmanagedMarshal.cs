using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x02000463 RID: 1123
	[Serializable]
	public sealed class UnmanagedMarshal : Object
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x0001862B File Offset: 0x0001682B
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedMarshal()
		{
			Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "UnmanagedMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr);
			UnmanagedMarshal.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr, 100673224);
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x0013CB00 File Offset: 0x0013AD00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMarshal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMarshal.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00018664 File Offset: 0x00016864
		public UnmanagedMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}

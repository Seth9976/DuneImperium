using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class ThreadStaticAttribute : Attribute
	{
		// Token: 0x06000F38 RID: 3896 RVA: 0x00005A88 File Offset: 0x00003C88
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStaticAttribute()
		{
			Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThreadStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr);
			ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr, 100665956);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0006CF80 File Offset: 0x0006B180
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00005AC1 File Offset: 0x00003CC1
		public ThreadStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

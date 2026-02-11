using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000017 RID: 23
	public class ThreadSafeAttribute : NativeMethodAttribute
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000025BB File Offset: 0x000007BB
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeAttribute()
		{
			Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "ThreadSafeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr);
			ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr, 100663348);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000415C File Offset: 0x0000235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269131, XrefRangeEnd = 1269132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadSafeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000025F4 File Offset: 0x000007F4
		public ThreadSafeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

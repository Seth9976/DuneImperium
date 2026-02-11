using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class ThreadAndSerializationSafeAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020B6 File Offset: 0x000002B6
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadAndSerializationSafeAttribute()
		{
			Il2CppClassPointerStore<ThreadAndSerializationSafeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "ThreadAndSerializationSafeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadAndSerializationSafeAttribute>.NativeClassPtr);
			ThreadAndSerializationSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadAndSerializationSafeAttribute>.NativeClassPtr, 100663298);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000297C File Offset: 0x00000B7C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadAndSerializationSafeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadAndSerializationSafeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadAndSerializationSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020EF File Offset: 0x000002EF
		public ThreadAndSerializationSafeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

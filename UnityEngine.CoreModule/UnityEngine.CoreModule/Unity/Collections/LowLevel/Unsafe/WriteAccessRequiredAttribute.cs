using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004E RID: 78
	public class WriteAccessRequiredAttribute : Attribute
	{
		// Token: 0x0600028D RID: 653 RVA: 0x00003578 File Offset: 0x00001778
		// Note: this type is marked as 'beforefieldinit'.
		static WriteAccessRequiredAttribute()
		{
			Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "WriteAccessRequiredAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr);
			WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr, 100663520);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteAccessRequiredAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000035B1 File Offset: 0x000017B1
		public WriteAccessRequiredAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000015 RID: 21
	public class UnmarshalledAttribute : Attribute
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002570 File Offset: 0x00000770
		// Note: this type is marked as 'beforefieldinit'.
		static UnmarshalledAttribute()
		{
			Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "UnmarshalledAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr);
			UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003FD0 File Offset: 0x000021D0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmarshalledAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000025A9 File Offset: 0x000007A9
		public UnmarshalledAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

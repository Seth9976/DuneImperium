using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000012 RID: 18
	public class NativeAsStructAttribute : Attribute
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00002484 File Offset: 0x00000684
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAsStructAttribute()
		{
			Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeAsStructAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr);
			NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr, 100663334);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003B0C File Offset: 0x00001D0C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeAsStructAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024BD File Offset: 0x000006BD
		public NativeAsStructAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

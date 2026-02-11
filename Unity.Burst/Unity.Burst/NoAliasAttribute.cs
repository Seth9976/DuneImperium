using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000015 RID: 21
	public class NoAliasAttribute : Attribute
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00002C1E File Offset: 0x00000E1E
		// Note: this type is marked as 'beforefieldinit'.
		static NoAliasAttribute()
		{
			Il2CppClassPointerStore<NoAliasAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "NoAliasAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAliasAttribute>.NativeClassPtr);
			NoAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAliasAttribute>.NativeClassPtr, 100663514);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009204 File Offset: 0x00007404
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoAliasAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoAliasAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002C57 File Offset: 0x00000E57
		public NoAliasAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

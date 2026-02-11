using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000049 RID: 73
	public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00003456 File Offset: 0x00001656
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsMinMaxWriteRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsMinMaxWriteRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr);
			NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr, 100663517);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001CF08 File Offset: 0x0001B108
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsMinMaxWriteRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000348F File Offset: 0x0000168F
		public NativeContainerSupportsMinMaxWriteRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000046 RID: 70
	public sealed class NativeContainerAttribute : Attribute
	{
		// Token: 0x06000278 RID: 632 RVA: 0x000033A4 File Offset: 0x000015A4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerAttribute()
		{
			Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr);
			NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr, 100663515);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001CE90 File Offset: 0x0001B090
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000033DD File Offset: 0x000015DD
		public NativeContainerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

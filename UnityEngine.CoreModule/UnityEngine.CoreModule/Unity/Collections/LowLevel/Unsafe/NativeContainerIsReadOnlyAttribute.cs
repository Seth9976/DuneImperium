using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000047 RID: 71
	public sealed class NativeContainerIsReadOnlyAttribute : Attribute
	{
		// Token: 0x0600027B RID: 635 RVA: 0x000033E6 File Offset: 0x000015E6
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerIsReadOnlyAttribute()
		{
			Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerIsReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr);
			NativeContainerIsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr, 100663516);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001CECC File Offset: 0x0001B0CC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerIsReadOnlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerIsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000341F File Offset: 0x0000161F
		public NativeContainerIsReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

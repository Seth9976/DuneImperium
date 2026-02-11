using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x0200005E RID: 94
	public sealed class PureAttribute : Attribute
	{
		// Token: 0x06000311 RID: 785 RVA: 0x00003961 File Offset: 0x00001B61
		// Note: this type is marked as 'beforefieldinit'.
		static PureAttribute()
		{
			Il2CppClassPointerStore<PureAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "PureAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr);
			PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr, 100663585);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001EB60 File Offset: 0x0001CD60
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PureAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000399A File Offset: 0x00001B9A
		public PureAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000026 RID: 38
	public class NotKeyableAttribute : Attribute
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002906 File Offset: 0x00000B06
		// Note: this type is marked as 'beforefieldinit'.
		static NotKeyableAttribute()
		{
			Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "NotKeyableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr);
			NotKeyableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr, 100663731);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000FC70 File Offset: 0x0000DE70
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotKeyableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotKeyableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000293F File Offset: 0x00000B3F
		public NotKeyableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

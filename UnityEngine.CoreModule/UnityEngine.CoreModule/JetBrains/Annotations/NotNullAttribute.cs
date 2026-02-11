using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x02000059 RID: 89
	public sealed class NotNullAttribute : Attribute
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00003881 File Offset: 0x00001A81
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "NotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr);
			NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663580);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001E85C File Offset: 0x0001CA5C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000038BA File Offset: 0x00001ABA
		public NotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

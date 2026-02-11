using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x02000058 RID: 88
	public sealed class CanBeNullAttribute : Attribute
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x0000383F File Offset: 0x00001A3F
		// Note: this type is marked as 'beforefieldinit'.
		static CanBeNullAttribute()
		{
			Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CanBeNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr);
			CanBeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr, 100663579);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001E820 File Offset: 0x0001CA20
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanBeNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanBeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003878 File Offset: 0x00001A78
		public CanBeNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

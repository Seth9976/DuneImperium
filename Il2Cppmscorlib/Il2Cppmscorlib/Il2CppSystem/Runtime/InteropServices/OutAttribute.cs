using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200038F RID: 911
	public sealed class OutAttribute : Attribute
	{
		// Token: 0x060037C1 RID: 14273 RVA: 0x000146AF File Offset: 0x000128AF
		// Note: this type is marked as 'beforefieldinit'.
		static OutAttribute()
		{
			Il2CppClassPointerStore<OutAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OutAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr);
			OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr, 100671638);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x001104E8 File Offset: 0x0010E6E8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x000146E8 File Offset: 0x000128E8
		public OutAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

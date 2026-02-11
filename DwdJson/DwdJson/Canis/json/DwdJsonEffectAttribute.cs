using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.json
{
	// Token: 0x0200000D RID: 13
	public class DwdJsonEffectAttribute : DwdJsonMessageAttribute
	{
		// Token: 0x06000064 RID: 100 RVA: 0x000022B0 File Offset: 0x000004B0
		// Note: this type is marked as 'beforefieldinit'.
		static DwdJsonEffectAttribute()
		{
			Il2CppClassPointerStore<DwdJsonEffectAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdJsonEffectAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonEffectAttribute>.NativeClassPtr);
			DwdJsonEffectAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonEffectAttribute>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003EC4 File Offset: 0x000020C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248501, XrefRangeEnd = 1248502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonEffectAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonEffectAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonEffectAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022E9 File Offset: 0x000004E9
		public DwdJsonEffectAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

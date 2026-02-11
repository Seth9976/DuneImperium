using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200006C RID: 108
	public class PreserveAttribute : Attribute
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00005D81 File Offset: 0x00003F81
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100664660);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002BF50 File Offset: 0x0002A150
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00005DBA File Offset: 0x00003FBA
		public PreserveAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

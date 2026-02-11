using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.Events
{
	// Token: 0x020000C3 RID: 195
	[Serializable]
	public class UnityEventString : UnityEvent<string>
	{
		// Token: 0x06000A6D RID: 2669 RVA: 0x00006550 File Offset: 0x00004750
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventString()
		{
			Il2CppClassPointerStore<UnityEventString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Events", "UnityEventString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr);
			UnityEventString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0003093C File Offset: 0x0002EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078753, XrefRangeEnd = 1078756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00006589 File Offset: 0x00004789
		public UnityEventString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

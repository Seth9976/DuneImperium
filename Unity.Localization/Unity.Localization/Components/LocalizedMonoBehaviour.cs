using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000C9 RID: 201
	public class LocalizedMonoBehaviour : MonoBehaviour
	{
		// Token: 0x06000A94 RID: 2708 RVA: 0x0000666F File Offset: 0x0000486F
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedMonoBehaviour()
		{
			Il2CppClassPointerStore<LocalizedMonoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizedMonoBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedMonoBehaviour>.NativeClassPtr);
			LocalizedMonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedMonoBehaviour>.NativeClassPtr, 100665066);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0003138C File Offset: 0x0002F58C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedMonoBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedMonoBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedMonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000066A8 File Offset: 0x000048A8
		public LocalizedMonoBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.Events
{
	// Token: 0x020000C1 RID: 193
	[Serializable]
	public class UnityEventGameObject : UnityEvent<GameObject>
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x000064CC File Offset: 0x000046CC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventGameObject()
		{
			Il2CppClassPointerStore<UnityEventGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Events", "UnityEventGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventGameObject>.NativeClassPtr);
			UnityEventGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventGameObject>.NativeClassPtr, 100665045);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000308C4 File Offset: 0x0002EAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078747, XrefRangeEnd = 1078750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventGameObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00006505 File Offset: 0x00004705
		public UnityEventGameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

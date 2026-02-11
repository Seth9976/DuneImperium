using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.notifications
{
	// Token: 0x02000111 RID: 273
	public class PushNotificationResponder : MonoBehaviour
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x00008B5E File Offset: 0x00006D5E
		// Note: this type is marked as 'beforefieldinit'.
		static PushNotificationResponder()
		{
			Il2CppClassPointerStore<PushNotificationResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications", "PushNotificationResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PushNotificationResponder>.NativeClassPtr);
			PushNotificationResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PushNotificationResponder>.NativeClassPtr, 100665348);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003CB58 File Offset: 0x0003AD58
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PushNotificationResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PushNotificationResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PushNotificationResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00008B97 File Offset: 0x00006D97
		public PushNotificationResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

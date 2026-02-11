using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x0200007E RID: 126
	[Serializable]
	public class OnPositionRequestedEvent : UnityEvent<UnitView, UnitPosition>
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x00005AF4 File Offset: 0x00003CF4
		// Note: this type is marked as 'beforefieldinit'.
		static OnPositionRequestedEvent()
		{
			Il2CppClassPointerStore<OnPositionRequestedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "OnPositionRequestedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnPositionRequestedEvent>.NativeClassPtr);
			OnPositionRequestedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPositionRequestedEvent>.NativeClassPtr, 100664295);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00021EF8 File Offset: 0x000200F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114297, XrefRangeEnd = 1114300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPositionRequestedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPositionRequestedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnPositionRequestedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00005B2D File Offset: 0x00003D2D
		public OnPositionRequestedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B1 RID: 177
	public class GetObserverList : NetworkMessageEvent
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00005AA3 File Offset: 0x00003CA3
		// Note: this type is marked as 'beforefieldinit'.
		static GetObserverList()
		{
			Il2CppClassPointerStore<GetObserverList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "GetObserverList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetObserverList>.NativeClassPtr);
			GetObserverList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetObserverList>.NativeClassPtr, 100663660);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00015868 File Offset: 0x00013A68
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetObserverList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetObserverList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetObserverList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00005ADC File Offset: 0x00003CDC
		public GetObserverList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

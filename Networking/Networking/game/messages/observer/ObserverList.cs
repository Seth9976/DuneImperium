using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B5 RID: 181
	public class ObserverList : NetworkMessageEvent
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00015AF0 File Offset: 0x00013CF0
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverList()
		{
			Il2CppClassPointerStore<ObserverList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "ObserverList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverList>.NativeClassPtr);
			ObserverList.NativeFieldInfoPtr_Observers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverList>.NativeClassPtr, "Observers");
			ObserverList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverList>.NativeClassPtr, 100663664);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00015B48 File Offset: 0x00013D48
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public ObserverList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00015B84 File Offset: 0x00013D84
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00005BBE File Offset: 0x00003DBE
		public unsafe Dictionary<AccountID, List<AccountIDUsernameMetadata>> Observers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverList.NativeFieldInfoPtr_Observers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, List<AccountIDUsernameMetadata>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverList.NativeFieldInfoPtr_Observers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_Observers;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

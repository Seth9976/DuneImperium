using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B4 RID: 180
	public class ObserverLeft : NetworkMessageEvent
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x000159E8 File Offset: 0x00013BE8
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverLeft()
		{
			Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "ObserverLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr);
			ObserverLeft.NativeFieldInfoPtr_Observer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr, "Observer");
			ObserverLeft.NativeFieldInfoPtr_ObservedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr, "ObservedPlayer");
			ObserverLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr, 100663663);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00015A54 File Offset: 0x00013C54
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00005B6E File Offset: 0x00003D6E
		public ObserverLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00015A90 File Offset: 0x00013C90
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00005B77 File Offset: 0x00003D77
		public unsafe AccountIDUsernameMetadata Observer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverLeft.NativeFieldInfoPtr_Observer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverLeft.NativeFieldInfoPtr_Observer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00015AC0 File Offset: 0x00013CC0
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00005B96 File Offset: 0x00003D96
		public unsafe AccountID ObservedPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverLeft.NativeFieldInfoPtr_ObservedPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverLeft.NativeFieldInfoPtr_ObservedPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_Observer;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_ObservedPlayer;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

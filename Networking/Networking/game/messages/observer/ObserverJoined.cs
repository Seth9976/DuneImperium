using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.game.messages.observer
{
	// Token: 0x020000B2 RID: 178
	public class ObserverJoined : NetworkMessageEvent
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x000158A4 File Offset: 0x00013AA4
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverJoined()
		{
			Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.observer", "ObserverJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr);
			ObserverJoined.NativeFieldInfoPtr_Observer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr, "Observer");
			ObserverJoined.NativeFieldInfoPtr_ObservedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr, "ObservedPlayer");
			ObserverJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr, 100663661);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00015910 File Offset: 0x00013B10
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00005AE5 File Offset: 0x00003CE5
		public ObserverJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001594C File Offset: 0x00013B4C
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00005AEE File Offset: 0x00003CEE
		public unsafe AccountIDUsernameMetadata Observer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverJoined.NativeFieldInfoPtr_Observer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverJoined.NativeFieldInfoPtr_Observer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001597C File Offset: 0x00013B7C
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00005B0D File Offset: 0x00003D0D
		public unsafe AccountID ObservedPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverJoined.NativeFieldInfoPtr_ObservedPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverJoined.NativeFieldInfoPtr_ObservedPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_Observer;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_ObservedPlayer;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

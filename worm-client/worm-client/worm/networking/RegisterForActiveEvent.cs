using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking
{
	// Token: 0x02000064 RID: 100
	public class RegisterForActiveEvent : NetworkMessageEvent
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00024F10 File Offset: 0x00023110
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterForActiveEvent()
		{
			Il2CppClassPointerStore<RegisterForActiveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "RegisterForActiveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterForActiveEvent>.NativeClassPtr);
			RegisterForActiveEvent.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForActiveEvent>.NativeClassPtr, "eventID");
			RegisterForActiveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForActiveEvent>.NativeClassPtr, 100663921);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00024F68 File Offset: 0x00023168
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterForActiveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterForActiveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForActiveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003B41 File Offset: 0x00001D41
		public RegisterForActiveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00024FA4 File Offset: 0x000231A4
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003B4A File Offset: 0x00001D4A
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForActiveEvent.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForActiveEvent.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking
{
	// Token: 0x02000065 RID: 101
	public class ResignEvent : NetworkMessageEvent
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x00024FD4 File Offset: 0x000231D4
		// Note: this type is marked as 'beforefieldinit'.
		static ResignEvent()
		{
			Il2CppClassPointerStore<ResignEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "ResignEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignEvent>.NativeClassPtr);
			ResignEvent.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignEvent>.NativeClassPtr, "eventID");
			ResignEvent.NativeFieldInfoPtr_entryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignEvent>.NativeClassPtr, "entryID");
			ResignEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignEvent>.NativeClassPtr, 100663922);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00025040 File Offset: 0x00023240
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResignEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003B69 File Offset: 0x00001D69
		public ResignEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0002507C File Offset: 0x0002327C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003B72 File Offset: 0x00001D72
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignEvent.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignEvent.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000250AC File Offset: 0x000232AC
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003B91 File Offset: 0x00001D91
		public unsafe EntryID entryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignEvent.NativeFieldInfoPtr_entryID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntryID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignEvent.NativeFieldInfoPtr_entryID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_entryID;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x0200006A RID: 106
	public class EventEntryData : Object
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00025890 File Offset: 0x00023A90
		// Note: this type is marked as 'beforefieldinit'.
		static EventEntryData()
		{
			Il2CppClassPointerStore<EventEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntryData>.NativeClassPtr);
			EventEntryData.NativeFieldInfoPtr_maxJoins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryData>.NativeClassPtr, "maxJoins");
			EventEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntryData>.NativeClassPtr, 100663938);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000258E8 File Offset: 0x00023AE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntryData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003E00 File Offset: 0x00002000
		public EventEntryData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00025924 File Offset: 0x00023B24
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003E09 File Offset: 0x00002009
		public unsafe int maxJoins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryData.NativeFieldInfoPtr_maxJoins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryData.NativeFieldInfoPtr_maxJoins)) = value;
			}
		}

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_maxJoins;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

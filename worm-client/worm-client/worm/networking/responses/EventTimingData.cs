using System;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x02000069 RID: 105
	public class EventTimingData : Object
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x00025700 File Offset: 0x00023900
		// Note: this type is marked as 'beforefieldinit'.
		static EventTimingData()
		{
			Il2CppClassPointerStore<EventTimingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventTimingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr);
			EventTimingData.NativeFieldInfoPtr_visibilityStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr, "visibilityStartTime");
			EventTimingData.NativeFieldInfoPtr_registrationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr, "registrationStartTime");
			EventTimingData.NativeFieldInfoPtr_registrationEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr, "registrationEndTime");
			EventTimingData.NativeFieldInfoPtr_visibilityEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr, "visibilityEndTime");
			EventTimingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr, 100663937);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00025794 File Offset: 0x00023994
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventTimingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTimingData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTimingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003D3F File Offset: 0x00001F3F
		public EventTimingData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000257D0 File Offset: 0x000239D0
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00003D48 File Offset: 0x00001F48
		public WargTime visibilityStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_visibilityStartTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_visibilityStartTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00025800 File Offset: 0x00023A00
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00003D76 File Offset: 0x00001F76
		public Nullable<WargTime> registrationStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_registrationStartTime);
				return new Nullable<WargTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WargTime>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_registrationStartTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WargTime>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00025830 File Offset: 0x00023A30
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public Nullable<WargTime> registrationEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_registrationEndTime);
				return new Nullable<WargTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WargTime>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_registrationEndTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WargTime>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00025860 File Offset: 0x00023A60
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00003DD2 File Offset: 0x00001FD2
		public WargTime visibilityEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_visibilityEndTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTimingData.NativeFieldInfoPtr_visibilityEndTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_visibilityStartTime;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_registrationStartTime;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_registrationEndTime;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_visibilityEndTime;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

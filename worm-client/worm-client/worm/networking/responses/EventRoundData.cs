using System;
using Canis.utils.ids;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x0200006B RID: 107
	public class EventRoundData : Object
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0002594C File Offset: 0x00023B4C
		// Note: this type is marked as 'beforefieldinit'.
		static EventRoundData()
		{
			Il2CppClassPointerStore<EventRoundData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventRoundData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr);
			EventRoundData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "id");
			EventRoundData.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "startTime");
			EventRoundData.NativeFieldInfoPtr_gameLastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "gameLastStartTime");
			EventRoundData.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "endTime");
			EventRoundData.NativeFieldInfoPtr_allowLateJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "allowLateJoin");
			EventRoundData.NativeFieldInfoPtr_descriptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "descriptionData");
			EventRoundData.NativeFieldInfoPtr_roundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "roundNumber");
			EventRoundData.NativeFieldInfoPtr_queueData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, "queueData");
			EventRoundData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr, 100663939);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00025A30 File Offset: 0x00023C30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventRoundData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoundData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventRoundData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003E24 File Offset: 0x00002024
		public EventRoundData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00025A6C File Offset: 0x00023C6C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00003E2D File Offset: 0x0000202D
		public unsafe RoundID id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00025A9C File Offset: 0x00023C9C
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003E4C File Offset: 0x0000204C
		public WargTime startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_startTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_startTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00025ACC File Offset: 0x00023CCC
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00003E7A File Offset: 0x0000207A
		public WargTime gameLastStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_gameLastStartTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_gameLastStartTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00025AFC File Offset: 0x00023CFC
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00003EA8 File Offset: 0x000020A8
		public WargTime endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_endTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_endTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00025B2C File Offset: 0x00023D2C
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00003ED6 File Offset: 0x000020D6
		public unsafe bool allowLateJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_allowLateJoin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_allowLateJoin)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00025B54 File Offset: 0x00023D54
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00003EF1 File Offset: 0x000020F1
		public unsafe EventDescriptionData descriptionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_descriptionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDescriptionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_descriptionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00025B84 File Offset: 0x00023D84
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00003F10 File Offset: 0x00002110
		public unsafe int roundNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_roundNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_roundNumber)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00025BAC File Offset: 0x00023DAC
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00003F2B File Offset: 0x0000212B
		public unsafe EventRoundQueueData queueData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_queueData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventRoundQueueData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundData.NativeFieldInfoPtr_queueData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_gameLastStartTime;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_allowLateJoin;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_descriptionData;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_roundNumber;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_queueData;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

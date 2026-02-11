using System;
using Canis.json.events;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000010 RID: 16
	public class UpdateRankedQueueInfo : NetworkMessageEvent
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00004694 File Offset: 0x00002894
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateRankedQueueInfo()
		{
			Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "UpdateRankedQueueInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr);
			UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueNextStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr, "QueueNextStart");
			UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueOpens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr, "QueueOpens");
			UpdateRankedQueueInfo.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr, "ServerTime");
			UpdateRankedQueueInfo.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr, "Definition");
			UpdateRankedQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004728 File Offset: 0x00002928
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateRankedQueueInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateRankedQueueInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateRankedQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000023AB File Offset: 0x000005AB
		public UpdateRankedQueueInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004764 File Offset: 0x00002964
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000023B4 File Offset: 0x000005B4
		public WargTime QueueNextStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueNextStart);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueNextStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004794 File Offset: 0x00002994
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000023E2 File Offset: 0x000005E2
		public WargTime QueueOpens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueOpens);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_QueueOpens), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000047C4 File Offset: 0x000029C4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002410 File Offset: 0x00000610
		public WargTime ServerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_ServerTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000047F4 File Offset: 0x000029F4
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe RankedSeasonDefinition Definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_Definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedSeasonDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateRankedQueueInfo.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_QueueNextStart;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_QueueOpens;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_ServerTime;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

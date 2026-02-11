using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x0200006C RID: 108
	public class EventRoundQueueData : Object
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00025BDC File Offset: 0x00023DDC
		// Note: this type is marked as 'beforefieldinit'.
		static EventRoundQueueData()
		{
			Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventRoundQueueData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr);
			EventRoundQueueData.NativeFieldInfoPtr_minPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, "minPlayers");
			EventRoundQueueData.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, "maxPlayers");
			EventRoundQueueData.NativeFieldInfoPtr_maxWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, "maxWins");
			EventRoundQueueData.NativeFieldInfoPtr_maxLosses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, "maxLosses");
			EventRoundQueueData.NativeFieldInfoPtr_maxGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, "maxGames");
			EventRoundQueueData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr, 100663940);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00025C84 File Offset: 0x00023E84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventRoundQueueData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoundQueueData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventRoundQueueData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00003F4A File Offset: 0x0000214A
		public EventRoundQueueData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00025CC0 File Offset: 0x00023EC0
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003F53 File Offset: 0x00002153
		public unsafe int minPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_minPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_minPlayers)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00025CE8 File Offset: 0x00023EE8
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003F6E File Offset: 0x0000216E
		public unsafe int maxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxPlayers)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00025D10 File Offset: 0x00023F10
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003F89 File Offset: 0x00002189
		public Nullable<int> maxWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxWins);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxWins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00025D40 File Offset: 0x00023F40
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003FB7 File Offset: 0x000021B7
		public Nullable<int> maxLosses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxLosses);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxLosses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00025D70 File Offset: 0x00023F70
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00003FE5 File Offset: 0x000021E5
		public Nullable<int> maxGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxGames);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventRoundQueueData.NativeFieldInfoPtr_maxGames), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_minPlayers;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_maxPlayers;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_maxWins;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_maxLosses;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_maxGames;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

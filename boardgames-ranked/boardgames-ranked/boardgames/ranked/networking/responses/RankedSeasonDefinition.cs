using System;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000011 RID: 17
	public class RankedSeasonDefinition : Object
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00004824 File Offset: 0x00002A24
		// Note: this type is marked as 'beforefieldinit'.
		static RankedSeasonDefinition()
		{
			Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedSeasonDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr);
			RankedSeasonDefinition.NativeFieldInfoPtr_QueueOpenLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "QueueOpenLength");
			RankedSeasonDefinition.NativeFieldInfoPtr_SeasonId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "SeasonId");
			RankedSeasonDefinition.NativeFieldInfoPtr_RotateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "RotateTime");
			RankedSeasonDefinition.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "Options");
			RankedSeasonDefinition.NativeFieldInfoPtr_SeasonDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "SeasonDuration");
			RankedSeasonDefinition.NativeFieldInfoPtr_QueueNextStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, "QueueNextStart");
			RankedSeasonDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000048E0 File Offset: 0x00002AE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedSeasonDefinition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedSeasonDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSeasonDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000245D File Offset: 0x0000065D
		public RankedSeasonDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000491C File Offset: 0x00002B1C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002466 File Offset: 0x00000666
		public unsafe int QueueOpenLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_QueueOpenLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_QueueOpenLength)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004944 File Offset: 0x00002B44
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002481 File Offset: 0x00000681
		public unsafe int SeasonId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_SeasonId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_SeasonId)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000496C File Offset: 0x00002B6C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000249C File Offset: 0x0000069C
		public WargTime RotateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_RotateTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_RotateTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000024CA File Offset: 0x000006CA
		public unsafe Dictionary<string, string> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000049CC File Offset: 0x00002BCC
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000024E9 File Offset: 0x000006E9
		public unsafe long SeasonDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_SeasonDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_SeasonDuration)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000049F4 File Offset: 0x00002BF4
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002504 File Offset: 0x00000704
		public unsafe string QueueNextStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_QueueNextStart);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonDefinition.NativeFieldInfoPtr_QueueNextStart), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_QueueOpenLength;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_SeasonId;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_RotateTime;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_SeasonDuration;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_QueueNextStart;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

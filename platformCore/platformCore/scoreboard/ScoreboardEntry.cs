using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace platformCore.scoreboard
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class ScoreboardEntry : Object
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00004464 File Offset: 0x00002664
		// Note: this type is marked as 'beforefieldinit'.
		static ScoreboardEntry()
		{
			Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.scoreboard", "ScoreboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr);
			ScoreboardEntry.NativeFieldInfoPtr_screenname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr, "screenname");
			ScoreboardEntry.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr, "score");
			ScoreboardEntry.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr, "rank");
			ScoreboardEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr, 100663351);
			ScoreboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000044F8 File Offset: 0x000026F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250118, XrefRangeEnd = 1250126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScoreboardEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000453C File Offset: 0x0000273C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScoreboardEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScoreboardEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScoreboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002421 File Offset: 0x00000621
		public ScoreboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000242A File Offset: 0x0000062A
		public unsafe string screenname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_screenname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_screenname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000045A0 File Offset: 0x000027A0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002449 File Offset: 0x00000649
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000045C8 File Offset: 0x000027C8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002464 File Offset: 0x00000664
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScoreboardEntry.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_screenname;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace platformCore.scoreboard
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class Scoreboard : Object
	{
		// Token: 0x0600006E RID: 110 RVA: 0x000045F0 File Offset: 0x000027F0
		// Note: this type is marked as 'beforefieldinit'.
		static Scoreboard()
		{
			Il2CppClassPointerStore<Scoreboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.scoreboard", "Scoreboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr);
			Scoreboard.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr, "game");
			Scoreboard.NativeFieldInfoPtr_scores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr, "scores");
			Scoreboard.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr, 100663353);
			Scoreboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr, 100663354);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004670 File Offset: 0x00002870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250126, XrefRangeEnd = 1250137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scoreboard.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000046B4 File Offset: 0x000028B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scoreboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scoreboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scoreboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000247F File Offset: 0x0000067F
		public Scoreboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000046F0 File Offset: 0x000028F0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002488 File Offset: 0x00000688
		public unsafe string game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scoreboard.NativeFieldInfoPtr_game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scoreboard.NativeFieldInfoPtr_game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004718 File Offset: 0x00002918
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000024A7 File Offset: 0x000006A7
		public unsafe Il2CppReferenceArray<ScoreboardEntry> scores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scoreboard.NativeFieldInfoPtr_scores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScoreboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scoreboard.NativeFieldInfoPtr_scores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_game;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_scores;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

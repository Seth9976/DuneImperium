using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace offlineChallenges.NetworkCommands
{
	// Token: 0x0200000B RID: 11
	public class SyncChallenges : Object
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00004DB8 File Offset: 0x00002FB8
		// Note: this type is marked as 'beforefieldinit'.
		static SyncChallenges()
		{
			Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.NetworkCommands", "SyncChallenges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr);
			SyncChallenges.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr, "progress");
			SyncChallenges.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr, "Level");
			SyncChallenges.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr, 100663404);
			SyncChallenges.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr, 100663405);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004E38 File Offset: 0x00003038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1261168, RefRangeEnd = 1261170, XrefRangeStart = 1261132, XrefRangeEnd = 1261168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyncChallenges(Dictionary<int, int> progressDict, int level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progressDict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncChallenges.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004E94 File Offset: 0x00003094
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyncChallenges()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncChallenges>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncChallenges.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000023D1 File Offset: 0x000005D1
		public SyncChallenges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004ED0 File Offset: 0x000030D0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000023DA File Offset: 0x000005DA
		public unsafe List<SyncChallengeData> progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallenges.NativeFieldInfoPtr_progress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SyncChallengeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallenges.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004F00 File Offset: 0x00003100
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023F9 File Offset: 0x000005F9
		public unsafe int Level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallenges.NativeFieldInfoPtr_Level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallenges.NativeFieldInfoPtr_Level)) = value;
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_Level;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

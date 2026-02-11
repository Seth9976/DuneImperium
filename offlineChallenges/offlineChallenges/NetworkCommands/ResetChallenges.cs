using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace offlineChallenges.NetworkCommands
{
	// Token: 0x0200000A RID: 10
	public class ResetChallenges : Object
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00004C98 File Offset: 0x00002E98
		// Note: this type is marked as 'beforefieldinit'.
		static ResetChallenges()
		{
			Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.NetworkCommands", "ResetChallenges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr);
			ResetChallenges.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr, "progress");
			ResetChallenges.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr, "Level");
			ResetChallenges.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr, 100663403);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004D04 File Offset: 0x00002F04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetChallenges(Dictionary<int, int> progress, int level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetChallenges>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetChallenges.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000238E File Offset: 0x0000058E
		public ResetChallenges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004D60 File Offset: 0x00002F60
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002397 File Offset: 0x00000597
		public unsafe Dictionary<int, int> progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetChallenges.NativeFieldInfoPtr_progress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetChallenges.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004D90 File Offset: 0x00002F90
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000023B6 File Offset: 0x000005B6
		public unsafe int Level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetChallenges.NativeFieldInfoPtr_Level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetChallenges.NativeFieldInfoPtr_Level)) = value;
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_Level;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace offlineChallenges
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class ChallengeModel : Object
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00004B28 File Offset: 0x00002D28
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeModel()
		{
			Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges", "ChallengeModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr);
			ChallengeModel.NativeFieldInfoPtr_ChallengeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr, "ChallengeID");
			ChallengeModel.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr, "Progress");
			ChallengeModel.NativeFieldInfoPtr_LastCheckedProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr, "LastCheckedProgress");
			ChallengeModel.NativeFieldInfoPtr_LastSyncedProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr, "LastSyncedProgress");
			ChallengeModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr, 100663402);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004BBC File Offset: 0x00002DBC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002319 File Offset: 0x00000519
		public ChallengeModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004BF8 File Offset: 0x00002DF8
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002322 File Offset: 0x00000522
		public unsafe int ChallengeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_ChallengeID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_ChallengeID)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004C20 File Offset: 0x00002E20
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000233D File Offset: 0x0000053D
		public unsafe int Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_Progress)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004C48 File Offset: 0x00002E48
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002358 File Offset: 0x00000558
		public unsafe int LastCheckedProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_LastCheckedProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_LastCheckedProgress)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004C70 File Offset: 0x00002E70
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe int LastSyncedProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_LastSyncedProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeModel.NativeFieldInfoPtr_LastSyncedProgress)) = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeID;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_LastCheckedProgress;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_LastSyncedProgress;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

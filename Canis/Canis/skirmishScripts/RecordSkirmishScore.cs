using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x02000048 RID: 72
	public class RecordSkirmishScore : NetworkMessageEvent
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x0002B518 File Offset: 0x00029718
		// Note: this type is marked as 'beforefieldinit'.
		static RecordSkirmishScore()
		{
			Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "RecordSkirmishScore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr);
			RecordSkirmishScore.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "AccountID");
			RecordSkirmishScore.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "ScreenName");
			RecordSkirmishScore.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "Score");
			RecordSkirmishScore.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "Timestamp");
			RecordSkirmishScore.NativeFieldInfoPtr_StageVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "StageVariables");
			RecordSkirmishScore.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "Client");
			RecordSkirmishScore.NativeFieldInfoPtr_GameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "GameKey");
			RecordSkirmishScore.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, "GameID");
			RecordSkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr, 100664240);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0002B5FC File Offset: 0x000297FC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordSkirmishScore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordSkirmishScore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordSkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00003EC5 File Offset: 0x000020C5
		public RecordSkirmishScore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0002B638 File Offset: 0x00029838
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003ECE File Offset: 0x000020CE
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0002B668 File Offset: 0x00029868
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003EED File Offset: 0x000020ED
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002B690 File Offset: 0x00029890
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00003F0C File Offset: 0x0000210C
		public unsafe int Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002B6B8 File Offset: 0x000298B8
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003F27 File Offset: 0x00002127
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002B6E0 File Offset: 0x000298E0
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003F42 File Offset: 0x00002142
		public unsafe Dictionary<string, string> StageVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_StageVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_StageVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002B710 File Offset: 0x00029910
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003F61 File Offset: 0x00002161
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002B738 File Offset: 0x00029938
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003F80 File Offset: 0x00002180
		public unsafe int GameKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_GameKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_GameKey)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0002B760 File Offset: 0x00029960
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00003F9B File Offset: 0x0000219B
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordSkirmishScore.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_StageVariables;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_GameKey;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

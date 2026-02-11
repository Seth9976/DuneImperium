using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000C6 RID: 198
	public class ChallengeHighScoreData : DataComponent
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0003809C File Offset: 0x0003629C
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeHighScoreData()
		{
			Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "ChallengeHighScoreData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr);
			ChallengeHighScoreData.NativeFieldInfoPtr__Score_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr, "<Score>k__BackingField");
			ChallengeHighScoreData.NativeMethodInfoPtr_get_Score_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr, 100664543);
			ChallengeHighScoreData.NativeMethodInfoPtr_set_Score_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr, 100664544);
			ChallengeHighScoreData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr, 100664545);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0003811C File Offset: 0x0003631C
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00038158 File Offset: 0x00036358
		public unsafe int Score
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeHighScoreData.NativeMethodInfoPtr_get_Score_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeHighScoreData.NativeMethodInfoPtr_set_Score_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00038198 File Offset: 0x00036398
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 504768, RefRangeEnd = 504775, XrefRangeStart = 504767, XrefRangeEnd = 504768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeHighScoreData(int score)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeHighScoreData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref score;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeHighScoreData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00005E62 File Offset: 0x00004062
		public ChallengeHighScoreData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000381E0 File Offset: 0x000363E0
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00005E6B File Offset: 0x0000406B
		public unsafe int _Score_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreData.NativeFieldInfoPtr__Score_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreData.NativeFieldInfoPtr__Score_k__BackingField)) = value;
			}
		}

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr__Score_k__BackingField;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_get_Score_Public_get_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_set_Score_Private_set_Void_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}

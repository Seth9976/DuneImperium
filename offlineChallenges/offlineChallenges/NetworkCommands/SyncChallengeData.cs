using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace offlineChallenges.NetworkCommands
{
	// Token: 0x0200000C RID: 12
	public class SyncChallengeData : Object
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00004F28 File Offset: 0x00003128
		// Note: this type is marked as 'beforefieldinit'.
		static SyncChallengeData()
		{
			Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.NetworkCommands", "SyncChallengeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr);
			SyncChallengeData.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr, "key");
			SyncChallengeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr, "value");
			SyncChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr, 100663406);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004F94 File Offset: 0x00003194
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyncChallengeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncChallengeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002414 File Offset: 0x00000614
		public SyncChallengeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004FD0 File Offset: 0x000031D0
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000241D File Offset: 0x0000061D
		public unsafe int key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallengeData.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallengeData.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002438 File Offset: 0x00000638
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallengeData.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncChallengeData.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

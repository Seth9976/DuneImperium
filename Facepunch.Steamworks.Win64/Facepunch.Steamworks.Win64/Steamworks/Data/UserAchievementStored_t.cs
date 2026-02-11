using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013F RID: 319
	public sealed class UserAchievementStored_t : ValueType
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x00062CA4 File Offset: 0x00060EA4
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementStored_t()
		{
			Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserAchievementStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr);
			UserAchievementStored_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "GameID");
			UserAchievementStored_t.NativeFieldInfoPtr_GroupAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "GroupAchievement");
			UserAchievementStored_t.NativeFieldInfoPtr_AchievementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "AchievementName");
			UserAchievementStored_t.NativeFieldInfoPtr_CurProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "CurProgress");
			UserAchievementStored_t.NativeFieldInfoPtr_MaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "MaxProgress");
			UserAchievementStored_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "_datasize");
			UserAchievementStored_t.NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, 100667025);
			UserAchievementStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, 100667026);
			UserAchievementStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, 100667027);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00062D88 File Offset: 0x00060F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950557, RefRangeEnd = 950558, XrefRangeStart = 950553, XrefRangeEnd = 950557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AchievementNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementStored_t.NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00062DC4 File Offset: 0x00060FC4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950558, XrefRangeEnd = 950562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00062E08 File Offset: 0x00061008
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0000531B File Offset: 0x0000351B
		public UserAchievementStored_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00005324 File Offset: 0x00003524
		public UserAchievementStored_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00062E4C File Offset: 0x0006104C
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x00005336 File Offset: 0x00003536
		public unsafe ulong GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_GameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_GameID)) = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00062E74 File Offset: 0x00061074
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00005351 File Offset: 0x00003551
		public unsafe bool GroupAchievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_GroupAchievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_GroupAchievement)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00062E9C File Offset: 0x0006109C
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000536C File Offset: 0x0000356C
		public unsafe Il2CppStructArray<byte> AchievementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_AchievementName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_AchievementName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00062ECC File Offset: 0x000610CC
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000538B File Offset: 0x0000358B
		public unsafe uint CurProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_CurProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_CurProgress)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00062EF4 File Offset: 0x000610F4
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x000053A6 File Offset: 0x000035A6
		public unsafe uint MaxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_MaxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_MaxProgress)) = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00062F1C File Offset: 0x0006111C
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x000053C1 File Offset: 0x000035C1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementStored_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementStored_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_GroupAchievement;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeFieldInfoPtr_AchievementName;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_CurProgress;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_MaxProgress;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

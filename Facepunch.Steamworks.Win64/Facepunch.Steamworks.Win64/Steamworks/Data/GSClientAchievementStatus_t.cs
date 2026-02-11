using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A8 RID: 424
	public sealed class GSClientAchievementStatus_t : ValueType
	{
		// Token: 0x060014F4 RID: 5364 RVA: 0x0006B7E8 File Offset: 0x000699E8
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientAchievementStatus_t()
		{
			Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSClientAchievementStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr);
			GSClientAchievementStatus_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "SteamID");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_PchAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "PchAchievement");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "Unlocked");
			GSClientAchievementStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "_datasize");
			GSClientAchievementStatus_t.NativeMethodInfoPtr_PchAchievementUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, 100667349);
			GSClientAchievementStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, 100667350);
			GSClientAchievementStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, 100667351);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0006B8A4 File Offset: 0x00069AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951016, XrefRangeEnd = 951020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PchAchievementUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientAchievementStatus_t.NativeMethodInfoPtr_PchAchievementUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0006B8E0 File Offset: 0x00069AE0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951020, XrefRangeEnd = 951024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientAchievementStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0006B924 File Offset: 0x00069B24
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientAchievementStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00006CFF File Offset: 0x00004EFF
		public GSClientAchievementStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00006D08 File Offset: 0x00004F08
		public GSClientAchievementStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0006B968 File Offset: 0x00069B68
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x00006D1A File Offset: 0x00004F1A
		public unsafe ulong SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_SteamID)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0006B990 File Offset: 0x00069B90
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00006D35 File Offset: 0x00004F35
		public unsafe Il2CppStructArray<byte> PchAchievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_PchAchievement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_PchAchievement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0006B9C0 File Offset: 0x00069BC0
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x00006D54 File Offset: 0x00004F54
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0006B9E8 File Offset: 0x00069BE8
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x00006D6F File Offset: 0x00004F6F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientAchievementStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientAchievementStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeFieldInfoPtr_PchAchievement;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_PchAchievementUTF8_Internal_String_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

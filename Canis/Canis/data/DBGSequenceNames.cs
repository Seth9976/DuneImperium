using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000154 RID: 340
	public static class DBGSequenceNames : Object
	{
		// Token: 0x06000EEF RID: 3823 RVA: 0x000581D8 File Offset: 0x000563D8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSequenceNames()
		{
			Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGSequenceNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr);
			DBGSequenceNames.NativeFieldInfoPtr_GameStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr, "GameStart");
			DBGSequenceNames.NativeFieldInfoPtr_PassToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr, "PassToPlayer");
			DBGSequenceNames.NativeFieldInfoPtr_OneTimeTutorialAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr, "OneTimeTutorialAction");
			DBGSequenceNames.NativeFieldInfoPtr_FlagOneTimeTutorialAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr, "FlagOneTimeTutorialAction");
			DBGSequenceNames.NativeFieldInfoPtr_UpdateObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequenceNames>.NativeClassPtr, "UpdateObjectives");
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000078A3 File Offset: 0x00005AA3
		public DBGSequenceNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0005826C File Offset: 0x0005646C
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000078AC File Offset: 0x00005AAC
		public unsafe static string GameStart
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGSequenceNames.NativeFieldInfoPtr_GameStart, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGSequenceNames.NativeFieldInfoPtr_GameStart, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0005828C File Offset: 0x0005648C
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000078BE File Offset: 0x00005ABE
		public unsafe static string PassToPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGSequenceNames.NativeFieldInfoPtr_PassToPlayer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGSequenceNames.NativeFieldInfoPtr_PassToPlayer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000582AC File Offset: 0x000564AC
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000078D0 File Offset: 0x00005AD0
		public unsafe static string OneTimeTutorialAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGSequenceNames.NativeFieldInfoPtr_OneTimeTutorialAction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGSequenceNames.NativeFieldInfoPtr_OneTimeTutorialAction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000582CC File Offset: 0x000564CC
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000078E2 File Offset: 0x00005AE2
		public unsafe static string FlagOneTimeTutorialAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGSequenceNames.NativeFieldInfoPtr_FlagOneTimeTutorialAction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGSequenceNames.NativeFieldInfoPtr_FlagOneTimeTutorialAction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000582EC File Offset: 0x000564EC
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000078F4 File Offset: 0x00005AF4
		public unsafe static string UpdateObjectives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGSequenceNames.NativeFieldInfoPtr_UpdateObjectives, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGSequenceNames.NativeFieldInfoPtr_UpdateObjectives, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_GameStart;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_PassToPlayer;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_OneTimeTutorialAction;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_FlagOneTimeTutorialAction;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_UpdateObjectives;
	}
}

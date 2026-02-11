using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000202 RID: 514
	[StructLayout(2)]
	public struct LeaderboardUpdate
	{
		// Token: 0x0600199D RID: 6557 RVA: 0x0007BCA0 File Offset: 0x00079EA0
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardUpdate()
		{
			Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr);
			LeaderboardUpdate.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, "Score");
			LeaderboardUpdate.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, "Changed");
			LeaderboardUpdate.NativeFieldInfoPtr_NewGlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, "NewGlobalRank");
			LeaderboardUpdate.NativeFieldInfoPtr_OldGlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, "OldGlobalRank");
			LeaderboardUpdate.NativeMethodInfoPtr_get_RankChange_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, 100667964);
			LeaderboardUpdate.NativeMethodInfoPtr_From_Internal_Static_LeaderboardUpdate_LeaderboardScoreUploaded_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, 100667965);
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0007BD48 File Offset: 0x00079F48
		public unsafe int RankChange
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardUpdate.NativeMethodInfoPtr_get_RankChange_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0007BD78 File Offset: 0x00079F78
		[CallerCount(0)]
		public unsafe static LeaderboardUpdate From(LeaderboardScoreUploaded_t e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref e;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardUpdate.NativeMethodInfoPtr_From_Internal_Static_LeaderboardUpdate_LeaderboardScoreUploaded_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000857E File Offset: 0x0000677E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeFieldInfoPtr_NewGlobalRank;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeFieldInfoPtr_OldGlobalRank;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_get_RankChange_Public_get_Int32_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_LeaderboardUpdate_LeaderboardScoreUploaded_t_0;

		// Token: 0x04001ED6 RID: 7894
		[FieldOffset(0)]
		public int Score;

		// Token: 0x04001ED7 RID: 7895
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool Changed;

		// Token: 0x04001ED8 RID: 7896
		[FieldOffset(8)]
		public int NewGlobalRank;

		// Token: 0x04001ED9 RID: 7897
		[FieldOffset(12)]
		public int OldGlobalRank;
	}
}

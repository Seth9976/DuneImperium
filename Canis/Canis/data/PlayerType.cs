using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000157 RID: 343
	[Serializable]
	public class PlayerType : Object
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x000586A0 File Offset: 0x000568A0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerType()
		{
			Il2CppClassPointerStore<PlayerType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "PlayerType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerType>.NativeClassPtr);
			PlayerType.NativeFieldInfoPtr_acctID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "acctID");
			PlayerType.NativeFieldInfoPtr_isAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "isAI");
			PlayerType.NativeFieldInfoPtr_clientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "clientPlatform");
			PlayerType.NativeFieldInfoPtr_clientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "clientVersion");
			PlayerType.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "score");
			PlayerType.NativeFieldInfoPtr_aiDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, "aiDifficulty");
			PlayerType.NativeMethodInfoPtr__ctor_Public_Void_AccountID_Boolean_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerType>.NativeClassPtr, 100666531);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0005875C File Offset: 0x0005695C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 577969, RefRangeEnd = 577971, XrefRangeStart = 577965, XrefRangeEnd = 577969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerType(AccountID acctID, bool isAI, string cPlat, string cVer, int score, int aiDifficulty)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acctID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAI;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cPlat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cVer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiDifficulty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerType.NativeMethodInfoPtr__ctor_Public_Void_AccountID_Boolean_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000079FA File Offset: 0x00005BFA
		public PlayerType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000587F8 File Offset: 0x000569F8
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00007A03 File Offset: 0x00005C03
		public unsafe AccountID acctID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_acctID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_acctID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00058828 File Offset: 0x00056A28
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00007A22 File Offset: 0x00005C22
		public unsafe bool isAI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_isAI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_isAI)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00058850 File Offset: 0x00056A50
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00007A3D File Offset: 0x00005C3D
		public unsafe string clientPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_clientPlatform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_clientPlatform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00058878 File Offset: 0x00056A78
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe string clientVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_clientVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_clientVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000588A0 File Offset: 0x00056AA0
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00007A7B File Offset: 0x00005C7B
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000588C8 File Offset: 0x00056AC8
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00007A96 File Offset: 0x00005C96
		public unsafe int aiDifficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_aiDifficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerType.NativeFieldInfoPtr_aiDifficulty)) = value;
			}
		}

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_acctID;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_isAI;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_clientPlatform;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_clientVersion;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_aiDifficulty;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_Boolean_String_String_Int32_Int32_0;
	}
}

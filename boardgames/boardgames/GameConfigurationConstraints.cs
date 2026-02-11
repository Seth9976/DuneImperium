using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000FE RID: 254
	public class GameConfigurationConstraints : MonoBehaviour
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x00037ADC File Offset: 0x00035CDC
		// Note: this type is marked as 'beforefieldinit'.
		static GameConfigurationConstraints()
		{
			Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "GameConfigurationConstraints");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr);
			GameConfigurationConstraints.NativeFieldInfoPtr_minHumanPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "minHumanPlayers");
			GameConfigurationConstraints.NativeFieldInfoPtr_minMatchPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "minMatchPlayers");
			GameConfigurationConstraints.NativeFieldInfoPtr_maxMatchPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "maxMatchPlayers");
			GameConfigurationConstraints.NativeFieldInfoPtr_offlineObfuscation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "offlineObfuscation");
			GameConfigurationConstraints.NativeFieldInfoPtr_onlineObfuscation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "onlineObfuscation");
			GameConfigurationConstraints.NativeFieldInfoPtr_RequiredFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, "RequiredFriend");
			GameConfigurationConstraints.NativeMethodInfoPtr_get_MinHumanPlayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665233);
			GameConfigurationConstraints.NativeMethodInfoPtr_get_MinMatchPlayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665234);
			GameConfigurationConstraints.NativeMethodInfoPtr_get_MaxMatchPlayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665235);
			GameConfigurationConstraints.NativeMethodInfoPtr_get_OfflineObfuscation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665236);
			GameConfigurationConstraints.NativeMethodInfoPtr_get_OnlineObfuscation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665237);
			GameConfigurationConstraints.NativeMethodInfoPtr_SetObfuscation_Public_Void_Nullable_1_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665238);
			GameConfigurationConstraints.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr, 100665239);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00037C10 File Offset: 0x00035E10
		public unsafe int MinHumanPlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_get_MinHumanPlayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00037C4C File Offset: 0x00035E4C
		public unsafe int MinMatchPlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_get_MinMatchPlayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00037C88 File Offset: 0x00035E88
		public unsafe int MaxMatchPlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_get_MaxMatchPlayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00037CC4 File Offset: 0x00035EC4
		public unsafe bool OfflineObfuscation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_get_OfflineObfuscation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00037D00 File Offset: 0x00035F00
		public unsafe bool OnlineObfuscation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_get_OnlineObfuscation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00037D3C File Offset: 0x00035F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995363, XrefRangeEnd = 995369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObfuscation(Nullable<bool> offline, Nullable<bool> online)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(offline));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(online));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr_SetObfuscation_Public_Void_Nullable_1_Boolean_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00037D9C File Offset: 0x00035F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995369, XrefRangeEnd = 995370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameConfigurationConstraints()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameConfigurationConstraints>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConfigurationConstraints.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0000794E File Offset: 0x00005B4E
		public GameConfigurationConstraints(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00037DD8 File Offset: 0x00035FD8
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00007957 File Offset: 0x00005B57
		public unsafe int minHumanPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_minHumanPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_minHumanPlayers)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00037E00 File Offset: 0x00036000
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00007972 File Offset: 0x00005B72
		public unsafe int minMatchPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_minMatchPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_minMatchPlayers)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00037E28 File Offset: 0x00036028
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0000798D File Offset: 0x00005B8D
		public unsafe int maxMatchPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_maxMatchPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_maxMatchPlayers)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00037E50 File Offset: 0x00036050
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x000079A8 File Offset: 0x00005BA8
		public unsafe bool offlineObfuscation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_offlineObfuscation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_offlineObfuscation)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00037E78 File Offset: 0x00036078
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000079C3 File Offset: 0x00005BC3
		public unsafe bool onlineObfuscation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_onlineObfuscation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_onlineObfuscation)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00037EA0 File Offset: 0x000360A0
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x000079DE File Offset: 0x00005BDE
		public unsafe AccountID RequiredFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_RequiredFriend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameConfigurationConstraints.NativeFieldInfoPtr_RequiredFriend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_minHumanPlayers;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_minMatchPlayers;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_maxMatchPlayers;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_offlineObfuscation;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_onlineObfuscation;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_RequiredFriend;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_get_MinHumanPlayers_Public_get_Int32_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_MinMatchPlayers_Public_get_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxMatchPlayers_Public_get_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_OfflineObfuscation_Public_get_Boolean_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlineObfuscation_Public_get_Boolean_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_SetObfuscation_Public_Void_Nullable_1_Boolean_Nullable_1_Boolean_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

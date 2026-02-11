using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001D8 RID: 472
	[Serializable]
	public class SerializedRunUsableAbilityForPlayer : SerializedAction
	{
		// Token: 0x060013FA RID: 5114 RVA: 0x0006A1F8 File Offset: 0x000683F8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunUsableAbilityForPlayer()
		{
			Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedRunUsableAbilityForPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr);
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_AbilityToRunID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "AbilityToRunID");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "PlayerID");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ActiveAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "ActiveAbilityID");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipTargeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "SkipTargeting");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "SkipCosts");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipSelectedCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "SkipSelectedCosts");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_MayCancelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "MayCancelAbility");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "ResolutionSourceID");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceOverrideID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "ResolutionSourceOverrideID");
			SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_CurrentSubState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, "CurrentSubState");
			SerializedRunUsableAbilityForPlayer.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, 100667705);
			SerializedRunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr, 100667706);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0006A318 File Offset: 0x00068518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588535, XrefRangeEnd = 588536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunUsableAbilityForPlayer.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0006A374 File Offset: 0x00068574
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunUsableAbilityForPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunUsableAbilityForPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00009B73 File Offset: 0x00007D73
		public SerializedRunUsableAbilityForPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0006A3B0 File Offset: 0x000685B0
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00009B7C File Offset: 0x00007D7C
		public unsafe EntityID AbilityToRunID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_AbilityToRunID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_AbilityToRunID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0006A3E0 File Offset: 0x000685E0
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00009B9B File Offset: 0x00007D9B
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0006A410 File Offset: 0x00068610
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00009BBA File Offset: 0x00007DBA
		public unsafe EntityID ActiveAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ActiveAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ActiveAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0006A440 File Offset: 0x00068640
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00009BD9 File Offset: 0x00007DD9
		public unsafe bool SkipTargeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipTargeting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipTargeting)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0006A468 File Offset: 0x00068668
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public unsafe bool SkipCosts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipCosts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipCosts)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0006A490 File Offset: 0x00068690
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00009C0F File Offset: 0x00007E0F
		public unsafe bool SkipSelectedCosts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipSelectedCosts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_SkipSelectedCosts)) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0006A4B8 File Offset: 0x000686B8
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00009C2A File Offset: 0x00007E2A
		public unsafe bool MayCancelAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_MayCancelAbility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_MayCancelAbility)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0006A4E0 File Offset: 0x000686E0
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00009C45 File Offset: 0x00007E45
		public unsafe EntityID ResolutionSourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0006A510 File Offset: 0x00068710
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x00009C64 File Offset: 0x00007E64
		public unsafe EntityID ResolutionSourceOverrideID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceOverrideID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_ResolutionSourceOverrideID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0006A540 File Offset: 0x00068740
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00009C83 File Offset: 0x00007E83
		public unsafe int CurrentSubState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_CurrentSubState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunUsableAbilityForPlayer.NativeFieldInfoPtr_CurrentSubState)) = value;
			}
		}

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_AbilityToRunID;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityID;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_SkipTargeting;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_SkipCosts;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_SkipSelectedCosts;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_MayCancelAbility;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionSourceID;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionSourceOverrideID;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSubState;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

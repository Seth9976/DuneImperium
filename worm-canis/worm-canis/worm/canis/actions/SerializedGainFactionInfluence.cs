using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.actions
{
	// Token: 0x02000243 RID: 579
	public class SerializedGainFactionInfluence : SerializedAction
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x000BB1C0 File Offset: 0x000B93C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainFactionInfluence()
		{
			Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainFactionInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr);
			SerializedGainFactionInfluence.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, "PlayerID");
			SerializedGainFactionInfluence.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, "Faction");
			SerializedGainFactionInfluence.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, "Amount");
			SerializedGainFactionInfluence.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, "LogMode");
			SerializedGainFactionInfluence.NativeFieldInfoPtr_GameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, "GameLogID");
			SerializedGainFactionInfluence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, 100667847);
			SerializedGainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr, 100667848);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000BB27C File Offset: 0x000B947C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136053, XrefRangeEnd = 136061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainFactionInfluence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000BB2D8 File Offset: 0x000B94D8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainFactionInfluence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainFactionInfluence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0000AD5D File Offset: 0x00008F5D
		public SerializedGainFactionInfluence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000BB314 File Offset: 0x000B9514
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000AD66 File Offset: 0x00008F66
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000BB344 File Offset: 0x000B9544
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000AD85 File Offset: 0x00008F85
		public unsafe Factions Faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_Faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_Faction)) = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x000BB36C File Offset: 0x000B956C
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000BB394 File Offset: 0x000B9594
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0000ADBB File Offset: 0x00008FBB
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x000BB3BC File Offset: 0x000B95BC
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x0000ADD6 File Offset: 0x00008FD6
		public unsafe int GameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_GameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainFactionInfluence.NativeFieldInfoPtr_GameLogID)) = value;
			}
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr_Faction;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeFieldInfoPtr_GameLogID;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

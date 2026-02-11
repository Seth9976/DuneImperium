using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002DF RID: 735
	public class SerializedGainResearch : SerializedAction
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x000CEFC0 File Offset: 0x000CD1C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainResearch()
		{
			Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedGainResearch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr);
			SerializedGainResearch.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, "PlayerID");
			SerializedGainResearch.NativeFieldInfoPtr_TargetSpaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, "TargetSpaceIndex");
			SerializedGainResearch.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, "LogMode");
			SerializedGainResearch.NativeFieldInfoPtr_GameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, "GameLogID");
			SerializedGainResearch.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, 100670382);
			SerializedGainResearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr, 100670383);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000CF068 File Offset: 0x000CD268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170646, XrefRangeEnd = 170654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainResearch.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000CF0C4 File Offset: 0x000CD2C4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainResearch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainResearch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainResearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		public SerializedGainResearch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x000CF100 File Offset: 0x000CD300
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0000CA75 File Offset: 0x0000AC75
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000CF130 File Offset: 0x000CD330
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0000CA94 File Offset: 0x0000AC94
		public unsafe int TargetSpaceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_TargetSpaceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_TargetSpaceIndex)) = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x000CF158 File Offset: 0x000CD358
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0000CAAF File Offset: 0x0000ACAF
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x000CF180 File Offset: 0x000CD380
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0000CACA File Offset: 0x0000ACCA
		public unsafe int GameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_GameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainResearch.NativeFieldInfoPtr_GameLogID)) = value;
			}
		}

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_TargetSpaceIndex;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_GameLogID;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

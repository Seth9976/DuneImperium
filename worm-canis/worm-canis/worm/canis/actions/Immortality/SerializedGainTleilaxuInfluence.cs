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
	// Token: 0x020002E3 RID: 739
	public class SerializedGainTleilaxuInfluence : SerializedAction
	{
		// Token: 0x06001E6E RID: 7790 RVA: 0x000CFB1C File Offset: 0x000CDD1C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainTleilaxuInfluence()
		{
			Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedGainTleilaxuInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr);
			SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, "PlayerID");
			SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, "Amount");
			SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, "LogMode");
			SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_GameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, "GameLogID");
			SerializedGainTleilaxuInfluence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, 100670446);
			SerializedGainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr, 100670447);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000CFBC4 File Offset: 0x000CDDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171226, XrefRangeEnd = 171234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainTleilaxuInfluence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000CFC20 File Offset: 0x000CDE20
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainTleilaxuInfluence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainTleilaxuInfluence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0000CBC1 File Offset: 0x0000ADC1
		public SerializedGainTleilaxuInfluence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x000CFC5C File Offset: 0x000CDE5C
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0000CBCA File Offset: 0x0000ADCA
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x000CFC8C File Offset: 0x000CDE8C
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0000CBE9 File Offset: 0x0000ADE9
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x000CFCB4 File Offset: 0x000CDEB4
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0000CC04 File Offset: 0x0000AE04
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x000CFCDC File Offset: 0x000CDEDC
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0000CC1F File Offset: 0x0000AE1F
		public unsafe int GameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_GameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainTleilaxuInfluence.NativeFieldInfoPtr_GameLogID)) = value;
			}
		}

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr_GameLogID;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

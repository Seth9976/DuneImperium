using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200025F RID: 607
	public class SerializedGiveAllianceToken : SerializedAction
	{
		// Token: 0x060019F5 RID: 6645 RVA: 0x000BDD24 File Offset: 0x000BBF24
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGiveAllianceToken()
		{
			Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGiveAllianceToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr);
			SerializedGiveAllianceToken.NativeFieldInfoPtr_AllianceTokenID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr, "AllianceTokenID");
			SerializedGiveAllianceToken.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr, 100668105);
			SerializedGiveAllianceToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr, 100668106);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000BDD90 File Offset: 0x000BBF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139399, XrefRangeEnd = 139411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGiveAllianceToken.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000BDDEC File Offset: 0x000BBFEC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGiveAllianceToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGiveAllianceToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGiveAllianceToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0000B2B9 File Offset: 0x000094B9
		public SerializedGiveAllianceToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x000BDE28 File Offset: 0x000BC028
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0000B2C2 File Offset: 0x000094C2
		public unsafe EntityID AllianceTokenID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGiveAllianceToken.NativeFieldInfoPtr_AllianceTokenID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGiveAllianceToken.NativeFieldInfoPtr_AllianceTokenID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr_AllianceTokenID;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

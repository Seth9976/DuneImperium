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
	// Token: 0x020002E9 RID: 745
	public class SerializedMoveFirstCardToPlay : SerializedAction
	{
		// Token: 0x06001EB5 RID: 7861 RVA: 0x000D09DC File Offset: 0x000CEBDC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMoveFirstCardToPlay()
		{
			Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedMoveFirstCardToPlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr);
			SerializedMoveFirstCardToPlay.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr, "PlayerID");
			SerializedMoveFirstCardToPlay.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr, 100670508);
			SerializedMoveFirstCardToPlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr, 100670509);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000D0A48 File Offset: 0x000CEC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171773, XrefRangeEnd = 171781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMoveFirstCardToPlay.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000D0AA4 File Offset: 0x000CECA4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMoveFirstCardToPlay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMoveFirstCardToPlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMoveFirstCardToPlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000CE30 File Offset: 0x0000B030
		public SerializedMoveFirstCardToPlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000D0AE0 File Offset: 0x000CECE0
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0000CE39 File Offset: 0x0000B039
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveFirstCardToPlay.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveFirstCardToPlay.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

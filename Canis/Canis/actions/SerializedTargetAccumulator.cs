using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001DA RID: 474
	[Serializable]
	public class SerializedTargetAccumulator : SerializedAction
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x0006A89C File Offset: 0x00068A9C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTargetAccumulator()
		{
			Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedTargetAccumulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr);
			SerializedTargetAccumulator.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr, "PlayerID");
			SerializedTargetAccumulator.NativeFieldInfoPtr_AbilityToRunID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr, "AbilityToRunID");
			SerializedTargetAccumulator.NativeFieldInfoPtr_ActiveAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr, "ActiveAbilityID");
			SerializedTargetAccumulator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr, 100667720);
			SerializedTargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr, 100667721);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0006A930 File Offset: 0x00068B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588607, XrefRangeEnd = 588608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTargetAccumulator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0006A98C File Offset: 0x00068B8C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTargetAccumulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTargetAccumulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00009D04 File Offset: 0x00007F04
		public SerializedTargetAccumulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0006A9C8 File Offset: 0x00068BC8
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x00009D0D File Offset: 0x00007F0D
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0006A9F8 File Offset: 0x00068BF8
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x00009D2C File Offset: 0x00007F2C
		public unsafe EntityID AbilityToRunID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_AbilityToRunID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_AbilityToRunID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006AA28 File Offset: 0x00068C28
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x00009D4B File Offset: 0x00007F4B
		public unsafe EntityID ActiveAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_ActiveAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTargetAccumulator.NativeFieldInfoPtr_ActiveAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr_AbilityToRunID;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityID;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

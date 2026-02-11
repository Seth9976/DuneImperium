using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public class SerializedRunAbilityFSM : SerializedAction
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x0006868C File Offset: 0x0006688C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunAbilityFSM()
		{
			Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedRunAbilityFSM");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr);
			SerializedRunAbilityFSM.NativeFieldInfoPtr_RunCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr, "RunCost");
			SerializedRunAbilityFSM.NativeFieldInfoPtr_SelectedAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr, "SelectedAbilityID");
			SerializedRunAbilityFSM.NativeFieldInfoPtr_CurrentSubState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr, "CurrentSubState");
			SerializedRunAbilityFSM.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr, 100667553);
			SerializedRunAbilityFSM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr, 100667554);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00068720 File Offset: 0x00066920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587191, XrefRangeEnd = 587212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunAbilityFSM.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0006877C File Offset: 0x0006697C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunAbilityFSM()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunAbilityFSM>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunAbilityFSM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00009861 File Offset: 0x00007A61
		public SerializedRunAbilityFSM(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000687B8 File Offset: 0x000669B8
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000986A File Offset: 0x00007A6A
		public unsafe bool RunCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_RunCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_RunCost)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000687E0 File Offset: 0x000669E0
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x00009885 File Offset: 0x00007A85
		public unsafe EntityID SelectedAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_SelectedAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_SelectedAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00068810 File Offset: 0x00066A10
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x000098A4 File Offset: 0x00007AA4
		public unsafe int CurrentSubState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_CurrentSubState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunAbilityFSM.NativeFieldInfoPtr_CurrentSubState)) = value;
			}
		}

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr_RunCost;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityID;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSubState;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

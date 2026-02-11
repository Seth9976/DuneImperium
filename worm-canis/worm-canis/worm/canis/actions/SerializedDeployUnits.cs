using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x02000236 RID: 566
	public class SerializedDeployUnits : SerializedAction
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x000B9474 File Offset: 0x000B7674
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDeployUnits()
		{
			Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedDeployUnits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr);
			SerializedDeployUnits.NativeFieldInfoPtr_TroopEntityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr, "TroopEntityIDs");
			SerializedDeployUnits.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr, "LogMode");
			SerializedDeployUnits.NativeFieldInfoPtr_SkipUnitsGainedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr, "SkipUnitsGainedUpdate");
			SerializedDeployUnits.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr, 100667665);
			SerializedDeployUnits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr, 100667666);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000B9508 File Offset: 0x000B7708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134102, XrefRangeEnd = 134109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDeployUnits.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000B9564 File Offset: 0x000B7764
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedDeployUnits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDeployUnits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDeployUnits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000AA89 File Offset: 0x00008C89
		public SerializedDeployUnits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000B95A0 File Offset: 0x000B77A0
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000AA92 File Offset: 0x00008C92
		public unsafe List<EntityID> TroopEntityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_TroopEntityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_TroopEntityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x000B95D0 File Offset: 0x000B77D0
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000AAB1 File Offset: 0x00008CB1
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000B95F8 File Offset: 0x000B77F8
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000AACC File Offset: 0x00008CCC
		public unsafe bool SkipUnitsGainedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_SkipUnitsGainedUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeployUnits.NativeFieldInfoPtr_SkipUnitsGainedUpdate)) = value;
			}
		}

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_TroopEntityIDs;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_SkipUnitsGainedUpdate;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

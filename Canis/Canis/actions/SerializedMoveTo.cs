using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001C5 RID: 453
	public class SerializedMoveTo : SerializedAction
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x00066E28 File Offset: 0x00065028
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMoveTo()
		{
			Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedMoveTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr);
			SerializedMoveTo.NativeFieldInfoPtr_TargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr, "TargetID");
			SerializedMoveTo.NativeFieldInfoPtr_SelectedDestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr, "SelectedDestinationID");
			SerializedMoveTo.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr, 100667437);
			SerializedMoveTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr, 100667438);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00066EA8 File Offset: 0x000650A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586529, XrefRangeEnd = 586548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMoveTo.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00066F04 File Offset: 0x00065104
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMoveTo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMoveTo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMoveTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0000967B File Offset: 0x0000787B
		public SerializedMoveTo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00066F40 File Offset: 0x00065140
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00009684 File Offset: 0x00007884
		public unsafe EntityID TargetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveTo.NativeFieldInfoPtr_TargetID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveTo.NativeFieldInfoPtr_TargetID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00066F70 File Offset: 0x00065170
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000096A3 File Offset: 0x000078A3
		public unsafe EntityID SelectedDestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveTo.NativeFieldInfoPtr_SelectedDestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMoveTo.NativeFieldInfoPtr_SelectedDestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_TargetID;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_SelectedDestinationID;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

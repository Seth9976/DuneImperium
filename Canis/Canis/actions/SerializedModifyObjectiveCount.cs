using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001BA RID: 442
	public class SerializedModifyObjectiveCount : SerializedAction
	{
		// Token: 0x060012BF RID: 4799 RVA: 0x00065514 File Offset: 0x00063714
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedModifyObjectiveCount()
		{
			Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedModifyObjectiveCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr);
			SerializedModifyObjectiveCount.NativeFieldInfoPtr_DeltaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr, "DeltaFactory");
			SerializedModifyObjectiveCount.NativeFieldInfoPtr_ObjectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr, "ObjectiveID");
			SerializedModifyObjectiveCount.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr, 100667321);
			SerializedModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr, 100667322);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00065594 File Offset: 0x00063794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585795, XrefRangeEnd = 585801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedModifyObjectiveCount.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000655F0 File Offset: 0x000637F0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedModifyObjectiveCount()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedModifyObjectiveCount>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00009309 File Offset: 0x00007509
		public SerializedModifyObjectiveCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0006562C File Offset: 0x0006382C
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00009312 File Offset: 0x00007512
		public unsafe ObjectiveDeltaFactory DeltaFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedModifyObjectiveCount.NativeFieldInfoPtr_DeltaFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectiveDeltaFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedModifyObjectiveCount.NativeFieldInfoPtr_DeltaFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0006565C File Offset: 0x0006385C
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00009331 File Offset: 0x00007531
		public unsafe int ObjectiveID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedModifyObjectiveCount.NativeFieldInfoPtr_ObjectiveID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedModifyObjectiveCount.NativeFieldInfoPtr_ObjectiveID)) = value;
			}
		}

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_DeltaFactory;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeFieldInfoPtr_ObjectiveID;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

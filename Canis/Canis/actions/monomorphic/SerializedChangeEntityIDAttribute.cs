using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.monomorphic
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class SerializedChangeEntityIDAttribute : SerializedAction
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x00073F90 File Offset: 0x00072190
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedChangeEntityIDAttribute()
		{
			Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.monomorphic", "SerializedChangeEntityIDAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr);
			SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr, "AttributeDefinition");
			SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr, "AttributeValue");
			SerializedChangeEntityIDAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr, 100668424);
			SerializedChangeEntityIDAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr, 100668425);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00074010 File Offset: 0x00072210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593571, XrefRangeEnd = 593583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedChangeEntityIDAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0007406C File Offset: 0x0007226C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedChangeEntityIDAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChangeEntityIDAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChangeEntityIDAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000ACF5 File Offset: 0x00008EF5
		public SerializedChangeEntityIDAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000740A8 File Offset: 0x000722A8
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x0000ACFE File Offset: 0x00008EFE
		public unsafe int AttributeDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeDefinition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeDefinition)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x000740D0 File Offset: 0x000722D0
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x0000AD19 File Offset: 0x00008F19
		public unsafe EntityID AttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeEntityIDAttribute.NativeFieldInfoPtr_AttributeValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_AttributeDefinition;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_AttributeValue;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

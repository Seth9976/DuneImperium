using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.monomorphic
{
	// Token: 0x0200021F RID: 543
	[Serializable]
	public class SerializedChangeBoolAttribute : SerializedAction
	{
		// Token: 0x0600169E RID: 5790 RVA: 0x00074294 File Offset: 0x00072494
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedChangeBoolAttribute()
		{
			Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.monomorphic", "SerializedChangeBoolAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr);
			SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr, "AttributeDefinition");
			SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr, "AttributeValue");
			SerializedChangeBoolAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr, 100668429);
			SerializedChangeBoolAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr, 100668430);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00074314 File Offset: 0x00072514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593612, XrefRangeEnd = 593624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedChangeBoolAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00074370 File Offset: 0x00072570
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedChangeBoolAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChangeBoolAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChangeBoolAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0000AD41 File Offset: 0x00008F41
		public SerializedChangeBoolAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000743AC File Offset: 0x000725AC
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0000AD4A File Offset: 0x00008F4A
		public unsafe int AttributeDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeDefinition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeDefinition)) = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000743D4 File Offset: 0x000725D4
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000AD65 File Offset: 0x00008F65
		public Nullable<bool> AttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeValue);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeBoolAttribute.NativeFieldInfoPtr_AttributeValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_AttributeDefinition;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_AttributeValue;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

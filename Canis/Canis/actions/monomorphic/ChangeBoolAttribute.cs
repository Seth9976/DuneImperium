using System;
using Canis.actions.serialized;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.monomorphic
{
	// Token: 0x0200021E RID: 542
	public class ChangeBoolAttribute : ChangeAttribute<Nullable<bool>>
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x00074100 File Offset: 0x00072300
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeBoolAttribute()
		{
			Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.monomorphic", "ChangeBoolAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr);
			ChangeBoolAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Boolean_Nullable_1_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr, 100668426);
			ChangeBoolAttribute.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr, 100668427);
			ChangeBoolAttribute.NativeMethodInfoPtr_Deserialize_Public_Static_ChangeBoolAttribute_Match_SerializedChangeBoolAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr, 100668428);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0007416C File Offset: 0x0007236C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 593586, RefRangeEnd = 593595, XrefRangeStart = 593583, XrefRangeEnd = 593586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangeBoolAttribute(AttributeDefinition<Nullable<bool>> attribute, Nullable<bool> value, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeBoolAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeBoolAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Boolean_Nullable_1_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000741E0 File Offset: 0x000723E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593595, XrefRangeEnd = 593600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangeBoolAttribute.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0007423C File Offset: 0x0007243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593600, XrefRangeEnd = 593612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChangeBoolAttribute Deserialize(Match match, SerializedChangeBoolAttribute serialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeBoolAttribute.NativeMethodInfoPtr_Deserialize_Public_Static_ChangeBoolAttribute_Match_SerializedChangeBoolAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChangeBoolAttribute>(intPtr3) : null;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0000AD38 File Offset: 0x00008F38
		public ChangeBoolAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Boolean_Nullable_1_Boolean_Match_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ChangeBoolAttribute_Match_SerializedChangeBoolAttribute_0;
	}
}

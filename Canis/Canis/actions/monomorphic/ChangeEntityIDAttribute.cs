using System;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.monomorphic
{
	// Token: 0x0200021C RID: 540
	public class ChangeEntityIDAttribute : ChangeAttribute<EntityID>
	{
		// Token: 0x0600168C RID: 5772 RVA: 0x00073E00 File Offset: 0x00072000
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeEntityIDAttribute()
		{
			Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.monomorphic", "ChangeEntityIDAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr);
			ChangeEntityIDAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr, 100668421);
			ChangeEntityIDAttribute.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr, 100668422);
			ChangeEntityIDAttribute.NativeMethodInfoPtr_Deserialize_Public_Static_ChangeEntityIDAttribute_Match_SerializedChangeEntityIDAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr, 100668423);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00073E6C File Offset: 0x0007206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593550, XrefRangeEnd = 593553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangeEntityIDAttribute(AttributeDefinition<EntityID> attribute, EntityID value, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeEntityIDAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEntityIDAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_EntityID_EntityID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00073EDC File Offset: 0x000720DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593553, XrefRangeEnd = 593559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangeEntityIDAttribute.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00073F38 File Offset: 0x00072138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593559, XrefRangeEnd = 593571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChangeEntityIDAttribute Deserialize(Match match, SerializedChangeEntityIDAttribute serialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeEntityIDAttribute.NativeMethodInfoPtr_Deserialize_Public_Static_ChangeEntityIDAttribute_Match_SerializedChangeEntityIDAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChangeEntityIDAttribute>(intPtr3) : null;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public ChangeEntityIDAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_EntityID_EntityID_Match_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ChangeEntityIDAttribute_Match_SerializedChangeEntityIDAttribute_0;
	}
}

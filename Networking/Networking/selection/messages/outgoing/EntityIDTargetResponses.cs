using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000085 RID: 133
	public class EntityIDTargetResponses : Object
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x00011EB4 File Offset: 0x000100B4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityIDTargetResponses()
		{
			Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "EntityIDTargetResponses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr);
			EntityIDTargetResponses.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr, "entityID");
			EntityIDTargetResponses.NativeFieldInfoPtr_targetResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr, "targetResponses");
			EntityIDTargetResponses.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr, 100663588);
			EntityIDTargetResponses.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr, 100663589);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00011F34 File Offset: 0x00010134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1194683, RefRangeEnd = 1194685, XrefRangeStart = 1194674, XrefRangeEnd = 1194683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityIDTargetResponses(EntityID entityID, IEnumerable<TargetResponse> targetResponses)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityIDTargetResponses>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIDTargetResponses.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00011F94 File Offset: 0x00010194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194685, XrefRangeEnd = 1194697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityIDTargetResponses.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00004C94 File Offset: 0x00002E94
		public EntityIDTargetResponses(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00011FD8 File Offset: 0x000101D8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00004C9D File Offset: 0x00002E9D
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDTargetResponses.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDTargetResponses.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00012008 File Offset: 0x00010208
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00004CBC File Offset: 0x00002EBC
		public unsafe Il2CppReferenceArray<TargetResponse> targetResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDTargetResponses.NativeFieldInfoPtr_targetResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDTargetResponses.NativeFieldInfoPtr_targetResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_targetResponses;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

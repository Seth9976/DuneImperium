using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000084 RID: 132
	public class EntityIDEntityTargetsResponse : Object
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x00011D30 File Offset: 0x0000FF30
		// Note: this type is marked as 'beforefieldinit'.
		static EntityIDEntityTargetsResponse()
		{
			Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "EntityIDEntityTargetsResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr);
			EntityIDEntityTargetsResponse.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr, "entityID");
			EntityIDEntityTargetsResponse.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr, "targets");
			EntityIDEntityTargetsResponse.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr, 100663586);
			EntityIDEntityTargetsResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr, 100663587);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194643, XrefRangeEnd = 1194652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityIDEntityTargetsResponse(EntityID entityID, IEnumerable<EntityID> targets)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityIDEntityTargetsResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIDEntityTargetsResponse.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00011E10 File Offset: 0x00010010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194652, XrefRangeEnd = 1194674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityIDEntityTargetsResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00004C4D File Offset: 0x00002E4D
		public EntityIDEntityTargetsResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00011E54 File Offset: 0x00010054
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00004C56 File Offset: 0x00002E56
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDEntityTargetsResponse.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDEntityTargetsResponse.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00011E84 File Offset: 0x00010084
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00004C75 File Offset: 0x00002E75
		public unsafe Il2CppReferenceArray<EntityID> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDEntityTargetsResponse.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIDEntityTargetsResponse.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_EntityID_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

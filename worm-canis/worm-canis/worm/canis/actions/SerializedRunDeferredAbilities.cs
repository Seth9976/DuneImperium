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
	// Token: 0x02000293 RID: 659
	public class SerializedRunDeferredAbilities : SerializedAction
	{
		// Token: 0x06001B80 RID: 7040 RVA: 0x000C3C1C File Offset: 0x000C1E1C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunDeferredAbilities()
		{
			Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedRunDeferredAbilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr);
			SerializedRunDeferredAbilities.NativeFieldInfoPtr_DeferredAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr, "DeferredAbilityIDs");
			SerializedRunDeferredAbilities.NativeFieldInfoPtr_ParentUndoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr, "ParentUndoID");
			SerializedRunDeferredAbilities.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr, 100668761);
			SerializedRunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr, 100668762);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000C3C9C File Offset: 0x000C1E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146608, XrefRangeEnd = 146639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunDeferredAbilities.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000C3CF8 File Offset: 0x000C1EF8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunDeferredAbilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunDeferredAbilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000BBEF File Offset: 0x00009DEF
		public SerializedRunDeferredAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000C3D34 File Offset: 0x000C1F34
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public unsafe List<EntityID> DeferredAbilityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunDeferredAbilities.NativeFieldInfoPtr_DeferredAbilityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunDeferredAbilities.NativeFieldInfoPtr_DeferredAbilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000C3D64 File Offset: 0x000C1F64
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000BC17 File Offset: 0x00009E17
		public unsafe EntityID ParentUndoID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunDeferredAbilities.NativeFieldInfoPtr_ParentUndoID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunDeferredAbilities.NativeFieldInfoPtr_ParentUndoID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_DeferredAbilityIDs;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_ParentUndoID;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

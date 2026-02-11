using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200029D RID: 669
	public class TakeControl : global::Canis.actions.Action
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x000C4E04 File Offset: 0x000C3004
		// Note: this type is marked as 'beforefieldinit'.
		static TakeControl()
		{
			Il2CppClassPointerStore<TakeControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "TakeControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeControl>.NativeClassPtr);
			TakeControl.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, "<LogMode>k__BackingField");
			TakeControl.NativeFieldInfoPtr_logTopLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, "logTopLevel");
			TakeControl.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668884);
			TakeControl.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668885);
			TakeControl.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668886);
			TakeControl.NativeMethodInfoPtr_GetControlMarker_Private_WormEntity_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668887);
			TakeControl.NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668888);
			TakeControl.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668889);
			TakeControl.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668890);
			TakeControl.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, 100668891);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000C4EFC File Offset: 0x000C30FC
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x000C4F38 File Offset: 0x000C3138
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000C4F78 File Offset: 0x000C3178
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 148093, RefRangeEnd = 148102, XrefRangeStart = 148092, XrefRangeEnd = 148093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TakeControl(Match match, bool logTopLevel = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeControl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logTopLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000C4FD4 File Offset: 0x000C31D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148121, RefRangeEnd = 148123, XrefRangeStart = 148102, XrefRangeEnd = 148121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntity GetControlMarker(WormEntity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.NativeMethodInfoPtr_GetControlMarker_Private_WormEntity_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr3) : null;
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000C5024 File Offset: 0x000C3224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148125, RefRangeEnd = 148127, XrefRangeStart = 148123, XrefRangeEnd = 148125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControllable(ObjectAttributes oa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000C5074 File Offset: 0x000C3274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148127, XrefRangeEnd = 148133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TakeControl.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000C50C0 File Offset: 0x000C32C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148133, XrefRangeEnd = 148140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TakeControl.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000C511C File Offset: 0x000C331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148140, XrefRangeEnd = 148144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TakeControl.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0000BD69 File Offset: 0x00009F69
		public TakeControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000C5178 File Offset: 0x000C3378
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000BD72 File Offset: 0x00009F72
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000C51A0 File Offset: 0x000C33A0
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000BD8D File Offset: 0x00009F8D
		public unsafe bool logTopLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl.NativeFieldInfoPtr_logTopLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl.NativeFieldInfoPtr_logTopLevel)) = value;
			}
		}

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeFieldInfoPtr_logTopLevel;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_GetControlMarker_Private_WormEntity_WormEntity_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006EA RID: 1770
		[ObfuscatedName("worm.canis.actions.TakeControl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005F01 RID: 24321 RVA: 0x001D586C File Offset: 0x001D3A6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr);
				TakeControl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9");
				TakeControl.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9__6_0");
				TakeControl.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9__8_0");
				TakeControl.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9__8_1");
				TakeControl.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9__9_0");
				TakeControl.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, "<>9__9_1");
				TakeControl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668893);
				TakeControl.__c.NativeMethodInfoPtr__GetControlMarker_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668894);
				TakeControl.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668895);
				TakeControl.__c.NativeMethodInfoPtr__execute_b__8_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668896);
				TakeControl.__c.NativeMethodInfoPtr__undo_b__9_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668897);
				TakeControl.__c.NativeMethodInfoPtr__undo_b__9_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr, 100668898);
			}

			// Token: 0x06005F02 RID: 24322 RVA: 0x001D5988 File Offset: 0x001D3B88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeControl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F03 RID: 24323 RVA: 0x001D59C4 File Offset: 0x001D3BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147603, XrefRangeEnd = 147608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetControlMarker_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__GetControlMarker_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F04 RID: 24324 RVA: 0x001D5A14 File Offset: 0x001D3C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147608, XrefRangeEnd = 147613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__8_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F05 RID: 24325 RVA: 0x001D5A64 File Offset: 0x001D3C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147613, XrefRangeEnd = 147618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__8_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__execute_b__8_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F06 RID: 24326 RVA: 0x001D5AB4 File Offset: 0x001D3CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147618, XrefRangeEnd = 147623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _undo_b__9_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__undo_b__9_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F07 RID: 24327 RVA: 0x001D5B04 File Offset: 0x001D3D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147623, XrefRangeEnd = 147628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _undo_b__9_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl.__c.NativeMethodInfoPtr__undo_b__9_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F08 RID: 24328 RVA: 0x00023EB4 File Offset: 0x000220B4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FA RID: 6394
			// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001D5B54 File Offset: 0x001D3D54
			// (set) Token: 0x06005F0A RID: 24330 RVA: 0x00023EBD File Offset: 0x000220BD
			public unsafe static TakeControl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TakeControl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FB RID: 6395
			// (get) Token: 0x06005F0B RID: 24331 RVA: 0x001D5B7C File Offset: 0x001D3D7C
			// (set) Token: 0x06005F0C RID: 24332 RVA: 0x00023ECF File Offset: 0x000220CF
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FC RID: 6396
			// (get) Token: 0x06005F0D RID: 24333 RVA: 0x001D5BA4 File Offset: 0x001D3DA4
			// (set) Token: 0x06005F0E RID: 24334 RVA: 0x00023EE1 File Offset: 0x000220E1
			public unsafe static Func<Entity, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FD RID: 6397
			// (get) Token: 0x06005F0F RID: 24335 RVA: 0x001D5BCC File Offset: 0x001D3DCC
			// (set) Token: 0x06005F10 RID: 24336 RVA: 0x00023EF3 File Offset: 0x000220F3
			public unsafe static Func<Entity, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FE RID: 6398
			// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001D5BF4 File Offset: 0x001D3DF4
			// (set) Token: 0x06005F12 RID: 24338 RVA: 0x00023F05 File Offset: 0x00022105
			public unsafe static Func<Entity, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FF RID: 6399
			// (get) Token: 0x06005F13 RID: 24339 RVA: 0x001D5C1C File Offset: 0x001D3E1C
			// (set) Token: 0x06005F14 RID: 24340 RVA: 0x00023F17 File Offset: 0x00022117
			public unsafe static Func<Entity, bool> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TakeControl.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TakeControl.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003DAC RID: 15788
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003DAD RID: 15789
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04003DAE RID: 15790
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04003DAF RID: 15791
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04003DB0 RID: 15792
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04003DB1 RID: 15793
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04003DB2 RID: 15794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003DB3 RID: 15795
			private static readonly IntPtr NativeMethodInfoPtr__GetControlMarker_b__6_0_Internal_Boolean_Entity_0;

			// Token: 0x04003DB4 RID: 15796
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Internal_Boolean_Entity_0;

			// Token: 0x04003DB5 RID: 15797
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_1_Internal_Boolean_Entity_0;

			// Token: 0x04003DB6 RID: 15798
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__9_0_Internal_Boolean_Entity_0;

			// Token: 0x04003DB7 RID: 15799
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__9_1_Internal_Boolean_Entity_0;
		}

		// Token: 0x020006EB RID: 1771
		[ObfuscatedName("worm.canis.actions.TakeControl+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06005F15 RID: 24341 RVA: 0x001D5C44 File Offset: 0x001D3E44
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr);
				TakeControl._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<>1__state");
				TakeControl._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<>2__current");
				TakeControl._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				TakeControl._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<>4__this");
				TakeControl._execute_d__8.NativeFieldInfoPtr__newController_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<newController>5__2");
				TakeControl._execute_d__8.NativeFieldInfoPtr__space_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<space>5__3");
				TakeControl._execute_d__8.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<wormMatch>5__4");
				TakeControl._execute_d__8.NativeFieldInfoPtr__undoNode_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<undoNode>5__5");
				TakeControl._execute_d__8.NativeFieldInfoPtr__existingControlMarker_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<existingControlMarker>5__6");
				TakeControl._execute_d__8.NativeFieldInfoPtr__newControlMarker_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<newControlMarker>5__7");
				TakeControl._execute_d__8.NativeFieldInfoPtr__oldController_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<oldController>5__8");
				TakeControl._execute_d__8.NativeFieldInfoPtr__wm_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<wm>5__9");
				TakeControl._execute_d__8.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, "<>7__wrap9");
				TakeControl._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668899);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668900);
				TakeControl._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668901);
				TakeControl._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668902);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668903);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668904);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668905);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668906);
				TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr, 100668907);
			}

			// Token: 0x06005F16 RID: 24342 RVA: 0x001D5E28 File Offset: 0x001D4028
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeControl._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F17 RID: 24343 RVA: 0x001D5E70 File Offset: 0x001D4070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147628, XrefRangeEnd = 147633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F18 RID: 24344 RVA: 0x001D5EA4 File Offset: 0x001D40A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147633, XrefRangeEnd = 147892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005F19 RID: 24345 RVA: 0x001D5EE0 File Offset: 0x001D40E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147892, XrefRangeEnd = 147895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700190D RID: 6413
			// (get) Token: 0x06005F1A RID: 24346 RVA: 0x001D5F14 File Offset: 0x001D4114
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005F1B RID: 24347 RVA: 0x001D5F54 File Offset: 0x001D4154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147895, XrefRangeEnd = 147900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700190E RID: 6414
			// (get) Token: 0x06005F1C RID: 24348 RVA: 0x001D5F88 File Offset: 0x001D4188
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F1D RID: 24349 RVA: 0x001D5FC8 File Offset: 0x001D41C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147900, XrefRangeEnd = 147902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005F1E RID: 24350 RVA: 0x001D6008 File Offset: 0x001D4208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F1F RID: 24351 RVA: 0x00023F29 File Offset: 0x00022129
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001900 RID: 6400
			// (get) Token: 0x06005F20 RID: 24352 RVA: 0x001D6048 File Offset: 0x001D4248
			// (set) Token: 0x06005F21 RID: 24353 RVA: 0x00023F32 File Offset: 0x00022132
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001901 RID: 6401
			// (get) Token: 0x06005F22 RID: 24354 RVA: 0x001D6070 File Offset: 0x001D4270
			// (set) Token: 0x06005F23 RID: 24355 RVA: 0x00023F4D File Offset: 0x0002214D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001902 RID: 6402
			// (get) Token: 0x06005F24 RID: 24356 RVA: 0x001D60A0 File Offset: 0x001D42A0
			// (set) Token: 0x06005F25 RID: 24357 RVA: 0x00023F6C File Offset: 0x0002216C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001903 RID: 6403
			// (get) Token: 0x06005F26 RID: 24358 RVA: 0x001D60C8 File Offset: 0x001D42C8
			// (set) Token: 0x06005F27 RID: 24359 RVA: 0x00023F87 File Offset: 0x00022187
			public unsafe TakeControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TakeControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001904 RID: 6404
			// (get) Token: 0x06005F28 RID: 24360 RVA: 0x001D60F8 File Offset: 0x001D42F8
			// (set) Token: 0x06005F29 RID: 24361 RVA: 0x00023FA6 File Offset: 0x000221A6
			public unsafe WormPlayer _newController_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__newController_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__newController_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001905 RID: 6405
			// (get) Token: 0x06005F2A RID: 24362 RVA: 0x001D6128 File Offset: 0x001D4328
			// (set) Token: 0x06005F2B RID: 24363 RVA: 0x00023FC5 File Offset: 0x000221C5
			public unsafe WormSpace _space_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__space_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__space_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001906 RID: 6406
			// (get) Token: 0x06005F2C RID: 24364 RVA: 0x001D6158 File Offset: 0x001D4358
			// (set) Token: 0x06005F2D RID: 24365 RVA: 0x00023FE4 File Offset: 0x000221E4
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001907 RID: 6407
			// (get) Token: 0x06005F2E RID: 24366 RVA: 0x001D6188 File Offset: 0x001D4388
			// (set) Token: 0x06005F2F RID: 24367 RVA: 0x00024003 File Offset: 0x00022203
			public unsafe UndoNode _undoNode_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__undoNode_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__undoNode_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001908 RID: 6408
			// (get) Token: 0x06005F30 RID: 24368 RVA: 0x001D61B8 File Offset: 0x001D43B8
			// (set) Token: 0x06005F31 RID: 24369 RVA: 0x00024022 File Offset: 0x00022222
			public unsafe WormEntity _existingControlMarker_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__existingControlMarker_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__existingControlMarker_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001909 RID: 6409
			// (get) Token: 0x06005F32 RID: 24370 RVA: 0x001D61E8 File Offset: 0x001D43E8
			// (set) Token: 0x06005F33 RID: 24371 RVA: 0x00024041 File Offset: 0x00022241
			public unsafe WormEntity _newControlMarker_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__newControlMarker_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__newControlMarker_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190A RID: 6410
			// (get) Token: 0x06005F34 RID: 24372 RVA: 0x001D6218 File Offset: 0x001D4418
			// (set) Token: 0x06005F35 RID: 24373 RVA: 0x00024060 File Offset: 0x00022260
			public unsafe WormPlayer _oldController_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__oldController_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__oldController_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190B RID: 6411
			// (get) Token: 0x06005F36 RID: 24374 RVA: 0x001D6248 File Offset: 0x001D4448
			// (set) Token: 0x06005F37 RID: 24375 RVA: 0x0002407F File Offset: 0x0002227F
			public unsafe WormMatch _wm_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__wm_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr__wm_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190C RID: 6412
			// (get) Token: 0x06005F38 RID: 24376 RVA: 0x001D6278 File Offset: 0x001D4478
			// (set) Token: 0x06005F39 RID: 24377 RVA: 0x0002409E File Offset: 0x0002229E
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._execute_d__8.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003DB8 RID: 15800
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003DB9 RID: 15801
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003DBA RID: 15802
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003DBB RID: 15803
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003DBC RID: 15804
			private static readonly IntPtr NativeFieldInfoPtr__newController_5__2;

			// Token: 0x04003DBD RID: 15805
			private static readonly IntPtr NativeFieldInfoPtr__space_5__3;

			// Token: 0x04003DBE RID: 15806
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003DBF RID: 15807
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__5;

			// Token: 0x04003DC0 RID: 15808
			private static readonly IntPtr NativeFieldInfoPtr__existingControlMarker_5__6;

			// Token: 0x04003DC1 RID: 15809
			private static readonly IntPtr NativeFieldInfoPtr__newControlMarker_5__7;

			// Token: 0x04003DC2 RID: 15810
			private static readonly IntPtr NativeFieldInfoPtr__oldController_5__8;

			// Token: 0x04003DC3 RID: 15811
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__9;

			// Token: 0x04003DC4 RID: 15812
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04003DC5 RID: 15813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003DC6 RID: 15814
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DC7 RID: 15815
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003DC8 RID: 15816
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003DC9 RID: 15817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003DCA RID: 15818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DCB RID: 15819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003DCC RID: 15820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003DCD RID: 15821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006EC RID: 1772
		[ObfuscatedName("worm.canis.actions.TakeControl+<undo>d__9")]
		public sealed class _undo_d__9 : Object
		{
			// Token: 0x06005F3A RID: 24378 RVA: 0x001D62A8 File Offset: 0x001D44A8
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__9()
			{
				Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TakeControl>.NativeClassPtr, "<undo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr);
				TakeControl._undo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<>1__state");
				TakeControl._undo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<>2__current");
				TakeControl._undo_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<>l__initialThreadId");
				TakeControl._undo_d__9.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "undoContext");
				TakeControl._undo_d__9.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<>3__undoContext");
				TakeControl._undo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<>4__this");
				TakeControl._undo_d__9.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<undoNode>5__2");
				TakeControl._undo_d__9.NativeFieldInfoPtr__wormMatch_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<wormMatch>5__3");
				TakeControl._undo_d__9.NativeFieldInfoPtr__playerMarker_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<playerMarker>5__4");
				TakeControl._undo_d__9.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<player>5__5");
				TakeControl._undo_d__9.NativeFieldInfoPtr__space_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<space>5__6");
				TakeControl._undo_d__9.NativeFieldInfoPtr__previousPlayer_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, "<previousPlayer>5__7");
				TakeControl._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668908);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668909);
				TakeControl._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668910);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668911);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668912);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668913);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668914);
				TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr, 100668915);
			}

			// Token: 0x06005F3B RID: 24379 RVA: 0x001D6464 File Offset: 0x001D4664
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeControl._undo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F3C RID: 24380 RVA: 0x001D64AC File Offset: 0x001D46AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F3D RID: 24381 RVA: 0x001D64E0 File Offset: 0x001D46E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147902, XrefRangeEnd = 148073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700191B RID: 6427
			// (get) Token: 0x06005F3E RID: 24382 RVA: 0x001D651C File Offset: 0x001D471C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005F3F RID: 24383 RVA: 0x001D655C File Offset: 0x001D475C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148073, XrefRangeEnd = 148083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700191C RID: 6428
			// (get) Token: 0x06005F40 RID: 24384 RVA: 0x001D6590 File Offset: 0x001D4790
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F41 RID: 24385 RVA: 0x001D65D0 File Offset: 0x001D47D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148083, XrefRangeEnd = 148092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005F42 RID: 24386 RVA: 0x001D6610 File Offset: 0x001D4810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeControl._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F43 RID: 24387 RVA: 0x000240BD File Offset: 0x000222BD
			public _undo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190F RID: 6415
			// (get) Token: 0x06005F44 RID: 24388 RVA: 0x001D6650 File Offset: 0x001D4850
			// (set) Token: 0x06005F45 RID: 24389 RVA: 0x000240C6 File Offset: 0x000222C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001910 RID: 6416
			// (get) Token: 0x06005F46 RID: 24390 RVA: 0x001D6678 File Offset: 0x001D4878
			// (set) Token: 0x06005F47 RID: 24391 RVA: 0x000240E1 File Offset: 0x000222E1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001911 RID: 6417
			// (get) Token: 0x06005F48 RID: 24392 RVA: 0x001D66A8 File Offset: 0x001D48A8
			// (set) Token: 0x06005F49 RID: 24393 RVA: 0x00024100 File Offset: 0x00022300
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001912 RID: 6418
			// (get) Token: 0x06005F4A RID: 24394 RVA: 0x001D66D0 File Offset: 0x001D48D0
			// (set) Token: 0x06005F4B RID: 24395 RVA: 0x0002411B File Offset: 0x0002231B
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001913 RID: 6419
			// (get) Token: 0x06005F4C RID: 24396 RVA: 0x001D6700 File Offset: 0x001D4900
			// (set) Token: 0x06005F4D RID: 24397 RVA: 0x0002413A File Offset: 0x0002233A
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001914 RID: 6420
			// (get) Token: 0x06005F4E RID: 24398 RVA: 0x001D6730 File Offset: 0x001D4930
			// (set) Token: 0x06005F4F RID: 24399 RVA: 0x00024159 File Offset: 0x00022359
			public unsafe TakeControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TakeControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001915 RID: 6421
			// (get) Token: 0x06005F50 RID: 24400 RVA: 0x001D6760 File Offset: 0x001D4960
			// (set) Token: 0x06005F51 RID: 24401 RVA: 0x00024178 File Offset: 0x00022378
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001916 RID: 6422
			// (get) Token: 0x06005F52 RID: 24402 RVA: 0x001D6790 File Offset: 0x001D4990
			// (set) Token: 0x06005F53 RID: 24403 RVA: 0x00024197 File Offset: 0x00022397
			public unsafe WormMatch _wormMatch_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__wormMatch_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__wormMatch_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001917 RID: 6423
			// (get) Token: 0x06005F54 RID: 24404 RVA: 0x001D67C0 File Offset: 0x001D49C0
			// (set) Token: 0x06005F55 RID: 24405 RVA: 0x000241B6 File Offset: 0x000223B6
			public unsafe WormEntity _playerMarker_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__playerMarker_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__playerMarker_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001918 RID: 6424
			// (get) Token: 0x06005F56 RID: 24406 RVA: 0x001D67F0 File Offset: 0x001D49F0
			// (set) Token: 0x06005F57 RID: 24407 RVA: 0x000241D5 File Offset: 0x000223D5
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001919 RID: 6425
			// (get) Token: 0x06005F58 RID: 24408 RVA: 0x001D6820 File Offset: 0x001D4A20
			// (set) Token: 0x06005F59 RID: 24409 RVA: 0x000241F4 File Offset: 0x000223F4
			public unsafe WormSpace _space_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__space_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__space_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700191A RID: 6426
			// (get) Token: 0x06005F5A RID: 24410 RVA: 0x001D6850 File Offset: 0x001D4A50
			// (set) Token: 0x06005F5B RID: 24411 RVA: 0x00024213 File Offset: 0x00022413
			public unsafe WormPlayer _previousPlayer_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__previousPlayer_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeControl._undo_d__9.NativeFieldInfoPtr__previousPlayer_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003DCE RID: 15822
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003DCF RID: 15823
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003DD0 RID: 15824
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003DD1 RID: 15825
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003DD2 RID: 15826
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003DD3 RID: 15827
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003DD4 RID: 15828
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04003DD5 RID: 15829
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__3;

			// Token: 0x04003DD6 RID: 15830
			private static readonly IntPtr NativeFieldInfoPtr__playerMarker_5__4;

			// Token: 0x04003DD7 RID: 15831
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04003DD8 RID: 15832
			private static readonly IntPtr NativeFieldInfoPtr__space_5__6;

			// Token: 0x04003DD9 RID: 15833
			private static readonly IntPtr NativeFieldInfoPtr__previousPlayer_5__7;

			// Token: 0x04003DDA RID: 15834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003DDB RID: 15835
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DDC RID: 15836
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003DDD RID: 15837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003DDE RID: 15838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DDF RID: 15839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003DE0 RID: 15840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003DE1 RID: 15841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis.actions.serialized;
using Canis.context;
using Canis.context.targetpickers;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001BF RID: 447
	public class MoveMultiple : Action
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x000661A0 File Offset: 0x000643A0
		// Note: this type is marked as 'beforefieldinit'.
		static MoveMultiple()
		{
			Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "MoveMultiple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr);
			MoveMultiple.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "destination");
			MoveMultiple.NativeFieldInfoPtr_destinationGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "destinationGen");
			MoveMultiple.NativeFieldInfoPtr_positionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "positionInParent");
			MoveMultiple.NativeFieldInfoPtr_SelectedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "SelectedTargets");
			MoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667359);
			MoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667360);
			MoveMultiple.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667361);
			MoveMultiple.NativeMethodInfoPtr_GetMoveTargets_Protected_Virtual_New_IEnumerable_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667362);
			MoveMultiple.NativeMethodInfoPtr_GetTargetsFromQueue_Private_IEnumerable_1_Entity_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667363);
			MoveMultiple.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667364);
			MoveMultiple.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, 100667365);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000662AC File Offset: 0x000644AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586346, XrefRangeEnd = 586349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveMultiple(Entity destination, Match m, Nullable<int> positionInParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00066320 File Offset: 0x00064520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586349, XrefRangeEnd = 586352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveMultiple(Func<Entity, Entity> destinationGen, Match m, Nullable<int> positionInParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destinationGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00066394 File Offset: 0x00064594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586352, XrefRangeEnd = 586358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveMultiple.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000663E0 File Offset: 0x000645E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586358, XrefRangeEnd = 586365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Entity> GetMoveTargets(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveMultiple.NativeMethodInfoPtr_GetMoveTargets_Protected_Virtual_New_IEnumerable_1_Entity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0006643C File Offset: 0x0006463C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 586372, RefRangeEnd = 586374, XrefRangeStart = 586365, XrefRangeEnd = 586372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetTargetsFromQueue(TargetResponseQueue trq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.NativeMethodInfoPtr_GetTargetsFromQueue_Private_IEnumerable_1_Entity_TargetResponseQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0006648C File Offset: 0x0006468C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586374, XrefRangeEnd = 586402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveMultiple.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000664E8 File Offset: 0x000646E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586402, XrefRangeEnd = 586407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00009510 File Offset: 0x00007710
		public MoveMultiple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00066538 File Offset: 0x00064738
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00009519 File Offset: 0x00007719
		public unsafe Entity destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00066568 File Offset: 0x00064768
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x00009538 File Offset: 0x00007738
		public unsafe Func<Entity, Entity> destinationGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_destinationGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_destinationGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00066598 File Offset: 0x00064798
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x00009557 File Offset: 0x00007757
		public Nullable<int> positionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_positionInParent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_positionInParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000665C8 File Offset: 0x000647C8
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00009585 File Offset: 0x00007785
		public unsafe IEnumerable<Entity> SelectedTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_SelectedTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.NativeFieldInfoPtr_SelectedTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_destination;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_destinationGen;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_positionInParent;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTargets;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_Nullable_1_Int32_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Entity_Entity_Match_Nullable_1_Int32_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_GetMoveTargets_Protected_Virtual_New_IEnumerable_1_Entity_Context_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetsFromQueue_Private_IEnumerable_1_Entity_TargetResponseQueue_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0;

		// Token: 0x020003F3 RID: 1011
		[ObfuscatedName("Canis.actions.MoveMultiple+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002B63 RID: 11107 RVA: 0x000B90B8 File Offset: 0x000B72B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr);
				MoveMultiple.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr, "<>9");
				MoveMultiple.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr, "<>9__9_0");
				MoveMultiple.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr, 100667367);
				MoveMultiple.__c.NativeMethodInfoPtr__MakeSerializedAction_b__9_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr, 100667368);
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x000B9134 File Offset: 0x000B7334
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x000B9170 File Offset: 0x000B7370
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedAction_b__9_0(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.__c.NativeMethodInfoPtr__MakeSerializedAction_b__9_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x00014C26 File Offset: 0x00012E26
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000B91C0 File Offset: 0x000B73C0
			// (set) Token: 0x06002B68 RID: 11112 RVA: 0x00014C2F File Offset: 0x00012E2F
			public unsafe static MoveMultiple.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoveMultiple.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveMultiple.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoveMultiple.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000B91E8 File Offset: 0x000B73E8
			// (set) Token: 0x06002B6A RID: 11114 RVA: 0x00014C41 File Offset: 0x00012E41
			public unsafe static Func<Entity, EntityID> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoveMultiple.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoveMultiple.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B1E RID: 6942
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B1F RID: 6943
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001B20 RID: 6944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B21 RID: 6945
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__9_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x020003F4 RID: 1012
		[ObfuscatedName("Canis.actions.MoveMultiple+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002B6B RID: 11115 RVA: 0x000B9210 File Offset: 0x000B7410
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr);
				MoveMultiple.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr, "selectedTarget");
				MoveMultiple.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr, 100667369);
				MoveMultiple.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr, 100667370);
			}

			// Token: 0x06002B6C RID: 11116 RVA: 0x000B9278 File Offset: 0x000B7478
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B6D RID: 11117 RVA: 0x000B92B4 File Offset: 0x000B74B4
			[CallerCount(0)]
			public unsafe bool _execute_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B6E RID: 11118 RVA: 0x00014C53 File Offset: 0x00012E53
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000B9304 File Offset: 0x000B7504
			// (set) Token: 0x06002B70 RID: 11120 RVA: 0x00014C5C File Offset: 0x00012E5C
			public unsafe Entity selectedTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B22 RID: 6946
			private static readonly IntPtr NativeFieldInfoPtr_selectedTarget;

			// Token: 0x04001B23 RID: 6947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B24 RID: 6948
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020003F5 RID: 1013
		[ObfuscatedName("Canis.actions.MoveMultiple+<GetMoveTargets>d__7")]
		public sealed class _GetMoveTargets_d__7 : Object
		{
			// Token: 0x06002B71 RID: 11121 RVA: 0x000B9334 File Offset: 0x000B7534
			// Note: this type is marked as 'beforefieldinit'.
			static _GetMoveTargets_d__7()
			{
				Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "<GetMoveTargets>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr);
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>1__state");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>2__current");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>l__initialThreadId");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "context");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>3__context");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>4__this");
				MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, "<>7__wrap1");
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667371);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667372);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667373);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667374);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667375);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667376);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667377);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667378);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667379);
				MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr, 100667380);
			}

			// Token: 0x06002B72 RID: 11122 RVA: 0x000B94B4 File Offset: 0x000B76B4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetMoveTargets_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple._GetMoveTargets_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B73 RID: 11123 RVA: 0x000B94FC File Offset: 0x000B76FC
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B74 RID: 11124 RVA: 0x000B9530 File Offset: 0x000B7730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586154, XrefRangeEnd = 586210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B75 RID: 11125 RVA: 0x000B956C File Offset: 0x000B776C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586210, XrefRangeEnd = 586213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B76 RID: 11126 RVA: 0x000B95A0 File Offset: 0x000B77A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586213, XrefRangeEnd = 586216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000B95D4 File Offset: 0x000B77D4
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002B78 RID: 11128 RVA: 0x000B9614 File Offset: 0x000B7814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586216, XrefRangeEnd = 586221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000B9648 File Offset: 0x000B7848
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B7A RID: 11130 RVA: 0x000B9688 File Offset: 0x000B7888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586221, XrefRangeEnd = 586230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x06002B7B RID: 11131 RVA: 0x000B96C8 File Offset: 0x000B78C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetMoveTargets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B7C RID: 11132 RVA: 0x00014C7B File Offset: 0x00012E7B
			public _GetMoveTargets_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000B9708 File Offset: 0x000B7908
			// (set) Token: 0x06002B7E RID: 11134 RVA: 0x00014C84 File Offset: 0x00012E84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000B9730 File Offset: 0x000B7930
			// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00014C9F File Offset: 0x00012E9F
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000B9760 File Offset: 0x000B7960
			// (set) Token: 0x06002B82 RID: 11138 RVA: 0x00014CBE File Offset: 0x00012EBE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000B9788 File Offset: 0x000B7988
			// (set) Token: 0x06002B84 RID: 11140 RVA: 0x00014CD9 File Offset: 0x00012ED9
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000B97B8 File Offset: 0x000B79B8
			// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00014CF8 File Offset: 0x00012EF8
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000B97E8 File Offset: 0x000B79E8
			// (set) Token: 0x06002B88 RID: 11144 RVA: 0x00014D17 File Offset: 0x00012F17
			public unsafe MoveMultiple __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveMultiple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000B9818 File Offset: 0x000B7A18
			// (set) Token: 0x06002B8A RID: 11146 RVA: 0x00014D36 File Offset: 0x00012F36
			public unsafe IEnumerator<Entity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetMoveTargets_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B25 RID: 6949
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B26 RID: 6950
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B27 RID: 6951
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001B28 RID: 6952
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001B29 RID: 6953
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001B2A RID: 6954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B2B RID: 6955
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001B2C RID: 6956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B2D RID: 6957
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B2E RID: 6958
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B2F RID: 6959
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001B30 RID: 6960
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001B31 RID: 6961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x04001B32 RID: 6962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B33 RID: 6963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B34 RID: 6964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x04001B35 RID: 6965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("Canis.actions.MoveMultiple+<GetTargetsFromQueue>d__8")]
		public sealed class _GetTargetsFromQueue_d__8 : Object
		{
			// Token: 0x06002B8B RID: 11147 RVA: 0x000B9848 File Offset: 0x000B7A48
			// Note: this type is marked as 'beforefieldinit'.
			static _GetTargetsFromQueue_d__8()
			{
				Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "<GetTargetsFromQueue>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>1__state");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>2__current");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>l__initialThreadId");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr_trq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "trq");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___3__trq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>3__trq");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>4__this");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>7__wrap1");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, "<>7__wrap2");
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667381);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667382);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667383);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667384);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667385);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667386);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667387);
				MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr, 100667388);
			}

			// Token: 0x06002B8C RID: 11148 RVA: 0x000B99B4 File Offset: 0x000B7BB4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetTargetsFromQueue_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple._GetTargetsFromQueue_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B8D RID: 11149 RVA: 0x000B99FC File Offset: 0x000B7BFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8E RID: 11150 RVA: 0x000B9A30 File Offset: 0x000B7C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586230, XrefRangeEnd = 586246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000B9A6C File Offset: 0x000B7C6C
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002B90 RID: 11152 RVA: 0x000B9AAC File Offset: 0x000B7CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586246, XrefRangeEnd = 586251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000B9AE0 File Offset: 0x000B7CE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B92 RID: 11154 RVA: 0x000B9B20 File Offset: 0x000B7D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586251, XrefRangeEnd = 586260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x06002B93 RID: 11155 RVA: 0x000B9B60 File Offset: 0x000B7D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._GetTargetsFromQueue_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B94 RID: 11156 RVA: 0x00014D55 File Offset: 0x00012F55
			public _GetTargetsFromQueue_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000B9BA0 File Offset: 0x000B7DA0
			// (set) Token: 0x06002B96 RID: 11158 RVA: 0x00014D5E File Offset: 0x00012F5E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000B9BC8 File Offset: 0x000B7DC8
			// (set) Token: 0x06002B98 RID: 11160 RVA: 0x00014D79 File Offset: 0x00012F79
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
			// (set) Token: 0x06002B9A RID: 11162 RVA: 0x00014D98 File Offset: 0x00012F98
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000B9C20 File Offset: 0x000B7E20
			// (set) Token: 0x06002B9C RID: 11164 RVA: 0x00014DB3 File Offset: 0x00012FB3
			public unsafe TargetResponseQueue trq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr_trq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr_trq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000B9C50 File Offset: 0x000B7E50
			// (set) Token: 0x06002B9E RID: 11166 RVA: 0x00014DD2 File Offset: 0x00012FD2
			public unsafe TargetResponseQueue __3__trq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___3__trq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___3__trq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000B9C80 File Offset: 0x000B7E80
			// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x00014DF1 File Offset: 0x00012FF1
			public unsafe MoveMultiple __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveMultiple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000B9CB0 File Offset: 0x000B7EB0
			// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00014E10 File Offset: 0x00013010
			public unsafe Il2CppReferenceArray<EntityID> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000B9CE0 File Offset: 0x000B7EE0
			// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00014E2F File Offset: 0x0001302F
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._GetTargetsFromQueue_d__8.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x04001B36 RID: 6966
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B37 RID: 6967
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B38 RID: 6968
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001B39 RID: 6969
			private static readonly IntPtr NativeFieldInfoPtr_trq;

			// Token: 0x04001B3A RID: 6970
			private static readonly IntPtr NativeFieldInfoPtr___3__trq;

			// Token: 0x04001B3B RID: 6971
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B3C RID: 6972
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001B3D RID: 6973
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001B3E RID: 6974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B3F RID: 6975
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B40 RID: 6976
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B41 RID: 6977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x04001B42 RID: 6978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B43 RID: 6979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B44 RID: 6980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x04001B45 RID: 6981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020003F7 RID: 1015
		[ObfuscatedName("Canis.actions.MoveMultiple+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002BA5 RID: 11173 RVA: 0x000B9D08 File Offset: 0x000B7F08
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveMultiple>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr);
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>1__state");
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>2__current");
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>l__initialThreadId");
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>4__this");
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>8__1");
				MoveMultiple._execute_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, "<>7__wrap1");
				MoveMultiple._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667389);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667390);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667391);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667392);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667393);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667394);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667395);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667396);
				MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr, 100667397);
			}

			// Token: 0x06002BA6 RID: 11174 RVA: 0x000B9E60 File Offset: 0x000B8060
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveMultiple._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BA7 RID: 11175 RVA: 0x000B9EA8 File Offset: 0x000B80A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586260, XrefRangeEnd = 586265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BA8 RID: 11176 RVA: 0x000B9EDC File Offset: 0x000B80DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586265, XrefRangeEnd = 586336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BA9 RID: 11177 RVA: 0x000B9F18 File Offset: 0x000B8118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586336, XrefRangeEnd = 586339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000B9F4C File Offset: 0x000B814C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002BAB RID: 11179 RVA: 0x000B9F8C File Offset: 0x000B818C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586339, XrefRangeEnd = 586344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06002BAC RID: 11180 RVA: 0x000B9FC0 File Offset: 0x000B81C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BAD RID: 11181 RVA: 0x000BA000 File Offset: 0x000B8200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586344, XrefRangeEnd = 586346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002BAE RID: 11182 RVA: 0x000BA040 File Offset: 0x000B8240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveMultiple._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002BAF RID: 11183 RVA: 0x00014E4A File Offset: 0x0001304A
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000BA080 File Offset: 0x000B8280
			// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00014E53 File Offset: 0x00013053
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x000BA0A8 File Offset: 0x000B82A8
			// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00014E6E File Offset: 0x0001306E
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000BA0D8 File Offset: 0x000B82D8
			// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00014E8D File Offset: 0x0001308D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000BA100 File Offset: 0x000B8300
			// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00014EA8 File Offset: 0x000130A8
			public unsafe MoveMultiple __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveMultiple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000BA130 File Offset: 0x000B8330
			// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00014EC7 File Offset: 0x000130C7
			public unsafe MoveMultiple.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveMultiple.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000BA160 File Offset: 0x000B8360
			// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00014EE6 File Offset: 0x000130E6
			public unsafe IEnumerator<Entity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveMultiple._execute_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B46 RID: 6982
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B47 RID: 6983
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B48 RID: 6984
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001B49 RID: 6985
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B4A RID: 6986
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001B4B RID: 6987
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001B4C RID: 6988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B4D RID: 6989
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B4E RID: 6990
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B4F RID: 6991
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001B50 RID: 6992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001B51 RID: 6993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B52 RID: 6994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B53 RID: 6995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001B54 RID: 6996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

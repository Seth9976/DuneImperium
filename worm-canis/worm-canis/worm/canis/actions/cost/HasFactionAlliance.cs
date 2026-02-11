using System;
using Canis;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.actions.cost
{
	// Token: 0x020002F2 RID: 754
	public class HasFactionAlliance : CostAction
	{
		// Token: 0x06001EF7 RID: 7927 RVA: 0x000D1A2C File Offset: 0x000CFC2C
		// Note: this type is marked as 'beforefieldinit'.
		static HasFactionAlliance()
		{
			Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "HasFactionAlliance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr);
			HasFactionAlliance.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr, "faction");
			HasFactionAlliance.NativeMethodInfoPtr__ctor_Public_Void_Factions_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr, 100670624);
			HasFactionAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr, 100670625);
			HasFactionAlliance.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr, 100670626);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000D1AAC File Offset: 0x000CFCAC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 142727, RefRangeEnd = 142766, XrefRangeStart = 142727, XrefRangeEnd = 142766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasFactionAlliance(Factions faction, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance.NativeMethodInfoPtr__ctor_Public_Void_Factions_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000D1B08 File Offset: 0x000CFD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172386, XrefRangeEnd = 172391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasFactionAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000D1B54 File Offset: 0x000CFD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172391, XrefRangeEnd = 172399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasFactionAlliance.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0000CF88 File Offset: 0x0000B188
		public HasFactionAlliance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x000D1BAC File Offset: 0x000CFDAC
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0000CF91 File Offset: 0x0000B191
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Factions_Match_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x0200079C RID: 1948
		[ObfuscatedName("worm.canis.actions.cost.HasFactionAlliance+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06006E0B RID: 28171 RVA: 0x00203C20 File Offset: 0x00201E20
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasFactionAlliance>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr);
				HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, "<>1__state");
				HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, "<>2__current");
				HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670627);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670628);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670629);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670630);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670631);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670632);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670633);
				HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr, 100670634);
			}

			// Token: 0x06006E0C RID: 28172 RVA: 0x00203D28 File Offset: 0x00201F28
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFactionAlliance._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006E0D RID: 28173 RVA: 0x00203D70 File Offset: 0x00201F70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006E0E RID: 28174 RVA: 0x00203DA4 File Offset: 0x00201FA4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E29 RID: 7721
			// (get) Token: 0x06006E0F RID: 28175 RVA: 0x00203DE0 File Offset: 0x00201FE0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006E10 RID: 28176 RVA: 0x00203E20 File Offset: 0x00202020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172379, XrefRangeEnd = 172384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E2A RID: 7722
			// (get) Token: 0x06006E11 RID: 28177 RVA: 0x00203E54 File Offset: 0x00202054
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006E12 RID: 28178 RVA: 0x00203E94 File Offset: 0x00202094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172384, XrefRangeEnd = 172386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006E13 RID: 28179 RVA: 0x00203ED4 File Offset: 0x002020D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasFactionAlliance._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006E14 RID: 28180 RVA: 0x0002BC50 File Offset: 0x00029E50
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E26 RID: 7718
			// (get) Token: 0x06006E15 RID: 28181 RVA: 0x00203F14 File Offset: 0x00202114
			// (set) Token: 0x06006E16 RID: 28182 RVA: 0x0002BC59 File Offset: 0x00029E59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E27 RID: 7719
			// (get) Token: 0x06006E17 RID: 28183 RVA: 0x00203F3C File Offset: 0x0020213C
			// (set) Token: 0x06006E18 RID: 28184 RVA: 0x0002BC74 File Offset: 0x00029E74
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E28 RID: 7720
			// (get) Token: 0x06006E19 RID: 28185 RVA: 0x00203F6C File Offset: 0x0020216C
			// (set) Token: 0x06006E1A RID: 28186 RVA: 0x0002BC93 File Offset: 0x00029E93
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasFactionAlliance._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04004716 RID: 18198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004717 RID: 18199
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004718 RID: 18200
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004719 RID: 18201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400471A RID: 18202
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400471B RID: 18203
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400471C RID: 18204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400471D RID: 18205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400471E RID: 18206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400471F RID: 18207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004720 RID: 18208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis.actions;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000244 RID: 580
	public static class ResourceActions : Object
	{
		// Token: 0x06001946 RID: 6470 RVA: 0x000BB3E4 File Offset: 0x000B95E4
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceActions()
		{
			Il2CppClassPointerStore<ResourceActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ResourceActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActions>.NativeClassPtr);
			ResourceActions.NativeFieldInfoPtr_ResourceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions>.NativeClassPtr, "ResourceNames");
			ResourceActions.NativeMethodInfoPtr_Make_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_AttributeDefinition_1_Nullable_1_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions>.NativeClassPtr, 100667849);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000BB43C File Offset: 0x000B963C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136120, RefRangeEnd = 136124, XrefRangeStart = 136111, XrefRangeEnd = 136120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Canis.actions.Action> Make(WormMatch wm, WormPlayer player, AttributeDefinition<Nullable<int>> attribute, int amount, string sequenceNameOverride = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceNameOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions.NativeMethodInfoPtr_Make_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_AttributeDefinition_1_Nullable_1_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0000ADF1 File Offset: 0x00008FF1
		public ResourceActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x000BB4C8 File Offset: 0x000B96C8
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0000ADFA File Offset: 0x00008FFA
		public unsafe static Dictionary<AttributeDefinition<Nullable<int>>, string> ResourceNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceActions.NativeFieldInfoPtr_ResourceNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AttributeDefinition<Nullable<int>>, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceActions.NativeFieldInfoPtr_ResourceNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr_ResourceNames;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_Make_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_AttributeDefinition_1_Nullable_1_Int32_Int32_String_0;

		// Token: 0x02000681 RID: 1665
		[ObfuscatedName("worm.canis.actions.ResourceActions+<Make>d__0")]
		public sealed class _Make_d__0 : Object
		{
			// Token: 0x060055F3 RID: 22003 RVA: 0x001BAD00 File Offset: 0x001B8F00
			// Note: this type is marked as 'beforefieldinit'.
			static _Make_d__0()
			{
				Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceActions>.NativeClassPtr, "<Make>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr);
				ResourceActions._Make_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>1__state");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>2__current");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>l__initialThreadId");
				ResourceActions._Make_d__0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "amount");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___3__amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>3__amount");
				ResourceActions._Make_d__0.NativeFieldInfoPtr_sequenceNameOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "sequenceNameOverride");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___3__sequenceNameOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>3__sequenceNameOverride");
				ResourceActions._Make_d__0.NativeFieldInfoPtr_wm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "wm");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___3__wm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>3__wm");
				ResourceActions._Make_d__0.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "attribute");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___3__attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>3__attribute");
				ResourceActions._Make_d__0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "player");
				ResourceActions._Make_d__0.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<>3__player");
				ResourceActions._Make_d__0.NativeFieldInfoPtr__isGain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<isGain>5__2");
				ResourceActions._Make_d__0.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, "<sequenceHelper>5__3");
				ResourceActions._Make_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667851);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667852);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667853);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667854);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667855);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667856);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667857);
				ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr, 100667858);
			}

			// Token: 0x060055F4 RID: 22004 RVA: 0x001BAEF8 File Offset: 0x001B90F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Make_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceActions._Make_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055F5 RID: 22005 RVA: 0x001BAF40 File Offset: 0x001B9140
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055F6 RID: 22006 RVA: 0x001BAF74 File Offset: 0x001B9174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136061, XrefRangeEnd = 136095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015BA RID: 5562
			// (get) Token: 0x060055F7 RID: 22007 RVA: 0x001BAFB0 File Offset: 0x001B91B0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060055F8 RID: 22008 RVA: 0x001BAFF0 File Offset: 0x001B91F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136095, XrefRangeEnd = 136100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015BB RID: 5563
			// (get) Token: 0x060055F9 RID: 22009 RVA: 0x001BB024 File Offset: 0x001B9224
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055FA RID: 22010 RVA: 0x001BB064 File Offset: 0x001B9264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136100, XrefRangeEnd = 136111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060055FB RID: 22011 RVA: 0x001BB0A4 File Offset: 0x001B92A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActions._Make_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055FC RID: 22012 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
			public _Make_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015AB RID: 5547
			// (get) Token: 0x060055FD RID: 22013 RVA: 0x001BB0E4 File Offset: 0x001B92E4
			// (set) Token: 0x060055FE RID: 22014 RVA: 0x0001EBB9 File Offset: 0x0001CDB9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015AC RID: 5548
			// (get) Token: 0x060055FF RID: 22015 RVA: 0x001BB10C File Offset: 0x001B930C
			// (set) Token: 0x06005600 RID: 22016 RVA: 0x0001EBD4 File Offset: 0x0001CDD4
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AD RID: 5549
			// (get) Token: 0x06005601 RID: 22017 RVA: 0x001BB13C File Offset: 0x001B933C
			// (set) Token: 0x06005602 RID: 22018 RVA: 0x0001EBF3 File Offset: 0x0001CDF3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015AE RID: 5550
			// (get) Token: 0x06005603 RID: 22019 RVA: 0x001BB164 File Offset: 0x001B9364
			// (set) Token: 0x06005604 RID: 22020 RVA: 0x0001EC0E File Offset: 0x0001CE0E
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x170015AF RID: 5551
			// (get) Token: 0x06005605 RID: 22021 RVA: 0x001BB18C File Offset: 0x001B938C
			// (set) Token: 0x06005606 RID: 22022 RVA: 0x0001EC29 File Offset: 0x0001CE29
			public unsafe int __3__amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__amount)) = value;
				}
			}

			// Token: 0x170015B0 RID: 5552
			// (get) Token: 0x06005607 RID: 22023 RVA: 0x001BB1B4 File Offset: 0x001B93B4
			// (set) Token: 0x06005608 RID: 22024 RVA: 0x0001EC44 File Offset: 0x0001CE44
			public unsafe string sequenceNameOverride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_sequenceNameOverride);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_sequenceNameOverride), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015B1 RID: 5553
			// (get) Token: 0x06005609 RID: 22025 RVA: 0x001BB1DC File Offset: 0x001B93DC
			// (set) Token: 0x0600560A RID: 22026 RVA: 0x0001EC63 File Offset: 0x0001CE63
			public unsafe string __3__sequenceNameOverride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__sequenceNameOverride);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__sequenceNameOverride), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015B2 RID: 5554
			// (get) Token: 0x0600560B RID: 22027 RVA: 0x001BB204 File Offset: 0x001B9404
			// (set) Token: 0x0600560C RID: 22028 RVA: 0x0001EC82 File Offset: 0x0001CE82
			public unsafe WormMatch wm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_wm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_wm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B3 RID: 5555
			// (get) Token: 0x0600560D RID: 22029 RVA: 0x001BB234 File Offset: 0x001B9434
			// (set) Token: 0x0600560E RID: 22030 RVA: 0x0001ECA1 File Offset: 0x0001CEA1
			public unsafe WormMatch __3__wm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__wm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__wm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B4 RID: 5556
			// (get) Token: 0x0600560F RID: 22031 RVA: 0x001BB264 File Offset: 0x001B9464
			// (set) Token: 0x06005610 RID: 22032 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
			public unsafe AttributeDefinition<Nullable<int>> attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_attribute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B5 RID: 5557
			// (get) Token: 0x06005611 RID: 22033 RVA: 0x001BB294 File Offset: 0x001B9494
			// (set) Token: 0x06005612 RID: 22034 RVA: 0x0001ECDF File Offset: 0x0001CEDF
			public unsafe AttributeDefinition<Nullable<int>> __3__attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__attribute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B6 RID: 5558
			// (get) Token: 0x06005613 RID: 22035 RVA: 0x001BB2C4 File Offset: 0x001B94C4
			// (set) Token: 0x06005614 RID: 22036 RVA: 0x0001ECFE File Offset: 0x0001CEFE
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B7 RID: 5559
			// (get) Token: 0x06005615 RID: 22037 RVA: 0x001BB2F4 File Offset: 0x001B94F4
			// (set) Token: 0x06005616 RID: 22038 RVA: 0x0001ED1D File Offset: 0x0001CF1D
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B8 RID: 5560
			// (get) Token: 0x06005617 RID: 22039 RVA: 0x001BB324 File Offset: 0x001B9524
			// (set) Token: 0x06005618 RID: 22040 RVA: 0x0001ED3C File Offset: 0x0001CF3C
			public unsafe bool _isGain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr__isGain_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr__isGain_5__2)) = value;
				}
			}

			// Token: 0x170015B9 RID: 5561
			// (get) Token: 0x06005619 RID: 22041 RVA: 0x001BB34C File Offset: 0x001B954C
			// (set) Token: 0x0600561A RID: 22042 RVA: 0x0001ED57 File Offset: 0x0001CF57
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActions._Make_d__0.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003823 RID: 14371
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003824 RID: 14372
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003825 RID: 14373
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003826 RID: 14374
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04003827 RID: 14375
			private static readonly IntPtr NativeFieldInfoPtr___3__amount;

			// Token: 0x04003828 RID: 14376
			private static readonly IntPtr NativeFieldInfoPtr_sequenceNameOverride;

			// Token: 0x04003829 RID: 14377
			private static readonly IntPtr NativeFieldInfoPtr___3__sequenceNameOverride;

			// Token: 0x0400382A RID: 14378
			private static readonly IntPtr NativeFieldInfoPtr_wm;

			// Token: 0x0400382B RID: 14379
			private static readonly IntPtr NativeFieldInfoPtr___3__wm;

			// Token: 0x0400382C RID: 14380
			private static readonly IntPtr NativeFieldInfoPtr_attribute;

			// Token: 0x0400382D RID: 14381
			private static readonly IntPtr NativeFieldInfoPtr___3__attribute;

			// Token: 0x0400382E RID: 14382
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400382F RID: 14383
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003830 RID: 14384
			private static readonly IntPtr NativeFieldInfoPtr__isGain_5__2;

			// Token: 0x04003831 RID: 14385
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x04003832 RID: 14386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003833 RID: 14387
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003834 RID: 14388
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003835 RID: 14389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003836 RID: 14390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003837 RID: 14391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003838 RID: 14392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003839 RID: 14393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

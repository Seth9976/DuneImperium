using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.obfuscation
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class DescendantsVisibility : Object
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		// Note: this type is marked as 'beforefieldinit'.
		static DescendantsVisibility()
		{
			Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "DescendantsVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr);
			DescendantsVisibility.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Abstract_Virtual_New_Visibility_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, 100664428);
			DescendantsVisibility.NativeMethodInfoPtr_EntityChildrenHidden_Public_Abstract_Virtual_New_Boolean_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, 100664429);
			DescendantsVisibility.NativeMethodInfoPtr_NumChildrenHidden_Public_Abstract_Virtual_New_Int32_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, 100664430);
			DescendantsVisibility.NativeMethodInfoPtr_PostMove_Public_Virtual_New_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, 100664431);
			DescendantsVisibility.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, 100664432);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0002EB7C File Offset: 0x0002CD7C
		[CallerCount(0)]
		public unsafe virtual Visibility MakeVisibilityForDescendent(EntityID ancestor, EntityID descendent, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescendantsVisibility.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Abstract_Virtual_New_Visibility_EntityID_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		[CallerCount(0)]
		public unsafe virtual bool EntityChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescendantsVisibility.NativeMethodInfoPtr_EntityChildrenHidden_Public_Abstract_Virtual_New_Boolean_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0002EC78 File Offset: 0x0002CE78
		[CallerCount(0)]
		public unsafe virtual int NumChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescendantsVisibility.NativeMethodInfoPtr_NumChildrenHidden_Public_Abstract_Virtual_New_Int32_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0002ECF4 File Offset: 0x0002CEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554870, XrefRangeEnd = 554875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<NetworkMessageEvent> PostMove(EntityMoved entityMoved, EntityID parentID, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityMoved);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescendantsVisibility.NativeMethodInfoPtr_PostMove_Public_Virtual_New_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0002ED88 File Offset: 0x0002CF88
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DescendantsVisibility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000464F File Offset: 0x0000284F
		public DescendantsVisibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Abstract_Virtual_New_Visibility_EntityID_EntityID_Match_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Abstract_Virtual_New_Boolean_EntityID_AccountID_Match_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Abstract_Virtual_New_Int32_EntityID_AccountID_Match_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_PostMove_Public_Virtual_New_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002BD RID: 701
		[ObfuscatedName("Canis.obfuscation.DescendantsVisibility+<PostMove>d__3")]
		public sealed class _PostMove_d__3 : Object
		{
			// Token: 0x06001D9F RID: 7583 RVA: 0x0008ACC4 File Offset: 0x00088EC4
			// Note: this type is marked as 'beforefieldinit'.
			static _PostMove_d__3()
			{
				Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescendantsVisibility>.NativeClassPtr, "<PostMove>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr);
				DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, "<>1__state");
				DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, "<>2__current");
				DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, "<>l__initialThreadId");
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664433);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664434);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664435);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664436);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664437);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664438);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664439);
				DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr, 100664440);
			}

			// Token: 0x06001DA0 RID: 7584 RVA: 0x0008ADCC File Offset: 0x00088FCC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostMove_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescendantsVisibility._PostMove_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DA1 RID: 7585 RVA: 0x0008AE14 File Offset: 0x00089014
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA2 RID: 7586 RVA: 0x0008AE48 File Offset: 0x00089048
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0008AE84 File Offset: 0x00089084
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x0008AEC4 File Offset: 0x000890C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554863, XrefRangeEnd = 554868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0008AEF8 File Offset: 0x000890F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x0008AF38 File Offset: 0x00089138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554868, XrefRangeEnd = 554870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x06001DA7 RID: 7591 RVA: 0x0008AF78 File Offset: 0x00089178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsVisibility._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001DA8 RID: 7592 RVA: 0x0000E3A7 File Offset: 0x0000C5A7
			public _PostMove_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0008AFB8 File Offset: 0x000891B8
			// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0008AFE0 File Offset: 0x000891E0
			// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000E3CB File Offset: 0x0000C5CB
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0008B010 File Offset: 0x00089210
			// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000E3EA File Offset: 0x0000C5EA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsVisibility._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

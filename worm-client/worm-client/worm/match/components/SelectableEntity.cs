using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.components
{
	// Token: 0x020001BD RID: 445
	public class SelectableEntity : Observer
	{
		// Token: 0x0600139B RID: 5019 RVA: 0x00053AC4 File Offset: 0x00051CC4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableEntity()
		{
			Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "SelectableEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr);
			SelectableEntity.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, "selectionResponder");
			SelectableEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, 100665980);
			SelectableEntity.NativeMethodInfoPtr_Event_AttemptSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, 100665981);
			SelectableEntity.NativeMethodInfoPtr_SubmitSelection_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, 100665982);
			SelectableEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, 100665983);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00053B58 File Offset: 0x00051D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713223, XrefRangeEnd = 713227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableEntity.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00053B94 File Offset: 0x00051D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713227, XrefRangeEnd = 713237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AttemptSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity.NativeMethodInfoPtr_Event_AttemptSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00053BC8 File Offset: 0x00051DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713237, XrefRangeEnd = 713242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SubmitSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity.NativeMethodInfoPtr_SubmitSelection_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00053C08 File Offset: 0x00051E08
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0000C188 File Offset: 0x0000A388
		public SelectableEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00053C44 File Offset: 0x00051E44
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x0000C191 File Offset: 0x0000A391
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_Event_AttemptSelection_Public_Void_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_SubmitSelection_Private_IEnumerator_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CA RID: 970
		[ObfuscatedName("worm.match.components.SelectableEntity+<SubmitSelection>d__3")]
		public sealed class _SubmitSelection_d__3 : Object
		{
			// Token: 0x0600273F RID: 10047 RVA: 0x0008F358 File Offset: 0x0008D558
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitSelection_d__3()
			{
				Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectableEntity>.NativeClassPtr, "<SubmitSelection>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr);
				SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, "<>1__state");
				SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, "<>2__current");
				SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, "<>4__this");
				SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr__submitConfirmation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, "<submitConfirmation>5__2");
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665984);
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665985);
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665986);
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665987);
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665988);
				SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr, 100665989);
			}

			// Token: 0x06002740 RID: 10048 RVA: 0x0008F44C File Offset: 0x0008D64C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SubmitSelection_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableEntity._SubmitSelection_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002741 RID: 10049 RVA: 0x0008F494 File Offset: 0x0008D694
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002742 RID: 10050 RVA: 0x0008F4C8 File Offset: 0x0008D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713202, XrefRangeEnd = 713218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x06002743 RID: 10051 RVA: 0x0008F504 File Offset: 0x0008D704
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002744 RID: 10052 RVA: 0x0008F544 File Offset: 0x0008D744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713218, XrefRangeEnd = 713223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x06002745 RID: 10053 RVA: 0x0008F578 File Offset: 0x0008D778
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableEntity._SubmitSelection_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002746 RID: 10054 RVA: 0x0001597F File Offset: 0x00013B7F
			public _SubmitSelection_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06002747 RID: 10055 RVA: 0x0008F5B8 File Offset: 0x0008D7B8
			// (set) Token: 0x06002748 RID: 10056 RVA: 0x00015988 File Offset: 0x00013B88
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06002749 RID: 10057 RVA: 0x0008F5E0 File Offset: 0x0008D7E0
			// (set) Token: 0x0600274A RID: 10058 RVA: 0x000159A3 File Offset: 0x00013BA3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x0600274B RID: 10059 RVA: 0x0008F610 File Offset: 0x0008D810
			// (set) Token: 0x0600274C RID: 10060 RVA: 0x000159C2 File Offset: 0x00013BC2
			public unsafe SelectableEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectableEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x0600274D RID: 10061 RVA: 0x0008F640 File Offset: 0x0008D840
			// (set) Token: 0x0600274E RID: 10062 RVA: 0x000159E1 File Offset: 0x00013BE1
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr__submitConfirmation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableEntity._SubmitSelection_d__3.NativeFieldInfoPtr__submitConfirmation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__2;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lib.canis.dbg_client.match.selection
{
	// Token: 0x02000038 RID: 56
	public class CompositeTargetInfoListsSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06000242 RID: 578 RVA: 0x00024C30 File Offset: 0x00022E30
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeTargetInfoListsSelectionCommand()
		{
			Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.match.selection", "CompositeTargetInfoListsSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr);
			CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr, 100663660);
			CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr, 100663661);
			CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr, 100663662);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00024C9C File Offset: 0x00022E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498303, XrefRangeEnd = 498304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeTargetInfoListsSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00024CF8 File Offset: 0x00022EF8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00024D40 File Offset: 0x00022F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498304, XrefRangeEnd = 498309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListsSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002FAA File Offset: 0x000011AA
		public CompositeTargetInfoListsSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x020002DD RID: 733
		[ObfuscatedName("lib.canis.dbg_client.match.selection.CompositeTargetInfoListsSelectionCommand+<idle>d__2")]
		public sealed class _idle_d__2 : Object
		{
			// Token: 0x06002273 RID: 8819 RVA: 0x0008F8FC File Offset: 0x0008DAFC
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__2()
			{
				Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand>.NativeClassPtr, "<idle>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, "<>1__state");
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, "<>2__current");
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, "<>4__this");
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663663);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663664);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663665);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663666);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663667);
				CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr, 100663668);
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x0008F9DC File Offset: 0x0008DBDC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInfoListsSelectionCommand._idle_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x0008FA24 File Offset: 0x0008DC24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x0008FA58 File Offset: 0x0008DC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498246, XrefRangeEnd = 498298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x06002277 RID: 8823 RVA: 0x0008FA94 File Offset: 0x0008DC94
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002278 RID: 8824 RVA: 0x0008FAD4 File Offset: 0x0008DCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498298, XrefRangeEnd = 498303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x06002279 RID: 8825 RVA: 0x0008FB08 File Offset: 0x0008DD08
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600227A RID: 8826 RVA: 0x00011F58 File Offset: 0x00010158
			public _idle_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x0600227B RID: 8827 RVA: 0x0008FB48 File Offset: 0x0008DD48
			// (set) Token: 0x0600227C RID: 8828 RVA: 0x00011F61 File Offset: 0x00010161
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x0600227D RID: 8829 RVA: 0x0008FB70 File Offset: 0x0008DD70
			// (set) Token: 0x0600227E RID: 8830 RVA: 0x00011F7C File Offset: 0x0001017C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x0600227F RID: 8831 RVA: 0x0008FBA0 File Offset: 0x0008DDA0
			// (set) Token: 0x06002280 RID: 8832 RVA: 0x00011F9B File Offset: 0x0001019B
			public unsafe CompositeTargetInfoListsSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeTargetInfoListsSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

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

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030B RID: 779
	public class IsFaceUp : CostAction
	{
		// Token: 0x06001FE6 RID: 8166 RVA: 0x000D5B8C File Offset: 0x000D3D8C
		// Note: this type is marked as 'beforefieldinit'.
		static IsFaceUp()
		{
			Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "IsFaceUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr);
			IsFaceUp.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr, 100671028);
			IsFaceUp.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr, 100671029);
			IsFaceUp.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr, 100671030);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000D5BF8 File Offset: 0x000D3DF8
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsFaceUp(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000D5C44 File Offset: 0x000D3E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174506, XrefRangeEnd = 174511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsFaceUp.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000D5C90 File Offset: 0x000D3E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174511, XrefRangeEnd = 174518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsFaceUp.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0000D405 File Offset: 0x0000B605
		public IsFaceUp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x020007C3 RID: 1987
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.IsFaceUp+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06007080 RID: 28800 RVA: 0x0020C1C8 File Offset: 0x0020A3C8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IsFaceUp>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr);
				IsFaceUp._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, "<>1__state");
				IsFaceUp._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, "<>2__current");
				IsFaceUp._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
				IsFaceUp._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671031);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671032);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671033);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671034);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671035);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671036);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671037);
				IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr, 100671038);
			}

			// Token: 0x06007081 RID: 28801 RVA: 0x0020C2D0 File Offset: 0x0020A4D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsFaceUp._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007082 RID: 28802 RVA: 0x0020C318 File Offset: 0x0020A518
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007083 RID: 28803 RVA: 0x0020C34C File Offset: 0x0020A54C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EE9 RID: 7913
			// (get) Token: 0x06007084 RID: 28804 RVA: 0x0020C388 File Offset: 0x0020A588
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007085 RID: 28805 RVA: 0x0020C3C8 File Offset: 0x0020A5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174499, XrefRangeEnd = 174504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EEA RID: 7914
			// (get) Token: 0x06007086 RID: 28806 RVA: 0x0020C3FC File Offset: 0x0020A5FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007087 RID: 28807 RVA: 0x0020C43C File Offset: 0x0020A63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174504, XrefRangeEnd = 174506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007088 RID: 28808 RVA: 0x0020C47C File Offset: 0x0020A67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsFaceUp._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007089 RID: 28809 RVA: 0x0002CADE File Offset: 0x0002ACDE
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EE6 RID: 7910
			// (get) Token: 0x0600708A RID: 28810 RVA: 0x0020C4BC File Offset: 0x0020A6BC
			// (set) Token: 0x0600708B RID: 28811 RVA: 0x0002CAE7 File Offset: 0x0002ACE7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EE7 RID: 7911
			// (get) Token: 0x0600708C RID: 28812 RVA: 0x0020C4E4 File Offset: 0x0020A6E4
			// (set) Token: 0x0600708D RID: 28813 RVA: 0x0002CB02 File Offset: 0x0002AD02
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EE8 RID: 7912
			// (get) Token: 0x0600708E RID: 28814 RVA: 0x0020C514 File Offset: 0x0020A714
			// (set) Token: 0x0600708F RID: 28815 RVA: 0x0002CB21 File Offset: 0x0002AD21
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsFaceUp._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040048AF RID: 18607
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040048B0 RID: 18608
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040048B1 RID: 18609
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040048B2 RID: 18610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040048B3 RID: 18611
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048B4 RID: 18612
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040048B5 RID: 18613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040048B6 RID: 18614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048B7 RID: 18615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040048B8 RID: 18616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040048B9 RID: 18617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

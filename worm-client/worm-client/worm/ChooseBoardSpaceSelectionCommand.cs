using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm
{
	// Token: 0x02000038 RID: 56
	public class ChooseBoardSpaceSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06000291 RID: 657 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseBoardSpaceSelectionCommand()
		{
			Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "ChooseBoardSpaceSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr);
			ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr, 100663709);
			ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr, 100663710);
			ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr, 100663711);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00020C2C File Offset: 0x0001EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseBoardSpaceSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00020C88 File Offset: 0x0001EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690413, XrefRangeEnd = 690418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00020CD4 File Offset: 0x0001EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690418, XrefRangeEnd = 690419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003304 File Offset: 0x00001504
		public ChooseBoardSpaceSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x020002D6 RID: 726
		[ObfuscatedName("worm.ChooseBoardSpaceSelectionCommand+<idle>d__1")]
		public sealed class _idle_d__1 : Object
		{
			// Token: 0x06001D93 RID: 7571 RVA: 0x00072D04 File Offset: 0x00070F04
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__1()
			{
				Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand>.NativeClassPtr, "<idle>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, "<>1__state");
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, "<>2__current");
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, "<>4__this");
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr__showRow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, "<showRow>5__2");
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663712);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663713);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663714);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663715);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663716);
				ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr, 100663717);
			}

			// Token: 0x06001D94 RID: 7572 RVA: 0x00072DF8 File Offset: 0x00070FF8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseBoardSpaceSelectionCommand._idle_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D95 RID: 7573 RVA: 0x00072E40 File Offset: 0x00071040
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D96 RID: 7574 RVA: 0x00072E74 File Offset: 0x00071074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690399, XrefRangeEnd = 690408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00072EB0 File Offset: 0x000710B0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D98 RID: 7576 RVA: 0x00072EF0 File Offset: 0x000710F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690408, XrefRangeEnd = 690413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00072F24 File Offset: 0x00071124
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D9A RID: 7578 RVA: 0x00010E1B File Offset: 0x0000F01B
			public _idle_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00072F64 File Offset: 0x00071164
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00010E24 File Offset: 0x0000F024
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00072F8C File Offset: 0x0007118C
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x00010E3F File Offset: 0x0000F03F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00072FBC File Offset: 0x000711BC
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00010E5E File Offset: 0x0000F05E
			public unsafe ChooseBoardSpaceSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChooseBoardSpaceSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00072FEC File Offset: 0x000711EC
			// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00010E7D File Offset: 0x0000F07D
			public unsafe WormShowImperiumRow _showRow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr__showRow_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseBoardSpaceSelectionCommand._idle_d__1.NativeFieldInfoPtr__showRow_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001128 RID: 4392
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001129 RID: 4393
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400112A RID: 4394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400112B RID: 4395
			private static readonly IntPtr NativeFieldInfoPtr__showRow_5__2;

			// Token: 0x0400112C RID: 4396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400112D RID: 4397
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400112E RID: 4398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400112F RID: 4399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001130 RID: 4400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001131 RID: 4401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

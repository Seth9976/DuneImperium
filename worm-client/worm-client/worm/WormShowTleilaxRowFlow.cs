using System;
using dwd.core.commands;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm
{
	// Token: 0x0200003A RID: 58
	public class WormShowTleilaxRowFlow : Command
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00020D84 File Offset: 0x0001EF84
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowTleilaxRowFlow()
		{
			Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormShowTleilaxRowFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr);
			WormShowTleilaxRowFlow.NativeFieldInfoPtr_DismissablePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr, "DismissablePrompt");
			WormShowTleilaxRowFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr, 100663719);
			WormShowTleilaxRowFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr, 100663720);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690449, XrefRangeEnd = 690454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowTleilaxRowFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00020E3C File Offset: 0x0001F03C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowTleilaxRowFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000334F File Offset: 0x0000154F
		public WormShowTleilaxRowFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00020E78 File Offset: 0x0001F078
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe FlavoredDismissablePrompt DismissablePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow.NativeFieldInfoPtr_DismissablePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow.NativeFieldInfoPtr_DismissablePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_DismissablePrompt;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D7 RID: 727
		[ObfuscatedName("worm.WormShowTleilaxRowFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06001DA3 RID: 7587 RVA: 0x0007301C File Offset: 0x0007121C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowTleilaxRowFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr);
				WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, "<>4__this");
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663721);
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663722);
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663723);
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663724);
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663725);
				WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr, 100663726);
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x000730FC File Offset: 0x000712FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowTleilaxRowFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DA5 RID: 7589 RVA: 0x00073144 File Offset: 0x00071344
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x00073178 File Offset: 0x00071378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690420, XrefRangeEnd = 690444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000731B4 File Offset: 0x000713B4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DA8 RID: 7592 RVA: 0x000731F4 File Offset: 0x000713F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690444, XrefRangeEnd = 690449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00073228 File Offset: 0x00071428
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTleilaxRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DAA RID: 7594 RVA: 0x00010E9C File Offset: 0x0000F09C
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00073268 File Offset: 0x00071468
			// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00010EA5 File Offset: 0x0000F0A5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00073290 File Offset: 0x00071490
			// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00010EC0 File Offset: 0x0000F0C0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000732C0 File Offset: 0x000714C0
			// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00010EDF File Offset: 0x0000F0DF
			public unsafe WormShowTleilaxRowFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowTleilaxRowFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTleilaxRowFlow._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001132 RID: 4402
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001133 RID: 4403
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001134 RID: 4404
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001135 RID: 4405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001136 RID: 4406
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001137 RID: 4407
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001138 RID: 4408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001139 RID: 4409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400113A RID: 4410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

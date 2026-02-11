using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lib.canis.src.util;
using lotus;

namespace lib.canis.input
{
	// Token: 0x02000029 RID: 41
	public class InitialSelectionHighlightedPriority : InitialSelectionPriority
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00022888 File Offset: 0x00020A88
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionHighlightedPriority()
		{
			Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "InitialSelectionHighlightedPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr);
			InitialSelectionHighlightedPriority.NativeFieldInfoPtr_inAvailableSelectionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, "inAvailableSelectionPriority");
			InitialSelectionHighlightedPriority.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, "selection");
			InitialSelectionHighlightedPriority.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, "entityView");
			InitialSelectionHighlightedPriority.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, 100663568);
			InitialSelectionHighlightedPriority.NativeMethodInfoPtr_checkAvailability_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, 100663569);
			InitialSelectionHighlightedPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, 100663570);
			InitialSelectionHighlightedPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, 100663571);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00022944 File Offset: 0x00020B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497621, XrefRangeEnd = 497626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00022984 File Offset: 0x00020B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497668, RefRangeEnd = 497669, XrefRangeStart = 497626, XrefRangeEnd = 497668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool checkAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority.NativeMethodInfoPtr_checkAvailability_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000229C0 File Offset: 0x00020BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497669, XrefRangeEnd = 497670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionHighlightedPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00022A08 File Offset: 0x00020C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497670, XrefRangeEnd = 497671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionHighlightedPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000029CE File Offset: 0x00000BCE
		public InitialSelectionHighlightedPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00022A44 File Offset: 0x00020C44
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000029D7 File Offset: 0x00000BD7
		public unsafe int inAvailableSelectionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_inAvailableSelectionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_inAvailableSelectionPriority)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00022A6C File Offset: 0x00020C6C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000029F2 File Offset: 0x00000BF2
		public unsafe Selection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00022A9C File Offset: 0x00020C9C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002A11 File Offset: 0x00000C11
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_inAvailableSelectionPriority;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_checkAvailability_Private_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D9 RID: 729
		[ObfuscatedName("lib.canis.input.InitialSelectionHighlightedPriority+<Start>d__3")]
		public sealed class _Start_d__3 : Object
		{
			// Token: 0x0600223F RID: 8767 RVA: 0x0008EEE4 File Offset: 0x0008D0E4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__3()
			{
				Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitialSelectionHighlightedPriority>.NativeClassPtr, "<Start>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr);
				InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, "<>1__state");
				InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, "<>2__current");
				InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, "<>4__this");
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663572);
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663573);
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663574);
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663575);
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663576);
				InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr, 100663577);
			}

			// Token: 0x06002240 RID: 8768 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionHighlightedPriority._Start_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002241 RID: 8769 RVA: 0x0008F00C File Offset: 0x0008D20C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002242 RID: 8770 RVA: 0x0008F040 File Offset: 0x0008D240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497607, XrefRangeEnd = 497616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x06002243 RID: 8771 RVA: 0x0008F07C File Offset: 0x0008D27C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002244 RID: 8772 RVA: 0x0008F0BC File Offset: 0x0008D2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497616, XrefRangeEnd = 497621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x06002245 RID: 8773 RVA: 0x0008F0F0 File Offset: 0x0008D2F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionHighlightedPriority._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002246 RID: 8774 RVA: 0x00011DE6 File Offset: 0x0000FFE6
			public _Start_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x06002247 RID: 8775 RVA: 0x0008F130 File Offset: 0x0008D330
			// (set) Token: 0x06002248 RID: 8776 RVA: 0x00011DEF File Offset: 0x0000FFEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x06002249 RID: 8777 RVA: 0x0008F158 File Offset: 0x0008D358
			// (set) Token: 0x0600224A RID: 8778 RVA: 0x00011E0A File Offset: 0x0001000A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x0600224B RID: 8779 RVA: 0x0008F188 File Offset: 0x0008D388
			// (set) Token: 0x0600224C RID: 8780 RVA: 0x00011E29 File Offset: 0x00010029
			public unsafe InitialSelectionHighlightedPriority __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitialSelectionHighlightedPriority>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionHighlightedPriority._Start_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

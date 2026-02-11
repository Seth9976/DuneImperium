using System;
using boardgames.hints;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.tutorial
{
	// Token: 0x02000127 RID: 295
	public class ShowTutorialHint : Command
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00047074 File Offset: 0x00045274
		// Note: this type is marked as 'beforefieldinit'.
		static ShowTutorialHint()
		{
			Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.tutorial", "ShowTutorialHint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr);
			ShowTutorialHint.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, "entityID");
			ShowTutorialHint.NativeFieldInfoPtr_hinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, "hinter");
			ShowTutorialHint.NativeFieldInfoPtr_hintFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, "hintFlavors");
			ShowTutorialHint.NativeFieldInfoPtr__Interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, "<Interrupted>k__BackingField");
			ShowTutorialHint.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665197);
			ShowTutorialHint.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665198);
			ShowTutorialHint.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665199);
			ShowTutorialHint.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665200);
			ShowTutorialHint.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665201);
			ShowTutorialHint.NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, 100665202);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0004716C File Offset: 0x0004536C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510654, RefRangeEnd = 510655, XrefRangeStart = 510636, XrefRangeEnd = 510654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowTutorialHint(EntityID entityID, IEnumerable<string> hintFlavors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintFlavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000471CC File Offset: 0x000453CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510655, XrefRangeEnd = 510660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowTutorialHint.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00047218 File Offset: 0x00045418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510660, XrefRangeEnd = 510661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0004724C File Offset: 0x0004544C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00047288 File Offset: 0x00045488
		public unsafe bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000472C8 File Offset: 0x000454C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510677, RefRangeEnd = 510678, XrefRangeStart = 510661, XrefRangeEnd = 510677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TriggerOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint.NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0000862D File Offset: 0x0000682D
		public ShowTutorialHint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x000472FC File Offset: 0x000454FC
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00008636 File Offset: 0x00006836
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0004732C File Offset: 0x0004552C
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00008655 File Offset: 0x00006855
		public unsafe DBGHintManager hinter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_hinter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_hinter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0004735C File Offset: 0x0004555C
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00008674 File Offset: 0x00006874
		public unsafe List<string> hintFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_hintFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr_hintFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0004738C File Offset: 0x0004558C
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00008693 File Offset: 0x00006893
		public unsafe bool _Interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr__Interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint.NativeFieldInfoPtr__Interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_hinter;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_hintFlavors;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr__Interrupted_k__BackingField;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_IEnumerable_1_String_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("boardgames.tutorial.ShowTutorialHint+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002848 RID: 10312 RVA: 0x000A10E8 File Offset: 0x0009F2E8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTutorialHint>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr);
				ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, "<>1__state");
				ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, "<>2__current");
				ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, "<>4__this");
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665203);
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665204);
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665205);
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665206);
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665207);
				ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr, 100665208);
			}

			// Token: 0x06002849 RID: 10313 RVA: 0x000A11C8 File Offset: 0x0009F3C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTutorialHint._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600284A RID: 10314 RVA: 0x000A1210 File Offset: 0x0009F410
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600284B RID: 10315 RVA: 0x000A1244 File Offset: 0x0009F444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510605, XrefRangeEnd = 510631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x0600284C RID: 10316 RVA: 0x000A1280 File Offset: 0x0009F480
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600284D RID: 10317 RVA: 0x000A12C0 File Offset: 0x0009F4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510631, XrefRangeEnd = 510636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x0600284E RID: 10318 RVA: 0x000A12F4 File Offset: 0x0009F4F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowTutorialHint._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600284F RID: 10319 RVA: 0x00014D2D File Offset: 0x00012F2D
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06002850 RID: 10320 RVA: 0x000A1334 File Offset: 0x0009F534
			// (set) Token: 0x06002851 RID: 10321 RVA: 0x00014D36 File Offset: 0x00012F36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06002852 RID: 10322 RVA: 0x000A135C File Offset: 0x0009F55C
			// (set) Token: 0x06002853 RID: 10323 RVA: 0x00014D51 File Offset: 0x00012F51
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06002854 RID: 10324 RVA: 0x000A138C File Offset: 0x0009F58C
			// (set) Token: 0x06002855 RID: 10325 RVA: 0x00014D70 File Offset: 0x00012F70
			public unsafe ShowTutorialHint __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowTutorialHint>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowTutorialHint._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400193E RID: 6462
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400193F RID: 6463
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001940 RID: 6464
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001941 RID: 6465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001942 RID: 6466
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001943 RID: 6467
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001944 RID: 6468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001945 RID: 6469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001946 RID: 6470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

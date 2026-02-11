using System;
using boardgames.moz;
using Canis.attributes;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.tutorial
{
	// Token: 0x02000259 RID: 601
	public class StopEntityMozCallToAction : ObserverCallToAction
	{
		// Token: 0x06001B55 RID: 6997 RVA: 0x00076C54 File Offset: 0x00074E54
		// Note: this type is marked as 'beforefieldinit'.
		static StopEntityMozCallToAction()
		{
			Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "StopEntityMozCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr);
			StopEntityMozCallToAction.NativeFieldInfoPtr_entityMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, "entityMoz");
			StopEntityMozCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, 100667677);
			StopEntityMozCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, 100667678);
			StopEntityMozCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, 100667679);
			StopEntityMozCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, 100667680);
			StopEntityMozCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, 100667681);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x00076CFC File Offset: 0x00074EFC
		public unsafe override string Identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533133, XrefRangeEnd = 533137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopEntityMozCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00076D40 File Offset: 0x00074F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533137, XrefRangeEnd = 533142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopEntityMozCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00076D9C File Offset: 0x00074F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopEntityMozCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00076DD8 File Offset: 0x00074FD8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopEntityMozCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00076E24 File Offset: 0x00075024
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopEntityMozCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0000ED6B File Offset: 0x0000CF6B
		public StopEntityMozCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00076E60 File Offset: 0x00075060
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public unsafe BaseMoz entityMoz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction.NativeFieldInfoPtr_entityMoz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction.NativeFieldInfoPtr_entityMoz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_entityMoz;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000446 RID: 1094
		[ObfuscatedName("boardgames.match.tutorial.StopEntityMozCallToAction+<RunAction>d__3")]
		public sealed class _RunAction_d__3 : Object
		{
			// Token: 0x060033C4 RID: 13252 RVA: 0x000C2FD4 File Offset: 0x000C11D4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAction_d__3()
			{
				Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StopEntityMozCallToAction>.NativeClassPtr, "<RunAction>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr);
				StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, "<>1__state");
				StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, "<>2__current");
				StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, "<>4__this");
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667682);
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667683);
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667684);
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667685);
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667686);
				StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr, 100667687);
			}

			// Token: 0x060033C5 RID: 13253 RVA: 0x000C30B4 File Offset: 0x000C12B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAction_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopEntityMozCallToAction._RunAction_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033C6 RID: 13254 RVA: 0x000C30FC File Offset: 0x000C12FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033C7 RID: 13255 RVA: 0x000C3130 File Offset: 0x000C1330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533123, XrefRangeEnd = 533128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F23 RID: 3875
			// (get) Token: 0x060033C8 RID: 13256 RVA: 0x000C316C File Offset: 0x000C136C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033C9 RID: 13257 RVA: 0x000C31AC File Offset: 0x000C13AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533128, XrefRangeEnd = 533133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F24 RID: 3876
			// (get) Token: 0x060033CA RID: 13258 RVA: 0x000C31E0 File Offset: 0x000C13E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopEntityMozCallToAction._RunAction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033CB RID: 13259 RVA: 0x0001AB5D File Offset: 0x00018D5D
			public _RunAction_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F20 RID: 3872
			// (get) Token: 0x060033CC RID: 13260 RVA: 0x000C3220 File Offset: 0x000C1420
			// (set) Token: 0x060033CD RID: 13261 RVA: 0x0001AB66 File Offset: 0x00018D66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F21 RID: 3873
			// (get) Token: 0x060033CE RID: 13262 RVA: 0x000C3248 File Offset: 0x000C1448
			// (set) Token: 0x060033CF RID: 13263 RVA: 0x0001AB81 File Offset: 0x00018D81
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F22 RID: 3874
			// (get) Token: 0x060033D0 RID: 13264 RVA: 0x000C3278 File Offset: 0x000C1478
			// (set) Token: 0x060033D1 RID: 13265 RVA: 0x0001ABA0 File Offset: 0x00018DA0
			public unsafe StopEntityMozCallToAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopEntityMozCallToAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopEntityMozCallToAction._RunAction_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FED RID: 8173
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FEE RID: 8174
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FEF RID: 8175
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FF0 RID: 8176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FF1 RID: 8177
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FF2 RID: 8178
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FF3 RID: 8179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FF4 RID: 8180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FF5 RID: 8181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

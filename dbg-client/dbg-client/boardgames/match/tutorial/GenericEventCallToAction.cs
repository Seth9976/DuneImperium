using System;
using Canis.attributes;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.tutorial
{
	// Token: 0x02000253 RID: 595
	public class GenericEventCallToAction : ObserverCallToAction
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x00075E18 File Offset: 0x00074018
		// Note: this type is marked as 'beforefieldinit'.
		static GenericEventCallToAction()
		{
			Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "GenericEventCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr);
			GenericEventCallToAction.NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, "identifier");
			GenericEventCallToAction.NativeFieldInfoPtr_invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, "invoked");
			GenericEventCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667625);
			GenericEventCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667626);
			GenericEventCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667627);
			GenericEventCallToAction.NativeMethodInfoPtr_Event_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667628);
			GenericEventCallToAction.NativeMethodInfoPtr_Event_Invoke_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667629);
			GenericEventCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, 100667630);
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x00075EE8 File Offset: 0x000740E8
		public unsafe override string Identifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericEventCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00075F2C File Offset: 0x0007412C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532989, XrefRangeEnd = 532994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericEventCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00075F88 File Offset: 0x00074188
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericEventCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00075FD4 File Offset: 0x000741D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 532994, RefRangeEnd = 532995, XrefRangeStart = 532994, XrefRangeEnd = 532994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction.NativeMethodInfoPtr_Event_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00076008 File Offset: 0x00074208
		[CallerCount(0)]
		public unsafe void Event_Invoke(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction.NativeMethodInfoPtr_Event_Invoke_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00076048 File Offset: 0x00074248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532995, XrefRangeEnd = 532999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericEventCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0000EC87 File Offset: 0x0000CE87
		public GenericEventCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00076084 File Offset: 0x00074284
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x0000EC90 File Offset: 0x0000CE90
		public unsafe string identifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction.NativeFieldInfoPtr_identifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction.NativeFieldInfoPtr_identifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x000760AC File Offset: 0x000742AC
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x0000ECAF File Offset: 0x0000CEAF
		public unsafe bool invoked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction.NativeFieldInfoPtr_invoked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction.NativeFieldInfoPtr_invoked)) = value;
			}
		}

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_identifier;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_invoked;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_Event_Invoke_Public_Void_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_Event_Invoke_Public_Void_Boolean_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000443 RID: 1091
		[ObfuscatedName("boardgames.match.tutorial.GenericEventCallToAction+<RunAction>d__4")]
		public sealed class _RunAction_d__4 : Object
		{
			// Token: 0x06003398 RID: 13208 RVA: 0x000C2714 File Offset: 0x000C0914
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAction_d__4()
			{
				Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericEventCallToAction>.NativeClassPtr, "<RunAction>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr);
				GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, "<>1__state");
				GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, "<>2__current");
				GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, "<>4__this");
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667631);
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667632);
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667633);
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667634);
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667635);
				GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr, 100667636);
			}

			// Token: 0x06003399 RID: 13209 RVA: 0x000C27F4 File Offset: 0x000C09F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAction_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEventCallToAction._RunAction_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600339A RID: 13210 RVA: 0x000C283C File Offset: 0x000C0A3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339B RID: 13211 RVA: 0x000C2870 File Offset: 0x000C0A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532982, XrefRangeEnd = 532984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F13 RID: 3859
			// (get) Token: 0x0600339C RID: 13212 RVA: 0x000C28AC File Offset: 0x000C0AAC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600339D RID: 13213 RVA: 0x000C28EC File Offset: 0x000C0AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532984, XrefRangeEnd = 532989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F14 RID: 3860
			// (get) Token: 0x0600339E RID: 13214 RVA: 0x000C2920 File Offset: 0x000C0B20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600339F RID: 13215 RVA: 0x0001AA18 File Offset: 0x00018C18
			public _RunAction_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F10 RID: 3856
			// (get) Token: 0x060033A0 RID: 13216 RVA: 0x000C2960 File Offset: 0x000C0B60
			// (set) Token: 0x060033A1 RID: 13217 RVA: 0x0001AA21 File Offset: 0x00018C21
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F11 RID: 3857
			// (get) Token: 0x060033A2 RID: 13218 RVA: 0x000C2988 File Offset: 0x000C0B88
			// (set) Token: 0x060033A3 RID: 13219 RVA: 0x0001AA3C File Offset: 0x00018C3C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F12 RID: 3858
			// (get) Token: 0x060033A4 RID: 13220 RVA: 0x000C29B8 File Offset: 0x000C0BB8
			// (set) Token: 0x060033A5 RID: 13221 RVA: 0x0001AA5B File Offset: 0x00018C5B
			public unsafe GenericEventCallToAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericEventCallToAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FD1 RID: 8145
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FD2 RID: 8146
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FD3 RID: 8147
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FD4 RID: 8148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FD5 RID: 8149
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FD6 RID: 8150
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FD7 RID: 8151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FD8 RID: 8152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FD9 RID: 8153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

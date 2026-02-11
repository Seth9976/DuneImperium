using System;
using boardgames.match.selection;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.tutorial
{
	// Token: 0x02000258 RID: 600
	public class SelectEntityCallToAction : ObserverCallToAction
	{
		// Token: 0x06001B4B RID: 6987 RVA: 0x000769C8 File Offset: 0x00074BC8
		// Note: this type is marked as 'beforefieldinit'.
		static SelectEntityCallToAction()
		{
			Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "SelectEntityCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr);
			SelectEntityCallToAction.NativeFieldInfoPtr_selectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, "selectedEntity");
			SelectEntityCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667665);
			SelectEntityCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667666);
			SelectEntityCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667667);
			SelectEntityCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667668);
			SelectEntityCallToAction.NativeMethodInfoPtr_onAttemptSubmitSelection_Private_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667669);
			SelectEntityCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, 100667670);
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00076A84 File Offset: 0x00074C84
		public unsafe override string Identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533109, XrefRangeEnd = 533113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectEntityCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00076AC8 File Offset: 0x00074CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectEntityCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00076B04 File Offset: 0x00074D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533113, XrefRangeEnd = 533118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectEntityCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00076B60 File Offset: 0x00074D60
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectEntityCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00076BAC File Offset: 0x00074DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533118, XrefRangeEnd = 533123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onAttemptSubmitSelection(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction.NativeMethodInfoPtr_onAttemptSubmitSelection_Private_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00076BF0 File Offset: 0x00074DF0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectEntityCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000ED47 File Offset: 0x0000CF47
		public SelectEntityCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00076C2C File Offset: 0x00074E2C
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public unsafe bool selectedEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction.NativeFieldInfoPtr_selectedEntity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction.NativeFieldInfoPtr_selectedEntity)) = value;
			}
		}

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntity;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_onAttemptSubmitSelection_Private_Void_EntityID_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000445 RID: 1093
		[ObfuscatedName("boardgames.match.tutorial.SelectEntityCallToAction+<RunAction>d__4")]
		public sealed class _RunAction_d__4 : Object
		{
			// Token: 0x060033B4 RID: 13236 RVA: 0x000C2CBC File Offset: 0x000C0EBC
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAction_d__4()
			{
				Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectEntityCallToAction>.NativeClassPtr, "<RunAction>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr);
				SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, "<>1__state");
				SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, "<>2__current");
				SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, "<>4__this");
				SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, "<selectionResponder>5__2");
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667671);
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667672);
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667673);
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667674);
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667675);
				SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr, 100667676);
			}

			// Token: 0x060033B5 RID: 13237 RVA: 0x000C2DB0 File Offset: 0x000C0FB0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAction_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectEntityCallToAction._RunAction_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033B6 RID: 13238 RVA: 0x000C2DF8 File Offset: 0x000C0FF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033B7 RID: 13239 RVA: 0x000C2E2C File Offset: 0x000C102C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533072, XrefRangeEnd = 533104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F1E RID: 3870
			// (get) Token: 0x060033B8 RID: 13240 RVA: 0x000C2E68 File Offset: 0x000C1068
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033B9 RID: 13241 RVA: 0x000C2EA8 File Offset: 0x000C10A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533104, XrefRangeEnd = 533109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F1F RID: 3871
			// (get) Token: 0x060033BA RID: 13242 RVA: 0x000C2EDC File Offset: 0x000C10DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033BB RID: 13243 RVA: 0x0001AADC File Offset: 0x00018CDC
			public _RunAction_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F1A RID: 3866
			// (get) Token: 0x060033BC RID: 13244 RVA: 0x000C2F1C File Offset: 0x000C111C
			// (set) Token: 0x060033BD RID: 13245 RVA: 0x0001AAE5 File Offset: 0x00018CE5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F1B RID: 3867
			// (get) Token: 0x060033BE RID: 13246 RVA: 0x000C2F44 File Offset: 0x000C1144
			// (set) Token: 0x060033BF RID: 13247 RVA: 0x0001AB00 File Offset: 0x00018D00
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1C RID: 3868
			// (get) Token: 0x060033C0 RID: 13248 RVA: 0x000C2F74 File Offset: 0x000C1174
			// (set) Token: 0x060033C1 RID: 13249 RVA: 0x0001AB1F File Offset: 0x00018D1F
			public unsafe SelectEntityCallToAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectEntityCallToAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1D RID: 3869
			// (get) Token: 0x060033C2 RID: 13250 RVA: 0x000C2FA4 File Offset: 0x000C11A4
			// (set) Token: 0x060033C3 RID: 13251 RVA: 0x0001AB3E File Offset: 0x00018D3E
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEntityCallToAction._RunAction_d__4.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FE3 RID: 8163
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FE4 RID: 8164
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FE5 RID: 8165
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FE6 RID: 8166
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x04001FE7 RID: 8167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FE8 RID: 8168
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FE9 RID: 8169
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FEA RID: 8170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FEB RID: 8171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FEC RID: 8172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

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
	// Token: 0x02000255 RID: 597
	public class MozEntityCallToAction : ObserverCallToAction
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x00076224 File Offset: 0x00074424
		// Note: this type is marked as 'beforefieldinit'.
		static MozEntityCallToAction()
		{
			Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "MozEntityCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr);
			MozEntityCallToAction.NativeFieldInfoPtr_mozComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, "mozComplete");
			MozEntityCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667640);
			MozEntityCallToAction.NativeMethodInfoPtr_get_MozAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667641);
			MozEntityCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667642);
			MozEntityCallToAction.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667643);
			MozEntityCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667644);
			MozEntityCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667645);
			MozEntityCallToAction.NativeMethodInfoPtr_CompleteMozRequirement_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667646);
			MozEntityCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, 100667647);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00076308 File Offset: 0x00074508
		public unsafe override string Identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533006, XrefRangeEnd = 533010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0007634C File Offset: 0x0007454C
		public unsafe bool MozAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction.NativeMethodInfoPtr_get_MozAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00076388 File Offset: 0x00074588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533010, XrefRangeEnd = 533015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000763E4 File Offset: 0x000745E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533015, XrefRangeEnd = 533028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToAction.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00076420 File Offset: 0x00074620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533028, XrefRangeEnd = 533030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0007645C File Offset: 0x0007465C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000764A8 File Offset: 0x000746A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533030, XrefRangeEnd = 533039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteMozRequirement(string entityIDString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction.NativeMethodInfoPtr_CompleteMozRequirement_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000764EC File Offset: 0x000746EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 533040, RefRangeEnd = 533041, XrefRangeStart = 533039, XrefRangeEnd = 533040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozEntityCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0000ECD3 File Offset: 0x0000CED3
		public MozEntityCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00076528 File Offset: 0x00074728
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		public unsafe bool mozComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction.NativeFieldInfoPtr_mozComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction.NativeFieldInfoPtr_mozComplete)) = value;
			}
		}

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_mozComplete;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_get_MozAvailable_Public_get_Boolean_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_CompleteMozRequirement_Protected_Void_String_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000444 RID: 1092
		[ObfuscatedName("boardgames.match.tutorial.MozEntityCallToAction+<RunAction>d__5")]
		public sealed class _RunAction_d__5 : Object
		{
			// Token: 0x060033A6 RID: 13222 RVA: 0x000C29E8 File Offset: 0x000C0BE8
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAction_d__5()
			{
				Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MozEntityCallToAction>.NativeClassPtr, "<RunAction>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr);
				MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, "<>1__state");
				MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, "<>2__current");
				MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, "<>4__this");
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667648);
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667649);
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667650);
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667651);
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667652);
				MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr, 100667653);
			}

			// Token: 0x060033A7 RID: 13223 RVA: 0x000C2AC8 File Offset: 0x000C0CC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAction_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozEntityCallToAction._RunAction_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033A8 RID: 13224 RVA: 0x000C2B10 File Offset: 0x000C0D10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033A9 RID: 13225 RVA: 0x000C2B44 File Offset: 0x000C0D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532999, XrefRangeEnd = 533001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F18 RID: 3864
			// (get) Token: 0x060033AA RID: 13226 RVA: 0x000C2B80 File Offset: 0x000C0D80
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033AB RID: 13227 RVA: 0x000C2BC0 File Offset: 0x000C0DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533001, XrefRangeEnd = 533006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F19 RID: 3865
			// (get) Token: 0x060033AC RID: 13228 RVA: 0x000C2BF4 File Offset: 0x000C0DF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToAction._RunAction_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033AD RID: 13229 RVA: 0x0001AA7A File Offset: 0x00018C7A
			public _RunAction_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F15 RID: 3861
			// (get) Token: 0x060033AE RID: 13230 RVA: 0x000C2C34 File Offset: 0x000C0E34
			// (set) Token: 0x060033AF RID: 13231 RVA: 0x0001AA83 File Offset: 0x00018C83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F16 RID: 3862
			// (get) Token: 0x060033B0 RID: 13232 RVA: 0x000C2C5C File Offset: 0x000C0E5C
			// (set) Token: 0x060033B1 RID: 13233 RVA: 0x0001AA9E File Offset: 0x00018C9E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F17 RID: 3863
			// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000C2C8C File Offset: 0x000C0E8C
			// (set) Token: 0x060033B3 RID: 13235 RVA: 0x0001AABD File Offset: 0x00018CBD
			public unsafe MozEntityCallToAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozEntityCallToAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozEntityCallToAction._RunAction_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FDA RID: 8154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FDB RID: 8155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FDC RID: 8156
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FDD RID: 8157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FDE RID: 8158
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FDF RID: 8159
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FE0 RID: 8160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FE1 RID: 8161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FE2 RID: 8162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

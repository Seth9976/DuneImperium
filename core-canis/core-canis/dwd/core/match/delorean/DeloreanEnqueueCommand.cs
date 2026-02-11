using System;
using Canis.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.delorean
{
	// Token: 0x02000165 RID: 357
	public class DeloreanEnqueueCommand : Command
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x00067B20 File Offset: 0x00065D20
		// Note: this type is marked as 'beforefieldinit'.
		static DeloreanEnqueueCommand()
		{
			Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.delorean", "DeloreanEnqueueCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr);
			DeloreanEnqueueCommand.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, "<Error>k__BackingField");
			DeloreanEnqueueCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, "message");
			DeloreanEnqueueCommand.NativeFieldInfoPtr_queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, "queues");
			DeloreanEnqueueCommand.NativeMethodInfoPtr_get_Error_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, 100666440);
			DeloreanEnqueueCommand.NativeMethodInfoPtr_set_Error_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, 100666441);
			DeloreanEnqueueCommand.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, 100666442);
			DeloreanEnqueueCommand.NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_ICollection_1_IDeloreanExecutionQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, 100666443);
			DeloreanEnqueueCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, 100666444);
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00067BF0 File Offset: 0x00065DF0
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00067C28 File Offset: 0x00065E28
		public unsafe ErrorInfo Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand.NativeMethodInfoPtr_get_Error_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand.NativeMethodInfoPtr_set_Error_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00067C70 File Offset: 0x00065E70
		public unsafe bool Succeeded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875238, XrefRangeEnd = 875242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00067CAC File Offset: 0x00065EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875242, XrefRangeEnd = 875245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeloreanEnqueueCommand(IGameMessage message, ICollection<IDeloreanExecutionQueue> queues)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand.NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_ICollection_1_IDeloreanExecutionQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00067D0C File Offset: 0x00065F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875245, XrefRangeEnd = 875250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeloreanEnqueueCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000093BB File Offset: 0x000075BB
		public DeloreanEnqueueCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00067D58 File Offset: 0x00065F58
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000093C4 File Offset: 0x000075C4
		public ErrorInfo _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr__Error_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00067D88 File Offset: 0x00065F88
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x000093F2 File Offset: 0x000075F2
		public unsafe IGameMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00067DB8 File Offset: 0x00065FB8
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00009411 File Offset: 0x00007611
		public unsafe ICollection<IDeloreanExecutionQueue> queues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr_queues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<IDeloreanExecutionQueue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand.NativeFieldInfoPtr_queues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeFieldInfoPtr_queues;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ErrorInfo_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Private_set_Void_ErrorInfo_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_ICollection_1_IDeloreanExecutionQueue_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020002E5 RID: 741
		[ObfuscatedName("dwd.core.match.delorean.DeloreanEnqueueCommand+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06002250 RID: 8784 RVA: 0x00098670 File Offset: 0x00096870
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeloreanEnqueueCommand>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr);
				DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, "<>1__state");
				DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, "<>2__current");
				DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, "<>4__this");
				DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, "<>7__wrap1");
				DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr__queue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, "<queue>5__3");
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666445);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666446);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666447);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666448);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666449);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666450);
				DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr, 100666451);
			}

			// Token: 0x06002251 RID: 8785 RVA: 0x0009878C File Offset: 0x0009698C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeloreanEnqueueCommand._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002252 RID: 8786 RVA: 0x000987D4 File Offset: 0x000969D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875193, XrefRangeEnd = 875198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002253 RID: 8787 RVA: 0x00098808 File Offset: 0x00096A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875198, XrefRangeEnd = 875230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002254 RID: 8788 RVA: 0x00098844 File Offset: 0x00096A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875230, XrefRangeEnd = 875233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x06002255 RID: 8789 RVA: 0x00098878 File Offset: 0x00096A78
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002256 RID: 8790 RVA: 0x000988B8 File Offset: 0x00096AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875233, XrefRangeEnd = 875238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x06002257 RID: 8791 RVA: 0x000988EC File Offset: 0x00096AEC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanEnqueueCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002258 RID: 8792 RVA: 0x0000EBA5 File Offset: 0x0000CDA5
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06002259 RID: 8793 RVA: 0x0009892C File Offset: 0x00096B2C
			// (set) Token: 0x0600225A RID: 8794 RVA: 0x0000EBAE File Offset: 0x0000CDAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x0600225B RID: 8795 RVA: 0x00098954 File Offset: 0x00096B54
			// (set) Token: 0x0600225C RID: 8796 RVA: 0x0000EBC9 File Offset: 0x0000CDC9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x0600225D RID: 8797 RVA: 0x00098984 File Offset: 0x00096B84
			// (set) Token: 0x0600225E RID: 8798 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
			public unsafe DeloreanEnqueueCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeloreanEnqueueCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x000989B4 File Offset: 0x00096BB4
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x0000EC07 File Offset: 0x0000CE07
			public unsafe IEnumerator<IDeloreanExecutionQueue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IDeloreanExecutionQueue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x000989E4 File Offset: 0x00096BE4
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x0000EC26 File Offset: 0x0000CE26
			public unsafe IDeloreanExecutionQueue _queue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr__queue_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDeloreanExecutionQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeloreanEnqueueCommand._execute_d__9.NativeFieldInfoPtr__queue_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__3;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

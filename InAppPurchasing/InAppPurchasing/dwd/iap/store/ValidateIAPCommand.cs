using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.iap.store
{
	// Token: 0x02000027 RID: 39
	public class ValidateIAPCommand : Command
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateIAPCommand()
		{
			Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "ValidateIAPCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr);
			ValidateIAPCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, "status");
			ValidateIAPCommand.NativeFieldInfoPtr_interrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, "interrupted");
			ValidateIAPCommand.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, "product");
			ValidateIAPCommand.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, "model");
			ValidateIAPCommand.NativeMethodInfoPtr_get_Status_Public_get_IAPValidationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663767);
			ValidateIAPCommand.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663768);
			ValidateIAPCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_IAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663769);
			ValidateIAPCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663770);
			ValidateIAPCommand.NativeMethodInfoPtr_requestValidation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663771);
			ValidateIAPCommand.NativeMethodInfoPtr_cleanup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663772);
			ValidateIAPCommand.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, 100663773);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		public unsafe IAPValidationStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand.NativeMethodInfoPtr_get_Status_Public_get_IAPValidationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000BF18 File Offset: 0x0000A118
		public unsafe bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BF54 File Offset: 0x0000A154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526769, RefRangeEnd = 526771, XrefRangeStart = 526769, XrefRangeEnd = 526771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidateIAPCommand(IAPProduct product, IAPStoreModel model)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(model);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_IAPStoreModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202678, XrefRangeEnd = 1202683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidateIAPCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000C000 File Offset: 0x0000A200
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void requestValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidateIAPCommand.NativeMethodInfoPtr_requestValidation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000C03C File Offset: 0x0000A23C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidateIAPCommand.NativeMethodInfoPtr_cleanup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000C078 File Offset: 0x0000A278
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1066406, RefRangeEnd = 1066410, XrefRangeStart = 1066406, XrefRangeEnd = 1066410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002F23 File Offset: 0x00001123
		public ValidateIAPCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002F2C File Offset: 0x0000112C
		public unsafe IAPValidationStatus status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002F47 File Offset: 0x00001147
		public unsafe bool interrupted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_interrupted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_interrupted)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002F62 File Offset: 0x00001162
		public unsafe IAPProduct product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000C12C File Offset: 0x0000A32C
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002F81 File Offset: 0x00001181
		public unsafe IAPStoreModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_interrupted;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_product;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_IAPValidationStatus_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_IAPStoreModel_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_requestValidation_Protected_Virtual_New_Void_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_New_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x02000053 RID: 83
		[ObfuscatedName("dwd.iap.store.ValidateIAPCommand+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06000454 RID: 1108 RVA: 0x000125B0 File Offset: 0x000107B0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateIAPCommand>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr);
				ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, "<>1__state");
				ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, "<>2__current");
				ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, "<>4__this");
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663774);
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663775);
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663776);
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663777);
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663778);
				ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr, 100663779);
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x00012690 File Offset: 0x00010890
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateIAPCommand._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x000126D8 File Offset: 0x000108D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x0001270C File Offset: 0x0001090C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202671, XrefRangeEnd = 1202673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x00012748 File Offset: 0x00010948
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00012788 File Offset: 0x00010988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202673, XrefRangeEnd = 1202678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x000127BC File Offset: 0x000109BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateIAPCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00003E7F File Offset: 0x0000207F
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x000127FC File Offset: 0x000109FC
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003E88 File Offset: 0x00002088
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00012824 File Offset: 0x00010A24
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003EA3 File Offset: 0x000020A3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x00012854 File Offset: 0x00010A54
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003EC2 File Offset: 0x000020C2
			public unsafe ValidateIAPCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidateIAPCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateIAPCommand._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

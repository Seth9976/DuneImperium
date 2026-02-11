using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x02000014 RID: 20
	public class IAPRestorePurchasesCommand : Command
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00007100 File Offset: 0x00005300
		// Note: this type is marked as 'beforefieldinit'.
		static IAPRestorePurchasesCommand()
		{
			Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPRestorePurchasesCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr);
			IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchasesRestored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, "purchasesRestored");
			IAPRestorePurchasesCommand.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, "error");
			IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, "purchases");
			IAPRestorePurchasesCommand.NativeFieldInfoPtr_failedPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, "failedPurchases");
			IAPRestorePurchasesCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, 100663483);
			IAPRestorePurchasesCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, 100663484);
			IAPRestorePurchasesCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, 100663485);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000071BC File Offset: 0x000053BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1200763, RefRangeEnd = 1200765, XrefRangeStart = 1200750, XrefRangeEnd = 1200763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPRestorePurchasesCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000071F8 File Offset: 0x000053F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200765, XrefRangeEnd = 1200770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPRestorePurchasesCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007244 File Offset: 0x00005444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200770, XrefRangeEnd = 1200776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000264B File Offset: 0x0000084B
		public IAPRestorePurchasesCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000727C File Offset: 0x0000547C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002654 File Offset: 0x00000854
		public unsafe bool purchasesRestored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchasesRestored);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchasesRestored)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000072A4 File Offset: 0x000054A4
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000266F File Offset: 0x0000086F
		public unsafe string error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000072CC File Offset: 0x000054CC
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000268E File Offset: 0x0000088E
		public unsafe List<IAPProduct> purchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_purchases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000072FC File Offset: 0x000054FC
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000026AD File Offset: 0x000008AD
		public unsafe List<IAPProduct> failedPurchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_failedPurchases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand.NativeFieldInfoPtr_failedPurchases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_purchasesRestored;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_purchases;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_failedPurchases;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000039 RID: 57
		[ObfuscatedName("dwd.iap.store.IAPRestorePurchasesCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06000324 RID: 804 RVA: 0x0000E874 File Offset: 0x0000CA74
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPRestorePurchasesCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr);
				IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, "<>4__this");
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663486);
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663487);
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663488);
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663489);
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663490);
				IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr, 100663491);
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0000E954 File Offset: 0x0000CB54
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPRestorePurchasesCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0000E99C File Offset: 0x0000CB9C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200741, XrefRangeEnd = 1200745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000328 RID: 808 RVA: 0x0000EA0C File Offset: 0x0000CC0C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000EA4C File Offset: 0x0000CC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200745, XrefRangeEnd = 1200750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600032A RID: 810 RVA: 0x0000EA80 File Offset: 0x0000CC80
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPRestorePurchasesCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600032B RID: 811 RVA: 0x00003602 File Offset: 0x00001802
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
			// (set) Token: 0x0600032D RID: 813 RVA: 0x0000360B File Offset: 0x0000180B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
			// (set) Token: 0x0600032F RID: 815 RVA: 0x00003626 File Offset: 0x00001826
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000330 RID: 816 RVA: 0x0000EB18 File Offset: 0x0000CD18
			// (set) Token: 0x06000331 RID: 817 RVA: 0x00003645 File Offset: 0x00001845
			public unsafe IAPRestorePurchasesCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPRestorePurchasesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPRestorePurchasesCommand._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

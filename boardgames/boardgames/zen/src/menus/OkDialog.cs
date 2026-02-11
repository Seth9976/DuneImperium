using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace zen.src.menus
{
	// Token: 0x0200005C RID: 92
	public class OkDialog : ConfirmDialog
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		// Note: this type is marked as 'beforefieldinit'.
		static OkDialog()
		{
			Il2CppClassPointerStore<OkDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "OkDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OkDialog>.NativeClassPtr);
			OkDialog.NativeMethodInfoPtr_ShowUntilOk_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog>.NativeClassPtr, 100663946);
			OkDialog.NativeMethodInfoPtr_WithMessage_Public_OkDialog_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog>.NativeClassPtr, 100663947);
			OkDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog>.NativeClassPtr, 100663948);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001F018 File Offset: 0x0001D218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986322, XrefRangeEnd = 986327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowUntilOk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog.NativeMethodInfoPtr_ShowUntilOk_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001F058 File Offset: 0x0001D258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986327, XrefRangeEnd = 986340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe OkDialog WithMessage(string message, string titleLabel = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(titleLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog.NativeMethodInfoPtr_WithMessage_Public_OkDialog_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OkDialog>(intPtr3) : null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001F0BC File Offset: 0x0001D2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985903, RefRangeEnd = 985904, XrefRangeStart = 985903, XrefRangeEnd = 985904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OkDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OkDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000431F File Offset: 0x0000251F
		public OkDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_ShowUntilOk_Public_IEnumerator_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_WithMessage_Public_OkDialog_String_String_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001CA RID: 458
		[ObfuscatedName("zen.src.menus.OkDialog+<ShowUntilOk>d__0")]
		public sealed class _ShowUntilOk_d__0 : Object
		{
			// Token: 0x060015B8 RID: 5560 RVA: 0x000541E4 File Offset: 0x000523E4
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowUntilOk_d__0()
			{
				Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OkDialog>.NativeClassPtr, "<ShowUntilOk>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr);
				OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, "<>1__state");
				OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, "<>2__current");
				OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, "<>4__this");
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663949);
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663950);
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663951);
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663952);
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663953);
				OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr, 100663954);
			}

			// Token: 0x060015B9 RID: 5561 RVA: 0x000542C4 File Offset: 0x000524C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowUntilOk_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OkDialog._ShowUntilOk_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015BA RID: 5562 RVA: 0x0005430C File Offset: 0x0005250C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015BB RID: 5563 RVA: 0x00054340 File Offset: 0x00052540
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x060015BC RID: 5564 RVA: 0x0005437C File Offset: 0x0005257C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015BD RID: 5565 RVA: 0x000543BC File Offset: 0x000525BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986317, XrefRangeEnd = 986322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x060015BE RID: 5566 RVA: 0x000543F0 File Offset: 0x000525F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OkDialog._ShowUntilOk_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015BF RID: 5567 RVA: 0x0000C289 File Offset: 0x0000A489
			public _ShowUntilOk_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00054430 File Offset: 0x00052630
			// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0000C292 File Offset: 0x0000A492
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00054458 File Offset: 0x00052658
			// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0000C2AD File Offset: 0x0000A4AD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00054488 File Offset: 0x00052688
			// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0000C2CC File Offset: 0x0000A4CC
			public unsafe OkDialog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OkDialog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OkDialog._ShowUntilOk_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D2D RID: 3373
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D2E RID: 3374
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D2F RID: 3375
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D30 RID: 3376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D31 RID: 3377
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D32 RID: 3378
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D33 RID: 3379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D34 RID: 3380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D35 RID: 3381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

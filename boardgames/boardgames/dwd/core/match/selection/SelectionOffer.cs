using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.selection.messages;

namespace dwd.core.match.selection
{
	// Token: 0x0200009E RID: 158
	public class SelectionOffer : Command
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00029204 File Offset: 0x00027404
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionOffer()
		{
			Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.selection", "SelectionOffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr);
			SelectionOffer.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr, "message");
			SelectionOffer.NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr, 100664513);
			SelectionOffer.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr, 100664514);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00029270 File Offset: 0x00027470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990971, RefRangeEnd = 990972, XrefRangeStart = 990959, XrefRangeEnd = 990971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionOffer(SelectionMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer.NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000292BC File Offset: 0x000274BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990972, XrefRangeEnd = 990977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionOffer.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00005747 File Offset: 0x00003947
		public SelectionOffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00029308 File Offset: 0x00027508
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe SelectionMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000215 RID: 533
		[ObfuscatedName("dwd.core.match.selection.SelectionOffer+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06001865 RID: 6245 RVA: 0x0005CB74 File Offset: 0x0005AD74
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionOffer>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr);
				SelectionOffer._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, "<>1__state");
				SelectionOffer._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, "<>2__current");
				SelectionOffer._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, "<>4__this");
				SelectionOffer._execute_d__2.NativeFieldInfoPtr__selection_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, "<selection>5__2");
				SelectionOffer._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664515);
				SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664516);
				SelectionOffer._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664517);
				SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664518);
				SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664519);
				SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr, 100664520);
			}

			// Token: 0x06001866 RID: 6246 RVA: 0x0005CC68 File Offset: 0x0005AE68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionOffer._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001867 RID: 6247 RVA: 0x0005CCB0 File Offset: 0x0005AEB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001868 RID: 6248 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990942, XrefRangeEnd = 990954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001869 RID: 6249 RVA: 0x0005CD20 File Offset: 0x0005AF20
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600186A RID: 6250 RVA: 0x0005CD60 File Offset: 0x0005AF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990954, XrefRangeEnd = 990959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x0600186B RID: 6251 RVA: 0x0005CD94 File Offset: 0x0005AF94
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionOffer._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600186C RID: 6252 RVA: 0x0000D5AC File Offset: 0x0000B7AC
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x0600186D RID: 6253 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
			// (set) Token: 0x0600186E RID: 6254 RVA: 0x0000D5B5 File Offset: 0x0000B7B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x0600186F RID: 6255 RVA: 0x0005CDFC File Offset: 0x0005AFFC
			// (set) Token: 0x06001870 RID: 6256 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06001871 RID: 6257 RVA: 0x0005CE2C File Offset: 0x0005B02C
			// (set) Token: 0x06001872 RID: 6258 RVA: 0x0000D5EF File Offset: 0x0000B7EF
			public unsafe SelectionOffer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionOffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06001873 RID: 6259 RVA: 0x0005CE5C File Offset: 0x0005B05C
			// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000D60E File Offset: 0x0000B80E
			public unsafe Selection _selection_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr__selection_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionOffer._execute_d__2.NativeFieldInfoPtr__selection_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EC6 RID: 3782
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EC7 RID: 3783
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EC8 RID: 3784
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EC9 RID: 3785
			private static readonly IntPtr NativeFieldInfoPtr__selection_5__2;

			// Token: 0x04000ECA RID: 3786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000ECB RID: 3787
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ECC RID: 3788
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000ECD RID: 3789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000ECE RID: 3790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ECF RID: 3791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace zen.src.menus
{
	// Token: 0x02000058 RID: 88
	public class DialogRendererStack : MonoBehaviour
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x0001EA50 File Offset: 0x0001CC50
		// Note: this type is marked as 'beforefieldinit'.
		static DialogRendererStack()
		{
			Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "DialogRendererStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr);
			DialogRendererStack.NativeFieldInfoPtr_dialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, "dialogs");
			DialogRendererStack.NativeFieldInfoPtr_stackZBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, "stackZBuffer");
			DialogRendererStack.NativeMethodInfoPtr_ShowOnStack_Public_IEnumerator_DialogRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, 100663925);
			DialogRendererStack.NativeMethodInfoPtr_HideOnStack_Public_IEnumerator_DialogRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, 100663926);
			DialogRendererStack.NativeMethodInfoPtr_ClearEmpties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, 100663927);
			DialogRendererStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, 100663928);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986278, XrefRangeEnd = 986284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOnStack(DialogRenderer dialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack.NativeMethodInfoPtr_ShowOnStack_Public_IEnumerator_DialogRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001EB48 File Offset: 0x0001CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986284, XrefRangeEnd = 986290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HideOnStack(DialogRenderer dialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack.NativeMethodInfoPtr_HideOnStack_Public_IEnumerator_DialogRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001EB98 File Offset: 0x0001CD98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 986301, RefRangeEnd = 986303, XrefRangeStart = 986290, XrefRangeEnd = 986301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEmpties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack.NativeMethodInfoPtr_ClearEmpties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986303, XrefRangeEnd = 986311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogRendererStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000041DA File Offset: 0x000023DA
		public DialogRendererStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001EC08 File Offset: 0x0001CE08
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000041E3 File Offset: 0x000023E3
		public unsafe List<DialogRenderer> dialogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack.NativeFieldInfoPtr_dialogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack.NativeFieldInfoPtr_dialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001EC38 File Offset: 0x0001CE38
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00004202 File Offset: 0x00002402
		public unsafe float stackZBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack.NativeFieldInfoPtr_stackZBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack.NativeFieldInfoPtr_stackZBuffer)) = value;
			}
		}

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_dialogs;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_stackZBuffer;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnStack_Public_IEnumerator_DialogRenderer_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_HideOnStack_Public_IEnumerator_DialogRenderer_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_ClearEmpties_Private_Void_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001C8 RID: 456
		[ObfuscatedName("zen.src.menus.DialogRendererStack+<HideOnStack>d__3")]
		public sealed class _HideOnStack_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06001598 RID: 5528 RVA: 0x00053BB4 File Offset: 0x00051DB4
			// Note: this type is marked as 'beforefieldinit'.
			static _HideOnStack_d__3()
			{
				Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, "<HideOnStack>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr);
				DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, "<>1__state");
				DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, "<>2__current");
				DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, "<>4__this");
				DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, "dialog");
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663929);
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663930);
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663931);
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663932);
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663933);
				DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr, 100663934);
			}

			// Token: 0x06001599 RID: 5529 RVA: 0x00053CA8 File Offset: 0x00051EA8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HideOnStack_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRendererStack._HideOnStack_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600159A RID: 5530 RVA: 0x00053CF0 File Offset: 0x00051EF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600159B RID: 5531 RVA: 0x00053D24 File Offset: 0x00051F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986235, XrefRangeEnd = 986249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x0600159C RID: 5532 RVA: 0x00053D60 File Offset: 0x00051F60
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600159D RID: 5533 RVA: 0x00053DA0 File Offset: 0x00051FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986249, XrefRangeEnd = 986254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x0600159E RID: 5534 RVA: 0x00053DD4 File Offset: 0x00051FD4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._HideOnStack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600159F RID: 5535 RVA: 0x0000C187 File Offset: 0x0000A387
			public _HideOnStack_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00053E14 File Offset: 0x00052014
			// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000C190 File Offset: 0x0000A390
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00053E3C File Offset: 0x0005203C
			// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000C1AB File Offset: 0x0000A3AB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00053E6C File Offset: 0x0005206C
			// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0000C1CA File Offset: 0x0000A3CA
			public unsafe DialogRendererStack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRendererStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00053E9C File Offset: 0x0005209C
			// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0000C1E9 File Offset: 0x0000A3E9
			public unsafe DialogRenderer dialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr_dialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._HideOnStack_d__3.NativeFieldInfoPtr_dialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D19 RID: 3353
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D1A RID: 3354
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D1B RID: 3355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D1C RID: 3356
			private static readonly IntPtr NativeFieldInfoPtr_dialog;

			// Token: 0x04000D1D RID: 3357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D1E RID: 3358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D1F RID: 3359
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D20 RID: 3360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D21 RID: 3361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D22 RID: 3362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001C9 RID: 457
		[ObfuscatedName("zen.src.menus.DialogRendererStack+<ShowOnStack>d__2")]
		public sealed class _ShowOnStack_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x060015A8 RID: 5544 RVA: 0x00053ECC File Offset: 0x000520CC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnStack_d__2()
			{
				Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRendererStack>.NativeClassPtr, "<ShowOnStack>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr);
				DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, "<>1__state");
				DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, "<>2__current");
				DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, "<>4__this");
				DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, "dialog");
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663935);
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663936);
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663937);
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663938);
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663939);
				DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr, 100663940);
			}

			// Token: 0x060015A9 RID: 5545 RVA: 0x00053FC0 File Offset: 0x000521C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnStack_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRendererStack._ShowOnStack_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015AA RID: 5546 RVA: 0x00054008 File Offset: 0x00052208
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015AB RID: 5547 RVA: 0x0005403C File Offset: 0x0005223C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986254, XrefRangeEnd = 986273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x060015AC RID: 5548 RVA: 0x00054078 File Offset: 0x00052278
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015AD RID: 5549 RVA: 0x000540B8 File Offset: 0x000522B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986273, XrefRangeEnd = 986278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x060015AE RID: 5550 RVA: 0x000540EC File Offset: 0x000522EC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererStack._ShowOnStack_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015AF RID: 5551 RVA: 0x0000C208 File Offset: 0x0000A408
			public _ShowOnStack_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0005412C File Offset: 0x0005232C
			// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000C211 File Offset: 0x0000A411
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00054154 File Offset: 0x00052354
			// (set) Token: 0x060015B3 RID: 5555 RVA: 0x0000C22C File Offset: 0x0000A42C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00054184 File Offset: 0x00052384
			// (set) Token: 0x060015B5 RID: 5557 RVA: 0x0000C24B File Offset: 0x0000A44B
			public unsafe DialogRendererStack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRendererStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x060015B6 RID: 5558 RVA: 0x000541B4 File Offset: 0x000523B4
			// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0000C26A File Offset: 0x0000A46A
			public unsafe DialogRenderer dialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr_dialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererStack._ShowOnStack_d__2.NativeFieldInfoPtr_dialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D23 RID: 3363
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D24 RID: 3364
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D25 RID: 3365
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D26 RID: 3366
			private static readonly IntPtr NativeFieldInfoPtr_dialog;

			// Token: 0x04000D27 RID: 3367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D28 RID: 3368
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D29 RID: 3369
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D2A RID: 3370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D2B RID: 3371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D2C RID: 3372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

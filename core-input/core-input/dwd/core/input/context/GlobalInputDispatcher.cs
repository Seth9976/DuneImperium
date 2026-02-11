using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace dwd.core.input.context
{
	// Token: 0x02000079 RID: 121
	public sealed class GlobalInputDispatcher : UIBehaviour
	{
		// Token: 0x060004CB RID: 1227 RVA: 0x00015D88 File Offset: 0x00013F88
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalInputDispatcher()
		{
			Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "GlobalInputDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr);
			GlobalInputDispatcher.NativeFieldInfoPtr_GlobalInputPriorityOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, "GlobalInputPriorityOffset");
			GlobalInputDispatcher.NativeFieldInfoPtr_inputActionLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, "inputActionLookup");
			GlobalInputDispatcher.NativeMethodInfoPtr_RegisterInput_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663873);
			GlobalInputDispatcher.NativeMethodInfoPtr_UnregisterInput_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663874);
			GlobalInputDispatcher.NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663875);
			GlobalInputDispatcher.NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663876);
			GlobalInputDispatcher.NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663877);
			GlobalInputDispatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663878);
			GlobalInputDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663879);
			GlobalInputDispatcher.NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, 100663880);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00015E80 File Offset: 0x00014080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123283, RefRangeEnd = 1123285, XrefRangeStart = 1123245, XrefRangeEnd = 1123283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInput(InputAction inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_RegisterInput_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00015EC4 File Offset: 0x000140C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1123319, RefRangeEnd = 1123324, XrefRangeStart = 1123285, XrefRangeEnd = 1123319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterInput(InputAction inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_UnregisterInput_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00015F08 File Offset: 0x00014108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123365, RefRangeEnd = 1123368, XrefRangeStart = 1123324, XrefRangeEnd = 1123365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExportInputActions([In] ref Dictionary<string, List<InputAction>> actionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(actionLookup);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				actionLookup = ((intPtr4 == 0) ? null : new Dictionary<string, List<InputAction>>(intPtr4));
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00015F60 File Offset: 0x00014160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123368, XrefRangeEnd = 1123388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addActionForInputId(string inputId, InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00015FB4 File Offset: 0x000141B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123388, XrefRangeEnd = 1123397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removeActionForInputId(string inputId, InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00016008 File Offset: 0x00014208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123397, XrefRangeEnd = 1123422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00016040 File Offset: 0x00014240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123422, XrefRangeEnd = 1123430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalInputDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001607C File Offset: 0x0001427C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123430, XrefRangeEnd = 1123431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwd_core_IInputActionExecutor_ExportInputActions([In] ref Dictionary<string, List<InputAction>> actionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(actionLookup);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				actionLookup = ((intPtr4 == 0) ? null : new Dictionary<string, List<InputAction>>(intPtr4));
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004B64 File Offset: 0x00002D64
		public GlobalInputDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000160D4 File Offset: 0x000142D4
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004B6D File Offset: 0x00002D6D
		public unsafe int GlobalInputPriorityOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalInputDispatcher.NativeFieldInfoPtr_GlobalInputPriorityOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalInputDispatcher.NativeFieldInfoPtr_GlobalInputPriorityOffset)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000160FC File Offset: 0x000142FC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00004B88 File Offset: 0x00002D88
		public unsafe Dictionary<string, List<InputAction>> inputActionLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalInputDispatcher.NativeFieldInfoPtr_inputActionLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<InputAction>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalInputDispatcher.NativeFieldInfoPtr_inputActionLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_GlobalInputPriorityOffset;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_inputActionLookup;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInput_Public_Void_InputAction_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInput_Public_Void_InputAction_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_InputAction_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0;

		// Token: 0x020000D1 RID: 209
		[ObfuscatedName("dwd.core.input.context.GlobalInputDispatcher+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000950 RID: 2384 RVA: 0x00024F48 File Offset: 0x00023148
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalInputDispatcher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr);
				GlobalInputDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr, "<>9");
				GlobalInputDispatcher.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr, "<>9__7_0");
				GlobalInputDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr, 100663882);
				GlobalInputDispatcher.__c.NativeMethodInfoPtr__ToString_b__7_0_Internal_String_KeyValuePair_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr, 100663883);
			}

			// Token: 0x06000951 RID: 2385 RVA: 0x00024FC4 File Offset: 0x000231C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalInputDispatcher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000952 RID: 2386 RVA: 0x00025000 File Offset: 0x00023200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123236, XrefRangeEnd = 1123245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__7_0(KeyValuePair<string, List<InputAction>> inputAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputAction));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalInputDispatcher.__c.NativeMethodInfoPtr__ToString_b__7_0_Internal_String_KeyValuePair_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000953 RID: 2387 RVA: 0x00006DB8 File Offset: 0x00004FB8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000954 RID: 2388 RVA: 0x00025050 File Offset: 0x00023250
			// (set) Token: 0x06000955 RID: 2389 RVA: 0x00006DC1 File Offset: 0x00004FC1
			public unsafe static GlobalInputDispatcher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalInputDispatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalInputDispatcher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalInputDispatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000956 RID: 2390 RVA: 0x00025078 File Offset: 0x00023278
			// (set) Token: 0x06000957 RID: 2391 RVA: 0x00006DD3 File Offset: 0x00004FD3
			public unsafe static Func<KeyValuePair<string, List<InputAction>>, string> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalInputDispatcher.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<InputAction>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalInputDispatcher.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005C5 RID: 1477
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005C6 RID: 1478
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040005C7 RID: 1479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005C8 RID: 1480
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__7_0_Internal_String_KeyValuePair_2_String_List_1_InputAction_0;
		}
	}
}

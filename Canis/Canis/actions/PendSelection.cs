using System;
using Canis.actions.continuations;
using Canis.actions.responseparsers;
using Canis.context;
using Canis.data;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace Canis.actions
{
	// Token: 0x02000188 RID: 392
	public class PendSelection : Action
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x0005ED10 File Offset: 0x0005CF10
		// Note: this type is marked as 'beforefieldinit'.
		static PendSelection()
		{
			Il2CppClassPointerStore<PendSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "PendSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendSelection>.NativeClassPtr);
			PendSelection.NativeFieldInfoPtr_SelectionRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "SelectionRequest");
			PendSelection.NativeFieldInfoPtr_ResponseParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "ResponseParser");
			PendSelection.NativeFieldInfoPtr_InitialContinuationGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "InitialContinuationGenerator");
			PendSelection.NativeFieldInfoPtr_CompletionGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "CompletionGenerator");
			PendSelection.NativeFieldInfoPtr_executeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "executeStack");
			PendSelection.NativeMethodInfoPtr__ctor_Public_Void_RequestSelection_ResponseParser_ContinuationGenerator_Context_CompletionGenerator_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666871);
			PendSelection.NativeMethodInfoPtr_ProvideExecuteStack_Public_Void_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666872);
			PendSelection.NativeMethodInfoPtr_DetermineSelectingPlayer_Private_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666873);
			PendSelection.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666874);
			PendSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666875);
			PendSelection.NativeMethodInfoPtr__execute_b__8_1_Private_Int32_KeyValuePair_2_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, 100666876);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0005EE1C File Offset: 0x0005D01C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 583690, RefRangeEnd = 583692, XrefRangeStart = 583683, XrefRangeEnd = 583690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendSelection(SelectionRequest.RequestSelection selectionRequest, ResponseParser responseParser, ContinuationGenerator initialContinuationGenerator, Context context, CompletionGenerator completionGenerator, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialContinuationGenerator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completionGenerator);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.NativeMethodInfoPtr__ctor_Public_Void_RequestSelection_ResponseParser_ContinuationGenerator_Context_CompletionGenerator_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 583693, RefRangeEnd = 583695, XrefRangeStart = 583692, XrefRangeEnd = 583693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProvideExecuteStack(ExecuteStack executeStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executeStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.NativeMethodInfoPtr_ProvideExecuteStack_Public_Void_ExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0005EF08 File Offset: 0x0005D108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 583698, RefRangeEnd = 583700, XrefRangeStart = 583695, XrefRangeEnd = 583698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity DetermineSelectingPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.NativeMethodInfoPtr_DetermineSelectingPlayer_Private_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0005EF48 File Offset: 0x0005D148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583700, XrefRangeEnd = 583706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendSelection.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0005EF94 File Offset: 0x0005D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583706, XrefRangeEnd = 583709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583709, XrefRangeEnd = 583716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _execute_b__8_1(KeyValuePair<PlayerEntity, SelectionMessage> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.NativeMethodInfoPtr__execute_b__8_1_Private_Int32_KeyValuePair_2_PlayerEntity_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00008954 File Offset: 0x00006B54
		public PendSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0005F02C File Offset: 0x0005D22C
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000895D File Offset: 0x00006B5D
		public unsafe SelectionRequest.RequestSelection SelectionRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_SelectionRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionRequest.RequestSelection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_SelectionRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0005F05C File Offset: 0x0005D25C
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe ResponseParser ResponseParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_ResponseParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_ResponseParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0005F08C File Offset: 0x0005D28C
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000899B File Offset: 0x00006B9B
		public unsafe ContinuationGenerator InitialContinuationGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_InitialContinuationGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinuationGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_InitialContinuationGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x000089BA File Offset: 0x00006BBA
		public unsafe CompletionGenerator CompletionGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_CompletionGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompletionGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_CompletionGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0005F0EC File Offset: 0x0005D2EC
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x000089D9 File Offset: 0x00006BD9
		public unsafe ExecuteStack executeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_executeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.NativeFieldInfoPtr_executeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_SelectionRequest;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_ResponseParser;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_InitialContinuationGenerator;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_CompletionGenerator;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_executeStack;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RequestSelection_ResponseParser_ContinuationGenerator_Context_CompletionGenerator_Match_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_ProvideExecuteStack_Public_Void_ExecuteStack_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_DetermineSelectingPlayer_Private_PlayerEntity_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_1_Private_Int32_KeyValuePair_2_PlayerEntity_SelectionMessage_0;

		// Token: 0x020003C2 RID: 962
		[ObfuscatedName("Canis.actions.PendSelection+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002883 RID: 10371 RVA: 0x000AFE74 File Offset: 0x000AE074
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr);
				PendSelection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, "<>9");
				PendSelection.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, "<>9__8_2");
				PendSelection.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, "<>9__8_3");
				PendSelection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, 100666878);
				PendSelection.__c.NativeMethodInfoPtr__execute_b__8_2_Internal_AccountID_KeyValuePair_2_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, 100666879);
				PendSelection.__c.NativeMethodInfoPtr__execute_b__8_3_Internal_SelectionMessage_KeyValuePair_2_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr, 100666880);
			}

			// Token: 0x06002884 RID: 10372 RVA: 0x000AFF18 File Offset: 0x000AE118
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendSelection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002885 RID: 10373 RVA: 0x000AFF54 File Offset: 0x000AE154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583233, XrefRangeEnd = 583234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _execute_b__8_2(KeyValuePair<PlayerEntity, SelectionMessage> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.__c.NativeMethodInfoPtr__execute_b__8_2_Internal_AccountID_KeyValuePair_2_PlayerEntity_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06002886 RID: 10374 RVA: 0x000AFFAC File Offset: 0x000AE1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583234, XrefRangeEnd = 583235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectionMessage _execute_b__8_3(KeyValuePair<PlayerEntity, SelectionMessage> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.__c.NativeMethodInfoPtr__execute_b__8_3_Internal_SelectionMessage_KeyValuePair_2_PlayerEntity_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
				}
			}

			// Token: 0x06002887 RID: 10375 RVA: 0x000135D3 File Offset: 0x000117D3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06002888 RID: 10376 RVA: 0x000B0004 File Offset: 0x000AE204
			// (set) Token: 0x06002889 RID: 10377 RVA: 0x000135DC File Offset: 0x000117DC
			public unsafe static PendSelection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PendSelection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendSelection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PendSelection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x0600288A RID: 10378 RVA: 0x000B002C File Offset: 0x000AE22C
			// (set) Token: 0x0600288B RID: 10379 RVA: 0x000135EE File Offset: 0x000117EE
			public unsafe static Func<KeyValuePair<PlayerEntity, SelectionMessage>, AccountID> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PendSelection.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PlayerEntity, SelectionMessage>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PendSelection.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x0600288C RID: 10380 RVA: 0x000B0054 File Offset: 0x000AE254
			// (set) Token: 0x0600288D RID: 10381 RVA: 0x00013600 File Offset: 0x00011800
			public unsafe static Func<KeyValuePair<PlayerEntity, SelectionMessage>, SelectionMessage> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PendSelection.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PlayerEntity, SelectionMessage>, SelectionMessage>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PendSelection.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400194E RID: 6478
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400194F RID: 6479
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x04001950 RID: 6480
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x04001951 RID: 6481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001952 RID: 6482
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_2_Internal_AccountID_KeyValuePair_2_PlayerEntity_SelectionMessage_0;

			// Token: 0x04001953 RID: 6483
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_3_Internal_SelectionMessage_KeyValuePair_2_PlayerEntity_SelectionMessage_0;
		}

		// Token: 0x020003C3 RID: 963
		[ObfuscatedName("Canis.actions.PendSelection+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600288E RID: 10382 RVA: 0x000B007C File Offset: 0x000AE27C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr);
				PendSelection.__c__DisplayClass8_0.NativeFieldInfoPtr_currentPassedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr, "currentPassedPlayer");
				PendSelection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr, 100666881);
				PendSelection.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr, 100666882);
			}

			// Token: 0x0600288F RID: 10383 RVA: 0x000B00E4 File Offset: 0x000AE2E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendSelection.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002890 RID: 10384 RVA: 0x000B0120 File Offset: 0x000AE320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583235, XrefRangeEnd = 583289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0(ValueTuple<PlayerEntity, PendingSelection> p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002891 RID: 10385 RVA: 0x00013612 File Offset: 0x00011812
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06002892 RID: 10386 RVA: 0x000B0174 File Offset: 0x000AE374
			// (set) Token: 0x06002893 RID: 10387 RVA: 0x0001361B File Offset: 0x0001181B
			public unsafe AccountID currentPassedPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.__c__DisplayClass8_0.NativeFieldInfoPtr_currentPassedPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection.__c__DisplayClass8_0.NativeFieldInfoPtr_currentPassedPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001954 RID: 6484
			private static readonly IntPtr NativeFieldInfoPtr_currentPassedPlayer;

			// Token: 0x04001955 RID: 6485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001956 RID: 6486
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0;
		}

		// Token: 0x020003C4 RID: 964
		[ObfuscatedName("Canis.actions.PendSelection+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06002894 RID: 10388 RVA: 0x000B01A4 File Offset: 0x000AE3A4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendSelection>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr);
				PendSelection._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>1__state");
				PendSelection._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>2__current");
				PendSelection._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				PendSelection._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>4__this");
				PendSelection._execute_d__8.NativeFieldInfoPtr__timedMessageMap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<timedMessageMap>5__2");
				PendSelection._execute_d__8.NativeFieldInfoPtr__pendingSelections_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<pendingSelections>5__3");
				PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>7__wrap3");
				PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelectingPlayer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<currentSelectingPlayer>5__5");
				PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelection_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<currentSelection>5__6");
				PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelectingPlayer_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<nextSelectingPlayer>5__7");
				PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelection_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<nextSelection>5__8");
				PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>7__wrap8");
				PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, "<>7__wrap9");
				PendSelection._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666883);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666884);
				PendSelection._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666885);
				PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666886);
				PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666887);
				PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666888);
				PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666889);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666890);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666891);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666892);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666893);
				PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr, 100666894);
			}

			// Token: 0x06002895 RID: 10389 RVA: 0x000B03C4 File Offset: 0x000AE5C4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendSelection._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002896 RID: 10390 RVA: 0x000B040C File Offset: 0x000AE60C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583289, XrefRangeEnd = 583307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002897 RID: 10391 RVA: 0x000B0440 File Offset: 0x000AE640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583307, XrefRangeEnd = 583663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002898 RID: 10392 RVA: 0x000B047C File Offset: 0x000AE67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583663, XrefRangeEnd = 583666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002899 RID: 10393 RVA: 0x000B04B0 File Offset: 0x000AE6B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 583669, RefRangeEnd = 583670, XrefRangeStart = 583666, XrefRangeEnd = 583669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600289A RID: 10394 RVA: 0x000B04E4 File Offset: 0x000AE6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583670, XrefRangeEnd = 583673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600289B RID: 10395 RVA: 0x000B0518 File Offset: 0x000AE718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583673, XrefRangeEnd = 583676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x0600289C RID: 10396 RVA: 0x000B054C File Offset: 0x000AE74C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600289D RID: 10397 RVA: 0x000B058C File Offset: 0x000AE78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583676, XrefRangeEnd = 583681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x0600289E RID: 10398 RVA: 0x000B05C0 File Offset: 0x000AE7C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600289F RID: 10399 RVA: 0x000B0600 File Offset: 0x000AE800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583681, XrefRangeEnd = 583683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060028A0 RID: 10400 RVA: 0x000B0640 File Offset: 0x000AE840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendSelection._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028A1 RID: 10401 RVA: 0x0001363A File Offset: 0x0001183A
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000B0680 File Offset: 0x000AE880
			// (set) Token: 0x060028A3 RID: 10403 RVA: 0x00013643 File Offset: 0x00011843
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000B06A8 File Offset: 0x000AE8A8
			// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0001365E File Offset: 0x0001185E
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000B06D8 File Offset: 0x000AE8D8
			// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0001367D File Offset: 0x0001187D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000B0700 File Offset: 0x000AE900
			// (set) Token: 0x060028A9 RID: 10409 RVA: 0x00013698 File Offset: 0x00011898
			public unsafe PendSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x060028AA RID: 10410 RVA: 0x000B0730 File Offset: 0x000AE930
			// (set) Token: 0x060028AB RID: 10411 RVA: 0x000136B7 File Offset: 0x000118B7
			public unsafe Dictionary<PlayerEntity, SelectionMessage> _timedMessageMap_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__timedMessageMap_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, SelectionMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__timedMessageMap_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x060028AC RID: 10412 RVA: 0x000B0760 File Offset: 0x000AE960
			// (set) Token: 0x060028AD RID: 10413 RVA: 0x000136D6 File Offset: 0x000118D6
			public unsafe List<ValueTuple<PlayerEntity, PendingSelection>> _pendingSelections_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__pendingSelections_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<PlayerEntity, PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__pendingSelections_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x060028AE RID: 10414 RVA: 0x000B0790 File Offset: 0x000AE990
			// (set) Token: 0x060028AF RID: 10415 RVA: 0x000136F5 File Offset: 0x000118F5
			public unsafe IEnumerator<Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000B07C0 File Offset: 0x000AE9C0
			// (set) Token: 0x060028B1 RID: 10417 RVA: 0x00013714 File Offset: 0x00011914
			public unsafe PlayerEntity _currentSelectingPlayer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelectingPlayer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelectingPlayer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000B07F0 File Offset: 0x000AE9F0
			// (set) Token: 0x060028B3 RID: 10419 RVA: 0x00013733 File Offset: 0x00011933
			public unsafe PendingSelection _currentSelection_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelection_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__currentSelection_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x060028B4 RID: 10420 RVA: 0x000B0820 File Offset: 0x000AEA20
			// (set) Token: 0x060028B5 RID: 10421 RVA: 0x00013752 File Offset: 0x00011952
			public unsafe PlayerEntity _nextSelectingPlayer_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelectingPlayer_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelectingPlayer_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000B0850 File Offset: 0x000AEA50
			// (set) Token: 0x060028B7 RID: 10423 RVA: 0x00013771 File Offset: 0x00011971
			public unsafe PendingSelection _nextSelection_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelection_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr__nextSelection_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000B0880 File Offset: 0x000AEA80
			// (set) Token: 0x060028B9 RID: 10425 RVA: 0x00013790 File Offset: 0x00011990
			public List<ValueTuple<PlayerEntity, PendingSelection>>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap8);
					return new List<ValueTuple<PlayerEntity, PendingSelection>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<PlayerEntity, PendingSelection>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<PlayerEntity, PendingSelection>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x060028BA RID: 10426 RVA: 0x000B08B0 File Offset: 0x000AEAB0
			// (set) Token: 0x060028BB RID: 10427 RVA: 0x000137BE File Offset: 0x000119BE
			public unsafe IEnumerator<DBGSequence> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<DBGSequence>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendSelection._execute_d__8.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001957 RID: 6487
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001958 RID: 6488
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001959 RID: 6489
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400195A RID: 6490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400195B RID: 6491
			private static readonly IntPtr NativeFieldInfoPtr__timedMessageMap_5__2;

			// Token: 0x0400195C RID: 6492
			private static readonly IntPtr NativeFieldInfoPtr__pendingSelections_5__3;

			// Token: 0x0400195D RID: 6493
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400195E RID: 6494
			private static readonly IntPtr NativeFieldInfoPtr__currentSelectingPlayer_5__5;

			// Token: 0x0400195F RID: 6495
			private static readonly IntPtr NativeFieldInfoPtr__currentSelection_5__6;

			// Token: 0x04001960 RID: 6496
			private static readonly IntPtr NativeFieldInfoPtr__nextSelectingPlayer_5__7;

			// Token: 0x04001961 RID: 6497
			private static readonly IntPtr NativeFieldInfoPtr__nextSelection_5__8;

			// Token: 0x04001962 RID: 6498
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04001963 RID: 6499
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04001964 RID: 6500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001965 RID: 6501
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001966 RID: 6502
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001967 RID: 6503
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001968 RID: 6504
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001969 RID: 6505
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x0400196A RID: 6506
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x0400196B RID: 6507
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400196C RID: 6508
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400196D RID: 6509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400196E RID: 6510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400196F RID: 6511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

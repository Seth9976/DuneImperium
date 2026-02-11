using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.selection
{
	// Token: 0x0200026B RID: 619
	public class DBGSelectionPromptCommand<TNodeType> : DBGSelectionCommand<TNodeType> where TNodeType : class
	{
		// Token: 0x06001CAB RID: 7339 RVA: 0x0007C498 File Offset: 0x0007A698
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionPromptCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr);
			DBGSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, "prompt");
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667995);
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667996);
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_displayPrompt_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667997);
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_resolvePromptAffect_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667998);
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667999);
			DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_DBGSelectionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100668000);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0007C590 File Offset: 0x0007A790
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 534669, RefRangeEnd = 534681, XrefRangeStart = 534669, XrefRangeEnd = 534681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0007C638 File Offset: 0x0007A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535983, XrefRangeEnd = 535987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator displayPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_displayPrompt_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0007C678 File Offset: 0x0007A878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535987, XrefRangeEnd = 536005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resolvePromptAffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_resolvePromptAffect_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0007C6AC File Offset: 0x0007A8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536005, XrefRangeEnd = 536008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0007C6E8 File Offset: 0x0007A8E8
		[CallerCount(0)]
		public unsafe virtual DBGSelectionPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_DBGSelectionPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr3) : null;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0000F5B2 File Offset: 0x0000D7B2
		public DBGSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0007C734 File Offset: 0x0007A934
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0000F5BB File Offset: 0x0000D7BB
		public unsafe DBGSelectionPrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_displayPrompt_Protected_IEnumerator_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_resolvePromptAffect_Protected_Void_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_DBGSelectionPrompt_0;

		// Token: 0x02000464 RID: 1124
		[ObfuscatedName("boardgames.match.selection.DBGSelectionPromptCommand`1+<displayPrompt>d__3")]
		public sealed class _displayPrompt_d__3 : Object
		{
			// Token: 0x0600356A RID: 13674 RVA: 0x000C7FA0 File Offset: 0x000C61A0
			// Note: this type is marked as 'beforefieldinit'.
			static _displayPrompt_d__3()
			{
				Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<displayPrompt>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, "<>1__state");
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, "<>2__current");
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, "<>4__this");
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668001);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668002);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668003);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668004);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668005);
				DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr, 100668006);
			}

			// Token: 0x0600356B RID: 13675 RVA: 0x000C80BC File Offset: 0x000C62BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _displayPrompt_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600356C RID: 13676 RVA: 0x000C8104 File Offset: 0x000C6304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600356D RID: 13677 RVA: 0x000C8138 File Offset: 0x000C6338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535970, XrefRangeEnd = 535981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FB3 RID: 4019
			// (get) Token: 0x0600356E RID: 13678 RVA: 0x000C8174 File Offset: 0x000C6374
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600356F RID: 13679 RVA: 0x000C81B4 File Offset: 0x000C63B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FB4 RID: 4020
			// (get) Token: 0x06003570 RID: 13680 RVA: 0x000C81E8 File Offset: 0x000C63E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003571 RID: 13681 RVA: 0x0001B933 File Offset: 0x00019B33
			public _displayPrompt_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FB0 RID: 4016
			// (get) Token: 0x06003572 RID: 13682 RVA: 0x000C8228 File Offset: 0x000C6428
			// (set) Token: 0x06003573 RID: 13683 RVA: 0x0001B93C File Offset: 0x00019B3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FB1 RID: 4017
			// (get) Token: 0x06003574 RID: 13684 RVA: 0x000C8250 File Offset: 0x000C6450
			// (set) Token: 0x06003575 RID: 13685 RVA: 0x0001B957 File Offset: 0x00019B57
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB2 RID: 4018
			// (get) Token: 0x06003576 RID: 13686 RVA: 0x000C8280 File Offset: 0x000C6480
			// (set) Token: 0x06003577 RID: 13687 RVA: 0x0001B976 File Offset: 0x00019B76
			public unsafe DBGSelectionPromptCommand<TNodeType> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionPromptCommand<TNodeType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._displayPrompt_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020E9 RID: 8425
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020EA RID: 8426
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020EB RID: 8427
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020EC RID: 8428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020ED RID: 8429
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020EE RID: 8430
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020EF RID: 8431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020F0 RID: 8432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020F1 RID: 8433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000465 RID: 1125
		[ObfuscatedName("boardgames.match.selection.DBGSelectionPromptCommand`1+<idle>d__2")]
		public sealed class _idle_d__2 : Object
		{
			// Token: 0x06003578 RID: 13688 RVA: 0x000C82B0 File Offset: 0x000C64B0
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__2()
			{
				Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<idle>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, "<>1__state");
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, "<>2__current");
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, "<>4__this");
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668007);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668008);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668009);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668010);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668011);
				DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr, 100668012);
			}

			// Token: 0x06003579 RID: 13689 RVA: 0x000C83CC File Offset: 0x000C65CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionPromptCommand<TNodeType>._idle_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600357A RID: 13690 RVA: 0x000C8414 File Offset: 0x000C6614
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357B RID: 13691 RVA: 0x000C8448 File Offset: 0x000C6648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535981, XrefRangeEnd = 535983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FB8 RID: 4024
			// (get) Token: 0x0600357C RID: 13692 RVA: 0x000C8484 File Offset: 0x000C6684
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600357D RID: 13693 RVA: 0x000C84C4 File Offset: 0x000C66C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FB9 RID: 4025
			// (get) Token: 0x0600357E RID: 13694 RVA: 0x000C84F8 File Offset: 0x000C66F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600357F RID: 13695 RVA: 0x0001B995 File Offset: 0x00019B95
			public _idle_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FB5 RID: 4021
			// (get) Token: 0x06003580 RID: 13696 RVA: 0x000C8538 File Offset: 0x000C6738
			// (set) Token: 0x06003581 RID: 13697 RVA: 0x0001B99E File Offset: 0x00019B9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FB6 RID: 4022
			// (get) Token: 0x06003582 RID: 13698 RVA: 0x000C8560 File Offset: 0x000C6760
			// (set) Token: 0x06003583 RID: 13699 RVA: 0x0001B9B9 File Offset: 0x00019BB9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB7 RID: 4023
			// (get) Token: 0x06003584 RID: 13700 RVA: 0x000C8590 File Offset: 0x000C6790
			// (set) Token: 0x06003585 RID: 13701 RVA: 0x0001B9D8 File Offset: 0x00019BD8
			public unsafe DBGSelectionPromptCommand<TNodeType> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionPromptCommand<TNodeType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionPromptCommand<TNodeType>._idle_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020F2 RID: 8434
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020F3 RID: 8435
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020F4 RID: 8436
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020F5 RID: 8437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020F6 RID: 8438
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020F7 RID: 8439
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020F8 RID: 8440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020F9 RID: 8441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020FA RID: 8442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.match.prompts.prompts;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028C RID: 652
	public class WormSelectionPromptCommand<TNodeType> : DBGSelectionCommand<TNodeType> where TNodeType : class
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x00069D74 File Offset: 0x00067F74
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectionPromptCommand()
		{
			Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectionPromptCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr);
			WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, "prompt");
			WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_temporaryChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, "temporaryChoices");
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667190);
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667191);
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667192);
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_selectResult_Protected_Abstract_Virtual_New_Void_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667193);
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getChoices_Protected_Abstract_Virtual_New_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667194);
			WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_WormSelectEntityPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667195);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00069E80 File Offset: 0x00068080
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 723614, RefRangeEnd = 723623, XrefRangeStart = 723612, XrefRangeEnd = 723614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00069EDC File Offset: 0x000680DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 723627, RefRangeEnd = 723628, XrefRangeStart = 723623, XrefRangeEnd = 723627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00069F28 File Offset: 0x00068128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723628, XrefRangeEnd = 723646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00069F64 File Offset: 0x00068164
		[CallerCount(0)]
		public unsafe virtual void selectResult(List<EntityID> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_selectResult_Protected_Abstract_Virtual_New_Void_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00069FB4 File Offset: 0x000681B4
		[CallerCount(0)]
		public unsafe virtual List<EntityComponent> getChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getChoices_Protected_Abstract_Virtual_New_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0006A000 File Offset: 0x00068200
		[CallerCount(0)]
		public unsafe virtual WormSelectEntityPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_WormSelectEntityPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPrompt>(intPtr3) : null;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000F6F5 File Offset: 0x0000D8F5
		public WormSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0006A04C File Offset: 0x0006824C
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000F6FE File Offset: 0x0000D8FE
		public unsafe WormSelectEntityPrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0006A07C File Offset: 0x0006827C
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0000F71D File Offset: 0x0000D91D
		public unsafe List<EntityComponent> temporaryChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_temporaryChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_temporaryChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr_temporaryChoices;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_selectResult_Protected_Abstract_Virtual_New_Void_List_1_EntityID_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_getChoices_Protected_Abstract_Virtual_New_List_1_EntityComponent_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Abstract_Virtual_New_WormSelectEntityPrompt_0;

		// Token: 0x02000435 RID: 1077
		[ObfuscatedName("worm.match.commands.selectionCommands.WormSelectionPromptCommand`1+<idle>d__3")]
		public sealed class _idle_d__3 : Object
		{
			// Token: 0x06002CCB RID: 11467 RVA: 0x0009FE38 File Offset: 0x0009E038
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__3()
			{
				Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<idle>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, "<>1__state");
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, "<>2__current");
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, "<>4__this");
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667196);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667197);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667198);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667199);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667200);
				WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr, 100667201);
			}

			// Token: 0x06002CCC RID: 11468 RVA: 0x0009FF54 File Offset: 0x0009E154
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectionPromptCommand<TNodeType>._idle_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CCD RID: 11469 RVA: 0x0009FF9C File Offset: 0x0009E19C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CCE RID: 11470 RVA: 0x0009FFD0 File Offset: 0x0009E1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723605, XrefRangeEnd = 723612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000A000C File Offset: 0x0009E20C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CD0 RID: 11472 RVA: 0x000A004C File Offset: 0x0009E24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000A0080 File Offset: 0x0009E280
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CD2 RID: 11474 RVA: 0x00018502 File Offset: 0x00016702
			public _idle_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000A00C0 File Offset: 0x0009E2C0
			// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x0001850B File Offset: 0x0001670B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000A00E8 File Offset: 0x0009E2E8
			// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00018526 File Offset: 0x00016726
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000A0118 File Offset: 0x0009E318
			// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x00018545 File Offset: 0x00016745
			public unsafe WormSelectionPromptCommand<TNodeType> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectionPromptCommand<TNodeType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionPromptCommand<TNodeType>._idle_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A10 RID: 6672
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A11 RID: 6673
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A12 RID: 6674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A13 RID: 6675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A14 RID: 6676
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A15 RID: 6677
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A16 RID: 6678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A17 RID: 6679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A18 RID: 6680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

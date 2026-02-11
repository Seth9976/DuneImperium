using System;
using dwd.core.data.composition;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.selection
{
	// Token: 0x0200025E RID: 606
	public class CustomChoiceInfoCommand : DBGSelectionCommand<CustomChoiceInfoNode>
	{
		// Token: 0x06001BCA RID: 7114 RVA: 0x00078CDC File Offset: 0x00076EDC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceInfoCommand()
		{
			Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "CustomChoiceInfoCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr);
			CustomChoiceInfoCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667823);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667824);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667825);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667826);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667827);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667828);
			CustomChoiceInfoCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, 100667829);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00078D98 File Offset: 0x00076F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534366, XrefRangeEnd = 534369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceInfoCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00078DF4 File Offset: 0x00076FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534369, XrefRangeEnd = 534374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00078E40 File Offset: 0x00077040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534374, XrefRangeEnd = 534385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PrefabFlavorContext getPromptFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00078E84 File Offset: 0x00077084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534385, XrefRangeEnd = 534401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition getPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00078ED0 File Offset: 0x000770D0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00078F18 File Offset: 0x00077118
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00078F64 File Offset: 0x00077164
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0000F01A File Offset: 0x0000D21A
		public CustomChoiceInfoCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x02000456 RID: 1110
		[ObfuscatedName("boardgames.match.selection.CustomChoiceInfoCommand+<idle>d__1")]
		public sealed class _idle_d__1 : Object
		{
			// Token: 0x060034CE RID: 13518 RVA: 0x000C6058 File Offset: 0x000C4258
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__1()
			{
				Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomChoiceInfoCommand>.NativeClassPtr, "<idle>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr);
				CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, "<>1__state");
				CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, "<>2__current");
				CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, "<>4__this");
				CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr__prompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, "<prompt>5__2");
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667830);
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667831);
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667832);
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667833);
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667834);
				CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr, 100667835);
			}

			// Token: 0x060034CF RID: 13519 RVA: 0x000C614C File Offset: 0x000C434C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceInfoCommand._idle_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060034D0 RID: 13520 RVA: 0x000C6194 File Offset: 0x000C4394
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034D1 RID: 13521 RVA: 0x000C61C8 File Offset: 0x000C43C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534351, XrefRangeEnd = 534361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F83 RID: 3971
			// (get) Token: 0x060034D2 RID: 13522 RVA: 0x000C6204 File Offset: 0x000C4404
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034D3 RID: 13523 RVA: 0x000C6244 File Offset: 0x000C4444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534361, XrefRangeEnd = 534366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F84 RID: 3972
			// (get) Token: 0x060034D4 RID: 13524 RVA: 0x000C6278 File Offset: 0x000C4478
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoCommand._idle_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034D5 RID: 13525 RVA: 0x0001B4A3 File Offset: 0x000196A3
			public _idle_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x060034D6 RID: 13526 RVA: 0x000C62B8 File Offset: 0x000C44B8
			// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0001B4AC File Offset: 0x000196AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F80 RID: 3968
			// (get) Token: 0x060034D8 RID: 13528 RVA: 0x000C62E0 File Offset: 0x000C44E0
			// (set) Token: 0x060034D9 RID: 13529 RVA: 0x0001B4C7 File Offset: 0x000196C7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F81 RID: 3969
			// (get) Token: 0x060034DA RID: 13530 RVA: 0x000C6310 File Offset: 0x000C4510
			// (set) Token: 0x060034DB RID: 13531 RVA: 0x0001B4E6 File Offset: 0x000196E6
			public unsafe CustomChoiceInfoCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceInfoCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F82 RID: 3970
			// (get) Token: 0x060034DC RID: 13532 RVA: 0x000C6340 File Offset: 0x000C4540
			// (set) Token: 0x060034DD RID: 13533 RVA: 0x0001B505 File Offset: 0x00019705
			public unsafe CustomChoiceInfoPrompt _prompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr__prompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceInfoPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoCommand._idle_d__1.NativeFieldInfoPtr__prompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400208C RID: 8332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400208D RID: 8333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400208E RID: 8334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400208F RID: 8335
			private static readonly IntPtr NativeFieldInfoPtr__prompt_5__2;

			// Token: 0x04002090 RID: 8336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002091 RID: 8337
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002092 RID: 8338
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002093 RID: 8339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002094 RID: 8340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002095 RID: 8341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

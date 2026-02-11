using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000007 RID: 7
public class WormTroopsSelectionCommand : DBGSelectionCommand<IEntityListSelection>
{
	// Token: 0x0600001A RID: 26 RVA: 0x00018FE0 File Offset: 0x000171E0
	// Note: this type is marked as 'beforefieldinit'.
	static WormTroopsSelectionCommand()
	{
		Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTroopsSelectionCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr);
		WormTroopsSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, "selectionPromptRenderers");
		WormTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663312);
		WormTroopsSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663313);
		WormTroopsSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663314);
		WormTroopsSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663315);
		WormTroopsSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663316);
		WormTroopsSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, 100663317);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0001909C File Offset: 0x0001729C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 686900, RefRangeEnd = 686902, XrefRangeStart = 686890, XrefRangeEnd = 686900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTroopsSelectionCommand(ISelectionNode node, bool fromCancel)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000190F8 File Offset: 0x000172F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686902, XrefRangeEnd = 686907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator idle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopsSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00019144 File Offset: 0x00017344
	[CallerCount(184)]
	[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool autoAdvance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopsSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0001918C File Offset: 0x0001738C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686907, XrefRangeEnd = 686911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void enterNode(bool fromCancel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopsSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000191D8 File Offset: 0x000173D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686911, XrefRangeEnd = 686919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void exitNode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopsSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00019214 File Offset: 0x00017414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686919, XrefRangeEnd = 686934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool submitSelection(EntityID selectedEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopsSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000210B File Offset: 0x0000030B
	public WormTroopsSelectionCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000022 RID: 34 RVA: 0x0001926C File Offset: 0x0001746C
	// (set) Token: 0x06000023 RID: 35 RVA: 0x00002114 File Offset: 0x00000314
	public unsafe Il2CppReferenceArray<SelectionPromptRenderer> selectionPromptRenderers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SelectionPromptRenderer>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr_selectionPromptRenderers;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0;

	// Token: 0x020002AB RID: 683
	[ObfuscatedName("WormTroopsSelectionCommand+<idle>d__2")]
	public sealed class _idle_d__2 : Object
	{
		// Token: 0x06001BD5 RID: 7125 RVA: 0x0006DB64 File Offset: 0x0006BD64
		// Note: this type is marked as 'beforefieldinit'.
		static _idle_d__2()
		{
			Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTroopsSelectionCommand>.NativeClassPtr, "<idle>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr);
			WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, "<>1__state");
			WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, "<>2__current");
			WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, "<>4__this");
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663318);
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663319);
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663320);
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663321);
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663322);
			WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr, 100663323);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0006DC44 File Offset: 0x0006BE44
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _idle_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopsSelectionCommand._idle_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0006DC8C File Offset: 0x0006BE8C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0006DCC0 File Offset: 0x0006BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686876, XrefRangeEnd = 686885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0006DCFC File Offset: 0x0006BEFC
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0006DD3C File Offset: 0x0006BF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686885, XrefRangeEnd = 686890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0006DD70 File Offset: 0x0006BF70
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopsSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00010072 File Offset: 0x0000E272
		public _idle_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0006DDB0 File Offset: 0x0006BFB0
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0001007B File Offset: 0x0000E27B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0006DDD8 File Offset: 0x0006BFD8
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00010096 File Offset: 0x0000E296
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0006DE08 File Offset: 0x0006C008
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x000100B5 File Offset: 0x0000E2B5
		public unsafe WormTroopsSelectionCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTroopsSelectionCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopsSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

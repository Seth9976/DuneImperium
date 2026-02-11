using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000005 RID: 5
public class WormOpponentTurnDefferedSelectionCommand : DBGBasicEntityListSelectionCommand
{
	// Token: 0x0600000F RID: 15 RVA: 0x00018D58 File Offset: 0x00016F58
	// Note: this type is marked as 'beforefieldinit'.
	static WormOpponentTurnDefferedSelectionCommand()
	{
		Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormOpponentTurnDefferedSelectionCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr);
		WormOpponentTurnDefferedSelectionCommand.NativeFieldInfoPtr_autoadvanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr, "autoadvanceCount");
		WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr, 100663301);
		WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr, 100663302);
		WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr, 100663303);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00018DD8 File Offset: 0x00016FD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormOpponentTurnDefferedSelectionCommand(ISelectionNode node, bool fromCancel)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00018E34 File Offset: 0x00017034
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686861, XrefRangeEnd = 686866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator idle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00018E80 File Offset: 0x00017080
	public unsafe virtual IEnumerable<EntityID> SelectableAbilities
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686866, XrefRangeEnd = 686873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020DE File Offset: 0x000002DE
	public WormOpponentTurnDefferedSelectionCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00018EC0 File Offset: 0x000170C0
	// (set) Token: 0x06000015 RID: 21 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe int autoadvanceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand.NativeFieldInfoPtr_autoadvanceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand.NativeFieldInfoPtr_autoadvanceCount)) = value;
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_autoadvanceCount;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0;

	// Token: 0x020002AA RID: 682
	[ObfuscatedName("WormOpponentTurnDefferedSelectionCommand+<idle>d__2")]
	public sealed class _idle_d__2 : Object
	{
		// Token: 0x06001BC7 RID: 7111 RVA: 0x0006D890 File Offset: 0x0006BA90
		// Note: this type is marked as 'beforefieldinit'.
		static _idle_d__2()
		{
			Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand>.NativeClassPtr, "<idle>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, "<>1__state");
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, "<>2__current");
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, "<>4__this");
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663304);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663305);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663306);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663307);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663308);
			WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr, 100663309);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0006D970 File Offset: 0x0006BB70
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _idle_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOpponentTurnDefferedSelectionCommand._idle_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0006D9B8 File Offset: 0x0006BBB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0006D9EC File Offset: 0x0006BBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686808, XrefRangeEnd = 686856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x0006DA28 File Offset: 0x0006BC28
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0006DA68 File Offset: 0x0006BC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686856, XrefRangeEnd = 686861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00010010 File Offset: 0x0000E210
		public _idle_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0006DADC File Offset: 0x0006BCDC
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x00010019 File Offset: 0x0000E219
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0006DB04 File Offset: 0x0006BD04
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00010034 File Offset: 0x0000E234
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0006DB34 File Offset: 0x0006BD34
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x00010053 File Offset: 0x0000E253
		public unsafe WormOpponentTurnDefferedSelectionCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormOpponentTurnDefferedSelectionCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOpponentTurnDefferedSelectionCommand._idle_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

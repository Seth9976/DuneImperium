using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

// Token: 0x02000005 RID: 5
public class VoodooEntityMovedCommand : Command
{
	// Token: 0x0600000F RID: 15 RVA: 0x0000962C File Offset: 0x0000782C
	// Note: this type is marked as 'beforefieldinit'.
	static VoodooEntityMovedCommand()
	{
		Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "", "VoodooEntityMovedCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr);
		VoodooEntityMovedCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "EntityID");
		VoodooEntityMovedCommand.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "SourceID");
		VoodooEntityMovedCommand.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "DestinationID");
		VoodooEntityMovedCommand.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "PositionInParent");
		VoodooEntityMovedCommand.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "um");
		VoodooEntityMovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityMoved_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, 100663301);
		VoodooEntityMovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, 100663302);
		VoodooEntityMovedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, 100663303);
		VoodooEntityMovedCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, 100663304);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00009710 File Offset: 0x00007910
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106424, XrefRangeEnd = 1106433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VoodooEntityMovedCommand(EntityMoved message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityMoved_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000975C File Offset: 0x0000795C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106433, XrefRangeEnd = 1106441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VoodooEntityMovedCommand(EntityID entityID, EntityID sourceID, EntityID destinationID, int positionInParent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceID);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationID);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionInParent;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000097DC File Offset: 0x000079DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106441, XrefRangeEnd = 1106446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityMovedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00009828 File Offset: 0x00007A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106446, XrefRangeEnd = 1106467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityMovedCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000020DE File Offset: 0x000002DE
	public VoodooEntityMovedCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000015 RID: 21 RVA: 0x0000986C File Offset: 0x00007A6C
	// (set) Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe EntityID EntityID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_EntityID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000017 RID: 23 RVA: 0x0000989C File Offset: 0x00007A9C
	// (set) Token: 0x06000018 RID: 24 RVA: 0x00002106 File Offset: 0x00000306
	public unsafe EntityID SourceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_SourceID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000019 RID: 25 RVA: 0x000098CC File Offset: 0x00007ACC
	// (set) Token: 0x0600001A RID: 26 RVA: 0x00002125 File Offset: 0x00000325
	public unsafe EntityID DestinationID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_DestinationID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001B RID: 27 RVA: 0x000098FC File Offset: 0x00007AFC
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00002144 File Offset: 0x00000344
	public unsafe int PositionInParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_PositionInParent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_PositionInParent)) = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001D RID: 29 RVA: 0x00009924 File Offset: 0x00007B24
	// (set) Token: 0x0600001E RID: 30 RVA: 0x0000215F File Offset: 0x0000035F
	public unsafe UpdateManager um
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_um);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_EntityID;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr_SourceID;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_um;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityMoved_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_EntityID_Int32_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x020000AD RID: 173
	[ObfuscatedName("VoodooEntityMovedCommand+<execute>d__7")]
	public sealed class _execute_d__7 : Object
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x00029DC0 File Offset: 0x00027FC0
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__7()
		{
			Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooEntityMovedCommand>.NativeClassPtr, "<execute>d__7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr);
			VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, "<>1__state");
			VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, "<>2__current");
			VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, "<>4__this");
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663305);
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663306);
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663307);
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663308);
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663309);
			VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr, 100663310);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00029EA0 File Offset: 0x000280A0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__7(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityMovedCommand._execute_d__7>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00029EE8 File Offset: 0x000280E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00029F1C File Offset: 0x0002811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106408, XrefRangeEnd = 1106419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00029F58 File Offset: 0x00028158
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00029F98 File Offset: 0x00028198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106419, XrefRangeEnd = 1106424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00029FCC File Offset: 0x000281CC
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00006B77 File Offset: 0x00004D77
		public _execute_d__7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0002A00C File Offset: 0x0002820C
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00006B80 File Offset: 0x00004D80
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0002A034 File Offset: 0x00028234
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00006B9B File Offset: 0x00004D9B
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0002A064 File Offset: 0x00028264
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00006BBA File Offset: 0x00004DBA
		public unsafe VoodooEntityMovedCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooEntityMovedCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedCommand._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

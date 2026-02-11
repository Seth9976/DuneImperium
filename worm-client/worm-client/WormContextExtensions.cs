using System;
using boardgames.match.behaviours;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using voodoo.flavors;

// Token: 0x02000029 RID: 41
public class WormContextExtensions : GameSpecificContextExtensions
{
	// Token: 0x060001DF RID: 479 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
	// Note: this type is marked as 'beforefieldinit'.
	static WormContextExtensions()
	{
		Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormContextExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr);
		WormContextExtensions.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, "entitiesProvider");
		WormContextExtensions.NativeFieldInfoPtr_matchHub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, "matchHub");
		WormContextExtensions.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, 100663618);
		WormContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, 100663619);
		WormContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, 100663620);
		WormContextExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, 100663621);
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0001ED6C File Offset: 0x0001CF6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689752, XrefRangeEnd = 689753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689753, XrefRangeEnd = 689758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerable<string> WithMoveContext(PrefabFlavorContext context, MoveContext moveContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveContext);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0001EE14 File Offset: 0x0001D014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689758, XrefRangeEnd = 689765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerable<string> WithEntityContext(PrefabFlavorContext context, EntityComponent entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0001EE88 File Offset: 0x0001D088
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormContextExtensions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002E00 File Offset: 0x00001000
	public WormContextExtensions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
	// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002E09 File Offset: 0x00001009
	public unsafe DBGEntitiesProvider entitiesProvider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions.NativeFieldInfoPtr_entitiesProvider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001EEF4 File Offset: 0x0001D0F4
	// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002E28 File Offset: 0x00001028
	public unsafe DBGMatchHub matchHub
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions.NativeFieldInfoPtr_matchHub);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions.NativeFieldInfoPtr_matchHub), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeFieldInfoPtr_matchHub;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeMethodInfoPtr_WithMoveContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeMethodInfoPtr_WithEntityContext_Public_Virtual_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002CB RID: 715
	[ObfuscatedName("WormContextExtensions+<WithEntityContext>d__4")]
	public sealed class _WithEntityContext_d__4 : Object
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x00071A90 File Offset: 0x0006FC90
		// Note: this type is marked as 'beforefieldinit'.
		static _WithEntityContext_d__4()
		{
			Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, "<WithEntityContext>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr);
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<>1__state");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<>2__current");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<>l__initialThreadId");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "entity");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___3__entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<>3__entity");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<>4__this");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__owner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<owner>5__2");
			WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__isAI_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, "<isAI>5__3");
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663622);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663623);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663624);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663625);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663626);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663627);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663628);
			WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr, 100663629);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00071BFC File Offset: 0x0006FDFC
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WithEntityContext_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContextExtensions._WithEntityContext_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00071C44 File Offset: 0x0006FE44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00071C78 File Offset: 0x0006FE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689698, XrefRangeEnd = 689723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00071CB4 File Offset: 0x0006FEB4
		public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00071CEC File Offset: 0x0006FEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689723, XrefRangeEnd = 689728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00071D20 File Offset: 0x0006FF20
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00071D60 File Offset: 0x0006FF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689728, XrefRangeEnd = 689737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00071DA0 File Offset: 0x0006FFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithEntityContext_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00010AEE File Offset: 0x0000ECEE
		public _WithEntityContext_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00010AF7 File Offset: 0x0000ECF7
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00071E08 File Offset: 0x00070008
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00010B12 File Offset: 0x0000ED12
		public unsafe string __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___2__current);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00071E30 File Offset: 0x00070030
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x00010B31 File Offset: 0x0000ED31
		public unsafe int __l__initialThreadId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___l__initialThreadId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00071E58 File Offset: 0x00070058
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00010B4C File Offset: 0x0000ED4C
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00071E88 File Offset: 0x00070088
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00010B6B File Offset: 0x0000ED6B
		public unsafe EntityComponent __3__entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___3__entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___3__entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00071EB8 File Offset: 0x000700B8
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x00010B8A File Offset: 0x0000ED8A
		public unsafe WormContextExtensions __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormContextExtensions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00071EE8 File Offset: 0x000700E8
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x00010BA9 File Offset: 0x0000EDA9
		public unsafe EntityComponent _owner_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__owner_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__owner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00071F18 File Offset: 0x00070118
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		public unsafe bool _isAI_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__isAI_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithEntityContext_d__4.NativeFieldInfoPtr__isAI_5__3)) = value;
			}
		}

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeFieldInfoPtr___3__entity;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeFieldInfoPtr__owner_5__2;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeFieldInfoPtr__isAI_5__3;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}

	// Token: 0x020002CC RID: 716
	[ObfuscatedName("WormContextExtensions+<WithMoveContext>d__3")]
	public sealed class _WithMoveContext_d__3 : Object
	{
		// Token: 0x06001D47 RID: 7495 RVA: 0x00071F40 File Offset: 0x00070140
		// Note: this type is marked as 'beforefieldinit'.
		static _WithMoveContext_d__3()
		{
			Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormContextExtensions>.NativeClassPtr, "<WithMoveContext>d__3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr);
			WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, "<>1__state");
			WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, "<>2__current");
			WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, "<>l__initialThreadId");
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663630);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663631);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663632);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663633);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663634);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663635);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663636);
			WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr, 100663637);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00072048 File Offset: 0x00070248
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WithMoveContext_d__3(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormContextExtensions._WithMoveContext_d__3>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00072090 File Offset: 0x00070290
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000720C4 File Offset: 0x000702C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689737, XrefRangeEnd = 689745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00072100 File Offset: 0x00070300
		public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00072138 File Offset: 0x00070338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689745, XrefRangeEnd = 689750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0007216C File Offset: 0x0007036C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000721AC File Offset: 0x000703AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689750, XrefRangeEnd = 689752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000721EC File Offset: 0x000703EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormContextExtensions._WithMoveContext_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00010BE3 File Offset: 0x0000EDE3
		public _WithMoveContext_d__3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0007222C File Offset: 0x0007042C
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00010BEC File Offset: 0x0000EDEC
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00072254 File Offset: 0x00070454
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00010C07 File Offset: 0x0000EE07
		public unsafe string __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___2__current);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0007227C File Offset: 0x0007047C
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00010C26 File Offset: 0x0000EE26
		public unsafe int __l__initialThreadId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___l__initialThreadId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormContextExtensions._WithMoveContext_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
			}
		}

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}

using System;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using worm;

// Token: 0x02000024 RID: 36
public class WormTechRowView : LayoutPileView
{
	// Token: 0x0600017A RID: 378 RVA: 0x0001D78C File Offset: 0x0001B98C
	// Note: this type is marked as 'beforefieldinit'.
	static WormTechRowView()
	{
		Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTechRowView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr);
		WormTechRowView.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr, "wormEntities");
		WormTechRowView.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr, 100663527);
		WormTechRowView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr, 100663528);
		WormTechRowView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr, 100663529);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0001D80C File Offset: 0x0001BA0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688985, XrefRangeEnd = 688990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0001D84C File Offset: 0x0001BA4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688990, XrefRangeEnd = 689001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override UnitView createView(EntityComponent e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechRowView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
		}
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689001, XrefRangeEnd = 689002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTechRowView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002AF7 File Offset: 0x00000CF7
	public WormTechRowView(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600017F RID: 383 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
	// (set) Token: 0x06000180 RID: 384 RVA: 0x00002B00 File Offset: 0x00000D00
	public unsafe WormEntities wormEntities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView.NativeFieldInfoPtr_wormEntities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002C0 RID: 704
	[ObfuscatedName("WormTechRowView+<Start>d__1")]
	public sealed class _Start_d__1 : Object
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x00070144 File Offset: 0x0006E344
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__1()
		{
			Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTechRowView>.NativeClassPtr, "<Start>d__1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr);
			WormTechRowView._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, "<>1__state");
			WormTechRowView._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, "<>2__current");
			WormTechRowView._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, "<>4__this");
			WormTechRowView._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, "<entitiesProvider>5__2");
			WormTechRowView._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663530);
			WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663531);
			WormTechRowView._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663532);
			WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663533);
			WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663534);
			WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr, 100663535);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00070238 File Offset: 0x0006E438
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__1(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechRowView._Start_d__1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00070280 File Offset: 0x0006E480
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x000702B4 File Offset: 0x0006E4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688971, XrefRangeEnd = 688980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000702F0 File Offset: 0x0006E4F0
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00070330 File Offset: 0x0006E530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688980, XrefRangeEnd = 688985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00070364 File Offset: 0x0006E564
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowView._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000106C2 File Offset: 0x0000E8C2
		public _Start_d__1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x000703A4 File Offset: 0x0006E5A4
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x000106CB File Offset: 0x0000E8CB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x000703CC File Offset: 0x0006E5CC
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x000106E6 File Offset: 0x0000E8E6
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x000703FC File Offset: 0x0006E5FC
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00010705 File Offset: 0x0000E905
		public unsafe WormTechRowView __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechRowView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0007042C File Offset: 0x0006E62C
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00010724 File Offset: 0x0000E924
		public unsafe EntitiesProvider _entitiesProvider_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowView._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

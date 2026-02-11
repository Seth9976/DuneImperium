using System;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

// Token: 0x02000016 RID: 22
public class LocalPlayerEntityView : EntityViewDataProvider
{
	// Token: 0x060000BB RID: 187 RVA: 0x00012F2C File Offset: 0x0001112C
	// Note: this type is marked as 'beforefieldinit'.
	static LocalPlayerEntityView()
	{
		Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "LocalPlayerEntityView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr);
		LocalPlayerEntityView.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr, 100663438);
		LocalPlayerEntityView.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr, 100663439);
		LocalPlayerEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr, 100663440);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00012F98 File Offset: 0x00011198
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982817, XrefRangeEnd = 982822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00012FD8 File Offset: 0x000111D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982822, XrefRangeEnd = 982823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override EntityComponent ProvideData(EntityInitializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalPlayerEntityView.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00013034 File Offset: 0x00011234
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalPlayerEntityView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000024DA File Offset: 0x000006DA
	public LocalPlayerEntityView(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000196 RID: 406
	[ObfuscatedName("LocalPlayerEntityView+<Start>d__0")]
	public sealed class _Start_d__0 : Object
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0004E290 File Offset: 0x0004C490
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__0()
		{
			Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayerEntityView>.NativeClassPtr, "<Start>d__0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr);
			LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, "<>1__state");
			LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, "<>2__current");
			LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, "<>4__this");
			LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, "<entitiesProvider>5__2");
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663441);
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663442);
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663443);
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663444);
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663445);
			LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr, 100663446);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0004E384 File Offset: 0x0004C584
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__0(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerEntityView._Start_d__0>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0004E3CC File Offset: 0x0004C5CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0004E400 File Offset: 0x0004C600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982804, XrefRangeEnd = 982812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0004E43C File Offset: 0x0004C63C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0004E47C File Offset: 0x0004C67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982812, XrefRangeEnd = 982817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerEntityView._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0000B380 File Offset: 0x00009580
		public _Start_d__0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0004E4F0 File Offset: 0x0004C6F0
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x0000B389 File Offset: 0x00009589
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0004E518 File Offset: 0x0004C718
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0004E548 File Offset: 0x0004C748
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0000B3C3 File Offset: 0x000095C3
		public unsafe LocalPlayerEntityView __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayerEntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0004E578 File Offset: 0x0004C778
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0000B3E2 File Offset: 0x000095E2
		public unsafe EntitiesProvider _entitiesProvider_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr__entitiesProvider_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerEntityView._Start_d__0.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

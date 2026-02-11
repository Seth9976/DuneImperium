using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200013D RID: 317
	public class Component : MarshalByRefObject
	{
		// Token: 0x060012C6 RID: 4806 RVA: 0x000644E8 File Offset: 0x000626E8
		// Note: this type is marked as 'beforefieldinit'.
		static Component()
		{
			Il2CppClassPointerStore<Component>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Component");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Component>.NativeClassPtr);
			Component.NativeFieldInfoPtr_EventDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Component>.NativeClassPtr, "EventDisposed");
			Component.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Component>.NativeClassPtr, "site");
			Component.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Component>.NativeClassPtr, "events");
			Component.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666027);
			Component.NativeMethodInfoPtr_get_CanRaiseEvents_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666028);
			Component.NativeMethodInfoPtr_get_CanRaiseEventsInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666029);
			Component.NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666030);
			Component.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666031);
			Component.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666032);
			Component.NativeMethodInfoPtr_GetService_Protected_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666033);
			Component.NativeMethodInfoPtr_get_DesignMode_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666034);
			Component.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666035);
			Component.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666036);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0006461C File Offset: 0x0006281C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 460725, RefRangeEnd = 460728, XrefRangeStart = 460722, XrefRangeEnd = 460725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00064658 File Offset: 0x00062858
		public unsafe virtual bool CanRaiseEvents
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_get_CanRaiseEvents_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000646A0 File Offset: 0x000628A0
		public unsafe bool CanRaiseEventsInternal
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 381934, RefRangeEnd = 381975, XrefRangeStart = 381934, XrefRangeEnd = 381975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_CanRaiseEventsInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x000646DC File Offset: 0x000628DC
		public unsafe virtual ISite Site
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00064728 File Offset: 0x00062928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 460732, RefRangeEnd = 460734, XrefRangeStart = 460728, XrefRangeEnd = 460732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0006475C File Offset: 0x0006295C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 460757, RefRangeEnd = 460759, XrefRangeStart = 460734, XrefRangeEnd = 460757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000647A8 File Offset: 0x000629A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460759, XrefRangeEnd = 460760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetService(Type service)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_GetService_Protected_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00064804 File Offset: 0x00062A04
		public unsafe bool DesignMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 460761, RefRangeEnd = 460762, XrefRangeStart = 460760, XrefRangeEnd = 460761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_DesignMode_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00064840 File Offset: 0x00062A40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 460772, RefRangeEnd = 460774, XrefRangeStart = 460762, XrefRangeEnd = 460772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Component.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00064884 File Offset: 0x00062A84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Component>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00008967 File Offset: 0x00006B67
		public Component(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000648C0 File Offset: 0x00062AC0
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x00008970 File Offset: 0x00006B70
		public unsafe static Object EventDisposed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Component.NativeFieldInfoPtr_EventDisposed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Component.NativeFieldInfoPtr_EventDisposed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000648E8 File Offset: 0x00062AE8
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x00008982 File Offset: 0x00006B82
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Component.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Component.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00064918 File Offset: 0x00062B18
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x000089A1 File Offset: 0x00006BA1
		public unsafe EventHandlerList events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Component.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Component.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr_EventDisposed;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRaiseEvents_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRaiseEventsInternal_Internal_get_Boolean_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Protected_Virtual_New_Object_Type_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_get_DesignMode_Protected_get_Boolean_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

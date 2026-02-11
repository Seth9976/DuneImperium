using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200011E RID: 286
	public class MarshalByValueComponent : Object
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x0005E758 File Offset: 0x0005C958
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalByValueComponent()
		{
			Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "MarshalByValueComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr);
			MarshalByValueComponent.NativeFieldInfoPtr_s_eventDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, "s_eventDisposed");
			MarshalByValueComponent.NativeFieldInfoPtr__site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, "_site");
			MarshalByValueComponent.NativeFieldInfoPtr__events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, "_events");
			MarshalByValueComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665824);
			MarshalByValueComponent.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665825);
			MarshalByValueComponent.NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665826);
			MarshalByValueComponent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665827);
			MarshalByValueComponent.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665828);
			MarshalByValueComponent.NativeMethodInfoPtr_GetService_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665829);
			MarshalByValueComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr, 100665830);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005E850 File Offset: 0x0005CA50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByValueComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalByValueComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByValueComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005E88C File Offset: 0x0005CA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459464, XrefRangeEnd = 459467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByValueComponent.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0005E8C8 File Offset: 0x0005CAC8
		public unsafe virtual ISite Site
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByValueComponent.NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005E914 File Offset: 0x0005CB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459467, XrefRangeEnd = 459471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByValueComponent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0005E948 File Offset: 0x0005CB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459494, RefRangeEnd = 459495, XrefRangeStart = 459471, XrefRangeEnd = 459494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByValueComponent.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005E994 File Offset: 0x0005CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459495, XrefRangeEnd = 459498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetService(Type service)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByValueComponent.NativeMethodInfoPtr_GetService_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005E9F0 File Offset: 0x0005CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459498, XrefRangeEnd = 459508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByValueComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00008271 File Offset: 0x00006471
		public MarshalByValueComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0005EA34 File Offset: 0x0005CC34
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x0000827A File Offset: 0x0000647A
		public unsafe static Object s_eventDisposed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MarshalByValueComponent.NativeFieldInfoPtr_s_eventDisposed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MarshalByValueComponent.NativeFieldInfoPtr_s_eventDisposed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0005EA5C File Offset: 0x0005CC5C
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x0000828C File Offset: 0x0000648C
		public unsafe ISite _site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByValueComponent.NativeFieldInfoPtr__site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByValueComponent.NativeFieldInfoPtr__site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0005EA8C File Offset: 0x0005CC8C
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x000082AB File Offset: 0x000064AB
		public unsafe EventHandlerList _events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByValueComponent.NativeFieldInfoPtr__events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByValueComponent.NativeFieldInfoPtr__events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeFieldInfoPtr_s_eventDisposed;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr__site;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr__events;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_New_get_ISite_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Public_Virtual_New_Object_Type_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

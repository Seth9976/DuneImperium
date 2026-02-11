using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000AE RID: 174
	public class Event : Object
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x0003A268 File Offset: 0x00038468
		// Note: this type is marked as 'beforefieldinit'.
		static Event()
		{
			Il2CppClassPointerStore<Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "Event");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Event>.NativeClassPtr);
			Event.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "Name");
			Event.NativeFieldInfoPtr__Context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "<Context>k__BackingField");
			Event.NativeFieldInfoPtr_propertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "propertiesPhrases");
			Event.NativeMethodInfoPtr_get_Context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664970);
			Event.NativeMethodInfoPtr_set_Context_Private_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664971);
			Event.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664972);
			Event.NativeMethodInfoPtr_WithContext_Public_Event_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664973);
			Event.NativeMethodInfoPtr_Where_Public_Event_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664974);
			Event.NativeMethodInfoPtr_FiredBy_Public_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100664975);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0003A34C File Offset: 0x0003854C
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x0003A38C File Offset: 0x0003858C
		public unsafe Context Context
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_Context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_Context_Private_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0003A3D0 File Offset: 0x000385D0
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 559261, RefRangeEnd = 559357, XrefRangeStart = 559252, XrefRangeEnd = 559261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0003A41C File Offset: 0x0003861C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 559365, RefRangeEnd = 559398, XrefRangeStart = 559357, XrefRangeEnd = 559365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event WithContext(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_WithContext_Public_Event_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0003A46C File Offset: 0x0003866C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 559401, RefRangeEnd = 559436, XrefRangeStart = 559398, XrefRangeEnd = 559401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event Where(Func<Context, bool> propertiesPhrase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertiesPhrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Where_Public_Event_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0003A4BC File Offset: 0x000386BC
		[CallerCount(158)]
		[CachedScanResults(RefRangeStart = 559441, RefRangeEnd = 559599, XrefRangeStart = 559436, XrefRangeEnd = 559441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FiredBy(Event trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_FiredBy_Public_Boolean_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000536C File Offset: 0x0000356C
		public Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0003A50C File Offset: 0x0003870C
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005375 File Offset: 0x00003575
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0003A534 File Offset: 0x00038734
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005394 File Offset: 0x00003594
		public unsafe Context _Context_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr__Context_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr__Context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0003A564 File Offset: 0x00038764
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000053B3 File Offset: 0x000035B3
		public unsafe List<Func<Context, bool>> propertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_propertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<Context, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_propertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr__Context_k__BackingField;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_propertiesPhrases;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Context_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Private_set_Void_Context_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_WithContext_Public_Event_Context_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Event_Func_2_Context_Boolean_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_FiredBy_Public_Boolean_Event_0;
	}
}

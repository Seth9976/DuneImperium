using System;
using Canis.context;
using Canis.context.propertiesphrases;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000B0 RID: 176
	public class SerializableEvent : Event
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x0003A7C4 File Offset: 0x000389C4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableEvent()
		{
			Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializableEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr);
			SerializableEvent.NativeFieldInfoPtr_propertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, "propertiesPhrases");
			SerializableEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664982);
			SerializableEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664983);
			SerializableEvent.NativeMethodInfoPtr_Where_Public_SerializableEvent_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664984);
			SerializableEvent.NativeMethodInfoPtr_WithContext_Public_SerializableEvent_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664985);
			SerializableEvent.NativeMethodInfoPtr_InheritContext_Public_SerializableEvent_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664986);
			SerializableEvent.NativeMethodInfoPtr_Serialize_Public_SerializedEvent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664987);
			SerializableEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664988);
			SerializableEvent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664989);
			SerializableEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr, 100664990);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0003A8BC File Offset: 0x00038ABC
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 559714, RefRangeEnd = 559793, XrefRangeStart = 559703, XrefRangeEnd = 559714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0003A908 File Offset: 0x00038B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559823, RefRangeEnd = 559824, XrefRangeStart = 559793, XrefRangeEnd = 559823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent(SerializableEvent other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0003A954 File Offset: 0x00038B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 559836, RefRangeEnd = 559838, XrefRangeStart = 559824, XrefRangeEnd = 559836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent Where(PropertiesPhrase propertiesPhrase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertiesPhrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr_Where_Public_SerializableEvent_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 559365, RefRangeEnd = 559398, XrefRangeStart = 559365, XrefRangeEnd = 559398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe SerializableEvent WithContext(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr_WithContext_Public_SerializableEvent_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559845, RefRangeEnd = 559846, XrefRangeStart = 559838, XrefRangeEnd = 559845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent InheritContext(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr_InheritContext_Public_SerializableEvent_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0003AA44 File Offset: 0x00038C44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 559859, RefRangeEnd = 559862, XrefRangeStart = 559846, XrefRangeEnd = 559859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEvent Serialize(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEvent.NativeMethodInfoPtr_Serialize_Public_SerializedEvent_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0003AA94 File Offset: 0x00038C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559862, XrefRangeEnd = 559867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559867, XrefRangeEnd = 559882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEvent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0003AB20 File Offset: 0x00038D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559882, XrefRangeEnd = 559889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000053FA File Offset: 0x000035FA
		public SerializableEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0003AB78 File Offset: 0x00038D78
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00005403 File Offset: 0x00003603
		public new unsafe List<PropertiesPhrase> propertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEvent.NativeFieldInfoPtr_propertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertiesPhrase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEvent.NativeFieldInfoPtr_propertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_propertiesPhrases;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_SerializableEvent_PropertiesPhrase_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_WithContext_Public_SerializableEvent_Context_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_InheritContext_Public_SerializableEvent_Context_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_SerializedEvent_Match_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}

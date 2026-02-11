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
	// Token: 0x020000B1 RID: 177
	public class SerializedEvent : Object
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0003ABA8 File Offset: 0x00038DA8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEvent()
		{
			Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr);
			SerializedEvent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr, "Name");
			SerializedEvent.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr, "Context");
			SerializedEvent.NativeFieldInfoPtr_PropertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr, "PropertiesPhrases");
			SerializedEvent.NativeMethodInfoPtr_GenCompleteEvent_Public_SerializableEvent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr, 100664991);
			SerializedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr, 100664992);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0003AC3C File Offset: 0x00038E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 559932, RefRangeEnd = 559936, XrefRangeStart = 559889, XrefRangeEnd = 559932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent GenCompleteEvent(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEvent.NativeMethodInfoPtr_GenCompleteEvent_Public_SerializableEvent_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0003AC8C File Offset: 0x00038E8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00005422 File Offset: 0x00003622
		public SerializedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0000542B File Offset: 0x0000362B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0003ACF0 File Offset: 0x00038EF0
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0000544A File Offset: 0x0000364A
		public unsafe SerializedContext Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0003AD20 File Offset: 0x00038F20
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00005469 File Offset: 0x00003669
		public unsafe List<PropertiesPhrase> PropertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_PropertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertiesPhrase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEvent.NativeFieldInfoPtr_PropertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_Context;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesPhrases;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_GenCompleteEvent_Public_SerializableEvent_Match_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

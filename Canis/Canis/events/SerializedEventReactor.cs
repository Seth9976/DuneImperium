using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000B5 RID: 181
	public class SerializedEventReactor : Object
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x0003B810 File Offset: 0x00039A10
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEventReactor()
		{
			Il2CppClassPointerStore<SerializedEventReactor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializedEventReactor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEventReactor>.NativeClassPtr);
			SerializedEventReactor.NativeFieldInfoPtr_Responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEventReactor>.NativeClassPtr, "Responses");
			SerializedEventReactor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEventReactor>.NativeClassPtr, 100665026);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003B868 File Offset: 0x00039A68
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEventReactor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEventReactor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEventReactor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00005500 File Offset: 0x00003700
		public SerializedEventReactor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0003B8A4 File Offset: 0x00039AA4
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00005509 File Offset: 0x00003709
		public unsafe List<SerializedEventResponse> Responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventReactor.NativeFieldInfoPtr_Responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedEventResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventReactor.NativeFieldInfoPtr_Responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_Responses;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

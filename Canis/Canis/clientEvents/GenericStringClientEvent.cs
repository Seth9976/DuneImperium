using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace Canis.clientEvents
{
	// Token: 0x0200015E RID: 350
	public class GenericStringClientEvent : ClientEvent
	{
		// Token: 0x06000F6C RID: 3948 RVA: 0x00059250 File Offset: 0x00057450
		// Note: this type is marked as 'beforefieldinit'.
		static GenericStringClientEvent()
		{
			Il2CppClassPointerStore<GenericStringClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.clientEvents", "GenericStringClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericStringClientEvent>.NativeClassPtr);
			GenericStringClientEvent.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericStringClientEvent>.NativeClassPtr, "EventName");
			GenericStringClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStringClientEvent>.NativeClassPtr, 100666537);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000592A8 File Offset: 0x000574A8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericStringClientEvent(string eventName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericStringClientEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericStringClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00007D90 File Offset: 0x00005F90
		public GenericStringClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000592F4 File Offset: 0x000574F4
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00007D99 File Offset: 0x00005F99
		public unsafe string EventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericStringClientEvent.NativeFieldInfoPtr_EventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericStringClientEvent.NativeFieldInfoPtr_EventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_EventName;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

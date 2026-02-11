using System;
using dwd.core.eventTriggers.clientTriggers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace lib.canis.boardgames.src.tutorials.triggers
{
	// Token: 0x02000038 RID: 56
	public class GenericStringClientTrigger : ClientTrigger
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00018610 File Offset: 0x00016810
		// Note: this type is marked as 'beforefieldinit'.
		static GenericStringClientTrigger()
		{
			Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.tutorials.triggers", "GenericStringClientTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr);
			GenericStringClientTrigger.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr, "Event");
			GenericStringClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr, 100663724);
			GenericStringClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr, 100663725);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001867C File Offset: 0x0001687C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 983240, RefRangeEnd = 983255, XrefRangeStart = 983240, XrefRangeEnd = 983255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericStringClientTrigger(string Event)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericStringClientTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Event);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericStringClientTrigger.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000186C8 File Offset: 0x000168C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984800, XrefRangeEnd = 984804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool matches(ClientEvent clientEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericStringClientTrigger.NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003019 File Offset: 0x00001219
		public GenericStringClientTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00018720 File Offset: 0x00016920
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00003022 File Offset: 0x00001222
		public unsafe string Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericStringClientTrigger.NativeFieldInfoPtr_Event);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericStringClientTrigger.NativeFieldInfoPtr_Event), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_matches_Protected_Virtual_Boolean_ClientEvent_0;
	}
}

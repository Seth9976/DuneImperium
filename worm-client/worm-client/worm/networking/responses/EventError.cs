using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000071 RID: 113
	public class EventError : NetworkMessageEvent
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00026568 File Offset: 0x00024768
		// Note: this type is marked as 'beforefieldinit'.
		static EventError()
		{
			Il2CppClassPointerStore<EventError>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventError>.NativeClassPtr);
			EventError.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventError>.NativeClassPtr, "error");
			EventError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventError>.NativeClassPtr, 100663948);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000265C0 File Offset: 0x000247C0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000042D0 File Offset: 0x000024D0
		public EventError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000265FC File Offset: 0x000247FC
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x000042D9 File Offset: 0x000024D9
		public unsafe string error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventError.NativeFieldInfoPtr_error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventError.NativeFieldInfoPtr_error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

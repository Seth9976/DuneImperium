using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.eventtriggers.clientactions;

namespace dwd.core.eventTriggers.clientActions
{
	// Token: 0x020001B4 RID: 436
	public class HideArrow : ClientAction
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x000756F4 File Offset: 0x000738F4
		// Note: this type is marked as 'beforefieldinit'.
		static HideArrow()
		{
			Il2CppClassPointerStore<HideArrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientActions", "HideArrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideArrow>.NativeClassPtr);
			HideArrow.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideArrow>.NativeClassPtr, "Handle");
			HideArrow.NativeMethodInfoPtr__ctor_Public_Void_ArrowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideArrow>.NativeClassPtr, 100667208);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0007574C File Offset: 0x0007394C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 578945, RefRangeEnd = 578947, XrefRangeStart = 578945, XrefRangeEnd = 578947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideArrow(ArrowID handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideArrow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideArrow.NativeMethodInfoPtr__ctor_Public_Void_ArrowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000ABBC File Offset: 0x00008DBC
		public HideArrow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00075798 File Offset: 0x00073998
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000ABC5 File Offset: 0x00008DC5
		public unsafe ArrowID Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideArrow.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrowID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideArrow.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrowID_0;
	}
}

using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x0200004F RID: 79
	public class AckMsg : NetworkMessageEvent
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000C820 File Offset: 0x0000AA20
		// Note: this type is marked as 'beforefieldinit'.
		static AckMsg()
		{
			Il2CppClassPointerStore<AckMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "AckMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AckMsg>.NativeClassPtr);
			AckMsg.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AckMsg>.NativeClassPtr, "Counter");
			AckMsg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AckMsg>.NativeClassPtr, 100663428);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000C878 File Offset: 0x0000AA78
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AckMsg()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AckMsg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AckMsg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003AFC File Offset: 0x00001CFC
		public AckMsg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003B05 File Offset: 0x00001D05
		public unsafe string Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AckMsg.NativeFieldInfoPtr_Counter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AckMsg.NativeFieldInfoPtr_Counter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

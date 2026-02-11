using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001AA RID: 426
	public class SystemNetworkCredential : NetworkCredential
	{
		// Token: 0x06001AA6 RID: 6822 RVA: 0x00084C0C File Offset: 0x00082E0C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemNetworkCredential()
		{
			Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SystemNetworkCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr);
			SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, "defaultCredential");
			SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, 100667445);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00084C64 File Offset: 0x00082E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474041, XrefRangeEnd = 474044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemNetworkCredential()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0000B6A1 File Offset: 0x000098A1
		public SystemNetworkCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00084CA0 File Offset: 0x00082EA0
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x0000B6AA File Offset: 0x000098AA
		public unsafe static SystemNetworkCredential defaultCredential
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemNetworkCredential>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_defaultCredential;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}

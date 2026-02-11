using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platform.data
{
	// Token: 0x0200002B RID: 43
	public class PlatformAttributes : Object
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0000AF28 File Offset: 0x00009128
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformAttributes()
		{
			Il2CppClassPointerStore<PlatformAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.platform.data", "PlatformAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAttributes>.NativeClassPtr);
			PlatformAttributes.NativeFieldInfoPtr_ClientAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAttributes>.NativeClassPtr, "ClientAttributes");
			PlatformAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAttributes>.NativeClassPtr, 100663550);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000AF80 File Offset: 0x00009180
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002848 File Offset: 0x00000A48
		public PlatformAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000AFBC File Offset: 0x000091BC
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002851 File Offset: 0x00000A51
		public unsafe Dictionary<string, Object> ClientAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAttributes.NativeFieldInfoPtr_ClientAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAttributes.NativeFieldInfoPtr_ClientAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_ClientAttributes;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

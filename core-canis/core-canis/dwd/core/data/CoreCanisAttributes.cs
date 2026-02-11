using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001C3 RID: 451
	public class CoreCanisAttributes : Object
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x0007820C File Offset: 0x0007640C
		// Note: this type is marked as 'beforefieldinit'.
		static CoreCanisAttributes()
		{
			Il2CppClassPointerStore<CoreCanisAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "CoreCanisAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreCanisAttributes>.NativeClassPtr);
			CoreCanisAttributes.NativeFieldInfoPtr_XBToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCanisAttributes>.NativeClassPtr, "XBToken");
			CoreCanisAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCanisAttributes>.NativeClassPtr, 100667299);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00078264 File Offset: 0x00076464
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreCanisAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreCanisAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCanisAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0000B146 File Offset: 0x00009346
		public CoreCanisAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x000782A0 File Offset: 0x000764A0
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0000B14F File Offset: 0x0000934F
		public unsafe static AttributeDefinition<string> XBToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreCanisAttributes.NativeFieldInfoPtr_XBToken, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreCanisAttributes.NativeFieldInfoPtr_XBToken, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_XBToken;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

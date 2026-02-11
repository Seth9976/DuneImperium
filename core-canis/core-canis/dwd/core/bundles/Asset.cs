using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.bundles
{
	// Token: 0x020001F1 RID: 497
	[Serializable]
	public class Asset : Object
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
		// Note: this type is marked as 'beforefieldinit'.
		static Asset()
		{
			Il2CppClassPointerStore<Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "Asset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Asset>.NativeClassPtr);
			Asset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asset>.NativeClassPtr, "name");
			Asset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asset>.NativeClassPtr, 100667588);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0007F238 File Offset: 0x0007D438
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Asset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Asset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000BA48 File Offset: 0x00009C48
		public Asset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0007F274 File Offset: 0x0007D474
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000BA51 File Offset: 0x00009C51
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asset.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

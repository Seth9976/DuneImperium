using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.user
{
	// Token: 0x0200004A RID: 74
	public class NameMetadata : Object
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		// Note: this type is marked as 'beforefieldinit'.
		static NameMetadata()
		{
			Il2CppClassPointerStore<NameMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "NameMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameMetadata>.NativeClassPtr);
			NameMetadata.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameMetadata>.NativeClassPtr, "Metadata");
			NameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameMetadata>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000C254 File Offset: 0x0000A454
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000039F1 File Offset: 0x00001BF1
		public NameMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000C290 File Offset: 0x0000A490
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000039FA File Offset: 0x00001BFA
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameMetadata.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameMetadata.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

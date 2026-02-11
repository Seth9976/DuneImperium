using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.user
{
	// Token: 0x02000049 RID: 73
	public class FederatedNameData : Object
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0000C138 File Offset: 0x0000A338
		// Note: this type is marked as 'beforefieldinit'.
		static FederatedNameData()
		{
			Il2CppClassPointerStore<FederatedNameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "FederatedNameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FederatedNameData>.NativeClassPtr);
			FederatedNameData.NativeFieldInfoPtr_FederationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FederatedNameData>.NativeClassPtr, "FederationMap");
			FederatedNameData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederatedNameData>.NativeClassPtr, 100663417);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000C190 File Offset: 0x0000A390
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FederatedNameData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FederatedNameData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederatedNameData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000039C9 File Offset: 0x00001BC9
		public FederatedNameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000039D2 File Offset: 0x00001BD2
		public unsafe Dictionary<string, NameMetadata> FederationMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederatedNameData.NativeFieldInfoPtr_FederationMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederatedNameData.NativeFieldInfoPtr_FederationMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_FederationMap;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

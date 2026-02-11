using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.direBytes.messages
{
	// Token: 0x0200001D RID: 29
	public class GetDireBytes : global::Il2CppSystem.Object
	{
		// Token: 0x0600015D RID: 349 RVA: 0x000073B4 File Offset: 0x000055B4
		// Note: this type is marked as 'beforefieldinit'.
		static GetDireBytes()
		{
			Il2CppClassPointerStore<GetDireBytes>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "GetDireBytes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetDireBytes>.NativeClassPtr);
			GetDireBytes.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDireBytes>.NativeClassPtr, "Platform");
			GetDireBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDireBytes>.NativeClassPtr, 100663434);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000740C File Offset: 0x0000560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235020, XrefRangeEnd = 1235025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetDireBytes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetDireBytes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetDireBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002C3F File Offset: 0x00000E3F
		public GetDireBytes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00007448 File Offset: 0x00005648
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002C48 File Offset: 0x00000E48
		public unsafe RuntimePlatform Platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDireBytes.NativeFieldInfoPtr_Platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDireBytes.NativeFieldInfoPtr_Platform)) = value;
			}
		}

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_Platform;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

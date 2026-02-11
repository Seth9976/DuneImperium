using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.direBytes.messages
{
	// Token: 0x02000018 RID: 24
	public class DireBytesFound : NetworkMessageEvent
	{
		// Token: 0x06000112 RID: 274 RVA: 0x000069AC File Offset: 0x00004BAC
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesFound()
		{
			Il2CppClassPointerStore<DireBytesFound>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireBytesFound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesFound>.NativeClassPtr);
			DireBytesFound.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesFound>.NativeClassPtr, "Tiles");
			DireBytesFound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesFound>.NativeClassPtr, 100663429);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006A04 File Offset: 0x00004C04
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesFound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesFound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesFound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002856 File Offset: 0x00000A56
		public DireBytesFound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006A40 File Offset: 0x00004C40
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000285F File Offset: 0x00000A5F
		public unsafe List<DireByteTile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesFound.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DireByteTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesFound.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

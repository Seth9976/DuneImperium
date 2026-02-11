using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000139 RID: 313
	public class WormHelenaReserveViewRenderer : Observer
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x00042A0C File Offset: 0x00040C0C
		// Note: this type is marked as 'beforefieldinit'.
		static WormHelenaReserveViewRenderer()
		{
			Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHelenaReserveViewRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr);
			WormHelenaReserveViewRenderer.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr, "header");
			WormHelenaReserveViewRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr, 100665206);
			WormHelenaReserveViewRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr, 100665207);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00042A78 File Offset: 0x00040C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706217, XrefRangeEnd = 706227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHelenaReserveViewRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00042AB4 File Offset: 0x00040CB4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHelenaReserveViewRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHelenaReserveViewRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveViewRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000969E File Offset: 0x0000789E
		public WormHelenaReserveViewRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00042AF0 File Offset: 0x00040CF0
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x000096A7 File Offset: 0x000078A7
		public unsafe GameObject header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveViewRenderer.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveViewRenderer.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

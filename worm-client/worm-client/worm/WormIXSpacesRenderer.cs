using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm
{
	// Token: 0x02000040 RID: 64
	public class WormIXSpacesRenderer : Observer
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x00021564 File Offset: 0x0001F764
		// Note: this type is marked as 'beforefieldinit'.
		static WormIXSpacesRenderer()
		{
			Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormIXSpacesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr);
			WormIXSpacesRenderer.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr, "icon");
			WormIXSpacesRenderer.NativeFieldInfoPtr_matchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr, "matchData");
			WormIXSpacesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr, 100663743);
			WormIXSpacesRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr, 100663744);
			WormIXSpacesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr, 100663745);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000215F8 File Offset: 0x0001F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690673, XrefRangeEnd = 690683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIXSpacesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00021634 File Offset: 0x0001F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690683, XrefRangeEnd = 690692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIXSpacesRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00021670 File Offset: 0x0001F870
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIXSpacesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIXSpacesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIXSpacesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003470 File Offset: 0x00001670
		public WormIXSpacesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000216AC File Offset: 0x0001F8AC
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00003479 File Offset: 0x00001679
		public unsafe GameObject icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIXSpacesRenderer.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIXSpacesRenderer.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000216DC File Offset: 0x0001F8DC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003498 File Offset: 0x00001698
		public unsafe GameOptionsData matchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIXSpacesRenderer.NativeFieldInfoPtr_matchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIXSpacesRenderer.NativeFieldInfoPtr_matchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_matchData;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

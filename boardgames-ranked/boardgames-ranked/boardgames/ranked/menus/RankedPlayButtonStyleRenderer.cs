using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x02000022 RID: 34
	public class RankedPlayButtonStyleRenderer : VersionedView<RankedPlayProvider>
	{
		// Token: 0x06000114 RID: 276 RVA: 0x000062F8 File Offset: 0x000044F8
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayButtonStyleRenderer()
		{
			Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayButtonStyleRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr);
			RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_underwayParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, "underwayParam");
			RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, "anim");
			RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, 100663366);
			RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, 100663367);
			RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, 100663368);
			RankedPlayButtonStyleRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr, 100663369);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000063A0 File Offset: 0x000045A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225114, XrefRangeEnd = 1225125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000063DC File Offset: 0x000045DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225125, XrefRangeEnd = 1225126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006418 File Offset: 0x00004618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225138, RefRangeEnd = 1225140, XrefRangeStart = 1225126, XrefRangeEnd = 1225138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButtonStyleRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000644C File Offset: 0x0000464C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225140, XrefRangeEnd = 1225146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayButtonStyleRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayButtonStyleRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButtonStyleRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002B9C File Offset: 0x00000D9C
		public RankedPlayButtonStyleRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006488 File Offset: 0x00004688
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public unsafe string underwayParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_underwayParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_underwayParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButtonStyleRenderer.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_underwayParam;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

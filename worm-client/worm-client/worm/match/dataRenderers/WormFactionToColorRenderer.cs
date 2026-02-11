using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000125 RID: 293
	public class WormFactionToColorRenderer : WormColorRenderer
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x00040AFC File Offset: 0x0003ECFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionToColorRenderer()
		{
			Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionToColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr);
			WormFactionToColorRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, "animator");
			WormFactionToColorRenderer.NativeFieldInfoPtr_colorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, "colorDict");
			WormFactionToColorRenderer.NativeFieldInfoPtr_PlayerColorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, "PlayerColorParam");
			WormFactionToColorRenderer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, 100665128);
			WormFactionToColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, 100665129);
			WormFactionToColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr, 100665130);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00040BA4 File Offset: 0x0003EDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705617, XrefRangeEnd = 705620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionToColorRenderer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00040BE0 File Offset: 0x0003EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705620, XrefRangeEnd = 705630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionToColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00040C1C File Offset: 0x0003EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705630, XrefRangeEnd = 705650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionToColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionToColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionToColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000091BB File Offset: 0x000073BB
		public WormFactionToColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00040C58 File Offset: 0x0003EE58
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x000091C4 File Offset: 0x000073C4
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionToColorRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionToColorRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00040C88 File Offset: 0x0003EE88
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x000091E3 File Offset: 0x000073E3
		public unsafe Dictionary<PieceColor, int> colorDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionToColorRenderer.NativeFieldInfoPtr_colorDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PieceColor, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionToColorRenderer.NativeFieldInfoPtr_colorDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00040CB8 File Offset: 0x0003EEB8
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00009202 File Offset: 0x00007402
		public unsafe static int PlayerColorParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFactionToColorRenderer.NativeFieldInfoPtr_PlayerColorParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFactionToColorRenderer.NativeFieldInfoPtr_PlayerColorParam, (void*)(&value));
			}
		}

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_colorDict;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_PlayerColorParam;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

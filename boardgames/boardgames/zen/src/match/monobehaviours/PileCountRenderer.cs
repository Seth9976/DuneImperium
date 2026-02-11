using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000072 RID: 114
	public class PileCountRenderer : VersionedSubscriber<EntityComponent>
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00023A10 File Offset: 0x00021C10
		// Note: this type is marked as 'beforefieldinit'.
		static PileCountRenderer()
		{
			Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "PileCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr);
			PileCountRenderer.NativeFieldInfoPtr_minToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, "minToShow");
			PileCountRenderer.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, "colors");
			PileCountRenderer.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, "label");
			PileCountRenderer.NativeFieldInfoPtr_previousCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, "previousCount");
			PileCountRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, 100664254);
			PileCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, 100664255);
			PileCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr, 100664256);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00023ACC File Offset: 0x00021CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988367, XrefRangeEnd = 988374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileCountRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00023B00 File Offset: 0x00021D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988374, XrefRangeEnd = 988385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00023B3C File Offset: 0x00021D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988385, XrefRangeEnd = 988392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00004BF1 File Offset: 0x00002DF1
		public PileCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00023B78 File Offset: 0x00021D78
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004BFA File Offset: 0x00002DFA
		public unsafe int minToShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_minToShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_minToShow)) = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00023BA0 File Offset: 0x00021DA0
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00004C15 File Offset: 0x00002E15
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00023BD0 File Offset: 0x00021DD0
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00004C34 File Offset: 0x00002E34
		public unsafe TMP_Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00023C00 File Offset: 0x00021E00
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00004C53 File Offset: 0x00002E53
		public unsafe int previousCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_previousCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountRenderer.NativeFieldInfoPtr_previousCount)) = value;
			}
		}

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_minToShow;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_previousCount;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FC RID: 252
	public class WormBonusSpiceRenderer : VersionedDataComponentObserver<WormBonusSpiceData>
	{
		// Token: 0x06000B41 RID: 2881 RVA: 0x0003A498 File Offset: 0x00038698
		// Note: this type is marked as 'beforefieldinit'.
		static WormBonusSpiceRenderer()
		{
			Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormBonusSpiceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr);
			WormBonusSpiceRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "text");
			WormBonusSpiceRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "animator");
			WormBonusSpiceRenderer.NativeFieldInfoPtr_cachedSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "cachedSpice");
			WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "NewSpiceParam");
			WormBonusSpiceRenderer.NativeFieldInfoPtr_SpiceRemovedParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "SpiceRemovedParam");
			WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceAdditionalParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, "NewSpiceAdditionalParam");
			WormBonusSpiceRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, 100664860);
			WormBonusSpiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr, 100664861);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0003A568 File Offset: 0x00038768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703023, XrefRangeEnd = 703040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBonusSpiceRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003A5A4 File Offset: 0x000387A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703040, XrefRangeEnd = 703043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBonusSpiceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBonusSpiceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusSpiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00007EBF File Offset: 0x000060BF
		public WormBonusSpiceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0003A5E0 File Offset: 0x000387E0
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00007EC8 File Offset: 0x000060C8
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0003A610 File Offset: 0x00038810
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00007EE7 File Offset: 0x000060E7
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0003A640 File Offset: 0x00038840
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00007F06 File Offset: 0x00006106
		public unsafe int cachedSpice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_cachedSpice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceRenderer.NativeFieldInfoPtr_cachedSpice)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0003A668 File Offset: 0x00038868
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00007F21 File Offset: 0x00006121
		public unsafe static int NewSpiceParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceParam, (void*)(&value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0003A684 File Offset: 0x00038884
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00007F2F File Offset: 0x0000612F
		public unsafe static int SpiceRemovedParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_SpiceRemovedParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_SpiceRemovedParam, (void*)(&value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003A6A0 File Offset: 0x000388A0
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00007F3D File Offset: 0x0000613D
		public unsafe static int NewSpiceAdditionalParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceAdditionalParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormBonusSpiceRenderer.NativeFieldInfoPtr_NewSpiceAdditionalParam, (void*)(&value));
			}
		}

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_cachedSpice;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_NewSpiceParam;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_SpiceRemovedParam;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr_NewSpiceAdditionalParam;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

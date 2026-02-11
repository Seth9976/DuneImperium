using System;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000142 RID: 322
	public class WormLeaderAbilityRenderer : VersionedSubscriber<NameData>
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x00043BC0 File Offset: 0x00041DC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderAbilityRenderer()
		{
			Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormLeaderAbilityRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr);
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "staticAbilityTitleText");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "staticAbilityDescText");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "signetAbilityTitleText");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "signetAbilityDescText");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleLocExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "staticAbilityTitleLocExt");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescLocExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "staticAbilityDescLocExt");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleLocExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "signetAbilityTitleLocExt");
			WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescLocExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, "signetAbilityDescLocExt");
			WormLeaderAbilityRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, 100665262);
			WormLeaderAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr, 100665263);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00043CB8 File Offset: 0x00041EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706650, XrefRangeEnd = 706685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderAbilityRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00043CF4 File Offset: 0x00041EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706685, XrefRangeEnd = 706697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderAbilityRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderAbilityRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000099E8 File Offset: 0x00007BE8
		public WormLeaderAbilityRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00043D30 File Offset: 0x00041F30
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x000099F1 File Offset: 0x00007BF1
		public unsafe TMP_Text staticAbilityTitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00043D60 File Offset: 0x00041F60
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00009A10 File Offset: 0x00007C10
		public unsafe TMP_Text staticAbilityDescText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00043D90 File Offset: 0x00041F90
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00009A2F File Offset: 0x00007C2F
		public unsafe TMP_Text signetAbilityTitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00043DC0 File Offset: 0x00041FC0
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00009A4E File Offset: 0x00007C4E
		public unsafe TMP_Text signetAbilityDescText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00043DF0 File Offset: 0x00041FF0
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00009A6D File Offset: 0x00007C6D
		public unsafe string staticAbilityTitleLocExt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleLocExt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityTitleLocExt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00043E18 File Offset: 0x00042018
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x00009A8C File Offset: 0x00007C8C
		public unsafe string staticAbilityDescLocExt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescLocExt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_staticAbilityDescLocExt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00043E40 File Offset: 0x00042040
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00009AAB File Offset: 0x00007CAB
		public unsafe string signetAbilityTitleLocExt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleLocExt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityTitleLocExt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00043E68 File Offset: 0x00042068
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00009ACA File Offset: 0x00007CCA
		public unsafe string signetAbilityDescLocExt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescLocExt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderAbilityRenderer.NativeFieldInfoPtr_signetAbilityDescLocExt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_staticAbilityTitleText;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_staticAbilityDescText;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr_signetAbilityTitleText;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr_signetAbilityDescText;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeFieldInfoPtr_staticAbilityTitleLocExt;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeFieldInfoPtr_staticAbilityDescLocExt;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeFieldInfoPtr_signetAbilityTitleLocExt;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_signetAbilityDescLocExt;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

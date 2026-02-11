using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.src.match.components
{
	// Token: 0x02000034 RID: 52
	public class WormRevealPreviewTooltipSource : MonoBehaviour
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealPreviewTooltipSource()
		{
			Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "lib.src.match.components", "WormRevealPreviewTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr);
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKeyWithExtra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "persuasionLocKeyWithExtra");
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "persuasionLocKey");
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKeyWithExtra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "strengthLocKeyWithExtra");
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "strengthLocKey");
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_specimensLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "specimensLocKey");
			WormRevealPreviewTooltipSource.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, "entitiesProvider");
			WormRevealPreviewTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, 100663683);
			WormRevealPreviewTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, 100663684);
			WormRevealPreviewTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr, 100663685);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001FC40 File Offset: 0x0001DE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689991, XrefRangeEnd = 689994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealPreviewTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001FC74 File Offset: 0x0001DE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689994, XrefRangeEnd = 690131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealPreviewTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001FCAC File Offset: 0x0001DEAC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealPreviewTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealPreviewTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealPreviewTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00003030 File Offset: 0x00001230
		public WormRevealPreviewTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00003039 File Offset: 0x00001239
		public unsafe static string persuasionLocKeyWithExtra
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKeyWithExtra, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKeyWithExtra, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001FD08 File Offset: 0x0001DF08
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000304B File Offset: 0x0000124B
		public unsafe static string persuasionLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_persuasionLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0001FD28 File Offset: 0x0001DF28
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0000305D File Offset: 0x0000125D
		public unsafe static string strengthLocKeyWithExtra
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKeyWithExtra, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKeyWithExtra, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0001FD48 File Offset: 0x0001DF48
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000306F File Offset: 0x0000126F
		public unsafe static string strengthLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_strengthLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001FD68 File Offset: 0x0001DF68
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00003081 File Offset: 0x00001281
		public unsafe static string specimensLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_specimensLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_specimensLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0001FD88 File Offset: 0x0001DF88
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00003093 File Offset: 0x00001293
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealPreviewTooltipSource.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_persuasionLocKeyWithExtra;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_persuasionLocKey;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_strengthLocKeyWithExtra;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_strengthLocKey;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_specimensLocKey;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

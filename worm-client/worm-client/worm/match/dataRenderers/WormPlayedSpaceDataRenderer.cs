using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.boardgames.src.match;
using UnityEngine;
using voodoo;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014A RID: 330
	public class WormPlayedSpaceDataRenderer : VersionedDataComponentObserver<WormPlayedSpaceData>
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00044ADC File Offset: 0x00042CDC
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayedSpaceDataRenderer()
		{
			Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayedSpaceDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr);
			WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_overlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, "overlay");
			WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, "archetypeProvider");
			WormPlayedSpaceDataRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, 100665296);
			WormPlayedSpaceDataRenderer.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, 100665297);
			WormPlayedSpaceDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, 100665298);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00044B70 File Offset: 0x00042D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707034, XrefRangeEnd = 707047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayedSpaceDataRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00044BAC File Offset: 0x00042DAC
		[CallerCount(0)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayedSpaceDataRenderer.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00044BE0 File Offset: 0x00042DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707047, XrefRangeEnd = 707050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayedSpaceDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayedSpaceDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00009CD6 File Offset: 0x00007ED6
		public WormPlayedSpaceDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00044C1C File Offset: 0x00042E1C
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00009CDF File Offset: 0x00007EDF
		public unsafe GameObject overlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_overlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_overlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00044C4C File Offset: 0x00042E4C
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00009CFE File Offset: 0x00007EFE
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr_overlay;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000395 RID: 917
		[Serializable]
		public sealed class IconSpriteNamePair : ValueType
		{
			// Token: 0x060024E3 RID: 9443 RVA: 0x00087A1C File Offset: 0x00085C1C
			// Note: this type is marked as 'beforefieldinit'.
			static IconSpriteNamePair()
			{
				Il2CppClassPointerStore<WormPlayedSpaceDataRenderer.IconSpriteNamePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer>.NativeClassPtr, "IconSpriteNamePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer.IconSpriteNamePair>.NativeClassPtr);
				WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_agentIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer.IconSpriteNamePair>.NativeClassPtr, "agentIcon");
				WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer.IconSpriteNamePair>.NativeClassPtr, "spriteName");
			}

			// Token: 0x060024E4 RID: 9444 RVA: 0x000148FA File Offset: 0x00012AFA
			public IconSpriteNamePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060024E5 RID: 9445 RVA: 0x00014903 File Offset: 0x00012B03
			public IconSpriteNamePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayedSpaceDataRenderer.IconSpriteNamePair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00087A70 File Offset: 0x00085C70
			// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00014915 File Offset: 0x00012B15
			public unsafe AgentIcons agentIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_agentIcon);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_agentIcon)) = value;
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x060024E8 RID: 9448 RVA: 0x00087A98 File Offset: 0x00085C98
			// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00014930 File Offset: 0x00012B30
			public unsafe string spriteName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_spriteName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceDataRenderer.IconSpriteNamePair.NativeFieldInfoPtr_spriteName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeFieldInfoPtr_agentIcon;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeFieldInfoPtr_spriteName;
		}
	}
}

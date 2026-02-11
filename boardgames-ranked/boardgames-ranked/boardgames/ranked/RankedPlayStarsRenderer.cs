using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.ranked
{
	// Token: 0x02000008 RID: 8
	public class RankedPlayStarsRenderer : MonoBehaviour
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003F40 File Offset: 0x00002140
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayStarsRenderer()
		{
			Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked", "RankedPlayStarsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr);
			RankedPlayStarsRenderer.NativeFieldInfoPtr_starPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, "starPrefab");
			RankedPlayStarsRenderer.NativeFieldInfoPtr_FilledParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, "FilledParam");
			RankedPlayStarsRenderer.NativeFieldInfoPtr_starBackers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, "starBackers");
			RankedPlayStarsRenderer.NativeFieldInfoPtr_cachedStars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, "cachedStars");
			RankedPlayStarsRenderer.NativeMethodInfoPtr_ShowStars_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, 100663310);
			RankedPlayStarsRenderer.NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, 100663311);
			RankedPlayStarsRenderer.NativeMethodInfoPtr_HideStars_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, 100663312);
			RankedPlayStarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004010 File Offset: 0x00002210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224669, XrefRangeEnd = 1224685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowStars(int stars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stars;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayStarsRenderer.NativeMethodInfoPtr_ShowStars_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004050 File Offset: 0x00002250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnStars(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayStarsRenderer.NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004090 File Offset: 0x00002290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224685, XrefRangeEnd = 1224700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideStars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayStarsRenderer.NativeMethodInfoPtr_HideStars_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000040C4 File Offset: 0x000022C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayStarsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayStarsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayStarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002146 File Offset: 0x00000346
		public RankedPlayStarsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004100 File Offset: 0x00002300
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000214F File Offset: 0x0000034F
		public unsafe Animator starPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_starPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_starPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004130 File Offset: 0x00002330
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe static int FilledParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedPlayStarsRenderer.NativeFieldInfoPtr_FilledParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedPlayStarsRenderer.NativeFieldInfoPtr_FilledParam, (void*)(&value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000414C File Offset: 0x0000234C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe List<GameObject> starBackers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_starBackers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_starBackers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000417C File Offset: 0x0000237C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000219B File Offset: 0x0000039B
		public unsafe int cachedStars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_cachedStars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayStarsRenderer.NativeFieldInfoPtr_cachedStars)) = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_starPrefab;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_FilledParam;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_starBackers;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_cachedStars;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_ShowStars_Public_Void_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_HideStars_Public_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

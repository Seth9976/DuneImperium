using System;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000096 RID: 150
	public class WormReputationRenderer : MonoBehaviour
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x0002A860 File Offset: 0x00028A60
		// Note: this type is marked as 'beforefieldinit'.
		static WormReputationRenderer()
		{
			Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormReputationRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr);
			WormReputationRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, "text");
			WormReputationRenderer.NativeFieldInfoPtr_cachedRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, "cachedRep");
			WormReputationRenderer.NativeFieldInfoPtr_RepLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, "RepLimit");
			WormReputationRenderer.NativeFieldInfoPtr_enableBelowRepLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, "enableBelowRepLimit");
			WormReputationRenderer.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, "provider");
			WormReputationRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, 100664129);
			WormReputationRenderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, 100664130);
			WormReputationRenderer.NativeMethodInfoPtr_DirtyUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, 100664131);
			WormReputationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr, 100664132);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0002A944 File Offset: 0x00028B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695681, XrefRangeEnd = 695684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0002A978 File Offset: 0x00028B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695684, XrefRangeEnd = 695687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationRenderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0002A9AC File Offset: 0x00028BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695705, RefRangeEnd = 695706, XrefRangeStart = 695687, XrefRangeEnd = 695705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationRenderer.NativeMethodInfoPtr_DirtyUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695706, XrefRangeEnd = 695714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormReputationRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormReputationRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004E69 File Offset: 0x00003069
		public WormReputationRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0002AA1C File Offset: 0x00028C1C
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00004E72 File Offset: 0x00003072
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0002AA4C File Offset: 0x00028C4C
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00004E91 File Offset: 0x00003091
		public unsafe int cachedRep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_cachedRep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_cachedRep)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0002AA74 File Offset: 0x00028C74
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00004EAC File Offset: 0x000030AC
		public unsafe int RepLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_RepLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_RepLimit)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0002AA9C File Offset: 0x00028C9C
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00004EC7 File Offset: 0x000030C7
		public unsafe List<GameObject> enableBelowRepLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_enableBelowRepLimit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_enableBelowRepLimit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0002AACC File Offset: 0x00028CCC
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00004EE6 File Offset: 0x000030E6
		public unsafe AccountProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationRenderer.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_cachedRep;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_RepLimit;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_enableBelowRepLimit;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Private_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

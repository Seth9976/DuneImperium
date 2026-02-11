using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x0200015E RID: 350
	public class DailyChallengeButtonInfoRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004F590 File Offset: 0x0004D790
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeButtonInfoRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeButtonInfoRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr);
			DailyChallengeButtonInfoRenderer.NativeFieldInfoPtr_infoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr, "infoPanel");
			DailyChallengeButtonInfoRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr, 100665534);
			DailyChallengeButtonInfoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr, 100665535);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513504, XrefRangeEnd = 513506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeButtonInfoRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004F64C File Offset: 0x0004D84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513506, XrefRangeEnd = 513509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeButtonInfoRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeButtonInfoRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeButtonInfoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0000992B File Offset: 0x00007B2B
		public DailyChallengeButtonInfoRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004F688 File Offset: 0x0004D888
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00009934 File Offset: 0x00007B34
		public unsafe GameObject infoPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeButtonInfoRenderer.NativeFieldInfoPtr_infoPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeButtonInfoRenderer.NativeFieldInfoPtr_infoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr_infoPanel;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

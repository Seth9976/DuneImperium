using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x0200016E RID: 366
	public class WormTransformChildCountRenderer : MonoBehaviour
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x00049064 File Offset: 0x00047264
		// Note: this type is marked as 'beforefieldinit'.
		static WormTransformChildCountRenderer()
		{
			Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTransformChildCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr);
			WormTransformChildCountRenderer.NativeFieldInfoPtr_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr, "countText");
			WormTransformChildCountRenderer.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr, 100665502);
			WormTransformChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr, 100665503);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000490D0 File Offset: 0x000472D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709146, XrefRangeEnd = 709180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTransformChildCountRenderer.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00049104 File Offset: 0x00047304
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTransformChildCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTransformChildCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTransformChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0000A982 File Offset: 0x00008B82
		public WormTransformChildCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00049140 File Offset: 0x00047340
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x0000A98B File Offset: 0x00008B8B
		public unsafe TMP_Text countText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTransformChildCountRenderer.NativeFieldInfoPtr_countText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTransformChildCountRenderer.NativeFieldInfoPtr_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_countText;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

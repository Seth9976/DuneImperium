using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001EB RID: 491
	public class WormEndAgentTurnButtonHinter : MonoBehaviour
	{
		// Token: 0x060015BA RID: 5562 RVA: 0x0005A290 File Offset: 0x00058490
		// Note: this type is marked as 'beforefieldinit'.
		static WormEndAgentTurnButtonHinter()
		{
			Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEndAgentTurnButtonHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr);
			WormEndAgentTurnButtonHinter.NativeFieldInfoPtr_HintParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr, "HintParam");
			WormEndAgentTurnButtonHinter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr, 100666302);
			WormEndAgentTurnButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr, 100666303);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0005A2FC File Offset: 0x000584FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715765, XrefRangeEnd = 715779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndAgentTurnButtonHinter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0005A330 File Offset: 0x00058530
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEndAgentTurnButtonHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEndAgentTurnButtonHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndAgentTurnButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0000D257 File Offset: 0x0000B457
		public WormEndAgentTurnButtonHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0005A36C File Offset: 0x0005856C
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0000D260 File Offset: 0x0000B460
		public unsafe static int HintParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormEndAgentTurnButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEndAgentTurnButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&value));
			}
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_HintParam;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

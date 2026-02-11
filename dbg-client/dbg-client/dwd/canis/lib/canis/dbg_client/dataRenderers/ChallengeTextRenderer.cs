using System;
using dwd.canis.lib.canis.dbg_client.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace dwd.canis.lib.canis.dbg_client.dataRenderers
{
	// Token: 0x02000058 RID: 88
	public class ChallengeTextRenderer : Subscriber<ChallengeTextData>
	{
		// Token: 0x06000360 RID: 864 RVA: 0x00028500 File Offset: 0x00026700
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeTextRenderer()
		{
			Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataRenderers", "ChallengeTextRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr);
			ChallengeTextRenderer.NativeFieldInfoPtr_textType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr, "textType");
			ChallengeTextRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr, "text");
			ChallengeTextRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr, 100663832);
			ChallengeTextRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr, 100663833);
			ChallengeTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr, 100663834);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00028594 File Offset: 0x00026794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499789, XrefRangeEnd = 499794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeTextRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000285D0 File Offset: 0x000267D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499794, XrefRangeEnd = 499808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeTextRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0002860C File Offset: 0x0002680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499808, XrefRangeEnd = 499811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeTextRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeTextRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003775 File Offset: 0x00001975
		public ChallengeTextRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00028648 File Offset: 0x00026848
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0000377E File Offset: 0x0000197E
		public unsafe ChallengeTextData.ChallengeTextType textType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextRenderer.NativeFieldInfoPtr_textType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextRenderer.NativeFieldInfoPtr_textType)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00028670 File Offset: 0x00026870
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00003799 File Offset: 0x00001999
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_textType;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

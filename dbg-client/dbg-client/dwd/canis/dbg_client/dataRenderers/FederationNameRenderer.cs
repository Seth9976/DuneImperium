using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace dwd.canis.dbg_client.dataRenderers
{
	// Token: 0x0200007B RID: 123
	public class FederationNameRenderer : VersionedSubscriber<FederationData>
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x0002C02C File Offset: 0x0002A22C
		// Note: this type is marked as 'beforefieldinit'.
		static FederationNameRenderer()
		{
			Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.dataRenderers", "FederationNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr);
			FederationNameRenderer.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr, "NameText");
			FederationNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr, 100664010);
			FederationNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr, 100664011);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002C098 File Offset: 0x0002A298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501028, XrefRangeEnd = 501029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501029, XrefRangeEnd = 501032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FederationNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FederationNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000415D File Offset: 0x0000235D
		public FederationNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0002C110 File Offset: 0x0002A310
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00004166 File Offset: 0x00002366
		public unsafe TMP_Text NameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederationNameRenderer.NativeFieldInfoPtr_NameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederationNameRenderer.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_NameText;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

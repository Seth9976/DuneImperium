using System;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using voodoo;

namespace worm.match.dataRenderers
{
	// Token: 0x0200016D RID: 365
	public class WormTopLevelNameRenderer : VersionedDataComponentObserver<NameData>
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x00048F50 File Offset: 0x00047150
		// Note: this type is marked as 'beforefieldinit'.
		static WormTopLevelNameRenderer()
		{
			Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTopLevelNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr);
			WormTopLevelNameRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr, "text");
			WormTopLevelNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr, 100665500);
			WormTopLevelNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr, 100665501);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00048FBC File Offset: 0x000471BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709130, XrefRangeEnd = 709143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTopLevelNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00048FF8 File Offset: 0x000471F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709143, XrefRangeEnd = 709146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTopLevelNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTopLevelNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTopLevelNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0000A95A File Offset: 0x00008B5A
		public WormTopLevelNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00049034 File Offset: 0x00047234
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0000A963 File Offset: 0x00008B63
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTopLevelNameRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTopLevelNameRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

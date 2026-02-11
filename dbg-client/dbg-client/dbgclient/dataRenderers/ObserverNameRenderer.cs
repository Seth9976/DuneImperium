using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using voodoo;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000BC RID: 188
	public class ObserverNameRenderer : VersionedDataComponentObserver<NameLookup>
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x000359FC File Offset: 0x00033BFC
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverNameRenderer()
		{
			Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "ObserverNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr);
			ObserverNameRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr, "text");
			ObserverNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr, 100664454);
			ObserverNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr, 100664455);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00035A68 File Offset: 0x00033C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504514, XrefRangeEnd = 504516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00035AA4 File Offset: 0x00033CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504519, RefRangeEnd = 504520, XrefRangeStart = 504516, XrefRangeEnd = 504519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0000595E File Offset: 0x00003B5E
		public ObserverNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00035AE0 File Offset: 0x00033CE0
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00005967 File Offset: 0x00003B67
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverNameRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverNameRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

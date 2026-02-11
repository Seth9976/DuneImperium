using System;
using dwd.canis.lib.canis.dbg_client.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace dwd.canis.lib.canis.dbg_client.dataRenderers
{
	// Token: 0x0200005B RID: 91
	public class SelectableActiveSubscriber : VersionedSubscriber<SelectableActiveData>
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00028A14 File Offset: 0x00026C14
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableActiveSubscriber()
		{
			Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataRenderers", "SelectableActiveSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr);
			SelectableActiveSubscriber.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr, "selectable");
			SelectableActiveSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr, 100663841);
			SelectableActiveSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr, 100663842);
			SelectableActiveSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr, 100663843);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00028A94 File Offset: 0x00026C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499853, XrefRangeEnd = 499858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableActiveSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499858, XrefRangeEnd = 499861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableActiveSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00028B0C File Offset: 0x00026D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499861, XrefRangeEnd = 499864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableActiveSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableActiveSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003861 File Offset: 0x00001A61
		public SelectableActiveSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00028B48 File Offset: 0x00026D48
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000386A File Offset: 0x00001A6A
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveSubscriber.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveSubscriber.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

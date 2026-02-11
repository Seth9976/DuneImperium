using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.dataRenderers
{
	// Token: 0x02000159 RID: 345
	public class SubscriberImageRenderer : VersionedSubscriber<ImageLookup>
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x0004EDD4 File Offset: 0x0004CFD4
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberImageRenderer()
		{
			Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SubscriberImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr);
			SubscriberImageRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr, "assetPathFormat");
			SubscriberImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr, "image");
			SubscriberImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr, 100665521);
			SubscriberImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr, 100665522);
			SubscriberImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr, 100665523);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0004EE68 File Offset: 0x0004D068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513403, XrefRangeEnd = 513407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0004EEA4 File Offset: 0x0004D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513407, XrefRangeEnd = 513413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004EEE0 File Offset: 0x0004D0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513413, XrefRangeEnd = 513419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000097CC File Offset: 0x000079CC
		public SubscriberImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004EF1C File Offset: 0x0004D11C
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000097D5 File Offset: 0x000079D5
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004EF44 File Offset: 0x0004D144
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x000097F4 File Offset: 0x000079F4
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

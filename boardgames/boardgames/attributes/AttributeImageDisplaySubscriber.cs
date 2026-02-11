using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.attributes
{
	// Token: 0x02000160 RID: 352
	public class AttributeImageDisplaySubscriber : AttributeSubscriber
	{
		// Token: 0x060011E6 RID: 4582 RVA: 0x000480F4 File Offset: 0x000462F4
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeImageDisplaySubscriber()
		{
			Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeImageDisplaySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr);
			AttributeImageDisplaySubscriber.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, "atlasName");
			AttributeImageDisplaySubscriber.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, "spriteNameFormat");
			AttributeImageDisplaySubscriber.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, "image");
			AttributeImageDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, 100665928);
			AttributeImageDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, 100665929);
			AttributeImageDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr, 100665930);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0004819C File Offset: 0x0004639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000509, XrefRangeEnd = 1000513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeImageDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000481D8 File Offset: 0x000463D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000513, XrefRangeEnd = 1000531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeImageDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00048214 File Offset: 0x00046414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000531, XrefRangeEnd = 1000539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeImageDisplaySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeImageDisplaySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeImageDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0000A5C5 File Offset: 0x000087C5
		public AttributeImageDisplaySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00048250 File Offset: 0x00046450
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x0000A5CE File Offset: 0x000087CE
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00048278 File Offset: 0x00046478
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x0000A5ED File Offset: 0x000087ED
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000482A0 File Offset: 0x000464A0
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000A60C File Offset: 0x0000880C
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplaySubscriber.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

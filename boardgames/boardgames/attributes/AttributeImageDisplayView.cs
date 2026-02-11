using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.attributes
{
	// Token: 0x0200015D RID: 349
	public class AttributeImageDisplayView : AttributeView
	{
		// Token: 0x060011B9 RID: 4537 RVA: 0x00047838 File Offset: 0x00045A38
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeImageDisplayView()
		{
			Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeImageDisplayView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr);
			AttributeImageDisplayView.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, "atlasName");
			AttributeImageDisplayView.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, "spriteNameFormat");
			AttributeImageDisplayView.NativeFieldInfoPtr_assignSpriteIfNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, "assignSpriteIfNotFound");
			AttributeImageDisplayView.NativeFieldInfoPtr_onSpriteAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, "onSpriteAssigned");
			AttributeImageDisplayView.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, "image");
			AttributeImageDisplayView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, 100665911);
			AttributeImageDisplayView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr, 100665912);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000478F4 File Offset: 0x00045AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000373, XrefRangeEnd = 1000395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeImageDisplayView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00047930 File Offset: 0x00045B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000395, XrefRangeEnd = 1000408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeImageDisplayView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeImageDisplayView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeImageDisplayView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0000A45D File Offset: 0x0000865D
		public AttributeImageDisplayView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0004796C File Offset: 0x00045B6C
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000A466 File Offset: 0x00008666
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00047994 File Offset: 0x00045B94
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0000A485 File Offset: 0x00008685
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000479BC File Offset: 0x00045BBC
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0000A4A4 File Offset: 0x000086A4
		public unsafe bool assignSpriteIfNotFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_assignSpriteIfNotFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_assignSpriteIfNotFound)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x000479E4 File Offset: 0x00045BE4
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0000A4BF File Offset: 0x000086BF
		public unsafe BoolUnityEvents onSpriteAssigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_onSpriteAssigned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_onSpriteAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00047A14 File Offset: 0x00045C14
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0000A4DE File Offset: 0x000086DE
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeImageDisplayView.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_assignSpriteIfNotFound;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_onSpriteAssigned;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

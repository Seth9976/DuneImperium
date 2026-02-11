using System;
using boardgames.attributes;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm
{
	// Token: 0x0200003F RID: 63
	public class PlayerDictAttributeStringRenderer : AttributeView
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00021380 File Offset: 0x0001F580
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDictAttributeStringRenderer()
		{
			Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "PlayerDictAttributeStringRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr);
			PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, "format");
			PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, "entities");
			PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, "textField");
			PlayerDictAttributeStringRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, 100663740);
			PlayerDictAttributeStringRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, 100663741);
			PlayerDictAttributeStringRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr, 100663742);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00021428 File Offset: 0x0001F628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690637, XrefRangeEnd = 690642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDictAttributeStringRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00021464 File Offset: 0x0001F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690642, XrefRangeEnd = 690668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDictAttributeStringRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000214A0 File Offset: 0x0001F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690668, XrefRangeEnd = 690673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDictAttributeStringRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDictAttributeStringRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDictAttributeStringRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000340A File Offset: 0x0000160A
		public PlayerDictAttributeStringRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000214DC File Offset: 0x0001F6DC
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00003413 File Offset: 0x00001613
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00021504 File Offset: 0x0001F704
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00003432 File Offset: 0x00001632
		public unsafe DBGEntitiesProvider entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00021534 File Offset: 0x0001F734
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00003451 File Offset: 0x00001651
		public unsafe TMP_Text textField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_textField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDictAttributeStringRenderer.NativeFieldInfoPtr_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_textField;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

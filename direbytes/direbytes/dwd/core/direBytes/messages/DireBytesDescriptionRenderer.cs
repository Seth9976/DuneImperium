using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace dwd.core.direBytes.messages
{
	// Token: 0x02000015 RID: 21
	public class DireBytesDescriptionRenderer : Subscriber<BasicDescription>
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000063BC File Offset: 0x000045BC
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesDescriptionRenderer()
		{
			Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireBytesDescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr);
			DireBytesDescriptionRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr, "text");
			DireBytesDescriptionRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr, 100663419);
			DireBytesDescriptionRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr, 100663420);
			DireBytesDescriptionRenderer.NativeMethodInfoPtr_updateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr, 100663421);
			DireBytesDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr, 100663422);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006450 File Offset: 0x00004650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234933, XrefRangeEnd = 1234935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesDescriptionRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000648C File Offset: 0x0000468C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234935, XrefRangeEnd = 1234939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesDescriptionRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000064C8 File Offset: 0x000046C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234975, RefRangeEnd = 1234977, XrefRangeStart = 1234939, XrefRangeEnd = 1234975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesDescriptionRenderer.NativeMethodInfoPtr_updateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000064FC File Offset: 0x000046FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234977, XrefRangeEnd = 1234980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesDescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesDescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000274B File Offset: 0x0000094B
		public DireBytesDescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00006538 File Offset: 0x00004738
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002754 File Offset: 0x00000954
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesDescriptionRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesDescriptionRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_updateText_Private_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace dwd.core.direBytes.messages
{
	// Token: 0x02000016 RID: 22
	public class DireBytesNameRenderer : Subscriber<BasicName>
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00006568 File Offset: 0x00004768
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesNameRenderer()
		{
			Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireBytesNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr);
			DireBytesNameRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr, "text");
			DireBytesNameRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr, 100663423);
			DireBytesNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr, 100663424);
			DireBytesNameRenderer.NativeMethodInfoPtr_updateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr, 100663425);
			DireBytesNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr, 100663426);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000065FC File Offset: 0x000047FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234980, XrefRangeEnd = 1234982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesNameRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006638 File Offset: 0x00004838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234982, XrefRangeEnd = 1234986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006674 File Offset: 0x00004874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235000, RefRangeEnd = 1235002, XrefRangeStart = 1234986, XrefRangeEnd = 1235000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesNameRenderer.NativeMethodInfoPtr_updateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000066A8 File Offset: 0x000048A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235002, XrefRangeEnd = 1235005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002773 File Offset: 0x00000973
		public DireBytesNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000066E4 File Offset: 0x000048E4
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000277C File Offset: 0x0000097C
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesNameRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesNameRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_updateText_Private_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

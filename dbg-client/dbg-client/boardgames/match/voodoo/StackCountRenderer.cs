using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using voodoo;

namespace boardgames.match.voodoo
{
	// Token: 0x02000248 RID: 584
	public class StackCountRenderer : VersionedDataComponentObserver<StackCountData>
	{
		// Token: 0x06001A7C RID: 6780 RVA: 0x00073E84 File Offset: 0x00072084
		// Note: this type is marked as 'beforefieldinit'.
		static StackCountRenderer()
		{
			Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.voodoo", "StackCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr);
			StackCountRenderer.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr, "format");
			StackCountRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr, "text");
			StackCountRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr, 100667519);
			StackCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr, 100667520);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00073F04 File Offset: 0x00072104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532011, XrefRangeEnd = 532015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackCountRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00073F40 File Offset: 0x00072140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532015, XrefRangeEnd = 532022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0000E78C File Offset: 0x0000C98C
		public StackCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00073F7C File Offset: 0x0007217C
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0000E795 File Offset: 0x0000C995
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountRenderer.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountRenderer.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00073FA4 File Offset: 0x000721A4
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

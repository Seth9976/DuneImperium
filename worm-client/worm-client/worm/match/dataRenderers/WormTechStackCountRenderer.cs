using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000169 RID: 361
	public class WormTechStackCountRenderer : VersionedView<IAttribute<Nullable<int>>>
	{
		// Token: 0x0600101B RID: 4123 RVA: 0x00048704 File Offset: 0x00046904
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechStackCountRenderer()
		{
			Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTechStackCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr);
			WormTechStackCountRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr, "text");
			WormTechStackCountRenderer.NativeFieldInfoPtr_StackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr, "StackIndex");
			WormTechStackCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr, 100665480);
			WormTechStackCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr, 100665481);
			WormTechStackCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr, 100665482);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00048798 File Offset: 0x00046998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708986, XrefRangeEnd = 709007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechStackCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000487D4 File Offset: 0x000469D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709007, XrefRangeEnd = 709019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechStackCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00048810 File Offset: 0x00046A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709019, XrefRangeEnd = 709022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechStackCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechStackCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechStackCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0000A7AA File Offset: 0x000089AA
		public WormTechStackCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0004884C File Offset: 0x00046A4C
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x0000A7B3 File Offset: 0x000089B3
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechStackCountRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechStackCountRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0004887C File Offset: 0x00046A7C
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0000A7D2 File Offset: 0x000089D2
		public unsafe int StackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechStackCountRenderer.NativeFieldInfoPtr_StackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechStackCountRenderer.NativeFieldInfoPtr_StackIndex)) = value;
			}
		}

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_StackIndex;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

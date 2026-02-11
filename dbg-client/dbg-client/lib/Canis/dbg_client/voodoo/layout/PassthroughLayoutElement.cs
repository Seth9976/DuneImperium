using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace lib.canis.dbg_client.voodoo.layout
{
	// Token: 0x02000036 RID: 54
	public class PassthroughLayoutElement : UIBehaviour
	{
		// Token: 0x06000219 RID: 537 RVA: 0x00024328 File Offset: 0x00022528
		// Note: this type is marked as 'beforefieldinit'.
		static PassthroughLayoutElement()
		{
			Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.voodoo.layout", "PassthroughLayoutElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr);
			PassthroughLayoutElement.NativeMethodInfoPtr_getChildLayoutElement_Private_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663624);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663625);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663626);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663627);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663628);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663629);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663630);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663631);
			PassthroughLayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663632);
			PassthroughLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663633);
			PassthroughLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663634);
			PassthroughLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr, 100663635);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00024448 File Offset: 0x00022648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498023, XrefRangeEnd = 498028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutElement getChildLayoutElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_getChildLayoutElement_Private_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr3) : null;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00024488 File Offset: 0x00022688
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498028, XrefRangeEnd = 498032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000244C4 File Offset: 0x000226C4
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498032, XrefRangeEnd = 498036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00024500 File Offset: 0x00022700
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498036, XrefRangeEnd = 498040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0002453C File Offset: 0x0002273C
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498040, XrefRangeEnd = 498044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00024578 File Offset: 0x00022778
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498044, XrefRangeEnd = 498048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000245B4 File Offset: 0x000227B4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498048, XrefRangeEnd = 498052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000245F0 File Offset: 0x000227F0
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498052, XrefRangeEnd = 498056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0002462C File Offset: 0x0002282C
		public unsafe virtual bool ignoreLayout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498056, XrefRangeEnd = 498060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00024668 File Offset: 0x00022868
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassthroughLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000246A4 File Offset: 0x000228A4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassthroughLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000246E0 File Offset: 0x000228E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassthroughLayoutElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassthroughLayoutElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassthroughLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002EA8 File Offset: 0x000010A8
		public PassthroughLayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_getChildLayoutElement_Private_LayoutElement_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

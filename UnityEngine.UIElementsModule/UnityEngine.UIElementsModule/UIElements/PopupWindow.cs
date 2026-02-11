using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007E RID: 126
	public class PopupWindow : TextElement
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x00049A44 File Offset: 0x00047C44
		// Note: this type is marked as 'beforefieldinit'.
		static PopupWindow()
		{
			Il2CppClassPointerStore<PopupWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PopupWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr);
			PopupWindow.NativeFieldInfoPtr_m_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, "m_ContentContainer");
			PopupWindow.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, "ussClassName");
			PopupWindow.NativeFieldInfoPtr_contentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, "contentUssClassName");
			PopupWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, 100665116);
			PopupWindow.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, 100665117);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00049AD8 File Offset: 0x00047CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302835, XrefRangeEnd = 302855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00049B14 File Offset: 0x00047D14
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupWindow.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00006A8A File Offset: 0x00004C8A
		public PopupWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00049B60 File Offset: 0x00047D60
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00006A93 File Offset: 0x00004C93
		public unsafe VisualElement m_ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupWindow.NativeFieldInfoPtr_m_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupWindow.NativeFieldInfoPtr_m_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00049B90 File Offset: 0x00047D90
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00006AB2 File Offset: 0x00004CB2
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PopupWindow.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PopupWindow.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00049BB0 File Offset: 0x00047DB0
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public unsafe static string contentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PopupWindow.NativeFieldInfoPtr_contentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PopupWindow.NativeFieldInfoPtr_contentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentContainer;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_contentUssClassName;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x020003B0 RID: 944
		public new class UxmlFactory : UxmlFactory<PopupWindow, PopupWindow.UxmlTraits>
		{
			// Token: 0x0600391A RID: 14618 RVA: 0x00017E40 File Offset: 0x00016040
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<PopupWindow.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupWindow.UxmlFactory>.NativeClassPtr);
				PopupWindow.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupWindow.UxmlFactory>.NativeClassPtr, 100665119);
			}

			// Token: 0x0600391B RID: 14619 RVA: 0x000E8710 File Offset: 0x000E6910
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302834, RefRangeEnd = 302835, XrefRangeStart = 302831, XrefRangeEnd = 302834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupWindow.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupWindow.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600391C RID: 14620 RVA: 0x00017E74 File Offset: 0x00016074
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002876 RID: 10358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003B1 RID: 945
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x0600391D RID: 14621 RVA: 0x00017E7D File Offset: 0x0001607D
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<PopupWindow.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PopupWindow>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupWindow.UxmlTraits>.NativeClassPtr);
				PopupWindow.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupWindow.UxmlTraits>.NativeClassPtr, 100665120);
			}

			// Token: 0x0600391E RID: 14622 RVA: 0x000E874C File Offset: 0x000E694C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupWindow.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupWindow.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600391F RID: 14623 RVA: 0x00017EB1 File Offset: 0x000160B1
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002877 RID: 10359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200058C RID: 1420
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}
	}
}

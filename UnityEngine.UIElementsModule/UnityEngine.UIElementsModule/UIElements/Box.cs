using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004C RID: 76
	public class Box : VisualElement
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00037F48 File Offset: 0x00036148
		// Note: this type is marked as 'beforefieldinit'.
		static Box()
		{
			Il2CppClassPointerStore<Box>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Box");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Box>.NativeClassPtr);
			Box.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Box>.NativeClassPtr, "ussClassName");
			Box.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Box>.NativeClassPtr, 100664312);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00037FA0 File Offset: 0x000361A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292117, XrefRangeEnd = 292126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Box()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Box>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Box.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00004931 File Offset: 0x00002B31
		public Box(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00037FDC File Offset: 0x000361DC
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0000493A File Offset: 0x00002B3A
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Box.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Box.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000345 RID: 837
		public new class UxmlFactory : UxmlFactory<Box>
		{
			// Token: 0x06003652 RID: 13906 RVA: 0x00016401 File Offset: 0x00014601
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Box.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Box>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Box.UxmlFactory>.NativeClassPtr);
				Box.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Box.UxmlFactory>.NativeClassPtr, 100664314);
			}

			// Token: 0x06003653 RID: 13907 RVA: 0x000E04FC File Offset: 0x000DE6FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292116, RefRangeEnd = 292117, XrefRangeStart = 292113, XrefRangeEnd = 292116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Box.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Box.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003654 RID: 13908 RVA: 0x00016435 File Offset: 0x00014635
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026EE RID: 9966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

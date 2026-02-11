using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000205 RID: 517
	public class UxmlTraits : BaseUxmlTraits
	{
		// Token: 0x06002802 RID: 10242 RVA: 0x000B0014 File Offset: 0x000AE214
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlTraits()
		{
			Il2CppClassPointerStore<UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlTraits>.NativeClassPtr);
			UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTraits>.NativeClassPtr, 100669321);
			UxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTraits>.NativeClassPtr, 100669322);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000B006C File Offset: 0x000AE26C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000B00E4 File Offset: 0x000AE2E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 344029, RefRangeEnd = 344037, XrefRangeStart = 344029, XrefRangeEnd = 344037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000102CF File Offset: 0x0000E4CF
		public UxmlTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace lotus
{
	// Token: 0x02000058 RID: 88
	public class HiddenPile : ContainerView
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x0001AD14 File Offset: 0x00018F14
		// Note: this type is marked as 'beforefieldinit'.
		static HiddenPile()
		{
			Il2CppClassPointerStore<HiddenPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "HiddenPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr);
			HiddenPile.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr, 100663972);
			HiddenPile.NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr, 100663973);
			HiddenPile.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr, 100663974);
			HiddenPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr, 100663975);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001AD94 File Offset: 0x00018F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111568, XrefRangeEnd = 1111574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetPositionsFor(MoveContext context, Il2CppStructArray<LocalTransform> retVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HiddenPile.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111574, XrefRangeEnd = 1111577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddView(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HiddenPile.NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001AE50 File Offset: 0x00019050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111577, XrefRangeEnd = 1111616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HiddenPile.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001AE8C File Offset: 0x0001908C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690714, RefRangeEnd = 690716, XrefRangeStart = 690714, XrefRangeEnd = 690716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HiddenPile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HiddenPile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000049DD File Offset: 0x00002BDD
		public HiddenPile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

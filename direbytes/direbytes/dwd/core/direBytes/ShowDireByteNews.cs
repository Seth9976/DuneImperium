using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.direBytes
{
	// Token: 0x02000012 RID: 18
	public class ShowDireByteNews : MonoBehaviour
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00005C7C File Offset: 0x00003E7C
		// Note: this type is marked as 'beforefieldinit'.
		static ShowDireByteNews()
		{
			Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "ShowDireByteNews");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr);
			ShowDireByteNews.NativeMethodInfoPtr_AttemptShowSubpage_Public_Void_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663403);
			ShowDireByteNews.NativeMethodInfoPtr_HideSubpage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663404);
			ShowDireByteNews.NativeMethodInfoPtr_preventShowing_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663405);
			ShowDireByteNews.NativeMethodInfoPtr_showSubpage_Protected_Abstract_Virtual_New_Void_DireByteTileNewsSubpageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663406);
			ShowDireByteNews.NativeMethodInfoPtr_hideSubpage_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663407);
			ShowDireByteNews.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr, 100663408);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005D24 File Offset: 0x00003F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234840, XrefRangeEnd = 1234871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttemptShowSubpage(SubscriptionProvider subpageDataOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subpageDataOrigin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDireByteNews.NativeMethodInfoPtr_AttemptShowSubpage_Public_Void_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005D68 File Offset: 0x00003F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideSubpage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDireByteNews.NativeMethodInfoPtr_HideSubpage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005D9C File Offset: 0x00003F9C
		[CallerCount(0)]
		public unsafe virtual bool preventShowing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireByteNews.NativeMethodInfoPtr_preventShowing_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005DE4 File Offset: 0x00003FE4
		[CallerCount(0)]
		public unsafe virtual void showSubpage(DireByteTileNewsSubpageData subpageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subpageData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireByteNews.NativeMethodInfoPtr_showSubpage_Protected_Abstract_Virtual_New_Void_DireByteTileNewsSubpageData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005E34 File Offset: 0x00004034
		[CallerCount(0)]
		public unsafe virtual void hideSubpage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireByteNews.NativeMethodInfoPtr_hideSubpage_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005E70 File Offset: 0x00004070
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowDireByteNews()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowDireByteNews>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDireByteNews.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002695 File Offset: 0x00000895
		public ShowDireByteNews(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_AttemptShowSubpage_Public_Void_SubscriptionProvider_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_HideSubpage_Public_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_preventShowing_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_showSubpage_Protected_Abstract_Virtual_New_Void_DireByteTileNewsSubpageData_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_hideSubpage_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
